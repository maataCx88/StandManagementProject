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
using MetroFramework.Controls;
using DocumentFormat.OpenXml.Bibliography;

namespace StandManagementProject
{
    public partial class Détails_Facture_Client__Achat_ : Form
    {
        public Détails_Facture_Client__Achat_(int id, decimal montant, decimal versé, decimal reste, Factureclient fct,string nom_user,string nom_client)
        {
            InitializeComponent();
            this.id = id;
            this.montant = montant;
            this.versé = versé;
            this.reste = reste;
            this.nom_client = nom_client;
            this.nom_user = nom_user;
            this.numlbl.Text = this.id.ToString();
            TotalLbl.Text = this.montant.ToString();
            VersementLbl.Text = this.versé.ToString();
            Restelbl.Text = this.reste.ToString();
            if (this.reste == 0)
            {
                this.metroTextBox1.Enabled = false;
            }
            else
            {
                this.metroTextBox1.Enabled = true;
            }
            add_image_column();
            get_client_from_facture(id);
            Affichage_Vente(id);
            Affichage_reglement(id);
            

          //  this.réglementGrid.Columns[1].Width = 100;
            this.fct = fct;
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

            bunifuDatepicker1.Value = DateTime.Today;

        }
        int id_client;
        string nom_client;
        Factureclient fct;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = 0;string nom_user = "";
        decimal montant = 0, versé = 0, reste = 0;
        public void get_client_from_facture(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_client_from_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.id_client = Convert.ToInt32(dt.Rows[0][0]);
                }
                sqlcon.Close();


            }
        }
        public void add_image_column()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();

            img.Image = (Image)Properties.Resources.update_32px;
            détailsGrid.Columns.Add(img);
            img.HeaderText = "Retour";
            img.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            img.Name = "modify";
            img.Width = 70;
        }
        public void reactivate_deals(decimal new_montant, decimal new_versé, decimal new_reste)
        {
            montant = new_montant;
            versé = new_versé;
            reste = new_reste;
            TotalLbl.Text = new_montant.ToString("#.000");
            VersementLbl.Text = new_versé.ToString("#.000");
            Restelbl.Text = new_reste.ToString("#.000");
        }
        public void Affichage_Vente(int id)
        {
            this.détailsGrid.DataSource = null;
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_vente_by_facture", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.détailsGrid.Columns[1].Visible = false;
                this.détailsGrid.Columns[2].Visible = false;
                //this.détailsGrid.Columns[2].Width = 200;
               // this.détailsGrid.Columns[5].Width = 60;
                

            }
        }
        void Ajouter_Réglement(int id, decimal verse)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", verse);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", bunifuDatepicker1.Value);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void Affichage_reglement(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_reglement_by_id_clt", sqlcon);
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
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != string.Empty)
            {
                if (versé + Convert.ToDecimal(metroTextBox1.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    metroTextBox1.Text = string.Empty;
                }
                else
                {
                    versé = versé + Convert.ToDecimal(metroTextBox1.Text);
                    Ajouter_Réglement(this.id, Convert.ToDecimal(this.metroTextBox1.Text));
                    Affichage_reglement(this.id);
                    reste = montant - versé;
                    Restelbl.Text = reste.ToString();
                    VersementLbl.Text = versé.ToString();
                    upadte_facture(this.id, this.montant, this.versé, this.reste);
                    MessageBox.Show("vérsement réussie !");
                    fct.Affichage_Vente();
                    metroTextBox1.Text = string.Empty;

                    if (this.reste == 0)
                    {
                        this.metroTextBox1.Enabled = false;
                    }
                    else
                    {
                        this.metroTextBox1.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Montant versé vide !");
            }
        }
        public void calc()
        {
            Affichage_Vente(id);
            decimal price = 0;
            decimal qte = 0;
            montant = 0;
            foreach(DataGridViewRow row in détailsGrid.Rows)
            {
                price = Convert.ToDecimal(row.Cells[5].Value);
                qte = Convert.ToDecimal(row.Cells[6].Value);
                montant += price * qte;
            }
            if(reste == 0)
            {
                if(montant-versé > 0)
                {
                    reste = montant - versé;
                }
                else
                {
                    versé = montant;
                    reste = 0;
                }
            }
            else
            {
                reste = montant - versé;
            }
            upadte_facture(id, montant, versé, reste);
            reactivate_deals(montant, versé, reste);
            if (reste != 0)
            {
                metroTextBox1.Enabled = true;
            }
            else
            {
                metroTextBox1.Enabled = false;
            }
        }
        
        private void détailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (détailsGrid.RowCount > 0)
            {
                try
                {
                    if (détailsGrid.Rows[e.RowIndex].Cells["modify"].Selected)
                    {
                        int idprod = Convert.ToInt32(détailsGrid.CurrentRow.Cells[1].Value);
                        decimal prix_vente = Convert.ToDecimal(détailsGrid.CurrentRow.Cells[5].Value);
                        int qte = Convert.ToInt32(détailsGrid.CurrentRow.Cells[6].Value);
                        //MessageBox.Show("QTE " + qte + "ID" + idprod);
                        Retour_Article uc = new Retour_Article(this, id, idprod, prix_vente, qte, montant, reste, versé);
                        this.Controls.Add(uc);
                        uc.BringToFront();
                        
                    }
                }
                catch (Exception) { }

            }
        }

        private void détailsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Détails_Facture_Client__Achat__FormClosed(object sender, FormClosedEventArgs e)
        {
            fct.Affichage_Vente();
            fct.colors();
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
            e.Graphics.DrawString("Bon Comptoir N° " + numlbl.Text, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawString("Utilisateur: " + nom_user, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 127));
            e.Graphics.DrawString("Client: " + nom_client, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 140));

            e.Graphics.DrawLine(myPen, 1, 160, 1000, 160);

            e.Graphics.DrawString("Article", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Prix", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(115, 170));
            e.Graphics.DrawString("Qte", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(170, 170));
            e.Graphics.DrawString("Montant", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 170));
            myPen.Width = 1;
            e.Graphics.DrawLine(myPen, 1, 190, 1000, 190);

            int n = 180;
            decimal i = 0;
            foreach (DataGridViewRow row in détailsGrid.Rows)
            {
                if (row.Cells[6].Value.ToString() != "0,000" && row.Cells[6].Value.ToString() != "0")
                {
                    string article = row.Cells[3].Value.ToString();
                    n += 25;
                    if (article.Length >= 20)
                    {
                        article = article.Insert(19, "\n");
                    }

                    e.Graphics.DrawString(article, new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(10, n));
                    e.Graphics.DrawString(row.Cells[5].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(115, n));
                    e.Graphics.DrawString(row.Cells[6].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(170, n));
                    i += decimal.Parse(row.Cells[6].Value.ToString());
                    e.Graphics.DrawString((decimal.Parse(row.Cells[5].Value.ToString()) * decimal.Parse(row.Cells[6].Value.ToString())).ToString("#.000"), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(225, n));

                }
            }

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            n += 15;
            e.Graphics.DrawString("Total produit:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(i.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Net à payer:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.montant.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Reçu:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.versé.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Restant:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(this.reste.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));
            if(metroTextTransport.Text != "0" && metroTextTransport.Text != string.Empty)
            {
                n += 15;
                e.Graphics.DrawString("Tax de Transport:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(this.metroTextTransport.Text.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));
            }

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            n += 15;
            System.Drawing.RectangleF rectmerci = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("Merci pour votre visite!", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, rectmerci, sf);
            //e.Graphics.DrawString("Merci pour votre visite!", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, new Point(85, n));
            
            n += 15;
            System.Drawing.RectangleF rectarabic = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("في حالة إرجاع السلعة يرجى إحضار وصل التسليم", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, rectarabic, sf);

            n += 15;
            System.Drawing.RectangleF rectdzoftwares = new System.Drawing.RectangleF(0, n, 285, 25);
            e.Graphics.DrawString("DZOFTWARES/ dzoftwares@gmail.com/ 0659785799/ 0555756280", new Font("Hypermarket", 6, FontStyle.Regular), Brushes.Black, rectdzoftwares, sf);
            //e.Graphics.DrawString("DZOFTWARES/ dzoftwares@gmail.com/ 0659785799/ 0555756280", new Font("Hypermarket", 6, FontStyle.Regular), Brushes.Black, new Point(30, n));
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            if (metroTextTransport.Text != "0" && metroTextTransport.Text != string.Empty)
            {
                ajouter_dette(this.id_client, Convert.ToDecimal(metroTextTransport.Text),
                0, Convert.ToDecimal(metroTextTransport.Text));
            }
            
            printDocument1.Print();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        void ajouter_dette(int id, decimal montant, decimal versé, decimal reste)
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
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_dette", DateTime.Now);
                sqlcmd.SelectCommand.ExecuteNonQuery();
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

        private void NoCode_Click(object sender, EventArgs e)
        {
            Prod_list_and_price plp = new Prod_list_and_price(this,id);
            
            if (FormIsOpen(Application.OpenForms, typeof(Prod_list_and_price)))
            {
                MessageBox.Show("Formulaire déja ouvert!");
                plp.BringToFront();
            }
            else
            {
                plp.Show();
            }
        }

        private void Devis_to_Facture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }


        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != string.Empty)
            {
                if (versé + Convert.ToDecimal(metroTextBox1.Text) > montant)
                {
                    MessageBox.Show("Montant versé trés élevé ! \n veuillez refaire le versement");
                    metroTextBox1.Text = string.Empty;
                }
            }
        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        public static bool ControlIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<UserControl>().Any(openform => openform.GetType() == formtype);
        }
        void Update_Vente(int idfacture, int idprod, int pqte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_product_in_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", idfacture);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@idprod", idprod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", pqte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }
        public decimal qte_in_basket = 0;
        public bool exist_in_basket = false;
        public void check_prod_in_basket(int id_prod,decimal prod_qte)
        {
            exist_in_basket=false;
            qte_in_basket = 0;
            foreach (DataGridViewRow row in détailsGrid.Rows )
            {
                if (Convert.ToInt32(row.Cells[1].Value) == id_prod)
                {
                    exist_in_basket = true;
                    qte_in_basket = Convert.ToDecimal(row.Cells[6].Value);
                }
            }
            if (exist_in_basket)
            {
                if(qte_in_basket + 1 < prod_qte)
                {
                    qte_in_basket = qte_in_basket - (qte_in_basket - 1);
                    //MessageBox.Show("new qte " + qte_in_basket);
                    Update_Vente(id, id_prod, -(Convert.ToInt32(qte_in_basket)));
                }
                else
                {
                    MessageBox.Show("Quantité insuffisante");
                }
                //MessageBox.Show("id is " + id_prod + " with qte " + qte_in_basket);
            }
            
            
        }
    }
}
