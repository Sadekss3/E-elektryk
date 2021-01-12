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
    public partial class Window_Add_Order : Form
    {
        Boolean show_active_product = false;
        int client_id;
        zlecenie _z;
        string _type;
        adres a;

        public Window_Add_Order()
        {
            InitializeComponent();
            order_number();
            calculate_delay();
            _type = "Add";
        }

        public Window_Add_Order(zlecenie z)
        {
            InitializeComponent();
            _type = "Modify";
            _z = z;
            Button_Add_Order.Text = "Aktualizuj";
            Add_Order_Information();
        }

        private void Add_Order_Information()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                textBox_O_Name.Text = _z.Nazwa;
                textBox_Offer_Name.Text = db.kontrahent.Find(_z.Kontrahent).Imie;
                textBox_Offer_LastName.Text = db.kontrahent.Find(_z.Kontrahent).Nazwisko;
                textBox_Offer_CompanyName.Text = db.kontrahent.Find(_z.Kontrahent).Nazwa_Firmy;
                textBox_Town.Text = db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Miasto;
                textBox_Kod_1.Text = (db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Kod_pocztowy).Remove(2, 3);
                textBox_Kod_2.Text = (db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Kod_pocztowy).Remove(0, 2);
                textBox_Street.Text = db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Nazwa_ulicy;
                textBox_Building_Number.Text = db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Numer_budynku;
                textBox_Home_Number.Text = db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Numer_mieszkania;
                textBox_Country.Text = db.adres.Find(db.kontrahent.Find(_z.Kontrahent).Adres).Państwo;
                Order_Information_Box.Text = _z.Opis;
                dateTimePicker1.Value = _z.Data_od.Date;
                dateTimePicker2.Value = _z.Data_do.Date;
                List<produkty_w_wycenie> list = db.produkty_w_wycenie.ToList();
                foreach (produkty_w_wycenie produkty_W_Wycenie in list.Where(id => id.ID_zlecenie == _z.ID))
                {
                    DataGridViewRow item_grid = new DataGridViewRow();
                    item_grid.CreateCells(dataGridView1);
                    item_grid.Cells[0].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).ID;
                    item_grid.Cells[1].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Nazwa;
                    item_grid.Cells[2].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Producent;
                    item_grid.Cells[3].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Jm;
                    item_grid.Cells[4].Value = produkty_W_Wycenie.ilość;
                    item_grid.Cells[5].Value = produkty_W_Wycenie.Marża;
                    item_grid.Cells[6].Value = produkty_W_Wycenie.Aktualna_cena_netto;
                    item_grid.Cells[7].Value = produkty_W_Wycenie.Aktualna_cena_netto;
                    item_grid.Cells[8].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Vat + " %";
                    item_grid.Cells[9].Value = Math.Round(db.produkt.Find(produkty_W_Wycenie.ID_produktu).Cena_brutto, 2);
                    item_grid.Cells[10].Value = db.kategoria_produktu.Find(db.produkt.Find(produkty_W_Wycenie.ID_produktu).Kategoria).Nazwa_kategorii;
                    item_grid.Cells[11].Value = produkty_W_Wycenie.Zysk_netto;
                    dataGridView1.Rows.Add(item_grid);
                }
            }
        } // Fill offer window with information about actual offer

        private void Window_Add_Order_Load(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                List<produkt> list = db.produkt.ToList();
                listView1.Items.Clear();
                foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_name_search.Text.ToLower().Trim()) && lvi.Producent.ToLower().Contains(textBox_Producent_search.Text.ToLower().Trim()) && lvi.Status.ToString().Contains("1")))
                {
                    ListViewItem item = new ListViewItem(p.ID.ToString());
                    item.SubItems.Add(p.Nazwa.ToLower());
                    item.SubItems.Add(p.Producent.ToString());
                    item.SubItems.Add(p.Jm.ToString());
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
                    item.SubItems.Add(db.statusy_produktów.Find(p.Status).Status);
                    item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
                    listView1.Items.Add(item);
                }
            }
            calculate();
        }

        void Add_to_offer(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                DataGridViewRow item_grid = new DataGridViewRow();
                ListViewItem item = (ListViewItem)listView1.SelectedItems[0].Clone();   // Clone current litView object
                item_grid.CreateCells(dataGridView2);
                item_grid.Cells[0].Value = item.SubItems[0].Text;   // Add to cells ID
                item_grid.Cells[1].Value = item.SubItems[1].Text;   // Add to cells Nazwa
                item_grid.Cells[2].Value = item.SubItems[2].Text;   // Add to cells Producent
                item_grid.Cells[3].Value = item.SubItems[3].Text;   // Add to cells J.m
                decimal lot = 1;
                decimal margin = 0;
                item_grid.Cells[4].Value = lot;  // One piece for every new Product in DataGrid
                item_grid.Cells[5].Value = margin;
                string net_offer = TRIM_price(item.SubItems[5].Text);
                item_grid.Cells[6].Value = System.Convert.ToDecimal(net_offer); // Add decimal one piece net price to cells C.J
                item_grid.Cells[7].Value = System.Convert.ToDecimal(net_offer) * System.Convert.ToDecimal(lot) + " zł"; // Add calculated net price for all pieces
                item_grid.Cells[8].Value = item.SubItems[6].Text;   // Add taxe to cells VAT
                string gross_offer = TRIM_price(item.SubItems[7].Text);
                item_grid.Cells[9].Value = System.Convert.ToDecimal(gross_offer) * System.Convert.ToDecimal(lot) + " zł";   // Add calculated gross price for all pieces
                item_grid.Cells[10].Value = item.SubItems[8].Text;   // Add category name to cells Kategoria
                item_grid.Cells[11].Value = margin;
                dataGridView2.Rows.Add(item_grid);
            }
            calculate();
        }   // Clone listView object and add to dataGrid row

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculate();
        }   // Update dataGrid net and gross price value after enter new quantity value

        private void Button_chose_Client_Click(object sender, EventArgs e)
        {
            try
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    kontrahent k = new kontrahent();
                    Window_Choice_Client_For_Offer window_Choice_Client = new Window_Choice_Client_For_Offer(k);
                    window_Choice_Client.ShowDialog();
                    client_id = k.ID;
                    k = db.kontrahent.Find(k.ID);
                    adres a = new adres();
                    a = db.adres.Find(k.Adres);
                    textBox_Offer_Name.Text = k.Imie.ToString();
                    textBox_Offer_LastName.Text = k.Nazwisko.ToString();
                    textBox_Offer_CompanyName.Text = k.Nazwa_Firmy.ToString();
                }
            }
            catch
            {

            }
        } // Add information about Client to Offer Form

        private void Button_Delete_From_Grid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell selectedcell in dataGridView2.SelectedCells)
            {
                if (selectedcell.Selected)
                {
                    dataGridView2.Rows.RemoveAt(selectedcell.RowIndex);
                }
            }
            calculate();
        } // Delete product from Datagrid

        void Save_Order()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                Cursor.Current = Cursors.WaitCursor;
                zlecenie new_order = new zlecenie();
                try
                {
                    new_order.Nazwa = textBox_O_Name.Text;
                    new_order.Kontrahent = client_id;
                    new_order.Data_od = dateTimePicker1.Value;
                    new_order.Data_do = dateTimePicker2.Value;
                    new_order.Adres_zlecenia = db.adres.Find(a.ID).ID;
                    new_order.Opis = Order_Information_Box.Text;
                    new_order.Status_zlecenia = 1;
                    db.zlecenie.Add(new_order);
                    db.SaveChanges();
                    /*foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        produkty_w_wycenie produkty_W_Wycenie = new produkty_w_wycenie();
                        produkty_W_Wycenie.ID_zlecenie = new_order.ID;
                        produkty_W_Wycenie.ID_produktu = System.Convert.ToInt32(row.Cells[0].Value);
                        produkty_W_Wycenie.ilość = System.Convert.ToDecimal(row.Cells[4].Value);
                        produkty_W_Wycenie.Marża = System.Convert.ToInt32(row.Cells[5].Value);
                        produkty_W_Wycenie.Zysk_netto = System.Convert.ToDecimal(row.Cells[11].Value);
                        decimal actual_price = Convert.ToDecimal(row.Cells[6].Value.ToString().Trim(' ', 'z', 'ł'));
                        produkty_W_Wycenie.Aktualna_cena_netto = actual_price;
                        db.produkty_w_wycenie.Add(produkty_W_Wycenie);
                        db.SaveChanges();
                    }*/
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Zlecenie utworzone", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Błąd zapisu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // Save new offer

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                show_active_product = true;
                list_search(show_active_product);
            }
            else
            {
                show_active_product = false;
                list_search(show_active_product);
            }
        }

        void list_search(Boolean active_products)
        {
            if (active_products == true)
            {
                Cursor.Current = Cursors.WaitCursor;
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    listView1.Items.Clear();
                    List<produkt> list = db.produkt.ToList();
                    foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_name_search.Text.ToLower()) && lvi.Producent.ToLower().Contains(textBox_Producent_search.Text.ToLower())))
                    {
                        ListViewItem item = new ListViewItem(p.ID.ToString());
                        item.SubItems.Add(p.Nazwa.ToLower());
                        item.SubItems.Add(p.Producent.ToString());
                        item.SubItems.Add(p.Jm.ToString());
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
                        item.SubItems.Add(db.statusy_produktów.Find(p.Status).Status);
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        listView1.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;
            }

            if (active_products == false)
            {
                Cursor.Current = Cursors.WaitCursor;
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    listView1.Items.Clear();
                    List<produkt> list = db.produkt.ToList();
                    foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_name_search.Text.ToLower()) && lvi.Producent.ToLower().Contains(textBox_Producent_search.Text.ToLower()) && lvi.Status.ToString().Contains("1")))
                    {
                        ListViewItem item = new ListViewItem(p.ID.ToString());
                        item.SubItems.Add(p.Nazwa.ToLower());
                        item.SubItems.Add(p.Producent.ToString());
                        item.SubItems.Add(p.Jm.ToString());
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
                        item.SubItems.Add(db.statusy_produktów.Find(p.Status).Status);
                        item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
                        listView1.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        string TRIM_price(string net)
        {
            net = net.Trim(' ', 'z', 'ł');
            return net;
        }   // Trim char from price for decimal calculation

        private void Button_Add_Order_Click(object sender, EventArgs e)
        {
            Save_Order();
        }

        int button_number;

        private void Button_Adres_Zleceniodawcy_Click(object sender, EventArgs e)
        {
            button_number = 1;
            Choice_Address_For_Client(button_number);
        }

        private void button_Adres_from_list_Click(object sender, EventArgs e)
        {
            button_number = 2;
            Choice_Address_For_Client(button_number);
        }

        void Choice_Address_For_Client(int button_number) 
        { 
            TextBox[] textBox = { textBox_Town, textBox_Kod_1, textBox_Kod_2, textBox_Street, textBox_Building_Number, textBox_Home_Number, textBox_Country };
            switch (button_number)
            {                
                case 1:
                    {
                        try
                        {
                            using (zlecenieEntities db = new zlecenieEntities())
                            {
                                textBox_Town.Text = db.adres.Find(db.kontrahent.Find(client_id).Adres).Miasto;
                                textBox_Kod_1.Text = (db.adres.Find(db.kontrahent.Find(client_id).Adres).Kod_pocztowy).Remove(2, 3);
                                textBox_Kod_2.Text = (db.adres.Find(db.kontrahent.Find(client_id).Adres).Kod_pocztowy).Remove(0, 2);
                                textBox_Street.Text = db.adres.Find(db.kontrahent.Find(client_id).Adres).Nazwa_ulicy;
                                textBox_Building_Number.Text = db.adres.Find(db.kontrahent.Find(client_id).Adres).Numer_budynku;
                                textBox_Home_Number.Text = db.adres.Find(db.kontrahent.Find(client_id).Adres).Numer_mieszkania;
                                textBox_Country.Text = db.adres.Find(db.kontrahent.Find(client_id).Adres).Państwo;
                                
                                for(int i = 0; i < textBox.Length; i++)
                                {
                                    textBox[i].Enabled = false;
                                }   
                            }      
                        }
                        catch
                        {
                            MessageBox.Show("Wybierz Kontrahenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            using (zlecenieEntities db = new zlecenieEntities())
                            {
                                a = new adres();
                                Window_Choice_Adres_For_Order window_Choice_Adres = new Window_Choice_Adres_For_Order(a);
                                window_Choice_Adres.ShowDialog();
                                a = db.adres.Find(a.ID);
                                textBox_Town.Text = a.Miasto;
                                textBox_Kod_1.Text = a.Kod_pocztowy.Remove(2, 3);
                                textBox_Kod_2.Text = a.Kod_pocztowy.Remove(0, 2);
                                textBox_Street.Text = a.Nazwa_ulicy;
                                textBox_Building_Number.Text = a.Numer_budynku;
                                textBox_Home_Number.Text = a.Numer_mieszkania;
                                textBox_Country.Text = a.Państwo;

                                for (int i = 0; i < textBox.Length; i++)
                                {
                                    textBox[i].Enabled = false;
                                }
                            }
                        }
                        catch
                        {
                           
                        }
                        break;
                    }
            }
        }

        void order_number()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                int order_number = db.zlecenie.Count();
                label_order_number.Text = "Zlecenie nr: \n" + (order_number + 1).ToString() + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                int delay = dateTimePicker2.Value.Day - dateTime.Day;
            }
        }

        void calculate_delay()
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            int delay = (dateTimePicker2.Value - dateTime).Days;
            if (delay > 0)
            {
                label_delay.Text = delay + " dni do zakończenia prac";
            }
            else if (delay == 0)
            {
                label_delay.Text = delay + " dni.\n Termin zdania Prac";
            }
            else
            {
                label_delay.Text = delay.ToString().Trim('-') + " dni spóźnienia";
            }           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            calculate_delay();
        }

        void calculate()
        {
            try
            {
                decimal roznica_netto = 0;
                decimal roznica_brutto = 0;
                decimal sum_uzycie_netto = 0;
                decimal sum_uzycie_brutto = 0;
                decimal sum_oferta_netto = 0;
                decimal sum_oferta_brutto = 0;
                decimal sum_bez_oferty = 0;

                for (int z = 0; z < dataGridView1.Rows.Count; z++)
                {
                    DataGridViewRow row = dataGridView1.CurrentRow;
                    if (dataGridView1.CurrentRow != null)
                    {
                        if (dataGridView1.Rows[z].Cells[4].Value.ToString().Contains('.'))
                        {
                            row.Cells[4].Value.ToString().Replace('.', ',');
                            MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            decimal lot = System.Convert.ToDecimal(dataGridView1.Rows[z].Cells[4].Value); // ilość
                            decimal margin = System.Convert.ToDecimal(dataGridView1.Rows[z].Cells[5].Value); // marża
                            string piece_price = TRIM_price(dataGridView1.Rows[z].Cells[6].Value.ToString()); // cena jednostkowa
                            decimal price_w_margin; // cena z marżą
                            decimal Gross;
                            string vat = (dataGridView1.Rows[z].Cells[8].Value.ToString()).Trim(' ', '%'); // vat

                            if (dataGridView1.Rows[z].Cells[10].Value.ToString() == "Usługa")
                            {
                                price_w_margin = (System.Convert.ToDecimal(piece_price) * lot);
                                Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                                dataGridView1.Rows[z].Cells[9].Value = Gross * lot;
                                dataGridView1.Rows[z].Cells[5].Value = 100;
                            }
                            else
                            {
                                price_w_margin = (System.Convert.ToDecimal(piece_price) * lot) + (System.Convert.ToDecimal(piece_price) * lot * margin / 100);
                                Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                                dataGridView1.Rows[z].Cells[9].Value = (Gross * lot) + (Gross * lot * margin / 100);
                            }

                            dataGridView1.Rows[z].Cells[7].Value = price_w_margin; // cena jednostkowa + marża
                            decimal profit = (System.Convert.ToDecimal(piece_price) * lot) + (System.Convert.ToDecimal(piece_price) * lot * margin / 100) - (System.Convert.ToDecimal(piece_price) * lot);
                            dataGridView1.Rows[z].Cells[11].Value = profit; // zysk


                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                decimal uzycie_netto = System.Convert.ToDecimal(dataGridView2.Rows[i].Cells[7].Value.ToString().Trim(' ', 'z', 'ł'));
                                decimal uzycie_brutto = System.Convert.ToDecimal(dataGridView2.Rows[i].Cells[9].Value.ToString().Trim(' ', 'z', 'ł'));
                                sum_oferta_netto += uzycie_netto;
                                sum_oferta_brutto += uzycie_brutto;
                                sum_oferta_netto = Math.Round(sum_oferta_netto, 2);
                                sum_oferta_brutto = Math.Round(sum_oferta_brutto, 2);
                                sum_oferta_label_netto.Text = "Suma Netto: " + sum_oferta_netto.ToString() + " zł";
                                sum_oferta_label_brutto.Text = "Suma Brutto: " + sum_oferta_brutto.ToString() + " zł";
                            }
                            dataGridView1.Rows[z].Cells[6].Value = Math.Round(Convert.ToDecimal(piece_price), 2).ToString() + " zł";
                        }
                    }
                    else
                    {
                        sum_oferta_label_netto.Text = "Suma Netto: " + 0 + " zł";
                        sum_oferta_label_brutto.Text = "Suma Brutto: " + 0 + " zł";
                    }
                }
                for (int y = 0; y < dataGridView2.Rows.Count; y++)
                {
                    DataGridViewRow row = dataGridView2.CurrentRow;
                    if (dataGridView2.CurrentRow != null)
                    {
                        if (dataGridView2.Rows[y].Cells[4].Value.ToString().Contains('.'))
                        {
                            row.Cells[4].Value.ToString().Replace('.', ',');
                            MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            decimal lot = System.Convert.ToDecimal(dataGridView2.Rows[y].Cells[4].Value); // ilość
                            decimal margin = System.Convert.ToDecimal(dataGridView2.Rows[y].Cells[5].Value); // marża
                            string piece_price = TRIM_price(dataGridView2.Rows[y].Cells[6].Value.ToString()); // cena jednostkowa
                            decimal price_w_margin; // cena z marżą
                            decimal Gross;
                            string vat = (dataGridView2.Rows[y].Cells[8].Value.ToString()).Trim(' ', '%'); // vat

                            if (dataGridView2.Rows[y].Cells[10].Value.ToString() == "Usługa")
                            {
                                price_w_margin = (System.Convert.ToDecimal(piece_price) * lot);
                                Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                                dataGridView2.Rows[y].Cells[9].Value = Gross * lot;
                                dataGridView2.Rows[y].Cells[5].Value = 100;
                            }
                            else
                            {
                                price_w_margin = (System.Convert.ToDecimal(piece_price) * lot) + (System.Convert.ToDecimal(piece_price) * lot * margin / 100);
                                Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                                dataGridView2.Rows[y].Cells[9].Value = (Gross * lot) + (Gross * lot * margin / 100);
                            }

                            dataGridView2.Rows[y].Cells[7].Value = price_w_margin; // cena jednostkowa + marża
                            decimal profit = (System.Convert.ToDecimal(piece_price) * lot) + (System.Convert.ToDecimal(piece_price) * lot * margin / 100) - (System.Convert.ToDecimal(piece_price) * lot);
                            dataGridView2.Rows[y].Cells[11].Value = profit; // zysk                            

                            
                                decimal uzycie_netto = System.Convert.ToDecimal(dataGridView2.Rows[y].Cells[7].Value.ToString().Trim(' ', 'z', 'ł'));
                                decimal uzycie_brutto = System.Convert.ToDecimal(dataGridView2.Rows[y].Cells[9].Value.ToString().Trim(' ', 'z', 'ł'));                                
                                sum_uzycie_netto += uzycie_netto;
                                sum_uzycie_brutto += uzycie_brutto;
                                sum_uzycie_netto = Math.Round(sum_uzycie_netto, 2);
                                sum_uzycie_brutto = Math.Round(sum_uzycie_brutto, 2);
                                sum_użyte_netto.Text = "Suma Netto: " + sum_uzycie_netto.ToString() + " zł";
                                sum_użyte_brutto.Text = "Suma Brutto: " + sum_uzycie_brutto.ToString() + " zł";
                            
                            dataGridView2.Rows[y].Cells[6].Value = Math.Round(Convert.ToDecimal(piece_price), 2).ToString() + " zł";
                        }
                    }
                    else
                    {
                        sum_użyte_netto.Text = "Suma Netto: " + 0 + " zł";
                        sum_użyte_brutto.Text = "Suma Brutto: " + 0 + " zł";
                    }
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum_bez_oferty = sum_bez_oferty + System.Convert.ToDecimal(dataGridView2.Rows[i].Cells[11].Value.ToString().Trim(' ', 'z', 'ł'));                   
                }
                if (sum_oferta_netto != 0)
                {
                    roznica_netto = sum_oferta_netto - sum_uzycie_netto;
                    roznica_brutto = sum_oferta_brutto - sum_uzycie_brutto;
                    sum_roznica_netto.Text = "Zysk Netto: " + roznica_netto + " zł";
                    sum_roznica_brutto.Text = "Zysk Brutto: " + roznica_brutto + " zł";
                }
                else
                {
                    roznica_netto = sum_bez_oferty - sum_uzycie_netto; 
                }            
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Problem z przeliczeniem");
            }
        } // Calculate for sum
    }
}
