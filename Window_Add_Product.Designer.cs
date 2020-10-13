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
            this.comboBox_Product_Category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox_Taxes = new System.Windows.Forms.ComboBox();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.textBox_Price_Gross = new System.Windows.Forms.TextBox();
            this.textBox_Price_Net = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.textBox_Manufacturer = new System.Windows.Forms.TextBox();
            this.Cancel_Add_Product_Form = new System.Windows.Forms.Button();
            this.Button_Add_Product = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Product_Category
            // 
            this.comboBox_Product_Category.DisplayMember = "Nazwa_kategorii";
            this.comboBox_Product_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Product_Category.FormattingEnabled = true;
            this.comboBox_Product_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Product_Category.Location = new System.Drawing.Point(572, 204);
            this.comboBox_Product_Category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Product_Category.Name = "comboBox_Product_Category";
            this.comboBox_Product_Category.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Product_Category.TabIndex = 37;
            this.comboBox_Product_Category.ValueMember = "Nazwa_kategorii";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(422, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kategoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(699, 96);
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
            this.ComboBox_Taxes.Location = new System.Drawing.Point(572, 93);
            this.ComboBox_Taxes.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Taxes.Name = "ComboBox_Taxes";
            this.ComboBox_Taxes.Size = new System.Drawing.Size(108, 21);
            this.ComboBox_Taxes.TabIndex = 33;
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
            this.comboBox_Unit.Location = new System.Drawing.Point(234, 202);
            this.comboBox_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Unit.TabIndex = 31;
            // 
            // textBox_Price_Gross
            // 
            this.textBox_Price_Gross.Enabled = false;
            this.textBox_Price_Gross.Location = new System.Drawing.Point(572, 148);
            this.textBox_Price_Gross.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price_Gross.Name = "textBox_Price_Gross";
            this.textBox_Price_Gross.Size = new System.Drawing.Size(148, 20);
            this.textBox_Price_Gross.TabIndex = 34;
            // 
            // textBox_Price_Net
            // 
            this.textBox_Price_Net.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Price_Net.Location = new System.Drawing.Point(572, 37);
            this.textBox_Price_Net.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price_Net.Name = "textBox_Price_Net";
            this.textBox_Price_Net.Size = new System.Drawing.Size(148, 20);
            this.textBox_Price_Net.TabIndex = 32;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(234, 148);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(148, 20);
            this.textBox_Quantity.TabIndex = 30;
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Location = new System.Drawing.Point(234, 37);
            this.textBox_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(148, 20);
            this.textBox_Product_Name.TabIndex = 28;
            // 
            // textBox_Manufacturer
            // 
            this.textBox_Manufacturer.Location = new System.Drawing.Point(234, 93);
            this.textBox_Manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Manufacturer.Name = "textBox_Manufacturer";
            this.textBox_Manufacturer.Size = new System.Drawing.Size(148, 20);
            this.textBox_Manufacturer.TabIndex = 29;
            // 
            // Cancel_Add_Product_Form
            // 
            this.Cancel_Add_Product_Form.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Add_Product_Form.Location = new System.Drawing.Point(401, 350);
            this.Cancel_Add_Product_Form.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Add_Product_Form.Name = "Cancel_Add_Product_Form";
            this.Cancel_Add_Product_Form.Size = new System.Drawing.Size(202, 64);
            this.Cancel_Add_Product_Form.TabIndex = 27;
            this.Cancel_Add_Product_Form.Text = "Anuluj";
            this.Cancel_Add_Product_Form.UseVisualStyleBackColor = true;
            // 
            // Button_Add_Product
            // 
            this.Button_Add_Product.Location = new System.Drawing.Point(121, 350);
            this.Button_Add_Product.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Add_Product.Name = "Button_Add_Product";
            this.Button_Add_Product.Size = new System.Drawing.Size(202, 64);
            this.Button_Add_Product.TabIndex = 26;
            this.Button_Add_Product.Text = "Dodaj";
            this.Button_Add_Product.UseVisualStyleBackColor = true;
            this.Button_Add_Product.Click += new System.EventHandler(this.Button_Add_Product_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(422, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cena Brutto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(422, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(422, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cena Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(81, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "JM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(81, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Producent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwa";
            // 
            // Window_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Product_Category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBox_Taxes);
            this.Controls.Add(this.comboBox_Unit);
            this.Controls.Add(this.textBox_Price_Gross);
            this.Controls.Add(this.textBox_Price_Net);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.textBox_Manufacturer);
            this.Controls.Add(this.Cancel_Add_Product_Form);
            this.Controls.Add(this.Button_Add_Product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Window_Add_Product";
            this.Text = "Window_Add_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Cancel_Add_Product_Form;
        private System.Windows.Forms.Button Button_Add_Product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}