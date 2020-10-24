using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
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
        }
        void Add_to_offer(object sender, EventArgs e)
        {
            ListViewItem item = (ListViewItem)listView1.SelectedItems[0].Clone();
            DataGridViewRow item_grid = new DataGridViewRow();
            item_grid.CreateCells(dataGridView1);
            item_grid.Cells[0].Value = item.SubItems[0].Text;
            item_grid.Cells[1].Value = item.SubItems[1].Text;
            item_grid.Cells[2].Value = item.SubItems[2].Text;
            //string lot = Microsoft.VisualBasic.Interaction.InputBox("Podaj ilość: ", " ", "0");
            decimal lot = 1;
            item_grid.Cells[3].Value = lot.ToString();
            string net_offer = TRIM_price(item.SubItems[4].Text);
            item_grid.Cells[4].Value = item.SubItems[4].Text;
            item_grid.Cells[5].Value = System.Convert.ToDecimal(net_offer) * System.Convert.ToDecimal(lot);
            item_grid.Cells[6].Value = item.SubItems[5].Text;
            string gross_offer = TRIM_price(item.SubItems[6].Text);
            item_grid.Cells[7].Value = System.Convert.ToDecimal(gross_offer) * System.Convert.ToDecimal(lot);
            item_grid.Cells[8].Value = item.SubItems[7].Text;
            dataGridView1.Rows.Add(item_grid);
        }
        string TRIM_price(string net)
        {
            net = net.Trim(' ', 'z', 'ł');
            return net;
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            decimal lot = System.Convert.ToDecimal(row.Cells[3].Value);
            string piece_price = TRIM_price(row.Cells[4].Value.ToString());
            row.Cells[5].Value = System.Convert.ToDecimal(piece_price) * System.Convert.ToDecimal(lot);
            string gross_offer = TRIM_price(row.Cells[7].Value.ToString());
            string vat = (row.Cells[6].Value.ToString()).Trim(' ', '%');
            decimal Gross = System.Convert.ToDecimal(piece_price) + (System.Convert.ToDecimal(piece_price) * (System.Convert.ToDecimal(vat) / 100));
            row.Cells[7].Value = Gross * lot;
        }
    }
}

