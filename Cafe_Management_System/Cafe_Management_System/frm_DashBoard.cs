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
    }
}
