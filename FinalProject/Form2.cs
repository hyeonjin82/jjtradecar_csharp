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

namespace FinalProject
{
    public partial class Form2 : Form
    {
        
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private string agreementID = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
            dg1.Click += dg1_Click;
        }

        private void getData()
        {
            //string connStr =
            //    "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\jin\\Downloads\\FinalProject (1)\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";
            string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [RentalAgreement]";
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
            catch(SqlException ex)
            {
                if(conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data");
            }
            dg1.ClearSelection();
        }

        void dg1_Click(object sender, EventArgs e)
        {
            dg1.CurrentRow.Selected = true;
            agreementID = dg1.CurrentRow.Cells[0].Value.ToString();
            lblCurrentRAid.Text = "Rental Agreement ID: " + agreementID;
        }

        private void cmdReturnCar_Click(object sender, EventArgs e)
        {
            ReturnCar rc = new ReturnCar(agreementID);
            rc.Show();
        }
    }
}
