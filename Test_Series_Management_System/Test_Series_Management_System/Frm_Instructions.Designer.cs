namespace Test_Series_Management_System
{
    partial class Frm_Instructions
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
            this.btn_Go_To_Exam = new System.Windows.Forms.Button();
            this.cb_Yes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Go_To_Exam
            // 
            this.btn_Go_To_Exam.Enabled = false;
            this.btn_Go_To_Exam.Location = new System.Drawing.Point(802, 613);
            this.btn_Go_To_Exam.Name = "btn_Go_To_Exam";
            this.btn_Go_To_Exam.Size = new System.Drawing.Size(145, 45);
            this.btn_Go_To_Exam.TabIndex = 33;
            this.btn_Go_To_Exam.Text = "Start Exam";
            this.btn_Go_To_Exam.UseVisualStyleBackColor = true;
            this.btn_Go_To_Exam.Click += new System.EventHandler(this.btn_Go_To_Exam_Click);
            // 
            // cb_Yes
            // 
            this.cb_Yes.AutoSize = true;
            this.cb_Yes.Location = new System.Drawing.Point(377, 545);
            this.cb_Yes.Name = "cb_Yes";
            this.cb_Yes.Size = new System.Drawing.Size(58, 21);
            this.cb_Yes.TabIndex = 34;
            this.cb_Yes.Text = "Yes ";
            this.cb_Yes.UseVisualStyleBackColor = true;
            this.cb_Yes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 682);
            this.Controls.Add(this.cb_Yes);
            this.Controls.Add(this.btn_Go_To_Exam);
            this.Name = "Frm_Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Go_To_Exam;
        private System.Windows.Forms.CheckBox cb_Yes;
    }
}