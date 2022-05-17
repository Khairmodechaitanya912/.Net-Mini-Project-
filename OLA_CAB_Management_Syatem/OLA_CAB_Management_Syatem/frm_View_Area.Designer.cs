namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Area
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_View_All_Area = new System.Windows.Forms.DataGridView();
            this.areaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_OLA_CAB_Mgt_SystemDataSet2 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet2();
            this.area_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet2TableAdapters.Area_DetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2303, 100);
            this.panel1.TabIndex = 53;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(623, -10);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(588, 112);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "View All Area";
            // 
            // dgv_View_All_Area
            // 
            this.dgv_View_All_Area.AllowUserToAddRows = false;
            this.dgv_View_All_Area.AllowUserToDeleteRows = false;
            this.dgv_View_All_Area.AutoGenerateColumns = false;
            this.dgv_View_All_Area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaIdDataGridViewTextBoxColumn,
            this.areaNameDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.kmPriceDataGridViewTextBoxColumn});
            this.dgv_View_All_Area.DataSource = this.areaDetailsBindingSource;
            this.dgv_View_All_Area.Location = new System.Drawing.Point(68, 210);
            this.dgv_View_All_Area.Name = "dgv_View_All_Area";
            this.dgv_View_All_Area.ReadOnly = true;
            this.dgv_View_All_Area.RowTemplate.Height = 24;
            this.dgv_View_All_Area.Size = new System.Drawing.Size(1793, 692);
            this.dgv_View_All_Area.TabIndex = 54;
            // 
            // areaIdDataGridViewTextBoxColumn
            // 
            this.areaIdDataGridViewTextBoxColumn.DataPropertyName = "Area_Id";
            this.areaIdDataGridViewTextBoxColumn.HeaderText = "Area_Id";
            this.areaIdDataGridViewTextBoxColumn.Name = "areaIdDataGridViewTextBoxColumn";
            this.areaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaNameDataGridViewTextBoxColumn
            // 
            this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "Area_Name";
            this.areaNameDataGridViewTextBoxColumn.HeaderText = "Area_Name";
            this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
            this.areaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmPriceDataGridViewTextBoxColumn
            // 
            this.kmPriceDataGridViewTextBoxColumn.DataPropertyName = "Km_Price";
            this.kmPriceDataGridViewTextBoxColumn.HeaderText = "Km_Price";
            this.kmPriceDataGridViewTextBoxColumn.Name = "kmPriceDataGridViewTextBoxColumn";
            this.kmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDetailsBindingSource
            // 
            this.areaDetailsBindingSource.DataMember = "Area_Details";
            this.areaDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet2;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet2
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet2.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet2";
            this.dB_OLA_CAB_Mgt_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // area_DetailsTableAdapter
            // 
            this.area_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Area);
            this.Controls.Add(this.panel1);
            this.Name = "frm_View_Area";
            this.Text = "frm_View_Area";
            this.Load += new System.EventHandler(this.frm_View_Area_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_All_Area;
        private DB_OLA_CAB_Mgt_SystemDataSet2 dB_OLA_CAB_Mgt_SystemDataSet2;
        private System.Windows.Forms.BindingSource areaDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet2TableAdapters.Area_DetailsTableAdapter area_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmPriceDataGridViewTextBoxColumn;
    }
}