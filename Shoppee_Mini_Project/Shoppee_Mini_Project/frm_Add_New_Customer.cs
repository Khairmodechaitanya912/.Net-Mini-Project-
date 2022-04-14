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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mini_Shoppee_DB;Integrated Security=True");

        int pCnt = 1;

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

            SqlCommand Cmd = new SqlCommand("Select Max(Customer_ID) from Customer_Details", Con);

            if (Cmd.ExecuteScalar() == DBNull.Value)
            {
                Cnt = 1001;
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
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());

            dtp_Bill_Date.ResetText();
            tb_Customer_Name.Clear();
            tb_Customer_Mob_No.Clear();

            pCnt = 1;

            tb_Quantity.Text = "0";
            tb_Price.Text = "0";
            tb_Total_Price.Text = "0";
            tb_Total_Bill.Text = "0";
            dgv_Purchase_Details.Rows.Clear();

            cmb_Product_Name.SelectedIndex = -1;
        }

        void Bind_Combo_Box()
        {
            Con_Open();

            cmb_Product_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Product_Name) From Product_Details", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            obj.Dispose();
            Con_Close();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            Bind_Combo_Box();
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_Customer_Name.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Product_Name.Text != "" && tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                dgv_Purchase_Details.Rows.Add(pCnt, cmb_Product_Name.Text, tb_Price.Text, tb_Quantity.Text, tb_Total_Price.Text);
                pCnt++;

                double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                tb_Total_Bill.Text = Convert.ToString(Bill);
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            tb_Price.Clear();
            tb_Quantity.Text = "0";
            tb_Total_Price.Clear();
            cmb_Product_Name.SelectedIndex = -1;

            tb_Quantity.Enabled = false;
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Sales_Price From Product_Details where Product_Name = '" + cmb_Product_Name.Text + "' ", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Price.Text = (obj["Sales_Price"].ToString());
            }

            tb_Quantity.Enabled = true;

            Con_Close();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            double Tot = 0;

            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                Tot = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Price.Text);

                tb_Total_Price.Text = Convert.ToString(Tot);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_Name.Text != "" && tb_Customer_Mob_No.Text != "" && pCnt > 1 && tb_Total_Bill.Text != "" && Convert.ToInt32(tb_Total_Bill.Text) > 0)
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Customer_Details Values (@C_ID, @C_Name, @C_Mob_No, @Bill_Date, @Total_Bill) ", Con);

                cmd.Parameters.Add("@C_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                cmd.Parameters.Add("@C_Name", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                cmd.Parameters.Add("@C_Mob_No", SqlDbType.Decimal).Value = tb_Customer_Mob_No.Text;
                cmd.Parameters.Add("@Bill_Date", SqlDbType.Date).Value = dtp_Bill_Date.Value.Date;
                cmd.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = tb_Total_Bill.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert Into Purchase_Details Values (@ID, @P_Name, @Price, @Qty, @Tot_Price )", Con);

                    cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    cmd1.Parameters.Add("@P_Name", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Qty", SqlDbType.Int).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Tot_Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[4].Value;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }

                MessageBox.Show("Customer Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Fill Customer & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
