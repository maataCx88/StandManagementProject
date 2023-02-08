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
using MetroFramework.Controls;
using ClosedXML.Excel;

namespace StandManagementProject
{
    public partial class Facturefournisseur : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Facturefournisseur()
        {
            InitializeComponent();
            Affichage_fact();

        }
        public void initiate_facture()
        {
            metroDateTime1.Value = metroDateTime2.Value = DateTime.Today;
            searchfourn.Text = string.Empty;
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
            metroDateTime1.Value = metroDateTime2.Value = DateTime.Today;
            Affichage_fact();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_OnValueChanged(object sender, EventArgs e)
        {

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
            if (dataGridView1.CurrentRow.Index != -1 && dataGridView1.CurrentRow.Index != dataGridView1.RowCount )
            {
                
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                decimal montant = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[1].Value);
                decimal versé = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
                decimal reste = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                string fournisseur = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                Détail_Facture_Fournisseur dcf = new Détail_Facture_Fournisseur(id, montant,versé, reste,this,fournisseur);
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

        private void searchfourn_TextChanged(object sender, EventArgs e)
        {
            if(searchfourn.Text != string.Empty)
            {
                show_four(searchfourn.Text);
            }
            else
            {
                Affichage_fact();
            }
        }

        private void NoCode_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.RowCount > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                DataTable dt = new DataTable();
                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    dt.Columns.Add(col.Name);
                                }

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    DataRow dRow = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dRow[cell.ColumnIndex] = cell.Value;
                                    }
                                    dt.Rows.Add(dRow);
                                }
                                workbook.Worksheets.Add(dt, "Rapport");
                                workbook.SaveAs(sfd.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}
