namespace Test_Series_Management_System
{
    partial class frm_Update_Student_Password
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_New_Password = new System.Windows.Forms.Label();
            this.lbl_Current_Password = new System.Windows.Forms.Label();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.tb_Current_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(259, 520);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(185, 59);
            this.btn_Update.TabIndex = 84;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(514, 213);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(315, 36);
            this.cmb_Username.TabIndex = 81;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(164, 220);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(148, 29);
            this.lbl_Username.TabIndex = 85;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_New_Password
            // 
            this.lbl_New_Password.AutoSize = true;
            this.lbl_New_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Password.Location = new System.Drawing.Point(164, 408);
            this.lbl_New_Password.Name = "lbl_New_Password";
            this.lbl_New_Password.Size = new System.Drawing.Size(212, 29);
            this.lbl_New_Password.TabIndex = 87;
            this.lbl_New_Password.Text = "New Password";
            // 
            // lbl_Current_Password
            // 
            this.lbl_Current_Password.AutoSize = true;
            this.lbl_Current_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Password.Location = new System.Drawing.Point(164, 315);
            this.lbl_Current_Password.Name = "lbl_Current_Password";
            this.lbl_Current_Password.Size = new System.Drawing.Size(254, 29);
            this.lbl_Current_Password.TabIndex = 86;
            this.lbl_Current_Password.Text = "Current Password";
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.Location = new System.Drawing.Point(515, 402);
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.Size = new System.Drawing.Size(315, 35);
            this.tb_New_Password.TabIndex = 83;
            // 
            // tb_Current_Password
            // 
            this.tb_Current_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Password.Location = new System.Drawing.Point(514, 309);
            this.tb_Current_Password.Name = "tb_Current_Password";
            this.tb_Current_Password.Size = new System.Drawing.Size(315, 35);
            this.tb_Current_Password.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(132, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(759, 112);
            this.label2.TabIndex = 88;
            this.label2.Text = "Change Password";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Yellow;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(535, 520);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(157, 59);
            this.btn_Back.TabIndex = 91;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frm_Update_Student_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 715);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_New_Password);
            this.Controls.Add(this.lbl_Current_Password);
            this.Controls.Add(this.tb_New_Password);
            this.Controls.Add(this.tb_Current_Password);
            this.Name = "frm_Update_Student_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Student Password";
            this.Load += new System.EventHandler(this.frm_Update_Student_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmb_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_New_Password;
        private System.Windows.Forms.Label lbl_Current_Password;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.TextBox tb_Current_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
    }
}