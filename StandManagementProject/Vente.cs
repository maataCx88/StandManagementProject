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
    public partial class Vente : MetroFramework.Forms.MetroForm
    {
        public Vente(/*Plusieurs_Prix_par_Produits prp,Fournisseur frn,ProduitsSansCodeBarre pscb*/)
        {
            InitializeComponent();
            metroGrid1.Columns[0].ReadOnly = true;
            metroGrid1.Columns[1].ReadOnly = true;
            metroGrid1.Columns[2].ReadOnly = true;
            metroGrid1.Columns[3].ReadOnly = true;
            metroGrid1.Columns[4].ReadOnly = true;
            metroGrid1.Columns[5].ReadOnly = true;
            metroGrid1.Columns[6].ReadOnly = true;
            metroGrid1.Columns[7].ReadOnly = true;
            metroGrid1.Columns[8].ReadOnly = true;
            metroGrid1.Columns[9].ReadOnly = true;
            metroGrid1.Columns[10].ReadOnly = true;
            metroGrid1.Columns[11].ReadOnly = true;
            metroGrid1.Columns[12].ReadOnly = true;
            TotalLbl.Text = montant.ToString();
           

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        public int id_f = 0;//id de client
        public int id_p = 0;//id de produt
        public int id_u = 1;//id de user
        int index_cell = -1;
        decimal prix = -1;
        decimal prix_u = -1;//prix_vente 1
        decimal prix_r = -1;//prix_remise 1
        int qte = -1;
        int qteC = -1;
        /// <summary>
        /// variable nes7a9houm ki ykoun produit yexisty mara wa7da fi achat
        /// </summary>
        string designp = "";
        decimal ventep = -1;//prix_v 2
        decimal remisep = -1;//prix_remise 2
        int stockp = -1;
        bool plusieur = false;
        int id_achat = -1;
        bool exist = true;
        decimal montant = 0;
        decimal montantR = 0;
        void ajouter_facture_client(decimal montant, decimal versé, decimal reste, decimal remise)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", this.id_f);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_u", this.id_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé",   versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste",    reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_fact", DateTime.Today);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void ajouter_vente(int prod,decimal prix_u,int qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_vente ", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_f", id_f);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_p", prod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", qte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void reglé_facture_client(int id,decimal versé)
        {
            sqlcon.Open();
            SqlDataAdapter sqlcmd = new SqlDataAdapter("add_vente ", sqlcon);
            sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
            sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", System.DateTime.Now);
            sqlcmd.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
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
                    if(dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit");
                        plusieur = false;
                    }
                    else if (dt.Rows.Count > 1) {
                        MessageBox.Show("Produit Existe avec plusieurs fois njibou mn la table achat");
                        plusieur = true;
                    }
                }
                sqlcon.Close();
            }
        }
        void Informations_produit(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_prod_by_code", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        exist = true;
                        id_p =Convert.ToInt32(dt.Rows[0][0]);
                        designp = dt.Rows[0][2].ToString();
                        ventep= Convert.ToInt32(dt.Rows[0][4]);
                        remisep = Convert.ToInt32(dt.Rows[0][5]);
                        stockp = Convert.ToInt32(dt.Rows[0][6]);
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id : "+id_p);
                        
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Produit n'existe pas !");
                        exist = false;
                    }
                }
                sqlcon.Close();
            }
        }
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
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id achat: " + id_achat);

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Produit n'existe pas !");
                    }
                }
                sqlcon.Close();
            }
        }
        public void ajouter_article_sans_code(int id,int id_a,string des,decimal prix_v,decimal prix_r,int qte)
        {
            this.metroGrid1.Rows.Add(id, id_a, (metroGrid1.Rows.Count).ToString(), " ", des,
                prix_v.ToString(), Convert.ToDecimal(prix_v).ToString(), qte.ToString(), 1, (1 * prix_v).ToString(), prix_r.ToString());
        }
        void vider_tous_cas()
        {
            this.designp = "";
            this.ventep = -1;
            this.remisep = -1;
            this.stockp = -1;
            this.plusieur = false;
            this.id_achat = -1;
            this.exist = true;
            this.id_f = 1;
            this.id_p = 0;
            this.index_cell = -1;
            this.prix = -1;
            this.prix_u = -1;
            this.prix_r = -1;
            this.qte = -1;
            this.qteC = -1;
            CodeBarre.Text = string.Empty;
            PrixNoRéfTxt.Text = string.Empty;
            QteNoRéftxt.Text = string.Empty;
        }
        private void RecherchOrAddFour_Click(object sender, EventArgs e)
        {
           Client frn = new Client(this);
            frn.Show();
            
        }
        public void pass_to_four(int id_f,string name,string phone)
        {           
            this.id_f = id_f;
            
        }

        public void pass_to_datagrid(int id,int id_a, string des, decimal prix_v, decimal prix_r  , int qte)
        {
            this.metroGrid1.Rows.Add(id,id_a,(metroGrid1.Rows.Count).ToString(),CodeBarre.Text,des,
                prix_v.ToString(), Convert.ToDecimal( prix_v).ToString(), qte.ToString(), 1,(1 * prix_v).ToString(),prix_r.ToString());

        }

        private void CodeBarre_TextChanged(object sender, EventArgs e)
        {
            if(CodeBarre.Text != string.Empty)
            {
                Informations_produit(CodeBarre.Text);
                if (exist)
                {
                    Get_Achat_lastId(id_p);
                    affichage_achat_by_produit(id_p);
                    if (plusieur)
                    {
                        DialogResult result = MessageBox.Show("ce produit existe avec plusieurs prix \n vous voulez vendre avec ce prix : " + ventep, "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.metroGrid1.Rows.Add(id_p, id_achat, (metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                        ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString());
                        }
                        else
                        {
                            new Plusieurs_Prix_par_Produits(this, null,id_p).Show();
                        }

                    }
                    else
                    {
                        this.metroGrid1.Rows.Add(id_p, id_achat, (metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                        ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString());
                    }
                }                             
            }
            CodeBarre.Text = string.Empty;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Index != -1 && metroGrid1.CurrentRow.Index != metroGrid1.RowCount - 1)
            {
                
               

                if (metroGrid1.Columns[e.ColumnIndex].Index == 11)
                {
                    DialogResult result = MessageBox.Show("Vous voulez annuler cet article", "Alert !",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if ( result == DialogResult.Yes)
                    {
                        montantR = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[9].Value);
                        montant = montant - montantR;
                        TotalLbl.Text = montant.ToString();
                        metroGrid1.Rows.RemoveAt(metroGrid1.CurrentRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("Opération annulé");
                    }
                }
                else if (metroGrid1.Columns[e.ColumnIndex].Index == 12 && metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                {
                    prix = -1;
                    prix_u = -1;
                    qte = -1;
                    qteC = -1;
                    metroGrid1.CurrentRow.Cells[6].ReadOnly = false;
                    metroGrid1.CurrentRow.Cells[8].ReadOnly = false;
                    index_cell = metroGrid1.CurrentRow.Index;
                    prix_u = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[5].Value);
                    qte = Convert.ToInt32(metroGrid1.CurrentRow.Cells[7].Value);
                    qteC = Convert.ToInt32(metroGrid1.CurrentRow.Cells[8].Value);
                    prix = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[6].Value);
                    prix_r = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[10].Value);
                    MessageBox.Show(" Price " + prix_u + " qte " + qte + " new Price " + prix+ " Remise " + prix_r);
                    
                       
                }
            }
        }

        private void metroGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (metroGrid1.CurrentCell.ColumnIndex == 6  || metroGrid1.CurrentCell.ColumnIndex == 8) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
               e.Handled = true;
            }

              
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ( metroGrid1.Rows.Count - 1 != 0)
            {
               
                
                TotalLbl.Text = montant.ToString();
                if (index_cell != -1)
                {
                    if (metroGrid1.Rows[index_cell].Cells[6].Value == null || Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) == 0)
                    {
                        metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString();
                        
                    }
                    else
                    {
                        if(Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) > prix_u 
                            || Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) < prix_r)
                        {
                            MessageBox.Show("à ne pas dépasser " + prix_u + " \n et pas moins de " + prix_r);
                            metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString();
                        }
                        else
                        {
                            montantR = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[9].Value);
                            montant = montant - montantR;
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();
                            montantR = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[9].Value);
                            montant = montant + montantR;
                            TotalLbl.Text = montant.ToString();

                        }
                    }
                    if ( metroGrid1.Rows[index_cell].Cells[8].Value == null ||  Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) == 0)
                    {
                        metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        
                    }
                    else
                    {
                        if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) > qte )
                            
                        {
                            MessageBox.Show("quantité"+ Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) + " insuffisante, max " 
                                + qte );
                            metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        }
                        else
                        {
                            montantR = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[9].Value);
                            montant = montant - montantR;
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();
                            montantR = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[9].Value);
                            montant = montant + montantR;
                            TotalLbl.Text = montant.ToString();
                        }
                    }
                    
                }
            }
        }

        private void NoCode_Click(object sender, EventArgs e)
        {
            new ProduitsSansCodeBarre(this).Show();
        }

        private void NoRéf_Click(object sender, EventArgs e)
        {
            if(PrixNoRéfTxt.Text == string.Empty ||QteNoRéftxt.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir le prix et la qte S.V.P!");
            }
            else
            {
                this.metroGrid1.Rows.Add("","", "", "", "Autre Article", "",PrixNoRéfTxt.Text,"", QteNoRéftxt.Text, 
                    (Convert.ToDecimal(PrixNoRéfTxt.Text) *Convert.ToInt32(QteNoRéftxt.Text)), "");
                PrixNoRéfTxt.Text = QteNoRéftxt.Text = string.Empty;
                
            }
        }

        private void PrixNoRéfTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroGrid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int myindex = e.RowCount-1;
            montantR = Convert.ToDecimal(metroGrid1.Rows[myindex].Cells[9].Value);
            //myindex++;
            montant = montant + montantR;
            TotalLbl.Text = montant.ToString();
            metroGrid1.Rows[myindex].Selected = true;
        }

        private void ConfirmBillBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id client " + id_f);

        }
    }
}
