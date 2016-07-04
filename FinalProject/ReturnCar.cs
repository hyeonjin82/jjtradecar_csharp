using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace FinalProject
{
    public partial class ReturnCar : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlCommand cmd2 = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private string rentalAgreementID;
        private string odometer = "";
        private string vin = "";
        private Thread th;
        private string genInvNo;

        private string connStr =
            "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";

        private double ratePerMileage = 0.1;
        private double ratePerHour = 1.0;

        private double mileageCost = 0.0;
        private double totalTime = 0.0;
        private double timeCost = 0.0;
        private double amount = 0.0;

        private DateTime startDateTime;
        private DateTime retrunDateTime;

        public ReturnCar(string rentalAgreementID)
        {
            this.rentalAgreementID = rentalAgreementID;
            InitializeComponent();
        }

        private void ReturnCar_Load(object sender, EventArgs e)
        {
            lblRAid.Text = rentalAgreementID;
            getData();
            txtEndMileage.KeyPress += txtEndMileage_KeyPress;
        }

        // key validation for return mileage
        void txtEndMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c != 8) && (c < 48 || c > 57))
            {
                e.Handled = true;
            }
        }

        private void getData()
        {
            // get Rental Agreement Information from DB
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [RentalAgreement] WHERE [agreementID] = @agreementID";
                cmd.Parameters.AddWithValue("@agreementID", rentalAgreementID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bindingSource1.DataSource = dr;
                    dg1.DataSource = bindingSource1;
                }
                else
                {
                    dg1.Rows.Clear();
                    MessageBox.Show("Not matching data on agreementID");
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }

            // get Reservation Information from DB
            string strStartTime = dg1.Rows[0].Cells[3].Value.ToString();
            lblStartTime.Text = strStartTime;
            string confno = dg1.Rows[0].Cells[2].Value.ToString();
            lblconfno.Text = "Reservation NO: " + confno;
            string cname = "";
            retrunDateTime = DateTime.Now;
            lblRetrunTime.Text = DateTime.Now.ToString();
            startDateTime = Convert.ToDateTime(strStartTime);

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [Reservation] WHERE [confno] = @confno";
                cmd.Parameters.Add("@confno", SqlDbType.VarChar, 20).Value = confno;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cname = dr[1].ToString();
                        vin = dr[2].ToString();
                    }
                }

                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }

            lblconfno.Text = "Reservation: " + confno + ", Name: " + cname + ",  VIN: " + vin;

            // get Car Infomation from DB
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT odometer FROM [Car] WHERE [vin] = @vin";
                cmd.Parameters.Add("@vin", SqlDbType.VarChar, 20).Value = vin;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        odometer = dr[0].ToString();
                    }
                }

                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }
            lblStartMileage.Text = odometer;
        }

        private void cmdCompleteReturn_Click(object sender, EventArgs e)
        {
            // update car mileage(odometer) to DB
            string newOdometer = txtEndMileage.Text;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE [Car] SET [odometer] = @newOdometer WHERE[vin] = @vin";
                cmd.Parameters.Add("@newOdometer", SqlDbType.VarChar, 20).Value = newOdometer;
                cmd.Parameters.Add("@vin", SqlDbType.VarChar, 20).Value = vin;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Updating Data");
            }

            // calculate total amount
            try
            {   // 1) calculate mileage
                double doubleStartMileage = Convert.ToDouble(odometer);
                double doubleEndMileage = Convert.ToDouble(newOdometer);
                double mileage = doubleEndMileage - doubleStartMileage;

                if (mileage <= 0)
                {
                    MessageBox.Show("Smaller than the start mileage. Please input current total Mileage again.");
                    return;
                }
                else
                {
                    // 2) calculate time 
                    TimeSpan span = retrunDateTime.Subtract(startDateTime);
                    mileageCost = mileage * ratePerMileage;
                    totalTime = Convert.ToDouble(span.TotalHours.ToString("F"));
                    timeCost = totalTime * ratePerHour;
                    amount = mileageCost + timeCost;
                    MessageBox.Show(" Mileage: " + mileage.ToString() + " km \n" +
                                    "Cost for Mileage: $ " + mileageCost.ToString() +
                                    "\n Hours: " + totalTime.ToString() + " hrs \n" +
                                    " Cost for Time: $ " + timeCost.ToString() +
                                    "\n Total Amount: " + amount.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Invalid Mileage Data");
            }

            // save invoice data to DB   
            string sql = "INSERT INTO [Invoice] ([invoiceID], [invDateTime], [amount], [agreementID]) VALUES (@invoiceID, @invDateTime," + amount + ", @agreementID)";
            // string sql = "INSERT INTO [Invoice] VALUES (@invoiceID, @invDateTime,@amount, @agreementID)";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = sql;
                genInvNo = getInvID();
                cmd2.Parameters.Add("@invoiceID", SqlDbType.VarChar, 20).Value = genInvNo;
                cmd2.Parameters.Add("@invDateTime", SqlDbType.DateTime).Value = DateTime.Now.ToString("h:mm:ss tt");
                cmd2.Parameters.Add("@agreementID", SqlDbType.VarChar, 20).Value = rentalAgreementID;

                // cmd.Parameters.Add("@invoiceID", SqlDbType.VarChar, 20).Value = "1030";

                //SqlParameter param = new SqlParameter("@amount", SqlDbType.Decimal);
                //param.SourceColumn = amount.ToString();
                //param.Precision = 9;
                //param.Scale = 2;
                //cmd.Parameters.Add(param);

                cmd2.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success to save the Return!!!");
                this.Close();
                th = new Thread(opennewformInvDetail);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Inserting Record");
            }
        }

        private void opennewformInvDetail(object obj)
        {
            Application.Run(new Invoice(genInvNo));
        }

        private string getInvID()
        {
            string invID = null;
            string temInvID = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT TOP 1 invoiceID FROM [Invoice] ORDER BY invoiceID DESC ";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    temInvID = dr[0].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }
            int invNum = Convert.ToInt32(temInvID.Substring(1, 4));
            invNum += 1;
            invID = "V" + Convert.ToString(invNum);
            return invID;
        }

        private void cmdMainApp_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformMainApp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewformMainApp(object obj)
        {
            Application.Run(new MainApp());
        }
    }
}
