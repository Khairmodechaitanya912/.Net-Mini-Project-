namespace Shoppee_Mini_Project
{
    partial class frm_Customer_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Menu));
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Search_Single_Customer = new System.Windows.Forms.Button();
            this.btn_Add_New_Customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(624, -1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(110, 115);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(0, -1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(173, 107);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Search_Single_Customer
            // 
            this.btn_Search_Single_Customer.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Search_Single_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Single_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Single_Customer.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Single_Customer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Search_Single_Customer.Location = new System.Drawing.Point(214, 322);
            this.btn_Search_Single_Customer.Name = "btn_Search_Single_Customer";
            this.btn_Search_Single_Customer.Size = new System.Drawing.Size(358, 80);
            this.btn_Search_Single_Customer.TabIndex = 2;
            this.btn_Search_Single_Customer.Text = "Search Customer";
            this.btn_Search_Single_Customer.UseVisualStyleBackColor = false;
            this.btn_Search_Single_Customer.Click += new System.EventHandler(this.btn_Search_Single_Customer_Click);
            // 
            // btn_Add_New_Customer
            // 
            this.btn_Add_New_Customer.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Add_New_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_New_Customer.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Customer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_New_Customer.Location = new System.Drawing.Point(214, 157);
            this.btn_Add_New_Customer.Name = "btn_Add_New_Customer";
            this.btn_Add_New_Customer.Size = new System.Drawing.Size(358, 80);
            this.btn_Add_New_Customer.TabIndex = 1;
            this.btn_Add_New_Customer.Text = "Add New Customer";
            this.btn_Add_New_Customer.UseVisualStyleBackColor = false;
            this.btn_Add_New_Customer.Click += new System.EventHandler(this.btn_Add_New_Customer_Click);
            // 
            // frm_Customer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Search_Single_Customer);
            this.Controls.Add(this.btn_Add_New_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search_Single_Customer;
        private System.Windows.Forms.Button btn_Add_New_Customer;
    }
}