using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AgreementDetail : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private string agreementID = "";
        private Thread th;

        public AgreementDetail()
        {
            InitializeComponent();
        }

        private void AgreementDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet1.RentalAgreement' table. You can move, or remove it, as needed.
            this.rentalAgreementTableAdapter.Fill(this.rentCarDataSet1.RentalAgreement);
            setItmeValue();
            getData();
           
        }

        private void setItmeValue()
        {
            txtStartDt.Value = DateTime.Today.AddDays(-3);
        }

        private void getData()
        {
            string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "Select * FROM [RentalAgreement] WHERE confNo LIKE '" + txtConfNo.Text +
                             "%' AND startTime BETWEEN convert(datetime, '" + txtStartDt.Value +
                             "') AND convert(datetime, '" + txtEndDt.Value + "')";


                da = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Reservation");
                dg1.DataSource = ds;
                dg1.DataMember = "Reservation";
                conn.Close();
            }catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dg1.Columns["Detail"].Index) return;

            dg1.CurrentRow.Selected = true;
            agreementID = dg1.CurrentRow.Cells[0].Value.ToString();

            this.Close();
            th = new Thread(opennewformGenInv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); 
        }

        private void opennewformGenInv(object obj)
        {
            Application.Run(new ReturnCar(agreementID));
        }

        private void cmdSearchRental_Click(object sender, EventArgs e)
        {
            getData();
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
