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

namespace StandManagementProject
{
    public partial class daysusrcontrol : UserControl
    {
        public daysusrcontrol()
        {
            InitializeComponent();

        }

        private void daysusrcontrol_Load(object sender, EventArgs e)
        {

        }
        public void daysusr(int numday)
        {
            labeldays.Text=numday.ToString();
        }
        public static string static_day;
        private void daysusrcontrol_Click(object sender, EventArgs e)
        {
            static_day = labeldays.Text;
            displayevnt();
            Eventform evt = new Eventform();
            evt.Show();
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public void displayevnt()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlDataAdapter = new SqlCommand("show_note_cal", sqlcon);
            sqlDataAdapter.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Parameters.AddWithValue("@dateevent", static_day+"-"+Calendar.static_month+"-"+Calendar.static_year);
            SqlDataReader drd = sqlDataAdapter.ExecuteReader();
            while (drd.Read())
            {
                if (drd.GetValue(0).ToString() != "")
                {
                    eventlbl.Text = drd.GetValue(0).ToString();
                }
                else
                {
                    eventlbl.Text ="";
                }
            }
            drd.Close();
            sqlcon.Close();
            
        }
        public void displayevnti(int i)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlDataAdapter = new SqlCommand("show_note_cal", sqlcon);
            sqlDataAdapter.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Parameters.AddWithValue("@dateevent", i + "-" + Calendar.static_month + "-" + Calendar.static_year);
            SqlDataReader drd = sqlDataAdapter.ExecuteReader();
            while (drd.Read())
            {
                if (drd.GetValue(0).ToString() != "")
                {
                    eventlbl.Text = drd.GetValue(0).ToString();
                }
                else
                {
                    eventlbl.Text = "";
                }
            }
            drd.Close();
            sqlcon.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         //  displayevnt();
        }
    }
}
