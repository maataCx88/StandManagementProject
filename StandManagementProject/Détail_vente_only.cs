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
    public partial class Détail_vente_only : Form
    {
        public Détail_vente_only(int id)
        {
            InitializeComponent();
            détailsGrid.BorderStyle = BorderStyle.None;
            détailsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            détailsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            détailsGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            détailsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            détailsGrid.BackgroundColor = Color.White;
            détailsGrid.EnableHeadersVisualStyles = false;
            détailsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            détailsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            détailsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Affichage_Vente(id);
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public void Affichage_Vente(int id)
        {
            this.détailsGrid.DataSource = null;
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_vente_by_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.détailsGrid.Columns[0].Visible = false;
                this.détailsGrid.Columns[1].Visible = false;
                this.détailsGrid.Columns[3].Visible = false;
                //this.détailsGrid.Columns[2].Width = 200;
                // this.détailsGrid.Columns[5].Width = 60;


            }
        }
    }
}
