namespace FinalProject
{
    partial class AgreementDetail
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.agreementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rentalAgreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet1 = new FinalProject.RentCarDataSet1();
            this.txtConfNo = new System.Windows.Forms.TextBox();
            this.rentalAgreementTableAdapter = new FinalProject.RentCarDataSet1TableAdapters.RentalAgreementTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartDt = new System.Windows.Forms.DateTimePicker();
            this.txtEndDt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSearchRental = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdMainApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalAgreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AutoGenerateColumns = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agreementIDDataGridViewTextBoxColumn,
            this.insuranceIDDataGridViewTextBoxColumn,
            this.confNoDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.Detail});
            this.dg1.DataSource = this.rentalAgreementBindingSource;
            this.dg1.Location = new System.Drawing.Point(9, 153);
            this.dg1.Margin = new System.Windows.Forms.Padding(2);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(646, 293);
            this.dg1.TabIndex = 0;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // agreementIDDataGridViewTextBoxColumn
            // 
            this.agreementIDDataGridViewTextBoxColumn.DataPropertyName = "agreementID";
            this.agreementIDDataGridViewTextBoxColumn.HeaderText = "agreementID";
            this.agreementIDDataGridViewTextBoxColumn.Name = "agreementIDDataGridViewTextBoxColumn";
            this.agreementIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insuranceIDDataGridViewTextBoxColumn
            // 
            this.insuranceIDDataGridViewTextBoxColumn.DataPropertyName = "insuranceID";
            this.insuranceIDDataGridViewTextBoxColumn.HeaderText = "insuranceID";
            this.insuranceIDDataGridViewTextBoxColumn.Name = "insuranceIDDataGridViewTextBoxColumn";
            this.insuranceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confNoDataGridViewTextBoxColumn
            // 
            this.confNoDataGridViewTextBoxColumn.DataPropertyName = "confNo";
            this.confNoDataGridViewTextBoxColumn.HeaderText = "confNo";
            this.confNoDataGridViewTextBoxColumn.Name = "confNoDataGridViewTextBoxColumn";
            this.confNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "startTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "endTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Select";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "Select";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // rentalAgreementBindingSource
            // 
            this.rentalAgreementBindingSource.DataMember = "RentalAgreement";
            this.rentalAgreementBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rentCarDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // rentCarDataSet1
            // 
            this.rentCarDataSet1.DataSetName = "RentCarDataSet1";
            this.rentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConfNo
            // 
            this.txtConfNo.Location = new System.Drawing.Point(66, 103);
            this.txtConfNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfNo.Name = "txtConfNo";
            this.txtConfNo.Size = new System.Drawing.Size(84, 20);
            this.txtConfNo.TabIndex = 1;
            // 
            // rentalAgreementTableAdapter
            // 
            this.rentalAgreementTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ConfNo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date :";
            // 
            // txtStartDt
            // 
            this.txtStartDt.Location = new System.Drawing.Point(199, 103);
            this.txtStartDt.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDt.Name = "txtStartDt";
            this.txtStartDt.Size = new System.Drawing.Size(129, 20);
            this.txtStartDt.TabIndex = 6;
            // 
            // txtEndDt
            // 
            this.txtEndDt.Location = new System.Drawing.Point(352, 103);
            this.txtEndDt.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndDt.Name = "txtEndDt";
            this.txtEndDt.Size = new System.Drawing.Size(138, 20);
            this.txtEndDt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " ~ ";
            // 
            // cmdSearchRental
            // 
            this.cmdSearchRental.BackColor = System.Drawing.Color.Salmon;
            this.cmdSearchRental.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdSearchRental.Location = new System.Drawing.Point(550, 103);
            this.cmdSearchRental.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSearchRental.Name = "cmdSearchRental";
            this.cmdSearchRental.Size = new System.Drawing.Size(91, 22);
            this.cmdSearchRental.TabIndex = 9;
            this.cmdSearchRental.Text = "Search";
            this.cmdSearchRental.UseVisualStyleBackColor = false;
            this.cmdSearchRental.Click += new System.EventHandler(this.cmdSearchRental_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "RentalAgreement List";
            // 
            // cmdMainApp
            // 
            this.cmdMainApp.BackColor = System.Drawing.Color.Teal;
            this.cmdMainApp.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdMainApp.Location = new System.Drawing.Point(2, 7);
            this.cmdMainApp.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMainApp.Name = "cmdMainApp";
            this.cmdMainApp.Size = new System.Drawing.Size(94, 27);
            this.cmdMainApp.TabIndex = 11;
            this.cmdMainApp.Text = "Main App";
            this.cmdMainApp.UseVisualStyleBackColor = false;
            this.cmdMainApp.Click += new System.EventHandler(this.cmdMainApp_Click);
            // 
            // AgreementDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(662, 455);
            this.Controls.Add(this.cmdMainApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSearchRental);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndDt);
            this.Controls.Add(this.txtStartDt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfNo);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgreementDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agreement Detail";
            this.Load += new System.EventHandler(this.AgreementDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalAgreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.TextBox txtConfNo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RentCarDataSet1 rentCarDataSet1;
        private System.Windows.Forms.BindingSource rentalAgreementBindingSource;
        private RentCarDataSet1TableAdapters.RentalAgreementTableAdapter rentalAgreementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn agreementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtStartDt;
        private System.Windows.Forms.DateTimePicker txtEndDt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSearchRental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdMainApp;
    }
}