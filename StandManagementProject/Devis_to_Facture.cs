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
using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Microsoft.VisualBasic.Devices;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System.IO;

namespace StandManagementProject
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(Form))]
    public partial class Devis_to_Facture : Form
    {
        DataGridView metroGrid1;
        public Devis_to_Facture(int id_facture, decimal montant, decimal versé, decimal reste, decimal remise, int id_user, Détails_Devis DVS, string state, DataGridView dataGridView)
        {
            InitializeComponent();
            this.metroGrid1 = dataGridView;
            this.id_facture = id_facture;
            
            this.montant = montant;
            this.versé = versé;
            this.reste = reste;
            this.remise = remise;
            this.DVS = DVS;
            this.id_user = id_user;
            this.state = state;
            if (this.state == "En Attente")
            {
                this.metroTextMontantTTL.Text = this.montant.ToString();
                this.metroTextMHT.Text = this.montant.ToString();
                this.metroTextMVersé.Text = this.versé.ToString();
                this.metroTextMReste.Text = this.reste.ToString();
                get_client_by_facture_ID(this.id_facture);
                get_client_information(this.id_client);
            }

        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id_facture = -1; decimal montant = -1, versé = -1, reste = -1, remise = -1;
        int id_client = -1, id_user = -1;
        Détails_Devis DVS;
        string state = string.Empty;
        decimal new_montant = -1, new_versé = -1, new_reste = -1, new_remise = -1, new_tva = -1;
        private void Devis_to_Facture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.OnKeyDown(new KeyEventArgs(Keys.F5));
                this.Dispose();
                this.Hide();
            }
        }

        private void metroTextMVersé_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (sender as MetroTextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            /*if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf(',') > -1) && && (e.KeyChar != ','))
            {
                e.Handled = true;
            }*/
        }

        private void metroTextPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as MetroTextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroTextMHT_TextChanged(object sender, EventArgs e)
        {
            if (this.state == "En Attente")
            {
                if (metroTextMHT.Text == string.Empty && metroTextMTVA.Text == string.Empty)
                {

                    metroTextMVersé.Enabled = false;
                }
                else if (metroTextMHT.Text != string.Empty && metroTextMTVA.Text != string.Empty)
                {

                    metroTextMVersé.Enabled = true;
                }
                metroTextMVersé.Text = "0";
                metroTextMReste.Text = metroTextMHT.Text;
            }
                
        }

        private void metroTextCompte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '/') && ((sender as MetroTextBox).Text.IndexOf('/') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void metroTextMVersé_TextChanged(object sender, EventArgs e)
        {
            if (this.state == "En Attente")
            {
                if (metroTextMVersé.Text != string.Empty)
                {
                    if (Convert.ToDecimal(metroTextMVersé.Text) <= Convert.ToDecimal(metroTextMHT.Text))
                    {
                        metroTextMReste.Text = (Convert.ToDecimal(metroTextMHT.Text) - Convert.ToDecimal(metroTextMVersé.Text)).ToString("#.000");

                    }
                    else
                    {
                        metroTextMReste.Text = "0";
                    }
                }
                else
                {
                    metroTextMVersé.Text = "0";
                }
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
        private void Devis_to_Facture_Load(object sender, EventArgs e)
        {

        }
        private void metroTextMontantTTL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (metroTextMontantTTL.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroTextTVA_TextChanged(object sender, EventArgs e)
        {
            if (this.state == "En Attente")
            {
                if (metroTextTVA.Text != string.Empty)
                {
                    new_tva = Convert.ToDecimal(metroTextTVA.Text) / 100;
                    new_montant = Convert.ToDecimal(metroTextMontantTTL.Text);
                    metroTextMTVA.Text = (new_tva * (new_montant - Convert.ToDecimal(metroTextRemise.Text))).ToString("#.000");
                    new_montant = Convert.ToDecimal(metroTextMontantTTL.Text) -
                    Convert.ToDecimal(metroTextRemise.Text);
                    metroTextMHT.Text = (new_montant + (new_tva * new_montant)).ToString("#.000");


                }
                else
                {
                    metroTextTVA.Text = "0";
                    //metroTextMTVA.Text = string.Empty;
                    //metroTextMHT.Text = string.Empty;
                    //metroTextMVersé.Text = string.Empty;
                }
            }
                
        }


        public void pass_to_impression()
        {
            metroDateTime1.Enabled = false;
            //metroTextNomPrénom.Enabled = false;
            //metroTextPhone.Enabled = false;
            metroTextMontantTTL.Enabled = false;
            metroTextTVA.Enabled = false;
            metroTextMVersé.Enabled = false;

            metroTextRemise.Enabled = false;

            metroTextMReste.Enabled = false;

            metroTextMHT.Enabled = false;

            metroTextMTVA.Enabled = false;

            //metroTextCompte.Enabled = false;

            //metroTextAdresse.Enabled = false;

            //metroTextLivreur.Enabled = false;
            afficher_bon(this.id_facture);
            ConfirmBill.Text = "Imprimer";
            ConfirmBill.Enabled = true;
        }
        void calc_tva(decimal mtva,decimal net_montant,decimal remise)
        {
            metroTextMontantTTL.Text = (net_montant - mtva + remise).ToString("#.000");
            metroTextTVA.Text = ((mtva / (net_montant - mtva )) * 100).ToString("#");
            metroTextMTVA.Text = mtva.ToString();
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
                    metroTextNomPrénom.Text = client;
                    téléphone = dt.Rows[0][2].ToString();
                    metroTextPhone.Text = téléphone;
                    emp = dt.Rows[0][3].ToString();
                    net_Total = Convert.ToDecimal(dt.Rows[0][4]);
                    //metroTextMontantTTL.Text = net_Total.ToString();
                    net_Versé = Convert.ToDecimal(dt.Rows[0][5]);
                    metroTextMVersé.Text = net_Versé.ToString();
                    net_Remise = Convert.ToDecimal(dt.Rows[0][6]);
                    metroTextRemise.Text = net_Remise.ToString();
                    net_Reste = Convert.ToDecimal(dt.Rows[0][7]);
                    metroTextMReste.Text = net_Reste.ToString();
                    net_HT = Convert.ToDecimal(dt.Rows[0][8]);
                    metroTextMHT.Text = net_HT.ToString();
                    net_TVA = Convert.ToDecimal(dt.Rows[0][9]);
                    //metroTextMTVA.Text = net_TVA.ToString();
                    calc_tva(net_TVA, net_Total, net_Remise);
                    compte = dt.Rows[0][10].ToString();
                    metroTextCompte.Text = compte;
                    adresse = dt.Rows[0][11].ToString();
                    metroTextAdresse.Text = adresse;
                    livreur = dt.Rows[0][12].ToString();
                    metroTextLivreur.Text = livreur;
                    vendeur = Convert.ToInt32(dt.Rows[0][13]);
                    clt = Convert.ToInt32(dt.Rows[0][14]);
                    facture = Convert.ToInt32(dt.Rows[0][15]);
                }
                sqlcon.Close();
            }
        }

        private void metroTextRemise_TextChanged(object sender, EventArgs e)
        {
            if(this.state == "En Attente")
            {
                if (metroTextRemise.Text != string.Empty)
                {
                    metroTextTVA.Enabled = true;
                    metroTextMHT.Text = (Convert.ToDecimal(metroTextMontantTTL.Text) - Convert.ToDecimal(metroTextRemise.Text)).ToString("#.000");
                }
                else
                {
                    metroTextRemise.Text = "0";
                    this.metroTextMontantTTL.Text = this.montant.ToString("#.000");
                    metroTextTVA.Text = "0";
                    metroTextTVA.Enabled = false;

                }
            }
            

        }

        void get_client_by_facture_ID(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_client_by_Facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    id_client = Convert.ToInt32(dt.Rows[0][0]);
                }
                sqlcon.Close();
            }
        }
        void get_client_information(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_client_information", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_client", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    metroTextNomPrénom.Text = dt.Rows[0][0].ToString();
                    metroTextPhone.Text = dt.Rows[0][1].ToString();
                    metroTextPhone.Enabled = metroTextNomPrénom.Enabled = false;
                }
                sqlcon.Close();
            }
        }
        void ADD_BON_LIVRASION(int Facture, int Client, int USER, decimal TOTAL_HT, decimal TOTAL_TVA,
            string LIVREUR, string Compte, string ADRESSE)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_Bon_livraison_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture_devis", Facture);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_client", Client);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_user", USER);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@total_HT", TOTAL_HT);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@total_TVA", TOTAL_TVA);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@Livreur", LIVREUR);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@compte_bancaire", Compte);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@adresse", ADRESSE);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@Date_Facturation ", metroDateTime1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }

        //associate devis to facture client
        void associate_devis_to_facture(int id_devis,int id_facture_client)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("associate_as_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_devis", id_devis);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id_facture_client);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        int id_facture_associated = -1;
        void check_if_associated(int id_devis)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("check_if_facture_client_is_associated", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_devis", id_devis);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    id_facture_associated = Convert.ToInt32(dt.Rows[0][0]);
                }
                sqlcon.Close();
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
        private void ConfirmBill_Click(object sender, EventArgs e)
        {
            if (ConfirmBill.Text == "Confirmer")
            {
                if (metroTextLivreur.Text == string.Empty || metroTextCompte.Text == string.Empty
                || metroTextAdresse.Text == string.Empty)
                {
                    MessageBox.Show("Veuillez remplir les information de client S.V.P!");
                }
                else
                {
                    /*if(metroTextRemise.Text == string.Empty)
                    {
                        metroTextRemise.Text = "0";
                    }
                    if (metroTextMTVA.Text == string.Empty)
                    {
                        metroTextMTVA.Text = "0";
                    }
                    if(metroTextMHT.Text == string.Empty)
                    {
                        metroTextMHT.Text = metroTextMontantTTL.Text;
                    }
                    if (metroTextMVersé.Text != string.Empty)
                    {
                        if (Convert.ToDecimal(metroTextMVersé.Text) <= Convert.ToDecimal(metroTextMHT   .Text))
                        {
                            metroTextMReste.Text = (Convert.ToDecimal(metroTextMHT.Text) - Convert.ToDecimal(metroTextMVersé.Text)
                                - Convert.ToDecimal(metroTextRemise.Text)).ToString();

                        }
                        else
                        {
                            metroTextMReste.Text = "0";
                        }
                    }
                    else
                    {
                        metroTextMVersé.Text = "0";
                        metroTextMReste.Text = metroTextMHT.Text;
                    }*/
                    DialogResult rs = MessageBox.Show("Confirmer les réglement pour cette Facture ?" +
                        " \n TVA "+ metroTextTVA.Text + 
                        " \n montant HT " + metroTextMHT.Text +
                        " \n Remise " + metroTextRemise.Text +
                        " \n Total TTC Facture " + metroTextMontantTTL.Text +
                        " \n Versé " + metroTextMVersé.Text + 
                        " \n Reste " + metroTextMReste.Text, "Confirmation"
                        , MessageBoxButtons.YesNo);
                    if(rs == DialogResult.Yes)
                    {
                        decimal new_versé = 0, new_reste = 0, new_TOTAL_TVA = 0, new_TOTAL_HT = 0;
                        reste = Convert.ToDecimal(metroTextMReste.Text);
                        if (metroTextMVersé.Text == string.Empty)
                        {
                            versé = 0;
                        }
                        else
                        {
                            versé = Convert.ToDecimal(metroTextMVersé.Text);
                        }
                        if (metroTextRemise.Text == string.Empty)
                        {
                            remise = 0;
                        }
                        else
                        {
                            remise = Convert.ToDecimal(metroTextRemise.Text);
                        }
                        if (metroTextMHT.Text == string.Empty)
                        {
                            new_TOTAL_HT = 0;
                        }
                        else
                        {
                            new_TOTAL_HT = Convert.ToDecimal(metroTextMHT.Text);
                        }
                        if (metroTextMTVA.Text == string.Empty)
                        {
                            new_TOTAL_TVA = 0;
                        }
                        else
                        {
                            new_TOTAL_TVA = Convert.ToDecimal(metroTextMTVA.Text);


                        }
                        if(metroTextTVA.Text == string.Empty)
                        {

                        }
                        else
                        {

                        }
                        ADD_BON_LIVRASION(this.id_facture, this.id_client, this.id_user, new_TOTAL_HT,
                            new_TOTAL_TVA, metroTextLivreur.Text, metroTextCompte.Text, metroTextAdresse.Text);
                        DVS.reactivate_deals(Convert.ToDecimal(metroTextMHT.Text),
                            Convert.ToDecimal(metroTextMVersé.Text), Convert.ToDecimal(metroTextMReste.Text),
                            Convert.ToDecimal(metroTextRemise.Text), "Validée");
                        DVS.valider_devis();
                        
                        associate_devis_to_facture(this.id_facture, DVS.id_facture);
                        //check_if_associated(this.id_facture);
                        //MessageBox.Show("ID FACTURE IS " + id_facture_associated);
                        //update_vente(id_facture_associated);
                        //DVS.upadte_facture_devis(this.id_facture, Convert.ToDecimal(metroTextMHT.Text),
                        //Convert.ToDecimal(metroTextMVersé.Text),
                        //Convert.ToDecimal(metroTextMReste.Text), Convert.ToDecimal(metroTextRemise.Text), "En Attente");
                        //DVS.reactivate_deals(Convert.ToDecimal(metroTextMHT.Text),
                           // Convert.ToDecimal(metroTextMVersé.Text), 
                           // Convert.ToDecimal(metroTextMReste.Text),
                           // Convert.ToDecimal(metroTextRemise.Text), "En Attente");


                        this.Dispose();
                        this.Hide();
                        DVS.Dispose();
                        DVS.Hide();
                        //hna zid code
                        print();
                        
                        MessageBox.Show("Devis Validée avec succées!");
                    }
                    /**/


                }
            }
            else
            {
                print();
            }
        }

        bool liv = false;
        bool facture = false;
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

            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(200, 20));

            e.Graphics.DrawString(key.GetValue("Type").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 45));

            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 65));

            e.Graphics.DrawString("Téléphone: "+key.GetValue("phone").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 85));

            e.Graphics.DrawString("E-Mail: "+ key.GetValue("Email").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 105));

            e.Graphics.DrawString("N° de RC: "+ key.GetValue("RC").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 125));

            e.Graphics.DrawString("NIF: "+ key.GetValue("NIF").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 145));

            e.Graphics.DrawString("Art.. Imp.: "+ key.GetValue("Art").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 165));

            e.Graphics.DrawString("NIS: "+ key.GetValue("NIS").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 185));

            e.Graphics.DrawString("N° de compte bancaire: "+ key.GetValue("NCB").ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 205));

            if (!liv && !facture)
            {
                e.Graphics.DrawString("BON DE COMMANDE", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));
            }
            else if (liv && !facture)
            {
                e.Graphics.DrawString("BON DE LIVRAISON", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));
            }
            else
            {
                e.Graphics.DrawString("FACTURE", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(525, 50));
            }

            e.Graphics.DrawString("N° " + id_facture, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(525, 80));

            e.Graphics.DrawString("DATE " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(525, 110));

            e.Graphics.DrawString("CLIENT: " + metroTextNomPrénom.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, 140));

            int m = 140;

            m += 30;

            if (liv || facture)
            {
                e.Graphics.DrawString("LIVREUR: " + metroTextLivreur.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(525, m));
            }


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

            for (; rowI <= metroGrid1.Rows.Count - 1; rowI++)
            {
                isbig = false;
                string article = metroGrid1.Rows[rowI].Cells[3].Value.ToString();
                n += 30;
                if (article.Length >= 25)
                {
                    article = article.Insert(24, "\n");
                    isbig = true;
                }
                e.Graphics.DrawString(article, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(20, n));
                e.Graphics.DrawString(metroGrid1.Rows[rowI].Cells[4].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(metroGrid1.Rows[rowI].Cells[7].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(450, n));
                i += decimal.Parse(metroGrid1.Rows[rowI].Cells[7].Value.ToString());
                e.Graphics.DrawString(metroGrid1.Rows[rowI].Cells[9].Value.ToString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(600, n));

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


            if (rowI > metroGrid1.Rows.Count - 1)
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
                e.Graphics.DrawString(metroTextMontantTTL.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Remise: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(metroTextRemise.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Net à payer HT:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(metroTextMHT.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total TVA("+metroTextTVA.Text+"%):", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));          
                e.Graphics.DrawString(metroTextMTVA.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                n += 15;
                e.Graphics.DrawString("Total TTC:", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, n));
                e.Graphics.DrawString(metroTextMHT.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, n));

                n += 25;
                e.Graphics.DrawLine(myPen, 300, n, 800, n);

                e.Graphics.DrawString("Cachet et signature", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(20, n));
                n += 20;
                e.Graphics.DrawLine(myPen, 20, n, 210, n);

                liv = false;
                facture = false;
            }

        }
        public void print()
        {
            if (checkBoxliv.Checked)
            {
                liv = true;
                rowI = -1;
                i = 0;
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 840, 1188);

                /*printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();*/

                liv = true;
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

                liv = true;
                rowI = -1;
                i = 0;
                printDocument1.PrinterSettings.PrintFileName = "test" + id_facture;
                printDocument1.PrinterSettings.PrinterName = "CutePDF Writer";
                printDocument1.Print();
            }

            if (checkBoxfacture.Checked)
            {
                facture = true;
                rowI = -1;
                i = 0;
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 840, 1188);

                /*printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();*/

                facture = true;
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

                facture = true;
                rowI = -1;
                i = 0;
                printDocument1.PrinterSettings.PrintFileName = "test" + id_facture;
                printDocument1.PrinterSettings.PrinterName = "CutePDF Writer";
                printDocument1.Print();
            }

            if (checkBoxcmd.Checked)
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

        }


    }
}
