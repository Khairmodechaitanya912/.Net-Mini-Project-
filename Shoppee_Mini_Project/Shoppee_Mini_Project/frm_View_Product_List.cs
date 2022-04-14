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
    public partial class frm_View_Product_List : Form
    {
        public frm_View_Product_List()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Menu Obj = new frm_Product_Menu();

            Obj.Show();

            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();

            this.Hide();
        }

        private void frm_View_Product_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mini_Shoppee_DBDataSet.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.mini_Shoppee_DBDataSet.Product_Details);

        }


    }
}
