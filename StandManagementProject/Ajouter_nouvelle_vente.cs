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
    public partial class Ajouter_nouvelle_vente : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Ajouter_nouvelle_vente(Prod_list_and_price pcp,Détails_Facture_Client__Achat_ vnt,int facture,int produit,decimal price,decimal qte,decimal colis)
        {
            InitializeComponent();
            this.vnt = vnt;
            this.pcp = pcp;
            this.facture = facture;
            this.produit = produit;
            this.qte = qte;
            this.colis = colis;
            this.price = price;
            this.metroTextPrice.Text = price.ToString("#.000");
            this.metroTextQTE.Text = "1";

        }
        int facture = 0, produit = 0; decimal qte = 0, colis = 0,price=0;
        Prod_list_and_price pcp; Détails_Facture_Client__Achat_ vnt;

        private void metroTextColis_TextChanged(object sender, EventArgs e)
        {
            if(metroTextColis.Text == string.Empty)
            {
                metroTextQTE.Enabled = true;
                metroTextQTE.Text = string.Empty; 
            }
            else
            {
                if(colis != 0)
                {
                    if(Convert.ToDecimal(metroTextColis.Text) * colis > qte)
                    {
                        MessageBox.Show("Quantité insuffisante");
                        metroTextColis.Text = string.Empty;
                        metroTextColis.Focus();
                    }
                    else
                    {
                        metroTextQTE.Enabled = false;
                        metroTextQTE.Text = (Convert.ToDecimal(metroTextColis.Text) 
                            * colis).ToString("#.0000");
                    }
                }
                else
                {
                    metroTextQTE.Enabled = true;
                    metroTextQTE.Text = string.Empty;
                }
            }
        }

        private void metroTextQTE_TextChanged(object sender, EventArgs e)
        {
            if(metroTextQTE.Text != string.Empty)
            {
                if (Convert.ToDecimal(metroTextQTE.Text) > qte)
                {
                    MessageBox.Show("Quantité insuffisante");
                    metroTextQTE.Text = string.Empty;
                    metroTextQTE.Focus();
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(metroTextPrice.Text == string.Empty || metroTextQTE.Text == string.Empty)
            {
                MessageBox.Show("Veuillez remplir les champs S.V.P !");
            }
            else
            {

                ajouter_vente(produit, Convert.ToDecimal(metroTextPrice.Text)
                    , Convert.ToDecimal(metroTextQTE.Text));
                update_qte_prod(produit, Convert.ToDecimal(metroTextQTE.Text));
                vnt.calc();
                pcp.Dispose();
                //vnt.Dispose();
                pcp.Close();
                //vnt.Close();
                this.Dispose();
                this.Close();

            }
        }
        void update_qte_prod(int idprod, decimal pqte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("decrese_qte", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", idprod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", pqte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void ajouter_vente(int prod, decimal prix_u, decimal qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_vente ", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_f", facture);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_p", prod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", qte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        
    }
}
