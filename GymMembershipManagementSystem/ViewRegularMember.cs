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
    public partial class ViewRegularMember : Form
    {
        private SqlConnection sqlConnection;
        public ViewRegularMember()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeSearchTimer();
            LoadRegularMembers();
            FilterData();
            SetupDataGridView();
            buttonCheck.Visible = false;
            buttonCancel.Visible = false;
            buttonMultiDelete.Visible = true;

            // Hook up button click events
            buttonMultiDelete.Click += buttonMultiDelete_Click;
            buttonCheck.Click += buttonCheck_Click;
            buttonCancel.Click += buttonCancel_Click;
            dataGridViewRegular.CellContentClick += dataGridViewRegular_CellContentClick;
        }
        private void SetupDataGridView()
        {
            dataGridViewRegular.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewRegular.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewRegular.RowTemplate.Height = 28;
            dataGridViewRegular.ColumnHeadersHeight = 28;
            dataGridViewRegular.EditMode = DataGridViewEditMode.EditOnEnter;

            // Add TextChanged event for the search functionality
            textBoxSearchMember.TextChanged += (sender, e) =>
            {
                searchTimer.Stop();
                searchTimer.Start();  // This ensures a delay before applying the filter
            };
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public void LoadRegularMembers()
        {
            try
            {
                // SQL query for RegularMember table
                string query = "SELECT [RegularMemberId], [FirstName], [LastName], [DateOfBirth], [Age], [Gender], [Address], [MobileNumber], [Email], [EmergencyContactName], [EmergencyContactPhone], [DateJoined], [ProfileImage], [MembershipStartDate], [MembershipFee], [MembershipEndDate] FROM [dbo].[RegularMember]";
                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                // Add column for Remaining Days
                dataTable.Columns.Add("RemainingDays", typeof(int));

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime membershipStartDate = Convert.ToDateTime(row["MembershipStartDate"]);
                    DateTime expirationDate = membershipStartDate.AddDays(31); // Assuming 31 days membership
                    int remainingDays = (expirationDate - DateTime.Now).Days;

                    if (remainingDays <= 0)
                    {
                        row.Delete(); // Remove expired members
                    }
                    else
                    {
                        row["RemainingDays"] = remainingDays;
                    }
                }

                dataTable.AcceptChanges();
                dataGridViewRegular.DataSource = dataTable;

                dataGridViewRegular.Columns["RegularMemberId"].Visible = false;
                dataGridViewRegular.Columns["Age"].Visible = false;
                dataGridViewRegular.Columns["DateOfBirth"].Visible = false;
                dataGridViewRegular.Columns["ProfileImage"].Visible = false;
                dataGridViewRegular.Columns["Address"].Visible = false;
                dataGridViewRegular.Columns["Gender"].Visible = false;
                dataGridViewRegular.Columns["DateJoined"].Visible = false;
                dataGridViewRegular.Columns["EmergencyContactName"].Visible = false;
                dataGridViewRegular.Columns["MembershipFee"].Visible = false;
                dataGridViewRegular.Columns["Email"].Visible = false;
                dataGridViewRegular.Columns["MembershipEndDate"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading regular member data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 500; // 500ms delay
            searchTimer.Tick += searchTimer_Tick;
        }

        private void FilterData()
        {
            string searchTerm = textBoxSearchMember.Text.ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadRegularMembers();
                return;
            }

            try
            {
                DataTable dataTable = ((DataTable)dataGridViewRegular.DataSource).Copy();

                var filteredRows = dataTable.AsEnumerable()
                    .Where(row => row["FirstName"].ToString().ToLower().Contains(searchTerm) ||
                                  row["LastName"].ToString().ToLower().Contains(searchTerm) ||
                                  row["MobileNumber"].ToString().ToLower().Contains(searchTerm)).ToList();

                DataTable filteredDataTable = dataTable.Clone();

                // Add matching rows to the filtered DataTable first
                foreach (var row in filteredRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Add remaining rows to the filtered DataTable after
                var remainingRows = dataTable.AsEnumerable()
                    .Where(row => !filteredRows.Contains(row)).ToList();

                foreach (var row in remainingRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Bind the filtered DataTable back to the DataGridView
                dataGridViewRegular.DataSource = filteredDataTable;

                // Optionally hide unwanted columns
                dataGridViewRegular.Columns["MembershipStartDate"].Visible = false;
                dataGridViewRegular.Columns["ProfileImage"].Visible = false;
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

        private void dataGridViewRegular_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridViewRegular.Rows[e.RowIndex];

                    // Get member details (only first name and last name are needed now)
                    string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                    string lastName = selectedRow.Cells["LastName"].Value.ToString();

                    // Open the MemberDetailsForm with only the first name and last name
                    MemberDetailsForm memberDetailsForm = new MemberDetailsForm(firstName, lastName);
                    memberDetailsForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening member details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ToggleMultiDeleteMode(bool isMultiDeleteMode)
        {
            buttonMultiDelete.Visible = !isMultiDeleteMode;
            buttonCheck.Visible = isMultiDeleteMode;
            buttonCancel.Visible = isMultiDeleteMode;

            if (isMultiDeleteMode)
            {
                if (!dataGridViewRegular.Columns.Contains("Select"))
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "Select",
                        HeaderText = "",
                        Width = 30,
                        ReadOnly = false
                    };
                    dataGridViewRegular.Columns.Insert(0, checkBoxColumn);
                }

                // Allow only the checkbox column to be editable
                dataGridViewRegular.ReadOnly = false;
                foreach (DataGridViewColumn column in dataGridViewRegular.Columns)
                {
                    if (column.Name != "Select")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            else
            {
                if (dataGridViewRegular.Columns.Contains("Select"))
                {
                    dataGridViewRegular.Columns.Remove("Select");
                }
                    
                dataGridViewRegular.ReadOnly = true; // Revert to read-only
            }
        }
        private void DeleteSelectedMembers(List<int> studentIds)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnection.ConnectionString))
                {
                    connection.Open();

                    foreach (int id in studentIds)
                    {
                        // First delete the corresponding check-in records
                        string deleteCheckInQuery = "DELETE FROM [dbo].[RegularMemberCheckIn] WHERE RegularMemberId = @RegularMemberId";
                        using (SqlCommand checkInCommand = new SqlCommand(deleteCheckInQuery, connection))
                        {
                            checkInCommand.Parameters.AddWithValue("@RegularMemberId", id);
                            checkInCommand.ExecuteNonQuery();
                        }

                        // Then delete the student member record
                        string deleteStudentQuery = "DELETE FROM [dbo].[RegularMember] WHERE RegularMemberId = @RegularMemberId";
                        using (SqlCommand studentCommand = new SqlCommand(deleteStudentQuery, connection))
                        {
                            studentCommand.Parameters.AddWithValue("@RegularMemberId", id);
                            studentCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting members from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonMultiDelete_Click(object sender, EventArgs e)
        {
            ToggleMultiDeleteMode(true);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selectedIds = new List<int>();

                // Check if "Select" column exists before accessing it
                if (dataGridViewRegular.Columns.Contains("Select"))
                {
                    foreach (DataGridViewRow row in dataGridViewRegular.Rows)
                    {
                        // Check if the checkbox in the "Select" column is checked
                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            int studentId = Convert.ToInt32(row.Cells["RegularMemberId"].Value);
                            selectedIds.Add(studentId);
                        }
                    }
                }

                if (selectedIds.Count == 0)
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected members?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedMembers(selectedIds);
                    MessageBox.Show("Selected members have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegularMembers();
                    ToggleMultiDeleteMode(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ToggleMultiDeleteMode(false);
        }

        private void dataGridViewRegular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRegular.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                dataGridViewRegular.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
