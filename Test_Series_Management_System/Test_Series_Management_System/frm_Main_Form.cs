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
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
            if (Global_Vars.User_Role == 0)
            {
                pb_Exam.Visible = true;
                btn_Exam.Visible = true;
            }
            else if (Global_Vars.User_Role == 1)
            {
                pb_Exam.Visible = true;
                btn_Exam.Visible = true;
                pb_Teacher.Visible = true;
                btn_Teacher.Visible = true;
                pb_Report.Visible = true;
                btn_Report.Visible = true;
            }
            else if (Global_Vars.User_Role == 2)
            {
                pb_Teacher.Visible = true;
                btn_Teacher.Visible = true;
                pb_Report.Visible = true;
                btn_Report.Visible = true;
            }

        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            frm_Course fc = new frm_Course();
            fc.Show();
            this.Hide();
        }

        private void btn_Exam_Click(object sender, EventArgs e)
        {
            Frm_Instructions fi = new Frm_Instructions();
            fi.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                pb_Exam.Visible = false;
                btn_Exam.Visible = false;
                pb_Teacher.Visible = false;
                btn_Teacher.Visible = false;
                pb_Report.Visible = false;
                btn_Report.Visible = false;

                Global_Vars.User_Role = 0;

                frm_Login log = new frm_Login();
                log.Show();
                this.Hide();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Result_Report rr = new Result_Report();
            rr.Show();
            this.Hide();
        }
    }
}
