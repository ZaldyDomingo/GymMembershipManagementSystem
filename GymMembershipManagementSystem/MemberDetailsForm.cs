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
    public partial class MemberDetailsForm : Form
    {
        private const int MembershipDurationDays = 31;
        private DateTime checkInDate;
        public MemberDetailsForm(string firstName, string lastName)
        {
            InitializeComponent();

            checkInDate = DateTime.Now;
            PopulateMemberDetails(firstName, lastName);
        }
        private void PopulateMemberDetails(string firstName, string lastName)
        {
            try
            {
                // Get the member ID from the database
                int memberId = GetMemberIdFromDatabase(firstName, lastName);
                if (memberId == -1)
                {
                    MessageBox.Show("No member found with the provided details. Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch the full member details from both RegularMember and StudentMember tables
                DataRow memberDetails = GetMemberDetailsFromDatabase(memberId);

                if (memberDetails != null)
                {
                    // Populate all the fields dynamically with the fetched data
                    labelFirstName.Text = memberDetails["FirstName"].ToString();
                    labelLastName.Text = memberDetails["LastName"].ToString();
                    labelMobileNumber.Text = memberDetails["MobileNumber"].ToString();
                    labelEmergencyContactPhone.Text = memberDetails["EmergencyContactPhone"].ToString();
                    labelEmail.Text = memberDetails["Email"].ToString();
                    labelAge.Text = memberDetails["Age"].ToString();
                    labelGender.Text = memberDetails["Gender"].ToString();
                    labelAddress.Text = memberDetails["Address"].ToString();
                    labelDateOfBirth.Text = Convert.ToDateTime(memberDetails["DateOfBirth"]).ToString("yyyy-MM-dd");
                    labelDateJoined.Text = Convert.ToDateTime(memberDetails["DateJoined"]).ToString("yyyy-MM-dd");

                    // Handle Profile Image
                    byte[] profileImage = memberDetails["ProfileImage"] as byte[];
                    if (profileImage != null && profileImage.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(profileImage))
                        {
                            pictureBoxProfileImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxProfileImage.Image = null;
                    }

                    // Calculate and display the remaining membership time
                    DateTime? expirationDate = GetMembershipExpirationDate(memberId);
                    if (expirationDate.HasValue)
                    {
                        TimeSpan remainingDays = expirationDate.Value - DateTime.Now;
                        labelMemberTimeRemaining.Text = $"{remainingDays.Days} day(s) remaining";
                    }
                    else
                    {
                        labelMemberTimeRemaining.Text = "Membership Expired";
                    }
                }
                else
                {
                    MessageBox.Show("No details available for this member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while populating member details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetMemberIdFromDatabase(string firstName, string lastName)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = @"
                    SELECT RegularMemberId AS MemberId
                    FROM RegularMember
                    WHERE UPPER(FirstName) = @FirstName AND UPPER(LastName) = @LastName
                    UNION
                    SELECT StudentId AS MemberId
                    FROM StudentMember
                    WHERE UPPER(FirstName) = @FirstName AND UPPER(LastName) = @LastName";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@FirstName", firstName.ToUpper());
                command.Parameters.AddWithValue("@LastName", lastName.ToUpper());

                try
                {
                    sqlConnection.Open();
                    var result = command.ExecuteScalar();
                    sqlConnection.Close();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);  // Return the member ID
                    }
                    else
                    {
                        return -1;  // Member not found
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }
        private DataRow GetMemberDetailsFromDatabase(int memberId)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = @"
                    SELECT FirstName, LastName, MobileNumber, EmergencyContactPhone, Email, Age, Gender, Address, DateOfBirth, DateJoined, ProfileImage
                    FROM RegularMember
                    WHERE RegularMemberId = @MemberId
                    UNION
                    SELECT FirstName, LastName, MobileNumber, EmergencyContactPhone, Email, Age, Gender, Address, DateOfBirth, DateJoined, ProfileImage
                    FROM StudentMember
                    WHERE StudentId = @MemberId";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MemberId", memberId);

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable memberTable = new DataTable();
                    adapter.Fill(memberTable);

                    if (memberTable.Rows.Count > 0)
                    {
                        return memberTable.Rows[0];  // Return the first row (member details)
                    }
                    else
                    {
                        return null;  // No matching member found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching member details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private DateTime? GetMembershipExpirationDate(int memberId)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = @"
                    SELECT MembershipStartDate
                    FROM RegularMember
                    WHERE RegularMemberId = @MemberId
                    UNION
                    SELECT MembershipStartDate
                    FROM StudentMember
                    WHERE StudentId = @MemberId";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MemberId", memberId);

                try
                {
                    sqlConnection.Open();
                    var result = command.ExecuteScalar();
                    sqlConnection.Close();

                    if (result != null)
                    {
                        DateTime membershipStartDate = Convert.ToDateTime(result);
                        return membershipStartDate.AddDays(MembershipDurationDays);  // Add membership duration
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving membership expiration date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string firstName = labelFirstName.Text.Trim();
                    string lastName = labelLastName.Text.Trim();

                    // Check if first name and last name are not empty
                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    {
                        MessageBox.Show("First Name or Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get member ID from the database using the first and last name
                    int memberId = GetMemberIdFromDatabase(firstName, lastName);
                    if (memberId == -1)
                    {
                        MessageBox.Show("No member found with the provided details. Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Proceed with deleting the member from the database
                    bool isDeleted = DeleteMemberFromDatabase(memberId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Member successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();  // Close the form after successful deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the member. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool DeleteMemberFromDatabase(int memberId)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                try
                {
                    // SQL query to delete the member from RegularMember and StudentMember tables
                    string query = @"
                         DELETE FROM RegularMember WHERE RegularMemberId = @MemberId;
                         DELETE FROM StudentMember WHERE StudentId = @MemberId;";

                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@MemberId", memberId);

                    sqlConnection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    sqlConnection.Close();

                    // If rows affected is greater than 0, deletion was successful
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
