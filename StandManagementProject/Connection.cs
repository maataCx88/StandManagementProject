using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net; //Include this namespace
using System.Data.SqlClient;

namespace StandManagementProject
{
    //SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.1.55,1433; Initial Catalog = store; User ID = mahdi; Password=123"); 
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            Properties.Settings.Default.Connection_Timeout = "5";
            Properties.Settings.Default.TrustServerCertificate = "true";
            Properties.Settings.Default.Encrypt = "true";
            Properties.Settings.Default.MultipleActiveResultSets = "false";
            Properties.Settings.Default.Persist_Security_Info = "false";
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            // Get the IP
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            if (Properties.Settings.Default.Server == "")
            {
                ip.Text = myIP+", 1433";
                user.Text = "admin";
                pass.Text = "****";
            }
            else
            {
                ip.Text = Properties.Settings.Default.Server;
                user.Text = Properties.Settings.Default.User_ID;
                pass.Text = Properties.Settings.Default.Password;
            }


            label1.Text = myIP;
            //Console.ReadKey();
        }
        string myIP = "";
        public bool testcon(SqlConnection sqlConnection)
        {

                try
                {
                    sqlConnection.Open();
                    MessageBox.Show("Connecté");
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erreur de connexion");
                    Properties.Settings.Default.Server = myIP+", 1433";
                    Properties.Settings.Default.User_ID = "admin";
                    Properties.Settings.Default.Password = "*****";
                    Properties.Settings.Default.Save();
                return false;
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = ip.Text;
            Properties.Settings.Default.User_ID = user.Text;
            Properties.Settings.Default.Password = pass.Text;
            Properties.Settings.Default.FullString = "Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=store;User ID=" + Properties.Settings.Default.User_ID + ";Password=" + Properties.Settings.Default.Password;
            Properties.Settings.Default.Save();
            SqlConnection sqlConnection = new SqlConnection(@Properties.Settings.Default.FullString);
            Properties.Settings.Default.Server = myIP + ", 1433";
            if (testcon(sqlConnection))
            {
                this.Hide();
                LOGIN_ log = new LOGIN_();
                log.Show();
            }
        }

        private void guna2ControlBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
