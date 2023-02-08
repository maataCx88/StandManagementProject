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

    public partial class Fournisseur_dashboard : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Fournisseur_dashboard(int idprod, string designation, decimal prix_u,
            decimal prix_v, decimal prix_r, decimal prix_g, decimal qte, MultiCode Mc)
        {
            InitializeComponent();
            affichagefourn();
            this.id_produit = idprod;
            this.designation = designation;
            this.prix_u = prix_u;
            this.prix_v = prix_v;
            this.prix_g = prix_g;
            this.prix_r = prix_r;
            this.qte = qte;
            metroTextDesignation.Text = this.designation;
            metroTextAchat.Text = this.prix_u.ToString();
            metroTextVente.Text = this.prix_v.ToString();
            metroTextGros.Text = this.prix_g.ToString();
            metroTextRemise.Text = this.prix_r.ToString();
            metroTextQte.Text = this.qte.ToString();
            montant = this.prix_u * this.qte;
            metroTextTotal.Text = montant.ToString();
            this.Mc = Mc;
        }
        MultiCode Mc;
        int idfacture = -1; decimal montant = 0, versé = 0, reste = 0;
        int id_fournisseur = -1, id_produit = -1; string designation;
        decimal prix_u = 0, prix_v = 0, prix_r = 0, prix_g = 0, qte = 0;
        void actualiser()
        {
            metroTextDesignation.Text = this.designation;
            metroTextAchat.Text = this.prix_u.ToString();
            metroTextVente.Text = this.prix_v.ToString();
            metroTextGros.Text = this.prix_g.ToString();
            metroTextRemise.Text = this.prix_r.ToString();
            montant = prix_u * qte;
            metroTextTotal.Text = montant.ToString();
        }
        void reset()
        {
            affichagefourn();
            foreach (MetroFramework.Controls.MetroTextBox Contr in Controls)
            {
                Contr.Text = string.Empty;
                Contr.Enabled = true;
            }
            foreach (MetroFramework.Controls.MetroButton button in Controls)
            {
                button.Enabled = true;
            }
            idfacture = -1; montant = versé = reste = 0;
            id_fournisseur = -1;
            metroTextDesignation.Text = designation;
            prix_u = prix_v = prix_r = prix_g = qte = 0;
        }
        void affichagefourn()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_four", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridViewFournisseur.DataSource = dtbl;
            sqlcon.Close();
            //  dataGridView2.Columns[1].Width = 200;
            //   dataGridView2.Columns[2].Width = 200;
        }
        void last_four()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_last_id_four", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            id_fournisseur = Convert.ToInt32(dtbl.Rows[0][0]);
            sqlcon.Close();
        }
        void rech_four(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("search_four", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@nom", s);
            sda.SelectCommand.Parameters.AddWithValue("@prenom", s);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcon.Close();
        }
        void ajouter_reglement_fournisseur(int id, decimal versé)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlCommand sqlcmd = new SqlCommand("add_reg_four", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@id", id);
            sqlcmd.Parameters.AddWithValue("@versé", versé);
            sqlcmd.Parameters.AddWithValue("@date_reg_four", DateTime.Today);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void dataGridViewFournisseur_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewFournisseur.RowCount > 0)
            {
                id_fournisseur = Convert.ToInt32(dataGridViewFournisseur.CurrentRow.Cells[0].Value);
                metroTextNom.Text = dataGridViewFournisseur.CurrentRow.Cells[1].Value.ToString();
                metroTextPrénom.Text = dataGridViewFournisseur.CurrentRow.Cells[2].Value.ToString();
                metroTextPhone.Text = dataGridViewFournisseur.CurrentRow.Cells[3].Value.ToString();
                metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextPhone.Enabled = false;
                metroConfirm.Enabled = false;
            }
        }

        private void Fournisseur_dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                actualiser();
            }
            if (e.KeyCode == Keys.F4)
            {
                reset();
            }
        }

        private void metroTextAchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroTextVersé_TextChanged(object sender, EventArgs e)
        {
            if (metroTextTotal.Text != "0" && metroTextTotal.Text != string.Empty)
            {
                if (metroTextVersé.Text != string.Empty)
                {
                    versé = Convert.ToDecimal(metroTextVersé.Text);
                    montant = Convert.ToDecimal(metroTextTotal.Text);
                    if (versé <= montant)
                    {
                        reste = montant - versé;
                        metroTextReste.Text = reste.ToString();
                    }
                    else
                    {
                        metroTextVersé.Text = string.Empty;
                        metroTextReste.Text = metroTextTotal.Text;
                    }
                }
                else
                {
                    metroTextReste.Text = metroTextTotal.Text;
                }
            }
            else
            {
                metroTextReste.Text = "0";
            }
        }

        private void metroTextTotal_TextChanged(object sender, EventArgs e)
        {
            if (metroTextTotal.Text != string.Empty)
            {
                metroTextReste.Text = metroTextTotal.Text;
                metroTextVersé.Text = "0";
            }
            else
            {
                metroTextReste.Text = string.Empty;
                metroTextVersé.Text = string.Empty;
            }
        }

        private void metroTextAchat_TextChanged(object sender, EventArgs e)
        {
            decimal qte = 0; decimal achat = 0; decimal vente = 0;
            if (metroTextAchat.Text != string.Empty && metroTextQte.Text != string.Empty)
            {
                achat = Convert.ToDecimal(metroTextAchat.Text);
                if (metroTextVente.Text != string.Empty)
                {
                    vente = Convert.ToDecimal(metroTextVente.Text);
                    if (achat > vente)
                    {
                        metroTextVente.Text = string.Empty;
                    }
                }
                qte = Convert.ToDecimal(metroTextQte.Text);
                achat = achat * qte;
                metroTextTotal.Text = achat.ToString();
            }
            else
            {
                metroTextTotal.Text = string.Empty;
            }
        }

        private void metroTextSearch_TextChanged(object sender, EventArgs e)
        {
            if (metroTextSearch.Text != string.Empty)
            {
                rech_four(metroTextSearch.Text);
            }
            else
            {
                affichagefourn();
            }
        }

        private void metroTextVente_TextChanged(object sender, EventArgs e)
        {
            /*decimal achat = 0; decimal vente = 0; decimal remise = 0;
            if(metroTextVente.Text != string.Empty && metroTextRemise.Text != string.Empty)
            {
                achat= Convert.ToDecimal(metroTextAchat.Text);
                vente= Convert.ToDecimal(metroTextVente.Text);
                remise= Convert.ToDecimal(metroTextRemise.Text);
                if (achat > vente)
                {
                    metroTextVente.Text = string.Empty;
                }
                if( remise > vente)
                {
                    metroTextRemise.Text = string.Empty;
                }
            }
            else
            {
                metroTextVente.Text = string.Empty;
                metroTextRemise.Text = string.Empty;
            }*/
        }

        void getlastfactid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_last_id_fact_four", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                idfacture = Convert.ToInt32(dt.Rows[0][0]);
            }
            sqlcon.Close();
        }
        void ajouterachat(int id_f, int id_p, decimal prix_v, decimal prix_a, decimal prix_r, decimal prix_g, decimal qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_achat", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@id_f", id_f);
            sqlcmd.Parameters.AddWithValue("@id_p", id_p);
            sqlcmd.Parameters.AddWithValue("@prix_a", prix_a);
            sqlcmd.Parameters.AddWithValue("@prix_v", prix_v);
            sqlcmd.Parameters.AddWithValue("@prix_r", prix_r);
            sqlcmd.Parameters.AddWithValue("@prix_g", prix_g);
            sqlcmd.Parameters.AddWithValue("@qte", qte);
            sqlcmd.Parameters.AddWithValue("@date_a", DateTime.Now);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        void ajouterfacture(int id_f, decimal montant, decimal versé, decimal reste)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_facture_four", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@id_f", id_f);
            sqlcmd.Parameters.AddWithValue("@montant", montant);
            sqlcmd.Parameters.AddWithValue("@versé", versé);
            sqlcmd.Parameters.AddWithValue("@reste", reste);
            sqlcmd.Parameters.AddWithValue("@date_fact", dateTimePicker1.Value);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void metroConfirm_Click(object sender, EventArgs e)
        {
            if (metroTextNom.Text == string.Empty || metroTextPrénom.Text == string.Empty)
            {
                MessageBox.Show("Veuillez Saisir les coordonnées du fournisseur S.V.P!");
            }
            else
            {
                addfourn(metroTextNom.Text, metroTextPrénom.Text, metroTextPhone.Text);
                last_four();
                MessageBox.Show("Fournisseur Ajouté averc succées!");
                metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextPhone.Enabled = false;
                metroConfirm.Enabled = false;
            }
        }

        private void metroNouveauAchat_Click(object sender, EventArgs e)
        {
            if (metroTextTotal.Text == string.Empty)
            {
                MessageBox.Show("Veuillez D'abord Régler le montant Total S.V.P!");
            }
            else if (id_fournisseur == -1)
            {
                MessageBox.Show("Veuillez D'abord saisir les coordonnées du fournisseur S.V.P!");
            }
            else if (metroTextDesignation.Text == string.Empty || metroTextVente.Text == string.Empty
                    || metroTextRemise.Text == string.Empty || metroTextGros.Text == string.Empty)
            {
                MessageBox.Show("Veuillez D'abord saisir les informations de multi code S.V.P!");
            }
            else
            {
                decimal achat = 0; decimal vente = 0; decimal remise = 0;

                achat = Convert.ToDecimal(metroTextAchat.Text);
                vente = Convert.ToDecimal(metroTextVente.Text);
                remise = Convert.ToDecimal(metroTextRemise.Text);
                if (achat > vente)
                {
                    metroTextVente.Text = string.Empty;
                    MessageBox.Show("Vérifier Prix de vente");
                }
                else if (remise > vente || remise < achat)
                {
                    MessageBox.Show("Vérifier Prix de remise");
                    metroTextRemise.Text = string.Empty;
                }

                else
                {
                    /*check_existance_des(metroTextDesignation.Text);
                    if (this.id_produit == this.id_exist)
                    {
                        exist = false;
                    }
                    if (exist)
                    {
                        MessageBox.Show("Vérifier le nom de l'Article");
                    }*/
                    
                        prix_v = Convert.ToDecimal(metroTextVente.Text);
                        prix_u = Convert.ToDecimal(metroTextAchat.Text);
                        prix_r = Convert.ToDecimal(metroTextRemise.Text);
                        prix_g = Convert.ToDecimal(metroTextGros.Text);
                        qte = Convert.ToDecimal(metroTextQte.Text);
                        if(metroTextVersé.Text == string.Empty)
                        {
                            versé = 0;
                        }
                        else
                        {
                            versé = Convert.ToDecimal(metroTextVersé.Text);
                        }
                        montant = Convert.ToDecimal(metroTextTotal.Text);
                        reste = montant - versé;
                        ajouterfacture(id_fournisseur, montant, versé, reste);
                        //
                        getlastfactid();
                        ajouter_reglement_fournisseur(idfacture, versé);
                        ajouterachat(idfacture, id_produit, prix_v, prix_u, prix_r, prix_g, qte);
                        DialogResult result = MessageBox.Show("Confirmer cette modification sur ce produit", "Modification", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            update_designation_and_qte(id_produit, metroTextDesignation.Text, qte, prix_u, prix_v, prix_r, prix_g);
                            increase_qte(id_produit,qte);
                            Mc.view_stock();
                        }
                        this.Close();
                    
                }
            }
        }

        void addfourn(string nom, string prenom, string tel)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_four", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@nom", nom);
            sqlcmd.Parameters.AddWithValue("@prenom", prenom);
            sqlcmd.Parameters.AddWithValue("@phone", tel);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        public void update_designation_and_qte(int id, string designation, decimal qtes, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_designation_with_qte", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qtes);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }
        public void increase_qte(int id, decimal qtes) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("decrese_qte", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@qte", -qtes);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }
        bool exist = false; int id_exist = -1;
        void check_existance_des(string des)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("existance_multi_code_designation", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@designation ", des);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    exist = true;
                    id_exist = (int)dtbl.Rows[0][0];
                }
                else
                {
                    exist = false;
                    id_exist = -1;
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur Technique");
            }
        }
    }
}
