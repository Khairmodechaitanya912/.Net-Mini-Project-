using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.All_User_Controls
{
    public partial class Remove_Item : UserControl
    {
        Function Fn = new Function();
        String query;
        public Remove_Item()
        {
            InitializeComponent();
        }

        private void Remove_Item_Load(object sender, EventArgs e)
        {
            lbl_Delete_Lbl.Text = "How To Delete??";
            lbl_Delete_Lbl.ForeColor = Color.Blue;

            Load_Data(); 
        }
        public void Load_Data()
        {
            query = "Select * From Item";
            DataSet Ds = Fn.getData(query);
            dgv_Delete_Item.DataSource = Ds.Tables[0];
        }

        private void tb_Item_Name_TextChanged(object sender, EventArgs e)
        {
            query = "Select * From Item Where Name like '" + tb_Item_Name.Text + "%'";
            DataSet Ds = Fn.getData(query);
            dgv_Delete_Item.DataSource = Ds.Tables[0];
        }

        private void dgv_Delete_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item..???", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int Id = int.Parse(dgv_Delete_Item.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete From Item Where I_Id = " + Id + "";
                Fn.setData(query);
                Load_Data();
            }
        }

        private void lbl_Delete_Lbl_Click(object sender, EventArgs e)
        {
            lbl_Delete_Lbl.ForeColor = Color.Red;
            lbl_Delete_Lbl.Text = "*Click On Row To Delete The Item*";
        }

        private void Remove_Item_Enter(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
