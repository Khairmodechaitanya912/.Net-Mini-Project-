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
    public partial class frm_Customer_Menu : Form
    {
        public frm_Customer_Menu()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer Obj = new frm_Add_New_Customer();

            Obj.Show();

            this.Hide();
        }

        private void btn_Search_Single_Customer_Click(object sender, EventArgs e)
        {
            frm_View_Single_Customer_Details Obj = new frm_View_Single_Customer_Details();

            Obj.Show();

            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Form Obj = new frm_Main_Form();

            Obj.Show();

            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();

            this.Hide();
        }
    }
}
