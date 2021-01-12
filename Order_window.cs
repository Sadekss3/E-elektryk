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
    public partial class Order_window : Form
    {
        public Order_window()
        {
            InitializeComponent();
            Update_Offer_List();
        }
        public void Update_Offer_List()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Order_list.Items.Clear();
                    List<zlecenie> list = db.zlecenie.ToList();
                    foreach (zlecenie z in list.Where(lvi => lvi.Nazwa.ToLower().Contains(Order_Search_Order_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Kontrahent).Nazwa_Firmy.ToLower().Contains(Order_Search_Client_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Kontrahent).ID.ToString().Contains(Order_Search_Client_ID.Text)))
                    {
                        string Client_Info = db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Nazwa_ulicy + " " + db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Numer_budynku +
                            " " + db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Numer_mieszkania + " " + db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Kod_pocztowy.Remove(2, 3) +
                            "-" + db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Kod_pocztowy.Remove(0, 2) + " " + db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Miasto;
                        ListViewItem item = new ListViewItem(z.ID.ToString());
                        item.SubItems.Add(z.Nazwa);
                        item.SubItems.Add(db.kontrahent.Find(z.Kontrahent).Nazwa_Firmy);
                        item.SubItems.Add(Client_Info);
                        item.SubItems.Add(z.Data_od.ToString().Remove(10, 9));
                        item.SubItems.Add(z.Data_do.ToString().Remove(10, 9));
                        item.SubItems.Add(db.statusy_zlecenia.Find(z.Status_zlecenia).Status);
                        item.SubItems.Add(z.Opis.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Order_list.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void Offer_Search_Offer_Name_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Order_list.Items.Clear();
                    List<zlecenie> list = db.zlecenie.ToList();
                    foreach (zlecenie z in list.Where(lvi => lvi.Nazwa.ToLower().Contains(Order_Search_Order_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Kontrahent).Nazwa_Firmy.ToLower().Contains(Order_Search_Client_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Kontrahent).ID.ToString().Contains(Order_Search_Client_ID.Text)))
                    {
                        ListViewItem item = new ListViewItem(z.ID.ToString());
                        item.SubItems.Add(z.Nazwa);
                        item.SubItems.Add(db.kontrahent.Find(z.Kontrahent).Nazwa_Firmy);
                        item.SubItems.Add(db.adres.Find(db.kontrahent.Find(z.Kontrahent).Adres).Miasto);
                        item.SubItems.Add(z.Data_od.ToString().Remove(10, 9));
                        item.SubItems.Add(z.Data_do.ToString().Remove(10, 9));
                        item.SubItems.Add(z.Status_zlecenia.ToString());
                        item.SubItems.Add(z.Opis.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Order_list.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                }
            }
            Cursor.Current = Cursors.Default;
        } // Search and fill list by input

        /*        private void Offer_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Position_In_Offer_ListView.Items.Clear();
                    string id_offer = Offer_list.SelectedItems[0].Text;
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
                        decimal margin = p.Marża;
                        decimal netto = p.Aktualna_cena_netto;
                        decimal price_w_margin = Math.Round((netto * ilość) + (netto * ilość * margin / 100), 2);
                        item.SubItems.Add(price_w_margin.ToString() + " zł");
                        decimal vat = System.Convert.ToDecimal(db.produkt.Find(p.ID_produktu).Vat);
                        item.SubItems.Add(vat.ToString() + "%");
                        decimal brutto = Math.Round(price_w_margin + (price_w_margin * (vat / 100)), 2);
                        item.SubItems.Add(brutto.ToString() + " zł");
                        item.SubItems.Add(db.kategoria_produktu.Find(db.produkt.Find(p.ID_produktu).Kategoria).Nazwa_kategorii);
                        item.SubItems.Add(Math.Round(ilość * price_w_margin, 2).ToString() + " zł");
                        item.SubItems.Add(Math.Round(ilość * brutto, 2).ToString() + " zł");
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Position_In_Offer_ListView.Items.Add(item);
                    }
                    Calculate_tax_price();
                }
                catch (Exception)
                {
                }
            }
        } // Fill actual Offer products list*/

        /*void Calculate_tax_price()
        {
            decimal sum_w_taxes = 0;
            decimal sum_e_taxes = 0;
            for (int i = 0; i <= Position_In_Offer_ListView.Items.Count; i++)
            {
                sum_e_taxes += System.Convert.ToDecimal((Position_In_Offer_ListView.Items[i].SubItems[10].Text).Trim(' ', 'z', 'ł'));
                sum_w_taxes += System.Convert.ToDecimal((Position_In_Offer_ListView.Items[i].SubItems[11].Text).Trim(' ', 'z', 'ł'));
                sum_e_taxes = Math.Round(sum_e_taxes, 2);
                sum_w_taxes = Math.Round(sum_w_taxes, 2);
                sum_w_taxes_label_2.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
                sum_e_taxes_label_2.Text = "Suma Neto: " + sum_e_taxes.ToString() + " zł";
            }
        } // Calculate gross price for offer*/

        /*public int getSelectedProduct()
        {
            int Selected_Product_ID = 0;
            if (Offer_list.SelectedItems.Count > 0)
            {
                Selected_Product_ID = System.Convert.ToInt32(Offer_list.SelectedItems[0].Text);
            }
            return (Selected_Product_ID);
        }*/
        public int getSelectedProduct()
        {
            int Selected_Product_ID = 0;
            if (Order_list.SelectedItems.Count > 0)
            {
                Selected_Product_ID = System.Convert.ToInt32(Order_list.SelectedItems[0].Text);
            }
            return (Selected_Product_ID);
        }
    }
}
