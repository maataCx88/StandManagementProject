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
    public partial class Transfert_bon_client : Form
    {
        public Transfert_bon_client(Factureclient vnt,int id_vente)
        {
            InitializeComponent();
            Affichage_Four();
            this.vnt = vnt;
            id_facture = id_vente;
            id_client = -1;
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        Factureclient vnt;
        int id_facture = -1, id_client=-1;
        void Rechercher_Four(string name)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("search_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@nom", name);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    DataFournisseur.DataSource = dt;
                }
                sqlcon.Close();
            }
        }
        void Affichage_Four()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlcmd.Fill(dt);
                DataFournisseur.DataSource = dt;


                sqlcon.Close();
            }
        }
        void last_ID_Four()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_last_id_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlcmd.Fill(dt);
                id_client = Convert.ToInt32(dt.Rows[0][0]);
                sqlcon.Close();
            }
        }
        void Ajouter_Four(string nom, string prénom, string phone)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("add_client ", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@nom", nom);
                sqlcmd.Parameters.AddWithValue("@prenom", prénom);
                sqlcmd.Parameters.AddWithValue("@tel", phone);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void update_vente(int id_facture, int id_client)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("transfert_vente_client", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@id_facture", id_facture);
                sqlcmd.Parameters.AddWithValue("@id_client", id_client);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        public void pass_to_four()
        {
            update_vente(id_facture, id_client);
            vnt.Affichage_Vente();
        }

        private void Recherchetxt_TextChanged(object sender, EventArgs e)
        {
            if (Recherchetxt.Text != string.Empty)
            {

                Rechercher_Four(Recherchetxt.Text);
            }
            else
            {
                Affichage_Four();
            }
        }

        private void DataFournisseur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataFournisseur.RowCount > 0)
            {
                id_client = Convert.ToInt32(this.DataFournisseur.CurrentRow.Cells[0].Value);
                //string NameTxt = this.DataFournisseur.CurrentRow.Cells[1].Value.ToString();
                pass_to_four();
                /*MessageBox.Show("Name" + vnt.four + " ID " + vnt.id);*/
                this.Close();
            }
        }

        private void AjouterNew_Click(object sender, EventArgs e)
        {
            if (Nom.Text == string.Empty || Prénom.Text == string.Empty)
            {
                MessageBox.Show("Veuillez Remplir le nom et le prénom S.V.P !");
            }
            else
            {
                Ajouter_Four(Nom.Text, Prénom.Text, PhoneFour.Text);
                last_ID_Four();
                pass_to_four();
                this.Close();
            }

        }

        private void DataFournisseur_DoubleClick(object sender, EventArgs e)
        {
            if (DataFournisseur.RowCount > 0)
            {
                id_client = Convert.ToInt32(this.DataFournisseur.CurrentRow.Cells[0].Value);
                //string NameTxt = this.DataFournisseur.CurrentRow.Cells[1].Value.ToString();
                pass_to_four();
                this.Close();
            }
            else
            {
                id_client = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* DialogResult result = MessageBox.Show("Vous voulez Quitter ce Formulaire ! ", "Alert", MessageBoxButtons.YesNo);
             if(result == DialogResult.Yes)
             {
                 this.Close();
             }
             else
             {

             }*/
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
