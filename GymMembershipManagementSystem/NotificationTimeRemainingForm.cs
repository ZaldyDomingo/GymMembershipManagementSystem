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
            InitializeSearchTimer();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=LAPTOP-9VQCFDCQ\\SQLEXPRESS01;Initial Catalog=gymMembership;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        private void InitializeSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 500; 
            searchTimer.Tick += searchTimer_Tick;
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
