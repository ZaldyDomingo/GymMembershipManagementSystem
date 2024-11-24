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
    public partial class ViewStudentMember : Form
    {
        private SqlConnection sqlConnection;

        public ViewStudentMember()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeSearchTimer();
            LoadStudents();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dataGridViewStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewStudent.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewStudent.RowTemplate.Height = 28;
            dataGridViewStudent.ColumnHeadersHeight = 28;

            // Add TextChanged event for the search functionality
            textBoxSearchMember.TextChanged += (sender, e) =>
            {
                searchTimer.Stop();
                searchTimer.Start();  // This ensures a delay before applying the filter
            };
        }
        private void InitializeSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 500; // 500ms delay
            searchTimer.Tick += searchTimer_Tick;
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void LoadStudents()
        {
            try
            {
                // SQL query to get all necessary student information
                string query = "SELECT [StudentId], [FirstName], [LastName], [DateOfBirth], [Age], [Gender], [Address], [MobileNumber], [Email], [EmergencyContactName], [EmergencyContactPhone], [DateJoined], [ProfileImage], [MembershipStartDate], [MembershipFee], [MembershipEndDate] FROM [dbo].[StudentMember]";
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                // Add columns for additional data if needed (e.g., RemainingDays)
                dataTable.Columns.Add("RemainingDays", typeof(int));

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime membershipStartDate = Convert.ToDateTime(row["MembershipStartDate"]);
                    DateTime expirationDate = membershipStartDate.AddDays(31); 
                    int remainingDays = (expirationDate - DateTime.Now).Days;

                    if (remainingDays <= 0)
                    {
                        row.Delete(); 
                    }
                    else
                    {
                        row["RemainingDays"] = remainingDays; 
                    }
                }

                dataTable.AcceptChanges();

                
                dataGridViewStudent.DataSource = dataTable;

                dataGridViewStudent.Columns["StudentId"].Visible = false; 
                dataGridViewStudent.Columns["Age"].Visible = false; 
                dataGridViewStudent.Columns["ProfileImage"].Visible = false; 
                dataGridViewStudent.Columns["DateOfBirth"].Visible = false; 
                dataGridViewStudent.Columns["Address"].Visible = false; 
                dataGridViewStudent.Columns["Gender"].Visible = false;
                dataGridViewStudent.Columns["DateJoined"].Visible = false;
                dataGridViewStudent.Columns["EmergencyContactName"].Visible = false;
                dataGridViewStudent.Columns["MembershipFee"].Visible = false;
                dataGridViewStudent.Columns["Email"].Visible = false; 
                dataGridViewStudent.Columns["MembershipEndDate"].Visible = false; 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure it's not the header row
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridViewStudent.Rows[e.RowIndex];

                    // Retrieve only firstName and lastName now
                    string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                    string lastName = selectedRow.Cells["LastName"].Value.ToString();

                    // Open the MemberDetailsForm with just the firstName and lastName
                    MemberDetailsForm detailsForm = new MemberDetailsForm(firstName, lastName);
                    detailsForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterData()
        {
            string searchTerm = textBoxSearchMember.Text.ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadStudents();
                return;
            }

            try
            {
                DataTable dataTable = ((DataTable)dataGridViewStudent.DataSource).Copy();

                var filteredRows = dataTable.AsEnumerable()
                    .Where(row => row["FirstName"].ToString().ToLower().Contains(searchTerm) ||
                                  row["LastName"].ToString().ToLower().Contains(searchTerm) ||
                                  row["MobileNumber"].ToString().ToLower().Contains(searchTerm)).ToList();

                DataTable filteredDataTable = dataTable.Clone();

                // Add matching rows first
                foreach (var row in filteredRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Add remaining non-matching rows
                var remainingRows = dataTable.AsEnumerable()
                    .Where(row => !filteredRows.Contains(row)).ToList();

                foreach (var row in remainingRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Bind the filtered data to the DataGridView
                dataGridViewStudent.DataSource = filteredDataTable;

                // Optionally hide unwanted columns
                dataGridViewStudent.Columns["MembershipStartDate"].Visible = false;
                dataGridViewStudent.Columns["ProfileImage"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            FilterData();
        }
    }
}