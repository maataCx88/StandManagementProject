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
    public partial class Facturefournisseur : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        public Facturefournisseur()
        {
            InitializeComponent();
            Affichage_fact();

        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        void show_all()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_facture_four", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 220;
            dataGridView1.Columns[5].Width = 280;

        }
        void show_four(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_facture_four_byNameC", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@nom", s);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 220;
            dataGridView1.Columns[5].Width = 280;
        }
        public void Affichage_fact()
        {
            if (sqlcon.State == ConnectionState.Closed)
            sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_facture_four_byDate", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date1", metroDateTime1.Value);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date2", metroDateTime2.Value);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                }
                sqlcon.Close();
            
        }

        private void Facturefournisseur_Load(object sender, EventArgs e)
        {
            show_all();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchfourn.Text == string.Empty || searchfourn.Text == "Recherchez des factures")
            {
                show_all();
            }
            else
            {
                show_four(searchfourn.Text);
            }
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(metroDateTime1.Value) <= Convert.ToDateTime(metroDateTime2.Value))
            {
                Affichage_fact();
            }
            else
            {
                metroDateTime1.Value = metroDateTime2.Value = DateTime.Today;
                Affichage_fact();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount - 1 != 0 && dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                decimal montant = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[1].Value);
                decimal versé = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
                decimal reste = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                Détail_Facture_Fournisseur dcf = new Détail_Facture_Fournisseur(id, montant,versé, reste);
                if (FormIsOpen(Application.OpenForms, typeof(Détail_Facture_Fournisseur)))
                {
                    MessageBox.Show("Formulaire déja ouvert !");
                }
                else
                {
                    dcf.Show();
                }
            }
        }
    }
}
