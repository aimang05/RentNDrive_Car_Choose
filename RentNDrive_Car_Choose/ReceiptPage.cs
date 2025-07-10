using System;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class ReceiptPage : Form
    {
        public ReceiptPage(
            string customerName,
            string icNumber,
            string licenseId,
            string address,
            string brand,
            string model,
            int duration,
            decimal totalPrice)
        {
            InitializeComponent();

            txtReceipt.Text =
$@"====== RentNDrive Receipt ======

Customer Name : {customerName}
IC Number     : {icNumber}
License ID    : {licenseId}
Address       : {address}

Car Brand     : {brand}
Car Model     : {model}
Duration      : {duration} day(s)
Rate Total    : RM {totalPrice:0.00}

Thank you for choosing RentNDrive!
Have a safe journey!";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
