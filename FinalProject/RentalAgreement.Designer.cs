namespace FinalProject
{
    partial class RentalAgreement
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
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCar = new FinalProject.RentCar();
            this.cmdCusInfo = new System.Windows.Forms.Button();
            this.aaa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtLicNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdFindCus = new System.Windows.Forms.Button();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarVin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdFindCar = new System.Windows.Forms.Button();
            this.cmdCarInfo = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCarOdometer = new System.Windows.Forms.TextBox();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.ReservIDFind = new System.Windows.Forms.Button();
            this.txtReserv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boxIns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMainApp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentCar
            // 
            this.rentCar.DataSetName = "RentCar";
            this.rentCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdCusInfo
            // 
            this.cmdCusInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdCusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdCusInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdCusInfo.Location = new System.Drawing.Point(281, 89);
            this.cmdCusInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCusInfo.Name = "cmdCusInfo";
            this.cmdCusInfo.Size = new System.Drawing.Size(104, 25);
            this.cmdCusInfo.TabIndex = 2;
            this.cmdCusInfo.Text = "Customer Info";
            this.cmdCusInfo.UseVisualStyleBackColor = false;
            this.cmdCusInfo.Click += new System.EventHandler(this.CusInfo_Click);
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(56, 140);
            this.aaa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(88, 13);
            this.aaa.TabIndex = 3;
            this.aaa.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Customer IicNo :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Customer Phone :";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(149, 140);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(111, 20);
            this.txtCusName.TabIndex = 15;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(149, 170);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(111, 20);
            this.txtCusAddress.TabIndex = 16;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(149, 203);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(111, 20);
            this.txtCusPhone.TabIndex = 17;
            // 
            // txtLicNo
            // 
            this.txtLicNo.Location = new System.Drawing.Point(149, 235);
            this.txtLicNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicNo.Name = "txtLicNo";
            this.txtLicNo.Size = new System.Drawing.Size(111, 20);
            this.txtLicNo.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 267);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(111, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // cmdFindCus
            // 
            this.cmdFindCus.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdFindCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdFindCus.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdFindCus.Location = new System.Drawing.Point(250, 31);
            this.cmdFindCus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdFindCus.Name = "cmdFindCus";
            this.cmdFindCus.Size = new System.Drawing.Size(104, 25);
            this.cmdFindCus.TabIndex = 20;
            this.cmdFindCus.Text = "Find";
            this.cmdFindCus.UseVisualStyleBackColor = false;
            this.cmdFindCus.Click += new System.EventHandler(this.cmdFindCus_Click);
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(509, 264);
            this.txtCarType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(111, 20);
            this.txtCarType.TabIndex = 31;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarModel.Location = new System.Drawing.Point(509, 202);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(111, 19);
            this.txtCarModel.TabIndex = 29;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(509, 171);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(111, 20);
            this.txtCarMake.TabIndex = 28;
            // 
            // txtCarVin
            // 
            this.txtCarVin.Location = new System.Drawing.Point(509, 140);
            this.txtCarVin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarVin.Name = "txtCarVin";
            this.txtCarVin.Size = new System.Drawing.Size(111, 20);
            this.txtCarVin.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Car Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Car Odomerter :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Car Model :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(446, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Car Make :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(456, 140);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Car Vin :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(449, 299);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Car Year :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 383);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = " ~";
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdOk.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdOk.Location = new System.Drawing.Point(649, 383);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(104, 25);
            this.cmdOk.TabIndex = 35;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = false;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdReset.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdReset.Location = new System.Drawing.Point(541, 383);
            this.cmdReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(104, 25);
            this.cmdReset.TabIndex = 37;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdFindCar
            // 
            this.cmdFindCar.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdFindCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdFindCar.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdFindCar.Location = new System.Drawing.Point(237, 34);
            this.cmdFindCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdFindCar.Name = "cmdFindCar";
            this.cmdFindCar.Size = new System.Drawing.Size(104, 25);
            this.cmdFindCar.TabIndex = 38;
            this.cmdFindCar.Text = "Find";
            this.cmdFindCar.UseVisualStyleBackColor = false;
            this.cmdFindCar.Click += new System.EventHandler(this.cmdFindCar_Click);
            // 
            // cmdCarInfo
            // 
            this.cmdCarInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdCarInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdCarInfo.Location = new System.Drawing.Point(656, 89);
            this.cmdCarInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCarInfo.Name = "cmdCarInfo";
            this.cmdCarInfo.Size = new System.Drawing.Size(104, 25);
            this.cmdCarInfo.TabIndex = 39;
            this.cmdCarInfo.Text = "Car Info";
            this.cmdCarInfo.UseVisualStyleBackColor = false;
            this.cmdCarInfo.Click += new System.EventHandler(this.cmdCarInfo_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(97, 383);
            this.startDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(141, 20);
            this.startDate.TabIndex = 40;
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(302, 47);
            this.endDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(139, 19);
            this.endDate.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdFindCus);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(363, 225);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(0, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(446, 201);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCarOdometer);
            this.groupBox3.Controls.Add(this.txtCarYear);
            this.groupBox3.Controls.Add(this.cmdFindCar);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(399, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(361, 225);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car Info";
            // 
            // txtCarOdometer
            // 
            this.txtCarOdometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarOdometer.Location = new System.Drawing.Point(110, 130);
            this.txtCarOdometer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarOdometer.Name = "txtCarOdometer";
            this.txtCarOdometer.Size = new System.Drawing.Size(111, 19);
            this.txtCarOdometer.TabIndex = 53;
            // 
            // txtCarYear
            // 
            this.txtCarYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarYear.Location = new System.Drawing.Point(110, 190);
            this.txtCarYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(111, 19);
            this.txtCarYear.TabIndex = 53;
            // 
            // ReservIDFind
            // 
            this.ReservIDFind.BackColor = System.Drawing.Color.MediumPurple;
            this.ReservIDFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReservIDFind.ForeColor = System.Drawing.SystemColors.Info;
            this.ReservIDFind.Location = new System.Drawing.Point(642, 8);
            this.ReservIDFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReservIDFind.Name = "ReservIDFind";
            this.ReservIDFind.Size = new System.Drawing.Size(104, 25);
            this.ReservIDFind.TabIndex = 49;
            this.ReservIDFind.Text = "Find";
            this.ReservIDFind.UseVisualStyleBackColor = false;
            this.ReservIDFind.Click += new System.EventHandler(this.ReservIDFind_Click);
            // 
            // txtReserv
            // 
            this.txtReserv.Location = new System.Drawing.Point(526, 11);
            this.txtReserv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReserv.Name = "txtReserv";
            this.txtReserv.Size = new System.Drawing.Size(111, 20);
            this.txtReserv.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Reservation ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boxIns);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.endDate);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(26, 335);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(446, 81);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insurance Info";
            // 
            // boxIns
            // 
            this.boxIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIns.FormattingEnabled = true;
            this.boxIns.Location = new System.Drawing.Point(302, 22);
            this.boxIns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxIns.Name = "boxIns";
            this.boxIns.Size = new System.Drawing.Size(139, 21);
            this.boxIns.TabIndex = 53;
            this.boxIns.SelectedIndexChanged += new System.EventHandler(this.boxIns_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Insurance Option :";
            // 
            // cmdMainApp
            // 
            this.cmdMainApp.BackColor = System.Drawing.Color.SteelBlue;
            this.cmdMainApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdMainApp.ForeColor = System.Drawing.SystemColors.Info;
            this.cmdMainApp.Location = new System.Drawing.Point(9, 5);
            this.cmdMainApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdMainApp.Name = "cmdMainApp";
            this.cmdMainApp.Size = new System.Drawing.Size(104, 25);
            this.cmdMainApp.TabIndex = 52;
            this.cmdMainApp.Text = "Main App";
            this.cmdMainApp.UseVisualStyleBackColor = false;
            this.cmdMainApp.Click += new System.EventHandler(this.cmdMainApp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Contract";
            // 
            // RentalAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdMainApp);
            this.Controls.Add(this.cmdCusInfo);
            this.Controls.Add(this.cmdCarInfo);
            this.Controls.Add(this.txtReserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReservIDFind);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarVin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLicNo);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Agreement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private RentCar rentCar;
        private System.Windows.Forms.Button cmdCusInfo;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtLicNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdFindCus;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarVin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdFindCar;
        private System.Windows.Forms.Button cmdCarInfo;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ReservIDFind;
        private System.Windows.Forms.TextBox txtReserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxIns;
        private System.Windows.Forms.Button cmdMainApp;
        private System.Windows.Forms.TextBox txtCarOdometer;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.Label label7;
    }
}

