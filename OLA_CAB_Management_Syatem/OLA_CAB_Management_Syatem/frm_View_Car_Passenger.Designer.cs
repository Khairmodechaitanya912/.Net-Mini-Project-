﻿namespace OLA_CAB_Management_Syatem
{
    partial class frm_View_Car_Passenger
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
            this.dgv_View_Car_Passenger = new System.Windows.Forms.DataGridView();
            this.dB_OLA_CAB_Mgt_SystemDataSet4 = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet4();
            this.passengerCarDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passenger_Car_DetailsTableAdapter = new OLA_CAB_Management_Syatem.DB_OLA_CAB_Mgt_SystemDataSet4TableAdapters.Passenger_Car_DetailsTableAdapter();
            this.passengerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Car_Passenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCarDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-13, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2303, 100);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(623, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 112);
            this.label1.TabIndex = 12;
            this.label1.Text = "View Car Passenger";
            // 
            // dgv_View_Car_Passenger
            // 
            this.dgv_View_Car_Passenger.AllowUserToAddRows = false;
            this.dgv_View_Car_Passenger.AllowUserToDeleteRows = false;
            this.dgv_View_Car_Passenger.AutoGenerateColumns = false;
            this.dgv_View_Car_Passenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Car_Passenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Car_Passenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passengerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.alternateMobileNoDataGridViewTextBoxColumn,
            this.aadharNoDataGridViewTextBoxColumn,
            this.licenceNoDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn});
            this.dgv_View_Car_Passenger.DataSource = this.passengerCarDetailsBindingSource;
            this.dgv_View_Car_Passenger.Location = new System.Drawing.Point(99, 187);
            this.dgv_View_Car_Passenger.Name = "dgv_View_Car_Passenger";
            this.dgv_View_Car_Passenger.ReadOnly = true;
            this.dgv_View_Car_Passenger.RowTemplate.Height = 24;
            this.dgv_View_Car_Passenger.Size = new System.Drawing.Size(1739, 701);
            this.dgv_View_Car_Passenger.TabIndex = 18;
            // 
            // dB_OLA_CAB_Mgt_SystemDataSet4
            // 
            this.dB_OLA_CAB_Mgt_SystemDataSet4.DataSetName = "DB_OLA_CAB_Mgt_SystemDataSet4";
            this.dB_OLA_CAB_Mgt_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerCarDetailsBindingSource
            // 
            this.passengerCarDetailsBindingSource.DataMember = "Passenger_Car_Details";
            this.passengerCarDetailsBindingSource.DataSource = this.dB_OLA_CAB_Mgt_SystemDataSet4;
            // 
            // passenger_Car_DetailsTableAdapter
            // 
            this.passenger_Car_DetailsTableAdapter.ClearBeforeFill = true;
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
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frm_View_Car_Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Car_Passenger);
            this.Controls.Add(this.panel1);
            this.Name = "frm_View_Car_Passenger";
            this.Text = "View Car Passenger";
            this.Load += new System.EventHandler(this.frm_View_Car_Passenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Car_Passenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_OLA_CAB_Mgt_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCarDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_View_Car_Passenger;
        private DB_OLA_CAB_Mgt_SystemDataSet4 dB_OLA_CAB_Mgt_SystemDataSet4;
        private System.Windows.Forms.BindingSource passengerCarDetailsBindingSource;
        private DB_OLA_CAB_Mgt_SystemDataSet4TableAdapters.Passenger_Car_DetailsTableAdapter passenger_Car_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
    }
}