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
    public delegate void DataSentHandler(string code, string desc, decimal prixachat, decimal prixvente, decimal prixremise);
    public partial class SearchProduct : Form
    {
        // public event DataSentHandler DataSent;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public SearchProduct(Achat achat)
        {
            InitializeComponent();
            show_all();
            this.Achat = achat;
        }
        Achat Achat;
        void show_all()
        {
            dataGridView2.DataSource = null;
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("show_full_prod", sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Technique Conctactez DZoftware");
            }

        }
        void rech_four(string s)
        {
            dataGridView2.DataSource = null;
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("search_full_prod", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@code", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Technique Contactez DZoftware");
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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (searchfourn.Text == string.Empty)
            {
                show_all();
            }
            else
            {
                rech_four(searchfourn.Text);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView2.CurrentRow.Cells[0].Value.ToString() != "0")
                {
                    this.Achat.pass_from_datagrid(this.dataGridView2.CurrentRow.Cells[1].Value.ToString(), this.dataGridView2.CurrentRow.Cells[2].Value.ToString(), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[3].Value.ToString()), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[4].Value.ToString()), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[5].Value.ToString()));
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur technique");
            }
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {

            show_all();
        }
    }
}
