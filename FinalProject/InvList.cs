// Display Invoice List
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
    public partial class InvList : Form
    {
        private SqlConnection myConn = null;
        private int rowNum = -1;
        private string invoiceID = null;
        string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";

        private Thread th;

        public InvList()
        {
            InitializeComponent();
        }

        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            //if not select, then error message
            if (invoiceID == null || invoiceID == "")
            {
                MessageBox.Show("Please select one invoice!");
            }
            else    //pass invoiceID and show Invoice form
            {
                this.Close();
                th = new Thread(opennewformInvoice);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();          
            }
        }

        private void opennewformInvoice(object obj)
        {
            Application.Run(new Invoice(invoiceID));
        }


        private void InvList_Load(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                myConn = new SqlConnection(connStr);
                myConn.Open();

                //get data from database
                SqlDataAdapter invDa = new SqlDataAdapter("SELECT * FROM Invoice", myConn);
                SqlCommandBuilder invCb = new SqlCommandBuilder(invDa);
                DataSet invDs = new DataSet();
                invDa.Fill(invDs, "Invoice");
                myConn.Close();

                //display data in datagridview
                BindingSource bs = new BindingSource();
                bs.DataSource = invDs;
                bs.DataMember = "Invoice";
                dg.DataSource = bs;
            }
            catch (SqlException ex)
            {
                if (myConn != null)
                {
                    myConn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Data From Database");
            }

            dg.Click += dg_Click;
            
        }

        void dg_Click(object sender, EventArgs e)
        {
            //get current row index
            rowNum = dg.CurrentRow.Index;

            //get invoiceID from selected row
            invoiceID = dg.Rows[rowNum].Cells[0].Value.ToString();
            dg.CurrentRow.Selected = true;

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
