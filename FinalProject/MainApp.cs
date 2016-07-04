using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class MainApp : Form
    {
        private Thread th;

        public MainApp()
        {
            InitializeComponent();
        }

        private void cmdReservation_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformReserv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void opennewformReserv(object obj)
        {
            Application.Run(new ReserCarList());
        }

        private void cmdRentalAgreement_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformRental);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewformRental(object obj)
        {
            Application.Run(new RentalAgreement());
        }

        private void cmdInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformInvoice);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();   
        }

        private void opennewformInvoice(object obj)
        {
            Application.Run(new InvList());
        }

        private void cmdCarList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformCarInfo);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();  
        }

        private void opennewformCarInfo(object obj)
        {
            Application.Run(new CarInfo());
        }

        private void cmdCustomerList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformCustInfo);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();         
        }

        private void opennewformCustInfo(object obj)
        {
            Application.Run(new CustomerInfo());
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAgreementList_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformAgreementList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();   
        }

        private void opennewformAgreementList(object obj)
        {
            Application.Run(new AgreementDetail());
        }
    }
}
