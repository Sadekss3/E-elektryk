using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_elektryk
{
    public partial class Window_Add_Product : Form
    {

        produkt _p;
        string _type;

        public Window_Add_Product()
        {
            InitializeComponent();
            _type = "Add";
        }

        public Window_Add_Product(produkt p)
        {
            InitializeComponent();
            _type = "Modyfication";
            _p = p;
            Button_Add_Product.Text = "Zmień";
            Add_Product_Information();
        }

        void Add_Product_Information()
        {
            textBox_Product_Name.Text = _p.Nazwa.ToString();
            textBox_Manufacturer.Text = _p.Producent.ToString();
            textBox_Catalog.Text = _p.Numer_katalogowy.ToString();
            textBox_Quantity.Text = _p.Ilość.ToString();
            textBox_Price_Net.Text = _p.Cena_netto.ToString();
            textBox_Price_Gross.Text = _p.Cena_brutto.ToString();
            comboBox_Unit.Text = _p.Jm.ToString();
            ComboBox_Taxes.Text = _p.Vat.ToString();
            comboBox_Product_Category.Text = _p.Kategoria.ToString();
        }

        private void Button_Add_Product_Click(object sender, EventArgs e)
        {
            if (_type == "Add")
            {
                Adding();
            }
            else
            {
                Modify();
            }
        }

        private void Adding()
        {
            produkt produkt = new produkt();
            Boolean flag;
            try
            {
                produkt.Nazwa = textBox_Product_Name.Text.ToString();
                produkt.Producent = textBox_Manufacturer.Text.ToString();
                produkt.Numer_katalogowy = textBox_Catalog.Text.ToString();
                produkt.Ilość = System.Convert.ToDouble(textBox_Quantity.Text);
                produkt.Jm = comboBox_Unit.Text.ToString();
                produkt.Cena_netto = System.Convert.ToDecimal(textBox_Price_Net.Text);
                produkt.Vat = System.Convert.ToDouble(ComboBox_Taxes.Text);
                produkt.Cena_brutto = System.Convert.ToDecimal(textBox_Price_Gross.Text);
                produkt.Kategoria = (int)comboBox_Product_Category.SelectedValue;
                flag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ilość musi być liczbą","Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }
            if (flag == true)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    db.produkt.Add(produkt);
                    db.SaveChanges();
                    MessageBox.Show("Produkt dodany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_Product_Name.Clear();
                    textBox_Manufacturer.Clear();
                    textBox_Catalog.Clear();
                    textBox_Quantity.Clear();
                    textBox_Price_Net.Clear();
                    textBox_Price_Gross.Clear();
                    comboBox_Unit.Items.Clear();
                    ComboBox_Taxes.Items.Clear();
                }
            }
        }

        void Modify()
        {
            produkt produkt = new produkt();
            Boolean flag;
            try
            {
                produkt.ID = _p.ID;
                produkt.Nazwa = textBox_Product_Name.Text.ToString();
                produkt.Producent = textBox_Manufacturer.Text.ToString();
                produkt.Numer_katalogowy = textBox_Catalog.Text.ToString();
                produkt.Ilość = System.Convert.ToDouble(textBox_Quantity.Text);
                produkt.Jm = comboBox_Unit.Text.ToString();
                produkt.Cena_netto = System.Convert.ToDecimal(textBox_Price_Net.Text);
                produkt.Vat = System.Convert.ToDouble(ComboBox_Taxes.Text);
                produkt.Cena_brutto = System.Convert.ToDecimal(textBox_Price_Gross.Text);
                produkt.Kategoria = (int)comboBox_Product_Category.SelectedValue;              
                flag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ilość musi być liczbą", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }
            if (flag == true)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    db.produkt.AddOrUpdate(produkt);
                    db.SaveChanges();
                    MessageBox.Show("Produkt zmodyfikowany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        decimal Calc_gross(decimal net, decimal tax)
        {
            decimal gross;
            gross = net + (net * (tax / 100));
            return gross;
        }

        void Add_gross_price()
        {
            if (textBox_Price_Net.Text != "" && ComboBox_Taxes.Text != "")
            {
                decimal net = 0;
                decimal taxes = 0;
                try
                {
                    net = System.Convert.ToDecimal(textBox_Price_Net.Text);
                    taxes = System.Convert.ToDecimal(ComboBox_Taxes.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cena musi być liczbą!");
                }
                decimal brutto = Calc_gross(net, taxes);
                textBox_Price_Gross.Text = brutto.ToString();
            }
        }

        private void ComboBox_Taxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_gross_price();
        }

        private void Window_Add_Product_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zlecenieDataSet.kategoria_produktu' . Możesz go przenieść lub usunąć.
            this.kategoria_produktuTableAdapter.Fill(this.zlecenieDataSet.kategoria_produktu);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zlecenieDataSet.produkt' . Możesz go przenieść lub usunąć.
        }
    }
}
