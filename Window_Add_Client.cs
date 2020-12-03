using MySql.Data.MySqlClient.Memcached;
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
    public partial class Window_Add_Client : Form
    { 
        string _type;
        kontrahent _k;

        public Window_Add_Client()  
        {
            InitializeComponent();
            _type = "Add";
        }

        public Window_Add_Client(kontrahent k)
        {
            InitializeComponent();
            _type = "Modyfication";
            _k = k;
            Button_Add_New_Client.Text = "Zmień";
            Add_Client_Information();
        }

        void Add_Client_Information()
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                adres adres = new adres();
                textBox_Name.Text = _k.Imie.ToString();
                textBox_Lastname.Text = _k.Nazwisko.ToString();
                textBox_PESEL.Text = _k.Pesel.ToString();
                textBox_NIP.Text = _k.NIP.ToString();
                adres = db.adres.Find(_k.Adres);
                textBox_Adress_Town_Name.Text = adres.Miasto.ToString();
                textBox_Street_Name.Text = adres.Nazwa_ulicy.ToString();
                textBox_Code_1.Text = adres.Kod_pocztowy.ToString().Remove(2, 3);
                textBox_Code_2.Text = adres.Kod_pocztowy.ToString().Remove(0, 2);
                textBox_Building_Number.Text = adres.Numer_budynku.ToString();
                textBox_Home_Number.Text = adres.Numer_mieszkania.ToString();
                comboBox_Country_ID.Text = adres.Państwo.ToString();
                textBox_Company_Name.Text = _k.Nazwa_Firmy.ToString();
                textBox_Email_Adress.Text = _k.E_mail.ToString();
                textBox_Phone_Number_1.Text = _k.Telefon_1.ToString();
                textBox_Phone_Number_2.Text = _k.Telefon_2.ToString();
            }           
        }

        private void Button_Add_New_Client_Click(object sender, EventArgs e)
        {
            if (_type == "Add")
            {
                Add_New_Client();
            }
            else
            {
                Modify_Client_Info();
            }
        }

        private void Add_New_Client()
        { 
            var Adress = new adres();
            var kontrahent = new kontrahent();
            Boolean flag = false;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    kontrahent.Imie = textBox_Name.Text.ToString();
                    kontrahent.Nazwisko = textBox_Lastname.Text.ToString();
                    if (textBox_PESEL.Text == "")
                        kontrahent.Pesel = null;
                    else
                        kontrahent.Pesel = System.Convert.ToInt64(textBox_PESEL.Text);
                    if (textBox_NIP.Text == "")
                        kontrahent.NIP = null;
                    else
                        kontrahent.NIP = System.Convert.ToInt64(textBox_NIP.Text);

                    kontrahent.Nazwa_Firmy = textBox_Company_Name.Text.ToString();
                    Adress.Miasto = textBox_Adress_Town_Name.Text;
                    Adress.Nazwa_ulicy = textBox_Street_Name.Text;
                    Adress.Kod_pocztowy = textBox_Code_1.Text + textBox_Code_2.Text;
                    Adress.Numer_budynku = textBox_Building_Number.Text;
                    Adress.Numer_mieszkania = textBox_Home_Number.Text;
                    Adress.Państwo = comboBox_Country_ID.Text;
                    db.adres.AddOrUpdate(Adress);
                    db.SaveChanges();
                    kontrahent.E_mail = textBox_Email_Adress.Text.ToString();
                    kontrahent.Telefon_1 = textBox_Phone_Number_1.Text.ToString();
                    kontrahent.Telefon_2 = textBox_Phone_Number_2.Text.ToString();
                    kontrahent.Adres = Adress.ID;
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano nieprawidłowy numer NIP lub PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                if (flag == true)
                {
                    db.kontrahent.Add(kontrahent);
                    db.SaveChanges();
                    MessageBox.Show("Kontrahent dodany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Modify_Client_Info()
        {
            kontrahent kontrahent = new kontrahent();
            adres Adress = new adres();
            Boolean flag = true;
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    kontrahent.ID = _k.ID;
                    kontrahent.Imie = textBox_Name.Text;
                    kontrahent.Nazwisko = textBox_Lastname.Text;
                    kontrahent.NIP = System.Convert.ToInt64(textBox_NIP.Text);
                    kontrahent.Pesel = System.Convert.ToInt64(textBox_PESEL.Text);
                    kontrahent.Nazwa_Firmy = textBox_Company_Name.Text;
                    Adress.Miasto = textBox_Adress_Town_Name.Text;
                    Adress.Nazwa_ulicy = textBox_Street_Name.Text;
                    Adress.Kod_pocztowy = textBox_Code_1.Text + textBox_Code_2.Text;
                    Adress.Numer_budynku = textBox_Building_Number.Text;
                    Adress.Numer_mieszkania = textBox_Home_Number.Text;
                    Adress.Państwo = comboBox_Country_ID.Text;
                    db.adres.AddOrUpdate(Adress);
                    db.SaveChanges();
                    kontrahent.E_mail = textBox_Email_Adress.Text;
                    kontrahent.Telefon_1 = textBox_Phone_Number_1.Text;
                    kontrahent.Telefon_2 = textBox_Phone_Number_2.Text;
                    kontrahent.Adres = Adress.ID;
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano nieprawidłowy numer NIP lub PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                if (flag == true)
                {
                    db.kontrahent.AddOrUpdate(kontrahent);
                    db.SaveChanges();
                    MessageBox.Show("Dane kontrahenta zmienione", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
