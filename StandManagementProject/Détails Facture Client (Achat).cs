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
        public Détails_Facture_Client__Achat_(int id)
        {
            InitializeComponent();
            Affichage_Vente(id);
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
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
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();

            }
        }
    }
}
