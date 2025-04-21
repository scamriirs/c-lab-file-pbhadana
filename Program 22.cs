using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentDatabaseApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students WHERE RegistrationNo = @regNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", regNo);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtAge.Text = reader["Age"].ToString();
                        txtClass.Text = reader["Class"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found!");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
