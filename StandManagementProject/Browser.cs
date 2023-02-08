using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace StandManagementProject
{
    public partial class Navigateur : Form
    {
        public Navigateur()
        {
            InitializeComponent();
            webView.NavigationStarting += EnsureHttps;
        }

        private void next_Click(object sender, EventArgs e)
        {

        }

        private void refr_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {

        }
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                args.Cancel = true;
                MessageBox.Show("cancel");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate("google.com");
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webView.Refresh();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(link.Text);
                }
            }
            catch
            {
                webView.CoreWebView2.Navigate("https://duckduckgo.com/?q=" +link.Text+"&t=h_&ia=web");
            }
        }
    }
}
