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
    public partial class Result_Report : Form
    {
        public Result_Report()
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

        private void Result_Report_Load(object sender, EventArgs e)
        {
            Con_Open();

            string Query = "Select * from Result_Details";

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);

            DataSet ds = new DataSet();
            sda.Fill(ds, "Result_Details");

            ResultCrystalReport sdr = new ResultCrystalReport();
            sdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = sdr;


            Con_Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Form mf = new frm_Main_Form();
            mf.Show();
            this.Hide();
        }
    }
}
