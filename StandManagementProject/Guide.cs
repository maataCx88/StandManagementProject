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
    public partial class Guide : Form
    {
        public Guide(int sent)
        {
            InitializeComponent();
            if (sent == 0)
            {
                metroTabControl1.SelectedIndex = 0;
            }
            else if (sent == 1)
            {
                metroTabControl1.SelectedIndex = 1;
            }
            else if (sent == 2)
            {
                metroTabControl1.SelectedIndex = 2;
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

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
