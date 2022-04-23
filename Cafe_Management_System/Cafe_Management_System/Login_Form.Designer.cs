
namespace Cafe_Management_System
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.llbl_Continue_As_Guest = new System.Windows.Forms.LinkLabel();
            this.pnl_Border = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.lbl_Username.Location = new System.Drawing.Point(63, 270);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(101, 26);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.lbl_Password.Location = new System.Drawing.Point(62, 354);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 26);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("MV Boli", 12F);
            this.tb_Username.Location = new System.Drawing.Point(67, 299);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(247, 40);
            this.tb_Username.TabIndex = 3;
            this.tb_Username.Text = "Enter Username";
            this.tb_Username.Click += new System.EventHandler(this.tb_Username_Click);
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("MV Boli", 12F);
            this.tb_Password.Location = new System.Drawing.Point(67, 386);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(247, 40);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.Text = "Enter Password";
            this.tb_Password.Click += new System.EventHandler(this.tb_Password_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(241)))));
            this.btn_Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_In.Font = new System.Drawing.Font("Segoe Print", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.Location = new System.Drawing.Point(86, 469);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(199, 50);
            this.btn_Sign_In.TabIndex = 6;
            this.btn_Sign_In.Text = "Sign In";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // llbl_Continue_As_Guest
            // 
            this.llbl_Continue_As_Guest.AutoSize = true;
            this.llbl_Continue_As_Guest.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Continue_As_Guest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(176)))), ((int)(((byte)(71)))));
            this.llbl_Continue_As_Guest.Location = new System.Drawing.Point(109, 545);
            this.llbl_Continue_As_Guest.Name = "llbl_Continue_As_Guest";
            this.llbl_Continue_As_Guest.Size = new System.Drawing.Size(156, 24);
            this.llbl_Continue_As_Guest.TabIndex = 7;
            this.llbl_Continue_As_Guest.TabStop = true;
            this.llbl_Continue_As_Guest.Text = "Continue As Guest";
            this.llbl_Continue_As_Guest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Continue_As_Guest_LinkClicked);
            // 
            // pnl_Border
            // 
            this.pnl_Border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Border.Location = new System.Drawing.Point(12, 12);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Size = new System.Drawing.Size(354, 572);
            this.pnl_Border.TabIndex = 8;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(378, 596);
            this.Controls.Add(this.llbl_Continue_As_Guest);
            this.Controls.Add(this.btn_Sign_In);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pnl_Border);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Sign_In;
        private System.Windows.Forms.LinkLabel llbl_Continue_As_Guest;
        private System.Windows.Forms.Panel pnl_Border;
    }
}

