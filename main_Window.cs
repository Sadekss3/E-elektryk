using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_elektryk
{
    public partial class main_Window : Form
    {
        public main_Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product_List_Update();
            Client_List_Update();
            Offer_List_Update();
        }

        private void Product_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Products_list.Items.Clear();
                    List<produkt> list = db.produkt.ToList();
                    foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_product_name_search.Text.ToLower()) && lvi.Producent.ToLower().Contains(textBox_product_producent_search.Text.ToLower()) && lvi.Numer_katalogowy.ToLower().Contains(textBox_product_symbol_search.Text.ToLower())))
                    {
                        decimal value = Math.Round(p.Cena_netto * System.Convert.ToDecimal(p.Ilość), 2);
                        ListViewItem item = new ListViewItem(p.ID.ToString());
                        item.SubItems.Add(p.Nazwa);
                        item.SubItems.Add(p.Producent);
                        item.SubItems.Add(p.Numer_katalogowy);
                        item.SubItems.Add(p.Jm);
                        item.SubItems.Add(p.Ilość.ToString());
                        item.SubItems.Add(p.Cena_netto.ToString() + " zł");
                        item.SubItems.Add(p.Vat.ToString() + " %");
                        item.SubItems.Add(p.Cena_brutto.ToString() + " zł");
                        if (p.Kategoria != 0)
                        {
                            kategoria_produktu product_cat = new kategoria_produktu();
                            product_cat = db.kategoria_produktu.Find(p.Kategoria);
                            item.SubItems.Add(product_cat.Nazwa_kategorii.ToString());
                        }
                        item.SubItems.Add(value.ToString() + " zł");
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Products_list.Items.Add(item);
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Brak połączenia do bazy danych", "Błąd Bazy Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
        } // Add Products information from DB to listView

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Window_Add_Product window_add = new Window_Add_Product();
            window_add.ShowDialog();
        } // Add new Product

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            if (Products_list.SelectedItems.Count > 0)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    string ID = Products_list.SelectedItems[0].Text;
                    int numer_ID = System.Convert.ToInt32(ID);
                    produkt m = db.produkt.Find(numer_ID);
                    Window_Add_Product mod = new Window_Add_Product(m);
                    mod.ShowDialog();
                }
            }
        } // Modify Product

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (Products_list.SelectedItems.Count > 0)
            {
                string ID = Products_list.SelectedItems[0].Text;
                int ID_number = System.Convert.ToInt32(ID);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Czy na pewno chcesz usunąć pozycje?", "Usuwanie", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (zlecenieEntities db = new zlecenieEntities())
                    {
                        produkt p = db.produkt.Find(ID_number);
                        string name_p = p.Nazwa;
                        db.produkt.Remove(p);
                        db.SaveChanges();
                        MessageBox.Show("Produkt " + name_p + " usunięty", "OK", MessageBoxButtons.OK);
                    }
                }
            }
        } // Delete product 

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
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3)+ "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", " 
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                            else
                            {
                                item.SubItems.Add(Client_Adress.Miasto.ToString() + " " + Client_Adress.Kod_pocztowy.ToString().Remove(2, 3) + "-" + Client_Adress.Kod_pocztowy.ToString().Remove(0, 2) + ", " 
                                    + Client_Adress.Nazwa_ulicy.ToString() + " " + Client_Adress.Numer_budynku.ToString() +"/"+ Client_Adress.Numer_mieszkania.ToString() + " " + Client_Adress.Państwo.ToString());
                            }
                        }
                        item.SubItems.Add(C.E_mail);
                        item.SubItems.Add(C.Telefon_1.ToString());
                        item.SubItems.Add(C.Telefon_2.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Client_list.Items.Add(item);
                    }
                }
                catch (Exception f)
                {
                    Environment.Exit(1);
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Clients information from DB to listView 

        private void Button_Add_Client_Click(object sender, EventArgs e) // Add new Client
        {
            Window_Add_Client Add_Client= new Window_Add_Client();
            Add_Client.ShowDialog();
        }

        private void Button_DataMod_Client_Click(object sender, EventArgs e) // Modify Client information
        {
            if (Client_list.SelectedItems.Count > 0)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    string ID = Client_list.SelectedItems[0].Text;
                    int numer_ID_kontrahenta = System.Convert.ToInt32(ID);
                    kontrahent k = db.kontrahent.Find(numer_ID_kontrahenta);
                    Window_Add_Client Modyficate_Client = new Window_Add_Client(k);
                    Modyficate_Client.ShowDialog();
                }
            }
        }

        private void Button_Delete_Client_Click(object sender, EventArgs e) // Delete Client
        {
            if (Client_list.SelectedItems.Count > 0)
            {
                string ID = Client_list.SelectedItems[0].Text;
                int ID_number = System.Convert.ToInt32(ID);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Czy na pewno chcesz usunąć pozycje?", "Usuwanie", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (zlecenieEntities db = new zlecenieEntities())
                    {
                        kontrahent Client = db.kontrahent.Find(ID_number);
                        string Client_name = Client.Imie;
                        string Client_lastname = Client.Nazwisko;
                        db.kontrahent.Remove(Client);
                        db.SaveChanges();
                        MessageBox.Show("Kontrahent " + Client_name + " " + Client_lastname + " został usunięty z listy.", "Ok", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void Offer_List_Update()
        {

        } // Update Offer information from DB to listView

        private void Button_Add_Offer_Click(object sender, EventArgs e)
        {
            Window_Add_Offer offer = new Window_Add_Offer();
            offer.ShowDialog();
        } // Add new offer

        private void Button_Modify_Offer_Click(object sender, EventArgs e)
        {

        }
    }
}
