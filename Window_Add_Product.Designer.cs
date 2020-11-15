namespace E_elektryk
{
    partial class Window_Add_Product
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
            this.comboBox_Product_Category = new System.Windows.Forms.ComboBox();
            this.kategoriaproduktuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zlecenieDataSet = new E_elektryk.zlecenieDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox_Taxes = new System.Windows.Forms.ComboBox();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.textBox_Price_Gross = new System.Windows.Forms.TextBox();
            this.textBox_Price_Net = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.textBox_Manufacturer = new System.Windows.Forms.TextBox();
            this.Button_Add_Product = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Catalog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kategoria_produktuTableAdapter = new E_elektryk.zlecenieDataSetTableAdapters.kategoria_produktuTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.comboBox_Product_Status = new System.Windows.Forms.ComboBox();
            this.statusyzleceniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zlecenieDataSet1 = new E_elektryk.zlecenieDataSet();
            this.statusy_zleceniaTableAdapter = new E_elektryk.zlecenieDataSetTableAdapters.statusy_zleceniaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaproduktuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusyzleceniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Product_Category
            // 
            this.comboBox_Product_Category.DataSource = this.kategoriaproduktuBindingSource;
            this.comboBox_Product_Category.DisplayMember = "Nazwa_kategorii";
            this.comboBox_Product_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Product_Category.FormattingEnabled = true;
            this.comboBox_Product_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Product_Category.Location = new System.Drawing.Point(540, 201);
            this.comboBox_Product_Category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Product_Category.Name = "comboBox_Product_Category";
            this.comboBox_Product_Category.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Product_Category.TabIndex = 36;
            this.comboBox_Product_Category.ValueMember = "ID";
            // 
            // kategoriaproduktuBindingSource
            // 
            this.kategoriaproduktuBindingSource.DataMember = "kategoria_produktu";
            this.kategoriaproduktuBindingSource.DataSource = this.zlecenieDataSet;
            // 
            // zlecenieDataSet
            // 
            this.zlecenieDataSet.DataSetName = "zlecenieDataSet";
            this.zlecenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(398, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kategoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(667, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "%";
            // 
            // ComboBox_Taxes
            // 
            this.ComboBox_Taxes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Taxes.FormattingEnabled = true;
            this.ComboBox_Taxes.Items.AddRange(new object[] {
            "23"});
            this.ComboBox_Taxes.Location = new System.Drawing.Point(540, 90);
            this.ComboBox_Taxes.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Taxes.Name = "ComboBox_Taxes";
            this.ComboBox_Taxes.Size = new System.Drawing.Size(108, 21);
            this.ComboBox_Taxes.TabIndex = 34;
            this.ComboBox_Taxes.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Taxes_SelectedIndexChanged);
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Unit.Items.AddRange(new object[] {
            "szt",
            "opk",
            "kg",
            "m",
            "km"});
            this.comboBox_Unit.Location = new System.Drawing.Point(202, 254);
            this.comboBox_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Unit.TabIndex = 32;
            // 
            // textBox_Price_Gross
            // 
            this.textBox_Price_Gross.Enabled = false;
            this.textBox_Price_Gross.Location = new System.Drawing.Point(540, 145);
            this.textBox_Price_Gross.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price_Gross.Name = "textBox_Price_Gross";
            this.textBox_Price_Gross.Size = new System.Drawing.Size(148, 20);
            this.textBox_Price_Gross.TabIndex = 35;
            // 
            // textBox_Price_Net
            // 
            this.textBox_Price_Net.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Price_Net.Location = new System.Drawing.Point(540, 34);
            this.textBox_Price_Net.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price_Net.Name = "textBox_Price_Net";
            this.textBox_Price_Net.Size = new System.Drawing.Size(148, 20);
            this.textBox_Price_Net.TabIndex = 33;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(202, 200);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(148, 20);
            this.textBox_Quantity.TabIndex = 31;
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Location = new System.Drawing.Point(202, 34);
            this.textBox_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(148, 20);
            this.textBox_Product_Name.TabIndex = 28;
            // 
            // textBox_Manufacturer
            // 
            this.textBox_Manufacturer.Location = new System.Drawing.Point(202, 90);
            this.textBox_Manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Manufacturer.Name = "textBox_Manufacturer";
            this.textBox_Manufacturer.Size = new System.Drawing.Size(148, 20);
            this.textBox_Manufacturer.TabIndex = 29;
            // 
            // Button_Add_Product
            // 
            this.Button_Add_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.Button_Add_Product.FlatAppearance.BorderSize = 0;
            this.Button_Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Add_Product.ForeColor = System.Drawing.Color.White;
            this.Button_Add_Product.Location = new System.Drawing.Point(31, 371);
            this.Button_Add_Product.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Add_Product.Name = "Button_Add_Product";
            this.Button_Add_Product.Size = new System.Drawing.Size(202, 64);
            this.Button_Add_Product.TabIndex = 37;
            this.Button_Add_Product.Text = "Dodaj";
            this.Button_Add_Product.UseVisualStyleBackColor = false;
            this.Button_Add_Product.Click += new System.EventHandler(this.Button_Add_Product_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(398, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cena Brutto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(398, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(398, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cena Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "JM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Producent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwa";
            // 
            // textBox_Catalog
            // 
            this.textBox_Catalog.Location = new System.Drawing.Point(202, 146);
            this.textBox_Catalog.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Catalog.Name = "textBox_Catalog";
            this.textBox_Catalog.Size = new System.Drawing.Size(148, 20);
            this.textBox_Catalog.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(27, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Symbol katalogowy";
            // 
            // kategoria_produktuTableAdapter
            // 
            this.kategoria_produktuTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.comboBox_Product_Status);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Catalog);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_Product_Category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComboBox_Taxes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_Unit);
            this.panel1.Controls.Add(this.Button_Add_Product);
            this.panel1.Controls.Add(this.textBox_Price_Gross);
            this.panel1.Controls.Add(this.textBox_Manufacturer);
            this.panel1.Controls.Add(this.textBox_Price_Net);
            this.panel1.Controls.Add(this.textBox_Product_Name);
            this.panel1.Controls.Add(this.textBox_Quantity);
            this.panel1.Location = new System.Drawing.Point(86, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 458);
            this.panel1.TabIndex = 39;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(398, 252);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(62, 20);
            this.Status.TabIndex = 40;
            this.Status.Text = "Status";
            // 
            // comboBox_Product_Status
            // 
            this.comboBox_Product_Status.DataSource = this.statusyzleceniaBindingSource;
            this.comboBox_Product_Status.DisplayMember = "Status";
            this.comboBox_Product_Status.FormattingEnabled = true;
            this.comboBox_Product_Status.Location = new System.Drawing.Point(540, 254);
            this.comboBox_Product_Status.Name = "comboBox_Product_Status";
            this.comboBox_Product_Status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Product_Status.TabIndex = 39;
            this.comboBox_Product_Status.ValueMember = "ID_statusu";
            // 
            // statusyzleceniaBindingSource
            // 
            this.statusyzleceniaBindingSource.DataMember = "statusy_zlecenia";
            this.statusyzleceniaBindingSource.DataSource = this.zlecenieDataSet1;
            // 
            // zlecenieDataSet1
            // 
            this.zlecenieDataSet1.DataSetName = "zlecenieDataSet";
            this.zlecenieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusy_zleceniaTableAdapter
            // 
            this.statusy_zleceniaTableAdapter.ClearBeforeFill = true;
            // 
            // Window_Add_Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1747, 950);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Add_Product";
            this.Text = "Window_Add_Product";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaproduktuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusyzleceniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Product_Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBox_Taxes;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.TextBox textBox_Price_Gross;
        private System.Windows.Forms.TextBox textBox_Price_Net;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.TextBox textBox_Manufacturer;
        private System.Windows.Forms.Button Button_Add_Product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Catalog;
        private System.Windows.Forms.Label label10;
        private zlecenieDataSet zlecenieDataSet;
        private System.Windows.Forms.BindingSource kategoriaproduktuBindingSource;
        private zlecenieDataSetTableAdapters.kategoria_produktuTableAdapter kategoria_produktuTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox comboBox_Product_Status;
        private zlecenieDataSet zlecenieDataSet1;
        private System.Windows.Forms.BindingSource statusyzleceniaBindingSource;
        private zlecenieDataSetTableAdapters.statusy_zleceniaTableAdapter statusy_zleceniaTableAdapter;
    }
}