// Display Invoice Detail
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class Invoice : Form
    {
        //declare variable
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";

        private string invID = null;
        private Thread th;
        private string AgreeId = null;
        private string insId = null;
        private string confNo = null;


        public Invoice()
        {
            InitializeComponent();
        }

        public Invoice(string invID)
        {
            InitializeComponent();
            this.invID = invID;
        }


        private void invoice_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT invoiceID, invDateTime, amount, Invoice.agreementID, " +
                                    "RentalAgreement.insuranceID, RentalAgreement.confNo, startTime, endTime, " +
                                    "name, price, " +
                                    "customer.cname, address, licNo, phone, email," +
                                    "make, model " +
                               "FROM Invoice, RentalAgreement, Insurance, Reservation, Customer, Car  " +
                              "WHERE Invoice.agreementID = RentalAgreement.agreementID " +
                                "AND RentalAgreement.insuranceID = Insurance.insuranceID " +
                                "AND RentalAgreement.confNo = Reservation.confNo " +
                                "AND Reservation.cname = Customer.cname " +
                                "AND Reservation.vin = Car.vin " +
                                "AND invoiceID = '" + invID + "'";

                da = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Invoice");
               
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //display invoice detail in text boxes
                    lblinvNo.Text = ds.Tables[0].Rows[0]["invoiceID"].ToString();
                    lblinvdt.Text = ds.Tables[0].Rows[0]["invDateTime"].ToString();
                    lblAmount.Text = "$" + ds.Tables[0].Rows[0]["amount"].ToString();
                    lblInsu.Text = ds.Tables[0].Rows[0]["name"].ToString();
                    lblStartdt.Text = ds.Tables[0].Rows[0]["startTime"].ToString();
                    lblReturnDt.Text = ds.Tables[0].Rows[0]["endTime"].ToString();
                    lblPrice.Text = "$" + ds.Tables[0].Rows[0]["price"].ToString();
                    lblcus.Text = ds.Tables[0].Rows[0]["cname"].ToString();
                    lblAddress.Text = ds.Tables[0].Rows[0]["address"].ToString();
                    lblLic.Text = ds.Tables[0].Rows[0]["licNo"].ToString();
                    lblPhone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                    lblEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    lblMake.Text = ds.Tables[0].Rows[0]["make"].ToString();
                    lblModel.Text = ds.Tables[0].Rows[0]["model"].ToString(); 
                }
                else
                {
                    MessageBox.Show("No invoice Detail !!!");
                }
              
                conn.Close();              
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data From Database");
            }
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
