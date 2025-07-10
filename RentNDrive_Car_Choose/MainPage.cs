using System;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class MainPage : Form
    {
        private string username;

        public MainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username + "!";
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            CustomerDetails form = new CustomerDetails(username);
            form.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
