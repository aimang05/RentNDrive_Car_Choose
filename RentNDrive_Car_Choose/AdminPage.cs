using System;
using System.Data;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            string query = "SELECT * FROM Bookings ORDER BY Id DESC";
            DataTable dt = DBHelper.ExecuteSelectCommand(query);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to load bookings.");
            }
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
