using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class NewMemberNotStudent : Form
    {
        private SqlConnection sqlConnection;
        private const decimal MembershipFee = 400;
        public NewMemberNotStudent()
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
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxAddress, "Address");
            textBoxAddress.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxAddress.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxAddress, "Address");
            textBoxAddress.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxAddress, "Address");
        }

        private void MaskedFirstNameText()
        {
            textBoxFirstName.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxFirstName, "First name");
            textBoxFirstName.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxFirstName.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxFirstName, "First name");
            textBoxFirstName.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxFirstName, "First name");
        }

        private void MaskedLastNameText()
        {
            textBoxLastName.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxLastName, "Last name");
            textBoxLastName.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxLastName.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxLastName, "Last name");
            textBoxLastName.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxLastName, "Last name");
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (sender, e) => MaskingMethods.RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => MaskingMethods.AddPlaceholder(textBox, placeholder);
        }
        private void InitializeDatabaseConnection()
        {
            // Set up the connection string for your SQL Server database
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
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
                DateTime expirationDate = startDate.AddDays(31);

                byte[] imageBytes = ConvertImageToByteArray(pictureBoxMember.Image);

                // Update the table name to NewRegularMemberForm
                string query = "INSERT INTO RegularMember (FirstName, LastName, DateOfBirth, Age, Gender, Address, MobileNumber, Email, EmergencyContactName, EmergencyContactPhone, DateJoined, ProfileImage, MembershipStartDate, MembershipFee, MembershipEndDate) " +
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
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
