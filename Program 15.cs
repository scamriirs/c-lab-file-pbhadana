using System;
using System.Windows.Forms;
using System.Xml;

namespace XMLFileHandling
{
    public class ReadOnlyForm : Form
    {
        TextBox txtRegNo, txtName, txtAge, txtClass, txtGender, txtAddress;
        Button btnLoadXML;

        public ReadOnlyForm()
        {
            // Form properties
            this.Text = "XML Reader Form";
            this.Size = new System.Drawing.Size(300, 300);

            // Create Labels and Read-Only TextBoxes
            Label lblRegNo = new Label() { Text = "Reg No:", Left = 10, Top = 20 };
            txtRegNo = new TextBox() { Left = 100, Top = 20, Width = 150, ReadOnly = true };

            Label lblName = new Label() { Text = "Name:", Left = 10, Top = 50 };
            txtName = new TextBox() { Left = 100, Top = 50, Width = 150, ReadOnly = true };

            Label lblAge = new Label() { Text = "Age:", Left = 10, Top = 80 };
            txtAge = new TextBox() { Left = 100, Top = 80, Width = 150, ReadOnly = true };

            Label lblClass = new Label() { Text = "Class:", Left = 10, Top = 110 };
            txtClass = new TextBox() { Left = 100, Top = 110, Width = 150, ReadOnly = true };

            Label lblGender = new Label() { Text = "Gender:", Left = 10, Top = 140 };
            txtGender = new TextBox() { Left = 100, Top = 140, Width = 150, ReadOnly = true };

            Label lblAddress = new Label() { Text = "Address:", Left = 10, Top = 170 };
            txtAddress = new TextBox() { Left = 100, Top = 170, Width = 150, ReadOnly = true };

            // Load XML Button
            btnLoadXML = new Button() { Text = "Load XML", Left = 100, Top = 210 };
            btnLoadXML.Click += new EventHandler(BtnLoadXML_Click);

            // Add Controls to Form
            this.Controls.Add(lblRegNo); this.Controls.Add(txtRegNo);
            this.Controls.Add(lblName); this.Controls.Add(txtName);
            this.Controls.Add(lblAge); this.Controls.Add(txtAge);
            this.Controls.Add(lblClass); this.Controls.Add(txtClass);
            this.Controls.Add(lblGender); this.Controls.Add(txtGender);
            this.Controls.Add(lblAddress); this.Controls.Add(txtAddress);
            this.Controls.Add(btnLoadXML);
        }

        private void BtnLoadXML_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("student.xml"); // XML File

            // Read data and set textboxes
            txtRegNo.Text = xmlDoc.SelectSingleNode("//RegistrationNo")?.InnerText;
            txtName.Text = xmlDoc.SelectSingleNode("//Name")?.InnerText;
            txtAge.Text = xmlDoc.SelectSingleNode("//Age")?.InnerText;
            txtClass.Text = xmlDoc.SelectSingleNode("//Class")?.InnerText;
            txtGender.Text = xmlDoc.SelectSingleNode("//Gender")?.InnerText;
            txtAddress.Text = xmlDoc.SelectSingleNode("//Address")?.InnerText;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new ReadOnlyForm());
        }
    }
}
