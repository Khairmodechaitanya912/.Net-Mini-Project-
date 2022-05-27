using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Series_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Test_Series_Mgt_System;Integrated Security=True");

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

        private void btn_Log_Click(object sender, EventArgs e)
        {

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Login_Details Where Username = @UName And Password = @Pass And ID = @id";

            Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_ID.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_ID.Text && tb_ID.Text != "")
            {
                Global_Vars.Uname = tb_Username.Text;
                Global_Vars.UID = tb_ID.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.User_Role = 1;
                }
                else if (tb_Username.Text == "Teacher")
                {
                    Global_Vars.User_Role = 2;
                }

                MessageBox.Show(" Login Successful...!! ", "Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Main_Form MF = new frm_Main_Form();

                MF.Show();
                this.Hide();


            }

            else
            {

                MessageBox.Show(" Please Check Username or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            tb_Username.Enabled = true;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Log.Enabled = true;
        }


    }
}
