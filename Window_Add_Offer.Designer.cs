namespace E_elektryk
{
    partial class Window_Add_Offer
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
            this.components = new System.ComponentModel.Container();
            this.Button_Cancel_Offer = new System.Windows.Forms.Button();
            this.Button_Save_Offer = new System.Windows.Forms.Button();
            this.label_Offer_Name = new System.Windows.Forms.Label();
            this.label_Offer_Adress = new System.Windows.Forms.Label();
            this.label_Offer_Client = new System.Windows.Forms.Label();
            this.label_Offer_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Offer_Name = new System.Windows.Forms.TextBox();
            this.textBox_Offer_Adress = new System.Windows.Forms.TextBox();
            this.Button_chose_Client = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zlecenieDataSet = new E_elektryk.zlecenieDataSet();
            this.produktTableAdapter = new E_elektryk.zlecenieDataSetTableAdapters.produktTableAdapter();
            this.sum_e_taxes_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum_w_taxes_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancel_Offer
            // 
            this.Button_Cancel_Offer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel_Offer.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel_Offer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel_Offer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Cancel_Offer.FlatAppearance.BorderSize = 2;
            this.Button_Cancel_Offer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel_Offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Cancel_Offer.Location = new System.Drawing.Point(2924, 1313);
            this.Button_Cancel_Offer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button_Cancel_Offer.Name = "Button_Cancel_Offer";
            this.Button_Cancel_Offer.Size = new System.Drawing.Size(260, 73);
            this.Button_Cancel_Offer.TabIndex = 12;
            this.Button_Cancel_Offer.Text = "Anuluj";
            this.Button_Cancel_Offer.UseVisualStyleBackColor = false;
            // 
            // Button_Save_Offer
            // 
            this.Button_Save_Offer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save_Offer.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Save_Offer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Save_Offer.FlatAppearance.BorderSize = 2;
            this.Button_Save_Offer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save_Offer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Save_Offer.Location = new System.Drawing.Point(2652, 1313);
            this.Button_Save_Offer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button_Save_Offer.Name = "Button_Save_Offer";
            this.Button_Save_Offer.Size = new System.Drawing.Size(260, 73);
            this.Button_Save_Offer.TabIndex = 13;
            this.Button_Save_Offer.Text = "Zapisz";
            this.Button_Save_Offer.UseVisualStyleBackColor = false;
            // 
            // label_Offer_Name
            // 
            this.label_Offer_Name.AutoSize = true;
            this.label_Offer_Name.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Offer_Name.Location = new System.Drawing.Point(6, 6);
            this.label_Offer_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Offer_Name.Name = "label_Offer_Name";
            this.label_Offer_Name.Size = new System.Drawing.Size(202, 29);
            this.label_Offer_Name.TabIndex = 14;
            this.label_Offer_Name.Text = "Nazwa zlecenia";
            // 
            // label_Offer_Adress
            // 
            this.label_Offer_Adress.AutoSize = true;
            this.label_Offer_Adress.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Offer_Adress.Location = new System.Drawing.Point(906, 6);
            this.label_Offer_Adress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Offer_Adress.Name = "label_Offer_Adress";
            this.label_Offer_Adress.Size = new System.Drawing.Size(192, 29);
            this.label_Offer_Adress.TabIndex = 15;
            this.label_Offer_Adress.Text = "Adres zlecenia";
            // 
            // label_Offer_Client
            // 
            this.label_Offer_Client.AutoSize = true;
            this.label_Offer_Client.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Offer_Client.Location = new System.Drawing.Point(474, 6);
            this.label_Offer_Client.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Offer_Client.Name = "label_Offer_Client";
            this.label_Offer_Client.Size = new System.Drawing.Size(197, 29);
            this.label_Offer_Client.TabIndex = 16;
            this.label_Offer_Client.Text = "Zleceniodawca";
            // 
            // label_Offer_Date
            // 
            this.label_Offer_Date.AutoSize = true;
            this.label_Offer_Date.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Offer_Date.Location = new System.Drawing.Point(2108, 6);
            this.label_Offer_Date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Offer_Date.Name = "label_Offer_Date";
            this.label_Offer_Date.Size = new System.Drawing.Size(178, 29);
            this.label_Offer_Date.TabIndex = 17;
            this.label_Offer_Date.Text = "Data zlecenia";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(2114, 69);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 31);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1196, 92);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 31);
            this.textBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(906, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(906, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kod Pocztowy";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1196, 150);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 31);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1326, 150);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 31);
            this.textBox4.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(906, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ulica";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1172, 185);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(312, 31);
            this.textBox5.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1564, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numer Budynku";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1864, 69);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 31);
            this.textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1864, 127);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 31);
            this.textBox7.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1564, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "Numer Mieszkania";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1268, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "-";
            // 
            // textBox_Offer_Name
            // 
            this.textBox_Offer_Name.Location = new System.Drawing.Point(504, 85);
            this.textBox_Offer_Name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Offer_Name.Name = "textBox_Offer_Name";
            this.textBox_Offer_Name.Size = new System.Drawing.Size(294, 31);
            this.textBox_Offer_Name.TabIndex = 33;
            // 
            // textBox_Offer_Adress
            // 
            this.textBox_Offer_Adress.Location = new System.Drawing.Point(504, 135);
            this.textBox_Offer_Adress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Offer_Adress.Name = "textBox_Offer_Adress";
            this.textBox_Offer_Adress.Size = new System.Drawing.Size(294, 31);
            this.textBox_Offer_Adress.TabIndex = 34;
            // 
            // Button_chose_Client
            // 
            this.Button_chose_Client.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Button_chose_Client.Location = new System.Drawing.Point(480, 206);
            this.Button_chose_Client.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button_chose_Client.Name = "Button_chose_Client";
            this.Button_chose_Client.Size = new System.Drawing.Size(208, 65);
            this.Button_chose_Client.TabIndex = 35;
            this.Button_chose_Client.Text = "Wybierz z listy";
            this.Button_chose_Client.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(504, 185);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(294, 31);
            this.textBox8.TabIndex = 36;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listView1.LabelEdit = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(24, 483);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1572, 621);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.Add_to_offer);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Nazwa";
            this.columnHeader11.Width = 250;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Producent";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Jm";
            this.columnHeader14.Width = 35;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ilość";
            this.columnHeader15.Width = 50;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Cena netto";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader16.Width = 90;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "VAT";
            this.columnHeader17.Width = 45;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Cena Brutto";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "kategoria";
            this.columnHeader19.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label_Offer_Name);
            this.panel1.Controls.Add(this.label_Offer_Client);
            this.panel1.Controls.Add(this.Button_chose_Client);
            this.panel1.Controls.Add(this.label_Offer_Adress);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Offer_Date);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3160, 277);
            this.panel1.TabIndex = 41;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "produkt";
            this.produktBindingSource.DataSource = this.zlecenieDataSet;
            // 
            // zlecenieDataSet
            // 
            this.zlecenieDataSet.DataSetName = "zlecenieDataSet";
            this.zlecenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // sum_e_taxes_label
            // 
            this.sum_e_taxes_label.AutoSize = true;
            this.sum_e_taxes_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sum_e_taxes_label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum_e_taxes_label.Location = new System.Drawing.Point(2538, 1150);
            this.sum_e_taxes_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sum_e_taxes_label.Name = "sum_e_taxes_label";
            this.sum_e_taxes_label.Size = new System.Drawing.Size(0, 30);
            this.sum_e_taxes_label.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(1608, 483);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1576, 625);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 250F;
            this.Column1.HeaderText = "Nazwa";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "Producent";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "Jm";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 35;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Ilość";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cena netto";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vat";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cena Brutto";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "kategoria";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // sum_w_taxes_label
            // 
            this.sum_w_taxes_label.AutoSize = true;
            this.sum_w_taxes_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sum_w_taxes_label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum_w_taxes_label.Location = new System.Drawing.Point(2822, 1150);
            this.sum_w_taxes_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sum_w_taxes_label.Name = "sum_w_taxes_label";
            this.sum_w_taxes_label.Size = new System.Drawing.Size(0, 30);
            this.sum_w_taxes_label.TabIndex = 45;
            // 
            // Window_Add_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.Button_Cancel_Offer;
            this.ClientSize = new System.Drawing.Size(3208, 1410);
            this.Controls.Add(this.sum_w_taxes_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sum_e_taxes_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox_Offer_Adress);
            this.Controls.Add(this.textBox_Offer_Name);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_Save_Offer);
            this.Controls.Add(this.Button_Cancel_Offer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Window_Add_Offer";
            this.Text = "Widnow_Add_Offer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window_Add_Offer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel_Offer;
        private System.Windows.Forms.Button Button_Save_Offer;
        private System.Windows.Forms.Label label_Offer_Name;
        private System.Windows.Forms.Label label_Offer_Adress;
        private System.Windows.Forms.Label label_Offer_Client;
        private System.Windows.Forms.Label label_Offer_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Offer_Name;
        private System.Windows.Forms.TextBox textBox_Offer_Adress;
        private System.Windows.Forms.Button Button_chose_Client;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private zlecenieDataSet zlecenieDataSet;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private zlecenieDataSetTableAdapters.produktTableAdapter produktTableAdapter;
        private System.Windows.Forms.Label sum_e_taxes_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label sum_w_taxes_label;
    }
}