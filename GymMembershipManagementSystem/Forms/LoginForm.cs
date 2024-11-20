using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MaskedUserNameText();
            MaskedUserPasswordText();
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
        }
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();  
            }
        }
        private void MaskedUserNameText()
        {
            textBoxUserName.ForeColor = Color.Gray;
            SetPlaceholder(textBoxUserName, "Username");
            textBoxUserName.KeyPress += MaskingMethods.ValidateNameInput;
        }
        public void MaskedUserPasswordText()
        {
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.UseSystemPasswordChar = false; // Initially not masked
            textBoxPassword.Text = "Password"; // Set placeholder text initially

            // Attach events to handle placeholder behavior
            textBoxPassword.Enter += (sender, e) =>
            {
                if (textBoxPassword.Text == "Password")
                {
                    textBoxPassword.Text = ""; // Clear placeholder on focus
                    textBoxPassword.ForeColor = Color.Black;
                    textBoxPassword.UseSystemPasswordChar = true; // Mask when focused
                }
            };

            textBoxPassword.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    textBoxPassword.UseSystemPasswordChar = false; // Unmask when empty
                    textBoxPassword.Text = "Password"; // Restore placeholder
                    textBoxPassword.ForeColor = Color.Gray;
                }
            };

        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (sender, e) => MaskingMethods.RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => MaskingMethods.AddPlaceholder(textBox, placeholder);
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "Password")
            {
                textBoxPassword.UseSystemPasswordChar = !checkBoxPassword.Checked;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            String querry = "SELECT COUNT(*) FROM LoginForm WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Hello User!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Error in Login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
