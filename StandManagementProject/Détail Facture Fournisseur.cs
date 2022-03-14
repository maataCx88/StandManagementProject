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
    public partial class Détail_Facture_Fournisseur : MetroFramework.Forms.MetroForm
    {
        public Détail_Facture_Fournisseur(int id,decimal total,decimal versé,decimal Reste)
        {
            InitializeComponent();
            Affichage_achat(id);
            Affichage_reglement(id);
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        void Affichage_achat(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_achat_by_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = null;
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();

            }
        }
        void Ajouter_Réglement(int id, decimal verse)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", verse);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void Affichage_reglement(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_reglement_by_id_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.réglementGrid.DataSource = null;
                    this.réglementGrid.DataSource = dt;
                }
                sqlcon.Close();

            }
        }
    }
}
