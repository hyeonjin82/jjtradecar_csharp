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
    public partial class ReserCarList : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private string carID = "";
        private Thread th;

        public ReserCarList()
        {
            InitializeComponent();
        }

        private void AgreementDetail_Load(object sender, EventArgs e)
        {   
            this.carTableAdapter.Fill(this.rentCarDataSet3.Car);
            getData();
        }

        private void getData()
        {
            string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [Car]";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bindingSource1.DataSource = dr;
                    dg1.DataSource = bindingSource1;
                }
                else
                {
                    dg1.Rows.Clear();
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
            dg1.ClearSelection();
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dg1.Columns["Reservation"].Index) return;
            dg1.CurrentRow.Selected = true;
            carID = dg1.CurrentRow.Cells[0].Value.ToString();

            this.Close();
            th = new Thread(opennewformReservation);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();   
        }

        private void opennewformReservation(object obj)
        {
            Application.Run(new Reserv(carID));
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

        private void cmdCarSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "Select * FROM [Car] WHERE make LIKE '" + txtMake.Text + "%' AND model LIKE '" + txtModel.Text + "%' AND  type LIKE '" + txtType.Text + "%' AND year LIKE '" + txtYear.Text + "%'";

            da = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Car");
            dg1.DataSource = ds;
            dg1.DataMember = "Car";
            conn.Close();
        }
    }
}
