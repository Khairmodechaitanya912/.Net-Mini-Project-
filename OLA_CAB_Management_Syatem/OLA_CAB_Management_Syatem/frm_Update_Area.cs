﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OLA_CAB_Management_Syatem
{
    public partial class frm_Update_Area : Form
    {
        public frm_Update_Area()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_OLA_CAB_Mgt_System;Integrated Security=True");

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
            tb_Area_Id.Focus();
            tb_Name.Text = "";
            tb_Kilometer.Text = "";
            tb_Kmper_Price.Text = "";
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (tb_Area_Id.Text != "" && tb_Name.Text != "" && tb_Kilometer.Text != "" && tb_Kmper_Price.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Area_Details Set Area_Name = @A_Name,Km = @Km,Km_Price = @Km_Price";

                Cmd.Parameters.Add("A_Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Km", SqlDbType.Float).Value = tb_Kilometer.Text;
                Cmd.Parameters.Add("Km_Price", SqlDbType.Float).Value = tb_Kmper_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Area Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (tb_Area_Id.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Area_Details where Area_Id = " + tb_Area_Id.Text + " ";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Area_Name"));
                    tb_Kilometer.Text = (Dr["Km"].ToString());
                    tb_Kmper_Price.Text = (Dr["Km_Price"].ToString());
                }
                else
                {
                    MessageBox.Show("Area Not Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Area_Id.Clear();
                    tb_Area_Id.Focus();
                }

                Con_Close();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Update_Area_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Numerics(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
