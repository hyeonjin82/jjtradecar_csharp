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
    public partial class CustomerInfo : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True");
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private Thread th;

        public CustomerInfo()
        {
            InitializeComponent();
        }



        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            getData();
            dg1.Click += dg1_Click;
        }

        void dg1_Click(object sender, EventArgs e)
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
            txtCusName.Text = dg1.CurrentRow.Cells[0].Value.ToString();
            txtCusAddress.Text = dg1.CurrentRow.Cells[1].Value.ToString();
            txtCusPhone.Text = dg1.CurrentRow.Cells[2].Value.ToString();
            txtCusLicNo.Text = dg1.CurrentRow.Cells[3].Value.ToString();
            txtCusEmail.Text = dg1.CurrentRow.Cells[4].Value.ToString();
            cusStatusLabel.Text = "rowIndex = " + rowIndex;
            cusStatusLabel.Text = "Row State =" + ds.Tables[0].Rows[rowIndex].RowState;
            setControlState("u/d");

        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                if (isValidAccount("i"))
                {
                    DataRow dr = ds.Tables["Customer"].NewRow();
                    dr["cname"] = txtCusName.Text;
                    dr["address"] = txtCusAddress.Text;
                    dr["phone"] = txtCusPhone.Text;
                    dr["licNo"] = txtCusLicNo.Text;
                    dr["email"] = txtCusEmail.Text;
                    ds.Tables[0].Rows.Add(dr);
                    clearText();
                }
            }
            updateDB();
        }

        private void clearText()
        {
            txtCusName.Text = "";
            txtCusAddress.Text = "";
            txtCusPhone.Text = "";
            txtCusLicNo.Text = "";
            txtCusEmail.Text = "";
            txtCusName.Focus();
            dg1.ClearSelection();
        }
        private void setControlState(String state)
        {
            if (state.Equals("i"))
            {
                cmdInsert.Enabled = true;
                cmdUpdate.Enabled = false;
                cmdDelete.Enabled = false;
                clearText();
            }
            else if (state.Equals("u/d"))
            {
                cmdInsert.Enabled = false;
                cmdUpdate.Enabled = true;
                cmdDelete.Enabled = true;
            }
        }
        private bool dataGood()
        {
            return true;
        }

        private bool isValidAccount(string state)
        {
            if (state.Equals("i"))
            {
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    Console.WriteLine("i " + i + "dg1.CurrentRow.Index" + dg1.CurrentRow.Index);
                    if (txtCusName.Text.Equals(dg1.CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Is valid account?", "Confirm Record Insert",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCusName.Focus();
                        return false;
                    }
                }
            }
            else if (state.Equals("u"))
            {

                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    Console.WriteLine("i :" + i + " dg1.CurrentRow.Index :" + dg1.CurrentRow.Index);
                    Console.WriteLine("i " + i);
                    Console.WriteLine("cell " + dg1.Rows[i].Cells[0].Value.ToString());

                    if (i != dg1.CurrentRow.Index)
                    {
                        if (txtCusName.Text.Equals(dg1.Rows[i].Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Is valid account?", "Confirm Record Update ",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCusName.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                if (isValidAccount("u"))
                {
                    //update an existing row in DataSet table
                    DataRow dr = ds.Tables[0].Rows[rowIndex];
                    dr["cname"] = txtCusName.Text;
                    dr["address"] = txtCusAddress.Text;
                    dr["phone"] = txtCusPhone.Text;
                    dr["licNo"] = txtCusLicNo.Text;
                    dr["email"] = txtCusEmail.Text;
                    setControlState("i");
                }
            }
            updateDB();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Record Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                ds.Tables["Customer"].Rows[rowIndex].Delete();
            }
            setControlState("i");
            updateDB();
        }

        private void updateDB()
        {
            try
            {
                conn.Open();
                int updatedRows = da.Update(ds, "Customer");
                cusStatusLabel.Text = "Updated Rows = " + updatedRows;
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Updating Database");
            }
        }
        private void cmdView_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            string connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM [Customer]";
                da = new SqlDataAdapter(sql, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                createCommands();
                ds = new DataSet();
                da.Fill(ds, "Customer");
                conn.Close();
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "Customer";
                dg1.DataSource = bindingSource1;
                dg1.ClearSelection();
                setControlState("i");
                //Create DataView
                //DataView myView = new DataView(ds.Tables[0]);
                //set RowStateFilter to show DELETE
                //myView.RowStateFilter = DataViewRowState.CurrentRows | DataViewRowState.Deleted;
                //display DataView instance
                //dgView.DataSource = myView;
                //dgView.ClearSelection();
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

        private void createCommands()
        {
            //create INSERT command for DataAdapter
            String sql = "INSERT INTO [Customer] ([cname],[address],[phone],[licNo],[email]) " +
                         "VALUES (@cname,@address,@phone,@licNo,@email)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@cname", SqlDbType.VarChar, 20, "cname");
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50, "address");
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20, "phone");
            cmd.Parameters.Add("@licNo", SqlDbType.VarChar, 20, "licNo");
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 20, "email");
            //add command to DataAdapter
            da.InsertCommand = cmd;

            //create Update command for dataadapter
            sql = "UPDATE [Customer] SET [cname] = @cname, [address] = @address, [phone] = @phone" +
                  ", [licNo] = @licNo, [email] = @email  WHERE [cname] = @origCname";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@cname", SqlDbType.VarChar, 20, "cname");
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50, "address");
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20, "phone");
            cmd.Parameters.Add("@licNo", SqlDbType.VarChar, 20, "licNo");
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 20, "email");
            SqlParameter param = cmd.Parameters.Add("@origCname", SqlDbType.VarChar, 20, "cname");
            param.SourceVersion = DataRowVersion.Original;
            //add command to DataAdapter
            da.UpdateCommand = cmd;

            //create DELETE command for dataadapter
            sql = "DELETE FROM [Customer] WHERE [cname] = @origCname";
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@origCname", SqlDbType.VarChar, 20, "cname").SourceVersion = DataRowVersion.Original;
            //add command to dataadapter
            da.DeleteCommand = cmd;

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

        private void txtCusLicNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCusPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////name
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCusEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //email
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && e.KeyChar != 64 && e.KeyChar != 46)
            {
                e.Handled = true;
            } 
        }
    }
}
