using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_elektryk
{
    public partial class main_Window : Form
    {
        Product_Window pW;
        Offer_Window ofW;
        Client_Window cW;
        Invoice_Window iW;
        Order_window oW;

        public main_Window()
        {
            login();
            InitializeComponent();
        }

        void login()
        {
            Login login_window = new Login();
            login_window.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu_Design();
        }

        #region form_moving

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region menu_window_method

        private void button_Exit_Window_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        } // Exit Program

        private void button_minimalize_Window_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button_hide_window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Design()
        {
            panel_Order.Visible = false;
            panel_Offer.Visible = false;
            panel_Client.Visible = false;
            panel_Product.Visible = false;
            panel_Invoice.Visible = false;
        }

        private void Hide_Sub_Menu()
        {
            if (panel_Order.Visible == true)
                panel_Order.Visible = false;
            if (panel_Offer.Visible == true)
                panel_Offer.Visible = false;
            if (panel_Client.Visible == true)
                panel_Client.Visible = false;
            if (panel_Product.Visible == true)
                panel_Product.Visible = false;
            if (panel_Invoice.Visible == true)
                panel_Invoice.Visible = false;
        }

        private void Show_Sub_Menu(Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main_Window.Controls.Add(childForm);
            panel_Main_Window.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } // Open new window in main window panel

        private void button_main_menu_Click(object sender, EventArgs e)
        {
            try
            {
                this.activeForm.Close();
                Hide_Sub_Menu();
            }
            catch
            {

            }
        }

        #endregion

        #region menu_main_buttons

        private void button_Order_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Order);
        } // Open Order Window

        private void button_Offer_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Offer);
        } // Open Offer Window

        private void button_Client_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Client);
        } // Open Client Window

        private void button_Product_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Product);
        } // Open Product Window

        private void button_Invoice_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Invoice);
        } // Open Invoice Widnow

        #endregion

        #region buttons_new

        private void button_New_Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Window_Add_Order());
        }

        private void button_New_Offer_Click(object sender, EventArgs e) // Open New Offer Window
        {
            OpenChildForm(new Window_Add_Offer());
        }

        private void Button_New_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Window_Add_Product());

        } // Open New Product Window

        private void Buton_New_client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Window_Add_Client());
        } // Open New Client Window

        #endregion

        #region buttons_modify

        private void button_Modify_Product_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = pW.getSelectedProduct();
                    if (ID != 0)
                    {
                        produkt pm = db.produkt.Find(ID);
                        OpenChildForm(new Window_Add_Product(pm));
                    }
                }
                catch
                {

                }
            }
        } // Modify Product information

        private void button_Modify_Offer_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = ofW.getSelectedOffer();
                    if (ID != 0)
                    {
                        oferta mof = db.oferta.Find(ID);
                        OpenChildForm(new Window_Add_Offer(mof));
                    }
                }
                catch
                {

                }
            }
        } // Modify Offer information

        private void Button_Modify_Client_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = cW.getSelectedClient();
                    if (ID != 0)
                    {
                        kontrahent mc = db.kontrahent.Find(ID);
                        OpenChildForm(new Window_Add_Client(mc));
                    }
                }
                catch
                {

                }

            }
        } // Modify Client information

        private void button_Modify_Order_Info_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = oW.getSelectedProduct();
                    if (ID != 0)
                    {
                        zlecenie mo = db.zlecenie.Find(ID);
                        OpenChildForm(new Window_Add_Order(mo));
                    }
                }
                catch (Exception f)
                {

                }
            }
        } // Modify Order information

        #endregion

        #region lists_buttons

        private void button_order_list_Click(object sender, EventArgs e)
        {
            oW = new Order_window();
            OpenChildForm(oW);
        } // Show order list

        private void button_Offer_list_Click(object sender, EventArgs e)
        {
            ofW = new Offer_Window();
            OpenChildForm(ofW);
        } // Show offer list

        private void button_Clients_list_Click(object sender, EventArgs e)
        {
            cW = new Client_Window();
            OpenChildForm(cW);
        } // Show clients list

        private void button_Products_list_Click(object sender, EventArgs e)
        {
            pW = new Product_Window();
            OpenChildForm(pW);
        } // Show products list

        private void button_Invoice_list_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice_Window());
        } // Show invoice list

        #endregion

        #region menu_status_buttons

        private void button_Change_Offer_Status_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Offer_status);
        }

        private void button_Change_Order_Status_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Order_status);
        }

        private void button_Client_Status_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Client_status);
        }

        private void button_Product_status_Click(object sender, EventArgs e)
        {
            Show_Sub_Menu(panel_Product_status);
        }

        #endregion

        #region client_status_panel

        private void button_CStatus_active_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region product_status_panel

        private void button_PStatus_Active_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = pW.getSelectedProduct();
                    if (ID != 0)
                    {
                        produkt pm = db.produkt.Find(ID);
                        pm.Status = 1;
                        db.SaveChanges();
                        pW = new Product_Window();
                        OpenChildForm(pW);
                    }
                }
                catch
                {

                }
            }
        }
        private void button_PStatus_withdrawn_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = pW.getSelectedProduct();
                    if (ID != 0)
                    {
                        produkt pm = db.produkt.Find(ID);
                        pm.Status = 2;
                        db.SaveChanges();
                        pW = new Product_Window();
                        OpenChildForm(pW);
                    }
                }
                catch
                {

                }
            }
        }

        #endregion

        #region offer_status_panel

        private void button_Ostatus_new_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = ofW.getSelectedOffer();
                    if (ID != 0)
                    {
                        oferta of = db.oferta.Find(ID);
                        of.Status = 1;
                        db.SaveChanges();
                        ofW = new Offer_Window();
                        OpenChildForm(ofW);
                    }
                }
                catch
                {

                }
            }
        }
        private void button_OStatus_send_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = ofW.getSelectedOffer();
                    if (ID != 0)
                    {
                        oferta of = db.oferta.Find(ID);
                        of.Status = 2;
                        db.SaveChanges();
                        ofW = new Offer_Window();
                        OpenChildForm(ofW);
                    }
                }
                catch
                {

                }
            }
        }
        private void button_OStatus_Accept_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = ofW.getSelectedOffer();
                    if (ID != 0)
                    {
                        oferta of = db.oferta.Find(ID);
                        of.Status = 3;
                        db.SaveChanges();
                        ofW = new Offer_Window();
                        OpenChildForm(ofW);
                    }
                }
                catch
                {

                }
            }
        }
        private void button_Ostatus_Refused_Click(object sender, EventArgs e)
        {
            using (zlecenieEntities db = new zlecenieEntities())
            {
                try
                {
                    int ID = ofW.getSelectedOffer();
                    if (ID != 0)
                    {
                        oferta of = db.oferta.Find(ID);
                        of.Status = 4;
                        db.SaveChanges();
                        ofW = new Offer_Window();
                        OpenChildForm(ofW);
                    }
                }
                catch
                {

                }
            }
        }

        #endregion

        
    }
}
