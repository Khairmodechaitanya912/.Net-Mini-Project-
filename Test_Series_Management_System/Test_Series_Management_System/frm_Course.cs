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
    public partial class frm_Course : Form
    {
        public frm_Course()
        {
            InitializeComponent();
        }

        private void btn_Courses_Click(object sender, EventArgs e)
        {
            frm_Add_Courses ac = new frm_Add_Courses();
            ac.Show();
            this.Hide();

        }

        private void btn_Set_Exam_Click(object sender, EventArgs e)
        {
            frm_Set_Exam_Details sed = new frm_Set_Exam_Details();
            sed.Show();
            this.Hide();
        }

        private void btn_Add_Que_Click(object sender, EventArgs e)
        {
            Frm_Add_Que aq = new Frm_Add_Que();
            aq.Show();
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

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            frm_User_Management um = new frm_User_Management();
            um.Show();
            this.Hide();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            frm_Result_Form rf = new frm_Result_Form();
            rf.Show();
            this.Hide();
        }
    }
}
