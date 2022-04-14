namespace Shoppee_Mini_Project
{
    partial class frm_Product_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product_Menu));
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.btn_Update_Product = new System.Windows.Forms.Button();
            this.btn_View_Product_List = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Add_New_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_New_Product.Location = new System.Drawing.Point(214, 124);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(358, 80);
            this.btn_Add_New_Product.TabIndex = 1;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = false;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Update_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Product.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Update_Product.Location = new System.Drawing.Point(214, 245);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.Size = new System.Drawing.Size(358, 80);
            this.btn_Update_Product.TabIndex = 2;
            this.btn_Update_Product.Text = "Update Product";
            this.btn_Update_Product.UseVisualStyleBackColor = false;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_View_Product_List
            // 
            this.btn_View_Product_List.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_View_Product_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Product_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_Product_List.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Product_List.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_View_Product_List.Location = new System.Drawing.Point(214, 371);
            this.btn_View_Product_List.Name = "btn_View_Product_List";
            this.btn_View_Product_List.Size = new System.Drawing.Size(358, 80);
            this.btn_View_Product_List.TabIndex = 3;
            this.btn_View_Product_List.Text = "View Product List";
            this.btn_View_Product_List.UseVisualStyleBackColor = false;
            this.btn_View_Product_List.Click += new System.EventHandler(this.btn_View_Product_List_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(0, 1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(173, 107);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(624, 1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(110, 115);
            this.btn_LogOut.TabIndex = 5;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_Product_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_View_Product_List);
            this.Controls.Add(this.btn_Update_Product);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Product_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_New_Product;
        private System.Windows.Forms.Button btn_Update_Product;
        private System.Windows.Forms.Button btn_View_Product_List;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_LogOut;
    }
}