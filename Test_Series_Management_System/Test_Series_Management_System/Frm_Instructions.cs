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
    public partial class Frm_Instructions : Form
    {
        public Frm_Instructions()
        {
            InitializeComponent();
        }

        private void btn_Go_To_Exam_Click(object sender, EventArgs e)
        {
            frm_Exam_Form ef = new frm_Exam_Form();
            ef.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Yes.Checked == true)
            {
                btn_Go_To_Exam.Enabled = true;
            }
            else
            {
                btn_Go_To_Exam.Enabled = false;
            }
        }
    }
}
