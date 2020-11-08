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
        int Selected_Product_ID;

        public main_Window()
        {
            login();
            InitializeComponent();
        }

        void login()
        {
            Login login_window = new Login();
            login_window.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu_Design();
            //Product_List_Update();
            //Client_List_Update();
            //Offer_List_Update();
        }

        /*private void Product_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
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
            Cursor.Current = Cursors.Default;
        } // Add Products information from DB to listView*/

        /*private void Button_Add_Click(object sender, EventArgs e)
        {
            Window_Add_Product window_add = new Window_Add_Product();
            window_add.ShowDialog();
        } // Add new Product*/

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

        /*private void Client_List_Update()
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
                catch (Exception f)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Clients information from DB to listView */

        /*private void Button_Add_Client_Click(object sender, EventArgs e) // Add new Client
        {
            Window_Add_Client Add_Client = new Window_Add_Client();
            Add_Client.ShowDialog();
        }*/

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

        /*private void Offer_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Offer_list.Items.Clear();
                    List<oferta> list = db.oferta.ToList();
                    foreach (oferta o in list.Where(lvi => lvi.Nazwa.ToLower().Contains(Offer_Search_Offer_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Id_zleceniodawca).Nazwa_Firmy.ToLower().Contains(Offer_Search_Client_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Id_zleceniodawca).ID.ToString().Contains(Offer_Search_Client_ID.Text)))
                    {
                        ListViewItem item = new ListViewItem(o.ID.ToString());
                        item.SubItems.Add(o.Nazwa);
                        item.SubItems.Add(db.kontrahent.Find(o.Id_zleceniodawca).Nazwa_Firmy);
                        item.SubItems.Add(db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Miasto);
                        item.SubItems.Add(o.Data_Od.ToString().Remove(10, 9));
                        item.SubItems.Add(o.Data_Do.ToString().Remove(10, 9));
                        item.SubItems.Add(o.Status);
                        item.SubItems.Add(o.Opis.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Offer_list.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        } // Update Offer information from DB to listView*/

        /*private void Button_Add_Offer_Click(object sender, EventArgs e)
        {
                Window_Add_Offer offer = new Window_Add_Offer();
                offer.ShowDialog();
        } // Add new offer*/

        private void Button_Modify_Offer_Click(object sender, EventArgs e)
        {
            if (Offer_list.SelectedItems.Count > 0)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    string ID = Offer_list.SelectedItems[0].Text;
                    int Offer_ID = System.Convert.ToInt32(ID);
                    oferta o = db.oferta.Find(Offer_ID);
                    Window_Add_Offer Modify_Offer = new Window_Add_Offer(o);
                    Modify_Offer.ShowDialog();
                }
            }
        } // Modify offer information

        /*        private void Offer_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Position_In_Offer_ListView.Items.Clear();
                    string id_offer = Offer_list.SelectedItems[0].Text;
                    Position_In_Offer_ListView.Items.Clear();
                    List<produkty_w_wycenie> list = db.produkty_w_wycenie.ToList();
                    foreach (produkty_w_wycenie p in list.Where(id => id.ID_zlecenie.ToString() == id_offer))
                    {
                        ListViewItem item = new ListViewItem(p.ID_produktu.ToString());
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Nazwa);
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Producent);
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Numer_katalogowy);
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Jm);
                        decimal ilość = p.ilość;
                        item.SubItems.Add(ilość.ToString());
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Cena_netto.ToString() + " zł");
                        item.SubItems.Add(db.produkt.Find(p.ID_produktu).Vat.ToString() + "%");
                        decimal brutto = db.produkt.Find(p.ID_produktu).Cena_brutto;
                        item.SubItems.Add(brutto.ToString() + " zł");
                        item.SubItems.Add(db.kategoria_produktu.Find(db.produkt.Find(p.ID_produktu).Kategoria).Nazwa_kategorii);
                        item.SubItems.Add(Math.Round(ilość * brutto, 2).ToString() + " zł");
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Position_In_Offer_ListView.Items.Add(item);
                    }
                    Calculate_tax_price();
                }
                catch (Exception f)
                {
                }
            }
        } // Fill actual Offer products list
        
        void Calculate_tax_price()
        {
            decimal sum_w_taxes = 0;
            for (int i = 0; i <= Position_In_Offer_ListView.Items.Count; i++)
            {
                sum_w_taxes += System.Convert.ToDecimal((Position_In_Offer_ListView.Items[i].SubItems[10].Text).Trim(' ', 'z', 'ł'));
                sum_w_taxes = Math.Round(sum_w_taxes, 2);
                sum_w_taxes_label_2.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
            }
        } // Calculate gross price for offer*/

        private void button_Exit_Window_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        } // Exit Program

        private void button_minimalize_window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } // Minimalize Window

        private void Menu_Design()
        {
            panel_Order.Visible = false;
            panel_Offer.Visible = false;
            panel_Client.Visible = false;
            panel_Product.Visible = false;
            panel_Invoice.Visible = false;
        }

        private void Hide_Sub_Menu()
        {
            if (panel_Order.Visible == true)
                panel_Order.Visible = false;
            if (panel_Offer.Visible == true)
                panel_Offer.Visible = false;
            if (panel_Client.Visible == true)
                panel_Client.Visible = false;
            if (panel_Product.Visible == true)
                panel_Product.Visible = false;
            if (panel_Invoice.Visible == true)
                panel_Invoice.Visible = false;
        }

        private void Show_Sub_Menu(Panel panel)
        {
            if (panel.Visible == false)
            {
                Hide_Sub_Menu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order_window());
            Show_Sub_Menu(panel_Order);
        } // Open Order Window

        private void button_Offer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Offer_Window());
            Show_Sub_Menu(panel_Offer);
        } // Open Offer Window

        private void button_Client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Window());
            Show_Sub_Menu(panel_Client);
        } // Open Client Window

        private void button_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product_Window(Selected_Product_ID));
            Show_Sub_Menu(panel_Product);
        } // Open Product Window

        private void button_Invoice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice_Window());
            Show_Sub_Menu(panel_Invoice);
        } // Open Invoice Widnow

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main_Window.Controls.Add(childForm);
            panel_Main_Window.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } // Open new window in main window panel

        private void button_New_Offer_Click(object sender, EventArgs e) // Open New Offer Window
        {
            OpenChildForm(new Window_Add_Offer());
            Hide_Sub_Menu();
        }

        private void Button_New_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Window_Add_Product());
            Hide_Sub_Menu();
        } // Open New Product Window

        private void Buton_New_client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Window_Add_Client());
            Hide_Sub_Menu();
        } // Open New Client Window

        private void button_Modify_Product_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Selected_Product_ID.ToString());
            //OpenChildForm(new Window_Add_Product(Selected_Product_ID));   
        }
    }
}
