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

    public partial class Window_Choice_Client_For_Offer : Form
    {
        kontrahent _k;
        public Window_Choice_Client_For_Offer(kontrahent k)
        {
            InitializeComponent();
            Client_List_Update();
            _k = k;
        }

        private void Client_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Client_list.Items.Clear();
                    List<kontrahent> list = db.kontrahent.ToList();
                    foreach (kontrahent C in list)
                    {
                        ListViewItem item = new ListViewItem(C.ID.ToString());
                        item.SubItems.Add(C.Imie);
                        item.SubItems.Add(C.Nazwisko);
                        item.SubItems.Add(C.Pesel.ToString());
                        item.SubItems.Add(C.NIP.ToString());
                        item.SubItems.Add(C.Nazwa_Firmy);
                        item.SubItems.Add(C.Adres);
                        item.SubItems.Add(C.E_mail);
                        item.SubItems.Add(C.Telefon_1.ToString());
                        item.SubItems.Add(C.Telefon_2.ToString());
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        Client_list.Items.Add(item);
                    }
                }
                catch (Exception f)
                {
                    Environment.Exit(1);
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Clients information from DB to listView 

        private void Client_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = Client_list.SelectedItems[0];
            int ID = System.Convert.ToInt32(item.Text);
            /*using (zlecenieEntities db = new zlecenieEntities())
            {
                _k = db.kontrahent.Find(ID);

            }*/
            _k.ID = ID;
            this.Close();
        }
    }
}
