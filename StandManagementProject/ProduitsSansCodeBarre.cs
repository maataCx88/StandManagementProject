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
    public partial class ProduitsSansCodeBarre : Form
    {
        Vente vnt;
        public ProduitsSansCodeBarre(Vente vente)
        {
            InitializeComponent();
            this.vnt = vente;
            SansCode_produit();
        }
        
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id = -1;
        int id_achat = -1;
        string des = "";
        decimal prix_v = -1;
        decimal prix_r = -1;
        int qte = -1;
        bool plusieur = false;
        void Get_Achat_lastId(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_id_achat_by_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        id_achat = Convert.ToInt32(dt.Rows[0][0]);
                        MessageBox.Show("Produit Existe une seule fois njibou mn la table produit so id achat : " + id_achat);

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Produit n'existe pas !");
                    }
                }
                sqlcon.Close();
            }
        }
        void affichage_achat_by_produit(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_achat_by_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        plusieur = false;
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit ");
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        plusieur = true;
                        MessageBox.Show("Produit Existe avec plusieurs fois njibou mn la table achat");
                    }
                }
                sqlcon.Close();
            }
        }
        void SansCode_produit()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_prod_without_code_barre ", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
            }
        }
        void Search_produit(string desc)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_prod_withouut_code_barre_by_name", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@des", desc);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
            }
        }
        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (ProduitSansCodeGrid.Rows.Count - 1 != 0 && ProduitSansCodeGrid.CurrentRow.Index != ProduitSansCodeGrid.RowCount - 1)
            {
                
                id = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[0].Value);
                des = ProduitSansCodeGrid.CurrentRow.Cells[1].Value.ToString();
                prix_v = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[2].Value);
                prix_r = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[3].Value);
                qte = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[4].Value);
                vnt.stockp = qte;
                vnt.total = qte;
                vnt.total_qte_in_panier(this.id);
                if (vnt.total_p + 1 <= vnt.total)
                {
                    Get_Achat_lastId(id);
                    affichage_achat_by_produit(id);
                    if (plusieur)
                    {
                        DialogResult result = MessageBox.Show("ce produit existe avec plusieurs prix \n vous voulez vendre avec ce prix : " + prix_v, "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            vnt.update_qte_bydes(des);
                            if (!vnt.existontable)
                            {
                                vnt.ajouter_article_sans_code(id, " ", des, prix_v, prix_r, qte);
                            }
                            /*vnt. metroGrid1.Rows.Add(id, id_achat, (vnt.metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                        ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString());*/
                        }
                        else
                        {

                            new Plusieurs_Prix_par_Produits(this.vnt, this, id).Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        vnt.update_qte_bydes(des);
                        if (!vnt.existontable)
                        {
                            vnt.ajouter_article_sans_code(id, "", des, prix_v, prix_r, qte);
                        }
                        //vnt.existontable = false;
                        this.Close();

                    }
                    vnt.calc();
                }
                else
                {
                    MessageBox.Show("Tout Qte Inséré ! \n Ajout Impossible !");
                    this.Close();
                }
                
            }
        }

        private void RechercheSansCode_TextChanged(object sender, EventArgs e)
        {
            if(RechercheSansCode.Text != string.Empty)
            {
                Search_produit(RechercheSansCode.Text);
            }
            else
            {
                SansCode_produit();
            }
        }
    }
}
