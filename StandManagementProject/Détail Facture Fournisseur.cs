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
    public partial class Détail_Facture_Fournisseur : MetroFramework.Forms.MetroForm
    {
        public Détail_Facture_Fournisseur(int id,decimal total,decimal versé,decimal Reste)
        {
            InitializeComponent();
            this.id = id;
            this.montant = total;
            this.versé = versé;
            this.reste = Reste;
            this.numlbl.Text = this.id.ToString();
            TotalLbl.Text = this.montant.ToString();
            VersementLbl.Text = this.versé.ToString();
            Restelbl.Text = this.reste.ToString();
            if (this.reste == 0)
            {
                this.VerséTxt.Enabled = false;
            }
            else
            {
                this.VerséTxt.Enabled = true;
            }
            bunifuDatepicker1.Value = DateTime.Today;
            Affichage_achat(id);
            Affichage_reglement(id);
        }
        Facturefournisseur fct;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        decimal montant = 0, versé = 0, reste = 0; int id = 0;
        void Affichage_achat(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_achat_by_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = null;
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();

            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (VerséTxt.Text != string.Empty)
            {
                if (versé + Convert.ToDecimal(VerséTxt.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    VerséTxt.Text = string.Empty;
                }
                else
                {
                    versé = versé + Convert.ToDecimal(VerséTxt.Text);
                    Ajouter_Réglement(this.id, Convert.ToDecimal(this.VerséTxt.Text));
                    Affichage_reglement(this.id);
                    reste = montant - versé;
                    Restelbl.Text = reste.ToString();
                    MessageBox.Show("vérsement réussie !");
                    fct.Affichage_fact();
                    VerséTxt.Text = string.Empty;

                    if (this.reste == 0)
                    {
                        this.VerséTxt.Enabled = false;
                    }
                    else
                    {
                        this.VerséTxt.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Montant versé vide !");
            }
        }

        void Ajouter_Réglement(int id, decimal verse)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", verse);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void Affichage_reglement(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_reglement_by_id_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.réglementGrid.DataSource = null;
                    this.réglementGrid.DataSource = dt;
                }
                sqlcon.Close();

            }
        }
    }
}
