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
    public partial class UC_Update_Item : UserControl
    {
        Function Fn = new Function();
        String query;
        public UC_Update_Item()
        {
            InitializeComponent();
        }

        private void UC_Update_Item_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {
            query = "Select * from Item";
            DataSet DS = Fn.getData(query);
            dgv_Update_Item.DataSource = DS.Tables[0];
        }

        private void tb_Items_name_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from Item Where Name Like '" + tb_Items_name.Text + "%'";
            DataSet Ds = Fn.getData(query);
            dgv_Update_Item.DataSource = Ds.Tables[0];
        }

        int id;
        private void dgv_Update_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             id = int.Parse(dgv_Update_Item.Rows[e.RowIndex].Cells[0].Value.ToString());
             String Category = dgv_Update_Item.Rows[e.RowIndex].Cells[2].Value.ToString();
             String Name = dgv_Update_Item.Rows[e.RowIndex].Cells[1].Value.ToString();
             int Price = int.Parse(dgv_Update_Item.Rows[e.RowIndex].Cells[3].Value.ToString());

             cmb_Category.Text = Category;
             tb_Item_Name.Text = Name;
             tb_Price.Text = Price.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Item_Name.Text != "" && tb_Price.Text != "" && cmb_Category.Text != "")
            {
                query = "Update Item  Set Name = '" + tb_Item_Name.Text + "', category = '" + cmb_Category.Text + "', price = " + tb_Price.Text + " Where I_Id = " + id + "";
                Fn.setData(query);
                Load_Data();

                cmb_Category.SelectedIndex = -1;
                tb_Item_Name.Clear();
                tb_Price.Clear();
            }
            else
            {
                MessageBox.Show("Select The Row Who's Product Is Update...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
