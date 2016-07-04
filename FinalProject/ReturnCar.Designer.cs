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
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agreement ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Return Mileage:";
            // 
            // lblRAid
            // 
            this.lblRAid.AutoSize = true;
            this.lblRAid.Location = new System.Drawing.Point(145, 186);
            this.lblRAid.Name = "lblRAid";
            this.lblRAid.Size = new System.Drawing.Size(73, 17);
            this.lblRAid.TabIndex = 6;
            this.lblRAid.Text = "r.a.id here";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(145, 228);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(99, 17);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "start time here";
            // 
            // lblStartMileage
            // 
            this.lblStartMileage.AutoSize = true;
            this.lblStartMileage.Location = new System.Drawing.Point(477, 186);
            this.lblStartMileage.Name = "lblStartMileage";
            this.lblStartMileage.Size = new System.Drawing.Size(46, 17);
            this.lblStartMileage.TabIndex = 10;
            this.lblStartMileage.Text = "label7";
            // 
            // txtEndMileage
            // 
            this.txtEndMileage.Location = new System.Drawing.Point(477, 228);
            this.txtEndMileage.Name = "txtEndMileage";
            this.txtEndMileage.Size = new System.Drawing.Size(100, 22);
            this.txtEndMileage.TabIndex = 11;
            // 
            // cmdCompleteReturn
            // 
            this.cmdCompleteReturn.BackColor = System.Drawing.Color.Orchid;
            this.cmdCompleteReturn.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdCompleteReturn.Location = new System.Drawing.Point(468, 294);
            this.cmdCompleteReturn.Name = "cmdCompleteReturn";
            this.cmdCompleteReturn.Size = new System.Drawing.Size(143, 31);
            this.cmdCompleteReturn.TabIndex = 12;
            this.cmdCompleteReturn.Text = "Generate Inv";
            this.cmdCompleteReturn.UseVisualStyleBackColor = false;
            this.cmdCompleteReturn.Click += new System.EventHandler(this.cmdCompleteReturn_Click);
            // 
            // lblconfno
            // 
            this.lblconfno.AutoSize = true;
            this.lblconfno.Location = new System.Drawing.Point(258, 94);
            this.lblconfno.Name = "lblconfno";
            this.lblconfno.Size = new System.Drawing.Size(41, 17);
            this.lblconfno.TabIndex = 13;
            this.lblconfno.Text = "reser";
            // 
            // lblRetrunTime
            // 
            this.lblRetrunTime.AutoSize = true;
            this.lblRetrunTime.Location = new System.Drawing.Point(145, 271);
            this.lblRetrunTime.Name = "lblRetrunTime";
            this.lblRetrunTime.Size = new System.Drawing.Size(32, 17);
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
            this.dg1.Location = new System.Drawing.Point(41, 122);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.Size = new System.Drawing.Size(545, 49);
            this.dg1.TabIndex = 15;
            // 
            // cmdMainApp
            // 
            this.cmdMainApp.BackColor = System.Drawing.Color.Teal;
            this.cmdMainApp.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdMainApp.Location = new System.Drawing.Point(12, 12);
            this.cmdMainApp.Name = "cmdMainApp";
            this.cmdMainApp.Size = new System.Drawing.Size(138, 37);
            this.cmdMainApp.TabIndex = 16;
            this.cmdMainApp.Text = "Main App";
            this.cmdMainApp.UseVisualStyleBackColor = false;
            this.cmdMainApp.Click += new System.EventHandler(this.cmdMainApp_Click);
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(633, 337);
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
    }
}