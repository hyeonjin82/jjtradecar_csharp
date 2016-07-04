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
    public partial class ReservFind : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True");
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private Thread th;
        private List<string> reser;

        public ReservFind()
        {
            InitializeComponent();
        }
       

        private void ReservSearch_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void dg1_DoubleClick(object sender, EventArgs e)
        {
            rowIndex = dg1.CurrentRow.Index;
            //align rowIndex with index of selection in DataSet
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dg1.CurrentRow.Cells[0].Value.ToString().Equals(ds.Tables[0].Rows[i][0].ToString()))
                    {
                        rowIndex = i;
                        break;
                    }
                }
            }
            dg1.CurrentRow.Selected = true;
            reser = new List<string>();
            reser.Add(dg1.CurrentRow.Cells[0].Value.ToString());
            reser.Add(dg1.CurrentRow.Cells[1].Value.ToString());
            reser.Add(dg1.CurrentRow.Cells[2].Value.ToString());
            reser.Add(dg1.CurrentRow.Cells[3].Value.ToString());

            this.Close();
            th = new Thread(opennewformRental);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewformRental(object obj)
        {
            Application.Run(new RentalAgreement(reser));
        }

        private void ReservFind_Load(object sender, EventArgs e)
        {
            setItemValue();
            getData();
        }

        private void setItemValue()
        {
            txtStartDt.Value = DateTime.Today.AddDays(-3);
        }

        private void getData()
        {
            conn.Open();
            string sql = "Select * FROM [Reservation] WHERE cname LIKE '" + txtCus.Text + "%' AND vin LIKE '" + txtCar.Text + "%' AND resDate BETWEEN convert(datetime, '" + txtStartDt.Value + "') AND convert(datetime, '" + txtEndDt.Value + "')";

            da = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Reservation");
            dg1.DataSource = ds;
            dg1.DataMember = "Reservation";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformBackConf);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewformBackConf(object obj)
        {
            Application.Run(new RentalAgreement());
        }
    }
}
