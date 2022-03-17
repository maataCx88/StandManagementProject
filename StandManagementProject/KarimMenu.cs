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
    public partial class KarimMenu : Form
    {
        public KarimMenu()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_MouseEnter(object sender, EventArgs e)
        {
            guna2Button9.Text = "Deconnecter";
            guna2Button9.Width = 198;
            guna2Button9.BackColor = Color.White;
            guna2Button9.ForeColor = Color.Black;
            
            
        }

        private void guna2Button9_MouseLeave(object sender, EventArgs e)
        {
            guna2Button9.Text = "";
            guna2Button9.Width = 39;
            guna2Button9.BackColor = Color.Red;
        }
    }
}
