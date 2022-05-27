namespace Test_Series_Management_System
{
    partial class frm_User_Management
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
            this.btn_Delete_Student = new System.Windows.Forms.Button();
            this.btn_Change_Password = new System.Windows.Forms.Button();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Delete_Student
            // 
            this.btn_Delete_Student.Location = new System.Drawing.Point(255, 328);
            this.btn_Delete_Student.Name = "btn_Delete_Student";
            this.btn_Delete_Student.Size = new System.Drawing.Size(361, 51);
            this.btn_Delete_Student.TabIndex = 5;
            this.btn_Delete_Student.Text = "Delete Student";
            this.btn_Delete_Student.UseVisualStyleBackColor = true;
            this.btn_Delete_Student.Click += new System.EventHandler(this.btn_Delete_Student_Click);
            // 
            // btn_Change_Password
            // 
            this.btn_Change_Password.Location = new System.Drawing.Point(255, 237);
            this.btn_Change_Password.Name = "btn_Change_Password";
            this.btn_Change_Password.Size = new System.Drawing.Size(361, 51);
            this.btn_Change_Password.TabIndex = 4;
            this.btn_Change_Password.Text = "Change Password";
            this.btn_Change_Password.UseVisualStyleBackColor = true;
            this.btn_Change_Password.Click += new System.EventHandler(this.btn_Change_Password_Click);
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.Location = new System.Drawing.Point(255, 146);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(361, 51);
            this.btn_Add_Student.TabIndex = 3;
            this.btn_Add_Student.Text = "Add Student Id";
            this.btn_Add_Student.UseVisualStyleBackColor = true;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(1, -1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(130, 51);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(820, -1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(130, 51);
            this.btn_LogOut.TabIndex = 7;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 580);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete_Student);
            this.Controls.Add(this.btn_Change_Password);
            this.Controls.Add(this.btn_Add_Student);
            this.Name = "frm_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_User_Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete_Student;
        private System.Windows.Forms.Button btn_Change_Password;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_LogOut;
    }
}