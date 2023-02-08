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
using System.Web;
using ClosedXML.Excel;
using System.Data.SqlTypes;
using DocumentFormat.OpenXml.Drawing;

namespace StandManagementProject
{
    public partial class Factureclient : Form
    {
        public Factureclient()
        {
            InitializeComponent();
            bunifuDatepicker1.Value = bunifuDatepicker2.Value = DateTime.Today;
            Affichage_Vente();

            this.FacturClientGrid.Columns[0].HeaderText = "N° Ticket";
            for (int i = 0; i < FacturClientGrid.RowCount; i++)
            {
                Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
            }


        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = 0;
        public void Affichage_couleur(int id,int i)
        {
           if (sqlcon.State == ConnectionState.Closed)
            {
                
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_color_of_bill", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);

                        if (dt.Rows[0][1] != DBNull.Value)
                        {

                            FacturClientGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromName(dt.Rows[0][1].ToString());

                        }
                    
                    
                }
                sqlcon.Close();
            }
        }
        public void Affichage_Vente()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                
                // FacturClientGrid.Rows.Clear();
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_facture_clt_byDate_Marge", sqlcon);
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
            calc();
        }

        void calc()
        {
            try
            {
                decimal total = 0, versé = 0, reste = 0;
                foreach (DataGridViewRow row in FacturClientGrid.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[1].Value);
                    versé += Convert.ToDecimal(row.Cells[2].Value);
                    reste += Convert.ToDecimal(row.Cells[3].Value);
                }

                totalventelabel.Text = total.ToString();
                totalverselabel.Text = versé.ToString();
                totalrestelabel.Text = reste.ToString();

            }
            catch (Exception)
            {
                totalventelabel.Text = "0";
                totalverselabel.Text = "0";
                totalrestelabel.Text = "0";
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
                for (int i = 0; i < FacturClientGrid.RowCount; i++)
                {
                    Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
                }
            }
            else
            {
                bunifuDatepicker2.Value = bunifuDatepicker1.Value = DateTime.Today;
                Affichage_Vente();
                for (int i = 0; i < FacturClientGrid.RowCount; i++)
                {
                    Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
                }
            }
        }
        decimal montant = 0, versé = 0, reste = 0;



        private void FacturClientGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FacturClientGrid.CurrentRow.Index != -1 && FacturClientGrid.CurrentRow.Index != FacturClientGrid.RowCount)
            {

                id = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[0].Value);
                montant = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[1].Value);
                versé = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[2].Value);
                reste = Convert.ToDecimal(FacturClientGrid.CurrentRow.Cells[3].Value);
                string nom_client = Convert.ToString(FacturClientGrid.CurrentRow.Cells[7].Value);
                string nom_user = Convert.ToString(FacturClientGrid.CurrentRow.Cells[8].Value);
                Détails_Facture_Client__Achat_ dac = new Détails_Facture_Client__Achat_(this.id, this.montant, this.versé, this.reste, this,nom_user,nom_client);
                if (FormIsOpen(Application.OpenForms, typeof(Détails_Facture_Client__Achat_)))
                {
                    MessageBox.Show("Formulaire déja ouvert!");
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

        private void Factureclient_Load(object sender, EventArgs e)
        {
            bunifuDatepicker1.Value = bunifuDatepicker1.Value = DateTime.Today;
            Affichage_Vente();
            for (int i = 0; i < FacturClientGrid.RowCount; i++)
            {
                Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
            }
        }

        private void NoCode_Click(object sender, EventArgs e)
        {
            if(FacturClientGrid.RowCount > 0)
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
                                foreach (DataGridViewColumn col in FacturClientGrid.Columns)
                                {
                                    dt.Columns.Add(col.Name);
                                }

                                foreach (DataGridViewRow row in FacturClientGrid.Rows)
                                {
                                    DataRow dRow = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dRow[cell.ColumnIndex] = cell.Value;
                                    }
                                    dt.Rows.Add(dRow);
                                }
                                dt.Rows.Add("TOTAL", totalventelabel.Text);
                                dt.Rows.Add("versé", totalverselabel.Text);
                                dt.Rows.Add("reste", totalrestelabel.Text);
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
            
        }

        private void Factureclient_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FacturClientGrid_Click(object sender, EventArgs e)
        {
            if (FacturClientGrid.RowCount > 0)
            {
                id = Convert.ToInt32(FacturClientGrid.CurrentRow.Cells[0].Value);
            }
            else
            {
                id = -1;
            }
        }
        void update_vente(int id_facture)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("vider_facture_client", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@id_facture", id_facture);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void reset_vente(int id_facture)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("reset_bill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@id", id_facture);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        private void FacturClientGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (id == -1)
                {
                    MessageBox.Show("Veuillez d'abord séléctionner un bon \n pour changer son CLIENT !");
                }
                else
                {
                    new Transfert_bon_client(this, id).Show();
                }
            }
            else
            if (e.KeyCode == Keys.F2)
            {
                if (id == -1)
                {
                    MessageBox.Show("Veuillez d'abord séléctionner un bon \n Pour Annuler la vente !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Vous voulez Annuler Ce bon ! ", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        update_vente(id);
                    }
                    Affichage_Vente();
                    for (int i = 0; i < FacturClientGrid.RowCount; i++)
                    {
                        Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
                    }
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (id == -1)
                {
                    MessageBox.Show("Veuillez d'abord séléctionner un bon \n Pour actualiser une facture !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Vous voulez Actualiser Ce bon ! ", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        reset_vente(id);
                    }
                    Affichage_Vente();
                    for (int i = 0; i < FacturClientGrid.RowCount; i++)
                    {
                        Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
                    }
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (id == -1)
                {
                    MessageBox.Show("Veuillez d'abord séléctionner un bon \n Pour changer couleur de facture !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Vous voulez changer couleur Ce bon ! ", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ColorBill colorBill = new ColorBill(this, this.id);
                        if (FormIsOpen(Application.OpenForms, typeof(ColorBill)))
                        {
                            MessageBox.Show("Formulaire déja ouvert!");
                            
                        }
                        else
                        {
                            
                            colorBill.Top -= 20;
                            colorBill.Show();
                        }
                        
                    }
                    
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (id == -1)
                {
                    MessageBox.Show("Veuillez d'abord séléctionner un bon \n pour voir ses détails !");
                }
                else
                {
                    Détail_vente_only colorBill = new Détail_vente_only(this.id);
                    colorBill.Show();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Guide gg = new Guide(1);
            gg.Show();
        }

        private void searchfourn_TextChanged_1(object sender, EventArgs e)
        {
            if (searchfourn.Text != string.Empty)
            {
                show_clt(searchfourn.Text);
            }
            else
            {
                bunifuDatepicker1.Value = bunifuDatepicker2.Value = DateTime.Today;
                Affichage_Vente();
            }
            for (int i = 0; i < FacturClientGrid.RowCount; i++)
            {
                Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
            }

        }

        
        void show_clt(string s)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("show_facture_clt_byNameC_Marge", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@nom", s);                
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    this.FacturClientGrid.DataSource = dt;
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            calc();
        }
        public void colors()
        {
            for (int i = 0; i < FacturClientGrid.RowCount; i++)
            {
                Affichage_couleur(Convert.ToInt32(FacturClientGrid.Rows[i].Cells[0].Value), i);
            }
        }

    }
}
