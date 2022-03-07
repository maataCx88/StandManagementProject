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
    public partial class Factureclient : MetroFramework.Forms.MetroForm
    {
        public Factureclient()
        {
            InitializeComponent();
            Affichage_Vente();
            MessageBox.Show("Index " + (FacturClientGrid.RowCount - 1));
            this.FacturClientGrid.Columns[0].HeaderText = "N° Ticket";
            bunifuDatepicker1.Value = bunifuDatepicker1.Value = DateTime.Today;

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id=0;
        void Affichage_Vente()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_facture_clt_byDate", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date1", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date2", bunifuDatepicker2.Value);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.FacturClientGrid.DataSource = dt;
                }
                sqlcon.Close();
            }
        }
        public static bool FormIsOpen(FormCollection application ,Type formtype )
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype); 
        }
        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDateTime(bunifuDatepicker2.Value) >= Convert.ToDateTime(bunifuDatepicker1.Value)
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
            if(FacturClientGrid.RowCount-1 !=  0 && FacturClientGrid.CurrentRow.Index != FacturClientGrid.RowCount - 1)
            {
                
                id = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[0].Value);
                montant = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[1].Value);
                versé = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[2].Value);
                reste = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[3].Value);

                Détails_Facture_Client__Achat_ dac = new Détails_Facture_Client__Achat_(this.id,this.montant,this.versé,this.reste);
                if (FormIsOpen(Application.OpenForms, typeof(Détails_Facture_Client__Achat_))){
                    MessageBox.Show("Form already open!");
                }
                else 
                {
                    dac.Show();
                }

            }
            else
            {
                id = 0;
            }
        }

       
    }
}
