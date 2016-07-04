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
    public partial class Reserv : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlCommand cmd2 = null;
        private string origVin = "";
        private string carID;
        private Thread th;
        private List<string> cus;
        string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\jin_source\\C#class\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";

        public Reserv()
        {
            InitializeComponent();
        }
        public Reserv(string carId)
        {
            InitializeComponent();
            this.carID = carId;
        }
        public Reserv(List<string> cus)
        {
            InitializeComponent();
            this.carID = cus[5];
            this.cus = cus;
            setCus();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
            dg1.Click += dg1_Click;
            txtRes.KeyPress += txtRes_KeyPress;
            txtPNum.KeyPress += txtPNum_KeyPress;
            txtCName.KeyPress += txtCName_KeyPress;
            txtAddress.KeyPress += txtAdd_KeyPress;
            txtLic.KeyPress += txtLic_KeyPress;
            txtEmail.KeyPress += txtEmail_KeyPress;
        }

        private void setCus()
        {
            txtCName.Text = cus[0];
            txtLic.Text = cus[1];
            txtAddress.Text = cus[2];
            txtPNum.Text = cus[3];
            txtEmail.Text = cus[4];
        }

        void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
 	        char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                {
                    e.Handled = true;
                }
            }
        }

        void txtLic_KeyPress(object sender, KeyPressEventArgs e)
        {
 	        char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                {
                    e.Handled = true;
                }
            }
        }

        void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
 	        char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                {
                    e.Handled = true;
                }
            }
        }

        void txtCName_KeyPress(object sender, KeyPressEventArgs e)
        {
 	        char c = e.KeyChar;
            if (c != 8)
            {
                if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                {
                    e.Handled = true;
                }
            }
        }

        void txtPNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = txtPNum.Text.Length;
            txtPNum.SelectionStart = len;
            if (c != 8)
            {
                if (len == 3 || len == 7) // dash only
                {
                    if (c != 45) //not dash
                    {
                        //kill char
                        e.Handled = true;
                    }
                }
                else//numeric digit only
                {
                    if (c < 48 || c > 57)//not number
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int len = txtRes.Text.Length;
     
            if (c != 8)
            {
                if (len == 4 || len == 7) // dash only
                {
                    if (c != 45) //not dash
                    {
                        //kill char
                        e.Handled = true;
                    }
                }
                else//numeric digit only
                {
                    if (c < 48 || c > 57)//not number
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void dg1_Click(object sender, EventArgs e)
        {
            dg1.CurrentRow.Selected = true;
            origVin = dg1.CurrentRow.Cells[1].Value.ToString();
            setControlState("u/d");
        }
        private void getData()
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [Car] WHERE vin = '" + carID+"'";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bindingSource1.DataSource = dr;
                    dg1.DataSource = bindingSource1;
                }
                else
                {
                    dg1.DataSource = null;
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
        private void cmdInsert_Click(object sender, EventArgs e)
        {
             if (dataGood())
            {
                string sql = "INSERT INTO [Reservation] ([confno], [cname], [VIN], [resDate]) VALUES (@confno, @cname, @VIN, @resDate)";
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = sql;
                    cmd2.Parameters.Add("@confno", SqlDbType.VarChar, 20).Value = getConfID();
                    cmd2.Parameters.Add("@cname", SqlDbType.VarChar, 20).Value = txtCName.Text;
                    cmd2.Parameters.Add("@VIN", SqlDbType.VarChar, 20).Value = carID;
                    cmd2.Parameters.Add("@resDate", SqlDbType.Date).Value = DateTime.Now.ToString("h:mm:ss tt");
                    cmd2.ExecuteNonQuery(); 
                    conn.Close();
                }
                catch (Exception ex)
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    MessageBox.Show(ex.Message, "Error Inserting Record");
                }
            }
             MessageBox.Show("Sucess Reservation!!!");
             this.Close();
             th = new Thread(opennewformMain);
             th.SetApartmentState(ApartmentState.STA);
             th.Start();
        }

        private void opennewformMain(object obj)
        {
            Application.Run(new MainApp());
        }

        private string getConfID()
        {
            string confID=null;
            string temconfID = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT TOP 1 confno FROM [Reservation] ORDER BY confno DESC ";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    temconfID = dr[0].ToString();
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
            int incConf = Convert.ToInt32(temconfID.Substring(1, 4));
            incConf += 1;
            confID = "R" + Convert.ToString(incConf);
            return confID;
        }
        private void setControlState(string state)
        {
            if (state.Equals("i"))
            {
                txtRes.Enabled= true;
                clearText();
            }
            else if (state.Equals("u/d"))
            {
                txtRes.Enabled = true;
            }
        }
        private void clearText()
        {
            txtCName.Text = "";
            txtAddress.Text = "";
            txtPNum.Text = "";
            txtLic.Text = "";
            txtEmail.Text = "";
            txtRes.Text = "";
            dg1.ClearSelection();
        }
        private bool dataGood()
        {
            if (txtCName.Text.Length < 1)
            {
                MessageBox.Show("Customer Name required!", "Missing Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCName.Focus();
                return false;
            }
            if (txtAddress.Text.Length < 1)
            {
                MessageBox.Show("Address required!", "Missing Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }
            if ((txtPNum.Text.Length != 12) && (txtPNum.Text.Length < 1))
            {
                MessageBox.Show("Phone Number must conform to format or Missing Phone Number!", "Missing Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPNum.Focus();
                return false;
            }
            if (txtLic.Text.Length < 1)
            {
                MessageBox.Show("License required!", "Missing License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLic.Focus();
                return false;
            }
            if (txtEmail.Text.Length < 1)
            {
                MessageBox.Show("Email Address required!", "Missing Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if ((txtRes.Text.Length != 10) && (txtRes.Text.Length < 1))
            {
                MessageBox.Show("Reservation date must conform to format or Missing Reservation Date!", "Invalid Reservation Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRes.Focus();
                return false;
            }
            return true;
        }

        private void cmdCusFind_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new CusFind(carID));
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
