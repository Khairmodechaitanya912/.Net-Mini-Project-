
namespace Cafe_Management_System.All_User_Controls
{
    partial class Remove_Item
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
            this.lbl_Delete_Lbl = new System.Windows.Forms.Label();
            this.dgv_Delete_Item = new System.Windows.Forms.DataGridView();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.tb_Item_Name = new System.Windows.Forms.TextBox();
            this.lbl_Delete_Item = new System.Windows.Forms.Label();
            this.pnl_Add_New_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Item
            // 
            this.pnl_Add_New_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Delete_Lbl);
            this.pnl_Add_New_Item.Controls.Add(this.dgv_Delete_Item);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.tb_Item_Name);
            this.pnl_Add_New_Item.Controls.Add(this.lbl_Delete_Item);
            this.pnl_Add_New_Item.Location = new System.Drawing.Point(24, 22);
            this.pnl_Add_New_Item.Name = "pnl_Add_New_Item";
            this.pnl_Add_New_Item.Size = new System.Drawing.Size(959, 691);
            this.pnl_Add_New_Item.TabIndex = 10;
            // 
            // lbl_Delete_Lbl
            // 
            this.lbl_Delete_Lbl.AutoSize = true;
            this.lbl_Delete_Lbl.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Lbl.Location = new System.Drawing.Point(548, 650);
            this.lbl_Delete_Lbl.Name = "lbl_Delete_Lbl";
            this.lbl_Delete_Lbl.Size = new System.Drawing.Size(74, 33);
            this.lbl_Delete_Lbl.TabIndex = 14;
            this.lbl_Delete_Lbl.Text = "Delete";
            this.lbl_Delete_Lbl.Click += new System.EventHandler(this.lbl_Delete_Lbl_Click);
            // 
            // dgv_Delete_Item
            // 
            this.dgv_Delete_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Delete_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Delete_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete_Item.Location = new System.Drawing.Point(16, 167);
            this.dgv_Delete_Item.Name = "dgv_Delete_Item";
            this.dgv_Delete_Item.RowHeadersWidth = 51;
            this.dgv_Delete_Item.RowTemplate.Height = 24;
            this.dgv_Delete_Item.Size = new System.Drawing.Size(925, 475);
            this.dgv_Delete_Item.TabIndex = 13;
            this.dgv_Delete_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Delete_Item_CellClick);
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Name.Location = new System.Drawing.Point(604, 58);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(153, 43);
            this.lbl_Item_Name.TabIndex = 12;
            this.lbl_Item_Name.Text = "Item Name";
            // 
            // tb_Item_Name
            // 
            this.tb_Item_Name.Font = new System.Drawing.Font("Segoe Print", 13.8F);
            this.tb_Item_Name.Location = new System.Drawing.Point(612, 104);
            this.tb_Item_Name.Name = "tb_Item_Name";
            this.tb_Item_Name.Size = new System.Drawing.Size(311, 48);
            this.tb_Item_Name.TabIndex = 11;
            this.tb_Item_Name.TextChanged += new System.EventHandler(this.tb_Item_Name_TextChanged);
            // 
            // lbl_Delete_Item
            // 
            this.lbl_Delete_Item.AutoSize = true;
            this.lbl_Delete_Item.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.lbl_Delete_Item.Location = new System.Drawing.Point(7, 10);
            this.lbl_Delete_Item.Name = "lbl_Delete_Item";
            this.lbl_Delete_Item.Size = new System.Drawing.Size(214, 58);
            this.lbl_Delete_Item.TabIndex = 0;
            this.lbl_Delete_Item.Text = "Delete Item";
            // 
            // Remove_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Add_New_Item);
            this.Name = "Remove_Item";
            this.Size = new System.Drawing.Size(1006, 735);
            this.Load += new System.EventHandler(this.Remove_Item_Load);
            this.Enter += new System.EventHandler(this.Remove_Item_Enter);
            this.pnl_Add_New_Item.ResumeLayout(false);
            this.pnl_Add_New_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Item;
        private System.Windows.Forms.DataGridView dgv_Delete_Item;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.TextBox tb_Item_Name;
        private System.Windows.Forms.Label lbl_Delete_Item;
        private System.Windows.Forms.Label lbl_Delete_Lbl;
    }
}
