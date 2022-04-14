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
    public partial class frm_Product_Menu : Form
    {
        public frm_Product_Menu()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product Obj = new frm_Add_New_Product();

            Obj.Show();

            this.Hide();
        }

        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            frm_Update_Product Obj = new frm_Update_Product();

            Obj.Show();

            this.Hide();
        }

        private void btn_View_Product_List_Click(object sender, EventArgs e)
        {
            frm_View_Product_List Obj = new frm_View_Product_List();

            Obj.Show();

            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();

            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Form Obj = new frm_Main_Form();

            Obj.Show();

            this.Hide();
        }

    }
}
