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
    public partial class NotificationTimeRemainingForm : Form
    {
        private SqlConnection sqlConnection;
        public NotificationTimeRemainingForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadRecentActivities();
            SetupDataGridView();

        }
        private void SetupDataGridView()
        {
            dataGridViewRecentActivity.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridViewRecentActivity.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dataGridViewRecentActivity.RowTemplate.Height = 10;
            dataGridViewRecentActivity.ColumnHeadersHeight = 10;

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRecentActivities();
        }

        private void LoadRecentActivities()
        {
            try
            {
                sqlConnection.Open();

                // SQL Query to fetch recent activities with formatted date
                string query = @"
            -- Recently Added Members
            SELECT 'Regular Member ' + FirstName + ' is added to the gym!' AS Notification, 
                   FORMAT(DateJoined, 'MMMM dd, yyyy') AS EventTime
            FROM RegularMember
            WHERE DateJoined >= DATEADD(DAY, -1, GETDATE())
            UNION ALL
            SELECT 'Student Member ' + FirstName + ' is added to the gym!' AS Notification, 
                   FORMAT(DateJoined, 'MMMM dd, yyyy') AS EventTime
            FROM StudentMember
            WHERE DateJoined >= DATEADD(DAY, -1, GETDATE())

            -- Recently Checked-In Members
            UNION ALL
            SELECT 'Regular Member ' + rm.FirstName + ' checked in on ' + FORMAT(rmc.CheckInDate, 'MMMM dd, yyyy') + '!' AS Notification, 
                   FORMAT(rmc.CheckInDate, 'MMMM dd, yyyy') AS EventTime
            FROM RegularMemberCheckIn rmc
            INNER JOIN RegularMember rm ON rm.RegularMemberId = rmc.RegularMemberId
            WHERE rmc.CheckInDate >= DATEADD(DAY, -1, GETDATE())
            UNION ALL
            SELECT 'Student Member ' + sm.FirstName + ' checked in on ' + FORMAT(smc.CheckInDate, 'MMMM dd, yyyy') + '!' AS Notification, 
                   FORMAT(smc.CheckInDate, 'MMMM dd, yyyy') AS EventTime
            FROM StudentMemberCheckIn smc
            INNER JOIN StudentMember sm ON sm.StudentId = smc.StudentId
            WHERE smc.CheckInDate >= DATEADD(DAY, -1, GETDATE())

            -- Recently Deleted Members (if using a log table)
            UNION ALL
            SELECT 'Member ' + FirstName + ' has been deleted!' AS Notification, 
                   FORMAT(DeletedDate, 'MMMM dd, yyyy') AS EventTime
            FROM DeletedMembersLog
            WHERE DeletedDate >= DATEADD(DAY, -1, GETDATE())

            -- Order by EventTime in descending order to get the most recent activities at the top
            ORDER BY EventTime DESC";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable recentActivitiesTable = new DataTable();
                adapter.Fill(recentActivitiesTable);

                // Clear previous data in DataGridView
                dataGridViewRecentActivity.Rows.Clear();

                // Check if there are any recent activities
                if (recentActivitiesTable.Rows.Count == 0)
                {
                    // If no activities, show the "no recent activity" message in the DataGridView
                    dataGridViewRecentActivity.Rows.Add("You have no recent activity.", string.Empty);
                }
                else
                {
                    // Otherwise, populate the DataGridView with recent activities
                    foreach (DataRow row in recentActivitiesTable.Rows)
                    {
                        string notification = row["Notification"].ToString();
                        string eventTime = row["EventTime"].ToString();

                        // Add the notification and date directly into the given columns of the DataGridView
                        dataGridViewRecentActivity.Rows.Add(notification, eventTime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent activities: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewRecentActivity.Rows.Clear();
        }
    }
}
