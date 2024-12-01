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
    public partial class UpdateMember : Form
    {
        private SqlConnection sqlConnection;
        private int memberId;
        private string memberType;
        public UpdateMember(int memberId, string memberType)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.memberType = memberType;
            InitializeDatabaseConnection();
            LoadMemberDetails();
            MaskedFirstNameText();
            MaskedLastNameText();
            MaskedAddressText();
            MaskedAgeText();
            MaskedMobileNumber();
            MaskedEmail();
            MaskedGuardianFullName();
            MaskedGuardianMobileNumber();
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

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void LoadMemberDetails()
        {
            string query = "";

            if (memberType == "Regular")
            {
                query = @"
            SELECT RegularMemberId, FirstName, LastName, DateOfBirth, Age, Gender, Address, MobileNumber, Email, EmergencyContactName, EmergencyContactPhone, DateJoined, ProfileImage, MembershipStartDate, MembershipFee, MembershipEndDate
            FROM RegularMember
            WHERE RegularMemberId = @MemberId";
            }
            else if (memberType == "Student")
            {
                query = @"
            SELECT StudentId, FirstName, LastName, DateOfBirth, Age, Gender, Address, MobileNumber, Email, EmergencyContactName, EmergencyContactPhone, DateJoined, ProfileImage, MembershipStartDate, MembershipFee, MembershipEndDate
            FROM StudentMember
            WHERE StudentId = @MemberId";
            }

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@MemberId", memberId);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                textBoxFirstName.Text = row["FirstName"].ToString();
                textBoxLastName.Text = row["LastName"].ToString();
                dateTimePickerDOB.Value = Convert.ToDateTime(row["DateOfBirth"]);
                textBoxAge.Text = row["Age"].ToString();
                radioButtonMale.Checked = row["Gender"].ToString() == "Male";
                radioButtonFemale.Checked = row["Gender"].ToString() == "Female";
                textBoxAddress.Text = row["Address"].ToString();
                textBoxMobileNumber.Text = row["MobileNumber"].ToString();
                textBoxEmail.Text = row["Email"].ToString();
                textBoxGuardianFullName.Text = row["EmergencyContactName"].ToString();
                textBoxGuardianNumber.Text = row["EmergencyContactPhone"].ToString();

                // Convert image if it exists
                if (row["ProfileImage"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["ProfileImage"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxMember.Image = Image.FromStream(ms);
                    }
                }
            }

            // Hide the update button based on member type
            if (memberType == "Regular")
            {
                buttonUpdateRegular.Visible = true;
                buttonUpdateStudent.Visible = false;
            }
            else if (memberType == "Student")
            {
                buttonUpdateRegular.Visible = false;
                buttonUpdateStudent.Visible = true;
            }
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
        private void MaskedAgeText()
        {
            textBoxAge.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxAge, "Age");
            textBoxAge.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxAge.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxAge, "Age");
            textBoxAge.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxAge, "Age");
        }
        private void MaskedMobileNumber()
        {
            textBoxMobileNumber.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxMobileNumber, "Mobile Number");
            textBoxMobileNumber.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxMobileNumber.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxMobileNumber, "Mobile Number");
            textBoxMobileNumber.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxMobileNumber, "Mobile Number");
        }
        private void MaskedEmail()
        {
            textBoxEmail.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxEmail, "Email");
            textBoxEmail.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxEmail.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxEmail, "Email");
            textBoxEmail.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxEmail, "Email");
        }
        private void MaskedGuardianFullName()
        {
            textBoxGuardianFullName.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxGuardianFullName, "Full Name");
            textBoxGuardianFullName.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxGuardianFullName.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxGuardianFullName, "Full Name");
            textBoxGuardianFullName.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxGuardianFullName, "Full Name");
        }
        private void MaskedGuardianMobileNumber()
        {
            textBoxGuardianNumber.ForeColor = Color.Gray;
            // Use Singleton Pattern for placeholder management
            MaskingMethod.Instance.AddPlaceholder(textBoxGuardianNumber, "Mobile Number");
            textBoxGuardianNumber.KeyPress += MaskingMethod.Instance.ValidateNameInput;
            textBoxGuardianNumber.Enter += (sender, e) => MaskingMethod.Instance.RemovePlaceholder(textBoxGuardianNumber, "Mobile Number");
            textBoxGuardianNumber.Leave += (sender, e) => MaskingMethod.Instance.AddPlaceholder(textBoxGuardianNumber, "Mobile Number");
        }


        private void pictureBoxMember_Click(object sender, EventArgs e)
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

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string dateOfBirth = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
            int age = int.Parse(textBoxAge.Text);
            string gender = radioButtonMale.Checked ? "Male" : "Female";
            string address = textBoxAddress.Text;
            string mobileNumber = textBoxMobileNumber.Text;
            string email = textBoxEmail.Text;
            string guardianName = textBoxGuardianFullName.Text;
            string guardianNumber = textBoxGuardianNumber.Text;

            // SQL query for updating Student Member
            string updateQuery = @"
        UPDATE StudentMember 
        SET FirstName = @FirstName,
            LastName = @LastName,
            DateOfBirth = @DateOfBirth,
            Age = @Age,
            Gender = @Gender,
            Address = @Address,
            MobileNumber = @MobileNumber,
            Email = @Email,
            EmergencyContactName = @GuardianName,
            EmergencyContactPhone = @GuardianNumber
        WHERE StudentId = @MemberId";

            SqlCommand command = new SqlCommand(updateQuery, sqlConnection);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@GuardianName", guardianName);
            command.Parameters.AddWithValue("@GuardianNumber", guardianNumber);
            command.Parameters.AddWithValue("@MemberId", memberId);

            try
            {
                sqlConnection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student member details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Student member details not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void buttonUpdateRegular_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string dateOfBirth = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
            int age = int.Parse(textBoxAge.Text);
            string gender = radioButtonMale.Checked ? "Male" : "Female";
            string address = textBoxAddress.Text;
            string mobileNumber = textBoxMobileNumber.Text;
            string email = textBoxEmail.Text;
            string guardianName = textBoxGuardianFullName.Text;
            string guardianNumber = textBoxGuardianNumber.Text;

            // SQL query for updating Regular Member
            string updateQuery = @"
        UPDATE RegularMember 
            SET FirstName = @FirstName,
            LastName = @LastName,
            DateOfBirth = @DateOfBirth,
            Age = @Age,
            Gender = @Gender,
            Address = @Address,
            MobileNumber = @MobileNumber,
            Email = @Email,
            EmergencyContactName = @GuardianName,
            EmergencyContactPhone = @GuardianNumber
            WHERE RegularMemberId = @MemberId";

            SqlCommand command = new SqlCommand(updateQuery, sqlConnection);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@GuardianName", guardianName);
            command.Parameters.AddWithValue("@GuardianNumber", guardianNumber);
            command.Parameters.AddWithValue("@MemberId", memberId);

            try
            {
                sqlConnection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Member details not updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
