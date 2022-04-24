using DGVPrinterHelper;
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
            String Category = cmb_Category.Text;
            query = "Select Name from Item where category = '" + Category + "'";
            Show_Item_List(query);
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            String Category = cmb_Category.Text;
            query = "Select Name from Item where category = '" + Category + "' And Name Like '" + tb_Search.Text + "%'";
            Show_Item_List(query);
        }

        private void Show_Item_List(String query)
        {
            lb_Item_List.Items.Clear();
            DataSet DS = Fn.getData(query);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lb_Item_List.Items.Add(DS.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lb_Item_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            nud_Quantity.ResetText();
            tb_Total.Clear();

            String Text = lb_Item_List.GetItemText(lb_Item_List.SelectedItem);
            tb_Item_Name.Text = Text;
            query = "Select price From Item Where Name = '" + Text + "'";
            DataSet DS = Fn.getData(query);

            try
            {
                tb_Price.Text = DS.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
           

        }

        private void nud_Quantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 Qty = Int64.Parse(nud_Quantity.Value.ToString());
            Int64 Pri = Int64.Parse(tb_Price.Text);
            tb_Total.Text = (Qty * Pri).ToString();
        }

        protected int N, Tot = 0;

        private void btn_Add_To_Cart_Click(object sender, EventArgs e)
        {
            if(tb_Total.Text != "0" && tb_Total.Text != "")
            {
                N = dgv_Place_Order.Rows.Add();
                dgv_Place_Order.Rows[N].Cells[0].Value = tb_Item_Name.Text;
                dgv_Place_Order.Rows[N].Cells[1].Value = tb_Price.Text;
                dgv_Place_Order.Rows[N].Cells[2].Value = nud_Quantity.Value;
                dgv_Place_Order.Rows[N].Cells[3].Value = tb_Total.Text;

                Tot += int.Parse(tb_Total.Text);
                lbl_RS.Text = "Rs. " + Tot;
            }
            else
            {
                MessageBox.Show("Minimum Quantity Needs To be 1", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int Amount;
        private void dgv_Place_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Amount = int.Parse(dgv_Place_Order.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0} ", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + lbl_RS.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_Place_Order);

            Tot = 0;
            dgv_Place_Order.Rows.Clear();
            lbl_RS.Text = "Rs. " + Tot;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Place_Order.Rows.RemoveAt(this.dgv_Place_Order.SelectedRows[0].Index);
            }
            catch
            {

            }
            Tot -= Amount;
            lbl_RS.Text = "Rs. " + Tot;
        }

    }
}
