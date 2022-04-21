
namespace Cafe_Management_System.All_User_Controls
{
    partial class UC_Update_Item
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
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Update_Item = new System.Windows.Forms.Label();
            this.pnl_Add_New_Item = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_Update_Item = new System.Windows.Forms.DataGridView();
            this.pnl_Add_New_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Update_Item)).BeginInit();
            this.SuspendLayout();
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
            this.cmb_Category.Location = new System.Drawing.Point(86, 498);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(300, 48);
            this.cmb_Category.TabIndex = 5;
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Item_Name.Location = new System.Drawing.Point(86, 619);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(300, 48);
            this.tb_Item_Name.TabIndex = 6;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Price.Location = new System.Drawing.Point(528, 498);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(300, 48);
            this.tb_Price.TabIndex = 7;
            // 
            // lbl_Update_Item
            // 
            this.lbl_Update_Item.AutoSize = true;
            this.lbl_Update_Item.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Item.Location = new System.Drawing.Point(7, 10);
            this.lbl_Update_Item.Name = "lbl_Update_Item";
            this.lbl_Update_Item.Size = new System.Drawing.Size(244, 61);
            this.lbl_Update_Item.TabIndex = 0;
            this.lbl_Update_Item.Text = "Update Item";
            // 
            // pnl_Add_New_Item
            // 
            this.pnl_Add_New_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add_New_Item.Controls.Add(this.dgv_Update_Item);
            this.pnl_Add_New_Item.Controls.Add(this.label1);
            this.pnl_Add_New_Item.Controls.Add(this.textBox1);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Price);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Category);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.cmb_Category);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Price);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Update_Item);
            this.pnl_Add_New_Item.Controls.Add(this.btn_Update);
            this.pnl_Add_New_Item.Location = new System.Drawing.Point(24, 22);
            this.pnl_Add_New_Item.Name = "pnl_Add_New_Item";
            this.pnl_Add_New_Item.Size = new System.Drawing.Size(959, 691);
            this.pnl_Add_New_Item.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(565, 606);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(212, 61);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(520, 452);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(79, 43);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(78, 452);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(127, 43);
            this.lbl_Category.TabIndex = 9;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Name.Location = new System.Drawing.Point(78, 573);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(153, 43);
            this.lbl_Item_Name.TabIndex = 8;
            this.lbl_Item_Name.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Item Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.textBox1.Location = new System.Drawing.Point(632, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 48);
            this.textBox1.TabIndex = 11;
            // 
            // dgv_Update_Item
            // 
            this.dgv_Update_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Update_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Update_Item.Location = new System.Drawing.Point(18, 167);
            this.dgv_Update_Item.Name = "dgv_Update_Item";
            this.dgv_Update_Item.RowHeadersWidth = 51;
            this.dgv_Update_Item.RowTemplate.Height = 24;
            this.dgv_Update_Item.Size = new System.Drawing.Size(925, 269);
            this.dgv_Update_Item.TabIndex = 13;
            // 
            // UC_Update_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Add_New_Item);
            this.Name = "UC_Update_Item";
            this.Size = new System.Drawing.Size(1006, 735);
            this.pnl_Add_New_Item.ResumeLayout(false);
            this.pnl_Add_New_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Update_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Update_Item;
        private System.Windows.Forms.Panel pnl_Add_New_Item;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.DataGridView dgv_Update_Item;
    }
}
