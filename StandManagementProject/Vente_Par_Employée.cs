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
    public partial class Vente_Par_Employée : Form
    {
        public Vente_Par_Employée(int id_emp, string name)
        {
            InitializeComponent();
            this.id_emp=id_emp;
            Affichage_Vente(this.id_emp);
            label1.Text = name;

            détailsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            détailsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            détailsGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            détailsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            détailsGrid.BackgroundColor = Color.Gainsboro;
            détailsGrid.EnableHeadersVisualStyles = false;
            détailsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            détailsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            détailsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id_facture = 0; decimal montant = 0, versé = 0, reste = 0, remise = 0;
        decimal prix_vente = -1, prix_temp = -1, qteVente = -1, qteStock = -1, prix_v = -1, prix_u = -1;

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private void Détails_Devis_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Détails_Devis_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Détails_Devis_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        int id_emp;

        public void Affichage_Vente(int id)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_facture_clt_by_EMP_ID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_emp", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.détailsGrid.Columns[8].Visible = false;
            }
        }














        private void Détails_Devis_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.F3)       // UPDATE
            {

                if (state == "En Attente")
                {
                   
                }
            }*/




        }

        void afficher_bon(int id)
        {
            int bon = -1, facture = -1, vendeur = -1, clt = -1;
            string client = "", téléphone = "", emp = "", compte = "", adresse = "", livreur = "";
            decimal net_Total = -1, net_Versé = -1, net_Remise = -1, net_Reste = -1, net_HT = -1, net_TVA = -1;
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_bon_by_ID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    bon = Convert.ToInt32(dt.Rows[0][0]);
                    client = dt.Rows[0][1].ToString();
                    téléphone = dt.Rows[0][2].ToString();
                    emp = dt.Rows[0][3].ToString();
                    net_Total = Convert.ToDecimal(dt.Rows[0][4]);
                    net_Versé = Convert.ToDecimal(dt.Rows[0][5]);
                    net_Remise = Convert.ToDecimal(dt.Rows[0][6]);
                    net_Reste = Convert.ToDecimal(dt.Rows[0][7]);
                    net_HT = Convert.ToDecimal(dt.Rows[0][8]);
                    net_TVA = Convert.ToDecimal(dt.Rows[0][9]);
                    compte = dt.Rows[0][10].ToString();
                    adresse = dt.Rows[0][11].ToString();
                    livreur = dt.Rows[0][12].ToString();
                    vendeur = Convert.ToInt32(dt.Rows[0][13]);
                    clt = Convert.ToInt32(dt.Rows[0][14]);
                    facture = Convert.ToInt32(dt.Rows[0][14]);
                }
                sqlcon.Close();
            }
        }






        private void Détails_Facture_Client__Achat__FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
