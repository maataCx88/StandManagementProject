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
using ClosedXML.Excel;

namespace StandManagementProject
{
    public partial class Stock : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Stock()
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
            metroComboBoxstatus.SelectedIndex = 2;

            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true;
            dataGridView3.Columns[3].ReadOnly = true;
            dataGridView3.Columns[4].ReadOnly = true;
            dataGridView3.Columns[5].ReadOnly = true;
            dataGridView3.Columns[6].ReadOnly = true;
            dataGridView3.Columns[7].ReadOnly = true;
            
            vScrollBar1.Maximum = dataGridView3.RowCount;
            InventLbl.Text = calc();
        }
        string calc()
        {
            string s = ""; decimal invent = 0;
            if (dataGridView3.RowCount > 0)
            {
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    if (Convert.ToDecimal(dataGridView3.Rows[i].Cells[7].Value) > 0)
                    {
                        invent += Convert.ToDecimal(dataGridView3.Rows[i].Cells[6].Value) * Convert.ToDecimal(dataGridView3.Rows[i].Cells[7].Value);
                    }
                }
            }
            s = invent.ToString();
            return s;
        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        public static bool UControlIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<UserControl>().Any(openform => openform.GetType() == formtype);
        }
        int id_prod = -1, index_cell = -1; decimal prix_vente = 0, prix_remise = 0, prix_unitaire = 0, prix_gros = 0;
        void add_image_column()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();


            img.Image = (Image)Properties.Resources.update_32px;
            dataGridView3.Columns.Add(img);
            img.HeaderText = "Action";
            img.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            img.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            img.Name = "modify";
            img.Width = 70;
        }
        public void view_stock()
        {
            metroTextBoxsearch.Text = string.Empty;
            if (dataGridView3.Columns.Contains("modify"))
            {
                dataGridView3.Columns.Remove("modify");
            }
            try
            {
                dataGridView3.DataSource = null;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_stock", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
                //nominate();
                InventLbl.Text = calc();
                sqlcon.Close();
                vScrollBar1.Maximum = dataGridView3.RowCount;
                try
                {
                    decimal achtot = 0, ventot = 0, margeben = 0;
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        achtot += Convert.ToDecimal(row.Cells["Prix d'achat"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                        ventot += Convert.ToDecimal(row.Cells["Prix Vente"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                    }
                    margeben = ventot - achtot;
                    achatprice.Text = achtot.ToString();
                    venteprice.Text = ventot.ToString();
                    margeprice.Text = margeben.ToString();
                }
                catch (Exception)
                {
                    achatprice.Text = "0";
                    venteprice.Text = "0";
                    margeprice.Text = "0";
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
            if (!dataGridView3.Columns.Contains("modify"))
            {
                add_image_column();
            }
            dataGridView3.Columns[0].Visible = false;
            metroComboBoxstatus.SelectedIndex = 2;
            InventLbl.Text = calc();
        }

        void nominate()
        {
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "CODE BARE";
            //        dataGridView1.Columns[1].Width = 230;
            dataGridView3.Columns[2].HeaderText = "DESIGNATION";
            //dataGridView1.Columns[2].Width = 280;
            dataGridView3.Columns[3].HeaderText = "PRIX ACHAT";
            //     dataGridView1.Columns[3].Width = 220;
            dataGridView3.Columns[4].HeaderText = "PRIX UNITAIRE";
            //    dataGridView1.Columns[4].Width = 220;
            dataGridView3.Columns[5].HeaderText = "PRIX REMISE";
            //     dataGridView1.Columns[5].Width = 220;
            dataGridView3.Columns[6].HeaderText = "PRIX GROS";
            dataGridView3.Columns[7].HeaderText = "QUANTITE";
            //   dataGridView1.Columns[6].Width = 110;
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
                if (dataGridView3.Columns.Contains("modify"))
                {
                    dataGridView3.Columns.Remove("modify");
                }
                dataGridView3.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_full_prod", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@code", value);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
                sqlcon.Close();
                if (!dataGridView3.Columns.Contains("modify"))
                {
                    add_image_column();
                }
                dataGridView3.Columns[0].Visible = false;
                vScrollBar1.Maximum = dataGridView3.RowCount;
                InventLbl.Text = calc();

                try
                {
                    decimal achtot = 0, ventot = 0, margeben = 0;
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        achtot += Convert.ToDecimal(row.Cells["Prix d'achat"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                        ventot += Convert.ToDecimal(row.Cells["Prix Vente"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                    }
                    margeben = ventot - achtot;
                    achatprice.Text = achtot.ToString();
                    venteprice.Text = ventot.ToString();
                    margeprice.Text = margeben.ToString();
                }
                catch (Exception)
                {
                    achatprice.Text = "0";
                    venteprice.Text = "0";
                    margeprice.Text = "0";
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count > 0)
            {
                if (dataGridView3.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    if (dataGridView3.CurrentRow.Cells[0].Value.ToString() != "")
                    {
                        View_prodcut view = new View_prodcut(Int32.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString()));
                        view.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, contacter DZOFTWARES");
                    }
                }
                else
                {
                    Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                    mb.label1.Text = "Choisissez-en un \ns'il vous plaît.";
                    mb.label1.Location = new Point(80, 20);
                    mb.Show();
                }
            }
        }

        private void metroComboBoxstatus_TextChanged(object sender, EventArgs e)
        {
            string search = metroComboBoxstatus.Text;
            if (search == "DISPONIBLE")
            {
                dataGridView3.DataSource = null;
                view_stock();
            }
            else
            {
                search_stock_by_status(search);
            }

        }

        public void search_stock_by_status(string value)
        {
            try
            {
                dataGridView3.DataSource = null;
                if (dataGridView3.Columns.Contains("modify"))
                {
                    dataGridView3.Columns.Remove("modify");
                }
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter;

                if (value == "FINI")
                {
                    sqlDataAdapter = new SqlDataAdapter("search_stock_by_finished", sqlcon);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    DataTable dtbl = new DataTable();
                    sqlDataAdapter.Fill(dtbl);
                    dataGridView3.DataSource = dtbl;
                    sqlcon.Close();
                    dataGridView3.Columns[0].Visible = false;
                    if (!dataGridView3.Columns.Contains("modify"))
                    {
                        add_image_column();
                    }
                    InventLbl.Text = calc();
                    try
                    {
                        decimal achtot = 0, ventot = 0, margeben = 0;
                        foreach (DataGridViewRow row in dataGridView3.Rows)
                        {
                            achtot += Convert.ToDecimal(row.Cells["Prix d'achat"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                            ventot += Convert.ToDecimal(row.Cells["Prix Vente"].Value) * Convert.ToDecimal(row.Cells["Qte"].Value);
                        }
                        margeben = ventot - achtot;
                        achatprice.Text = achtot.ToString();
                        venteprice.Text = ventot.ToString();
                        margeprice.Text = margeben.ToString();
                    }
                    catch (Exception)
                    {
                        achatprice.Text = "0";
                        venteprice.Text = "0";
                        margeprice.Text = "0";
                    }
                }
                else
                {
                    view_stock();
                }



                //nominate();

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
        public void update_designation_and_qte(int id, string designation, decimal qtes, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g, decimal piéces) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_full_prod", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qtes);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.Parameters.AddWithValue("@piéces", piéces);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView3.CurrentCell.ColumnIndex == 5 || dataGridView3.CurrentCell.ColumnIndex == 4
                || dataGridView3.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        
        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount > 0)
            {
                id_prod = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                if (id_prod != 0)
                {
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
        }

        private void dataGridView3_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = e.NewValue;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView3.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.RowCount > 0)
            {
                string designation = ""; int qte = 0; decimal piéces = 0;
                if (dataGridView3.Columns[e.ColumnIndex].Name == "modify")
                {

                    index_cell = dataGridView3.CurrentRow.Index;
                    id_prod = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                    if (id_prod != 0)
                    {
                        designation = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                        prix_unitaire = Convert.ToDecimal(dataGridView3.CurrentRow.Cells[3].Value);


                        prix_vente = Convert.ToDecimal(dataGridView3.CurrentRow.Cells[4].Value);


                        prix_remise = Convert.ToDecimal(dataGridView3.CurrentRow.Cells[5].Value);


                        prix_gros = Convert.ToDecimal(dataGridView3.CurrentRow.Cells[6].Value);
                        qte = Convert.ToInt32(dataGridView3.CurrentRow.Cells[7].Value);
                        if(dataGridView3.CurrentRow.Cells[8].Value.ToString() == string.Empty)
                        {
                            piéces = 0;
                        }
                        else
                        {
                            piéces = Convert.ToDecimal(dataGridView3.CurrentRow.Cells[8].Value);

                        }
                        
                        UserControl1 uc = new UserControl1(this, id_prod, designation, prix_unitaire, prix_vente, prix_remise, prix_gros, qte, piéces);
                        this.Controls.Add(uc);
                        uc.BringToFront();
                        /*if (UControlIsOpen(Application.OpenForms, typeof(UserControl1)))
                        {
                            MessageBox.Show("Formulaire déja ouvert!");
                        }
                        else
                        {
                            
                            
                        }*/
                        
                    }

                }
                //index_cellv = -1;

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
        
        SaveFileDialog sfd = new SaveFileDialog(){Filter = "Excel |*.xlsx"};
        private void buttonexcel_Click(object sender, EventArgs e)
        {
            /*
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataGridView3.SelectAll();
                    DataObject copydata = dataGridView3.GetClipboardContent();
                    if (copydata != null) Clipboard.SetDataObject(copydata);
                    Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlapp.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                    object miseddata = System.Reflection.Missing.Value;
                    xlWbook = xlapp.Workbooks.Add(miseddata);

                    xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                    xlr.Select();

                    xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    sfd.FileName = "Teachers.xlsx";
                    xlWbook.SaveAs(sfd.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            */
            
            using (SaveFileDialog sfd=new SaveFileDialog() { Filter="Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (dataGridView3.Columns.Contains("modify"))
                        {
                            dataGridView3.Columns.Remove("modify");
                        }
                        using (XLWorkbook workbook = new XLWorkbook())
                        {                          
                            DataTable dt = new DataTable();
                            foreach (DataGridViewColumn col in dataGridView3.Columns)
                            {
                                 dt.Columns.Add(col.Name);
                            }

                            foreach (DataGridViewRow row in dataGridView3.Rows)
                            {
                                DataRow dRow = dt.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dRow[cell.ColumnIndex] = cell.Value;
                                }
                                dt.Rows.Add(dRow);
                            }
                            workbook.Worksheets.Add(dt,"Teachers");
                            workbook.SaveAs(sfd.FileName);
                        }
                        if (!dataGridView3.Columns.Contains("modify"))
                        {
                            add_image_column();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                }
            }
            
        }
    }
}
