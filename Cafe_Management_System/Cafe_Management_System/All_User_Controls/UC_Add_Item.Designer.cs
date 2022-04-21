
namespace Cafe_Management_System.All_User_Controls
{
    partial class UC_Add_Item
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
            this.lbl_Add_New_Item = new System.Windows.Forms.Label();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.pnl_Add_New_Item = new System.Windows.Forms.Panel();
            this.pnl_Add_New_Item.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Item
            // 
            this.lbl_Add_New_Item.AutoSize = true;
            this.lbl_Add_New_Item.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Item.Location = new System.Drawing.Point(298, 56);
            this.lbl_Add_New_Item.Name = "lbl_Add_New_Item";
            this.lbl_Add_New_Item.Size = new System.Drawing.Size(310, 68);
            this.lbl_Add_New_Item.TabIndex = 0;
            this.lbl_Add_New_Item.Text = "Add New Item";
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Name.Location = new System.Drawing.Point(203, 342);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(153, 43);
            this.lbl_Item_Name.TabIndex = 1;
            this.lbl_Item_Name.Text = "Item Name";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(203, 221);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(127, 43);
            this.lbl_Category.TabIndex = 2;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(203, 467);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(79, 43);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(328, 601);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(212, 61);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
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
            this.cmb_Category.Location = new System.Drawing.Point(190, 247);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(503, 48);
            this.cmb_Category.TabIndex = 5;
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Item_Name.Location = new System.Drawing.Point(190, 368);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(503, 48);
            this.tb_Item_Name.TabIndex = 6;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Price.Location = new System.Drawing.Point(190, 493);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(503, 48);
            this.tb_Price.TabIndex = 7;
            // 
            // pnl_Add_New_Item
            // 
            this.pnl_Add_New_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add_New_Item.Controls.Add(this.cmb_Category);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Price);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Add_New_Item);
            this.pnl_Add_New_Item.Controls.Add(this.btn_Add);
            this.pnl_Add_New_Item.Location = new System.Drawing.Point(20, 19);
            this.pnl_Add_New_Item.Name = "pnl_Add_New_Item";
            this.pnl_Add_New_Item.Size = new System.Drawing.Size(959, 691);
            this.pnl_Add_New_Item.TabIndex = 8;
            // 
            // UC_Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Item_Name);
            this.Controls.Add(this.pnl_Add_New_Item);
            this.Name = "UC_Add_Item";
            this.Size = new System.Drawing.Size(1006, 735);
            this.pnl_Add_New_Item.ResumeLayout(false);
            this.pnl_Add_New_Item.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Item;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Panel pnl_Add_New_Item;
    }
}
