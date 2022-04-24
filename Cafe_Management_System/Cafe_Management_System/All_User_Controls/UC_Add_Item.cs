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
    public partial class UC_Add_Item : UserControl
    {
        Function Fn = new Function();
        String query;
        public UC_Add_Item()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Item_Name.Text != "" && cmb_Category.Text != "" && tb_Price.Text != "")
            {
                query = "Insert Into Item (Name, category, price)Values('" + tb_Item_Name.Text + "', '" + cmb_Category.Text + "', " + tb_Price.Text + ")";
                Fn.setData(query);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Plzz Fill All The Information..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            
        }

        public void Clear_Controls()
        {
            cmb_Category.SelectedIndex = -1;
            tb_Item_Name.Clear();
            tb_Price.Clear();
        }

        private void UC_Add_Item_Leave(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
