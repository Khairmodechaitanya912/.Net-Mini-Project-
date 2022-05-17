namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Bike_Passenger
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_View_Bike = new System.Windows.Forms.DataGridView();
            this.dB_OLA_CAB_Mgt_SystemDataSet3 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet3();
            this.passengerBikeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passenger_Bike_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet3TableAdapters.Passenger_Bike_DetailsTableAdapter();
            this.passengerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Bike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBikeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2303, 100);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(623, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 112);
            this.label1.TabIndex = 12;
            this.label1.Text = "View Bike Passenger";
            // 
            // dgv_View_Bike
            // 
            this.dgv_View_Bike.AllowUserToAddRows = false;
            this.dgv_View_Bike.AllowUserToDeleteRows = false;
            this.dgv_View_Bike.AutoGenerateColumns = false;
            this.dgv_View_Bike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Bike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Bike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passengerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.alternateMobileNoDataGridViewTextBoxColumn,
            this.driverStatusDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.aadharNoDataGridViewTextBoxColumn,
            this.licenceNoDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn});
            this.dgv_View_Bike.DataSource = this.passengerBikeDetailsBindingSource;
            this.dgv_View_Bike.Location = new System.Drawing.Point(71, 182);
            this.dgv_View_Bike.Name = "dgv_View_Bike";
            this.dgv_View_Bike.ReadOnly = true;
            this.dgv_View_Bike.RowTemplate.Height = 24;
            this.dgv_View_Bike.Size = new System.Drawing.Size(1797, 701);
            this.dgv_View_Bike.TabIndex = 17;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet3
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet3.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet3";
            this.dB_OLA_CAB_Mgt_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBikeDetailsBindingSource
            // 
            this.passengerBikeDetailsBindingSource.DataMember = "Passenger_Bike_Details";
            this.passengerBikeDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet3;
            // 
            // passenger_Bike_DetailsTableAdapter
            // 
            this.passenger_Bike_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // passengerIdDataGridViewTextBoxColumn
            // 
            this.passengerIdDataGridViewTextBoxColumn.DataPropertyName = "Passenger_Id";
            this.passengerIdDataGridViewTextBoxColumn.HeaderText = "Passenger_Id";
            this.passengerIdDataGridViewTextBoxColumn.Name = "passengerIdDataGridViewTextBoxColumn";
            this.passengerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternateMobileNoDataGridViewTextBoxColumn
            // 
            this.alternateMobileNoDataGridViewTextBoxColumn.DataPropertyName = "Alternate_Mobile_No";
            this.alternateMobileNoDataGridViewTextBoxColumn.HeaderText = "Alternate_Mobile_No";
            this.alternateMobileNoDataGridViewTextBoxColumn.Name = "alternateMobileNoDataGridViewTextBoxColumn";
            this.alternateMobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverStatusDataGridViewTextBoxColumn
            // 
            this.driverStatusDataGridViewTextBoxColumn.DataPropertyName = "Driver_Status";
            this.driverStatusDataGridViewTextBoxColumn.HeaderText = "Driver_Status";
            this.driverStatusDataGridViewTextBoxColumn.Name = "driverStatusDataGridViewTextBoxColumn";
            this.driverStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aadharNoDataGridViewTextBoxColumn
            // 
            this.aadharNoDataGridViewTextBoxColumn.DataPropertyName = "Aadhar_No";
            this.aadharNoDataGridViewTextBoxColumn.HeaderText = "Aadhar_No";
            this.aadharNoDataGridViewTextBoxColumn.Name = "aadharNoDataGridViewTextBoxColumn";
            this.aadharNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenceNoDataGridViewTextBoxColumn
            // 
            this.licenceNoDataGridViewTextBoxColumn.DataPropertyName = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.HeaderText = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.Name = "licenceNoDataGridViewTextBoxColumn";
            this.licenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "Email_Id";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "Email_Id";
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "Charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Bike_Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Bike);
            this.Controls.Add(this.panel1);
            this.Name = "frm_View_Bike_Passenger";
            this.Text = "frm_View_Bike_Passenger";
            this.Load += new System.EventHandler(this.frm_View_Bike_Passenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Bike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBikeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_View_Bike;
        private DB_OLA_CAB_Mgt_SystemDataSet3 dB_OLA_CAB_Mgt_SystemDataSet3;
        private System.Windows.Forms.BindingSource passengerBikeDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet3TableAdapters.Passenger_Bike_DetailsTableAdapter passenger_Bike_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
    }
}