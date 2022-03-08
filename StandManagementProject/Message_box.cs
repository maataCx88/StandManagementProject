using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Message_box : Form
    {
        bool yesornot;
        Action action_yes;
        string parent_window;
        public static string yesorno;

        public Message_box(Action action_yes, bool yesornot, string parent_window)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(4, 0, 154);

            this.yesornot = yesornot;
            this.action_yes = action_yes;
            this.parent_window = parent_window;

            if (this.yesornot && this.parent_window == "Back")
            {
                this.action_yes = hide;
            }
            else if (!this.yesornot)
            {
                metroButtonyes.Hide();
                metroButtonno.Text = "OK !";
                metroButtonno.Location = new Point(130, 76);
            }
        }

        private void metroButtonyes_Click(object sender, EventArgs e)
        {
            action_yes();
            yesorno = "Yes";
        }

        private void metroButtonno_Click(object sender, EventArgs e)
        {
            hide();
            yesorno = "No";
        }

        public void hide()
        {
            this.Hide();
        }
    }
}
