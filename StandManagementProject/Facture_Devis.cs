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
using Bunifu.Framework.UI;

namespace StandManagementProject
{
    public partial class Facture_Devis : Form
    {
        public Facture_Devis(int id_user)
        {
            InitializeComponent();
            Affichage_Vente();
            this.id_user = id_user;
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = -1;
        int id_user = -1;
        decimal montant = 0, versé = 0, reste = 0, remise=0;
        public void Affichage_Vente()
        {
            searchfourn.Text = string.Empty;
            if (sqlcon.State == ConnectionState.Closed)
            {
                FacturClientGrid.DataSource = null;
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_facture_devis_byDate", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@dateD", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@dateF", bunifuDatepicker2.Value);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.FacturClientGrid.DataSource = dt;
                }
                sqlcon.Close();
                FacturClientGrid.Columns[9].Visible = false;
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
        private void FacturClientGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FacturClientGrid.RowCount > 0)
            {

                id = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[0].Value);
                montant = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[1].Value);
                versé = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[2].Value);
                remise = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[2].Value);
                reste = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[4].Value);
                string state = FacturClientGrid.CurrentRow.Cells[8].Value.ToString();
                string date = FacturClientGrid.CurrentRow.Cells[5].Value.ToString();
                string vendeur = FacturClientGrid.CurrentRow.Cells[6].Value.ToString();
                string client = FacturClientGrid.CurrentRow.Cells[7].Value.ToString();
                int ID_client = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[9].Value.ToString());
                Détails_Devis détails_Devis = new Détails_Devis(this,this.id,this.montant,this.versé,this.reste,this.remise,state,id_user,date,vendeur,client,ID_client);
                if (FormIsOpen(Application.OpenForms, typeof(Détails_Devis)))
                {
                    MessageBox.Show("Formulaire Dèja ouvert !");
                }
                else
                {
                    détails_Devis.Show();
                }

            }
            else
            {
                id = 0;
            }
        }

        private void Factureclient_Load(object sender, EventArgs e)
        {
            bunifuDatepicker2.Value = bunifuDatepicker1.Value = DateTime.Today;
            Affichage_Vente();
        }

        private void searchfourn_TextChanged(object sender, EventArgs e)
        {

            show_clt(searchfourn.Text);

        }
        void show_clt(string s)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("show_facture_devis_byID_OR_NAME_Client", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@Nom_OR_id_Facture", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                FacturClientGrid.DataSource = dtbl;
                sqlcon.Close();
                FacturClientGrid.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
