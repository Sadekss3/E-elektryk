using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_elektryk
{

    public partial class Window_Choice_Client_For_Offer : Form
    {
        kontrahent _k;
        public Window_Choice_Client_For_Offer(kontrahent k)
        {
            InitializeComponent();
            Client_List_Update();
            _k = k;
        }

        private void Client_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Client_list.Items.Clear();
                    List<kontrahent> list = db.kontrahent.ToList();
                    foreach (kontrahent C in list.Where(lvi => lvi.Nazwa_Firmy.ToLower().Contains(textBox4.Text.ToLower()) && lvi.Nazwisko.ToLower().Contains(textBox5.Text.ToLower()) && lvi.ID.ToString().ToLower().Contains(textBox6.Text.ToLower())))
                    {
                        ListViewItem item = new ListViewItem(C.ID.ToString());
                        item.SubItems.Add(C.Imie);
                        item.SubItems.Add(C.Nazwisko);
                        item.SubItems.Add(C.Pesel.ToString());
                        item.SubItems.Add(C.NIP.ToString());
                        item.SubItems.Add(C.Nazwa_Firmy);
                        if (C.Adres != 0)
                        {
                            adres Client_Adress = new adres();
                            Client_Adress = db.adres.Find(C.Adres);
                            if (Client_Adress.Numer_mieszkania == null)
                            {
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", " + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString()
                                + " " + Client_Adress.Państwo.ToString());
                            }
                            else
                            {
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", " + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString()
                                + "/" + Client_Adress.Numer_mieszkania.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                        }
                        item.SubItems.Add(C.E_mail);
                        item.SubItems.Add(C.Telefon_1.ToString());
                        item.SubItems.Add(C.Telefon_2.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Client_list.Items.Add(item);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Clients information from DB to listView 

        private void Client_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = Client_list.SelectedItems[0];
            int ID = System.Convert.ToInt32(item.Text);   
            _k.ID = ID;
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Client_List_Update();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_New_Address_Click(object sender, EventArgs e)
        {
            var Adress = new adres();
            var kontrahent = new kontrahent();
            Boolean flag = false;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    kontrahent.Imie = textBox_imie.Text.ToString();
                    kontrahent.Nazwisko = textBox_nazwisko.Text.ToString();
                    if (textBox_pesel.Text == "")
                        kontrahent.Pesel = null;
                    else
                        kontrahent.Pesel = System.Convert.ToInt64(textBox_pesel.Text);
                    if (textBox_nip.Text == "")
                        kontrahent.NIP = null;
                    else
                        kontrahent.NIP = System.Convert.ToInt64(textBox_nip.Text);

                    kontrahent.Nazwa_Firmy = textBox_firma.Text.ToString();
                    Adress.Miasto = textBox_town.Text;
                    Adress.Nazwa_ulicy = textBox_street.Text;
                    Adress.Kod_pocztowy = textBox_kod_1.Text + textBox_kod_2.Text;
                    Adress.Numer_budynku = textBox_building.Text;
                    Adress.Numer_mieszkania = textBox_home.Text;
                    Adress.Państwo = comboBox1.Text;
                    db.adres.Add(Adress);
                    db.SaveChanges();
                    kontrahent.E_mail = textBox_email.Text.ToString();
                    kontrahent.Telefon_1 = textBox_tel.Text.ToString();
                    kontrahent.Telefon_2 = textBox_tel2.Text.ToString();
                    kontrahent.Adres = Adress.ID;
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano nieprawidłowy numer NIP lub PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                if (flag == true)
                {
                    db.kontrahent.Add(kontrahent);
                    db.SaveChanges();
                    MessageBox.Show("Kontrahent dodany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
