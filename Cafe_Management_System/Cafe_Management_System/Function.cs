using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data source =DESKTOP-MD52OUL\SQL2019; database = DB_Cafe_Management_System ; integrated security=True";
            return Con;
        }

        public DataSet getData(String query)
        {
            SqlConnection Con = getConnection();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = query;
            SqlDataAdapter SDA = new SqlDataAdapter(Cmd);
            DataSet Ds = new DataSet();
            SDA.Fill(Ds);
            return Ds;
        }

        public void setData(String query)
        {
            SqlConnection Con = getConnection();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();

            MessageBox.Show("Data Processed Successfully.","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Con.Close();
        }
    }
}
