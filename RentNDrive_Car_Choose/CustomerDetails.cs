using RentNDrive_Car_Choose.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class CustomerDetails : Form
    {
        private string username;

        public CustomerDetails(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCarBrands();
        }

        private void LoadCarBrands()
        {
            string query = "SELECT DISTINCT Brand FROM Cars";
            DataTable dt = DBHelper.ExecuteSelectCommand(query);

            cmbCarBrand.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbCarBrand.Items.Add(row["Brand"].ToString());
            }
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = cmbCarBrand.SelectedItem.ToString();
            string query = "SELECT Model FROM Cars WHERE Brand=@brand";
            SqlParameter[] parameters = { new SqlParameter("@brand", selectedBrand) };

            DataTable dt = DBHelper.ExecuteSelectCommand(query, parameters);

            cmbCarModel.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbCarModel.Items.Add(row["Model"].ToString());
            }

            pictureBoxCar.Image = null;
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = cmbCarModel.SelectedItem.ToString();
            string imageFileName = selectedModel + ".jpeg";
            string imagePath = Path.Combine(Application.StartupPath, "Resources", imageFileName);

            if (File.Exists(imagePath))
            {
                pictureBoxCar.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxCar.Image = null;
                MessageBox.Show("Image not found: " + imageFileName);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbCarModel.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            string model = cmbCarModel.SelectedItem.ToString();
            int duration = (int)numDuration.Value;

            string query = "SELECT Rate FROM Cars WHERE Model=@model";
            SqlParameter[] param = { new SqlParameter("@model", model) };

            object rateObj = DBHelper.ExecuteScalar(query, param);
            if (rateObj == null)
            {
                MessageBox.Show("Rate not found.");
                return;
            }

            decimal rate = Convert.ToDecimal(rateObj);
            decimal totalPrice = rate * duration;

            PAYMENT_PAGE payPage = new PAYMENT_PAGE(
                txtName.Text.Trim(),
                txtIC.Text.Trim(),
                txtLicense.Text.Trim(),
                txtAddress.Text.Trim(),
                cmbCarBrand.SelectedItem.ToString(),
                model,
                duration,
                totalPrice
            );

            payPage.Show();
            this.Hide();
        }

        private void CustomerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
