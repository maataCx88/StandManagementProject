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
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id : " + id_achat);

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
                        
                        id_achat = Convert.ToInt32(dt.Rows[0][0]);
                        MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit id achat"+id_achat);
                    }
                    else if (dt.Rows.Count > 1)
                    {
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
        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (ProduitSansCodeGrid.Rows.Count - 1 != 0 && ProduitSansCodeGrid.CurrentRow.Index != ProduitSansCodeGrid.RowCount - 1)
            {
                id = Convert.ToInt32(ProduitSansCodeGrid.CurrentRow.Cells[0].Value);
                MessageBox.Show("id_p is" + id);
                affichage_achat_by_produit(id);
            }
        }
    }
}
