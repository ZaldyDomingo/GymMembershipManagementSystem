using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class ViewAllMember : Form
    {
        private SqlConnection sqlConnection;
        public ViewAllMember()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadAllMembers(); 
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                sqlConnection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database connection: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllMembers()
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT [FirstName], [LastName], [Address], [Email], [MobileNumber], [EmergencyContactPhone], [ProfileImage]
                FROM [dbo].[Students]
                UNION ALL
                SELECT [FirstName], [LastName], [Address], [Email], [MobileNumber], [EmergencyContactPhone], [ProfileImage]
                FROM [dbo].[NotStudentMember]";

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable); // Fill the DataTable with combined data
                    }
                }

                // Bind the combined data to the DataGridView
                dataGridViewAll.DataSource = dataTable;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error while loading data: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show($"Invalid operation: {invEx.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close(); // Ensure connection is closed
                }
            }
        }
    }
}