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
    public partial class achat_and_vente_détails :  MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public achat_and_vente_détails(int idproduit)
        {
            InitializeComponent();
            this.idproduit = idproduit;
            show_details_achat(this.idproduit);
            show_details_vente(this.idproduit);
        }
        int idproduit=-1;
        public void show_details_achat(int id)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_achat_by_prod_details", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridViewAchat.DataSource = dtbl;
                dataGridViewAchat.Columns[0].Visible = false;
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        public void show_details_vente(int id)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_vente_by_prod", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridViewVente.DataSource = dtbl;
                dataGridViewVente.Columns[0].Visible = false;
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        private void achat_and_vente_détails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
