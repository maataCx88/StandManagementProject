using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Détails_Commande_Livraison : Form
    {
        public Détails_Commande_Livraison(int id,string client,string livreur,string tht, string remisestring,string tva, string nettotal)
        {
            InitializeComponent();
            id_facture = id;
            Affichage_Vente(id_facture);

            détailsGrid.BorderStyle = BorderStyle.None;
            détailsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            détailsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            détailsGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            détailsGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            détailsGrid.BackgroundColor = Color.White;
            détailsGrid.EnableHeadersVisualStyles = false;
            détailsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            détailsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            détailsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.client = client;
            this.livreur = livreur;
            this.tht = tht;
            this.remisestring = remisestring;
            this.tva = tva;
            this.nettotal = nettotal;

        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id_facture = 0; decimal montant = 0, versé = 0, reste = 0, remise = 0;
        decimal prix_vente = -1, prix_temp = -1, qteVente = -1, qteStock = -1, prix_v = -1, prix_u = -1;
        string client,livreur,tht,remisestring,tva,nettotal;

        public void Affichage_Vente(int id)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_devis_factureID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.détailsGrid.Columns[0].Visible = false;
                this.détailsGrid.Columns[1].Visible = false;
                this.détailsGrid.Columns[5].Visible = false;
                this.détailsGrid.Columns[10].Visible = false;
                this.détailsGrid.Columns[11].Visible = false;
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











        private void Détails_Devis_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.F3)       // UPDATE
            {

                if (state == "En Attente")
                {
                   
                }
            }*/




        }

        void afficher_bon(int id)
        {
            int bon = -1, facture = -1, vendeur = -1, clt = -1;
            string client = "", téléphone = "", emp = "", compte = "", adresse = "", livreur = "";
            decimal net_Total = -1, net_Versé = -1, net_Remise = -1, net_Reste = -1, net_HT = -1, net_TVA = -1;
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_bon_by_ID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    bon = Convert.ToInt32(dt.Rows[0][0]);
                    client = dt.Rows[0][1].ToString();
                    téléphone = dt.Rows[0][2].ToString();
                    emp = dt.Rows[0][3].ToString();
                    net_Total = Convert.ToDecimal(dt.Rows[0][4]);
                    net_Versé = Convert.ToDecimal(dt.Rows[0][5]);
                    net_Remise = Convert.ToDecimal(dt.Rows[0][6]);
                    net_Reste = Convert.ToDecimal(dt.Rows[0][7]);
                    net_HT = Convert.ToDecimal(dt.Rows[0][8]);
                    net_TVA = Convert.ToDecimal(dt.Rows[0][9]);
                    compte = dt.Rows[0][10].ToString();
                    adresse = dt.Rows[0][11].ToString();
                    livreur = dt.Rows[0][12].ToString();
                    vendeur = Convert.ToInt32(dt.Rows[0][13]);
                    clt = Convert.ToInt32(dt.Rows[0][14]);
                    facture = Convert.ToInt32(dt.Rows[0][14]);
                }
                sqlcon.Close();
            }
        }

        int rowI = -1;
        decimal i = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");

            e.HasMorePages = false;

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            byte[] picData = key.GetValue("Picture") as byte[] ?? null;

            if (picData != null)
            {
                using (MemoryStream ms = new MemoryStream(picData))
                {
                    pictureBox5.Image = Image.FromStream(ms);
                }
            }

            System.Drawing.RectangleF rectlogo = new System.Drawing.RectangleF(25, 60, 150, 110);
            e.Graphics.DrawImage(pictureBox5.Image, rectlogo);

            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(200, 60));

            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 85));

            e.Graphics.DrawString("Téléphone: " + key.GetValue("phone").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 105));

            e.Graphics.DrawString("E-Mail: " + key.GetValue("Email").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 125));

            e.Graphics.DrawString("BON DE LIVRAISON", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));

            e.Graphics.DrawString("N° " + id_facture, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(525, 80));

            e.Graphics.DrawString("DATE " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(525, 110));

            e.Graphics.DrawString("CLIENT: " + this.client, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, 140));

            int m = 140;
            m += 30;
            e.Graphics.DrawString("LIVREUR: " + this.livreur, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, m));


            m += 60;
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            m += 10;
            e.Graphics.DrawString("Article", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(20, m));
            e.Graphics.DrawString("Prix HT", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(300, m));
            e.Graphics.DrawString("Qté", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(450, m));
            e.Graphics.DrawString("Montat HT", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, m));
            m += 30;
            myPen.Width = 2;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            bool isbig = false;
            int n = (m - 20);
            rowI++;
            //int i = 0;

            for (; rowI <= détailsGrid.Rows.Count - 1; rowI++)
            {
                isbig = false;
                string article = détailsGrid.Rows[rowI].Cells[3].Value.ToString();
                n += 30;
                if (article.Length >= 25)
                {
                    article = article.Insert(24, "\n");
                    isbig = true;
                }
                e.Graphics.DrawString(article, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(20, n));
                e.Graphics.DrawString(détailsGrid.Rows[rowI].Cells[4].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(détailsGrid.Rows[rowI].Cells[7].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(450, n));
                i += decimal.Parse(détailsGrid.Rows[rowI].Cells[7].Value.ToString());
                e.Graphics.DrawString(détailsGrid.Rows[rowI].Cells[9].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(600, n));

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


            if (rowI > détailsGrid.Rows.Count - 1)
            {
                n += 25;
                e.Graphics.DrawLine(myPen, 20, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total produit:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(i.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total HT:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.tht, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Remise: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.remisestring, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Net à payer HT:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString((decimal.Parse(this.tht) - decimal.Parse(this.remisestring)).ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                decimal tvacalc;
                tvacalc = decimal.Parse(this.tht) - decimal.Parse(this.remisestring);
                if (decimal.Parse(this.tva) > 0)
                    tvacalc /= decimal.Parse(this.tva);
                else
                    tvacalc = 0;

                n += 15;
                e.Graphics.DrawString("Total TVA(" + tvacalc.ToString("#.0") + "%):", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.tva, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total TTC:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(this.nettotal, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                e.Graphics.DrawString("Cachet et signature", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(20, n));
                n += 20;
                e.Graphics.DrawLine(myPen, 20, n, 210, n);
            }
        }

        private void printrapport_Click(object sender, EventArgs e)
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
            printDocument1.PrinterSettings.PrintFileName = "test" + id_facture;
            printDocument1.PrinterSettings.PrinterName = "CutePDF Writer";
            printDocument1.Print();
        }


        private void Détails_Facture_Client__Achat__FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
