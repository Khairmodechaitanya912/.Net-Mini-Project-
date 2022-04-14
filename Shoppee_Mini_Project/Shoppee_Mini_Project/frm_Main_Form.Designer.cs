namespace Shoppee_Mini_Project
{
    partial class frm_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.pb_Product = new System.Windows.Forms.PictureBox();
            this.pb_Customer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 77);
            this.panel1.TabIndex = 28;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(662, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(72, 77);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_Header.Location = new System.Drawing.Point(198, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(321, 58);
            this.lbl_Header.TabIndex = 5;
            this.lbl_Header.Text = "Shree Shopee";
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Customer.Location = new System.Drawing.Point(7, 441);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(358, 58);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Product.Location = new System.Drawing.Point(370, 441);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(358, 58);
            this.btn_Product.TabIndex = 2;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // pb_Product
            // 
            this.pb_Product.Image = ((System.Drawing.Image)(resources.GetObject("pb_Product.Image")));
            this.pb_Product.Location = new System.Drawing.Point(370, 96);
            this.pb_Product.Name = "pb_Product";
            this.pb_Product.Size = new System.Drawing.Size(358, 326);
            this.pb_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Product.TabIndex = 30;
            this.pb_Product.TabStop = false;
            // 
            // pb_Customer
            // 
            this.pb_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pb_Customer.Image")));
            this.pb_Customer.Location = new System.Drawing.Point(7, 96);
            this.pb_Customer.Name = "pb_Customer";
            this.pb_Customer.Size = new System.Drawing.Size(358, 326);
            this.pb_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Customer.TabIndex = 29;
            this.pb_Customer.TabStop = false;
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.pb_Product);
            this.Controls.Add(this.pb_Customer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.PictureBox pb_Customer;
        private System.Windows.Forms.PictureBox pb_Product;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_LogOut;
    }
}