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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Max(Product_ID) from Product_Details", Con);

            if (Cmd.ExecuteScalar() == DBNull.Value)
            {
                Cnt = 101;
            }
            else
            {
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }

            Con_Close();

            return Cnt;
        }
		
        
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
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

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
            tb_Product_Name.Focus();
        }

        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();
            tb_Product_Category.Clear();

            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
            tb_Product_Name.Focus();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Name.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sales_Rate.Text != "" && tb_Product_Category.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Product_Details Values (@P_ID, @P_Name, @P_Cat, @Date, @PPrice, @SPrice) ", Con);

                cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                cmd.Parameters.Add("@P_Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("@P_Cat", SqlDbType.NVarChar).Value = tb_Product_Category.Text;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("@PPrice", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                cmd.Parameters.Add("@SPrice", SqlDbType.Money).Value = tb_Sales_Rate.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
