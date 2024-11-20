using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class NewMemberForm : Form
    {
        private SqlConnection sqlConnection;
        private const decimal MembershipFee = 350;
        public NewMemberForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            MaskedFirstNameText();
            MaskedLastNameText();
            MaskedAddressText();
        }

        private void MaskedAddressText()
        {
            textBoxAddress.Text = "Address";
            textBoxAddress.ForeColor = Color.Gray;
            SetPlaceholder(textBoxAddress, "Address");
            textBoxAddress.KeyPress += MaskingMethods.ValidateNameInput;
        }
        private void MaskedFirstNameText()
        {
            textBoxFirstName.ForeColor = Color.Gray;
            SetPlaceholder(textBoxFirstName, "First name");
            textBoxFirstName.KeyPress += MaskingMethods.ValidateNameInput;
        }
        private void MaskedLastNameText()
        {
            textBoxLastName.ForeColor = Color.Gray;
            SetPlaceholder(textBoxLastName, "Last name");
            textBoxLastName.KeyPress += MaskingMethods.ValidateNameInput;
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (sender, e) => MaskingMethods.RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => MaskingMethods.AddPlaceholder(textBox, placeholder);
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxMobileNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxGuardianFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGuardianNumber.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string firstname = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
                string dateofbirth = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
                int age = int.Parse(textBoxAge.Text);
                string homeaddress = textBoxAddress.Text;
                string gender = radioButtonMale.Checked ? "Male" : "Female";
                string mobileNumber = textBoxMobileNumber.Text;
                string email = textBoxEmail.Text;
                string guardianname = textBoxGuardianFullName.Text;
                string guardiannumber = textBoxGuardianNumber.Text;
                string datejoined = dateTimePickerJoinedDate.Value.ToString("yyyy-MM-dd");
                DateTime startDate = dateTimePickerJoinedDate.Value;
                DateTime expirationDate = startDate.AddDays(31); // Add 31 days for membership

                byte[] imageBytes = ConvertImageToByteArray(pictureBoxMember.Image);

                string query = "INSERT INTO StudentMember (FirstName, LastName, DateOfBirth, Age, Gender, Address, MobileNumber, Email, EmergencyContactName, EmergencyContactPhone, DateJoined, ProfileImage, MembershipStartDate, MembershipFee, MembershipEndDate) " +
                               "VALUES (@FirstName, @LastName, @DateOfBirth, @Age, @Gender, @Address, @MobileNumber, @Email, @EmergencyContactName, @EmergencyContactPhone, @DateJoined, @ProfileImage, @MembershipStartDate, @MembershipFee, @MembershipEndDate)";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Address", homeaddress);
                    command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@EmergencyContactName", guardianname);
                    command.Parameters.AddWithValue("@EmergencyContactPhone", guardiannumber);
                    command.Parameters.AddWithValue("@DateJoined", datejoined);
                    command.Parameters.AddWithValue("@ProfileImage", imageBytes);
                    command.Parameters.AddWithValue("@MembershipStartDate", startDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@MembershipFee", MembershipFee);
                    command.Parameters.AddWithValue("@MembershipEndDate", expirationDate.ToString("yyyy-MM-dd"));

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFormFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
            textBoxMobileNumber.Clear();
            textBoxAge.Clear();
            textBoxGuardianFullName.Clear();
            textBoxGuardianNumber.Clear();
            pictureBoxMember.Image = null;
            dateTimePickerJoinedDate.Value = DateTime.Now; // Reset the DateTimePicker to current date
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void buttonBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMember.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
