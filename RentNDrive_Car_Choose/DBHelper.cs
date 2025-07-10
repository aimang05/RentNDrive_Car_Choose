using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentNDrive_Car_Choose
{
    public class DBHelper
    {
        private static readonly string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);

            return connection;
        }

        public static DataTable ExecuteSelectCommand(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, GetConnection()))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }

            return dt;
        }

        public static bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, GetConnection()))
                {
                    if (GetConnection().State != ConnectionState.Open)
                        GetConnection().Open();

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                    GetConnection().Close();
            }
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, GetConnection()))
                {
                    if (GetConnection().State != ConnectionState.Open)
                        GetConnection().Open();

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                    GetConnection().Close();
            }
        }
    }
}
