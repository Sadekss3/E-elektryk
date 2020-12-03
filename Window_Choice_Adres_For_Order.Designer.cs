namespace E_elektryk
{
    partial class Window_Choice_Adres_For_Order
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Street_Name = new System.Windows.Forms.TextBox();
            this.textBox_Town_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Adres_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kod_Pocztowy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Budynek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mieszkanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Państwo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_home = new System.Windows.Forms.TextBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kod_2 = new System.Windows.Forms.TextBox();
            this.textBox_kod_1 = new System.Windows.Forms.TextBox();
            this.textBox_town = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add_New_Address = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.zlecenieDataSet = new E_elektryk.zlecenieDataSet();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresTableAdapter = new E_elektryk.zlecenieDataSetTableAdapters.adresTableAdapter();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(384, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nazwa ulicy:";
            // 
            // textBox_Street_Name
            // 
            this.textBox_Street_Name.Location = new System.Drawing.Point(467, 7);
            this.textBox_Street_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Street_Name.Name = "textBox_Street_Name";
            this.textBox_Street_Name.Size = new System.Drawing.Size(133, 20);
            this.textBox_Street_Name.TabIndex = 20;
            this.textBox_Street_Name.TextChanged += new System.EventHandler(this.textBox_Town_Name_TextChanged);
            // 
            // textBox_Town_Name
            // 
            this.textBox_Town_Name.Location = new System.Drawing.Point(233, 7);
            this.textBox_Town_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Town_Name.Name = "textBox_Town_Name";
            this.textBox_Town_Name.Size = new System.Drawing.Size(133, 20);
            this.textBox_Town_Name.TabIndex = 19;
            this.textBox_Town_Name.TextChanged += new System.EventHandler(this.textBox_Town_Name_TextChanged);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox_Street_Name);
            this.panel3.Controls.Add(this.textBox_Town_Name);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1518, 46);
            this.panel3.TabIndex = 28;
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
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nazwa miasta:";
            // 
            // Adres_list
            // 
            this.Adres_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Adres_list.AllowColumnReorder = true;
            this.Adres_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Miasto,
            this.Kod_Pocztowy,
            this.Ulica,
            this.Budynek,
            this.Mieszkanie,
            this.Państwo});
            this.Adres_list.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Adres_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adres_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adres_list.FullRowSelect = true;
            this.Adres_list.GridLines = true;
            this.Adres_list.HideSelection = false;
            this.Adres_list.Location = new System.Drawing.Point(0, 46);
            this.Adres_list.MultiSelect = false;
            this.Adres_list.Name = "Adres_list";
            this.Adres_list.Size = new System.Drawing.Size(1518, 665);
            this.Adres_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Adres_list.TabIndex = 23;
            this.Adres_list.UseCompatibleStateImageBehavior = false;
            this.Adres_list.View = System.Windows.Forms.View.Details;
            this.Adres_list.DoubleClick += new System.EventHandler(this.Adres_list_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Miasto
            // 
            this.Miasto.Text = "Miasto";
            this.Miasto.Width = 120;
            // 
            // Kod_Pocztowy
            // 
            this.Kod_Pocztowy.Text = "Kod Pocztowy";
            this.Kod_Pocztowy.Width = 120;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 130;
            // 
            // Budynek
            // 
            this.Budynek.Text = "Budynek";
            this.Budynek.Width = 130;
            // 
            // Mieszkanie
            // 
            this.Mieszkanie.Text = "Mieszkanie";
            this.Mieszkanie.Width = 250;
            // 
            // Państwo
            // 
            this.Państwo.Text = "Państwo";
            this.Państwo.Width = 330;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_Add_New_Address);
            this.panel1.Controls.Add(this.Button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1518, 104);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox_home);
            this.panel2.Controls.Add(this.textBox_building);
            this.panel2.Controls.Add(this.textBox_street);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_kod_2);
            this.panel2.Controls.Add(this.textBox_kod_1);
            this.panel2.Controls.Add(this.textBox_town);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 93);
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
            this.comboBox1.Location = new System.Drawing.Point(393, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox_home
            // 
            this.textBox_home.Location = new System.Drawing.Point(393, 26);
            this.textBox_home.Name = "textBox_home";
            this.textBox_home.Size = new System.Drawing.Size(58, 20);
            this.textBox_home.TabIndex = 13;
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(246, 57);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(58, 20);
            this.textBox_building.TabIndex = 12;
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(211, 26);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(93, 20);
            this.textBox_street.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Państwo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nr. Mieszkania";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nr. Budynku";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kod \r\nPocztowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miasto";
            // 
            // textBox_kod_2
            // 
            this.textBox_kod_2.Location = new System.Drawing.Point(113, 58);
            this.textBox_kod_2.Name = "textBox_kod_2";
            this.textBox_kod_2.Size = new System.Drawing.Size(55, 20);
            this.textBox_kod_2.TabIndex = 3;
            // 
            // textBox_kod_1
            // 
            this.textBox_kod_1.Location = new System.Drawing.Point(68, 57);
            this.textBox_kod_1.Name = "textBox_kod_1";
            this.textBox_kod_1.Size = new System.Drawing.Size(23, 20);
            this.textBox_kod_1.TabIndex = 2;
            // 
            // textBox_town
            // 
            this.textBox_town.Location = new System.Drawing.Point(68, 26);
            this.textBox_town.Name = "textBox_town";
            this.textBox_town.Size = new System.Drawing.Size(100, 20);
            this.textBox_town.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nowy Adres";
            // 
            // button_Add_New_Address
            // 
            this.button_Add_New_Address.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Add_New_Address.FlatAppearance.BorderSize = 0;
            this.button_Add_New_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_New_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Add_New_Address.ForeColor = System.Drawing.Color.Black;
            this.button_Add_New_Address.Location = new System.Drawing.Point(482, 58);
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
            // zlecenieDataSet
            // 
            this.zlecenieDataSet.DataSetName = "zlecenieDataSet";
            this.zlecenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "adres";
            this.adresBindingSource.DataSource = this.zlecenieDataSet;
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // Window_Choice_Adres_For_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Adres_list);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Choice_Adres_For_Order";
            this.ShowInTaskbar = false;
            this.Text = "Window_Choice_Adres_For_Order";
            this.Load += new System.EventHandler(this.Window_Choice_Adres_For_Order_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Street_Name;
        private System.Windows.Forms.TextBox textBox_Town_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView Adres_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Miasto;
        private System.Windows.Forms.ColumnHeader Kod_Pocztowy;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Budynek;
        private System.Windows.Forms.ColumnHeader Mieszkanie;
        private System.Windows.Forms.ColumnHeader Państwo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_home;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kod_2;
        private System.Windows.Forms.TextBox textBox_kod_1;
        private System.Windows.Forms.TextBox textBox_town;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add_New_Address;
        private System.Windows.Forms.ComboBox comboBox1;
        private zlecenieDataSet zlecenieDataSet;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private zlecenieDataSetTableAdapters.adresTableAdapter adresTableAdapter;
    }
}