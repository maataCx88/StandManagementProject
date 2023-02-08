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
using System.Resources;
using System.CodeDom;

namespace StandManagementProject
{
    public partial class MultiCode : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);

        public MultiCode()
        {
            InitializeComponent();

            view_stock();

            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true;
            dataGridView3.Columns[3].ReadOnly = true;
            dataGridView3.Columns[4].ReadOnly = true;
            dataGridView3.Columns[5].ReadOnly = true;
            dataGridView3.Columns[6].ReadOnly = true;
            dataGridView3.Columns[7].ReadOnly = true;
            vScrollBar1.Maximum = dataGridView3.RowCount;

        }
        int id_prod = -1, index_cell = -1; decimal prix_vente = 0, prix_remise = 0, prix_unitaire = 0, prix_gros = 0;
        string code_prod = "none";
        public void view_stock()
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_full_multi_code", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
                sqlcon.Close();
                dataGridView3.Columns[0].Visible = false;
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
            index_cell = -1;
        }



        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                view_stock();
            }
            else
            {
                search_stock(search);
            }

        }

        public void search_stock(string value)
        {

            try
            {

                dataGridView3.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_multicode_by_des", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@designation", value);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
                sqlcon.Close();
                dataGridView3.Columns[0].Visible = false;
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }

        }


        public void update_product(int id, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_produit", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.Parameters.AddWithValue("@qte", 0);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }
        public void update_designation_and_qte(int id, string designation, int qtes, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_designation_with_qte", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qtes);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount > 0)
            {
                id_prod = Convert.ToInt32(dataGridView3.Rows[index_cell].Cells[0].Value);
                if (FormIsOpen(Application.OpenForms, typeof(achat_and_vente_détails)))
                {
                    MessageBox.Show("Formulaire déja ouvert!");
                }
                else
                {
                    new achat_and_vente_détails(id_prod).Show();
                }
            }
        }

        private void dataGridView3_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = e.NewValue;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView3.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void metroList_Click(object sender, EventArgs e)
        {
            string code = "";

            if (dataGridView3.RowCount > 0)
            {
                if (index_cell == -1)
                {
                    MessageBox.Show("Séléctionner Un Multi Code S.V.P!");
                }
                else
                {
                    // code = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                    id_prod = Convert.ToInt32(dataGridView3.Rows[index_cell].Cells[0].Value);
                    code = dataGridView3.Rows[index_cell].Cells[1].Value.ToString();
                    Add_to_list_To_A_MultiCode List_code = new Add_to_list_To_A_MultiCode(this, id_prod,"Action" ,code);
                    List_code.Show();
                }

            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount > 0)
            {
                index_cell = dataGridView3.CurrentRow.Index;

            }
        }

        private void metroAddMultiCode_Click(object sender, EventArgs e)
        {
            Add_A_MultiCode AMC = new Add_A_MultiCode(this, -1, "", -1, -1, -1, -1, -1,"action");
            this.Controls.Add(AMC);
            AMC.BringToFront();


        }

        private void metroInfo_Click(object sender, EventArgs e)
        {
            string designation = ""; int qte = 0;
            if (dataGridView3.RowCount > 0)
            {
                if (index_cell == -1)
                {
                    MessageBox.Show("Séléctionner un Multi Code S.V.P!");
                }
                else
                {
                    id_prod = Convert.ToInt32(dataGridView3.Rows[index_cell].Cells[0].Value);
                    code_prod = dataGridView3.Rows[index_cell].Cells[1].Value.ToString();
                    designation = dataGridView3.Rows[index_cell].Cells[2].Value.ToString();
                    prix_unitaire = Convert.ToDecimal(dataGridView3.Rows[index_cell].Cells[3].Value);
                    prix_vente = Convert.ToDecimal(dataGridView3.Rows[index_cell].Cells[4].Value);
                    prix_remise = Convert.ToDecimal(dataGridView3.Rows[index_cell].Cells[5].Value);
                    prix_gros = Convert.ToDecimal(dataGridView3.Rows[index_cell].Cells[6].Value);
                    qte = Convert.ToInt32(dataGridView3.Rows[index_cell].Cells[7].Value);
                    Add_A_MultiCode AMC = new Add_A_MultiCode(this, id_prod, designation, prix_unitaire,
                            prix_vente, prix_remise, prix_gros, qte,code_prod);
                    this.Controls.Add(AMC);

                    AMC.BringToFront();
                }

            }
        }



        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }


        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
