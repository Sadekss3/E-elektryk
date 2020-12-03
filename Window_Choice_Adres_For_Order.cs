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
    public partial class Window_Choice_Adres_For_Order : Form
    {
        adres _a;
        public Window_Choice_Adres_For_Order(adres a)
        {
            InitializeComponent();
            Address_List_Update();
            _a = a;
        }

        private void Address_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Adres_list.Items.Clear();
                    List<adres> list = db.adres.ToList();
                    foreach (adres A in list.Where(lvi => lvi.Miasto.ToLower().Contains(textBox_Town_Name.Text.ToLower()) && lvi.Nazwa_ulicy.ToLower().Contains(textBox_Street_Name.Text.ToLower())))
                    {
                        ListViewItem item = new ListViewItem(A.ID.ToString());
                        item.SubItems.Add(A.Miasto.ToString());
                        item.SubItems.Add(A.Kod_pocztowy.ToString().Remove(2, 3) + "-" + A.Kod_pocztowy.ToString().Remove(0, 2));
                        item.SubItems.Add(A.Nazwa_ulicy.ToString());
                        item.SubItems.Add(A.Numer_budynku.ToString());
                        item.SubItems.Add(A.Numer_mieszkania.ToString());
                        item.SubItems.Add(A.Państwo.ToString());                       
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Adres_list.Items.Add(item);
                    }
                }
                catch (Exception e) 
                {
                    MessageBox.Show(e.Message);
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Adres information from DB to listView 

        private void Adres_list_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = Adres_list.SelectedItems[0];
            int ID = System.Convert.ToInt32(item.Text);
            _a.ID = ID;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_New_Address_Click(object sender, EventArgs e)
        {
            var Address = new adres();
            Boolean flag = false;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {                    
                    Address.Miasto = textBox_town.Text;
                    Address.Nazwa_ulicy = textBox_street.Text;
                    if(textBox_kod_1.TextLength == 2 && textBox_kod_2.TextLength == 3)
                    {
                        Address.Kod_pocztowy = textBox_kod_1.Text + textBox_kod_2.Text;
                        Address.Numer_budynku = textBox_building.Text;
                        Address.Numer_mieszkania = textBox_home.Text;
                        Address.Państwo = comboBox1.Text;
                        flag = true;                       
                    }
                    else
                    {
                        MessageBox.Show("Błąd dla kodu pocztowego", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                       
                }
                catch (Exception)
                {
                    MessageBox.Show("Wypełnij wszystkie dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                if (flag == true)
                {
                    db.adres.Add(Address);
                    db.SaveChanges();
                    MessageBox.Show("Adres dodany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Address_List_Update();
                }
            }
        }

        private void Window_Choice_Adres_For_Order_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zlecenieDataSet.adres' . Możesz go przenieść lub usunąć.
            this.adresTableAdapter.Fill(this.zlecenieDataSet.adres);
        }

        private void textBox_Town_Name_TextChanged(object sender, EventArgs e)
        {
            Address_List_Update();
        }
    }
}
