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
    public partial class Eventform : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Eventform()
        {
            InitializeComponent();
            displayevnt();
            if (note.Text != String.Empty)
            {
                savebtn.Click-= new EventHandler(savebtn_Click);
                savebtn.Click += new EventHandler(savebtn2_Click);
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (note.Text != String.Empty)
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("insert_note_cal", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@dateevent", datetxt.Text);
                sqlcmd.Parameters.AddWithValue("@note ", note.Text);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Note enregistrée avec succès !");
                this.Dispose();
            }
        }
        private void savebtn2_Click(object sender, EventArgs e)
        {
            if (note.Text != String.Empty)
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("update_note_cal", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@dateevent", datetxt.Text);
                sqlcmd.Parameters.AddWithValue("@note ", note.Text);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Note mis a jour avec succès !");
                this.Dispose();
            }
            else
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("delete_note_cal", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@dateevent", datetxt.Text);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Note réinitialisé avec succès !");
                this.Dispose();
            }
        }
        public void displayevnt()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlDataAdapter = new SqlCommand("show_note_cal", sqlcon);
            sqlDataAdapter.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Parameters.AddWithValue("@dateevent", daysusrcontrol.static_day + "-" + Calendar.static_month + "-" + Calendar.static_year);
            SqlDataReader drd = sqlDataAdapter.ExecuteReader();
            while (drd.Read())
            {
                if (drd.GetValue(0).ToString() != "")
                {
                    note.Text = drd.GetValue(0).ToString();
                }
                else
                {
                    note.Text = "";
                }
            }
            drd.Close();
            sqlcon.Close();
        }
        private void Eventform_Load(object sender, EventArgs e)
        {
            datetxt.Text = daysusrcontrol.static_day + "-" + Calendar.static_month + "-" + Calendar.static_year;
        }
    }
}
