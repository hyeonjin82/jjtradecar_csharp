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
    public partial class CusFind : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True");
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private string carID;
        private Thread th;
        private List<string> cus;

        public CusFind()
        {
            InitializeComponent();
        }
        public CusFind(string carID)
        {
            InitializeComponent();
            this.carID = carID;
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
            cus = new List<string>();
            cus.Add(dg1.CurrentRow.Cells[0].Value.ToString());
            cus.Add(dg1.CurrentRow.Cells[1].Value.ToString());
            cus.Add(dg1.CurrentRow.Cells[2].Value.ToString());
            cus.Add(dg1.CurrentRow.Cells[3].Value.ToString());
            cus.Add(dg1.CurrentRow.Cells[4].Value.ToString());
            cus.Add(carID);

            this.Close();
            th = new Thread(opennewformRental);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewformRental(object obj)
        {
            Application.Run(new Reserv(cus));
        }

        private void CusSearch_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void CusFind_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            conn.Open();
            string sql = "Select * FROM [Customer] WHERE cname LIKE '" + txtCus.Text + "%' AND phone LIKE '" + txtPhone.Text + "%' AND Email LIKE '" + txtEmail.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Customer");
            dg1.DataSource = ds;
            dg1.DataMember = "Customer";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformBackReserv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewformBackReserv(object obj)
        {
            Application.Run(new ReserCarList());
        }
    }
}
