using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace StandManagementProject
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            lblVolume.Text = "50%";
        }

        private void lblTrackEnd_Click(object sender, EventArgs e)
        {

        }
        string[] paths, files;

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[trackList.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
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
        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex > 0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lblTrackStart.Text = player.Ctlcontrols.currentPositionString;
               // lblTrackEnd.Text = player.Ctlcontrols.currentItem.durationString;
            }
            catch
            {

            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
            lblVolume.Text = trackVolume.Value.ToString() + "%";  
        }


        // dont remove this lol. App breaks if you do. 
        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        // dont remove this lol. App breaks if you do. 


        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar.Width;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    trackList.Items.Add(files[x]);
                }
            }
        }
    }
}
