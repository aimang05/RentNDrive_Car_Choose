using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class PAYMENT_PAGE : Form
    {
        private string customerName, icNumber, licenseId, address;
        private string brand, model;
        private int duration;
        private decimal totalPrice;

        public PAYMENT_PAGE(
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

            this.customerName = customerName;
            this.icNumber = icNumber;
            this.licenseId = licenseId;
            this.address = address;
            this.brand = brand;
            this.model = model;
            this.duration = duration;
            this.totalPrice = totalPrice;

            DisplaySummary();
        }

        private void PAYMENT_PAGE_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.SelectedIndex = 0; // default to first option
        }

        private void DisplaySummary()
        {
            lblCustomer.Text = $"Name: {customerName}\nIC: {icNumber}\nLicense: {licenseId}\nAddress: {address}";
            lblCar.Text = $"Car: {brand} {model}\nDuration: {duration} day(s)";
            lblPrice.Text = $"Total Price: RM {totalPrice:0.00}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            string query = @"INSERT INTO Bookings 
                (CustomerName, ICNumber, LicenseId, Address, CarBrand, CarModel, Duration, TotalPrice, PaymentMethod) 
                VALUES 
                (@CustomerName, @IC, @License, @Address, @Brand, @Model, @Duration, @TotalPrice, @PaymentMethod)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerName", customerName),
                new SqlParameter("@IC", icNumber),
                new SqlParameter("@License", licenseId),
                new SqlParameter("@Address", address),
                new SqlParameter("@Brand", brand),
                new SqlParameter("@Model", model),
                new SqlParameter("@Duration", duration),
                new SqlParameter("@TotalPrice", totalPrice),
                new SqlParameter("@PaymentMethod", paymentMethod)
            };

            bool success = DBHelper.ExecuteNonQuery(query, parameters);

            if (success)
            {
                MessageBox.Show("Booking Confirmed!");

                ReceiptPage receipt = new ReceiptPage(
                    customerName, icNumber, licenseId, address,
                    brand, model, duration, totalPrice
                );

                receipt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Booking Failed.");
            }
        }

        private void PAYMENT_PAGE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
