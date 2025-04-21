using System;
using System.Data;
using MySql.Data.MySqlClient;

public partial class ViewStudents : System.Web.UI.Page
{
    string connectionString = "server=localhost;database=yourdbname;uid=root;pwd=yourpassword;";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadStudentData();
        }
    }

    private void LoadStudentData()
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            string query = "SELECT reg_no AS 'Reg No', name AS 'Name', age AS 'Age', class AS 'Class', email AS 'Email' FROM students";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                // Optional: handle exception
            }
        }
    }
}
