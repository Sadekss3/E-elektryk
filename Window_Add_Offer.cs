using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace E_elektryk
{
    public partial class Window_Add_Offer : Form
    {
        int client_id;
        oferta _o;
        string _type;

        public Window_Add_Offer()
        {
            InitializeComponent();
            _type = "Add";
        }

        public Window_Add_Offer(oferta o)
        {
            InitializeComponent();
            _type = "Modify";
            _o = o;
            Button_Add_Offer.Text = "Aktualizuj";
            Add_Offer_Information();
        }

        private void Add_Offer_Information()
        {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    textBox_O_Name.Text = _o.Nazwa;
                    textBox_Offer_Name.Text = db.kontrahent.Find(_o.Id_zleceniodawca).Imie;
                    textBox_Offer_LastName.Text = db.kontrahent.Find(_o.Id_zleceniodawca).Nazwisko;
                    textBox_Offer_CompanyName.Text = db.kontrahent.Find(_o.Id_zleceniodawca).Nazwa_Firmy;
                    textBox_Town_Name.Text = db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Miasto;
                    textBox_Post_Code_1.Text = (db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Kod_pocztowy).Remove(2, 3);
                    textBox_Post_Code_2.Text = (db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Kod_pocztowy).Remove(0, 2);
                    textBox_Street_Name.Text = db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Nazwa_ulicy;
                    textBox_Building_Number.Text = db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Numer_budynku;
                    textBox_Home_Number.Text = db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Numer_mieszkania;
                    textBox_Country_ID.Text = db.adres.Find(db.kontrahent.Find(_o.Id_zleceniodawca).Adres).Państwo;
                    Offer_Information_Box.Text = _o.Opis;
                    dateTimePicker1.Value = _o.Data_Od.Date;
                    dateTimePicker2.Value = _o.Data_Do.Date;
                    List<produkty_w_wycenie> list = db.produkty_w_wycenie.ToList();
                    foreach (produkty_w_wycenie produkty_W_Wycenie in list.Where(id => id.ID_zlecenie == _o.ID))
                    {
                        DataGridViewRow item_grid = new DataGridViewRow();
                        item_grid.CreateCells(dataGridView1);
                        item_grid.Cells[0].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).ID;
                        item_grid.Cells[1].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Nazwa;
                        item_grid.Cells[2].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Producent;
                        item_grid.Cells[3].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Jm;
                        item_grid.Cells[4].Value = produkty_W_Wycenie.ilość;
                        item_grid.Cells[5].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Cena_netto;
                        item_grid.Cells[6].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Cena_netto;
                        item_grid.Cells[7].Value = db.produkt.Find(produkty_W_Wycenie.ID_produktu).Vat + "%";
                        item_grid.Cells[8].Value = Math.Round(db.produkt.Find(produkty_W_Wycenie.ID_produktu).Cena_brutto, 2);
                        item_grid.Cells[9].Value = db.kategoria_produktu.Find(db.produkt.Find(produkty_W_Wycenie.ID_produktu).Kategoria).Nazwa_kategorii;
                        dataGridView1.Rows.Add(item_grid);
                    }
                }
        } // Fill offer window with information about actual offer

        private void Window_Add_Offer_Load(object sender, EventArgs e)
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
                    item.SubItems.Add(db.statusy_zlecenia.Find(p.Status).Status);
                    item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
                    listView1.Items.Add(item);
                }
            }
            decimal sum_e_taxes = 0;
            decimal sum_w_taxes = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains('.'))
                {
                    MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal lot = System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    string piece_price = TRIM_price(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    string gross_offer = TRIM_price(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    string vat = (dataGridView1.Rows[i].Cells[7].Value.ToString()).Trim(' ', '%');
                    decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                    sum_e_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    sum_w_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                    sum_e_taxes = Math.Round(sum_e_taxes, 2);
                    sum_w_taxes = Math.Round(sum_w_taxes, 2);
                    sum_e_taxes_label.Text = "Suma Netto: " + sum_e_taxes.ToString() + " zł";
                    sum_w_taxes_label.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
                    dataGridView1.Rows[i].Cells[6].Value = (Math.Round(System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot), 2));
                    dataGridView1.Rows[i].Cells[8].Value = Math.Round(Gross * lot, 2);
                }
            }
        }   // Fill listView from products DB

        void Add_to_offer(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                DataGridViewRow item_grid = new DataGridViewRow();
                ListViewItem item = (ListViewItem)listView1.SelectedItems[0].Clone();   // Clone current litView object
                item_grid.CreateCells(dataGridView1);
                item_grid.Cells[0].Value = item.SubItems[0].Text;   // Add to cells ID
                item_grid.Cells[1].Value = item.SubItems[1].Text;   // Add to cells Nazwa
                item_grid.Cells[2].Value = item.SubItems[2].Text;   // Add to cells Producent
                item_grid.Cells[3].Value = item.SubItems[3].Text;   // Add to cells J.m
                decimal lot = 1;
                item_grid.Cells[4].Value = lot.ToString();  // One piece for every new Product in DataGrid
                string net_offer = TRIM_price(item.SubItems[5].Text);
                item_grid.Cells[5].Value = System.Convert.ToDecimal(net_offer); // Add decimal one piece net price to cells C.J
                item_grid.Cells[6].Value = System.Convert.ToDecimal(net_offer) * System.Convert.ToDecimal(lot) + " zł"; // Add calculated net price for all pieces
                item_grid.Cells[7].Value = item.SubItems[6].Text + "%";   // Add taxe to cells VAT
                string gross_offer = TRIM_price(item.SubItems[7].Text);
                item_grid.Cells[8].Value = System.Convert.ToDecimal(gross_offer) * System.Convert.ToDecimal(lot) + " zł";   // Add calculated gross price for all pieces
                item_grid.Cells[9].Value = item.SubItems[8].Text;   // Add category name to cells Kategoria
                dataGridView1.Rows.Add(item_grid);
            }
            calculate();
        }   // Clone listView object and add to dataGrid row

        string TRIM_price(string net)
        {
            net = net.Trim(' ', 'z', 'ł');
            return net;
        }   // Trim char from price for decimal calculation

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculate();
        }   // Update dataGrid net and gross price value after enter new quantity value

        private void Button_chose_Client_Click(object sender, EventArgs e)
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
                textBox_Town_Name.Text = a.Miasto.ToString();
                textBox_Post_Code_1.Text = a.Kod_pocztowy.ToString().Remove(2, 3);
                textBox_Post_Code_2.Text = a.Kod_pocztowy.ToString().Remove(0, 2);
                textBox_Street_Name.Text = a.Nazwa_ulicy.ToString();
                textBox_Building_Number.Text = a.Numer_budynku.ToString();
                textBox_Home_Number.Text = a.Numer_mieszkania.ToString();
                textBox_Country_ID.Text = a.Państwo.ToString();
            }
        } // Add information about Client to Offer Form


        private void button2_Click(object sender, EventArgs e)
        {
            PdfPCell getCell(String text, int alignment)
            {
                string ss = @"C:\Windows\Fonts\micross.ttf";
                BaseFont aa = BaseFont.CreateFont(ss, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font bb = new iTextSharp.text.Font(aa, 8, iTextSharp.text.Font.NORMAL);
                PdfPCell cell = new PdfPCell(new Phrase(text , bb));
                cell.Padding = (0);
                cell.HorizontalAlignment = alignment;
                cell.Border = PdfPCell.NO_BORDER;
                return cell;
            }

            string My_Info = "";
            string Client_info = "";

            using (zlecenieEntities db = new zlecenieEntities())
            {
                int My_ID = 20;
                int Client_ID = _o.ID;
                if (_o != null)
                {
                    Client_ID = _o.Id_zleceniodawca;
                }
                else
                {
                    Client_ID = client_id;
                }

                My_Info = db.kontrahent.Find(My_ID).Imie + " " + db.kontrahent.Find(My_ID).Nazwisko + "\n" + db.kontrahent.Find(My_ID).Nazwa_Firmy + "\nul. " + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Nazwa_ulicy +
                   " " + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Numer_budynku + "/" + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Numer_mieszkania + "\n" +
                   db.adres.Find(db.kontrahent.Find(My_ID).Adres).Kod_pocztowy.Remove(2, 3) + "-" + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Kod_pocztowy.Remove(0, 2) + " " + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Miasto + "\nNIP: " +
                db.kontrahent.Find(My_ID).NIP + "\nPESEL: " + db.kontrahent.Find(My_ID).Pesel + "\nEmail: " + db.kontrahent.Find(My_ID).E_mail + "\nTel: " + db.kontrahent.Find(My_ID).Telefon_1 +
                   "\nTel: " + db.kontrahent.Find(My_ID).Telefon_2 + "\nPaństwo: " + db.adres.Find(db.kontrahent.Find(My_ID).Adres).Państwo;

                Client_info = db.kontrahent.Find(Client_ID).Imie + " " + db.kontrahent.Find(Client_ID).Nazwisko + "\n" + db.kontrahent.Find(Client_ID).Nazwa_Firmy + "\nul. " + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Nazwa_ulicy +
                   " " + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Numer_budynku + "/" + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Numer_mieszkania + "\n" +
                   db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Kod_pocztowy.Remove(2, 3) + "-" + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Kod_pocztowy.Remove(0, 2) + " " + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Miasto + "\nNIP: " +
                db.kontrahent.Find(Client_ID).NIP + "\nPESEL: " + db.kontrahent.Find(Client_ID).Pesel + "\nEmail: " + db.kontrahent.Find(Client_ID).E_mail + "\nTel: " + db.kontrahent.Find(Client_ID).Telefon_1 +
                   "\nTel: " + db.kontrahent.Find(Client_ID).Telefon_2 + "\nPaństwo: " + db.adres.Find(db.kontrahent.Find(Client_ID).Adres).Państwo;
            }

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"E:\E-elektryk oferty\" + _o.ID + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".pdf", FileMode.Create));
            document.Open();

            #region font

            string myFont = @"C:\Windows\Fonts\micross.ttf";
            BaseFont bf = BaseFont.CreateFont(myFont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font Font_Table_Headers = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font Font_Table_Cells = new iTextSharp.text.Font(bf, 6, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font Title_Font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            #endregion

            #region Client_info

            PdfPTable headers = new PdfPTable(2);
            headers.HorizontalAlignment = Element.ALIGN_LEFT;
            headers.AddCell(getCell(My_Info, Element.ALIGN_LEFT));
            headers.AddCell(getCell(Client_info, Element.ALIGN_RIGHT));
            document.Add(headers);

            #endregion

            #region Title

            Paragraph title = new Paragraph();
            Chunk c1 = new Chunk("Oferta nr: " +_o.ID + "/"+ DateTime.Now.Month + "/" + DateTime.Now.Year, Title_Font);
            title.Add(c1);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);
            Paragraph pause = new Paragraph();
            Chunk c2 = new Chunk(" ", Title_Font);
            pause.Add(c2);
            pause.Alignment = Element.ALIGN_CENTER;
            document.Add(pause);

            #endregion

            #region date

            Paragraph date = new Paragraph();
            Chunk c3 = new Chunk("Oferta ważna od: " + dateTimePicker1.Value.ToString().Remove(10, 9) +"\r" , Font_Table_Cells);
            Chunk c4 = new Chunk("Oferta ważna do: " + dateTimePicker2.Value.ToString().Remove(10, 9), Font_Table_Cells);
            date.Add(c3);
            date.Add(c4);
            date.Alignment = Element.ALIGN_LEFT;
            document.Add(date);
            document.Add(pause);

            #endregion

            #region tabela

            int columns = dataGridView1.Columns.Count;
            PdfPTable table = new PdfPTable(columns);

            float[] widths = new float[] { 10, 45, 25, 10, 15, 15, 15, 10, 15, 30};
            table.SetWidths(widths);
            table.AddCell(new PdfPCell(new Phrase("ID", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Nazwa", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Producent", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("JM", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Ilość", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("C.j", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Netto", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Vat", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Brutto", Font_Table_Headers)));
            table.AddCell(new PdfPCell(new Phrase("Kategoria", Font_Table_Headers)));

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    table.AddCell(new PdfPCell(new Phrase(dataGridView1.Rows[j].Cells[i].Value.ToString(), Font_Table_Cells)));
            }

            document.Add(table);

            #endregion

            document.Close();
            MessageBox.Show("Utworzono ofertę " + _o.ID + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".pdf");
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "acroRd32.exe"; //not the full application path
            myProcess.StartInfo.Arguments = "\""+ @"E:\E-elektryk oferty\" + _o.ID + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".pdf" + "\"";
            myProcess.Start();

        } // Generate offer pdf using itextsharp

        private void Button_Delete_From_Grid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell selectedcell in dataGridView1.SelectedCells)
            {
                if (_o == null)
                {
                    if (selectedcell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(selectedcell.RowIndex);
                    }
                }
                else
                {
                    using (zlecenieEntities db = new zlecenieEntities())
                    {
                        produkty_w_wycenie produkt_ = new produkty_w_wycenie();
                        int ID_produktu = System.Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        produkt_ = db.produkty_w_wycenie.Find(_o.ID, ID_produktu);
                        
                        db.produkty_w_wycenie.Remove(produkt_);
                        db.SaveChanges();
                    }
                    if (selectedcell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(selectedcell.RowIndex);
                    }
                }
            }
            calculate();
        } // Delete product from Datagrid

        void Save_Offer()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                Cursor.Current = Cursors.WaitCursor;
                oferta new_offer = new oferta();
                try
                {
                    new_offer.Nazwa = textBox_O_Name.Text;
                    new_offer.Id_zleceniodawca = client_id;
                    new_offer.Data_Od = dateTimePicker1.Value;
                    new_offer.Data_Do = dateTimePicker2.Value;
                    new_offer.Opis = Offer_Information_Box.Text;
                    new_offer.Status = "Oferta";
                    db.oferta.Add(new_offer);
                    db.SaveChanges();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        produkty_w_wycenie produkty_W_Wycenie = new produkty_w_wycenie();
                        produkty_W_Wycenie.ID_zlecenie = new_offer.ID;
                        produkty_W_Wycenie.ID_produktu = System.Convert.ToInt32(row.Cells[0].Value);
                        produkty_W_Wycenie.ilość = System.Convert.ToDecimal(row.Cells[4].Value);
                        db.produkty_w_wycenie.Add(produkty_W_Wycenie);
                        db.SaveChanges();
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Oferta utworzona", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // Save new offer

        void Modify_Offer()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                Cursor.Current = Cursors.WaitCursor;
                oferta new_offer = new oferta();
                try
                {
                    new_offer.ID = _o.ID;
                    new_offer.Nazwa = textBox_O_Name.Text;
                    if(client_id == 0)
                    {
                        new_offer.Id_zleceniodawca = _o.Id_zleceniodawca;
                    }
                    else
                    {
                        new_offer.Id_zleceniodawca = client_id;
                    }
                    new_offer.Data_Od = dateTimePicker1.Value;
                    new_offer.Data_Do = dateTimePicker2.Value;
                    new_offer.Opis = Offer_Information_Box.Text;
                    new_offer.Status = "Oferta";
                    db.oferta.AddOrUpdate(new_offer);
                    db.SaveChanges();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        produkty_w_wycenie produkty_W_Wycenie = new produkty_w_wycenie();
                        produkty_W_Wycenie.ID_zlecenie = new_offer.ID;
                        produkty_W_Wycenie.ID_produktu = System.Convert.ToInt32(row.Cells[0].Value);
                        produkty_W_Wycenie.ilość = System.Convert.ToDecimal(row.Cells[4].Value);
                        db.produkty_w_wycenie.AddOrUpdate(produkty_W_Wycenie);
                        db.SaveChanges();
                    }
                    //delete_from_DG();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Oferta zaktualizowana", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // Modify actual offer

        void calculate()
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[4].Value.ToString().Contains('.'))
                {
                    MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal lot = System.Convert.ToDecimal(row.Cells[4].Value);
                    string piece_price = TRIM_price(row.Cells[5].Value.ToString());
                    row.Cells[6].Value = System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot);
                    string gross_offer = TRIM_price(row.Cells[7].Value.ToString());
                    string vat = (row.Cells[7].Value.ToString()).Trim(' ', '%');
                    decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                    row.Cells[8].Value = Gross * lot;
                    decimal sum_e_taxes = 0;
                    decimal sum_w_taxes = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        decimal net = System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value.ToString().Trim(' ', 'z','ł'));
                        decimal gross = System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value.ToString().Trim(' ', 'z', 'ł'));
                        sum_e_taxes += System.Convert.ToDecimal(net);
                        sum_w_taxes += System.Convert.ToDecimal(gross);
                        sum_e_taxes = Math.Round(sum_e_taxes, 2);
                        sum_w_taxes = Math.Round(sum_w_taxes, 2);
                        sum_e_taxes_label.Text = "Suma Netto: " + sum_e_taxes.ToString() + " zł";
                        sum_w_taxes_label.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
                    }
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message, "Problem z przeliczeniem");
            }
        } // Calculate for sum

        private void Button_Add_Offer_Click(object sender, EventArgs e)
        {
            if (_type == "Add")
            {
                Save_Offer();
            }
            else
            {
                Modify_Offer();
            }
        } // Save or update information about Offer

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    List<produkt> list = db.produkt.ToList();
                    listView1.Items.Clear();
                    foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_name_search.Text.ToLower().Trim()) && lvi.Producent.ToLower().Contains(textBox_Producent_search.Text.ToLower().Trim())))
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
                        item.SubItems.Add(db.statusy_zlecenia.Find(p.Status).Status);
                        item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
                        listView1.Items.Add(item);
                    }
                }
                decimal sum_e_taxes = 0;
                decimal sum_w_taxes = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains('.'))
                    {
                        MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        decimal lot = System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        string piece_price = TRIM_price(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        string gross_offer = TRIM_price(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        string vat = (dataGridView1.Rows[i].Cells[7].Value.ToString()).Trim(' ', '%');
                        decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                        sum_e_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                        sum_w_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                        sum_e_taxes = Math.Round(sum_e_taxes, 2);
                        sum_w_taxes = Math.Round(sum_w_taxes, 2);
                        sum_e_taxes_label.Text = "Suma Netto: " + sum_e_taxes.ToString() + " zł";
                        sum_w_taxes_label.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
                        dataGridView1.Rows[i].Cells[6].Value = (Math.Round(System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot), 2));
                        dataGridView1.Rows[i].Cells[8].Value = Math.Round(Gross * lot, 2);
                    }
                }
            }
            else
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
                        item.SubItems.Add(db.statusy_zlecenia.Find(p.Status).Status);
                        item.Font = new System.Drawing.Font(item.Font, FontStyle.Regular);
                        listView1.Items.Add(item);
                    }
                }
                decimal sum_e_taxes = 0;
                decimal sum_w_taxes = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains('.'))
                    {
                        MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        decimal lot = System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        string piece_price = TRIM_price(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        string gross_offer = TRIM_price(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        string vat = (dataGridView1.Rows[i].Cells[7].Value.ToString()).Trim(' ', '%');
                        decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                        sum_e_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                        sum_w_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                        sum_e_taxes = Math.Round(sum_e_taxes, 2);
                        sum_w_taxes = Math.Round(sum_w_taxes, 2);
                        sum_e_taxes_label.Text = "Suma Netto: " + sum_e_taxes.ToString() + " zł";
                        sum_w_taxes_label.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
                        dataGridView1.Rows[i].Cells[6].Value = (Math.Round(System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot), 2));
                        dataGridView1.Rows[i].Cells[8].Value = Math.Round(Gross * lot, 2);
                    }
                }
            }
        }
    }
}

