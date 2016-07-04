namespace FinalProject
{
    partial class ReturnCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRAid = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblStartMileage = new System.Windows.Forms.Label();
            this.txtEndMileage = new System.Windows.Forms.TextBox();
            this.cmdCompleteReturn = new System.Windows.Forms.Button();
            this.lblconfno = new System.Windows.Forms.Label();
            this.lblRetrunTime = new System.Windows.Forms.Label();
            this.rentalAgreementTableAdapter1 = new FinalProject.RentCarDataSet1TableAdapters.RentalAgreementTableAdapter();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdMainApp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agreement ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Return Mileage:";
            // 
            // lblRAid
            // 
            this.lblRAid.AutoSize = true;
            this.lblRAid.Location = new System.Drawing.Point(109, 200);
            this.lblRAid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAid.Name = "lblRAid";
            this.lblRAid.Size = new System.Drawing.Size(54, 13);
            this.lblRAid.TabIndex = 6;
            this.lblRAid.Text = "r.a.id here";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(109, 234);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(73, 13);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "start time here";
            // 
            // lblStartMileage
            // 
            this.lblStartMileage.AutoSize = true;
            this.lblStartMileage.Location = new System.Drawing.Point(391, 200);
            this.lblStartMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartMileage.Name = "lblStartMileage";
            this.lblStartMileage.Size = new System.Drawing.Size(35, 13);
            this.lblStartMileage.TabIndex = 10;
            this.lblStartMileage.Text = "label7";
            // 
            // txtEndMileage
            // 
            this.txtEndMileage.Location = new System.Drawing.Point(391, 234);
            this.txtEndMileage.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndMileage.Name = "txtEndMileage";
            this.txtEndMileage.Size = new System.Drawing.Size(76, 20);
            this.txtEndMileage.TabIndex = 11;
            // 
            // cmdCompleteReturn
            // 
            this.cmdCompleteReturn.BackColor = System.Drawing.Color.Orchid;
            this.cmdCompleteReturn.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdCompleteReturn.Location = new System.Drawing.Point(455, 302);
            this.cmdCompleteReturn.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCompleteReturn.Name = "cmdCompleteReturn";
            this.cmdCompleteReturn.Size = new System.Drawing.Size(112, 29);
            this.cmdCompleteReturn.TabIndex = 12;
            this.cmdCompleteReturn.Text = "Generate Invoice";
            this.cmdCompleteReturn.UseVisualStyleBackColor = false;
            this.cmdCompleteReturn.Click += new System.EventHandler(this.cmdCompleteReturn_Click);
            // 
            // lblconfno
            // 
            this.lblconfno.AutoSize = true;
            this.lblconfno.Location = new System.Drawing.Point(320, 116);
            this.lblconfno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconfno.Name = "lblconfno";
            this.lblconfno.Size = new System.Drawing.Size(30, 13);
            this.lblconfno.TabIndex = 13;
            this.lblconfno.Text = "reser";
            // 
            // lblRetrunTime
            // 
            this.lblRetrunTime.AutoSize = true;
            this.lblRetrunTime.Location = new System.Drawing.Point(109, 268);
            this.lblRetrunTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetrunTime.Name = "lblRetrunTime";
            this.lblRetrunTime.Size = new System.Drawing.Size(25, 13);
            this.lblRetrunTime.TabIndex = 14;
            this.lblRetrunTime.Text = "end";
            // 
            // rentalAgreementTableAdapter1
            // 
            this.rentalAgreementTableAdapter1.ClearBeforeFill = true;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(22, 133);
            this.dg1.Margin = new System.Windows.Forms.Padding(2);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(545, 50);
            this.dg1.TabIndex = 15;
            // 
            // cmdMainApp
            // 
            this.cmdMainApp.BackColor = System.Drawing.Color.Teal;
            this.cmdMainApp.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdMainApp.Location = new System.Drawing.Point(9, 10);
            this.cmdMainApp.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMainApp.Name = "cmdMainApp";
            this.cmdMainApp.Size = new System.Drawing.Size(104, 30);
            this.cmdMainApp.TabIndex = 16;
            this.cmdMainApp.Text = "Main App";
            this.cmdMainApp.UseVisualStyleBackColor = false;
            this.cmdMainApp.Click += new System.EventHandler(this.cmdMainApp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "**The return mileage must be bigger than The Start one.";
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(580, 341);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdMainApp);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.lblRetrunTime);
            this.Controls.Add(this.lblconfno);
            this.Controls.Add(this.cmdCompleteReturn);
            this.Controls.Add(this.txtEndMileage);
            this.Controls.Add(this.lblStartMileage);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblRAid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnCar";
            this.Load += new System.EventHandler(this.ReturnCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRAid;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblStartMileage;
        private System.Windows.Forms.TextBox txtEndMileage;
        private System.Windows.Forms.Button cmdCompleteReturn;
        private System.Windows.Forms.Label lblconfno;
        private System.Windows.Forms.Label lblRetrunTime;
        private RentCarDataSet1TableAdapters.RentalAgreementTableAdapter rentalAgreementTableAdapter1;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdMainApp;
        private System.Windows.Forms.Label label8;
    }
}