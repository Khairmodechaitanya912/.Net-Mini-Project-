namespace OLA_CAB_Management_Syatem
{
    partial class frm_Delete_User
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Confirm_Passwordd = new System.Windows.Forms.Label();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Delete = new System.Windows.Forms.GroupBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Yellow;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(391, 398);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(157, 59);
            this.btn_Delete.TabIndex = 82;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(190, 162);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(148, 29);
            this.lbl_Username.TabIndex = 67;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Confirm_Passwordd
            // 
            this.lbl_Confirm_Passwordd.AutoSize = true;
            this.lbl_Confirm_Passwordd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Passwordd.Location = new System.Drawing.Point(189, 256);
            this.lbl_Confirm_Passwordd.Name = "lbl_Confirm_Passwordd";
            this.lbl_Confirm_Passwordd.Size = new System.Drawing.Size(257, 29);
            this.lbl_Confirm_Passwordd.TabIndex = 80;
            this.lbl_Confirm_Passwordd.Text = "Confirm Password";
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(540, 250);
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(315, 35);
            this.tb_Confirm_Password.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-13, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2303, 100);
            this.panel1.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(627, -16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 112);
            this.label2.TabIndex = 12;
            this.label2.Text = "Delete User";
            // 
            // gb_Delete
            // 
            this.gb_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.gb_Delete.Controls.Add(this.tb_Username);
            this.gb_Delete.Controls.Add(this.btn_Delete);
            this.gb_Delete.Controls.Add(this.lbl_Username);
            this.gb_Delete.Controls.Add(this.lbl_Confirm_Passwordd);
            this.gb_Delete.Controls.Add(this.tb_Confirm_Password);
            this.gb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Delete.Location = new System.Drawing.Point(443, 298);
            this.gb_Delete.Name = "gb_Delete";
            this.gb_Delete.Size = new System.Drawing.Size(1013, 539);
            this.gb_Delete.TabIndex = 78;
            this.gb_Delete.TabStop = false;
            this.gb_Delete.Text = "Delete User";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(540, 156);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(315, 35);
            this.tb_Username.TabIndex = 79;
            // 
            // frm_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Delete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Delete_User";
            this.Text = "Delete User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Delete.ResumeLayout(false);
            this.gb_Delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Confirm_Passwordd;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Delete;
        private System.Windows.Forms.TextBox tb_Username;

    }
}