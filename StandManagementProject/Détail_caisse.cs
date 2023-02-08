using ClosedXML.Excel;
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Détail_caisse : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);

        DateTimePicker dtps = new DateTimePicker();
        DateTimePicker dtpf = new DateTimePicker();
        string type,user;
        public Détail_caisse(string type,DateTimePicker dtps,DateTimePicker dtpf,string user)
        {
            InitializeComponent();
            this.dtps = dtps;
            this.dtpf = dtpf;
            this.type = type;
            this.user = user;

            if (type == "Journalier")
            {
                dataGridView3.DataSource = null;
                daily();
            }
            else if (type == "Mensuel")
            {
                dataGridView3.DataSource = null;
                monthly();
            }
            else if (type == "Annuel")
            {
                dataGridView3.DataSource = null;
                yearly();
            }
            else
            {
                dataGridView3.DataSource = null;
            }

            labels();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpram,
            int lpram);

        private void pictureandname_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void daily()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Dayli_stat", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateD",this.dtps.Value);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateF", this.dtpf.Value);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
            sqlcon.Close();
        }

        public void monthly()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Monthly_stat", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MonthD", this.dtps.Value.Month);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MonthF", this.dtpf.Value.Month);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@yearD", this.dtps.Value.Year);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@yearF", this.dtpf.Value.Year);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
            sqlcon.Close();
        }

        public void yearly()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Yearly_stat", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@yearD", this.dtps.Value.Year);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@yearF", this.dtpf.Value.Year);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
            sqlcon.Close();
        }

        public void labels()
        {
            //date
            labeldate1.Text = dtps.Value.ToString("dd/MM/yyyy");
            labeldate2.Text = dtpf.Value.ToString("dd/MM/yyyy");

            //Total HT + Total Versement + Total reste + Total vente + Marge HT + Marge %
            decimal tht=0, tv = 0, tr = 0, tve = 0, tmht = 0;
            foreach(DataGridViewRow row in dataGridView3.Rows)
            {
                tht  += Convert.ToDecimal(row.Cells[1].Value);
                tv   += Convert.ToDecimal(row.Cells[2].Value);
                tr   += Convert.ToDecimal(row.Cells[3].Value);
                tve  += Convert.ToDecimal(row.Cells[4].Value);
                tmht += Convert.ToDecimal(row.Cells[5].Value);
            }
            labelTHT.Text = tht.ToString("#.000");
            labelTV.Text = tv.ToString("#.000");
            labelTR.Text = tr.ToString("#.000");
            labelTVE.Text = tve.ToString("#.000");
            labelMHT.Text = tmht.ToString("#.000");
            if(tve != 0)
            labelMP.Text = ((tmht / tve) * 100).ToString("#.000") + "%";
            else
            {
                labelMP.Text = (0).ToString("#.000") + "%";
            }

        }

        private void labelcaisse_Click(object sender, EventArgs e)
        {

        }

        private void NoCode_Click(object sender, EventArgs e)
        {
            rowI = -1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 840, 1188);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            rowI = -1;
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.Document = printDocument1;

            DialogResult result = PrintDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        int rowI = -1;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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

            System.Drawing.RectangleF rectlogo = new System.Drawing.RectangleF(25, 40, 150, 110);
            e.Graphics.DrawImage(pictureBox5.Image, rectlogo);

            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(200, 60));

            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 85));

            e.Graphics.DrawString("Téléphone: " + key.GetValue("phone").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 105));

            e.Graphics.DrawString("E-Mail: " + key.GetValue("Email").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 125));
            
            e.Graphics.DrawString("RAPPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));

            e.Graphics.DrawString("DATE: " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(525, 80));

            e.Graphics.DrawString("EMPLOYEE: "+this.user, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, 110));

            int m = 110;

            m += 30;
            e.Graphics.DrawString(dtps.Value.ToString("dd/MM/yyyy")+" - " + dtpf.Value.ToString("dd/MM/yyyy"), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, m));

            m += 40;
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            m += 20;
            e.Graphics.DrawString("Date", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, m));
            e.Graphics.DrawString("T.HT", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(120, m));
            e.Graphics.DrawString("T.Versement", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(220, m));
            e.Graphics.DrawString("T.Reste", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(360, m));
            e.Graphics.DrawString("T.Vente", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(460, m));
            e.Graphics.DrawString("Marge HT", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(560, m));
            e.Graphics.DrawString("Marge %", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(680, m));
            m += 30;
            myPen.Width = 2;
            e.Graphics.DrawLine(myPen, 20, m, 800, m);

            int n = (m - 20);
            rowI++;
            //int i = 0;

            for (; rowI <= dataGridView3.Rows.Count - 1; rowI++)
            {
                n += 30;
                if (type != "Journalier")
                {
                    e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[0].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(20, n));
                }
                else
                {
                    e.Graphics.DrawString(DateTime.Parse(dataGridView3.Rows[rowI].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(20, n));
                }

                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[1].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(120, n));
                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[2].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(220, n));
                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[3].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(360, n));
                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[4].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(450, n));
                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[5].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(560, n));
                e.Graphics.DrawString(dataGridView3.Rows[rowI].Cells[6].Value.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(680, n));

                if (n >= e.PageBounds.Height - 100)
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


            if (rowI > dataGridView3.Rows.Count - 2)
            {
                n += 25;
                e.Graphics.DrawLine(myPen, 20, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total:", new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(20, n));
                e.Graphics.DrawString(labelTHT.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(120, n));
                e.Graphics.DrawString(labelTV.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(220, n));
                e.Graphics.DrawString(labelTR.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(360, n));
                e.Graphics.DrawString(labelTVE.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(450, n));
                e.Graphics.DrawString(labelMHT.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(560, n));
                e.Graphics.DrawString(labelMP.Text, new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(680, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 20, n, 800, n);

                n += 10;
                e.Graphics.DrawString("Cachet et signature", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, n));
                n += 20;
                e.Graphics.DrawLine(myPen, 20, n, 210, n);
            }
        }

        private void pdfrapport_Click(object sender, EventArgs e)
        {
            rowI = -1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 840, 1188);
            printDocument1.PrinterSettings.PrintFileName = "test";
            printDocument1.PrinterSettings.PrinterName = "CutePDF Writer";
            printDocument1.Print();
        }

        private void excelrapport_Click(object sender, EventArgs e)
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
}
