
namespace Cafe_Management_System
{
    partial class frm_DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DashBoard));
            this.pnl_Left_Manu = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.llbl_Logout = new System.Windows.Forms.LinkLabel();
            this.btn_Remove_Item = new System.Windows.Forms.Button();
            this.btn_Update_Item = new System.Windows.Forms.Button();
            this.btn_Add_Item = new System.Windows.Forms.Button();
            this.btn_Place_Order = new System.Windows.Forms.Button();
            this.pnl_Right_Manu = new System.Windows.Forms.Panel();
            this.uC_Banner1 = new Cafe_Management_System.UC_Banner();
            this.pnl_Left_Manu.SuspendLayout();
            this.pnl_Right_Manu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Left_Manu
            // 
            this.pnl_Left_Manu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.pnl_Left_Manu.Controls.Add(this.btn_Close);
            this.pnl_Left_Manu.Controls.Add(this.llbl_Logout);
            this.pnl_Left_Manu.Controls.Add(this.btn_Remove_Item);
            this.pnl_Left_Manu.Controls.Add(this.btn_Update_Item);
            this.pnl_Left_Manu.Controls.Add(this.btn_Add_Item);
            this.pnl_Left_Manu.Controls.Add(this.btn_Place_Order);
            this.pnl_Left_Manu.Location = new System.Drawing.Point(12, 18);
            this.pnl_Left_Manu.Name = "pnl_Left_Manu";
            this.pnl_Left_Manu.Size = new System.Drawing.Size(320, 735);
            this.pnl_Left_Manu.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(0, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 47);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // llbl_Logout
            // 
            this.llbl_Logout.AutoSize = true;
            this.llbl_Logout.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Logout.LinkColor = System.Drawing.Color.White;
            this.llbl_Logout.Location = new System.Drawing.Point(82, 659);
            this.llbl_Logout.Name = "llbl_Logout";
            this.llbl_Logout.Size = new System.Drawing.Size(128, 33);
            this.llbl_Logout.TabIndex = 4;
            this.llbl_Logout.TabStop = true;
            this.llbl_Logout.Text = "Log Out";
            this.llbl_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Logout_LinkClicked);
            // 
            // btn_Remove_Item
            // 
            this.btn_Remove_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Remove_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove_Item.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Remove_Item.Location = new System.Drawing.Point(0, 385);
            this.btn_Remove_Item.Name = "btn_Remove_Item";
            this.btn_Remove_Item.Size = new System.Drawing.Size(319, 47);
            this.btn_Remove_Item.TabIndex = 3;
            this.btn_Remove_Item.Text = "Remove Item";
            this.btn_Remove_Item.UseVisualStyleBackColor = false;
            // 
            // btn_Update_Item
            // 
            this.btn_Update_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Update_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Item.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Item.Location = new System.Drawing.Point(0, 297);
            this.btn_Update_Item.Name = "btn_Update_Item";
            this.btn_Update_Item.Size = new System.Drawing.Size(319, 47);
            this.btn_Update_Item.TabIndex = 2;
            this.btn_Update_Item.Text = "Update Item";
            this.btn_Update_Item.UseVisualStyleBackColor = false;
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Add_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Item.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Item.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Item.Location = new System.Drawing.Point(0, 214);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(319, 47);
            this.btn_Add_Item.TabIndex = 1;
            this.btn_Add_Item.Text = "Add Item";
            this.btn_Add_Item.UseVisualStyleBackColor = false;
            // 
            // btn_Place_Order
            // 
            this.btn_Place_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Place_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Place_Order.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Place_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Place_Order.Location = new System.Drawing.Point(0, 123);
            this.btn_Place_Order.Name = "btn_Place_Order";
            this.btn_Place_Order.Size = new System.Drawing.Size(319, 47);
            this.btn_Place_Order.TabIndex = 0;
            this.btn_Place_Order.Text = "Place Order";
            this.btn_Place_Order.UseVisualStyleBackColor = false;
            this.btn_Place_Order.Click += new System.EventHandler(this.btn_Place_Order_Click);
            // 
            // pnl_Right_Manu
            // 
            this.pnl_Right_Manu.BackColor = System.Drawing.Color.White;
            this.pnl_Right_Manu.Controls.Add(this.uC_Banner1);
            this.pnl_Right_Manu.Location = new System.Drawing.Point(332, 18);
            this.pnl_Right_Manu.Name = "pnl_Right_Manu";
            this.pnl_Right_Manu.Size = new System.Drawing.Size(1006, 735);
            this.pnl_Right_Manu.TabIndex = 1;
            // 
            // uC_Banner1
            // 
            this.uC_Banner1.BackColor = System.Drawing.Color.White;
            this.uC_Banner1.ForeColor = System.Drawing.Color.Coral;
            this.uC_Banner1.Location = new System.Drawing.Point(0, -6);
            this.uC_Banner1.Name = "uC_Banner1";
            this.uC_Banner1.Size = new System.Drawing.Size(1006, 735);
            this.uC_Banner1.TabIndex = 0;
            // 
            // frm_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1355, 775);
            this.Controls.Add(this.pnl_Right_Manu);
            this.Controls.Add(this.pnl_Left_Manu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.pnl_Left_Manu.ResumeLayout(false);
            this.pnl_Left_Manu.PerformLayout();
            this.pnl_Right_Manu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Left_Manu;
        private System.Windows.Forms.Panel pnl_Right_Manu;
        private System.Windows.Forms.Button btn_Place_Order;
        private System.Windows.Forms.Button btn_Remove_Item;
        private System.Windows.Forms.Button btn_Update_Item;
        private System.Windows.Forms.Button btn_Add_Item;
        private System.Windows.Forms.LinkLabel llbl_Logout;
        private System.Windows.Forms.Button btn_Close;
        private UC_Banner uC_Banner1;
    }
}