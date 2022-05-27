namespace Test_Series_Management_System
{
    partial class frm_Result_Form
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
            this.lbl_Std_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Atp_Que = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Res = new System.Windows.Forms.Label();
            this.tb_Std_Id = new System.Windows.Forms.TextBox();
            this.tb_Std_Name = new System.Windows.Forms.TextBox();
            this.tb_Atpt_Que = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Std_Id
            // 
            this.lbl_Std_Id.AutoSize = true;
            this.lbl_Std_Id.Location = new System.Drawing.Point(102, 150);
            this.lbl_Std_Id.Name = "lbl_Std_Id";
            this.lbl_Std_Id.Size = new System.Drawing.Size(72, 17);
            this.lbl_Std_Id.TabIndex = 0;
            this.lbl_Std_Id.Text = "Student Id";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(96, 256);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Atp_Que
            // 
            this.lbl_Atp_Que.AutoSize = true;
            this.lbl_Atp_Que.Location = new System.Drawing.Point(99, 351);
            this.lbl_Atp_Que.Name = "lbl_Atp_Que";
            this.lbl_Atp_Que.Size = new System.Drawing.Size(87, 17);
            this.lbl_Atp_Que.TabIndex = 2;
            this.lbl_Atp_Que.Text = "Attempt Que";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(99, 442);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Res
            // 
            this.lbl_Res.AutoSize = true;
            this.lbl_Res.Location = new System.Drawing.Point(99, 511);
            this.lbl_Res.Name = "lbl_Res";
            this.lbl_Res.Size = new System.Drawing.Size(48, 17);
            this.lbl_Res.TabIndex = 4;
            this.lbl_Res.Text = "Result";
            // 
            // tb_Std_Id
            // 
            this.tb_Std_Id.Location = new System.Drawing.Point(331, 150);
            this.tb_Std_Id.Name = "tb_Std_Id";
            this.tb_Std_Id.Size = new System.Drawing.Size(246, 22);
            this.tb_Std_Id.TabIndex = 5;
            // 
            // tb_Std_Name
            // 
            this.tb_Std_Name.Enabled = false;
            this.tb_Std_Name.Location = new System.Drawing.Point(331, 247);
            this.tb_Std_Name.Name = "tb_Std_Name";
            this.tb_Std_Name.Size = new System.Drawing.Size(246, 22);
            this.tb_Std_Name.TabIndex = 5;
            // 
            // tb_Atpt_Que
            // 
            this.tb_Atpt_Que.Enabled = false;
            this.tb_Atpt_Que.Location = new System.Drawing.Point(331, 342);
            this.tb_Atpt_Que.Name = "tb_Atpt_Que";
            this.tb_Atpt_Que.Size = new System.Drawing.Size(246, 22);
            this.tb_Atpt_Que.TabIndex = 5;
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Location = new System.Drawing.Point(331, 433);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(246, 22);
            this.tb_Total.TabIndex = 5;
            // 
            // tb_Result
            // 
            this.tb_Result.Enabled = false;
            this.tb_Result.Location = new System.Drawing.Point(331, 502);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(246, 22);
            this.tb_Result.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(636, 144);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 28);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(241, 647);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 51);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(427, 647);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(130, 51);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(282, 575);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(96, 35);
            this.lbl_Result.TabIndex = 9;
            this.lbl_Result.Text = "Result";
            this.lbl_Result.Visible = false;
            // 
            // frm_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 754);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_Atpt_Que);
            this.Controls.Add(this.tb_Std_Name);
            this.Controls.Add(this.tb_Std_Id);
            this.Controls.Add(this.lbl_Res);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Atp_Que);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Std_Id);
            this.Name = "frm_Result_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Form";
            this.Load += new System.EventHandler(this.frm_Result_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Std_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Atp_Que;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Res;
        private System.Windows.Forms.TextBox tb_Std_Id;
        private System.Windows.Forms.TextBox tb_Std_Name;
        private System.Windows.Forms.TextBox tb_Atpt_Que;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Result;
    }
}