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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void tb_Username_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_Password_Click(object sender, EventArgs e)
        {
            tb_Password.Text = "";
        }

        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            frm_DashBoard FDB = new frm_DashBoard();
            FDB.Show();
            this.Hide();
        }

        private void llbl_Continue_As_Guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DashBoard FDB = new frm_DashBoard("Guest");
            FDB.Show();
            this.Hide();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
