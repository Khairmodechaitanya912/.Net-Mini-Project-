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
    public partial class Frm_Add_Que : Form
    {
        public Frm_Add_Que()
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

        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Question_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Que_No) From Question_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        void Bind_Courses()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Course_Name) from Course_Details";

            SqlDataReader sdr = Cmd.ExecuteReader();

            while (sdr.Read())
            {
                cmb_Course_Name.Items.Add(sdr.GetString(sdr.GetOrdinal("Course_Name")));
            }

            Cmd.Dispose();
            sdr.Dispose();

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Que_No.Text = Convert.ToString(Auto_Increment());
            tb_Answer.Clear();
            tb_Question.Clear();
            tb_Option_A.Clear();
            tb_Option_B.Clear();
            tb_Option_C.Clear();
            tb_Option_D.Clear();
            cmb_Course_Name.SelectedIndex = -1;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Course fc = new frm_Course();
            fc.Show();
            this.Hide();
        }

        private void Frm_Add_Que_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Courses();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Course_Name.Text != "" && tb_Question.Text != "" && tb_Option_A.Text != "" && tb_Option_B.Text != "" && tb_Option_C.Text != "" && tb_Option_D.Text != "" && tb_Answer.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Question_Details(Que_No,Course_Name,Question,Op_A,Op_B,Op_C,Op_D,Ans) Values(@Q_ID,@C_Name,@Que,@A,@B,@C,@D,@Ans)";

                Cmd.Parameters.Add("Q_ID", SqlDbType.Int).Value = tb_Que_No.Text;
                Cmd.Parameters.Add("C_Name", SqlDbType.NVarChar).Value = cmb_Course_Name.Text;
                Cmd.Parameters.Add("Que", SqlDbType.NVarChar).Value = tb_Question.Text;
                Cmd.Parameters.Add("A", SqlDbType.NVarChar).Value = tb_Option_A.Text;
                Cmd.Parameters.Add("B", SqlDbType.NVarChar).Value = tb_Option_B.Text;
                Cmd.Parameters.Add("C", SqlDbType.NVarChar).Value = tb_Option_C.Text;
                Cmd.Parameters.Add("D", SqlDbType.NVarChar).Value = tb_Option_D.Text;
                Cmd.Parameters.Add("Ans", SqlDbType.NVarChar).Value = tb_Answer.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Question Add Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
        }

    }
}
