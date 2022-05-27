namespace Test_Series_Management_System
{
    partial class frm_Course
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
            this.btn_Courses = new System.Windows.Forms.Button();
            this.btn_Set_Exam = new System.Windows.Forms.Button();
            this.btn_Add_Que = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_User_Management = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Courses
            // 
            this.btn_Courses.Location = new System.Drawing.Point(271, 128);
            this.btn_Courses.Name = "btn_Courses";
            this.btn_Courses.Size = new System.Drawing.Size(361, 51);
            this.btn_Courses.TabIndex = 0;
            this.btn_Courses.Text = "Courses";
            this.btn_Courses.UseVisualStyleBackColor = true;
            this.btn_Courses.Click += new System.EventHandler(this.btn_Courses_Click);
            // 
            // btn_Set_Exam
            // 
            this.btn_Set_Exam.Location = new System.Drawing.Point(271, 219);
            this.btn_Set_Exam.Name = "btn_Set_Exam";
            this.btn_Set_Exam.Size = new System.Drawing.Size(361, 51);
            this.btn_Set_Exam.TabIndex = 1;
            this.btn_Set_Exam.Text = "Set Exam";
            this.btn_Set_Exam.UseVisualStyleBackColor = true;
            this.btn_Set_Exam.Click += new System.EventHandler(this.btn_Set_Exam_Click);
            // 
            // btn_Add_Que
            // 
            this.btn_Add_Que.Location = new System.Drawing.Point(271, 310);
            this.btn_Add_Que.Name = "btn_Add_Que";
            this.btn_Add_Que.Size = new System.Drawing.Size(361, 51);
            this.btn_Add_Que.TabIndex = 2;
            this.btn_Add_Que.Text = "Add Question";
            this.btn_Add_Que.UseVisualStyleBackColor = true;
            this.btn_Add_Que.Click += new System.EventHandler(this.btn_Add_Que_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(-1, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(130, 51);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(821, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(130, 51);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_User_Management
            // 
            this.btn_User_Management.Location = new System.Drawing.Point(271, 400);
            this.btn_User_Management.Name = "btn_User_Management";
            this.btn_User_Management.Size = new System.Drawing.Size(361, 51);
            this.btn_User_Management.TabIndex = 5;
            this.btn_User_Management.Text = "User Management";
            this.btn_User_Management.UseVisualStyleBackColor = true;
            this.btn_User_Management.Click += new System.EventHandler(this.btn_User_Management_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(271, 484);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(361, 51);
            this.btn_Result.TabIndex = 6;
            this.btn_Result.Text = "Result";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 580);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_User_Management);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add_Que);
            this.Controls.Add(this.btn_Set_Exam);
            this.Controls.Add(this.btn_Courses);
            this.Name = "frm_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Course";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Courses;
        private System.Windows.Forms.Button btn_Set_Exam;
        private System.Windows.Forms.Button btn_Add_Que;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_User_Management;
        private System.Windows.Forms.Button btn_Result;
    }
}