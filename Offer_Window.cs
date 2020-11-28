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
    public partial class Offer_Window : Form
    {
        public Offer_Window()
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
                    Offer_list.Items.Clear();
                    List<oferta> list = db.oferta.ToList();
                    foreach (oferta o in list.Where(lvi => lvi.Nazwa.ToLower().Contains(Offer_Search_Offer_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Id_zleceniodawca).Nazwa_Firmy.ToLower().Contains(Offer_Search_Client_Name.Text.ToLower()) && db.kontrahent.Find(lvi.Id_zleceniodawca).ID.ToString().Contains(Offer_Search_Client_ID.Text)))
                    {
                        string Client_Info = db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Nazwa_ulicy + " " + db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Numer_budynku + 
                            " " + db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Numer_mieszkania + " "+ db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Kod_pocztowy.Remove(2, 3) + 
                            "-" + db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Kod_pocztowy.Remove(0, 2) + " " + db.adres.Find(db.kontrahent.Find(o.Id_zleceniodawca).Adres).Miasto;
                        ListViewItem item = new ListViewItem(o.ID.ToString());
                        item.SubItems.Add(o.Nazwa);
                        item.SubItems.Add(db.kontrahent.Find(o.Id_zleceniodawca).Nazwa_Firmy);
                        item.SubItems.Add(Client_Info);
                        item.SubItems.Add(o.Data_Od.ToString().Remove(10, 9));
                        item.SubItems.Add(o.Data_Do.ToString().Remove(10, 9));
                        item.SubItems.Add(db.statusy_zlecenia.Find(o.Status).Status);
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
        }

        private void Offer_Search_Offer_Name_TextChanged(object sender, EventArgs e)
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
                        item.SubItems.Add(o.Status.ToString());
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
        } // Search and fill list by input

        private void Offer_list_SelectedIndexChanged_1(object sender, EventArgs e)
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
                catch (Exception)
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
                MessageBox.Show(sum_w_taxes.ToString());
                sum_w_taxes_label_2.Text = "Suma Brutto: " + sum_w_taxes.ToString() + " zł";
            }
        } // Calculate gross price for offer

        public int getSelectedProduct()
        {
            int Selected_Product_ID = 0;
            if (Offer_list.SelectedItems.Count > 0)
            {
                Selected_Product_ID = System.Convert.ToInt32(Offer_list.SelectedItems[0].Text);
            }
            return (Selected_Product_ID);
        }

    }
}
