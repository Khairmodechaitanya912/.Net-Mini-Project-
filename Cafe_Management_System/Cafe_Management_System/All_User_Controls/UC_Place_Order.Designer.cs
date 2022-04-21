
namespace Cafe_Management_System.All_User_Controls
{
    partial class UC_Place_Order
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Add_New_Item = new System.Windows.Forms.Panel();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Place_Order = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.lb_Item_List = new System.Windows.Forms.ListBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_Add_To_Cart = new System.Windows.Forms.Button();
            this.pnl_Order_Item = new System.Windows.Forms.Panel();
            this.dgv_Place_Order = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Print = new System.Windows.Forms.Button();
            this.lbl_Grand_Total = new System.Windows.Forms.Label();
            this.lbl_RS = new System.Windows.Forms.Label();
            this.pnl_Add_New_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Place_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Item
            // 
            this.pnl_Add_New_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add_New_Item.Controls.Add(this.lbl_RS);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Grand_Total);
            this.pnl_Add_New_Item.Controls.Add(this.btn_Remove);
            this.pnl_Add_New_Item.Controls.Add(this.btn_Print);
            this.pnl_Add_New_Item.Controls.Add(this.dgv_Place_Order);
            this.pnl_Add_New_Item.Controls.Add(this.btn_Add_To_Cart);
            this.pnl_Add_New_Item.Controls.Add(this.nud_Quantity);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Total);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Quantity);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Total);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Search);
            this.pnl_Add_New_Item.Controls.Add(this.lb_Item_List);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Price);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Category);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.cmb_Category);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Price);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Place_Order);
            this.pnl_Add_New_Item.Controls.Add(this.pnl_Order_Item);
            this.pnl_Add_New_Item.Location = new System.Drawing.Point(24, 22);
            this.pnl_Add_New_Item.Name = "pnl_Add_New_Item";
            this.pnl_Add_New_Item.Size = new System.Drawing.Size(959, 691);
            this.pnl_Add_New_Item.TabIndex = 9;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Cake",
            "South Indian",
            "Breakfast",
            "Ice-Cream"});
            this.cmb_Category.Location = new System.Drawing.Point(14, 127);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(215, 48);
            this.cmb_Category.TabIndex = 5;
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Item_Name.Location = new System.Drawing.Point(294, 76);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(246, 48);
            this.tb_Item_Name.TabIndex = 6;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Price.Location = new System.Drawing.Point(656, 76);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(246, 48);
            this.tb_Price.TabIndex = 7;
            // 
            // lbl_Place_Order
            // 
            this.lbl_Place_Order.AutoSize = true;
            this.lbl_Place_Order.Font = new System.Drawing.Font("Segoe Print", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Place_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.lbl_Place_Order.Location = new System.Drawing.Point(3, 9);
            this.lbl_Place_Order.Name = "lbl_Place_Order";
            this.lbl_Place_Order.Size = new System.Drawing.Size(237, 62);
            this.lbl_Place_Order.TabIndex = 0;
            this.lbl_Place_Order.Text = "Place Order";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(266, 612);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(163, 56);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(650, 30);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(79, 43);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(9, 87);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(104, 35);
            this.lbl_Category.TabIndex = 9;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Name.Location = new System.Drawing.Point(286, 30);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(153, 43);
            this.lbl_Item_Name.TabIndex = 8;
            this.lbl_Item_Name.Text = "Item Name";
            // 
            // lb_Item_List
            // 
            this.lb_Item_List.FormattingEnabled = true;
            this.lb_Item_List.ItemHeight = 16;
            this.lb_Item_List.Location = new System.Drawing.Point(14, 250);
            this.lb_Item_List.Name = "lb_Item_List";
            this.lb_Item_List.Size = new System.Drawing.Size(230, 420);
            this.lb_Item_List.TabIndex = 11;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Search.Location = new System.Drawing.Point(14, 191);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(192, 48);
            this.tb_Search.TabIndex = 12;
            this.tb_Search.Text = "Search";
            this.tb_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(648, 151);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(81, 43);
            this.lbl_Total.TabIndex = 16;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(286, 151);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(126, 43);
            this.lbl_Quantity.TabIndex = 15;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Total.Location = new System.Drawing.Point(656, 197);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(246, 48);
            this.tb_Total.TabIndex = 14;
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.nud_Quantity.Location = new System.Drawing.Point(294, 197);
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(246, 48);
            this.nud_Quantity.TabIndex = 17;
            // 
            // btn_Add_To_Cart
            // 
            this.btn_Add_To_Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Add_To_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_To_Cart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_To_Cart.ForeColor = System.Drawing.Color.White;
            this.btn_Add_To_Cart.Location = new System.Drawing.Point(725, 276);
            this.btn_Add_To_Cart.Name = "btn_Add_To_Cart";
            this.btn_Add_To_Cart.Size = new System.Drawing.Size(172, 49);
            this.btn_Add_To_Cart.TabIndex = 18;
            this.btn_Add_To_Cart.Text = "Add To Cart";
            this.btn_Add_To_Cart.UseVisualStyleBackColor = false;
            // 
            // pnl_Order_Item
            // 
            this.pnl_Order_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Order_Item.Location = new System.Drawing.Point(266, 23);
            this.pnl_Order_Item.Name = "pnl_Order_Item";
            this.pnl_Order_Item.Size = new System.Drawing.Size(667, 316);
            this.pnl_Order_Item.TabIndex = 19;
            // 
            // dgv_Place_Order
            // 
            this.dgv_Place_Order.AllowUserToAddRows = false;
            this.dgv_Place_Order.AllowUserToDeleteRows = false;
            this.dgv_Place_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Place_Order.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Place_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Place_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Unit_Price,
            this.Quantity,
            this.Price});
            this.dgv_Place_Order.Location = new System.Drawing.Point(266, 349);
            this.dgv_Place_Order.Name = "dgv_Place_Order";
            this.dgv_Place_Order.ReadOnly = true;
            this.dgv_Place_Order.RowHeadersWidth = 51;
            this.dgv_Place_Order.RowTemplate.Height = 24;
            this.dgv_Place_Order.Size = new System.Drawing.Size(667, 225);
            this.dgv_Place_Order.TabIndex = 20;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.MinimumWidth = 6;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(770, 610);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(163, 58);
            this.btn_Print.TabIndex = 21;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // lbl_Grand_Total
            // 
            this.lbl_Grand_Total.AutoSize = true;
            this.lbl_Grand_Total.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grand_Total.Location = new System.Drawing.Point(528, 580);
            this.lbl_Grand_Total.Name = "lbl_Grand_Total";
            this.lbl_Grand_Total.Size = new System.Drawing.Size(137, 35);
            this.lbl_Grand_Total.TabIndex = 22;
            this.lbl_Grand_Total.Text = "Grand Total";
            // 
            // lbl_RS
            // 
            this.lbl_RS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_RS.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RS.Location = new System.Drawing.Point(512, 617);
            this.lbl_RS.Name = "lbl_RS";
            this.lbl_RS.Size = new System.Drawing.Size(178, 64);
            this.lbl_RS.TabIndex = 23;
            this.lbl_RS.Text = "Rs.00";
            this.lbl_RS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Place_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Add_New_Item);
            this.Name = "UC_Place_Order";
            this.Size = new System.Drawing.Size(1006, 735);
            this.pnl_Add_New_Item.ResumeLayout(false);
            this.pnl_Add_New_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Place_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Item;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Place_Order;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.ListBox lb_Item_List;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.Button btn_Add_To_Cart;
        private System.Windows.Forms.Panel pnl_Order_Item;
        private System.Windows.Forms.DataGridView dgv_Place_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label lbl_RS;
        private System.Windows.Forms.Label lbl_Grand_Total;
    }
}
