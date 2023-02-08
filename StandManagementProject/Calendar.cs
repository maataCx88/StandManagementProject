using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            Properties.Settings.Default.FullString = "Data Source=.\\SQLEXPRESS;Initial Catalog=store;Integrated Security=True;MultipleActiveResultSets=true";
            Properties.Settings.Default.Save();
            InitializeComponent();
            showdays();
        }
        public static int static_month, static_year;
        public void showdays()
        {
            DateTime now=DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthyear.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days=DateTime.DaysInMonth(year, month);
            int daysofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"))+1;

            static_month = month; static_year = year;
            for (int i=1; i<daysofweek; i++)
            {
                day control = new day();
                daycontainer.Controls.Add(control);
            }

            for(int i=1; i<=days; i++)
            {
                daysusrcontrol ucdays = new daysusrcontrol();
                ucdays.daysusr(i);
                ucdays.displayevnti(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void Devis_to_Facture_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Devis_to_Facture_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Devis_to_Facture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        int month, year;
        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthyear.Text = monthname + " " + year;
            static_month = month; static_year = year;
            for (int i = 1; i < daysofweek; i++)
            {
                day control = new day();
                daycontainer.Controls.Add(control);
            }

            for (int i = 1; i <= days; i++)
            {
                daysusrcontrol ucdays = new daysusrcontrol();
                ucdays.daysusr(i);
                ucdays.displayevnti(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if(month == 0)
            {
                month = 12;
                year--;
            }
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthyear.Text = monthname + " " + year;
            static_month = month; static_year = year;
            for (int i = 1; i < daysofweek; i++)
            {
                day control = new day();
                daycontainer.Controls.Add(control);
            }

            for (int i = 1; i <= days; i++)
            {
                daysusrcontrol ucdays = new daysusrcontrol();
                ucdays.daysusr(i);
                ucdays.displayevnti(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
