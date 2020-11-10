namespace E_elektryk
{
    partial class Client_Window
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
            this.textBox_client_id_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_client_name_search = new System.Windows.Forms.TextBox();
            this.textBox_client_company_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Client = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.textBox_client_id_search);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_client_name_search);
            this.panel1.Controls.Add(this.textBox_client_company_search);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1763, 52);
            this.panel1.TabIndex = 26;
            // 
            // textBox_client_id_search
            // 
            this.textBox_client_id_search.Location = new System.Drawing.Point(679, 16);
            this.textBox_client_id_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_client_id_search.Name = "textBox_client_id_search";
            this.textBox_client_id_search.Size = new System.Drawing.Size(133, 20);
            this.textBox_client_id_search.TabIndex = 29;
            this.textBox_client_id_search.TextChanged += new System.EventHandler(this.textBox_client_company_search_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(578, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ID Kontrahenta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(292, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nazwisko Konbtrahenta:";
            // 
            // textBox_client_name_search
            // 
            this.textBox_client_name_search.Location = new System.Drawing.Point(441, 16);
            this.textBox_client_name_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_client_name_search.Name = "textBox_client_name_search";
            this.textBox_client_name_search.Size = new System.Drawing.Size(133, 20);
            this.textBox_client_name_search.TabIndex = 26;
            this.textBox_client_name_search.TextChanged += new System.EventHandler(this.textBox_client_company_search_TextChanged);
            // 
            // textBox_client_company_search
            // 
            this.textBox_client_company_search.Location = new System.Drawing.Point(155, 16);
            this.textBox_client_company_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_client_company_search.Name = "textBox_client_company_search";
            this.textBox_client_company_search.Size = new System.Drawing.Size(133, 20);
            this.textBox_client_company_search.TabIndex = 25;
            this.textBox_client_company_search.TextChanged += new System.EventHandler(this.textBox_client_company_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nazwa firmy:";
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
            // panel_Client
            // 
            this.panel_Client.Controls.Add(this.Client_list);
            this.panel_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Client.Location = new System.Drawing.Point(0, 52);
            this.panel_Client.Name = "panel_Client";
            this.panel_Client.Size = new System.Drawing.Size(1763, 937);
            this.panel_Client.TabIndex = 27;
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
            this.Client_list.Location = new System.Drawing.Point(0, 0);
            this.Client_list.MultiSelect = false;
            this.Client_list.Name = "Client_list";
            this.Client_list.Size = new System.Drawing.Size(1763, 937);
            this.Client_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Client_list.TabIndex = 1;
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
            // Client_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 989);
            this.Controls.Add(this.panel_Client);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client_Window";
            this.Text = "Client_Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Client.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_client_id_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_client_name_search;
        private System.Windows.Forms.TextBox textBox_client_company_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Client;
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
    }
}