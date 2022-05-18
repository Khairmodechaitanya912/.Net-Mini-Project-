namespace OLA_CAB_Management_Syatem
{
    partial class frm_Add_Area
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
            this.gb_Area = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Kmper_Price = new System.Windows.Forms.Label();
            this.tb_Kmper_Price = new System.Windows.Forms.TextBox();
            this.lbl_kilometer = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Area_Id = new System.Windows.Forms.Label();
            this.tb_kilometer = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Area_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Area.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Area
            // 
            this.gb_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.gb_Area.Controls.Add(this.btn_Refresh);
            this.gb_Area.Controls.Add(this.btn_Save);
            this.gb_Area.Controls.Add(this.lbl_Kmper_Price);
            this.gb_Area.Controls.Add(this.tb_Kmper_Price);
            this.gb_Area.Controls.Add(this.lbl_kilometer);
            this.gb_Area.Controls.Add(this.lbl_Name);
            this.gb_Area.Controls.Add(this.lbl_Area_Id);
            this.gb_Area.Controls.Add(this.tb_kilometer);
            this.gb_Area.Controls.Add(this.tb_Name);
            this.gb_Area.Controls.Add(this.tb_Area_Id);
            this.gb_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Area.Location = new System.Drawing.Point(526, 175);
            this.gb_Area.Name = "gb_Area";
            this.gb_Area.Size = new System.Drawing.Size(959, 691);
            this.gb_Area.TabIndex = 0;
            this.gb_Area.TabStop = false;
            this.gb_Area.Text = "Area Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(543, 529);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(208, 59);
            this.btn_Refresh.TabIndex = 74;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(199, 529);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 59);
            this.btn_Save.TabIndex = 73;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Kmper_Price
            // 
            this.lbl_Kmper_Price.AutoSize = true;
            this.lbl_Kmper_Price.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kmper_Price.Location = new System.Drawing.Point(190, 371);
            this.lbl_Kmper_Price.Name = "lbl_Kmper_Price";
            this.lbl_Kmper_Price.Size = new System.Drawing.Size(142, 29);
            this.lbl_Kmper_Price.TabIndex = 59;
            this.lbl_Kmper_Price.Text = "Km/Price";
            // 
            // tb_Kmper_Price
            // 
            this.tb_Kmper_Price.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Kmper_Price.Location = new System.Drawing.Point(509, 375);
            this.tb_Kmper_Price.Name = "tb_Kmper_Price";
            this.tb_Kmper_Price.Size = new System.Drawing.Size(251, 35);
            this.tb_Kmper_Price.TabIndex = 58;
            this.tb_Kmper_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_kilometer
            // 
            this.lbl_kilometer.AutoSize = true;
            this.lbl_kilometer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilometer.Location = new System.Drawing.Point(190, 290);
            this.lbl_kilometer.Name = "lbl_kilometer";
            this.lbl_kilometer.Size = new System.Drawing.Size(144, 29);
            this.lbl_kilometer.TabIndex = 57;
            this.lbl_kilometer.Text = "Kilometer";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(190, 214);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(90, 29);
            this.lbl_Name.TabIndex = 56;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Area_Id
            // 
            this.lbl_Area_Id.AutoSize = true;
            this.lbl_Area_Id.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Area_Id.Location = new System.Drawing.Point(190, 133);
            this.lbl_Area_Id.Name = "lbl_Area_Id";
            this.lbl_Area_Id.Size = new System.Drawing.Size(117, 29);
            this.lbl_Area_Id.TabIndex = 55;
            this.lbl_Area_Id.Text = "Area ID";
            // 
            // tb_kilometer
            // 
            this.tb_kilometer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kilometer.Location = new System.Drawing.Point(509, 294);
            this.tb_kilometer.Name = "tb_kilometer";
            this.tb_kilometer.Size = new System.Drawing.Size(251, 35);
            this.tb_kilometer.TabIndex = 52;
            this.tb_kilometer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(509, 216);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(251, 35);
            this.tb_Name.TabIndex = 50;
            // 
            // tb_Area_Id
            // 
            this.tb_Area_Id.Enabled = false;
            this.tb_Area_Id.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Area_Id.Location = new System.Drawing.Point(509, 133);
            this.tb_Area_Id.Name = "tb_Area_Id";
            this.tb_Area_Id.Size = new System.Drawing.Size(251, 35);
            this.tb_Area_Id.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2320, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(685, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 112);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Area";
            // 
            // frm_Add_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Area);
            this.Name = "frm_Add_Area";
            this.Text = "Add Area";
            this.Load += new System.EventHandler(this.frm_Add_Area_Load);
            this.gb_Area.ResumeLayout(false);
            this.gb_Area.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Area;
        private System.Windows.Forms.Label lbl_Kmper_Price;
        private System.Windows.Forms.TextBox tb_Kmper_Price;
        private System.Windows.Forms.Label lbl_kilometer;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Area_Id;
        private System.Windows.Forms.TextBox tb_kilometer;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Area_Id;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

    }
}