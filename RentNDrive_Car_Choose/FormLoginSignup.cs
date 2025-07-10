using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public partial class FormLoginSignup : Form
    {
        public FormLoginSignup()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            object result = DBHelper.ExecuteScalar(query, parameters);

            if (result != null && Convert.ToInt32(result) > 0)
            {
                MainPage main = new MainPage(username);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username";
            SqlParameter[] checkParams = { new SqlParameter("@username", username) };
            object exists = DBHelper.ExecuteScalar(checkQuery, checkParams);

            if (Convert.ToInt32(exists) > 0)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
            SqlParameter[] insertParams =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            if (DBHelper.ExecuteNonQuery(insertQuery, insertParams))
            {
                MessageBox.Show("Signup successful. Please login.");
            }
            else
            {
                MessageBox.Show("Signup failed.");
            }
        }

        private void FormLoginSignup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLoginSignup_Load(object sender, EventArgs e)
        {

        }
    }
}
