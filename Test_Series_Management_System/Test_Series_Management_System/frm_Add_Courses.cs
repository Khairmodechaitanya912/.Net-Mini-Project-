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
    public partial class frm_Add_Courses : Form
    {
        public frm_Add_Courses()
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
            Cmd.CommandText = "Select Count (*) From Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Course_ID) From Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }



        void Clear_Controls()
        {
            tb_Course_Id.Text = Convert.ToString(Auto_Increment());
            tb_Course_Name.Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Course fc = new frm_Course();
            fc.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Course_Name.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Course_Details(Course_ID,Course_Name) Values(@C_ID,@Course)";

                Cmd.Parameters.Add("C_ID", SqlDbType.Int).Value = tb_Course_Id.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = tb_Course_Name.Text;
               

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
        }

        private void frm_Add_Courses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_Series_Mgt_SystemDataSet.Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this.test_Series_Mgt_SystemDataSet.Course_Details);
            Clear_Controls();

        }
    }
}
