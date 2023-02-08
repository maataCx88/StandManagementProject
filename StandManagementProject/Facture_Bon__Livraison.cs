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
    public partial class Facture_Bon__Livraison : Form
    {
        public Facture_Bon__Livraison()
        {
            InitializeComponent();
            Affichage_Vente();
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString); 
        int id = 0;
        public void Affichage_Vente()
        {
            searchfourn.Text = string.Empty;
            if (sqlcon.State == ConnectionState.Closed)
            {
                FacturClientGrid.DataSource = null;
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_bon_by_date", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@dateD", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@dateF", bunifuDatepicker2.Value);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.FacturClientGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.FacturClientGrid.Columns[13].Visible = this.FacturClientGrid.Columns[14].Visible =
                    this.FacturClientGrid.Columns[15].Visible = false;
            }
        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(bunifuDatepicker2.Value) >= Convert.ToDateTime(bunifuDatepicker1.Value)
                && Convert.ToDateTime(bunifuDatepicker2.Value) <= DateTime.Today)
            {
                Affichage_Vente();
            }
            else
            {
                bunifuDatepicker2.Value = bunifuDatepicker1.Value = DateTime.Today;
                Affichage_Vente();
            }
        }
        decimal montant = 0, versé = 0, reste = 0;



        private void FacturClientGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FacturClientGrid.CurrentRow.Index != -1 && FacturClientGrid.CurrentRow.Index != FacturClientGrid.RowCount)
            {

                id = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[15].Value);
                Détails_Commande_Livraison dtl = new Détails_Commande_Livraison(this.id, FacturClientGrid.CurrentRow.Cells[1].Value.ToString(), 
                    FacturClientGrid.CurrentRow.Cells[12].Value.ToString(), FacturClientGrid.CurrentRow.Cells[8].Value.ToString()
                    , FacturClientGrid.CurrentRow.Cells[6].Value.ToString(), FacturClientGrid.CurrentRow.Cells[9].Value.ToString()
                    , FacturClientGrid.CurrentRow.Cells[4].Value.ToString());

                if (FormIsOpen(Application.OpenForms, typeof(Détails_Commande_Livraison)))
                {
                    MessageBox.Show("Formulaire déja ouvert!");
                }
                else
                {
                    dtl.Show();
                }

            }
            else
            {
                id = 0;
            }
        }

        private void Factureclient_Load(object sender, EventArgs e)
        {
            searchfourn.Text = string.Empty;
            bunifuDatepicker1.Value = bunifuDatepicker1.Value = DateTime.Today;
            Affichage_Vente();
        }

        private void searchfourn_TextChanged(object sender, EventArgs e)
        {
            if (searchfourn.Text != string.Empty)
            show_clt(searchfourn.Text);
            else
            {
                Affichage_Vente();
            }

        }
        void show_clt(string s)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("show_bon_byNameC", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@nom", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                FacturClientGrid.DataSource = dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
