using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StandManagementProject
{
    public partial class Main : Form
    {
        int id;

        Dashboard dashboard;

        public Main(int id, string first_name, string last_name, string role)
        {
            InitializeComponent();

            this.id = id;

            labelfullname.Text = first_name + " " + last_name;

            dashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelmain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void closeprgrm_Click(object sender, EventArgs e)
        {
            Message_box mb = new Message_box(Login.action_yes_1, true, "");
            mb.label1.Text = "Etes-vous sûr de sortir \n l'application?";
            mb.label1.Location = new Point(65, 20);
            mb.Show();
        }
    }
}
