namespace Test_Series_Management_System
{
    partial class frm_Add_Courses
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
            this.components = new System.ComponentModel.Container();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Course_Id = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_Id = new System.Windows.Forms.TextBox();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.test_Series_Mgt_SystemDataSet = new Test_Series_Management_System.Test_Series_Mgt_SystemDataSet();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_DetailsTableAdapter = new Test_Series_Management_System.Test_Series_Mgt_SystemDataSetTableAdapters.Course_DetailsTableAdapter();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_Series_Mgt_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(353, 361);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 35);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Course_Id
            // 
            this.lbl_Course_Id.AutoSize = true;
            this.lbl_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Id.Location = new System.Drawing.Point(193, 191);
            this.lbl_Course_Id.Name = "lbl_Course_Id";
            this.lbl_Course_Id.Size = new System.Drawing.Size(132, 31);
            this.lbl_Course_Id.TabIndex = 1;
            this.lbl_Course_Id.Text = "Course Id";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.Location = new System.Drawing.Point(193, 278);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(181, 31);
            this.lbl_Course_Name.TabIndex = 2;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_Id
            // 
            this.tb_Course_Id.Enabled = false;
            this.tb_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Id.Location = new System.Drawing.Point(437, 191);
            this.tb_Course_Id.Name = "tb_Course_Id";
            this.tb_Course_Id.Size = new System.Drawing.Size(224, 34);
            this.tb_Course_Id.TabIndex = 3;
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(437, 278);
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(224, 34);
            this.tb_Course_Name.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 212);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(-1, 1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(130, 51);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // test_Series_Mgt_SystemDataSet
            // 
            this.test_Series_Mgt_SystemDataSet.DataSetName = "Test_Series_Mgt_SystemDataSet";
            this.test_Series_Mgt_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "Course_Details";
            this.courseDetailsBindingSource.DataSource = this.test_Series_Mgt_SystemDataSet;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Add_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 667);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_Id);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_Id);
            this.Controls.Add(this.btn_Save);
            this.Name = "frm_Add_Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.frm_Add_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_Series_Mgt_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Course_Id;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_Id;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Back;
        private Test_Series_Mgt_SystemDataSet test_Series_Mgt_SystemDataSet;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private Test_Series_Mgt_SystemDataSetTableAdapters.Course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}