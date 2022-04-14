using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppee_Mini_Project
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "a123") || (tb_Username.Text == "Shree" && tb_Password.Text == "S") || (tb_Username.Text == "a" && tb_Password.Text == "a"))
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Main_Form Obj = new frm_Main_Form();
                Obj.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }
    }
}
