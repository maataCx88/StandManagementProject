using MetroFramework.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace StandManagementProject
{
    public partial class Dette_tansport : Form
    {
        public Dette_tansport(int id,string nom)
        {
            InitializeComponent();
           
            this.id = id;
            this.TextNom.Text = nom;
            Affichage_dette(this.id);
            
            
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = 0; decimal montant = 0, versé = 0, reste = 0;
        void Affichage_dette(int id)
        {
            montant =  versé =  reste = 0;
            if (sqlcon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlcmd = new SqlDataAdapter("show_total_transport_by_client", sqlcon);
                    sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", id);
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        if (dt.Rows.Count == 1 && !dt.Rows.Count.Equals(0))
                        {
                            montant += Convert.ToDecimal(dt.Rows[0][0]);
                            versé += Convert.ToDecimal(dt.Rows[0][1]);
                            reste += Convert.ToDecimal(dt.Rows[0][2]);

                        }
                        else
                        {
                            montant = versé = reste = 0;
                        }

                    }
                    
                }
                catch (Exception) { }
                reste = montant - versé;
                if(montant != 0)
                {
                    labelTotal.Text = montant.ToString("#.000");
                    labelVERS.Text = versé.ToString("#.000");
                    labelReste.Text = reste.ToString("#.000");
                }
                else
                {
                    labelTotal.Text = "0,000";
                    labelVERS.Text = "0,000";
                    labelReste.Text = "0,000";
                }
                


                sqlcon.Close();
            }
        }
        void ajouter_dette(int id,decimal montant,decimal versé,decimal reste)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_transport", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_dette", dateTimePicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void delete_dette(int id, decimal versement)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("delete_dette_transport", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versement", versement);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }


        private void metroTextReste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as MetroTextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void metroTextVersé_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as MetroTextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void metroTextVersé_TextChanged(object sender, EventArgs e)
        {
            if(metroTextVersé.Text != string.Empty)
            {
                if(Convert.ToDecimal(metroTextVersé.Text)> montant)
                {
                    MessageBox.Show("Vérifier le montant à verser !");
                }
               
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
            e.Graphics.DrawString("Téléphone: " + key.GetValue("phone").ToString(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectphone, sf);

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 1, 70, 1000, 70);

            System.Drawing.RectangleF rectticket = new System.Drawing.RectangleF(0, 80, 285, 25);
            e.Graphics.DrawString("Dettes de Transport", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawString("Client: " + TextNom.Text, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 127));
            //e.Graphics.DrawLine(myPen, 1, 147, 1000, 147);
            int n = 160;
            decimal i = 0;
            /*//e.Graphics.DrawString("N° Bon", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Montant", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Reste", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(115, 160));
            e.Graphics.DrawString("Date", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(170, 160));
            //e.Graphics.DrawString("Date", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 160));

            myPen.Width = 1;
            e.Graphics.DrawLine(myPen, 1, 175, 1000, 175);

            
            foreach (DataGridViewRow row in dataGridViewDette.Rows)
            {

                n += 25;


                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(115, n));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(170, n));
                i += decimal.Parse(row.Cells[2].Value.ToString());
                //e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(225, n));
            }*/

            //n += 25;
            //e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            
            e.Graphics.DrawString("TOTAL:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.labelTotal.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));
            if(metroTextVersé.Text == string.Empty)
            {
                metroTextVersé.Text = "0,000";
            }
            n += 15;
            e.Graphics.DrawString("Versement:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.versé.ToString("#.000"), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (montant > 0)
            {
                if (metroTextVersé.Text == string.Empty)
                {
                    metroTextVersé.Text = "0,000";
                }
                if (metroTextVersé.Text != string.Empty)
                {
                    ajouter_dette(id, 0, Convert.ToDecimal(metroTextVersé.Text), 0);
                }
                
                Affichage_dette(id);
                delete_dette(id, Convert.ToDecimal(metroTextVersé.Text)+versé);
                //printPreviewDialog1.Document = printDocument1;
               // printPreviewDialog1.Show();
                
                printDocument1.Print();
                metroTextVersé.Text = "";

            }
        }
    }
}
