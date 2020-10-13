﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_elektryk
{
    public partial class main_Window : Form
    {
        public main_Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product_List_Update();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Window_Add_Product window_add = new Window_Add_Product();
            window_add.ShowDialog();
        }

        private void Button_Modyfication_Click(object sender, EventArgs e)
        {
            if (Products_list.SelectedItems.Count <= 0)
            {
            }
            else
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    string ID = Products_list.SelectedItems[0].Text;
                    int numer_ID = System.Convert.ToInt32(ID);
                    produkt m = db.produkt.Find(numer_ID);
                    Window_Add_Product mod = new Window_Add_Product(m);
                    mod.ShowDialog();
                }
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (Products_list.SelectedItems.Count <= 0)
            {
            }
            else
            {
                string ID = Products_list.SelectedItems[0].Text;
                int ID_number = System.Convert.ToInt32(ID);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Czy na pewno chcesz usunąć pozycje?", "Usuwanie", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (zlecenieEntities db = new zlecenieEntities())
                    {
                        produkt p = db.produkt.Find(ID_number);
                        string name_p = p.Nazwa;
                        db.produkt.Remove(p);
                        db.SaveChanges();
                        MessageBox.Show("Produkt " + name_p + " usunięty", "OK", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void Product_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    Products_list.Items.Clear();
                    List<produkt> list = db.produkt.ToList();
                    foreach (produkt p in list)
                    {
                        decimal value = Math.Round(p.Cena_netto * System.Convert.ToDecimal(p.Ilość), 2);
                        ListViewItem item = new ListViewItem(p.ID.ToString());
                        item.SubItems.Add(p.Nazwa);
                        item.SubItems.Add(p.Producent);
                        item.SubItems.Add(p.Jm);
                        item.SubItems.Add(p.Ilość.ToString());
                        item.SubItems.Add(p.Cena_netto.ToString() + " zł");
                        item.SubItems.Add(p.Vat.ToString() + " %");
                        item.SubItems.Add(p.Cena_brutto.ToString() + " zł");
                        item.SubItems.Add(p.Kategoria.ToString());
                        item.SubItems.Add(value.ToString() + " zł");
                        Products_list.Items.Add(item);
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Brak połączenia do bazy danych", "Błąd Bazy Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
        }
    }
}
