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
        decimal sum_NET = 0;
        decimal sum_GROS = 0;
        decimal lot = 0;

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
            item_grid.Cells[3].Value = item.SubItems[3].Text;
            item_grid.Cells[4].Value = item.SubItems[4].Text;
            item_grid.Cells[5].Value = item.SubItems[5].Text;
            item_grid.Cells[6].Value = item.SubItems[6].Text;
            item_grid.Cells[7].Value = item.SubItems[7].Text;
            dataGridView1.Rows.Add(item_grid);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string sum_e_taxes = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string sum_w_taxes = dataGridView1.Rows[i].Cells[6].Value.ToString();
                string numbers_of_product = dataGridView1.Rows[i].Cells[3].Value.ToString();
                sum_e_taxes = sum_e_taxes.Trim(' ', 'z', 'ł');
                sum_w_taxes = sum_w_taxes.Trim(' ', 'z', 'ł');
                lot = System.Convert.ToDecimal(numbers_of_product);
                sum_NET += System.Convert.ToDecimal(sum_e_taxes);
                sum_GROS += System.Convert.ToDecimal(sum_w_taxes);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            MessageBox.Show(sum_NET.ToString(), lot.ToString());
            sum_e_taxes_label.Text = (sum_NET * lot).ToString();
            sum_w_taxes_label.Text = (sum_GROS * lot).ToString();   
        }
    }
}

