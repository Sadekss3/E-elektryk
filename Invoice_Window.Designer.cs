namespace E_elektryk
{
    partial class Invoice_Window
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Offer_Search_Offer_Name = new System.Windows.Forms.TextBox();
            this.Offer_Search_Client_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Offer_Search_Client_Name = new System.Windows.Forms.TextBox();
            this.panel_Offer = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel_Offer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Offer_Search_Offer_Name);
            this.panel1.Controls.Add(this.Offer_Search_Client_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Offer_Search_Client_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 52);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nazwa faktury:";
            // 
            // Offer_Search_Offer_Name
            // 
            this.Offer_Search_Offer_Name.Location = new System.Drawing.Point(168, 16);
            this.Offer_Search_Offer_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Offer_Search_Offer_Name.Name = "Offer_Search_Offer_Name";
            this.Offer_Search_Offer_Name.Size = new System.Drawing.Size(133, 20);
            this.Offer_Search_Offer_Name.TabIndex = 20;
            // 
            // Offer_Search_Client_ID
            // 
            this.Offer_Search_Client_ID.Location = new System.Drawing.Point(676, 15);
            this.Offer_Search_Client_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Offer_Search_Client_ID.Name = "Offer_Search_Client_ID";
            this.Offer_Search_Client_ID.Size = new System.Drawing.Size(133, 20);
            this.Offer_Search_Client_ID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-153, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Szukaj po:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(575, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID Kontrahenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nazwa Konbtrahenta:";
            // 
            // Offer_Search_Client_Name
            // 
            this.Offer_Search_Client_Name.Location = new System.Drawing.Point(438, 15);
            this.Offer_Search_Client_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Offer_Search_Client_Name.Name = "Offer_Search_Client_Name";
            this.Offer_Search_Client_Name.Size = new System.Drawing.Size(133, 20);
            this.Offer_Search_Client_Name.TabIndex = 21;
            // 
            // panel_Offer
            // 
            this.panel_Offer.Controls.Add(this.listView2);
            this.panel_Offer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Offer.Location = new System.Drawing.Point(0, 52);
            this.panel_Offer.Name = "panel_Offer";
            this.panel_Offer.Size = new System.Drawing.Size(1779, 898);
            this.panel_Offer.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.AllowColumnReorder = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1779, 898);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Imie";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Nazwisko";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Pesel";
            this.columnHeader13.Width = 130;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "NIP";
            this.columnHeader14.Width = 130;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Nazwa Firmy";
            this.columnHeader15.Width = 250;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Adres";
            this.columnHeader16.Width = 400;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Adres E-mail";
            this.columnHeader17.Width = 160;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Telefon 1";
            this.columnHeader18.Width = 120;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Telefon 2";
            this.columnHeader19.Width = 120;
            // 
            // Invoice_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 950);
            this.Controls.Add(this.panel_Offer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice_Window";
            this.Text = "Invoice_Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Offer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Offer_Search_Offer_Name;
        private System.Windows.Forms.TextBox Offer_Search_Client_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Offer_Search_Client_Name;
        private System.Windows.Forms.Panel panel_Offer;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}