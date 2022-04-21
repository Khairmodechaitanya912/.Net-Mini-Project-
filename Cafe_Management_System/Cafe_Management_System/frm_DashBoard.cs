using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frm_DashBoard : Form
    {
        public frm_DashBoard()
        {
            InitializeComponent();
        }
        public frm_DashBoard(String User)
        {
            InitializeComponent();

            if(User == "Guest")
            {
                btn_Add_Item.Hide();
                btn_Remove_Item.Hide();
                btn_Update_Item.Hide();
            }
        }

        private void btn_Place_Order_Click(object sender, EventArgs e)
        {
            uC_Place_Order1.Visible = true;
            uC_Place_Order1.BringToFront();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llbl_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form LF = new Login_Form();
            LF.Show();
            this.Hide();
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            uC_Add_Item1.Visible = true;
            uC_Add_Item1.BringToFront();
        }

        private void frm_DashBoard_Load(object sender, EventArgs e)
        {
            uC_Add_Item1.Visible = false;
            uC_Place_Order1.Visible = false;
            uC_Update_Item1.Visible = false;
            remove_Item1.Visible = false;
        }

        private void btn_Update_Item_Click(object sender, EventArgs e)
        {
            uC_Update_Item1.Visible = true;
            uC_Update_Item1.BringToFront();
        }

        private void btn_Remove_Item_Click(object sender, EventArgs e)
        {
            remove_Item1.Visible = true;
            remove_Item1.BringToFront();
        }
    }
}
