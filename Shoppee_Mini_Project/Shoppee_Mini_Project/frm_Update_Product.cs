using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoppee_Mini_Project
{
    public partial class frm_Update_Product : Form
    {
        public frm_Update_Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mini_Shoppee_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Product_Details where Product_ID = " + tb_Product_ID.Text + " ", Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Product_Name.Text =  obj.GetString(obj.GetOrdinal("Product_Name"));
                tb_Product_Category.Text =  obj.GetString(obj.GetOrdinal("Product_Category"));
                tb_Purchase_Rate.Text = (obj["Purchase_Price"].ToString());
                tb_Sales_Rate.Text = (obj["Sales_Price"].ToString());
                dtp_Date.Text = (obj["Date"].ToString());
               
                tb_Product_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Product ID!!!");
                tb_Product_ID.Clear();
                tb_Product_ID.Focus();
            }
            obj.Dispose();
            Con_Close();
        }

        private void frm_Update_Product_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Focus();
        }

        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();
            tb_Product_Category.Clear();

            tb_Product_ID.Focus();
            tb_Product_ID.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Name.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sales_Rate.Text != "" && tb_Product_Category.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details Set Purchase_Price = " + tb_Purchase_Rate.Text + ", Sales_Price = " + tb_Sales_Rate.Text + " where Product_ID = " + tb_Product_ID.Text + "", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Updated Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }
    }
}
