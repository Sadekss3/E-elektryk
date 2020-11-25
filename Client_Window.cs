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
    public partial class Client_Window : Form
    {
        public Client_Window()
        {
            InitializeComponent();
            Client_List_Update();
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
                    foreach (kontrahent C in list.Where(lvi => lvi.Nazwa_Firmy.ToLower().Contains(textBox_client_company_search.Text.ToLower()) && lvi.Nazwisko.ToLower().Contains(textBox_client_name_search.Text.ToLower()) && lvi.ID.ToString().ToLower().Contains(textBox_client_id_search.Text.ToLower())))
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
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", "
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                            else
                            {
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", "
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() + "/" + Client_Adress.Numer_mieszkania.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                        }
                        item.SubItems.Add(C.E_mail);
                        item.SubItems.Add(C.Telefon_1.ToString());
                        item.SubItems.Add(C.Telefon_2.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Client_list.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Clients information from DB to listView 

        private void textBox_client_company_search_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Client_list.Items.Clear();
                    List<kontrahent> list = db.kontrahent.ToList();
                    foreach (kontrahent C in list.Where(lvi => lvi.Nazwa_Firmy.ToLower().Contains(textBox_client_company_search.Text.ToLower()) && lvi.Nazwisko.ToLower().Contains(textBox_client_name_search.Text.ToLower()) && lvi.ID.ToString().ToLower().Contains(textBox_client_id_search.Text.ToLower())))
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
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", "
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                            else
                            {
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", "
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() + "/" + Client_Adress.Numer_mieszkania.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                        }
                        item.SubItems.Add(C.E_mail);
                        item.SubItems.Add(C.Telefon_1.ToString());
                        item.SubItems.Add(C.Telefon_2.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Client_list.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        } // Search and fill list by input

        public int getSelectedClient()
        {
            int Selected_Client_ID = 0;
            if (Client_list.SelectedItems.Count > 0)
            {
                Selected_Client_ID = System.Convert.ToInt32(Client_list.SelectedItems[0].Text);
            }
            return Selected_Client_ID;
        }
    }
}
