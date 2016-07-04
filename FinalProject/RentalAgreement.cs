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
    public partial class RentalAgreement : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private List<string> reser = null;
        private Thread th;
        private string insID = "S003";

        string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";

        public RentalAgreement()
        {
            InitializeComponent();
        }

        public RentalAgreement(List<string> reser)
        {
            InitializeComponent();
            this.reser = reser;
            setData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getInsurance();
            setItemValue();
        }

        private void setItemValue()
        {
            endDate.Value = DateTime.Today.AddDays(3);
            boxIns.SelectedText = "Standard Option"; 
            
        }

        private void getInsurance()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand("SELECT name FROM insurance", conn);
            //cmd.Parameters.AddWithValue("@itemname", boxIns.SelectedItem.ToString());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                boxIns.Items.Add(dr[0]);
            }
            dr.Close();
            conn.Close();
        }

        private void setData()
        {
            txtReserv.Text = reser[0];
            txtCusName.Text = reser[1];
            txtCarVin.Text = reser[2];
        }
        private void getCusData()
        {       
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "Select TOP 1 * from [Customer] WHERE cname = '" + txtCusName.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@insName", boxIns.SelectedItem.ToString());

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCusName.Text = dr[0].ToString();
                    txtCusAddress.Text = dr[1].ToString();
                    txtCusPhone.Text = dr[2].ToString();
                    txtLicNo.Text = dr[3].ToString();
                    txtEmail.Text = dr[4].ToString();
                   
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
        }

        private void getCarData()
        {
            try
            {

                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "Select TOP 1 * from [Car] WHERE vin = '" + txtCarVin.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCarVin.Text = dr[0].ToString();
                    txtCarMake.Text = dr[1].ToString();
                    txtCarModel.Text = dr[2].ToString();
                    txtCarOdometer.Text = dr[3].ToString();
                    txtCarType.Text = dr[4].ToString();
                    txtCarYear.Text = dr[5].ToString();

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
        }

        private void cmdFindCar_Click(object sender, EventArgs e)
        {
            getCarData();
        }

        private void cmdFindCus_Click(object sender, EventArgs e)
        {
            getCusData();
        }

        private void CusInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformCusList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();  
        }

        private void opennewformCusList(object obj)
        {
            Application.Run(new CustomerInfo());
        }

        private void cmdCarInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformCarList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();  
            
        }

        private void opennewformCarList(object obj)
        {
            Application.Run(new CarInfo());
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to confirm this form?", "Confirm RentalAgreement",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                if (generateAgree())
                {
                    MessageBox.Show("Success to save the contract !!!!");
                    this.Close();
                    th = new Thread(opennewformAgreeList);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();  
                }
                else
                {
                    MessageBox.Show("File to save the RentalAgreement!!!!");
                }
               
            }
        }

        private void opennewformAgreeList(object obj)
        {
            Application.Run(new AgreementDetail());
        }

        private bool generateAgree()
        {
            using (var conninsert = new SqlConnection(connStr))
            {
                SqlDataAdapter cmd = new SqlDataAdapter();
                SqlTransaction transaction;
                string sql = "INSERT INTO [dbo].[RentalAgreement] ([agreementID], [insuranceID], [confNo], [startTime], [endTime]) VALUES (@agreementID, @insuranceID, @confNo, @startTime, @endTime)";

                using (var insertCommand = new SqlCommand(sql))
                {

                    insertCommand.Connection = conninsert;
                    conninsert.Open();
                    transaction = conninsert.BeginTransaction("createRentalAgree");
                    insertCommand.Transaction = transaction;
                    cmd.InsertCommand = insertCommand;
                    insertCommand.Parameters.Add("@agreementID", SqlDbType.VarChar, 20).Value = getAgreementID();
                    insertCommand.Parameters.Add("@insuranceID", SqlDbType.VarChar, 20).Value = insID;
                    insertCommand.Parameters.Add("@confNo", SqlDbType.VarChar, 20).Value = txtReserv.Text;
                    insertCommand.Parameters.Add("@startTime", SqlDbType.DateTime).Value = Convert.ToDateTime(startDate.Value);
                    insertCommand.Parameters.Add("@endTime", SqlDbType.DateTime).Value = Convert.ToDateTime(endDate.Value);
                    insertCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            return true;
        }

        private string getAgreementID()
        {
            string agreementID = null;
            string temAgreementID = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT TOP 1 agreementID FROM [RentalAgreement] ORDER BY agreementID DESC ";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    temAgreementID = dr[0].ToString();
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
            int incConf = Convert.ToInt32(temAgreementID.Substring(1, 4));
            incConf += 1;
            agreementID = "A" + Convert.ToString(incConf);
            return agreementID;
        }

        private void ReservIDFind_Click(object sender, EventArgs e)
        {
            this.Close();
            th= new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new ReservFind());
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

        private void boxIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select InsuranceID from Insurance where name=@insName", conn);
            cmd.Parameters.AddWithValue("@insName", boxIns.SelectedItem.ToString());

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                insID = dr[0].ToString();  
            }
            dr.Close();
            conn.Close();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtCarVin.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtCarOdometer.Text = "";
            txtCarType.Text = "";
            txtCarYear.Text = "";
            txtCusAddress.Text = "";
            txtCusName.Text = "";
            txtCusPhone.Text = "";
            txtEmail.Text = "";
            txtLicNo.Text = ""; 
            txtReserv.Text = "";
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today.AddDays(3);
            boxIns.SelectedIndex = boxIns.Items.IndexOf("Standard Option");
        }
    }
}
