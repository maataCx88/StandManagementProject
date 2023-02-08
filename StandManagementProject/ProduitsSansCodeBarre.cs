using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class ProduitsSansCodeBarre : Form
    {
        Vente vnt;
        public ProduitsSansCodeBarre(Vente vente)
        {
            InitializeComponent();
            this.vnt = vente;
            metroProdSansCode.Checked = false;
            metroToutProduit.Checked = true;
            Tout_produit();

        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = -1;
        int id_achat = -1;
        string des = "";
        decimal prix_v = -1;
        decimal prix_r = -1;
        int qte = -1;
        decimal colis = -1;
        decimal pièces_par_colis = -1;
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

                    }
                    else if (dt.Rows.Count > 1)
                    {
                        plusieur = true;

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
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_prod_without_code_barre", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProduitSansCodeGrid.Columns[0].Visible = false;
                ProduitSansCodeGrid.Columns[1].Visible = false;
            }
        }
        void Tout_produit()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("Tout_produit", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProduitSansCodeGrid.Columns[0].Visible = false;
                ProduitSansCodeGrid.Columns[1].Visible = false;
            }
        }
        void Search_produit(string desc)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_prod_without_code_barre_by_name", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@des", desc);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProduitSansCodeGrid.Columns[0].Visible = false;
                ProduitSansCodeGrid.Columns[1].Visible = false;
            }
        }
        void Search_produit_avec_code(string desc)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_prod_byname_or_code", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", desc);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    ProduitSansCodeGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProduitSansCodeGrid.Columns[0].Visible = false;
                ProduitSansCodeGrid.Columns[1].Visible = false;
            }
        }
        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void RechercheSansCode_TextChanged(object sender, EventArgs e)
        {
            if (RechercheSansCode.Text != string.Empty)
            {
                if (!metroToutProduit.Checked)
                {
                    Search_produit(RechercheSansCode.Text);
                }
                else
                {
                    Search_produit_avec_code(RechercheSansCode.Text);
                }
            }
            else
            {
                if (!metroToutProduit.Checked)
                {
                    SansCode_produit();
                }
                else
                {
                    Tout_produit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroProdSansCode_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToutProduit.Checked)
            {
                RechercheSansCode.WaterMark = "Scanner ou chercher un produit ...";
                Tout_produit();
            }
            else
            {
                RechercheSansCode.WaterMark = "Rechercher Par  Désignation ...";
                SansCode_produit();
            }
        }

        private void ProduitSansCodeGrid_DoubleClick(object sender, EventArgs e)
        {
            string code_barre = ""; decimal grosp = 0;
            if (ProduitSansCodeGrid.RowCount != 0 && ProduitSansCodeGrid.CurrentRow.Index != ProduitSansCodeGrid.RowCount)
            {

                id = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[0].Value);
                string code = ProduitSansCodeGrid.CurrentRow.Cells[1].Value.ToString();
                if (code != "0000000")
                {
                    if (!metroToutProduit.Checked)
                    {
                        des = ProduitSansCodeGrid.CurrentRow.Cells[2].Value.ToString();
                        prix_v = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[3].Value);
                        prix_r = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[4].Value);
                        grosp = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[5].Value);
                        qte = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[6].Value);
                        colis = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[7].Value);
                        pièces_par_colis = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[7].Value);
                        if (colis != 0)
                        {
                            colis = -1;
                        }
                        else
                        {
                            pièces_par_colis = 0;
                        }

                    }
                    else
                    {
                        code_barre = ProduitSansCodeGrid.CurrentRow.Cells[1].Value.ToString();
                        des = ProduitSansCodeGrid.CurrentRow.Cells[2].Value.ToString();
                        prix_v = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[3].Value);
                        prix_r = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[4].Value);
                        grosp = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[5].Value);
                        qte = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[6].Value);
                        colis = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[7].Value);
                        pièces_par_colis = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[7].Value);
                        if (colis != 0)
                        {
                            colis = -1;
                        }
                        else
                        {
                            pièces_par_colis = 0;
                        }
                    }
                    vnt.stockp = qte;
                    vnt.total = qte;
                    vnt.total_qte_in_panier(this.id);
                    if (vnt.total_p + 1 <= vnt.total)
                    {
                        vnt.update_qte_bydes(des);
                        if (!vnt.existontable)
                        {
                            if (!vnt.radioVenteDétail.Checked)
                            {
                                prix_v = grosp;
                                prix_r = 0;

                            }
                            if (!metroToutProduit.Checked)
                            {
                                vnt.ajouter_article_sans_code(id, "", des, prix_v, prix_r, qte, colis, pièces_par_colis);
                            }
                            else
                            {
                                vnt.ajouter_article_avec_code(id, code_barre, des, prix_v, prix_r, qte, colis, pièces_par_colis);
                            }
                        }
                        //vnt.existontable = false;
                        this.Close();
                        vnt.calc();



                        /*Get_Achat_lastId(id);
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
                                //vnt. metroGrid1.Rows.Add(id, id_achat, (vnt.metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                            //ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString());
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
                        vnt.calc();*/
                    }
                    else
                    {
                        MessageBox.Show("Tout Qte Inséré ! \n Ajout Impossible !");
                        this.Close();
                    }
                }

            }
        }
    }
}
