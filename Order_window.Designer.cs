namespace E_elektryk
{
    partial class Order_window
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
            this.Order_Search_Order_Name = new System.Windows.Forms.TextBox();
            this.Order_Search_Client_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_Search_Client_Name = new System.Windows.Forms.TextBox();
            this.panel_Offer = new System.Windows.Forms.Panel();
            this.Order_list = new System.Windows.Forms.ListView();
            this.ID_offer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Order_Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Date2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offer_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel_Offer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Order_Search_Order_Name);
            this.panel1.Controls.Add(this.Order_Search_Client_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Order_Search_Client_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1763, 52);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nazwa zlecenia:";
            // 
            // Order_Search_Order_Name
            // 
            this.Order_Search_Order_Name.Location = new System.Drawing.Point(176, 17);
            this.Order_Search_Order_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Order_Search_Order_Name.Name = "Order_Search_Order_Name";
            this.Order_Search_Order_Name.Size = new System.Drawing.Size(133, 20);
            this.Order_Search_Order_Name.TabIndex = 20;
            // 
            // Order_Search_Client_ID
            // 
            this.Order_Search_Client_ID.Location = new System.Drawing.Point(685, 17);
            this.Order_Search_Client_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Order_Search_Client_ID.Name = "Order_Search_Client_ID";
            this.Order_Search_Client_ID.Size = new System.Drawing.Size(133, 20);
            this.Order_Search_Client_ID.TabIndex = 22;
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(584, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID Kontrahenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(314, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nazwa Konbtrahenta:";
            // 
            // Order_Search_Client_Name
            // 
            this.Order_Search_Client_Name.Location = new System.Drawing.Point(447, 17);
            this.Order_Search_Client_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Order_Search_Client_Name.Name = "Order_Search_Client_Name";
            this.Order_Search_Client_Name.Size = new System.Drawing.Size(133, 20);
            this.Order_Search_Client_Name.TabIndex = 21;
            // 
            // panel_Offer
            // 
            this.panel_Offer.Controls.Add(this.Order_list);
            this.panel_Offer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Offer.Location = new System.Drawing.Point(0, 52);
            this.panel_Offer.Name = "panel_Offer";
            this.panel_Offer.Size = new System.Drawing.Size(1763, 937);
            this.panel_Offer.TabIndex = 2;
            // 
            // Order_list
            // 
            this.Order_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_offer,
            this.Offer_name,
            this.Offer_Client,
            this.Offer_Order_Adress,
            this.Offer_Date,
            this.Offer_Date2,
            this.Offer_Status,
            this.Opis});
            this.Order_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_list.FullRowSelect = true;
            this.Order_list.GridLines = true;
            this.Order_list.HideSelection = false;
            this.Order_list.Location = new System.Drawing.Point(0, 0);
            this.Order_list.Name = "Order_list";
            this.Order_list.Size = new System.Drawing.Size(1763, 937);
            this.Order_list.TabIndex = 2;
            this.Order_list.UseCompatibleStateImageBehavior = false;
            this.Order_list.View = System.Windows.Forms.View.Details;
            // 
            // ID_offer
            // 
            this.ID_offer.Text = "ID";
            this.ID_offer.Width = 45;
            // 
            // Offer_name
            // 
            this.Offer_name.Text = "Nazwa";
            this.Offer_name.Width = 250;
            // 
            // Offer_Client
            // 
            this.Offer_Client.Text = "Zleceniodawca";
            this.Offer_Client.Width = 160;
            // 
            // Offer_Order_Adress
            // 
            this.Offer_Order_Adress.Text = "Adres zlecenia";
            this.Offer_Order_Adress.Width = 250;
            // 
            // Offer_Date
            // 
            this.Offer_Date.Text = "Data Zlecenia";
            this.Offer_Date.Width = 130;
            // 
            // Offer_Date2
            // 
            this.Offer_Date2.Text = "Data Zakończenia";
            this.Offer_Date2.Width = 130;
            // 
            // Offer_Status
            // 
            this.Offer_Status.Text = "Status  Zlecenia";
            this.Offer_Status.Width = 120;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 300;
            // 
            // Order_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 989);
            this.Controls.Add(this.panel_Offer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_window";
            this.Text = "Order_window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Offer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Order_Search_Order_Name;
        private System.Windows.Forms.TextBox Order_Search_Client_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Order_Search_Client_Name;
        private System.Windows.Forms.Panel panel_Offer;
        private System.Windows.Forms.ListView Order_list;
        private System.Windows.Forms.ColumnHeader ID_offer;
        private System.Windows.Forms.ColumnHeader Offer_name;
        private System.Windows.Forms.ColumnHeader Offer_Client;
        private System.Windows.Forms.ColumnHeader Offer_Order_Adress;
        private System.Windows.Forms.ColumnHeader Offer_Date;
        private System.Windows.Forms.ColumnHeader Offer_Date2;
        private System.Windows.Forms.ColumnHeader Offer_Status;
        private System.Windows.Forms.ColumnHeader Opis;
    }
}