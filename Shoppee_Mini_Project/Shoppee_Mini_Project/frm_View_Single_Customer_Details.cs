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
    public partial class frm_View_Single_Customer_Details : Form
    {
        public frm_View_Single_Customer_Details()
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Customer_ID.Clear();
            dtp_Bill_Date.ResetText();
            tb_Customer_Name.Clear();
            tb_Customer_Mob_No.Clear();

            tb_Total_Bill.Text = "0";
            dgv_Purchase_Details.DataSource = "";

            tb_Customer_ID.Enabled = true;
            tb_Customer_ID.Focus();
        }

        private void frm_View_Single_Customer_Details_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Customer_Details where Customer_ID = " + tb_Customer_ID.Text + " ", Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Customer_Name.Text = obj.GetString(obj.GetOrdinal("Customer_Name"));
                tb_Customer_Mob_No.Text = (obj["Mobile_No"].ToString());
                dtp_Bill_Date.Text = (obj["Bill_Date"].ToString());
                tb_Total_Bill.Text = (obj["Total_Bill"].ToString());

                tb_Customer_ID.Enabled = false;
                obj.Dispose();

                dgv_Purchase_Details.DataSource = "";

                SqlDataAdapter SDA = new SqlDataAdapter("Select * From Purchase_Details where Customer_ID = " + tb_Customer_ID.Text + " ", Con);

                DataTable dt = new DataTable();

                SDA.Fill(dt);

                dgv_Purchase_Details.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid Customer ID !!!");
                tb_Customer_ID.Clear();
                tb_Customer_ID.Focus();
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer_Menu Obj = new frm_Customer_Menu();

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
