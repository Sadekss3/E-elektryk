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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                string login = textBox1.Text.ToLower();
                string password = textBox2.Text;
                Dane_Logowania dane_Logowania = new Dane_Logowania();
                dane_Logowania = db.Dane_Logowania.Find(login.ToLower());
                try
                {
                    if (dane_Logowania.Login.ToLower() == login && dane_Logowania.Hasło == password)
                    {
                        Close();
                    }
                    else if (login == "" || password == "")
                    {
                        MessageBox.Show("Wypełnij pola Hasło i Login", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Błędne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Wypełnij pola Hasło i Login", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Uzupełnij pole Login i Hasło", "Podaj dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text.Contains(' ') || textBox2.Text.Contains(' '))
                {
                    MessageBox.Show("Pole Hasło i Login nie mogą zawierać przerw", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (zlecenieEntities db = new zlecenieEntities())
                    {
                        try
                        {
                            Dane_Logowania _Logowanie = new Dane_Logowania();
                            _Logowanie.Login = textBox1.Text.ToLower();
                            _Logowanie.Hasło = textBox2.Text;
                            db.Dane_Logowania.Add(_Logowanie);
                            db.SaveChanges();
                            MessageBox.Show("Konto utworzone", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Konto o podanym loginie już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
