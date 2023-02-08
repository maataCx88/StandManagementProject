using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class barcode : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public barcode(string nameshop)
        {
            InitializeComponent();
            this.nameshop = nameshop;
            Tout_produit_avec_code();
            vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
            //ProduitSansCodeGrid.Columns[6].Width = 10;

            //ProduitSansCodeGrid.BorderStyle = BorderStyle.None;
            ProduitSansCodeGrid.BorderStyle = BorderStyle.None;
            ProduitSansCodeGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ProduitSansCodeGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProduitSansCodeGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            ProduitSansCodeGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ProduitSansCodeGrid.BackgroundColor = Color.White;
            ProduitSansCodeGrid.EnableHeadersVisualStyles = false;
            ProduitSansCodeGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProduitSansCodeGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            ProduitSansCodeGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        string nameshop;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear_all_barcode()
        {
            metroToutProduit.Checked = true;
            RechercheSansCode.Text = string.Empty;
            RechercheSansCode.WaterMark = "Scanner ou chercher un produit ...";
            Tout_produit_avec_code();
            vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
        }
        void SansCode_produit()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlcmd = new SqlDataAdapter("Tout_Produit_without_code_barre", sqlcon);
                    sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        ProduitSansCodeGrid.DataSource = dt;
                    }
                    sqlcon.Close();
                    ProduitSansCodeGrid.Columns[0].Visible = false;
                    ProduitSansCodeGrid.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
            vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
        }

        private void RechercheSansCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RechercheSansCode.Text != string.Empty)
                {
                    if (!metroToutProduit.Checked)
                    {
                        Search_produit(RechercheSansCode.Text);
                    }
                    else
                    {
                        Search_produit_avec_code(RechercheSansCode.Text);
                    }
                }
                else
                {
                    if (!metroToutProduit.Checked)
                    {
                        SansCode_produit();
                    }
                    else
                    {
                        Tout_produit_avec_code();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
        }

        void Search_produit(string desc)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlcmd = new SqlDataAdapter("Tout_Produit_without_code_barre_code_or_name", sqlcon);
                    sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlcmd.SelectCommand.Parameters.AddWithValue("@des", desc);
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        ProduitSansCodeGrid.DataSource = dt;
                    }
                    sqlcon.Close();
                    ProduitSansCodeGrid.Columns[0].Visible = false;
                    vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR CONNEXION");
            }
        }

        void Tout_produit_avec_code()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlcmd = new SqlDataAdapter("Tout_Produit_with_code_barre", sqlcon);
                    sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        ProduitSansCodeGrid.DataSource = dt;
                    }
                    sqlcon.Close();
                    ProduitSansCodeGrid.Columns[0].Visible = false;
                    ProduitSansCodeGrid.Columns[1].Visible = false;
                    vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR CONNEXION");
            }

        }

        private void metroProdSansCode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroToutProduit.Checked)
                {
                    RechercheSansCode.WaterMark = "Scanner ou chercher un produit ...";
                    Tout_produit_avec_code();
                }
                else
                {
                    RechercheSansCode.WaterMark = "Rechercher Par  Désignation ...";
                    SansCode_produit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
        }

        void Search_produit_avec_code(string desc)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlcmd = new SqlDataAdapter("Tout_Produit_with_code_or_name", sqlcon);
                    sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlcmd.SelectCommand.Parameters.AddWithValue("@code", desc);
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        ProduitSansCodeGrid.DataSource = dt;
                    }
                    sqlcon.Close();
                    ProduitSansCodeGrid.Columns[0].Visible = false;
                    ProduitSansCodeGrid.Columns[1].Visible = false;
                    vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR CONNEXION");
            }
        }

        public void generate_barcode()
        {
            if (CodeTextBox.Text == string.Empty)
            {
                MessageBox.Show("Vous devez entrer une Référence S.V.P !");
            }
            else
            {
                try
                {
                    if (metroProdSansCode.Checked)
                    {
                        string reference = CodeTextBox.Text;
                        while (check_reference(reference))
                        {
                            MessageBox.Show("Référence déjà existante \nNous allons le générer à nouveau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reference = reference + "1";
                        }
                        CodeTextBox.Text = reference;
                    }
                    Zen.Barcode.Code128BarcodeDraw brCode =
                    Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox1.Image = brCode.Draw(CodeTextBox.Text, 60);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
                }
            }
        }

        public bool check_reference(string reference)
        {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sda = new SqlDataAdapter("check_reference", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@reference", reference);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    sqlcon.Close();
                    return true;
                }
                else
                {
                    sqlcon.Close();
                    return false;
                }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("add_reference", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@id", Int32.Parse(ProduitSansCodeGrid.CurrentRow.Cells[0].Value.ToString()));
                    sqlcmd.Parameters.AddWithValue("@code", CodeTextBox.Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("OK!", "Ajouter", MessageBoxButtons.OK);
                    metroProdSansCode.Checked = true;
                    SansCode_produit();
                    panel1.Enabled = false;
                    buttonadd.Enabled = false;
                    buttonprint.Enabled = false;
                    CodeTextBox.Text = "";
                    pictureBox1.Image = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR CONNEXION");
            }
        }

        private void ProduitSansCodeGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProduitSansCodeGrid.RowCount != 0 && ProduitSansCodeGrid.CurrentRow.Index != ProduitSansCodeGrid.RowCount)
                {
                    panel1.Enabled = true;
                    if (metroToutProduit.Checked)
                    {
                        CodeTextBox.Text = ProduitSansCodeGrid.CurrentRow.Cells[1].Value.ToString();
                        buttonadd.Enabled = false;
                        buttonprint.Enabled = true;
                    }
                    else
                    {
                        CodeTextBox.Text = DateTime.Today.Year + ProduitSansCodeGrid.CurrentRow.Cells[0].Value.ToString();
                        buttonadd.Enabled = true;
                        buttonprint.Enabled = false;
                    }
                    generate_barcode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }

        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 227, 67);
                //printPreviewDialog1.Document = printDocument1;
                 //printPreviewDialog1.ShowDialog(); //printDocument1.Print();
                PrintDialog PrintDialog1 = new PrintDialog();
                PrintDialog1.Document = printDocument1;

                DialogResult result = PrintDialog1.ShowDialog();

                // If the result is OK then print the document.
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectname = new System.Drawing.RectangleF(0, 1, 150, 0);
            e.Graphics.DrawString(nameshop.ToUpper(), new Font("Hypermarket", 10, FontStyle.Bold), Brushes.Black, new Point(0, 1));

            Zen.Barcode.Code128BarcodeDraw brCode =
                    Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            e.Graphics.DrawImage(brCode.Draw(CodeTextBox.Text, 20), new Point(5, 15));

            e.Graphics.DrawString(CodeTextBox.Text, new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, new Point(0, 35));

            e.Graphics.DrawString(ProduitSansCodeGrid.CurrentRow.Cells[2].Value.ToString(), new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, new Point(0, 44));

            e.Graphics.DrawString("Prix: " + ProduitSansCodeGrid.CurrentRow.Cells[3].Value.ToString() + " DA", new Font("Hypermarket", 11, FontStyle.Bold), Brushes.Black, new Point(0, 53));
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ProduitSansCodeGrid.FirstDisplayedScrollingRowIndex = e.NewValue;
            vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
            
        }

        private void ProduitSansCodeGrid_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = e.NewValue;
            vScrollBar1.Maximum = ProduitSansCodeGrid.RowCount;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
