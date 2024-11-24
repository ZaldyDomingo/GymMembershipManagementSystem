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
    public partial class MembershipTransactionFees : Form
    {
        private SqlConnection sqlConnection;
        public MembershipTransactionFees()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeRefreshTimer();
            SetupDataGridView();
            LoadMemberData();
        }
        private void SetupDataGridView()
        {
            dataGridStudentFeeTotal.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridStudentFeeTotal.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridStudentFeeTotal.RowTemplate.Height = 28;
            dataGridStudentFeeTotal.ColumnHeadersHeight = 28;

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void LoadMemberData()
        {
            try
            {
                // SQL query to combine StudentMember, RegularMember, and WalkInMember with respective MembershipFee
                string query = @"
                    SELECT [FirstName], [LastName], 350 AS MembershipFee
                    FROM [dbo].[StudentMember]
                    UNION ALL
                    SELECT [FirstName], [LastName], 400 AS MembershipFee
                    FROM [dbo].[RegularMember]
                    UNION ALL
                    SELECT [FirstName], [LastName], 60 AS MembershipFee
                    FROM [dbo].[WalkInMember]";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind data to DataGridView
                dataGridStudentFeeTotal.DataSource = dataTable;

                // Calculate total membership fee
                decimal totalMembershipFee = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalMembershipFee += Convert.ToDecimal(row["MembershipFee"]);
                }

                // Display total fee in the label
                labelTotalMembershipFee.Text = $"Total Membership Fee: {totalMembershipFee:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading member data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            refreshTimer.Stop();
            base.OnFormClosed(e);
        }
        private void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 10000; // 10 seconds
            refreshTimer.Tick += (sender, e) => LoadMemberData();  // Reload the data every time the timer ticks
            refreshTimer.Start();
        }
    }
}
