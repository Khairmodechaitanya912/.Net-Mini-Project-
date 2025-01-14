﻿namespace OLA_CAB_Management_Syatem
{
    partial class frm_Add_Vehicle
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
            this.gb_Add_Vehicle = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_Vehicle_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Vehicle_Type = new System.Windows.Forms.Label();
            this.lbl_Owner_Name = new System.Windows.Forms.Label();
            this.lbl_Vehicle_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Vehicle_Id = new System.Windows.Forms.Label();
            this.tb_Owner_Name = new System.Windows.Forms.TextBox();
            this.tb_Vehicle_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Vehicle_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Add_Vehicle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_Vehicle
            // 
            this.gb_Add_Vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.gb_Add_Vehicle.Controls.Add(this.dtp_Date);
            this.gb_Add_Vehicle.Controls.Add(this.btn_Refresh);
            this.gb_Add_Vehicle.Controls.Add(this.btn_Save);
            this.gb_Add_Vehicle.Controls.Add(this.cmb_Vehicle_Type);
            this.gb_Add_Vehicle.Controls.Add(this.lbl_Vehicle_Type);
            this.gb_Add_Vehicle.Controls.Add(this.lbl_Owner_Name);
            this.gb_Add_Vehicle.Controls.Add(this.lbl_Vehicle_No);
            this.gb_Add_Vehicle.Controls.Add(this.lbl_Name);
            this.gb_Add_Vehicle.Controls.Add(this.lbl_Vehicle_Id);
            this.gb_Add_Vehicle.Controls.Add(this.tb_Owner_Name);
            this.gb_Add_Vehicle.Controls.Add(this.tb_Vehicle_No);
            this.gb_Add_Vehicle.Controls.Add(this.tb_Name);
            this.gb_Add_Vehicle.Controls.Add(this.tb_Vehicle_Id);
            this.gb_Add_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Vehicle.Location = new System.Drawing.Point(549, 222);
            this.gb_Add_Vehicle.Name = "gb_Add_Vehicle";
            this.gb_Add_Vehicle.Size = new System.Drawing.Size(843, 662);
            this.gb_Add_Vehicle.TabIndex = 0;
            this.gb_Add_Vehicle.TabStop = false;
            this.gb_Add_Vehicle.Text = "Vehicle Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(572, 22);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(265, 34);
            this.dtp_Date.TabIndex = 49;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(489, 513);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(208, 59);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(145, 513);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 59);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_Vehicle_Type
            // 
            this.cmb_Vehicle_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Vehicle_Type.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vehicle_Type.FormattingEnabled = true;
            this.cmb_Vehicle_Type.Items.AddRange(new object[] {
            "Bike",
            "Car"});
            this.cmb_Vehicle_Type.Location = new System.Drawing.Point(454, 392);
            this.cmb_Vehicle_Type.Name = "cmb_Vehicle_Type";
            this.cmb_Vehicle_Type.Size = new System.Drawing.Size(253, 36);
            this.cmb_Vehicle_Type.TabIndex = 5;
            // 
            // lbl_Vehicle_Type
            // 
            this.lbl_Vehicle_Type.AutoSize = true;
            this.lbl_Vehicle_Type.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vehicle_Type.Location = new System.Drawing.Point(140, 391);
            this.lbl_Vehicle_Type.Name = "lbl_Vehicle_Type";
            this.lbl_Vehicle_Type.Size = new System.Drawing.Size(183, 29);
            this.lbl_Vehicle_Type.TabIndex = 45;
            this.lbl_Vehicle_Type.Text = "Vehicle Type";
            // 
            // lbl_Owner_Name
            // 
            this.lbl_Owner_Name.AutoSize = true;
            this.lbl_Owner_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Owner_Name.Location = new System.Drawing.Point(137, 320);
            this.lbl_Owner_Name.Name = "lbl_Owner_Name";
            this.lbl_Owner_Name.Size = new System.Drawing.Size(187, 29);
            this.lbl_Owner_Name.TabIndex = 44;
            this.lbl_Owner_Name.Text = "Owner Name";
            // 
            // lbl_Vehicle_No
            // 
            this.lbl_Vehicle_No.AutoSize = true;
            this.lbl_Vehicle_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vehicle_No.Location = new System.Drawing.Point(137, 242);
            this.lbl_Vehicle_No.Name = "lbl_Vehicle_No";
            this.lbl_Vehicle_No.Size = new System.Drawing.Size(154, 29);
            this.lbl_Vehicle_No.TabIndex = 43;
            this.lbl_Vehicle_No.Text = "Vehicle No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(137, 173);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(90, 29);
            this.lbl_Name.TabIndex = 42;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Vehicle_Id
            // 
            this.lbl_Vehicle_Id.AutoSize = true;
            this.lbl_Vehicle_Id.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vehicle_Id.Location = new System.Drawing.Point(135, 108);
            this.lbl_Vehicle_Id.Name = "lbl_Vehicle_Id";
            this.lbl_Vehicle_Id.Size = new System.Drawing.Size(148, 29);
            this.lbl_Vehicle_Id.TabIndex = 41;
            this.lbl_Vehicle_Id.Text = "Vehicle Id";
            // 
            // tb_Owner_Name
            // 
            this.tb_Owner_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Owner_Name.Location = new System.Drawing.Point(457, 317);
            this.tb_Owner_Name.Name = "tb_Owner_Name";
            this.tb_Owner_Name.Size = new System.Drawing.Size(251, 35);
            this.tb_Owner_Name.TabIndex = 4;
            this.tb_Owner_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Vehicle_No
            // 
            this.tb_Vehicle_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Vehicle_No.Location = new System.Drawing.Point(456, 246);
            this.tb_Vehicle_No.Name = "tb_Vehicle_No";
            this.tb_Vehicle_No.Size = new System.Drawing.Size(251, 35);
            this.tb_Vehicle_No.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(456, 175);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(251, 35);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Vehicle_Id
            // 
            this.tb_Vehicle_Id.Enabled = false;
            this.tb_Vehicle_Id.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Vehicle_Id.Location = new System.Drawing.Point(454, 108);
            this.tb_Vehicle_Id.Name = "tb_Vehicle_Id";
            this.tb_Vehicle_Id.Size = new System.Drawing.Size(251, 35);
            this.tb_Vehicle_Id.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2303, 100);
            this.panel1.TabIndex = 75;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(727, -9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(528, 112);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "Add Vehicle";
            // 
            // frm_Add_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Add_Vehicle);
            this.Name = "frm_Add_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Vehicle";
            this.Load += new System.EventHandler(this.frm_Add_Vehicle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            this.gb_Add_Vehicle.ResumeLayout(false);
            this.gb_Add_Vehicle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_Vehicle;
        private System.Windows.Forms.ComboBox cmb_Vehicle_Type;
        private System.Windows.Forms.Label lbl_Vehicle_Type;
        private System.Windows.Forms.Label lbl_Owner_Name;
        private System.Windows.Forms.Label lbl_Vehicle_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Vehicle_Id;
        private System.Windows.Forms.TextBox tb_Owner_Name;
        private System.Windows.Forms.TextBox tb_Vehicle_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Vehicle_Id;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DateTimePicker dtp_Date;

    }
}