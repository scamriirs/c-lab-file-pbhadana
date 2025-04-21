using System;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieving entered details
            string regNo = txtRegNo.Text;
            string name = txtName.Text;
            string age = txtAge.Text;
            string studentClass = txtClass.Text;
            string gender = cmbGender.SelectedItem.ToString();
            string address = txtAddress.Text;

            // Displaying the entered data
            MessageBox.Show($"Registration Successful!\n\n" +
                            $"Registration No: {regNo}\n" +
                            $"Name: {name}\n" +
                            $"Age: {age}\n" +
                            $"Class: {studentClass}\n" +
                            $"Gender: {gender}\n" +
                            $"Address: {address}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
