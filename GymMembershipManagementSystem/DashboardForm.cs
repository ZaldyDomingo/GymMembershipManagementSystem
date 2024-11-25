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
    public partial class DashboardForm : Form
    {
        private SqlConnection sqlConnection;
        private BackgroundWorker searchWorker;
        public DashboardForm()
        {

            InitializeComponent();
            InitializeDatabaseConnection();
            LoadAllMembers();
            DisplayMemberCounts();
            
            searchWorker = new BackgroundWorker();
            searchWorker.DoWork += searchWorker_DoWork;
            searchWorker.RunWorkerCompleted += searchWorker_RunWorkerCompleted;

            dataGridViewResult.Visible = false;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;

            countRefreshTimer = new Timer();
            countRefreshTimer.Interval = 5000;
            countRefreshTimer.Tick += countRefreshTimer_Tick;
            countRefreshTimer.Start();

            timerRecentMember = new Timer();
            timerRecentMember.Interval = 5000;
            timerRecentMember.Tick += timerRecentMember_Tick;
            timerRecentMember.Start();
            LoadRecentlyAddedMembers();
            dataGridViewRecentlyAdded.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dataGridViewRecentlyAdded.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewRecentlyAdded.RowTemplate.Height = 28;

            dataGridViewRecentlyAdded.ColumnHeadersHeight = 28;

            dataGridViewRecentlyAdded.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
 
        private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            e.Result = e.Argument.ToString();
        }
        private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string searchTerm = e.Result.ToString();
            SearchMember(searchTerm);
        }

        private void DisplayMemberCounts()
        {
            labelStudentCount.Text = GetMemberCount("StudentMember").ToString();
            labelNotStudentMemberCount.Text = GetMemberCount("RegularMember").ToString();
        }
        private int GetMemberCount(string tableName)
        {
            int count = 0;
            string query = $"SELECT COUNT(*) FROM [{tableName}]";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                try
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    count = (int)command.ExecuteScalar();
                }
                catch (SqlException ex) when (ex.Message.Contains("Invalid object name"))
                {
                    MessageBox.Show($"Error: The table '{tableName}' does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while counting members from {tableName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
            return count;
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void LoadAllMembers()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT [FirstName], [LastName], [MobileNumber], [EmergencyContactPhone] FROM [dbo].[StudentMember] " +
                           "UNION ALL " +
                           "SELECT [FirstName], [LastName], [MobileNumber], [EmergencyContactPhone] FROM [dbo].[RegularMember]";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            dataGridViewResult.DataSource = dataTable;
            if (dataGridViewResult.Columns.Contains("ProfileImage"))
            {
                dataGridViewResult.Columns.Remove("ProfileImage");
            }
        }
        private void SearchMember(string searchTerm)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT [FirstName], [LastName], [MobileNumber], [EmergencyContactPhone] FROM [dbo].[StudentMember] " +
                           "WHERE [FirstName] LIKE @search OR " +
                           "[LastName] LIKE @search OR " +
                           "[MobileNumber] LIKE @search OR " +
                           "[EmergencyContactPhone] LIKE @search " +
                           "UNION ALL " +
                           "SELECT [FirstName], [LastName], [MobileNumber], [EmergencyContactPhone] FROM [dbo].[RegularMember] " +
                           "WHERE [FirstName] LIKE @search OR " +
                           "[LastName] LIKE @search OR " +
                           "[MobileNumber] LIKE @search OR " +
                           "[EmergencyContactPhone] LIKE @search";
            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    sqlConnection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }

                dataGridViewResult.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            if (!searchWorker.IsBusy)
            {
                searchWorker.RunWorkerAsync(textBoxSearchMember.Text);
            }
        }
        private void dataGridViewResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewResult.Rows[e.RowIndex];

                // Extract first name and last name from the selected row
                string firstName = row.Cells["FirstName"].Value.ToString();
                string lastName = row.Cells["LastName"].Value.ToString();

                // Pass the first name and last name to the MemberDetailsForm constructor
                MemberDetailsForm detailsForm = new MemberDetailsForm(firstName, lastName);

                // Show the MemberDetailsForm as a dialog
                detailsForm.ShowDialog();
            }

        }
        private byte[] GetMemberProfileImage(string firstName, string lastName)
        {
            byte[] imageBytes = null;
            string query = "SELECT [ProfileImage] FROM [dbo].[StudentMember] WHERE [FirstName] = @firstName AND [LastName] = @lastName " +
                           "UNION ALL " +
                           "SELECT [ProfileImage] FROM [dbo].[RegularMember] WHERE [FirstName] = @firstName AND [LastName] = @lastName";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                try
                {
                    sqlConnection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        imageBytes = (byte[])result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching the profile image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return imageBytes;
        }
        private void countRefreshTimer_Tick(object sender, EventArgs e)
        {
            DisplayMemberCounts();
        }
        private void buttonViewMember_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.OfType<ViewStudentMember>().Any()) return;
            panelContainer.Controls.Clear();

            ViewStudentMember viewStudentMember = new ViewStudentMember
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Add(viewStudentMember);
            viewStudentMember.Show();
        }
        private void buttonViewRegularMember_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.OfType<ViewRegularMember>().Any()) return;
            panelContainer.Controls.Clear();
            ViewRegularMember viewRegularMember = new ViewRegularMember
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelContainer.Controls.Add(viewRegularMember);
            viewRegularMember.Show();
        }
        private void LoadRecentlyAddedMembers()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT [FirstName], [LastName], [ProfileImage] FROM [dbo].[StudentMember] " +
                           "UNION ALL " +
                           "SELECT [FirstName], [LastName], [ProfileImage] FROM [dbo].[RegularMember]";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            dataGridViewRecentlyAdded.DataSource = dataTable;
        }
        private void timerRecentMember_Tick(object sender, EventArgs e)
        {
            LoadRecentlyAddedMembers();
        }
        private void textBoxSearchMember_TextChanged_1(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
            if (!string.IsNullOrWhiteSpace(textBoxSearchMember.Text))
            {
                dataGridViewResult.Visible = true;
              
            }
            else 
            {
                dataGridViewResult.Visible = false;
            }
        }
        private void textBoxSearchMember_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearchMember.Text))
            {
                dataGridViewResult.Visible = true;
            }
        }

        private void monthCalendarMemberCheckedIn_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;  // Get the selected date
            ShowCheckInsForDate(selectedDate);  // Show check-ins for that date
        }
        private void ShowCheckInsForDate(DateTime selectedDate)
        {
            CheckInListForm checkInListForm = new CheckInListForm(selectedDate);
            checkInListForm.ShowDialog();
        }
    }
}


