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
    public partial class frm_Exam_Form : Form
    {
        public frm_Exam_Form()
        {
            InitializeComponent();
        }

        string value,course;
        int Cnt = 0, Minutes, Marks, Atpt_Que, Time,Que,per_Mark;
        

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

            Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Set_Exam";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

             if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Exam_Id) From Set_Exam";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cmd.Dispose();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select No_Of_Que,Course_Name,Time, Per_Que_Marks from Set_Exam where Exam_Id = " + Cnt + "";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    Que = Convert.ToInt32(Obj["No_Of_Que"]);
                    course = Obj.GetString(Obj.GetOrdinal("Course_Name"));
                    Time = Convert.ToInt32(Obj["Time"]);
                    per_Mark = Convert.ToInt32(Obj["Per_Que_Marks"]);
                }

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
            Auto_Increment();
            cmb_Answer.SelectedIndex = -1;
            tb_Que.Clear();
            tb_Option_A.Clear();
            tb_Option_B.Clear();
            tb_Option_C.Clear();
            tb_Option_D.Clear();
            tb_Course.Clear();

            Atpt_Que = 0;
            Marks = 0;
        }

        void Bind_Question()
        {
            cmb_Answer.Items.Clear();
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select * from Question_Details where Que_No = " + tb_Que_No.Text + "";

            SqlDataReader sdr = Cmd.ExecuteReader();

            while (sdr.Read())
            {
                tb_Course.Text = course;
                tb_Que.Text = (sdr.GetString(sdr.GetOrdinal("Question")));
                tb_Option_A.Text = (sdr.GetString(sdr.GetOrdinal("Op_A")));
                tb_Option_B.Text = (sdr.GetString(sdr.GetOrdinal("Op_C")));
                tb_Option_C.Text = (sdr.GetString(sdr.GetOrdinal("Op_C")));
                tb_Option_D.Text = (sdr.GetString(sdr.GetOrdinal("Op_D")));
                value = (sdr.GetString(sdr.GetOrdinal("Ans")));
                cmb_Answer.Items.Add(sdr.GetString(sdr.GetOrdinal("Op_A")));
                cmb_Answer.Items.Add(sdr.GetString(sdr.GetOrdinal("Op_B")));
                cmb_Answer.Items.Add(sdr.GetString(sdr.GetOrdinal("Op_C")));
                cmb_Answer.Items.Add(sdr.GetString(sdr.GetOrdinal("Op_D")));
            }

            Cmd.Dispose();
            sdr.Dispose();

            Con_Close();
        }

        void Finish()
        {
            DialogResult Res = MessageBox.Show("Are You Sure You Want To End Exam?", "End", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                Countdown_Timer.Stop();
                MessageBox.Show("Exam Submitted Successfully!", "End");
                frm_Login log = new frm_Login();
                log.Show();
                this.Hide();
            }
        }

        private void frm_Exam_Form_Load(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
            Clear_Controls();
            tb_Que_No.Text = Convert.ToString(1);
            Bind_Question();
            Minutes = Time;
            Countdown_Timer.Start();

            lbl_Name_S.Text = Global_Vars.Uname;
            lbl_Id.Text = Global_Vars.UID;
        }

        private void btn_Save_Next_Click(object sender, EventArgs e)
        {
            if (cmb_Answer.Text != "")
            {

                if (Convert.ToInt32(tb_Que_No.Text) <= Que)
                {

                    Con_Open();

                    Atpt_Que++;

                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Con;
                    Cmd.CommandText = "insert into Exam_Details(Que_No,Ans,Given_Answer,Date,U_Name,ID,Attempt_Que,Marks)values(@Que,@ans,@given_ans,@date,@uname,@id,@Atpt,@mark)";

                    Cmd.Parameters.Add("Que", SqlDbType.Int).Value = tb_Que_No.Text;
                    Cmd.Parameters.Add("ans", SqlDbType.NVarChar).Value = cmb_Answer.Text;
                    Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_Date.Text;
                    Cmd.Parameters.Add("uname", SqlDbType.NVarChar).Value = lbl_Name_S.Text;
                    Cmd.Parameters.Add("id", SqlDbType.Int).Value = lbl_Id.Text;
                    Cmd.Parameters.Add("Atpt", SqlDbType.Int).Value = Atpt_Que;


                    if (cmb_Answer.Text == value)
                    {
                        Cmd.Parameters.Add("given_ans", SqlDbType.Int).Value = 1;
                        Marks += per_Mark;

                    }
                    else
                    {
                        Cmd.Parameters.Add("given_ans", SqlDbType.Int).Value = 0;
                       
                    }
                    Cmd.Parameters.Add("mark", SqlDbType.Int).Value = Marks;

                    Cmd.ExecuteNonQuery();

                    tb_Que_No.Text = (Convert.ToInt32(tb_Que_No.Text) + 1).ToString();

                    if (Convert.ToInt32(tb_Que_No.Text) > Que)
                    {
                        Finish();
                    }
                    else
                    {
                        Bind_Question();
                    }
                }
                else
                {
                    Finish();
                }
            }
            else
            {
                MessageBox.Show("Select Your Answer!", "Select");
            }

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                Countdown_Timer.Stop();
                frm_Login log = new frm_Login();
                log.Show();
                this.Hide();
            }

        }

        private void Countdown_Timer_Tick(object sender, EventArgs e)
        {

            tb_Timer.Text = Minutes--.ToString();

            if (Minutes < 0)
            {
                Countdown_Timer.Stop();

                MessageBox.Show("Exam Submitted Successfully!", "End");
                frm_Login log = new frm_Login();
                log.Show();
                this.Close();
            }
        }

    }
}
