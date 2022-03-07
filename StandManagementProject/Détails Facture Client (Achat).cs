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
    public partial class Détails_Facture_Client__Achat_ : MetroFramework.Forms.MetroForm
    {
        public Détails_Facture_Client__Achat_(int id, decimal montant, decimal versé ,decimal reste)
        {
            InitializeComponent();          
            this.id = id;
            this.montant = montant;
            this.versé = versé;
            this.reste = reste;
            TotalLbl.Text = this.montant.ToString();
            VersementLbl.Text = this.versé.ToString();
            Restelbl.Text = this.reste.ToString();
            if (this.reste == 0)
            {
                this.metroTextBox1.Enabled = false;
            }
            else
            {
                this.metroTextBox1.Enabled = true;
            }
            Affichage_Vente(id);
            Affichage_reglement(id);
            this.détailsGrid.Columns[0].Visible = false;
            this.détailsGrid.Columns[4].Width = 60;
            this.réglementGrid.Columns[1].Width = 100;
            bunifuDatepicker1.Value = DateTime.Today;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id = 0;
        decimal montant = 0, versé = 0, reste = 0;

        
        void Affichage_Vente(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_vente_by_facture", sqlcon);
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
        void Ajouter_Réglement(int id, decimal verse)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_clt", sqlcon);
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
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_reglement_by_id_clt", sqlcon);
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
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text != string.Empty)
            {
                if( versé+Convert.ToDecimal(metroTextBox1.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    metroTextBox1.Text = string.Empty;
                }
                else
                {
                    versé = versé + Convert.ToDecimal(metroTextBox1.Text);
                    Ajouter_Réglement(this.id,Convert.ToDecimal(this.metroTextBox1.Text));
                    Affichage_reglement(this.id);
                    reste = montant - versé;
                    Restelbl.Text = reste.ToString();
                    MessageBox.Show("vérsement réussie !");
                    metroTextBox1.Text = string.Empty;
                    
                    if (this.reste == 0)
                    {
                        this.metroTextBox1.Enabled = false;
                    }
                    else
                    {
                        this.metroTextBox1.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Montant versé vide !");
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != string.Empty)
            {
                if (versé + Convert.ToDecimal(metroTextBox1.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    metroTextBox1.Text = string.Empty;
                }
            }
        }
    }
}
