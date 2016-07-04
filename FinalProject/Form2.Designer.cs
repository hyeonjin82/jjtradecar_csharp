namespace FinalProject
{
    partial class Form2
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.cmdReturnCar = new System.Windows.Forms.Button();
            this.lblCurrentRAid = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental Agreement List";
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(47, 60);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(753, 351);
            this.dg1.TabIndex = 7;
            // 
            // cmdReturnCar
            // 
            this.cmdReturnCar.Location = new System.Drawing.Point(628, 449);
            this.cmdReturnCar.Name = "cmdReturnCar";
            this.cmdReturnCar.Size = new System.Drawing.Size(172, 23);
            this.cmdReturnCar.TabIndex = 2;
            this.cmdReturnCar.Text = "Return Car";
            this.cmdReturnCar.UseVisualStyleBackColor = true;
            this.cmdReturnCar.Click += new System.EventHandler(this.cmdReturnCar_Click);
            // 
            // lblCurrentRAid
            // 
            this.lblCurrentRAid.AutoSize = true;
            this.lblCurrentRAid.Location = new System.Drawing.Point(44, 432);
            this.lblCurrentRAid.Name = "lblCurrentRAid";
            this.lblCurrentRAid.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentRAid.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 580);
            this.Controls.Add(this.lblCurrentRAid);
            this.Controls.Add(this.cmdReturnCar);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button cmdReturnCar;
        private System.Windows.Forms.Label lblCurrentRAid;
    }
}