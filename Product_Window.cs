﻿using System;
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
    public partial class Product_Window : Form
    {
        public int _Selected_Product_ID;

        public Product_Window()
        {
            InitializeComponent();
            Product_List_Update();
        }
        public Product_Window(int Selected_Product_ID)
        {
            InitializeComponent();
            Product_List_Update();
            _Selected_Product_ID = Selected_Product_ID;
        }
        private void Product_List_Update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                Products_list.Items.Clear();
                List<produkt> list = db.produkt.ToList();
                foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_product_name_search.Text.ToLower()) && lvi.Producent.ToLower().Contains(textBox_product_producent_search.Text.ToLower()) && lvi.Numer_katalogowy.ToLower().Contains(textBox_product_symbol_search.Text.ToLower())))
                {
                    decimal value = Math.Round(p.Cena_netto * System.Convert.ToDecimal(p.Ilość), 2);
                    ListViewItem item = new ListViewItem(p.ID.ToString());
                    item.SubItems.Add(p.Nazwa);
                    item.SubItems.Add(p.Producent);
                    item.SubItems.Add(p.Numer_katalogowy);
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
                    item.SubItems.Add(value.ToString() + " zł");
                    item.Font = new Font(item.Font, FontStyle.Regular);
                    Products_list.Items.Add(item);
                }
            }
            Cursor.Current = Cursors.Default;
        } // Add Products information from DB to listView

        private void textBox_product_name_search_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                Products_list.Items.Clear();
                List<produkt> list = db.produkt.ToList();
                foreach (produkt p in list.Where(lvi => lvi.Nazwa.ToLower().Contains(textBox_product_name_search.Text.ToLower()) && lvi.Producent.ToLower().Contains(textBox_product_producent_search.Text.ToLower()) && lvi.Numer_katalogowy.ToLower().Contains(textBox_product_symbol_search.Text.ToLower())))
                {
                    decimal value = Math.Round(p.Cena_netto * System.Convert.ToDecimal(p.Ilość), 2);
                    ListViewItem item = new ListViewItem(p.ID.ToString());
                    item.SubItems.Add(p.Nazwa);
                    item.SubItems.Add(p.Producent);
                    item.SubItems.Add(p.Numer_katalogowy);
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
                    item.SubItems.Add(value.ToString() + " zł");
                    item.Font = new Font(item.Font, FontStyle.Regular);
                    Products_list.Items.Add(item);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void Products_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                if (Products_list.SelectedItems.Count > 0)
                {
                    _Selected_Product_ID = System.Convert.ToInt32(Products_list.SelectedItems[0].Text);
                }
            }   
        }
    }
}
