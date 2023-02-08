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
using Microsoft.Win32;
using System.Drawing.Printing;

namespace StandManagementProject
{
    public partial class Détail_Facture_Fournisseur : Form
    {
        public Détail_Facture_Fournisseur(int id, decimal total, decimal versé, decimal Reste, Facturefournisseur fct,string fournisseur)
        {
            InitializeComponent();
            this.id = id;
            this.montant = total;
            this.versé = versé;
            this.reste = Reste;
            this.fournisseur = fournisseur; 
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
            détailsGrid.BorderStyle = BorderStyle.None;
            détailsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            détailsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            détailsGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            détailsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            détailsGrid.BackgroundColor = Color.White;
            détailsGrid.EnableHeadersVisualStyles = false;
            détailsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            détailsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            détailsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.fct = fct;
        }
        Facturefournisseur fct;
        string fournisseur;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
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
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void Devis_to_Facture_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Devis_to_Facture_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Devis_to_Facture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        void upadte_facture(int id, decimal montant, decimal versé, decimal reste)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_facture_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.ExecuteNonQuery();
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
                    VersementLbl.Text = versé.ToString();
                    upadte_facture(this.id, this.montant, this.versé, this.reste);

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

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (VerséTxt.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (VerséTxt.Text != string.Empty)
            {
                if (versé + Convert.ToDecimal(VerséTxt.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    VerséTxt.Text = string.Empty;
                }
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
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_four", bunifuDatepicker1.Value);
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
        private void buttonprint_Click(object sender, EventArgs e)
        {
            rowI = -1;
            i = 0;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 840, 1188);

            /*printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();*/

            rowI = -1;
            i = 0;
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.Document = printDocument1;

            DialogResult result = PrintDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

            rowI = -1;
            i = 0;
            printDocument1.PrinterSettings.PrinterName = "CutePDF Writer";
            printDocument1.Print();
        }

        int rowI = -1;
        decimal i = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");

            e.HasMorePages = false;

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectlogo = new System.Drawing.RectangleF(0, 25, 240, 150);
            e.Graphics.DrawImage(pictureBox5.Image, rectlogo);

            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, 60));

            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 85));

            e.Graphics.DrawString("Téléphone: " + key.GetValue("phone").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 105));

            e.Graphics.DrawString("E-Mail: " + key.GetValue("Email").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 125));

            e.Graphics.DrawString("BON D'ACHAT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));


            e.Graphics.DrawString("N° " + numlbl.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(525, 80));

            e.Graphics.DrawString("DATE " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(525, 110));

            e.Graphics.DrawString("FOURNISSEUR: "+ fournisseur, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, 140));

            int m = 140;

            m += 40;
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            m += 20;
            e.Graphics.DrawString("Article", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(20, m));
            e.Graphics.DrawString("Prix", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(300, m));
            e.Graphics.DrawString("Qté", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(450, m));
            e.Graphics.DrawString("Montat", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, m));
            m += 30;
            myPen.Width = 2;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            bool isbig = false;
            int n = (m - 20);
            rowI++;
            //int i = 0;

            for (; rowI <= détailsGrid.Rows.Count - 2; rowI++)
            {
                isbig = false;
                string article = détailsGrid.Rows[rowI].Cells[1].Value.ToString();
                n += 30;
                if (article.Length >= 25)
                {
                    article = article.Insert(24, "\n");
                    isbig = true;
                }
                e.Graphics.DrawString(article, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(20, n));
                e.Graphics.DrawString(détailsGrid.Rows[rowI].Cells[2].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(détailsGrid.Rows[rowI].Cells[5].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(450, n));
                i += decimal.Parse(détailsGrid.Rows[rowI].Cells[5].Value.ToString());
                e.Graphics.DrawString((decimal.Parse(détailsGrid.Rows[rowI].Cells[2].Value.ToString()) * decimal.Parse(détailsGrid.Rows[rowI].Cells[5].Value.ToString())).ToString("#.000"), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(600, n));

                if (isbig)
                    n += 20;

                if (n >= e.PageBounds.Height - 400)
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            /*foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                isbig = false;
                string article = row.Cells[4].Value.ToString();
                n += 30;
                if (article.Length >= 25)
                {
                    article = article.Insert(24, "\n");
                    isbig = true;
                }
                e.Graphics.DrawString(article, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(20, n));
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(row.Cells[8].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(450, n));
                i += Int32.Parse(row.Cells[8].Value.ToString());
                e.Graphics.DrawString(row.Cells[9].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(600, n));

                if (isbig)
                    n += 20;
            }*/


            if (rowI > détailsGrid.Rows.Count - 2)
            {
                n += 25;
                e.Graphics.DrawLine(myPen, 20, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total produit:", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(i.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.montant.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Versé: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.versé.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Reste: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.reste.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                e.Graphics.DrawString("Cachet et signature", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(20, n));
                n += 20;
                e.Graphics.DrawLine(myPen, 20, n, 210, n);
            }
        }
    }
}
