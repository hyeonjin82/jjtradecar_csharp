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
    public partial class CarInfo : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\C#class\\FinalProject\\FinalProject\\FinalProject\\RentCar.mdf;Integrated Security=True");
        private SqlDataAdapter da = null;
        private DataSet ds = null;
        private int rowIndex = -1;
        private Thread th;

        public CarInfo()
        {
            InitializeComponent();
        }

        private void CarInfo_Load(object sender, EventArgs e)
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
            txtCarVin.Text = dg1.CurrentRow.Cells[0].Value.ToString();
            txtCarMake.Text = dg1.CurrentRow.Cells[1].Value.ToString();
            txtCarModel.Text = dg1.CurrentRow.Cells[2].Value.ToString();
            txtCarOdometer.Text = dg1.CurrentRow.Cells[3].Value.ToString();
            txtCarType.Text = dg1.CurrentRow.Cells[4].Value.ToString();
            txtCarYear.Text = dg1.CurrentRow.Cells[5].Value.ToString();
            carStatusLabel.Text = "rowIndex = " + rowIndex;
            carStatusLabel.Text = "Row State =" + ds.Tables[0].Rows[rowIndex].RowState;
            setControlState("u/d");

        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                if (isValidAccount("i"))
                {
                    DataRow dr = ds.Tables["Car"].NewRow();
                    dr["vin"] = txtCarVin.Text;
                    dr["make"] = txtCarMake.Text;
                    dr["model"] = txtCarModel.Text;
                    dr["odometer"] = Convert.ToString(txtCarOdometer.Text);
                    dr["type"] = txtCarType.Text;
                    dr["year"] = txtCarYear.Text;
                    ds.Tables[0].Rows.Add(dr);
                    clearText();
                }
            }
            updateDB();
        }

        private void clearText()
        {
            txtCarVin.Text= "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtCarOdometer.Text = "";
            txtCarType.Text = "";
            txtCarYear.Text = "";
            txtCarVin.Focus();
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
                    if (txtCarVin.Text.Equals(dg1.CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Is valid account?", "Confirm Record Insert",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCarVin.Focus();
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
                        if (txtCarVin.Text.Equals(dg1.Rows[i].Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Is valid account?", "Confirm Record Update ",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCarVin.Focus();
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
                    dr["vin"] = txtCarVin.Text;
                    dr["make"] = txtCarMake.Text;
                    dr["model"] = txtCarModel.Text;
                    dr["odometer"] = txtCarOdometer.Text;
                    dr["type"] = txtCarType.Text;
                    dr["year"] = txtCarYear.Text;
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
                ds.Tables["Car"].Rows[rowIndex].Delete();
            }
            setControlState("i");
            updateDB();
        }

        private void updateDB()
        {
            try
            {
                conn.Open();
                int updatedRows = da.Update(ds, "Car");
                carStatusLabel.Text = "Updated Rows = " + updatedRows;
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
                string sql = "SELECT * FROM [Car]";
                da = new SqlDataAdapter(sql, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                createCommands();
                ds = new DataSet();
                da.Fill(ds, "Car");
                conn.Close();
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "Car";
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
            String sql = "INSERT INTO [Car] ([vin],[make],[model],[odometer],[type],[year]) " +
                         "VALUES (@vin,@make,@model,@odometer,@type,@year)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@vin", SqlDbType.VarChar, 20, "vin");
            cmd.Parameters.Add("@make", SqlDbType.VarChar, 20, "make");
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 20, "model");
            cmd.Parameters.Add("@odometer", SqlDbType.Int, 8, "odometer");
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 20, "type");
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 20, "year");
            //add command to DataAdapter
            da.InsertCommand = cmd;

            //create Update command for dataadapter
            sql = "UPDATE [Car] SET [vin] = @vin, [make] = @make, [model] = @model" +
                  ", [odometer] = @odometer, [type] = @type, [year] = @year  WHERE [vin] = @origVin";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@vin", SqlDbType.VarChar, 20, "vin");
            cmd.Parameters.Add("@make", SqlDbType.VarChar, 20, "make");
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 20, "model");
            cmd.Parameters.Add("@odometer", SqlDbType.Int, 8, "odometer");
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 20, "type");
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 20, "year");
            SqlParameter param = cmd.Parameters.Add("@origVin", SqlDbType.VarChar, 20, "vin");
            param.SourceVersion = DataRowVersion.Original;
            //add command to DataAdapter
            da.UpdateCommand = cmd;

            //create DELETE command for dataadapter
            sql = "DELETE FROM [Car] WHERE [vin] = @origVin";
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@origVin", SqlDbType.VarChar, 20, "vin").SourceVersion = DataRowVersion.Original;
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

        private void txtCarYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCarYear.Text.Length > 3 && (!char.IsControl(e.KeyChar))) { e.Handled = true; }
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                 e.Handled = true; 
            }
        }
        private void txtCarOdometer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        
    }
}
