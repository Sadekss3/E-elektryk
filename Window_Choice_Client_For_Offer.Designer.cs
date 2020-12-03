namespace E_elektryk
{
    partial class Window_Choice_Client_For_Offer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Client_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwa_Firmy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_home = new System.Windows.Forms.TextBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kod_2 = new System.Windows.Forms.TextBox();
            this.textBox_kod_1 = new System.Windows.Forms.TextBox();
            this.textBox_town = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Add_New_Address = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_firma = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_nip = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_pesel = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_tel2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client_list
            // 
            this.Client_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Client_list.AllowColumnReorder = true;
            this.Client_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Imie,
            this.Nazwisko,
            this.Pesel,
            this.NIP,
            this.nazwa_Firmy,
            this.Adres,
            this.Email,
            this.Telefon_1,
            this.Telefon_2});
            this.Client_list.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Client_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Client_list.FullRowSelect = true;
            this.Client_list.GridLines = true;
            this.Client_list.HideSelection = false;
            this.Client_list.Location = new System.Drawing.Point(0, 46);
            this.Client_list.MultiSelect = false;
            this.Client_list.Name = "Client_list";
            this.Client_list.Size = new System.Drawing.Size(1534, 704);
            this.Client_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Client_list.TabIndex = 22;
            this.Client_list.UseCompatibleStateImageBehavior = false;
            this.Client_list.View = System.Windows.Forms.View.Details;
            this.Client_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Client_list_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            this.Imie.Width = 120;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 120;
            // 
            // Pesel
            // 
            this.Pesel.Text = "Pesel";
            this.Pesel.Width = 130;
            // 
            // NIP
            // 
            this.NIP.Text = "NIP";
            this.NIP.Width = 130;
            // 
            // nazwa_Firmy
            // 
            this.nazwa_Firmy.Text = "Nazwa Firmy";
            this.nazwa_Firmy.Width = 250;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 330;
            // 
            // Email
            // 
            this.Email.Text = "Adres E-mail";
            this.Email.Width = 160;
            // 
            // Telefon_1
            // 
            this.Telefon_1.Text = "Telefon 1";
            this.Telefon_1.Width = 120;
            // 
            // Telefon_2
            // 
            this.Telefon_2.Text = "Telefon 2";
            this.Telefon_2.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1534, 46);
            this.panel3.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(731, 10);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 20);
            this.textBox6.TabIndex = 23;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(630, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID Kontrahenta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(360, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nazwa Konbtrahenta:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(493, 10);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nazwa firmy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Szukaj po:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_Add_New_Address);
            this.panel1.Controls.Add(this.Button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 104);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.textBox_tel2);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBox_tel);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox_email);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBox_nip);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.textBox_pesel);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox_firma);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox_nazwisko);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox_imie);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox_home);
            this.panel2.Controls.Add(this.textBox_building);
            this.panel2.Controls.Add(this.textBox_street);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_kod_2);
            this.panel2.Controls.Add(this.textBox_kod_1);
            this.panel2.Controls.Add(this.textBox_town);
            this.panel2.Controls.Add(this.label12);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 93);
            this.panel2.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PL",
            "UE",
            "UA",
            "DE"});
            this.comboBox1.Location = new System.Drawing.Point(932, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox_home
            // 
            this.textBox_home.Location = new System.Drawing.Point(932, 22);
            this.textBox_home.Name = "textBox_home";
            this.textBox_home.Size = new System.Drawing.Size(58, 20);
            this.textBox_home.TabIndex = 13;
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(785, 53);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(58, 20);
            this.textBox_building.TabIndex = 12;
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(750, 22);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(93, 20);
            this.textBox_street.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(849, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Państwo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label10.Location = new System.Drawing.Point(849, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nr. Mieszkania";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nr. Budynku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kod \r\nPocztowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miasto";
            // 
            // textBox_kod_2
            // 
            this.textBox_kod_2.Location = new System.Drawing.Point(652, 54);
            this.textBox_kod_2.Name = "textBox_kod_2";
            this.textBox_kod_2.Size = new System.Drawing.Size(55, 20);
            this.textBox_kod_2.TabIndex = 3;
            // 
            // textBox_kod_1
            // 
            this.textBox_kod_1.Location = new System.Drawing.Point(607, 53);
            this.textBox_kod_1.Name = "textBox_kod_1";
            this.textBox_kod_1.Size = new System.Drawing.Size(23, 20);
            this.textBox_kod_1.TabIndex = 2;
            // 
            // textBox_town
            // 
            this.textBox_town.Location = new System.Drawing.Point(607, 22);
            this.textBox_town.Name = "textBox_town";
            this.textBox_town.Size = new System.Drawing.Size(100, 20);
            this.textBox_town.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nowy Klient";
            // 
            // button_Add_New_Address
            // 
            this.button_Add_New_Address.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Add_New_Address.FlatAppearance.BorderSize = 0;
            this.button_Add_New_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_New_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Add_New_Address.ForeColor = System.Drawing.Color.Black;
            this.button_Add_New_Address.Location = new System.Drawing.Point(1018, 58);
            this.button_Add_New_Address.Name = "button_Add_New_Address";
            this.button_Add_New_Address.Size = new System.Drawing.Size(110, 38);
            this.button_Add_New_Address.TabIndex = 51;
            this.button_Add_New_Address.Text = "Dodaj nowy adres";
            this.button_Add_New_Address.UseVisualStyleBackColor = false;
            this.button_Add_New_Address.Click += new System.EventHandler(this.button_Add_New_Address_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel.FlatAppearance.BorderSize = 0;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Button_Cancel.Location = new System.Drawing.Point(1396, 60);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(110, 32);
            this.Button_Cancel.TabIndex = 50;
            this.Button_Cancel.Text = "Anuluj";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(550, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Imie";
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(69, 19);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(100, 20);
            this.textBox_imie.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Nazwisko";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(69, 45);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwisko.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Firma";
            // 
            // textBox_firma
            // 
            this.textBox_firma.Location = new System.Drawing.Point(69, 71);
            this.textBox_firma.Name = "textBox_firma";
            this.textBox_firma.Size = new System.Drawing.Size(100, 20);
            this.textBox_firma.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(175, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "E-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(232, 71);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "NIP";
            // 
            // textBox_nip
            // 
            this.textBox_nip.Location = new System.Drawing.Point(232, 45);
            this.textBox_nip.Name = "textBox_nip";
            this.textBox_nip.Size = new System.Drawing.Size(100, 20);
            this.textBox_nip.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(175, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Pesel";
            // 
            // textBox_pesel
            // 
            this.textBox_pesel.Location = new System.Drawing.Point(232, 19);
            this.textBox_pesel.Name = "textBox_pesel";
            this.textBox_pesel.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesel.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(341, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Telefon 2";
            // 
            // textBox_tel2
            // 
            this.textBox_tel2.Location = new System.Drawing.Point(398, 45);
            this.textBox_tel2.Name = "textBox_tel2";
            this.textBox_tel2.Size = new System.Drawing.Size(100, 20);
            this.textBox_tel2.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(341, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Telefon";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(398, 19);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 20);
            this.textBox_tel.TabIndex = 55;
            // 
            // Window_Choice_Client_For_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1534, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Client_list);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Choice_Client_For_Offer";
            this.Text = "Window_Choice_Client_For_Offer";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Client_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Pesel;
        private System.Windows.Forms.ColumnHeader NIP;
        private System.Windows.Forms.ColumnHeader nazwa_Firmy;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon_1;
        private System.Windows.Forms.ColumnHeader Telefon_2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_home;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kod_2;
        private System.Windows.Forms.TextBox textBox_kod_1;
        private System.Windows.Forms.TextBox textBox_town;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Add_New_Address;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_nip;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_pesel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_firma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_tel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_tel;
    }
}