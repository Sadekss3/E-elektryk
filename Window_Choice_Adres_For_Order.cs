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
            Client_List_Update();
            _a = a;
        }

        private void Client_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Adres_list.Items.Clear();
                    List<adres> list = db.adres.ToList();
                    foreach (adres A in list)
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
    }
}
