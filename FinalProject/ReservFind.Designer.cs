namespace FinalProject
{
    partial class ReservFind
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCus = new System.Windows.Forms.TextBox();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.txtStartDt = new System.Windows.Forms.DateTimePicker();
            this.txtEndDt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReservSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(9, 162);
            this.dg1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(444, 234);
            this.dg1.TabIndex = 0;
            this.dg1.DoubleClick += new System.EventHandler(this.dg1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car :";
            // 
            // txtCus
            // 
            this.txtCus.Location = new System.Drawing.Point(75, 80);
            this.txtCus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(116, 20);
            this.txtCus.TabIndex = 4;
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(251, 80);
            this.txtCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(132, 20);
            this.txtCar.TabIndex = 5;
            // 
            // txtStartDt
            // 
            this.txtStartDt.Location = new System.Drawing.Point(73, 110);
            this.txtStartDt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartDt.Name = "txtStartDt";
            this.txtStartDt.Size = new System.Drawing.Size(124, 20);
            this.txtStartDt.TabIndex = 6;
            // 
            // txtEndDt
            // 
            this.txtEndDt.Location = new System.Drawing.Point(217, 111);
            this.txtEndDt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndDt.Name = "txtEndDt";
            this.txtEndDt.Size = new System.Drawing.Size(140, 20);
            this.txtEndDt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "~ ";
            // 
            // ReservSearch
            // 
            this.ReservSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ReservSearch.ForeColor = System.Drawing.Color.Bisque;
            this.ReservSearch.Location = new System.Drawing.Point(380, 110);
            this.ReservSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReservSearch.Name = "ReservSearch";
            this.ReservSearch.Size = new System.Drawing.Size(70, 24);
            this.ReservSearch.TabIndex = 9;
            this.ReservSearch.Text = "Search";
            this.ReservSearch.UseVisualStyleBackColor = false;
            this.ReservSearch.Click += new System.EventHandler(this.ReservSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(375, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Please double click the wanted row";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Reservation List";
            // 
            // ReservFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(462, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReservSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDt);
            this.Controls.Add(this.txtStartDt);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.txtCus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReservFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservFind";
            this.Load += new System.EventHandler(this.ReservFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCus;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.DateTimePicker txtStartDt;
        private System.Windows.Forms.DateTimePicker txtEndDt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReservSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}