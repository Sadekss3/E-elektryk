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
            this.panel3.SuspendLayout();
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
            // 
            // textBox_Town_Name
            // 
            this.textBox_Town_Name.Location = new System.Drawing.Point(233, 7);
            this.textBox_Town_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Town_Name.Name = "textBox_Town_Name";
            this.textBox_Town_Name.Size = new System.Drawing.Size(133, 20);
            this.textBox_Town_Name.TabIndex = 19;
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
            // Window_Choice_Adres_For_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 711);
            this.Controls.Add(this.Adres_list);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Choice_Adres_For_Order";
            this.ShowInTaskbar = false;
            this.Text = "Window_Choice_Adres_For_Order";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}