namespace E_elektryk
{
    partial class main_Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Zlecenia = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Wyceny = new System.Windows.Forms.TabPage();
            this.Kontrahenci = new System.Windows.Forms.TabPage();
            this.button_usuń_kontrahenta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lista_kontrahentów = new System.Windows.Forms.ListView();
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
            this.Magazyn = new System.Windows.Forms.TabPage();
            this.Products_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Modyfication = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Faktury = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Zlecenia.SuspendLayout();
            this.Kontrahenci.SuspendLayout();
            this.Magazyn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Zlecenia);
            this.tabControl1.Controls.Add(this.Wyceny);
            this.tabControl1.Controls.Add(this.Kontrahenci);
            this.tabControl1.Controls.Add(this.Magazyn);
            this.tabControl1.Controls.Add(this.Faktury);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // Zlecenia
            // 
            this.Zlecenia.BackColor = System.Drawing.Color.Transparent;
            this.Zlecenia.Controls.Add(this.button2);
            this.Zlecenia.Controls.Add(this.button1);
            this.Zlecenia.Location = new System.Drawing.Point(4, 22);
            this.Zlecenia.Name = "Zlecenia";
            this.Zlecenia.Padding = new System.Windows.Forms.Padding(3);
            this.Zlecenia.Size = new System.Drawing.Size(792, 424);
            this.Zlecenia.TabIndex = 0;
            this.Zlecenia.Text = "Zlecenia";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(129, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usuń Zlecenie";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj Zlecenie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Wyceny
            // 
            this.Wyceny.Location = new System.Drawing.Point(4, 22);
            this.Wyceny.Name = "Wyceny";
            this.Wyceny.Padding = new System.Windows.Forms.Padding(3);
            this.Wyceny.Size = new System.Drawing.Size(792, 424);
            this.Wyceny.TabIndex = 1;
            this.Wyceny.Text = "Wyceny";
            this.Wyceny.UseVisualStyleBackColor = true;
            // 
            // Kontrahenci
            // 
            this.Kontrahenci.Controls.Add(this.button_usuń_kontrahenta);
            this.Kontrahenci.Controls.Add(this.button6);
            this.Kontrahenci.Controls.Add(this.button7);
            this.Kontrahenci.Controls.Add(this.lista_kontrahentów);
            this.Kontrahenci.Location = new System.Drawing.Point(4, 22);
            this.Kontrahenci.Name = "Kontrahenci";
            this.Kontrahenci.Padding = new System.Windows.Forms.Padding(3);
            this.Kontrahenci.Size = new System.Drawing.Size(792, 424);
            this.Kontrahenci.TabIndex = 2;
            this.Kontrahenci.Text = "Kontrahenci";
            this.Kontrahenci.UseVisualStyleBackColor = true;
            // 
            // button_usuń_kontrahenta
            // 
            this.button_usuń_kontrahenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_usuń_kontrahenta.BackColor = System.Drawing.Color.Gainsboro;
            this.button_usuń_kontrahenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_usuń_kontrahenta.FlatAppearance.BorderSize = 2;
            this.button_usuń_kontrahenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usuń_kontrahenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_kontrahenta.Location = new System.Drawing.Point(258, 386);
            this.button_usuń_kontrahenta.Name = "button_usuń_kontrahenta";
            this.button_usuń_kontrahenta.Size = new System.Drawing.Size(130, 38);
            this.button_usuń_kontrahenta.TabIndex = 8;
            this.button_usuń_kontrahenta.Text = "Usuń";
            this.button_usuń_kontrahenta.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(129, 386);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "Modyfikuj";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(0, 386);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Dodaj ";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // lista_kontrahentów
            // 
            this.lista_kontrahentów.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lista_kontrahentów.AllowColumnReorder = true;
            this.lista_kontrahentów.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_kontrahentów.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.lista_kontrahentów.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lista_kontrahentów.FullRowSelect = true;
            this.lista_kontrahentów.GridLines = true;
            this.lista_kontrahentów.HideSelection = false;
            this.lista_kontrahentów.Location = new System.Drawing.Point(0, 0);
            this.lista_kontrahentów.MultiSelect = false;
            this.lista_kontrahentów.Name = "lista_kontrahentów";
            this.lista_kontrahentów.Size = new System.Drawing.Size(792, 380);
            this.lista_kontrahentów.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lista_kontrahentów.TabIndex = 0;
            this.lista_kontrahentów.UseCompatibleStateImageBehavior = false;
            this.lista_kontrahentów.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            this.Imie.Width = 80;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 80;
            // 
            // Pesel
            // 
            this.Pesel.Text = "Pesel";
            this.Pesel.Width = 90;
            // 
            // NIP
            // 
            this.NIP.Text = "NIP";
            this.NIP.Width = 90;
            // 
            // nazwa_Firmy
            // 
            this.nazwa_Firmy.Text = "Nazwa Firmy";
            this.nazwa_Firmy.Width = 200;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 200;
            // 
            // Email
            // 
            this.Email.Text = "Adres E-mail";
            this.Email.Width = 120;
            // 
            // Telefon_1
            // 
            this.Telefon_1.Text = "Telefon 1";
            this.Telefon_1.Width = 90;
            // 
            // Telefon_2
            // 
            this.Telefon_2.Text = "Telefon 2";
            this.Telefon_2.Width = 90;
            // 
            // Magazyn
            // 
            this.Magazyn.BackColor = System.Drawing.Color.DimGray;
            this.Magazyn.Controls.Add(this.Products_list);
            this.Magazyn.Controls.Add(this.Button_Delete);
            this.Magazyn.Controls.Add(this.Button_Modyfication);
            this.Magazyn.Controls.Add(this.Button_Add);
            this.Magazyn.Location = new System.Drawing.Point(4, 22);
            this.Magazyn.Name = "Magazyn";
            this.Magazyn.Padding = new System.Windows.Forms.Padding(3);
            this.Magazyn.Size = new System.Drawing.Size(792, 424);
            this.Magazyn.TabIndex = 3;
            this.Magazyn.Text = "Kartoteka Materiałowa";
            // 
            // Products_list
            // 
            this.Products_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Products_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_list.CheckBoxes = true;
            this.Products_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader,
            this.columnHeader9});
            this.Products_list.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Products_list.FullRowSelect = true;
            this.Products_list.GridLines = true;
            this.Products_list.HideSelection = false;
            this.Products_list.Location = new System.Drawing.Point(0, 0);
            this.Products_list.Name = "Products_list";
            this.Products_list.Size = new System.Drawing.Size(792, 380);
            this.Products_list.TabIndex = 6;
            this.Products_list.UseCompatibleStateImageBehavior = false;
            this.Products_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producent";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jm";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ilość";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cena netto";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "VAT";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cena Brutto";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 140;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "kategoria";
            this.columnHeader.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Wartość magazynu";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 160;
            // 
            // Button_Delete
            // 
            this.Button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Delete.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Delete.FlatAppearance.BorderSize = 2;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Delete.Location = new System.Drawing.Point(280, 383);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(130, 38);
            this.Button_Delete.TabIndex = 5;
            this.Button_Delete.Text = "Usuń";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Modyfication
            // 
            this.Button_Modyfication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Modyfication.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Modyfication.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Modyfication.FlatAppearance.BorderSize = 2;
            this.Button_Modyfication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modyfication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Modyfication.Location = new System.Drawing.Point(144, 383);
            this.Button_Modyfication.Name = "Button_Modyfication";
            this.Button_Modyfication.Size = new System.Drawing.Size(130, 38);
            this.Button_Modyfication.TabIndex = 4;
            this.Button_Modyfication.Text = "Modyfikuj";
            this.Button_Modyfication.UseVisualStyleBackColor = false;
            this.Button_Modyfication.Click += new System.EventHandler(this.Button_Modyfication_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Add.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Add.FlatAppearance.BorderSize = 2;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Add.Location = new System.Drawing.Point(8, 383);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(130, 38);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "Dodaj ";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Faktury
            // 
            this.Faktury.Location = new System.Drawing.Point(4, 22);
            this.Faktury.Name = "Faktury";
            this.Faktury.Size = new System.Drawing.Size(792, 424);
            this.Faktury.TabIndex = 4;
            this.Faktury.Text = "Faktury";
            this.Faktury.UseVisualStyleBackColor = true;
            // 
            // main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "main_Window";
            this.Text = "E-elektryk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Zlecenia.ResumeLayout(false);
            this.Kontrahenci.ResumeLayout(false);
            this.Magazyn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Zlecenia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Wyceny;
        private System.Windows.Forms.TabPage Kontrahenci;
        private System.Windows.Forms.Button button_usuń_kontrahenta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView lista_kontrahentów;
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
        private System.Windows.Forms.TabPage Magazyn;
        private System.Windows.Forms.ListView Products_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Modyfication;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.TabPage Faktury;
    }
}

