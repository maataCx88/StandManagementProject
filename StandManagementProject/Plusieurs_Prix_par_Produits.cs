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
    public partial class Plusieurs_Prix_par_Produits : Form
    {
        public Plusieurs_Prix_par_Produits(Vente vente,ProduitsSansCodeBarre psb,int id)
        {
            InitializeComponent();
            this.id_p = id;
            this.vnt = vente;
            this.psb2 = psb;
            affichage_achat_by_produit(id);

        }
        Vente vnt ;
        ProduitsSansCodeBarre psb2;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id_achat = 0;
        int id_p = 0;
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
                    DataGridMultiPrice.DataSource = dt;
                }
                sqlcon.Close();
            }
        }

        private void DataGridMultiPrice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridMultiPrice.CurrentRow.Index != -1 && DataGridMultiPrice.CurrentRow.Index != DataGridMultiPrice.RowCount - 1)
            {
                 id_achat = Convert.ToInt32(this.DataGridMultiPrice.CurrentRow.Cells[0].Value);
                string des = Convert.ToString(this.DataGridMultiPrice.CurrentRow.Cells[1].Value);
                decimal prix_v  = Convert.ToInt32(this.DataGridMultiPrice.CurrentRow.Cells[3].Value);
                decimal prix_r = Convert.ToInt32(this.DataGridMultiPrice.CurrentRow.Cells[4].Value);
                int qte = Convert.ToInt32(this.DataGridMultiPrice.CurrentRow.Cells[6].Value);
                vnt.stockp = qte;
                vnt.total_qte_in_panier(this.id_p);
                MessageBox.Show("Total is " + vnt.total);
                MessageBox.Show("Total_P is " + vnt.total_p);
                if (vnt.total_p+1<= vnt.total)
                {
                    vnt.update_qte_byachat(id_achat);
                    if (!vnt.existontable)
                    {
                        vnt.pass_to_datagrid(this.id_p, id_achat, des, prix_v, prix_r, qte);
                    }
                }
                //vnt.existontable = false;   

                vnt.calc();           
                this.Close();



            }
        }
    }
}
