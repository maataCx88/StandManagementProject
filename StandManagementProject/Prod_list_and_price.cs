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
    public partial class Prod_list_and_price : Form
    {

        Détails_Facture_Client__Achat_ vnt;
        public Prod_list_and_price(Détails_Facture_Client__Achat_ vente,int facture)
        {
            InitializeComponent();
            this.vnt = vente;
            this.facture = facture;
            Tout_produit();

        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = -1,facture;
        

        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
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
                
                    Search_produit_avec_code(RechercheSansCode.Text);
                
            }
            else
            {
                
                    Tout_produit();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ProduitSansCodeGrid_DoubleClick(object sender, EventArgs e)
        {
            
            if (ProduitSansCodeGrid.RowCount > 0)
            {

                id = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[0].Value);
                if (id != 0)
                {
                    decimal prix_v = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[3].Value);
                    //decimal prix_g = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[5].Value);
                    decimal qte = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[6].Value);
                    decimal colis = Convert.ToDecimal(ProduitSansCodeGrid.CurrentRow.Cells[7].Value);
                    if(qte == 0)
                    {
                        MessageBox.Show("Quantité insuffisante");
                    }
                    else
                    {
                        vnt.check_prod_in_basket(id, qte);
                        if (!vnt.exist_in_basket)
                        {
                            Ajouter_nouvelle_vente AJV = new Ajouter_nouvelle_vente(this, vnt, facture, id, prix_v, qte, colis);
                            if (FormIsOpen(Application.OpenForms, typeof(Ajouter_nouvelle_vente)))
                            {
                                MessageBox.Show("Formulaire déja ouvert!");
                                AJV.BringToFront();
                            }
                            else
                            {
                                AJV.Show();
                            }
                        }
                        else
                        {
                            vnt.calc();
                            this.Close();
                        }
                    }
                }

            }
        }
    }
}
