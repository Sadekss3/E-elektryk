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
            this.Delete_Offer = new System.Windows.Forms.Button();
            this.Button_Modyficate_Offer = new System.Windows.Forms.Button();
            this.Button_Add_Offer = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_offer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Order_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kontrahenci = new System.Windows.Forms.TabPage();
            this.Button_Delete_Client = new System.Windows.Forms.Button();
            this.Button_Datamod_Client = new System.Windows.Forms.Button();
            this.Button_Add_Client = new System.Windows.Forms.Button();
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
            this.Magazyn = new System.Windows.Forms.TabPage();
            this.Products_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Wyceny.SuspendLayout();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.Wyceny.BackColor = System.Drawing.Color.DimGray;
            this.Wyceny.Controls.Add(this.Delete_Offer);
            this.Wyceny.Controls.Add(this.Button_Modyficate_Offer);
            this.Wyceny.Controls.Add(this.Button_Add_Offer);
            this.Wyceny.Controls.Add(this.listView1);
            this.Wyceny.Location = new System.Drawing.Point(4, 22);
            this.Wyceny.Name = "Wyceny";
            this.Wyceny.Padding = new System.Windows.Forms.Padding(3);
            this.Wyceny.Size = new System.Drawing.Size(792, 424);
            this.Wyceny.TabIndex = 1;
            this.Wyceny.Text = "Wyceny";
            // 
            // Delete_Offer
            // 
            this.Delete_Offer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_Offer.BackColor = System.Drawing.Color.Gainsboro;
            this.Delete_Offer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete_Offer.FlatAppearance.BorderSize = 2;
            this.Delete_Offer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Offer.Location = new System.Drawing.Point(280, 383);
            this.Delete_Offer.Name = "Delete_Offer";
            this.Delete_Offer.Size = new System.Drawing.Size(130, 38);
            this.Delete_Offer.TabIndex = 11;
            this.Delete_Offer.Text = "Usuń";
            this.Delete_Offer.UseVisualStyleBackColor = false;
            // 
            // Button_Modyficate_Offer
            // 
            this.Button_Modyficate_Offer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Modyficate_Offer.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Modyficate_Offer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Modyficate_Offer.FlatAppearance.BorderSize = 2;
            this.Button_Modyficate_Offer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modyficate_Offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Modyficate_Offer.Location = new System.Drawing.Point(145, 383);
            this.Button_Modyficate_Offer.Name = "Button_Modyficate_Offer";
            this.Button_Modyficate_Offer.Size = new System.Drawing.Size(130, 38);
            this.Button_Modyficate_Offer.TabIndex = 10;
            this.Button_Modyficate_Offer.Text = "Modyfikuj";
            this.Button_Modyficate_Offer.UseVisualStyleBackColor = false;
            // 
            // Button_Add_Offer
            // 
            this.Button_Add_Offer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Add_Offer.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Add_Offer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Add_Offer.FlatAppearance.BorderSize = 2;
            this.Button_Add_Offer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Add_Offer.Location = new System.Drawing.Point(10, 383);
            this.Button_Add_Offer.Name = "Button_Add_Offer";
            this.Button_Add_Offer.Size = new System.Drawing.Size(130, 38);
            this.Button_Add_Offer.TabIndex = 9;
            this.Button_Add_Offer.Text = "Dodaj ";
            this.Button_Add_Offer.UseVisualStyleBackColor = false;
            this.Button_Add_Offer.Click += new System.EventHandler(this.Button_Add_Offer_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_offer,
            this.Offer_name,
            this.Offer_Client,
            this.Offer_Order_Adress,
            this.Offer_Date,
            this.Offer_Status});
            this.listView1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(792, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID_offer
            // 
            this.ID_offer.Text = "ID";
            this.ID_offer.Width = 45;
            // 
            // Offer_name
            // 
            this.Offer_name.Text = "Nazwa";
            this.Offer_name.Width = 140;
            // 
            // Offer_Client
            // 
            this.Offer_Client.Text = "Zleceniodawca";
            this.Offer_Client.Width = 145;
            // 
            // Offer_Order_Adress
            // 
            this.Offer_Order_Adress.Text = "Adres zlecenia";
            this.Offer_Order_Adress.Width = 160;
            // 
            // Offer_Date
            // 
            this.Offer_Date.Text = "Data_wyceny";
            this.Offer_Date.Width = 130;
            // 
            // Offer_Status
            // 
            this.Offer_Status.Text = "Status  wyceny";
            this.Offer_Status.Width = 120;
            // 
            // Kontrahenci
            // 
            this.Kontrahenci.BackColor = System.Drawing.Color.DimGray;
            this.Kontrahenci.Controls.Add(this.Button_Delete_Client);
            this.Kontrahenci.Controls.Add(this.Button_Datamod_Client);
            this.Kontrahenci.Controls.Add(this.Button_Add_Client);
            this.Kontrahenci.Controls.Add(this.Client_list);
            this.Kontrahenci.Location = new System.Drawing.Point(4, 22);
            this.Kontrahenci.Name = "Kontrahenci";
            this.Kontrahenci.Padding = new System.Windows.Forms.Padding(3);
            this.Kontrahenci.Size = new System.Drawing.Size(792, 424);
            this.Kontrahenci.TabIndex = 2;
            this.Kontrahenci.Text = "Kontrahenci";
            // 
            // Button_Delete_Client
            // 
            this.Button_Delete_Client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Delete_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Delete_Client.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Delete_Client.FlatAppearance.BorderSize = 2;
            this.Button_Delete_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Delete_Client.Location = new System.Drawing.Point(280, 383);
            this.Button_Delete_Client.Name = "Button_Delete_Client";
            this.Button_Delete_Client.Size = new System.Drawing.Size(130, 38);
            this.Button_Delete_Client.TabIndex = 8;
            this.Button_Delete_Client.Text = "Usuń";
            this.Button_Delete_Client.UseVisualStyleBackColor = false;
            this.Button_Delete_Client.Click += new System.EventHandler(this.Button_Delete_Client_Click);
            // 
            // Button_Datamod_Client
            // 
            this.Button_Datamod_Client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Datamod_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Datamod_Client.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Datamod_Client.FlatAppearance.BorderSize = 2;
            this.Button_Datamod_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Datamod_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Datamod_Client.Location = new System.Drawing.Point(145, 383);
            this.Button_Datamod_Client.Name = "Button_Datamod_Client";
            this.Button_Datamod_Client.Size = new System.Drawing.Size(130, 38);
            this.Button_Datamod_Client.TabIndex = 7;
            this.Button_Datamod_Client.Text = "Modyfikuj";
            this.Button_Datamod_Client.UseVisualStyleBackColor = false;
            this.Button_Datamod_Client.Click += new System.EventHandler(this.Button_Datamod_Client_Click);
            // 
            // Button_Add_Client
            // 
            this.Button_Add_Client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Add_Client.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Add_Client.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Add_Client.FlatAppearance.BorderSize = 2;
            this.Button_Add_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Add_Client.Location = new System.Drawing.Point(10, 383);
            this.Button_Add_Client.Name = "Button_Add_Client";
            this.Button_Add_Client.Size = new System.Drawing.Size(130, 38);
            this.Button_Add_Client.TabIndex = 6;
            this.Button_Add_Client.Text = "Dodaj ";
            this.Button_Add_Client.UseVisualStyleBackColor = false;
            this.Button_Add_Client.Click += new System.EventHandler(this.Button_Add_Client_Click);
            // 
            // Client_list
            // 
            this.Client_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Client_list.AllowColumnReorder = true;
            this.Client_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Client_list.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Client_list.FullRowSelect = true;
            this.Client_list.GridLines = true;
            this.Client_list.HideSelection = false;
            this.Client_list.Location = new System.Drawing.Point(0, 0);
            this.Client_list.MultiSelect = false;
            this.Client_list.Name = "Client_list";
            this.Client_list.Size = new System.Drawing.Size(792, 380);
            this.Client_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Client_list.TabIndex = 0;
            this.Client_list.UseCompatibleStateImageBehavior = false;
            this.Client_list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
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
            this.Adres.Width = 400;
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
            this.columnHeade,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader,
            this.columnHeader9});
            this.Products_list.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            // columnHeade
            // 
            this.columnHeade.Text = "Symbol Katalogowy";
            this.columnHeade.Width = 180;
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
            this.columnHeader.Width = 180;
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
            this.Button_Modyfication.Location = new System.Drawing.Point(145, 383);
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
            this.Button_Add.Location = new System.Drawing.Point(10, 383);
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
            this.Text = "E-Elektryk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Zlecenia.ResumeLayout(false);
            this.Wyceny.ResumeLayout(false);
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
        private System.Windows.Forms.Button Button_Delete_Client;
        private System.Windows.Forms.Button Button_Datamod_Client;
        private System.Windows.Forms.Button Button_Add_Client;
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
        private System.Windows.Forms.Button Delete_Offer;
        private System.Windows.Forms.Button Button_Modyficate_Offer;
        private System.Windows.Forms.Button Button_Add_Offer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_offer;
        private System.Windows.Forms.ColumnHeader Offer_name;
        private System.Windows.Forms.ColumnHeader Offer_Client;
        private System.Windows.Forms.ColumnHeader Offer_Order_Adress;
        private System.Windows.Forms.ColumnHeader Offer_Date;
        private System.Windows.Forms.ColumnHeader Offer_Status;
        private System.Windows.Forms.ColumnHeader columnHeade;
    }
}

