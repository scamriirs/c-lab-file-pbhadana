// Default.aspx.cs
using System;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    string connectionString = "server=localhost;database=yourdbname;uid=root;pwd=yourpassword;";

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string regNo = txtRegNo.Text.Trim();
        string name = txtName.Text.Trim();
        int age = int.Parse(txtAge.Text);
        string sclass = txtClass.Text.Trim();
        string email = txtEmail.Text.Trim();

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            string query = "INSERT INTO students (reg_no, name, age, class, email) VALUES (@reg, @name, @age, @class, @email)";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@reg", regNo);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@class", sclass);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Student data saved successfully!";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Error: " + ex.Message;
            }
        }
    }
}
