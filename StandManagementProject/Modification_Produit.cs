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
    public partial class Modification_Produit : Form
    {
        public Modification_Produit()
        {
            InitializeComponent();
            Affichage_produit();
            
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id = -1;
        decimal prix_u=0,  prix_v=0,  prix_r =0;
        void Affichage_produit()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_full_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.ProductGrid.DataSource = null;
                    this.ProductGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProductGrid.Columns[0].Visible = false;
                ProductGrid.Columns[6].Width = 63;
            }
            datagridviewchange();
        }
        public void datagridviewchange()
        {
            ProductGrid.BorderStyle = BorderStyle.None;
            ProductGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ProductGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            ProductGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ProductGrid.BackgroundColor = Color.White;
            ProductGrid.EnableHeadersVisualStyles = false;
            ProductGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            ProductGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void Inventaire_achat()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("inventaire_prix_achat", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    
                }
                sqlcon.Close();
            }
        }
        void Inventaire_vente()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("inventaire_prix_vente", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {

                }
                sqlcon.Close();
            }
        }
        void search_produit(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("search_prod_byname_or_code", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", s);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.ProductGrid.DataSource = null;
                    this.ProductGrid.DataSource = dt;
                }
                sqlcon.Close();
                ProductGrid.Columns[0].Visible = false;
                ProductGrid.Columns[6].Width = 55;
            }
            datagridviewchange();
        }
        void update_product(int id, int qte, decimal prix_u, decimal prix_v, decimal prix_r) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_produit", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qte);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void ProductGrid_Click(object sender, EventArgs e)
        {
            if(ProductGrid.RowCount-1>0  && ProductGrid.CurrentRow.Index != ProductGrid.RowCount - 1)
            {
                id = Convert.ToInt32(ProductGrid.CurrentRow.Cells[0].Value);
                prix_u = Convert.ToDecimal(ProductGrid.CurrentRow.Cells[3].Value);
                AchatTxt.Text= ProductGrid.CurrentRow.Cells[3].Value.ToString();
                ancienVenteTxt.Text = ProductGrid.CurrentRow.Cells[4].Value.ToString();
                ancienrmiseTxt.Text = ProductGrid.CurrentRow.Cells[5].Value.ToString();

            }
            else
            {
                id = -1;
                prix_u = -1;
                AchatTxt.Text = "";
                ancienVenteTxt.Text = "";
                ancienrmiseTxt.Text = "";
            }
        }

        private void CodeBarre_TextChanged(object sender, EventArgs e)
        {
            if(CodeBarre.Text != string.Empty)
            {
                search_produit(CodeBarre.Text);
            }
            else
            {
                Affichage_produit();
            }
        }

        private void newVenteTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
              && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void clear()
        {
            newVenteTxt.Text = newRemiseTxt.Text = AchatTxt.Text = ancienVenteTxt.Text = ancienrmiseTxt.Text = string.Empty;
            id = -1;
            
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Veuillez Séléctionner Un Produit S.V.P!");
            }
            else
            {
                if(newVenteTxt.Text==string.Empty || newRemiseTxt.Text == string.Empty)
                {
                    MessageBox.Show("Veuillez Séléctionner Un Produit S.V.P!");
                }
                else
                {
                    prix_v = Convert.ToDecimal(newVenteTxt.Text);
                    prix_r = Convert.ToDecimal(newRemiseTxt.Text);
                    update_product(id, 0, prix_u, prix_v, prix_r);
                    clear();
                    Affichage_produit();
                    datagridviewchange();
                }
            }
        }
    }
}
