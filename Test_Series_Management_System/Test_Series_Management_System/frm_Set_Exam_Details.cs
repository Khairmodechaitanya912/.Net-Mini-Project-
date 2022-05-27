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
    public partial class frm_Set_Exam_Details : Form
    {
        public frm_Set_Exam_Details()
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
            Cmd.CommandText = "Select Count (*) From Set_Exam";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Exam_Id) From Set_Exam";

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
            tb_Exam_Id.Text = Convert.ToString(Auto_Increment());
            cmb_Course_Name.SelectedIndex = -1;
            tb_No_Of_Que.Clear();
            tb_Per_Que_Marks.Clear();
            tb_Time_For_Exam.Clear();
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Course fc = new frm_Course();
            fc.Show();
            this.Hide();
        }

        private void frm_Set_Exam_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Courses();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (tb_Exam_Id.Text != "" && cmb_Course_Name.Text != "" && tb_Per_Que_Marks.Text != "" && tb_Time_For_Exam.Text != "" && tb_No_Of_Que.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Set_Exam(Exam_Id,Course_Name,No_Of_Que,Per_Que_Marks,Time) Values(@C_ID,@C_Name,@NQ,@PQ,@Time)";

                Cmd.Parameters.Add("C_ID", SqlDbType.Int).Value = tb_Exam_Id.Text;
                Cmd.Parameters.Add("C_Name", SqlDbType.NVarChar).Value = cmb_Course_Name.Text;
                Cmd.Parameters.Add("NQ", SqlDbType.Int).Value = tb_No_Of_Que.Text;
                Cmd.Parameters.Add("PQ", SqlDbType.Int).Value = tb_Per_Que_Marks.Text;
                Cmd.Parameters.Add("Time", SqlDbType.Int).Value = tb_Time_For_Exam.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Set Exam Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
