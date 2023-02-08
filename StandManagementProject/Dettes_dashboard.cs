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
using System.Data.SqlTypes;
using Guna.UI2.WinForms.Suite;
using MetroFramework.Controls;
using System.Windows;
using Point = System.Drawing.Point;
using Microsoft.Win32;

namespace StandManagementProject
{
   public partial class Dettes_dashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Dettes_dashboard(int id_user)
        {
            InitializeComponent();
            affichagefourn();
            actualiser();
            this.id_user = id_user;
            dataGridViewClient.BorderStyle = BorderStyle.None;
            dataGridViewClient.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewClient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClient.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridViewClient.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewClient.BackgroundColor = Color.White;
            dataGridViewClient.EnableHeadersVisualStyles = false;
            dataGridViewClient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            dataGridViewClient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridViewDette.BorderStyle = BorderStyle.None;
            dataGridViewDette.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewDette.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewDette.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridViewDette.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewDette.BackgroundColor = Color.White;
            dataGridViewDette.EnableHeadersVisualStyles = false;
            dataGridViewDette.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDette.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            dataGridViewDette.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.KeyPreview = true;
        }
        int id_index = -1, id_client = -1, id_user = 1, id_facture = -1;
        decimal old_reste, old_versé = 0;
        decimal reste, verse, montant = 0;
        //facture procedures
        void ajouter_facture_client(decimal montant, decimal versé, decimal reste, decimal remise)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", this.id_client);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_u", this.id_user);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_fact", dateTimePicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void ajouter_reglement_client(int id, decimal versé)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", dateTimePicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void upadte_facture(int id, decimal montant, decimal versé, decimal reste)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }
        void last_id_facture_client()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("last_id_client_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    id_facture = Convert.ToInt32(dt.Rows[0][0]);
                }
                sqlcon.Close();
            }
        }
        //Client procedures
        void last_ID_Four()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_last_id_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlcmd.Fill(dt);
                id_client = Convert.ToInt32(dt.Rows[0][0]);
                sqlcon.Close();
            }
        }
        void Ajouter_Four(string nom, string prénom, string phone)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("add_client ", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@nom", nom);
                sqlcmd.Parameters.AddWithValue("@prenom", prénom);
                sqlcmd.Parameters.AddWithValue("@tel", phone);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void affichagefourn()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_clt", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridViewClient.DataSource = dtbl;
            sqlcon.Close();
            dataGridViewClient.Columns[0].Visible = false;
            //   dataGridView2.Columns[2].Width = 200;
        }
        void affichagefacture(int id_clt)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_facture_clt_ID_CLIENT", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id_clt);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridViewDette.DataSource = dtbl;
            sqlcon.Close();
            calc();
        }
        void rech_client(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("search_clt", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@nom", s);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridViewClient.DataSource = dtbl;
            sqlcon.Close();
            dataGridViewClient.Columns[0].Visible = false;
        }
        public void actualiser()
        {
            id_index = id_client = id_facture = -1;
            metroTextNom.Text = metroTextPrénom.Text = metroTextTéléphone.Text = metroTextSearch.Text = string.Empty;
            metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextTéléphone.Enabled = metroTextSearch.Enabled = true;
            metroConfirm.Enabled = true;
            metroDETTES.Text = "Ajouter Dette";
            metroDETTES.Enabled = false;
            metroTextReste.Enabled = metroTextVersé.Enabled = metroTextMontant.Enabled = false;
            metroTextReste.Text = metroTextVersé.Text = metroTextMontant.Text = string.Empty;
            affichagefourn();
            dataGridViewDette.DataSource = null;
            dateTimePicker1.Value = DateTime.Today;
            old_versé = 0;
            reste = verse = montant = 0;
            labelTotal.Visible = labelVERS.Visible = labelReste.Visible = false;
        }
        void unlock_fields(bool b, bool c) //open field of bill to edit ( enable =true);
        {
            metroDETTES.Enabled = b;
            metroTextReste.Enabled = metroTextMontant.Enabled = b;
            metroTextVersé.Enabled = c;
        }
        void calc()
        {
            decimal total = 0, verse = 0, reste = 0;
            labelTotal.Visible = labelVERS.Visible = labelReste.Visible = true;
            foreach(DataGridViewRow row in dataGridViewDette.Rows)
            {
                total += Convert.ToDecimal( row.Cells[1].Value);
                verse += Convert.ToDecimal(row.Cells[2].Value);
                reste += Convert.ToDecimal(row.Cells[3].Value);
            }
            labelTotal.Text = total.ToString("#.000");
            labelVERS.Text = verse.ToString("#.000");
            labelReste.Text = reste.ToString("#.000");
        }
        private void dataGridViewClient_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewClient.RowCount > 0)
            {
                id_index = id_client = id_facture = -1;
                metroTextNom.Text = metroTextPrénom.Text = metroTextTéléphone.Text =  string.Empty;
                metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextTéléphone.Enabled = metroTextSearch.Enabled = false;
                metroDETTES.Text = "Ajouter Dette";
                metroConfirm.Enabled = false;
                metroDETTES.Enabled = true;
                //metroTextReste.Enabled = metroTextVersé.Enabled = metroTextMontant.Enabled = true;
                metroTextReste.Text = metroTextVersé.Text = metroTextMontant.Text = string.Empty;
                dataGridViewDette.DataSource = null;
                dateTimePicker1.Value = DateTime.Today;
                old_versé = 0;
                reste = verse = montant = 0;
                id_client = Convert.ToInt32(dataGridViewClient.CurrentRow.Cells[0].Value.ToString());
                metroTextNom.Text = dataGridViewClient.CurrentRow.Cells[1].Value.ToString();
                metroTextTéléphone.Text = dataGridViewClient.CurrentRow.Cells[2].Value.ToString();
                metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextTéléphone.Enabled = metroTextSearch.Enabled = false;
                metroConfirm.Enabled = false;
                affichagefacture(id_client);
                unlock_fields(true, true);
            }
        }

        private void dataGridViewDette_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewDette.RowCount > 0)
            {
                metroDETTES.Text = "Ajouter Versement";
                id_facture = Convert.ToInt32(dataGridViewDette.CurrentRow.Cells[0].Value.ToString());
                metroTextMontant.Text = dataGridViewDette.CurrentRow.Cells[1].Value.ToString();
                metroTextVersé.Text = dataGridViewDette.CurrentRow.Cells[2].Value.ToString();
                old_versé = Convert.ToDecimal(dataGridViewDette.CurrentRow.Cells[2].Value.ToString());
                metroTextReste.Text = dataGridViewDette.CurrentRow.Cells[3].Value.ToString();
                old_reste = Convert.ToDecimal(dataGridViewDette.CurrentRow.Cells[3].Value.ToString());
                unlock_fields(false, true);
                metroDETTES.Enabled = true;
            }
        }

        private void metroTextVersé_TextChanged(object sender, EventArgs e)
        {
            if (metroTextMontant.Text != string.Empty)
            {

                montant = Convert.ToDecimal(metroTextMontant.Text);
                if (metroTextVersé.Text != string.Empty)
                {

                    if (metroDETTES.Text == "Ajouter Dette")
                    {

                        verse = Convert.ToDecimal(metroTextVersé.Text);
                        if (verse > montant)
                        {
                            metroTextVersé.Text = string.Empty;
                            metroTextReste.Text = metroTextMontant.Text;
                        }
                        else
                        {
                            reste = montant - verse; metroTextReste.Text = reste.ToString();
                        }
                    }
                    else
                    {

                        verse = Convert.ToDecimal(metroTextVersé.Text) + old_versé;
                        if (verse > montant)
                        {
                            metroTextVersé.Text = old_versé.ToString();
                            metroTextReste.Text = old_reste.ToString();
                        }
                        else
                        {
                            reste = montant - verse; metroTextReste.Text = reste.ToString();
                        }
                    }
                }
                else if (metroTextVersé.Text == string.Empty || metroTextVersé.Text == "0")
                {
                    metroTextVersé.Text = string.Empty;
                    metroTextReste.Text = montant.ToString();
                }
            }
        }

        private void metroTextMontant_TextChanged(object sender, EventArgs e)
        {
            if (metroTextMontant.Text != string.Empty)
            {
                montant = Convert.ToDecimal(metroTextMontant.Text);
                metroTextVersé.Text = string.Empty;
                metroTextReste.Text = metroTextMontant.Text;
            }
            else
            {
                metroTextVersé.Text = string.Empty;
                metroTextReste.Text = string.Empty;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewDette.RowCount > 0)
            {
                //printPreviewDialog1.Document = printDocument1;
                //printPreviewDialog1.ShowDialog(); 
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectname = new System.Drawing.RectangleF(0, 0, 285, 25);
            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, rectname, sf);
            //e.Graphics.DrawString("MAGASIN MEDJELLED", new Font("Arial",17,FontStyle.Bold),Brushes.Black,new Point(10,50));

            System.Drawing.RectangleF rectaddress = new System.Drawing.RectangleF(0, 30, 285, 25);
            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectaddress, sf);
            //e.Graphics.DrawString("CITE Maamoura -Laghouat-", new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, new Point(55, 80));

            System.Drawing.RectangleF rectphone = new System.Drawing.RectangleF(0, 50, 285, 25);
            e.Graphics.DrawString("Téléphone: "+ key.GetValue("phone").ToString(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectphone, sf);

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 1, 70, 1000, 70);

            System.Drawing.RectangleF rectticket = new System.Drawing.RectangleF(0, 80, 285, 25);
            e.Graphics.DrawString("Liste des Dettes " , new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawString("Client: " + metroTextNom.Text, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 127));
            e.Graphics.DrawLine(myPen, 1, 147, 1000, 147);

            e.Graphics.DrawString("N° Bon", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Montant", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(115, 160));
            e.Graphics.DrawString("Versé", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(170, 160));
            e.Graphics.DrawString("Reste", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 160));
            //e.Graphics.DrawString("Date", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 160));

            myPen.Width = 1;
            e.Graphics.DrawLine(myPen, 1, 175, 1000, 175);

            int n = 160;
            decimal i = 0;
            foreach (DataGridViewRow row in dataGridViewDette.Rows)
            {
                
                n += 25;
                

                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(115, n));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(170, n));
                i += decimal.Parse(row.Cells[3].Value.ToString());
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(225, n));
            }

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            n += 15;
            e.Graphics.DrawString("TOTAL:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.labelTotal.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Versement:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.labelVERS.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Restant:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.labelReste.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);


            n += 15;
            System.Drawing.RectangleF rectmerci = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("Merci pour votre visite!", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, rectmerci, sf);
            //e.Graphics.DrawString("Merci pour votre visite!", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, new Point(85, n));
            /*
            n += 15;
            System.Drawing.RectangleF rectarabic = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("في حالة إرجاع السلعة يرجى إحضار وصل التسليم", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, rectarabic, sf);

            n += 15;
            System.Drawing.RectangleF rectdzoftwares = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("DZOFTWARES/ dzoftwares@gmail.com/ 0659785799/ 0555756280", new Font("Hypermarket", 6, FontStyle.Regular), Brushes.Black, rectdzoftwares, sf);
            //e.Graphics.DrawString("DZOFTWARES/ dzoftwares@gmail.com/ 0659785799/ 0555756280", new Font("Hypermarket", 6, FontStyle.Regular), Brushes.Black, new Point(30, n));
            */
        }

        private void metroDETTES_Click(object sender, EventArgs e)
        {
            if (metroDETTES.Text == "Ajouter Dette")
            {
                if (metroTextMontant.Text == string.Empty || metroTextMontant.Text == "0")
                {
                    MessageBox.Show("Veuillez Saisir le montant");
                }
                else
                {
                    decimal montant = Convert.ToDecimal(metroTextMontant.Text);
                    decimal versé = 0;
                    if (metroTextVersé.Text == string.Empty)
                    {
                        verse = 0;
                    }
                    else
                    {
                        versé = Convert.ToDecimal(metroTextVersé.Text);
                    }
                    decimal reste = Convert.ToDecimal(metroTextReste.Text);
                    ajouter_facture_client(montant, versé, reste, 0);
                    last_id_facture_client();
                    ajouter_reglement_client(id_facture, versé);
                    actualiser();
                    affichagefacture(id_client);
                }
            }
            else if (metroDETTES.Text == "Ajouter Versement")
            {
                if (metroTextVersé.Text == string.Empty)
                {
                    MessageBox.Show("Veuiillez Ajouter le montant à versé");
                }
                else
                {
                    decimal montant = Convert.ToDecimal(metroTextMontant.Text);
                    decimal reste = Convert.ToDecimal(metroTextReste.Text);
                    upadte_facture(id_facture, montant, this.verse, reste);
                    ajouter_reglement_client(id_facture, Convert.ToDecimal(metroTextVersé.Text));
                    actualiser();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actualiser();

        }

        private void Dettes_dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)       // refresh
            {
                e.SuppressKeyPress = true;
                actualiser();
            }
            if (e.KeyCode == Keys.F4)       // refresh
            {
                e.SuppressKeyPress = true;
                if (id_client > 0)
                {
                    Dette_tansport ds = new Dette_tansport(id_client, metroTextNom.Text + " " 
                        + metroTextPrénom.Text);
                    ds.Show();
                }
                else
                {
                    MessageBox.Show("veuillez séléctionner Un client");
                }
                
                
            }
        }

        private void metroTextSearch_TextChanged(object sender, EventArgs e)
        {
            if (metroTextSearch.Text != String.Empty)
            {
                rech_client(metroTextSearch.Text);
            }
            else
            {
                affichagefourn();
            }
        }

        private void metroTextTéléphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroConfirm_Click(object sender, EventArgs e)
        {
            if (metroTextNom.Text == string.Empty || metroTextPrénom.Text == string.Empty)
            {
                MessageBox.Show("Veuillez remplir toute les cases S.V.P!");
            }
            else
            {
                Ajouter_Four(metroTextNom.Text, metroTextPrénom.Text, metroTextTéléphone.Text);
                MessageBox.Show("Client Ajouté avec succéss!");
                metroTextNom.Enabled = metroTextPrénom.Enabled = metroTextTéléphone.Enabled = false;
                metroConfirm.Enabled = false;
                metroTextSearch.Text = string.Empty;
                last_ID_Four();
                affichagefourn();
                unlock_fields(true, true);
            }
        }
    }
}
