using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Series_Management_System
{
    public partial class frm_User_Management : Form
    {
        public frm_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student fas = new frm_Add_Student();
            fas.Show();
            this.Hide();
        }

        private void btn_Change_Password_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Password usp = new frm_Update_Student_Password();
            usp.Show();
            this.Hide();
        }

        private void btn_Delete_Student_Click(object sender, EventArgs e)
        {
            frm_Delete_Student ds = new frm_Delete_Student();
            ds.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Form mf = new frm_Main_Form();
            mf.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login log = new frm_Login();
                log.Show();
                this.Hide();
            }
        }

    }
}
