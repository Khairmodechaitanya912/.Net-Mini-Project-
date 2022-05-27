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
    public partial class frm_Result_Form : Form
    {
        public frm_Result_Form()
        {
            InitializeComponent();
        }

        int Cnt, atpt, Tot, Que, Res, per_Mark;

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

        void Clear_Controls()
        {
            tb_Std_Id.Clear();
            tb_Std_Name.Clear();
            tb_Atpt_Que.Clear();
            tb_Result.Clear();
            tb_Total.Clear();


            Cnt = 0;
            atpt = 0;
            Tot = 0;
        }


        int Auto_Increment()
        {
            Con_Open();

            Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Exam_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Attempt_Que) From Exam_Details where ID = " + tb_Std_Id.Text + "";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();
            Con_Close();

            return Cnt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
             if (tb_Std_Id.Text != "")
            {
                Con_Open();

                SqlCommand Cmd4 = new SqlCommand();

                Cmd4.Connection = Con;

                Cmd4.CommandText = "Select ID from Exam_Details where ID = " + tb_Std_Id.Text + "";

                var Obj1 = Cmd4.ExecuteReader();

                if (Obj1.Read())
                {
                    Obj1.Dispose();
                    Cmd4.Dispose();

                    Auto_Increment();

                    Con_Open();

                    SqlCommand Cmd1 = new SqlCommand();

                    Cmd1.Connection = Con;

                    Cmd1.CommandText = "Select Max(Marks) from Exam_Details where Attempt_Que = " + Cnt + "";

                    Tot = Convert.ToInt32(Cmd1.ExecuteScalar());    // Count Of Total Marks

                    Cmd1.Dispose();


                    SqlCommand Cmd2 = new SqlCommand();

                    Cmd2.Connection = Con;

                    Cmd2.CommandText = "Select Max(Attempt_Que) from Exam_Details where Attempt_Que = " + Cnt + "";

                    atpt = Convert.ToInt32(Cmd2.ExecuteScalar());      //Attempted Que 

                    Cmd2.Dispose();


                    SqlCommand Cmd3 = new SqlCommand();

                    Cmd3.Connection = Con;

                    Cmd3.CommandText = "Select No_Of_Que from Set_Exam where Exam_Id = " + Cnt + "";

                    Que = Convert.ToInt32(Cmd3.ExecuteScalar());

                    Res = Que-Tot;    // Calculate Result
                    
                    Cmd3.Dispose();


                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Con;

                    Cmd.CommandText = "Select ID,U_Name,Attempt_Que from Exam_Details where ID = " + tb_Std_Id.Text + "";

                    var Obj = Cmd.ExecuteReader();
                    //SqlDataReader Obj = Cmd.EndExecuteReader();

                    if (Obj.Read())
                    {
                        tb_Std_Name.Text = Obj.GetString(Obj.GetOrdinal("U_Name"));
                        tb_Atpt_Que.Text = Convert.ToString(atpt);
                        tb_Total.Text = Convert.ToString(Tot);
                        tb_Result.Text = Res.ToString();

                        if (Convert.ToInt32(tb_Result.Text) >= Tot / 2)
                        {
                            lbl_Result.Visible = true;
                            lbl_Result.Text = "Pass";
                            lbl_Result.ForeColor = Color.Green;
                        }
                        else
                        {
                            lbl_Result.Text = "Fail";
                            lbl_Result.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student is Not Available.....", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Clear_Controls();
                    }

                    Obj.Dispose();
                    Cmd.Dispose();
                    Con_Close();
                }
                else
                {
                    MessageBox.Show("This Student Has Been Not Given Any Exam Yet!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Obj1.Dispose();
            }
        }

        private void frm_Result_Form_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Std_Id.Text != "" && tb_Std_Name.Text != "" && tb_Total.Text != "" && tb_Atpt_Que.Text != "" && tb_Result.Text != "" && ((lbl_Result.Text == "Pass") || (lbl_Result.Text == "Fail")) )
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Result_Details(ID,U_Name,Attempt_Que,Total,Result,Status)values(@id,@uname,@atpt,@tot,@res,@status)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Std_Id.Text;
                Cmd.Parameters.Add("uname", SqlDbType.NVarChar).Value = tb_Std_Name.Text;
                Cmd.Parameters.Add("atpt", SqlDbType.Int).Value = tb_Atpt_Que.Text;
                Cmd.Parameters.Add("tot", SqlDbType.Int).Value = tb_Total.Text;
                Cmd.Parameters.Add("res", SqlDbType.Int).Value = tb_Result.Text;
                Cmd.Parameters.Add("status",SqlDbType.NVarChar).Value = lbl_Result.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Result Save Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Check all Details...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Course fc = new frm_Course();
            fc.Show();
            this.Hide();
        }
    }
}
