using MySql.Data.MySqlClient.Memcached;
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
    public partial class Window_Add_Client : Form
    {

        string _type;
        kontrahent _k;

        public Window_Add_Client()
        {
            InitializeComponent();
            _type = "Dodawanie";
        }

        public Window_Add_Client(kontrahent k)
        {
            InitializeComponent();
            _type = "Modyfikacja";
            _k = k;
            Button_Add_New_Client.Text = "Zmień";
            Add_Client_Information();
        }

        void Add_Client_Information()
        {
            textBox_Name.Text = _k.Imie.ToString();
            textBox_Lastname.Text = _k.Nazwisko.ToString();
            textBox_PESEL.Text = _k.Pesel.ToString();
            textBox_NIP.Text = _k.NIP.ToString();
            textBox_Adress.Text = _k.Adres.ToString();
            textBox_Company_Name.Text = _k.ToString();
            textBox_Email_Adress.Text = _k.E_mail.ToString();
            textBox_Phone_Number_1.Text = _k.Telefon_1.ToString();
            textBox_Phone_Number_2.Text = _k.Telefon_2.ToString();
        }

        private void Button_Add_New_Client_Click(object sender, EventArgs e)
        {
            if (_type == "Dodawanie")
            {
                Add_New_Client();
            }
            else
            {
                Modyficate_Client_Info();
            }
        }

        private void Add_New_Client()
        {
            kontrahent kontrahent = new kontrahent();
            Boolean flag = true;
            try
            {
                kontrahent.Imie = textBox_Name.Text.ToString();
                kontrahent.Nazwisko = textBox_Lastname.Text.ToString();
                kontrahent.Pesel = System.Convert.ToInt64(textBox_PESEL.Text);
                kontrahent.NIP = System.Convert.ToInt64(textBox_NIP.Text);
                kontrahent.Nazwa_Firmy = textBox_Company_Name.Text.ToString();
                kontrahent.Adres = textBox_Adress.Text.ToString();
                kontrahent.E_mail = textBox_Email_Adress.Text.ToString();
                kontrahent.Telefon_1 = textBox_Phone_Number_1.Text.ToString();
                kontrahent.Telefon_2 = textBox_Phone_Number_2.Text.ToString();
                flag = true;
            }
            catch (Exception f)
            {
                MessageBox.Show("Podano nieprawidłowy numer NIP lub PESEL");
                flag = false;
            }
            if (flag == true)
            {
                using (zlecenieEntities db = new zlecenieEntities())
                {
                    db.kontrahent.Add(kontrahent);
                    db.SaveChanges();
                    MessageBox.Show("Kontrahent dodany", "OK", MessageBoxButtons.OK);
                }
            }
        }

        private void Modyficate_Client_Info()
        {

        }
    }
}
