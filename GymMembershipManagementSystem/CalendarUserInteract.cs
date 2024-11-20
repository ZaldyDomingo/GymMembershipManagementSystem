using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public partial class CalendarUserInteract : Form
    {
        public CalendarUserInteract()
        {
            InitializeComponent();

        }
        private void CalendarUserInteract_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //for (int i = 1; i < dayofweek; i++)
            //{
            //    UserControl1Blank usercontrolblank = new UserControl1Blank();
            //    daycontainer.Controls.Add(usercontrolblank);
            //}
            //for (int i = 1; i < days; i++) 
            //{
            //    UserControlDays usercontroldays = new UserControlDays();
            //    usercontroldays.days(i);
            //    daycontainer.Controls.Add(usercontroldays);
            //}
        }



        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
