using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace E_elektryk
{
    
    public partial class Window_Add_Offer : Form
    {
        
        public Window_Add_Offer()
        {
            InitializeComponent();
        }

        private void Window_Add_Offer_Load(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                listView1.Items.Clear();
                List<produkt> list = db.produkt.ToList();
                foreach (produkt p in list)
                {
                    ListViewItem item = new ListViewItem(p.Nazwa.ToString());
                    item.SubItems.Add(p.Producent);
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
                    item.Font = new Font(item.Font, FontStyle.Regular);
                    listView1.Items.Add(item);
                }
            }
        }   // Fill listView from products DB

        void Add_to_offer(object sender, EventArgs e)
        {
            ListViewItem item = (ListViewItem)listView1.SelectedItems[0].Clone();   // Clone current litView object
            DataGridViewRow item_grid = new DataGridViewRow();
            item_grid.CreateCells(dataGridView1);
            item_grid.Cells[0].Value = item.SubItems[0].Text;   // Add to cells Nazwa
            item_grid.Cells[1].Value = item.SubItems[1].Text;   // Add to cells Producent
            item_grid.Cells[2].Value = item.SubItems[2].Text;   // Add to cells JM
            decimal lot = 1;    
            item_grid.Cells[3].Value = lot.ToString();  // One piece for every new Product in DataGrid
            string net_offer = TRIM_price(item.SubItems[4].Text);
            item_grid.Cells[4].Value = System.Convert.ToDecimal(net_offer); // Add decimal one piece net price to cells C.J
            item_grid.Cells[5].Value = System.Convert.ToDecimal(net_offer) * System.Convert.ToDecimal(lot); // Add calculated net price for all pieces
            item_grid.Cells[6].Value = item.SubItems[5].Text;   // Add taxe to cells VAT
            string gross_offer = TRIM_price(item.SubItems[6].Text); 
            item_grid.Cells[7].Value = System.Convert.ToDecimal(gross_offer) * System.Convert.ToDecimal(lot);   // Add calculated gross price for all pieces
            item_grid.Cells[8].Value = item.SubItems[7].Text;   // Add category name to cells Kategoria
            dataGridView1.Rows.Add(item_grid);
        }   // Clone listView object and add it to dataGrid row

        string TRIM_price(string net)
        {
            net = net.Trim(' ', 'z', 'ł');
            return net;
        }   // Trim char from price for decimal calculation

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[3].Value.ToString().Contains('.'))
                {
                    MessageBox.Show("W wartościach numerycznych użyj znaku ',' zamiast '.'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    decimal lot = System.Convert.ToDecimal(row.Cells[3].Value);
                    string piece_price = TRIM_price(row.Cells[4].Value.ToString());
                    row.Cells[5].Value = System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot);
                    string gross_offer = TRIM_price(row.Cells[7].Value.ToString());
                    string vat = (row.Cells[6].Value.ToString()).Trim(' ', '%');
                    decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
                    row.Cells[7].Value = Gross * lot;
                    decimal sum_e_taxes = 0;
                    decimal sum_w_taxes = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum_e_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                        sum_w_taxes += System.Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                        sum_e_taxes = Math.Round(sum_e_taxes, 2);
                        sum_w_taxes = Math.Round(sum_w_taxes, 2);
                        sum_e_taxes_label.Text = "Suma Netto: " + sum_e_taxes.ToString();
                        sum_w_taxes_label.Text = "Suma Brutto: " + sum_w_taxes.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("W pole ilość można wprowadzać tylko wartości numeryczne!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   // Update dataGrid net and gross price value after enter new quantity value

        private void Button_chose_Client_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db =  new zlecenieEntities())
            {
                kontrahent k = new kontrahent();
                Window_Choice_Client_For_Offer window_Choice_Client = new Window_Choice_Client_For_Offer(k);
                window_Choice_Client.ShowDialog();
                using (zlecenieEntities dd = new zlecenieEntities())
                {
                    k = db.kontrahent.Find(k.ID);
                }
                textBox_Offer_Name.Text = k.Imie.ToString();
                textBox_Offer_LastName.Text = k.Nazwisko.ToString();
                textBox_Offer_CompanyName.Text = k.Nazwa_Firmy.ToString();
                textBox_Adress.Text = k.Adres.ToString();
            }
        }
    }
}

