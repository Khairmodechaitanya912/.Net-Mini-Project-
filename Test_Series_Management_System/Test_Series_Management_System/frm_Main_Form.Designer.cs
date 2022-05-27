namespace Test_Series_Management_System
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
            this.pb_Teacher = new System.Windows.Forms.PictureBox();
            this.pb_Exam = new System.Windows.Forms.PictureBox();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.pb_Report = new System.Windows.Forms.PictureBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Teacher
            // 
            this.pb_Teacher.Location = new System.Drawing.Point(102, 134);
            this.pb_Teacher.Name = "pb_Teacher";
            this.pb_Teacher.Size = new System.Drawing.Size(257, 259);
            this.pb_Teacher.TabIndex = 0;
            this.pb_Teacher.TabStop = false;
            this.pb_Teacher.Visible = false;
            // 
            // pb_Exam
            // 
            this.pb_Exam.Location = new System.Drawing.Point(476, 134);
            this.pb_Exam.Name = "pb_Exam";
            this.pb_Exam.Size = new System.Drawing.Size(257, 259);
            this.pb_Exam.TabIndex = 1;
            this.pb_Exam.TabStop = false;
            this.pb_Exam.Visible = false;
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.Location = new System.Drawing.Point(158, 463);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(122, 35);
            this.btn_Teacher.TabIndex = 7;
            this.btn_Teacher.Text = "Teacher";
            this.btn_Teacher.UseVisualStyleBackColor = true;
            this.btn_Teacher.Visible = false;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // btn_Exam
            // 
            this.btn_Exam.Location = new System.Drawing.Point(548, 463);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(122, 35);
            this.btn_Exam.TabIndex = 8;
            this.btn_Exam.Text = "Exam";
            this.btn_Exam.UseVisualStyleBackColor = true;
            this.btn_Exam.Visible = false;
            this.btn_Exam.Click += new System.EventHandler(this.btn_Exam_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(919, 463);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(122, 35);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Visible = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // pb_Report
            // 
            this.pb_Report.Location = new System.Drawing.Point(847, 134);
            this.pb_Report.Name = "pb_Report";
            this.pb_Report.Size = new System.Drawing.Size(257, 259);
            this.pb_Report.TabIndex = 9;
            this.pb_Report.TabStop = false;
            this.pb_Report.Visible = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(1076, 2);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(130, 51);
            this.btn_LogOut.TabIndex = 37;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 714);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.pb_Report);
            this.Controls.Add(this.btn_Exam);
            this.Controls.Add(this.btn_Teacher);
            this.Controls.Add(this.pb_Exam);
            this.Controls.Add(this.pb_Teacher);
            this.Name = "frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frm_Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Teacher;
        private System.Windows.Forms.PictureBox pb_Exam;
        private System.Windows.Forms.Button btn_Teacher;
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.PictureBox pb_Report;
        private System.Windows.Forms.Button btn_LogOut;
    }
}