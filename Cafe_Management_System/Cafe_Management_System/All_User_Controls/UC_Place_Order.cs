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
    public partial class UC_Place_Order : UserControl
    {
        Function Fn = new Function();
        String query;
        public UC_Place_Order()
        {
            InitializeComponent();
        }

        private void tb_Search_Click(object sender, EventArgs e)
        {
            tb_Search.Text = "";
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Item_List.Items.Clear();
            String Category = cmb_Category.Text;
            query = "Select Name from Item where category = '" + Category + "'";
            DataSet DS = Fn.getData(query);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lb_Item_List.Items.Add(DS.Tables[0].Rows[i][0].ToString());
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            lb_Item_List.Items.Clear();
            String Category = cmb_Category.Text;
            query = "Select Name from Item where category = '" + Category + "' And Name Like '" + tb_Search.Text + "%'";
            DataSet DS = Fn.getData(query);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lb_Item_List.Items.Add(DS.Tables[0].Rows[i][0].ToString());
            }
        }

    
    }
}
