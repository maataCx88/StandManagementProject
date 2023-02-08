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
using USB_Barcode_Scanner;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Globalization;
using MetroFramework.Controls;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using TextBox = System.Windows.Forms.TextBox;
//200020020222
namespace StandManagementProject
{
    public partial class Vente : Form
    {
        public Vente(/*Plusieurs_Prix_par_Produits prp,Fournisseur frn,ProduitsSansCodeBarre pscb*/string nom_user, int id_user, string phone, string nameshop, string address, string email, string fenetre)
        {
            InitializeComponent();
            metroGrid1.Columns[0].ReadOnly = true;
            metroGrid1.Columns[1].ReadOnly = true;
            metroGrid1.Columns[2].ReadOnly = true;
            metroGrid1.Columns[3].ReadOnly = true;
            metroGrid1.Columns[4].ReadOnly = true;
            metroGrid1.Columns[5].ReadOnly = true;
            metroGrid1.Columns[6].ReadOnly = true;
            metroGrid1.Columns[7].ReadOnly = true;
            metroGrid1.Columns[8].ReadOnly = true;
            metroGrid1.Columns[9].ReadOnly = true;
            metroGrid1.Columns[10].ReadOnly = true;
            metroGrid1.Columns[11].ReadOnly = true;
            metroGrid1.Columns[12].ReadOnly = true;
            metroGrid1.Columns[13].ReadOnly = true;
            metroGrid1.Columns[14].ReadOnly = true;
            id_u = id_user;
            name = nom_user;
            this.nameshop = nameshop;
            this.phone = phone;
            this.address = address;
            this.email = email;
            comboBox1.SelectedIndex = 0;
            //MessageBox.Show("ID USER IS "+ id_u);
            NameTxt.Text = "CLIENT COMPTOIR";
            TotalLbl.Text = montant.ToString();
            last_id_facture_client();
            NumdeBon.Text = (id_facture + 1).ToString();//"0";
            radioVenteDétail.Checked = true;
            CultureInfo fr = new CultureInfo("fr-Fr");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(fr);
            BarcodeScanner barcodeScanner = new BarcodeScanner(CodeBarre);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            this.Fenetre = fenetre;
            
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public int id_facture = 0;
        public int id_f = 1;//id de client
        public int id_p = 0;//id de produt
        public int id_u;//id de user
        public string name;
        public string phone;
        public string nameshop;
        public string address;
        public string email;
        int index_cell = -1;
        decimal prix = -1;
        string Fenetre = "";
        decimal prix_u = -1;//prix_vente 1
        decimal prix_r = -1;//prix_remise 1
        int qte = -1;
        decimal qteC = -1;
        /// <summary>
        /// variable nes7a9houm ki ykoun produit yexisty mara wa7da fi achat
        /// </summary>
        string designp = "";
        decimal ventep = -1;//prix_v 2
        decimal remisep = -1;//prix_remise 2
        decimal grosp = -1;
        public int stockp = -1;
        bool plusieur = false;
        int id_achat = -1;
        bool exist = true;
        bool exist_multi = true;
        public bool existontable = false;
        decimal montant = 0;
        public int total = 0;
        public decimal total_p = 0;
        string scb = "";
        decimal colis = -1;
        decimal pièces_par_colis = -1;
        decimal id__facture_devis = -1;
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            CodeBarre.Text = e.Barcode;
            if (CodeBarre.Text != string.Empty)
            {
                scb = CodeBarre.Text;
                existence(scb);
            }

        }
        void existence(string s)
        {
            Informations_produit(s);
            if (exist)
            {

                total_qte_in_panier(id_p);
                //MessageBox.Show("Total_P is " + total_p);
                if (total_p + 1 <= total)
                {

                    /*Get_Achat_lastId(id_p);
                    affichage_achat_by_produit(id_p);
                    if (plusieur)
                    {
                        DialogResult result = MessageBox.Show("ce produit existe avec plusieurs prix \n vous voulez vendre avec ce prix : " + ventep, "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            update_qte_bycode(CodeBarre.Text);
                            if (!existontable)
                            {
                                this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                                ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1,
                                (1 * ventep).ToString(), remisep.ToString());
                            }


                        }
                        else
                        {
                            Plusieurs_Prix_par_Produits pprp = new Plusieurs_Prix_par_Produits(this, null, id_p);
                            if (FormIsOpen(Application.OpenForms, typeof(Plusieurs_Prix_par_Produits)))
                            {
                                MessageBox.Show("Formulaire déja ouvert!");
                            }
                            else
                            {
                                pprp.Show();
                            }

                        }


                    }
                    else
                    {

                        update_qte_bycode(CodeBarre.Text);
                        if (!existontable)
                        {
                            this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count).ToString(), CodeBarre.Text, designp,
                            ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString());
                        }

                    }*/
                    update_qte_bycode(s);

                    if (!existontable)
                    {

                        if (radioVenteDétail.Checked)
                        {
                            this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count + 1).ToString(), s, designp,
                           ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString(), colis, pièces_par_colis);
                        }
                        else
                        {
                            this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count + 1).ToString(), s, designp,
                            ventep.ToString(), Convert.ToDecimal(grosp).ToString(), stockp.ToString(), 1, (1 * grosp).ToString(), "0",  colis, pièces_par_colis);
                        }
                        //this.metroGrid1.Rows.Add(id, "", (metroGrid1.Rows.Count + 1).ToString(), code_barre, des,
                        //prix_v.ToString(), Convert.ToDecimal(prix_v).ToString(), qte.ToString(), 1, (1 * prix_v).ToString(), prix_r.ToString(), colis, pièces_par_colis);

                    }
                }
                CodeBarre.Text = string.Empty;
                calc();
            }
            else
            {
                Informations_MULTI_CODE(s);
                if (exist_multi)
                {
                    total_qte_in_panier(id_p);
                    if (total_p + 1 <= total)
                    {
                        update_qte_bycode(multi_code_barre_code);
                        if (!existontable)
                        {

                            if (radioVenteDétail.Checked)
                            {
                                this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count + 1).ToString(), multi_code_barre_code, designp,
                               ventep.ToString(), Convert.ToDecimal(ventep).ToString(), stockp.ToString(), 1, (1 * ventep).ToString(), remisep.ToString(),colis, pièces_par_colis);
                            }
                            else
                            {
                                this.metroGrid1.Rows.Add(id_p, "", (metroGrid1.Rows.Count + 1).ToString(), multi_code_barre_code, designp,
                                ventep.ToString(), Convert.ToDecimal(grosp).ToString(), stockp.ToString(), 1, (1 * grosp).ToString(), "0", colis, pièces_par_colis);
                            }

                        }
                    }
                    CodeBarre.Text = string.Empty;
                    multi_code_barre_code = string.Empty;
                    exist_multi = false;
                    exist = false;
                    calc();
                }
                else
                {
                    MessageBox.Show("Produit n'existe pas !");
                    CodeBarre.Text = string.Empty;
                }
            } 
        }


        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }
        bool print = false;
        void valider_vente()
        {
            try
            {
                if (montant != 0)
                {
                    /*MessageBox.Show("id client " + id_f);
                    MessageBox.Show("montant " + montant);
                    MessageBox.Show("user " + id_u);
                    MessageBox.Show("facture N° " + id_facture);*/
                    if (VesréTxt.Text == string.Empty)
                    {
                        VesréTxt.Text = "0";
                        ResteTxt.Text = montant.ToString();
                    }
                    if (RemiseTxt.Text == string.Empty)
                    {
                        RemiseTxt.Text = "0";
                    }
                    ajouter_facture_client(this.montant, Convert.ToDecimal(VesréTxt.Text), Convert.ToDecimal(ResteTxt.Text), Convert.ToDecimal(RemiseTxt.Text));
                    last_id_facture_client();
                    ajouter_reglement_client(this.id_facture, Convert.ToDecimal(VesréTxt.Text));
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        if (metroGrid1.Rows[i].Cells[4].Value.ToString() != "Autre Article")
                        {
                            /*id_p = Convert.ToInt32(metroGrid1.Rows[i].Cells[0].Value);
                            prix_u = Convert.ToDecimal(metroGrid1.Rows[i].Cells[6].Value);
                            qteC = Convert.ToInt32(metroGrid1.Rows[i].Cells[8].Value);
                            decimal totalp = Convert.ToDecimal(metroGrid1.Rows[i].Cells[9].Value);
                            ajouter_vente(this.id_p, this.prix_u, this.qteC);
                            if (metroGrid1.Rows[i].Cells[1].Value.ToString() == string.Empty)
                            {
                                update_qte_prod(id_p, qteC);
                            }*/
                            /*else
                            {
                                id_achat = Convert.ToInt32(metroGrid1.Rows[i].Cells[1].Value);
                                update_achat(this.id_p, this.id_achat, this.qteC);
                            }*/


                            /*MessageBox.Show("Rows" + i + " id_p : " + id_p + " Achat : " + id_achat +
                                "\n prix_u : " + prix_u + " qte : " + qteC + "with total" + totalp);*/
                        }
                        id_p = Convert.ToInt32(metroGrid1.Rows[i].Cells[0].Value);
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[i].Cells[6].Value);
                        decimal new_qteC = Convert.ToDecimal(metroGrid1.Rows[i].Cells[8].Value);
                        decimal totalp = Convert.ToDecimal(metroGrid1.Rows[i].Cells[9].Value);
                        decimal colis_panier = Convert.ToDecimal(metroGrid1.Rows[i].Cells[11].Value);
                        ajouter_vente(this.id_p, this.prix_u, new_qteC);
                        if (id_p != 0)
                        {

                            update_qte_prod(id_p, new_qteC);
                        }
                    }
                    if (print)
                    {
                        //printPreviewDialog1.Document = printDocument1;
                       // printPreviewDialog1.ShowDialog(); 
                       if(PrixNoRéfTxt.Text != string.Empty)
                        {
                            ajouter_dette(id_f, Convert.ToDecimal(PrixNoRéfTxt.Text), 0, Convert.ToDecimal(PrixNoRéfTxt.Text));
                        }
                        printDocument1.Print();
                    }
                    //MessageBox.Show("Opération Réussie");
                    NumdeBon.Text = (id_facture + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Facture " + (id_facture + 1) + " Vide !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur Technique");

            }
        }
        public void total_qte_in_panier(int id)
        {
            total_p = 0;
            for (int i = 0; i < metroGrid1.RowCount; i++)
            {
                if (id == Convert.ToInt32(metroGrid1.Rows[i].Cells[0].Value))
                {
                    total_p += Convert.ToDecimal(metroGrid1.Rows[i].Cells[8].Value);
                }

            }

        }
        public void calc()
        {
            montant = 0;
            for (int i = 0; i < metroGrid1.RowCount; i++)
            {
                montant += Convert.ToDecimal(metroGrid1.Rows[i].Cells[9].Value);
            }
            if(montant == 0)
            {
                TotalLbl.Text ="0";
            }
            else
            {
                TotalLbl.Text = montant.ToString("#.000");
            }
            VesréTxt.Text = montant.ToString("#.000");
            bunifuCustomLabelRemise.Text = montant.ToString("#.000");

        }
        void ReIndex()
        {

            for (int i = 0; i < metroGrid1.RowCount; i++)
            {
                metroGrid1.Rows[i].Cells[2].Value = (i + 1).ToString();
            }

        }
        void ajouter_facture_client(decimal montant, decimal versé, decimal reste, decimal remise)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", this.id_f);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_u", this.id_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_fact", DateTime.Today);
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
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", DateTime.Today);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void ajouter_vente(int prod, decimal prix_u, decimal qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_vente ", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_f", id_facture);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_p", prod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", qte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void affichage_achat_by_produit(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_achat_by_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        //MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit");
                        plusieur = false;
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        //MessageBox.Show("Produit Existe avec plusieurs fois njibou mn la table achat");
                        plusieur = true;
                    }
                }
                sqlcon.Close();
            }
        }
        void get_qte_produit(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_achat_by_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        total = Convert.ToInt32(dt.Rows[0][0]);
                    }

                }
                sqlcon.Close();
            }
        }
        void update_qte_prod(int idprod, decimal pqte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("decrese_qte", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", idprod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", pqte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void update_achat(int idprod, int achat, int pqte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("sale__from_achat ", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", achat);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_p", idprod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", pqte);
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
        void last_id_facture_devis()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_last_facture_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    id__facture_devis = Convert.ToInt32(dt.Rows[0][0]);
                }
                sqlcon.Close();
            }
        }
        void ajouter_facture_devis(decimal montant, decimal versé, decimal reste, decimal remise)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_facture_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", this.id_f);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_u", this.id_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_fact", DateTime.Today);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void ajouter_devis(int prod, decimal colis, decimal prix_u, decimal qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_f", id__facture_devis);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_p", prod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@colis", colis);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", qte);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void Informations_produit(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_prod_by_code", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        exist = true;
                        id_p = Convert.ToInt32(dt.Rows[0][0]);
                        designp = dt.Rows[0][2].ToString();
                        ventep = Convert.ToDecimal(dt.Rows[0][4]);
                        remisep = Convert.ToDecimal(dt.Rows[0][5]);
                        grosp = Convert.ToDecimal(dt.Rows[0][7]);
                        stockp = Convert.ToInt32(dt.Rows[0][6]);
                        total = Convert.ToInt32(dt.Rows[0][6]);
                        colis = Convert.ToDecimal(dt.Rows[0][8]);
                        pièces_par_colis = Convert.ToDecimal(dt.Rows[0][8]);
                        if (colis != 0)
                        {
                            colis = -1;
                        }
                        else { pièces_par_colis = 0; }
                        //MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id : "+id_p );

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //MessageBox.Show("Produit n'existe pas !");
                        //CodeBarre.Text = string.Empty;
                        exist = false;

                    }
                }
                sqlcon.Close();
            }
        }


        public void update_qte_byachat(int achat)
        {
            int quantité = 0; existontable = false;
            if (metroGrid1.RowCount - 1 > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {

                    if (row.Index != metroGrid1.Rows.Count - 1 && row.Cells[1].Value.ToString() != string.Empty)
                    {
                        if (achat == Convert.ToInt32(row.Cells[1].Value.ToString()))
                        {

                            existontable = true;
                            quantité = Convert.ToInt32(row.Cells[8].Value);
                            if ((quantité + 1) <= stockp)
                            {
                                row.Cells[8].Value = (quantité + 1).ToString();
                                row.Cells[9].Value = Convert.ToDecimal(Convert.ToDecimal(row.Cells[8].Value) * Convert.ToDecimal(row.Cells[6].Value)).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Qte max " + stockp);
                            }
                            break;

                        }
                    }



                }
            }
        }
        public void update_qte_bydes(string des)
        {
            int quantité = 0; existontable = false;
            if (metroGrid1.RowCount > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {

                    if (row.Index != metroGrid1.RowCount)
                    {
                        if (des == row.Cells[4].Value.ToString() && row.Cells[1].Value.ToString() == string.Empty)
                        {

                            existontable = true;
                            quantité = Convert.ToInt32(row.Cells[8].Value);
                            if ((quantité + 1) <= stockp)
                            {
                                row.Cells[8].Value = (quantité + 1).ToString();
                                row.Cells[9].Value = Convert.ToDecimal(Convert.ToDecimal(row.Cells[8].Value) * Convert.ToDecimal(row.Cells[6].Value)).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Qte max " + stockp);
                            }
                            break;



                        }
                    }



                }
            }
        }
        public void update_qte_bycode(string code)
        {
            int quantité = 0; existontable = false;
            if (metroGrid1.RowCount > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {

                    if (row.Index != metroGrid1.RowCount)
                    {
                        if (code == row.Cells[3].Value.ToString() && row.Cells[1].Value.ToString() == string.Empty)
                        {

                            existontable = true;
                            quantité = Convert.ToInt32(row.Cells[8].Value);
                            if ((quantité + 1) <= stockp)
                            {
                                row.Cells[8].Value = (quantité + 1).ToString();
                                row.Cells[9].Value = Convert.ToDecimal(Convert.ToInt32(row.Cells[8].Value) * Convert.ToDecimal(row.Cells[6].Value)).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Qte max " + stockp);
                            }
                            break;

                        }
                    }



                }
            }
        }

        void Get_Achat_lastId(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_id_achat_by_prod", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        id_achat = Convert.ToInt32(dt.Rows[0][0]);
                        //MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id achat: " + id_achat);

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Produit n'existe pas !");
                    }
                }
                sqlcon.Close();
            }
        }
        public void ajouter_article_sans_code(int id, string id_a, string des, decimal prix_v, decimal prix_r, int qte, decimal colis, decimal pièces_par_colis)
        {
            this.metroGrid1.Rows.Add(id, id_a, (metroGrid1.Rows.Count + 1).ToString(), "N/A", des,
                prix_v.ToString(), Convert.ToDecimal(prix_v).ToString(), qte.ToString(), 1, (1 * prix_v).ToString(), prix_r.ToString(), colis, pièces_par_colis);
            
        }
        public void ajouter_article_avec_code(int id, string code_barre, string des, decimal prix_v, decimal prix_r, int qte, decimal colis, decimal pièces_par_colis)
        {
            this.metroGrid1.Rows.Add(id, "", (metroGrid1.Rows.Count + 1).ToString(), code_barre, des,
                prix_v.ToString(), Convert.ToDecimal(prix_v).ToString(), qte.ToString(), 1, (1 * prix_v).ToString(), prix_r.ToString(), colis, pièces_par_colis);
            
        }
        public void vider_tous_cas()
        {
            
            metroGrid1.Columns[6].ReadOnly = true;
            metroGrid1.Columns[8].ReadOnly = true;
            metroGrid1.Columns[11].ReadOnly = true;
            print = false;
            comboBox1.SelectedIndex = 0;
            this.designp = "";
            this.ventep = -1;
            this.remisep = -1;
            this.stockp = -1;
            this.plusieur = false;
            this.id_achat = -1;
            this.exist = true;
            this.id_f = 1;
            this.id_p = 0;
            this.index_cell = -1;
            this.prix = -1;
            this.prix_u = -1;
            this.prix_r = -1;
            this.qte = -1;
            this.qteC = -1;
            this.colis = -1;
            this.pièces_par_colis = -1;
            montant = 0;
            TotalLbl.Text = "0";
            bunifuCustomLabelRemise.Text = "0"; 
            CodeBarre.Text = string.Empty;
            PrixNoRéfTxt.Text = string.Empty;
            QteNoRéftxt.Text = string.Empty;
            RemiseTxt.Text = string.Empty;
            RenduTxt.Text = string.Empty;
            VesréTxt.Text = string.Empty;
            RenduTxt.Text = string.Empty;
            metroGrid1.Rows.Clear();
            NameTxt.Text = "CLIENT COMPTOIR";
            PhoneFourTxt.Text = string.Empty;
            radioVenteDétail.Checked = true;
            radioVenteGros.Checked = false;
            last_id_facture_client();
            NumdeBon.Text = (id_facture + 1).ToString();//"0";
            CodeBarre.Focus();
        }
        private void RecherchOrAddFour_Click(object sender, EventArgs e)
        {
            Client frn = new Client(this);
            if (FormIsOpen(Application.OpenForms, typeof(Client)))
            {
                MessageBox.Show("Formulaire déja ouvert!");
                frn.Show();
            }
            else
            {
                frn.Show();
            }


        }


        public void pass_to_datagrid(int id, int id_a, string des, decimal prix_v, decimal prix_r, int qte)
        {
            this.metroGrid1.Rows.Add(id, id_a, (metroGrid1.Rows.Count + 1).ToString(), scb, des,
                prix_v.ToString(), Convert.ToDecimal(prix_v).ToString(), qte.ToString(), 1, (1 * prix_v).ToString(), prix_r.ToString());

        }

        private void CodeBarre_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.RowCount > 0)
            {
                if(index_cell != -1)
                {



                    if (metroGrid1.Columns[e.ColumnIndex].Index == 13)
                    {
                        DialogResult result = MessageBox.Show("Vous voulez annuler cet article", "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            montant -= Convert.ToDecimal(metroGrid1.CurrentRow.Cells[9].Value);
                            metroGrid1.Rows.RemoveAt(metroGrid1.CurrentRow.Index);
                            TotalLbl.Text = montant.ToString();
                            ReIndex();
                            index_cell = -1;
                            foreach (DataGridViewRow row in metroGrid1.Rows)
                            {
                                row.Cells[6].ReadOnly =true;
                                row.Cells[8].ReadOnly = true;
                                row.Cells[11].ReadOnly = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opération annulé");
                        }
                    }
                    else if (metroGrid1.Columns[e.ColumnIndex].Index == 14 && metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {

                        prix = -1;
                        prix_u = -1;
                        qte = -1;
                        qteC = -1;
                        metroGrid1.EditMode = DataGridViewEditMode.EditOnEnter;
                        index_cell = metroGrid1.CurrentRow.Index;
                        metroGrid1.Rows[index_cell].Cells[6].ReadOnly = false;
                        metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                        }
                        else
                        {

                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;
                        }

                        for (int i = 0; i < metroGrid1.RowCount; i++)
                        {
                            if (i != index_cell)
                            {
                                metroGrid1.Rows[i].Cells[6].ReadOnly = true;
                                metroGrid1.Rows[i].Cells[8].ReadOnly = true;
                                metroGrid1.Rows[i].Cells[11].ReadOnly = true;
                            }
                        }
                        prix_u = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.CurrentRow.Cells[7].Value);
                       // qteC = Convert.ToInt32(metroGrid1.CurrentRow.Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[10].Value);
                        decimal colis_panier = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal colis_pièces = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        if (colis_pièces == 0)
                        {
                            MessageBox.Show("Pas de colis ");
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            MessageBox.Show("piéces par Colis  " + colis_pièces);
                        }

                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        /*MessageBox.Show("Total is " + total);
                        MessageBox.Show("Totalp is " + total_p);*/
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }

                    }
                }
            }
        }

        private void metroGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as DataGridTextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (metroGrid1.CurrentCell.ColumnIndex == 6 || metroGrid1.CurrentCell.ColumnIndex == 8 || metroGrid1.CurrentCell.ColumnIndex == 11) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    
                    
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                        && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }



        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NoCode_Click(object sender, EventArgs e)
        {
            ProduitsSansCodeBarre prb = new ProduitsSansCodeBarre(this);
            if (FormIsOpen(Application.OpenForms, typeof(ProduitsSansCodeBarre)))
            {
                MessageBox.Show("Formulaire déja ouvert!");
                prb.BringToFront();
            }
            else
            {
                
                prb.BringToFront();
                prb.Show();
            }
        }

        private void NoRéf_Click(object sender, EventArgs e)
        {
            /*if (PrixNoRéfTxt.Text == string.Empty || QteNoRéftxt.Text == string.Empty)
            {
                MessageBox.Show("Veuillez saisir le prix et la qte S.V.P!");
            }
            else
            {
                decimal price = Convert.ToDecimal(PrixNoRéfTxt.Text);

                if (comboBox1.SelectedIndex == 1)
                {
                    decimal qte = Convert.ToDecimal(QteNoRéftxt.Text) / 1000;
                    price = price * qte;
                    this.metroGrid1.Rows.Add("0", "", (metroGrid1.Rows.Count + 1).ToString(), "000000000000", "Autre Article", "", ((double)Convert.ToDecimal(PrixNoRéfTxt.Text)), "", qte.ToString(),
                    price.ToString(), "");
                }
                else
                {
                    this.metroGrid1.Rows.Add("0", "", (metroGrid1.Rows.Count + 1).ToString(), "000000000000", "Autre Article", "", ((Decimal)Convert.ToDecimal(PrixNoRéfTxt.Text)), "", QteNoRéftxt.Text,
                    (Convert.ToDecimal(PrixNoRéfTxt.Text) * Convert.ToDecimal(QteNoRéftxt.Text)).ToString(), "");
                }

                PrixNoRéfTxt.Text = QteNoRéftxt.Text = string.Empty;
                CodeBarre.Focus();
            }*/
        }

        private void PrixNoRéfTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

        }

        private void metroGrid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calc();
        }

        private void ConfirmBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                print = true;
                valider_vente();

                


                if (Fenetre == "En Attente")
                {
                    this.Hide();
                }
                else
                {
                    vider_tous_cas();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
        }

        private void VesréTxt_TextChanged(object sender, EventArgs e)
        {
            
            if (montant != 0)
            {
                if (VesréTxt.Text != string.Empty)
                {
                    if (RemiseTxt.Text != string.Empty)
                    {
                        if ((montant-Convert.ToDecimal(VesréTxt.Text)-Convert.ToDecimal(RemiseTxt.Text)) > 0)
                        {
                            
                            ResteTxt.Text = (montant - Convert.ToDecimal(VesréTxt.Text) - Convert.ToDecimal(RemiseTxt.Text)).ToString("#.000");
                        }
                        else
                        {
                            //bunifuCustomLabelRemise.Text = "0,000";
                            ResteTxt.Text = "0,000";
                        }
                        bunifuCustomLabelRemise.Text = (montant - Convert.ToDecimal(RemiseTxt.Text)).ToString("#.000");
                    }
                    else
                    {
                        bunifuCustomLabelRemise.Text = montant.ToString("#.000");
                        ResteTxt.Text = (montant - Convert.ToDecimal(VesréTxt.Text)).ToString("#.000");
                    }
                }
                else
                {
                    if (RemiseTxt.Text != string.Empty)
                    {
                        if ((montant - Convert.ToDecimal(RemiseTxt.Text)) > 0)
                        {
                            //bunifuCustomLabelRemise.Text = (montant  - Convert.ToDecimal(RemiseTxt.Text)).ToString("#.000");
                            ResteTxt.Text = (montant - Convert.ToDecimal(RemiseTxt.Text)).ToString("#.000");
                        }
                        else
                        {
                            //bunifuCustomLabelRemise.Text = "0,000";
                            ResteTxt.Text = "0,000";
                        }
                        bunifuCustomLabelRemise.Text = (montant - Convert.ToDecimal(RemiseTxt.Text)).ToString("#.000");
                    }
                    else
                    {
                        bunifuCustomLabelRemise.Text = montant.ToString("#.000");
                        ResteTxt.Text = montant .ToString("#.000");
                    }
                    
                }
                

            }
            else
            {
                VesréTxt.Text = string.Empty;
                RemiseTxt.Text = string.Empty;
                ResteTxt.Text = string.Empty;
                RenduTxt.Text = string.Empty;
            }
        }

        private void Confirm2_Click(object sender, EventArgs e)
        {
            valider_vente();
            MessageBox.Show("Impression en cours");
        }

        private void resetfields_Click(object sender, EventArgs e)
        {
            /*QteNoRéftxt.Text = PrixNoRéfTxt.Text = string.Empty;
            CodeBarre.Focus();*/
        }

        private void metroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.RowCount != 0)
            {

                if (index_cell != -1)
                {

                    if (metroGrid1.Rows[index_cell].Cells[6].Value == null || Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) == 0)
                    {
                        metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString("#.000");
                        metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");


                    }
                    else
                    {
                        if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) > prix_u
                            || Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) < prix_r)
                        {
                            MessageBox.Show("à ne pas dépasser " + prix_u + " \n et pas moins de " + prix_r);
                            metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString("#.000");
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                        }
                    }
                    if (metroGrid1.Rows[index_cell].Cells[8].Value == null || Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) == 0)
                    {
                        metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");


                    }
                    else
                    {

                        if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) > qte /*|| (total_p+1)> total */)
                        {
                            MessageBox.Show("quantité" + Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) + " insuffisante, max "
                                 + qte);
                            metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                            metroGrid1.Rows[index_cell].Cells[11].Value = "0";
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");
                        }

                    }
                    if (metroGrid1.Rows[index_cell].Cells[11].Value == null && metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_cell].Cells[11].Value = "-1";
                        metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString("#.000");
                        metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                    }
                    else if (metroGrid1.Rows[index_cell].Cells[11].Value.ToString() != "-1" && metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[12].Value) <= qte )
                        {
                            //metroGrid1.Rows[index_cell].Cells[11].Value.ToString() == "1"
                            //|| metroGrid1.Rows[index_cell].Cells[11].Value.ToString() == "0"
                            string v = metroGrid1.Rows[index_cell].Cells[11].Value.ToString();
                            string v2 = metroGrid1.Rows[index_cell].Cells[12].Value.ToString();
                            if (v == "0")
                            {
                                metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                                metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                            }
                            else
                            {
                                decimal piéces = Convert.ToDecimal(v) * Convert.ToDecimal(v2);
                                if (piéces > qte)
                                {
                                    metroGrid1.Rows[index_cell].Cells[11].Value = "1";
                                    metroGrid1.Rows[index_cell].Cells[8].Value = v2;
                                    metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                                }
                                else
                                {
                                    metroGrid1.Rows[index_cell].Cells[8].Value = piéces;
                                    metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("quantité" + Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value) + " insuffisante, max "
                                 + qte);
                            metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                            metroGrid1.Rows[index_cell].Cells[11].Value = "0";
                            metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString("#.000");

                        }
                    }
                    metroGrid1.Refresh();
                    metroGrid1.EditMode = DataGridViewEditMode.EditOnEnter;
                    metroGrid1.Rows[index_cell].Cells[6].ReadOnly = false;
                    metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                    if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                    }
                    else
                    {
                        metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;
                    }
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        if (i != index_cell)
                        {
                            metroGrid1.Rows[i].Cells[6].ReadOnly = true;
                            metroGrid1.Rows[i].Cells[8].ReadOnly = true;
                            metroGrid1.Rows[i].Cells[11].ReadOnly = true;
                        }
                    }

                    calc();
                }

            }
        }

        private void Vente_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Vente_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F1)       // Focus on grid
            {
                DialogResult result = MessageBox.Show("Annuler Vente", "Question ?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    vider_tous_cas();
                }
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F2)       // En attence
            {
                Vente vt = new Vente(name, id_u, phone, nameshop, address, email,"En Attente");
                vt.CenterToScreen();
                vt.Top -= 20;
                vt.Show();
            }
            if (e.KeyCode == Keys.F3)       // Autre Article
            {
                PrixNoRéfTxt.Focus();
                NoRéf_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F4)       // Modify price + qte
            {
                FOCUS_ON_GRID();
                if (metroGrid1.RowCount > 0)
                {
                    if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {
                        
                        index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                        /*index_cell = metroGrid1.Rows.Count - 1;
                        metroGrid1.Rows[index_cell].Selected = true;
                        metroGrid1.Focus();*/
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                        //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                        decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                        }
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        //MessageBox.Show("Total is " + total);
                        // MessageBox.Show("Totalp is " + total_p);
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }
                        modify_qte(index_cell, 6);
                    }
                }
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F5)       // Modify price + qte
            {
                FOCUS_ON_GRID();
                if (metroGrid1.RowCount > 0)
                {
                    if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {
                        index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                        /*index_cell = metroGrid1.Rows.Count - 1;
                        metroGrid1.Rows[index_cell].Selected = true;
                        metroGrid1.Focus();*/
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                        //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                        decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                        }
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        //MessageBox.Show("Total is " + total);
                        // MessageBox.Show("Totalp is " + total_p);
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }
                        modify_qte(index_cell, 8);
                    }
                }
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F6)       // Modify price + qte
            {
                FOCUS_ON_GRID();
                if (metroGrid1.RowCount > 0)
                {
                    if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {
                        index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                        //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                        decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                        }
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        //MessageBox.Show("Total is " + total);
                        // MessageBox.Show("Totalp is " + total_p);
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }
                        modify_qte(index_cell, 11);
                    }
                }
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F7)       // focus 
            {
                // CodeBarre.Focus();
                new Add_article_permanently(this).Show() ;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F8)       // remove
            {
                FOCUS_ON_GRID();
                DialogResult result = MessageBox.Show("Annuler Article", "Question ?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    if (metroGrid1.RowCount > 0)
                    {
                        if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                        {
                            index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                            /*index_cell = metroGrid1.Rows.Count - 1;
                            metroGrid1.Rows[index_cell].Selected = true;
                            metroGrid1.Focus();*/
                            prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                            qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                            //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                            prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                            prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                            decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                            decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                            if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                            {
                                metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                                //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                            }
                            else
                            {
                                metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                            }
                            //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                            int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                            total_qte_in_panier(idprod);
                            get_qte_produit(idprod);
                            //MessageBox.Show("Total is " + total);
                            // MessageBox.Show("Totalp is " + total_p);
                            if ((total_p + 1) <= total)
                            {
                                metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                            }
                            else
                            {

                                //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                            }
                            remove_from_basket(index_cell);
                            /*if (metroGrid1.Rows[index_cell].Cells[4].Value.ToString() == "Autre Article")
                            {
                                remove_from_basket(metroGrid1.CurrentRow.Index);

                            }
                            else
                            {
                                
                            }*/
                        }
                        else
                        {
                            //remove_from_basket(metroGrid1.CurrentRow.Index);
                            metroGrid1.Rows.Remove(metroGrid1.CurrentRow);
                            calc();
                        }

                    }

                }

                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F9)       // détail
            {
                radioVenteDétail.Checked = true;
                radioVenteGros.Checked = false;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10)       // gros
            {
                radioVenteDétail.Checked = false;
                radioVenteGros.Checked = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F11)       // save and print
            {
                print = true;
                ConfirmBillBtn_Click(sender, e);
                e.SuppressKeyPress = true;


            }
            if (e.KeyCode == Keys.F12)       // save only
            {
                ConfirmBillBtn2_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Subtract)       // save only
            {
                FOCUS_ON_GRID();
                if (metroGrid1.RowCount > 0)
                {
                    if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {
                        index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                        /*index_cell = metroGrid1.Rows.Count - 1;
                        metroGrid1.Rows[index_cell].Selected = true;
                        metroGrid1.Focus();*/
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                        //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                        decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                        }
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        //MessageBox.Show("Total is " + total);
                        // MessageBox.Show("Totalp is " + total_p);
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }
                        if (index_cell != -1)
                        {
                            if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[11].Value.ToString()) < 1)
                            {
                                decimal qte = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value);
                                qte--;
                                if (qte >= 1)
                                {
                                    metroGrid1.Rows[index_cell].Cells[8].Value = qte.ToString();
                                    metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();
                                    calc();
                                }
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("séléctionner d'abord ");
                        }
                    }
                }
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Add)       // save only
            {
                FOCUS_ON_GRID();
                if (metroGrid1.RowCount > 0)
                {

                    if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                    {
                        index_cell = metroGrid1.Rows[metroGrid1.Rows.IndexOf(metroGrid1.CurrentRow)].Index;
                        /*index_cell = metroGrid1.Rows.Count - 1;
                        metroGrid1.Rows[index_cell].Selected = true;
                        metroGrid1.Focus();*/
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                        qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                        //qteC = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[8].Value);
                        prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                        prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                        decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                        decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                        if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                            //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                        }
                        else
                        {
                            metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;

                        }
                        //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                        int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                        total_qte_in_panier(idprod);
                        get_qte_produit(idprod);
                        //MessageBox.Show("Total is " + total);
                        // MessageBox.Show("Totalp is " + total_p);
                        if ((total_p + 1) <= total)
                        {
                            metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                        }
                        else
                        {

                            //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                        }
                        if (index_cell != -1)
                        {
                            if (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[11].Value.ToString()) < 1)
                            {
                                decimal qte = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value);
                                decimal qteC = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[7].Value);
                                qte++;
                                if (qte <= qteC)
                                {
                                    metroGrid1.Rows[index_cell].Cells[8].Value = qte.ToString();
                                    metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();
                                    calc();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("séléctionner d'abord !");
                        }

                    }
                }
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.ControlKey)       // save only
            {
                pictureBox2_Click(sender, e);
            }

        }
        void remove_from_basket(int index_row)
        {
            if (index_row == -1)
            {
                MessageBox.Show("Séléctionner un article pour supprimer");
            }
            else
            {
                metroGrid1.Rows.RemoveAt(index_row);
                calc();
                TotalLbl.Text = montant.ToString();
                ReIndex();
                index_cell = -1;
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    row.Cells[6].ReadOnly = true;
                    row.Cells[8].ReadOnly = true;
                    row.Cells[11].ReadOnly = true;
                }
            }
        }
        void modify_qte(int index_row, int index_cellule)
        {
            if (index_row == -1)
            {
                MessageBox.Show("Séléctionner un article pour modifier  !");
            }
            else
            {
                if (metroGrid1.Rows[index_row].Cells[4].Value.ToString() != "Autre Article")
                {
                    /*prix_u = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[5].Value);
                    qte = Convert.ToInt32(metroGrid1.CurrentRow.Cells[7].Value);
                    qteC = Convert.ToInt32(metroGrid1.CurrentRow.Cells[8].Value);
                    prix = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[6].Value);
                    prix_r = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[10].Value);
                    decimal colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[11].Value);
                    decimal piéce_colis = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[12].Value);
                    if (metroGrid1.Rows[index_row].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_row].Cells[11].ReadOnly = false;
                        //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                    }
                    else
                    {
                        metroGrid1.Rows[index_row].Cells[11].ReadOnly = true;

                    }
                    //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                    int idprod = Convert.ToInt32(metroGrid1.Rows[index_row].Cells[0].Value);
                    total_qte_in_panier(idprod);
                    get_qte_produit(idprod);
                    //MessageBox.Show("Total is " + total);
                    //MessageBox.Show("Totalp is " + total_p);
                    if ((total_p + 1) <= total)
                    {
                        metroGrid1.Rows[index_row].Cells[8].ReadOnly = false;
                    }
                    else
                    {

                        //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                    }
                    if (metroGrid1.Rows[index_row].Cells[6].Value == null || Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[6].Value) == 0)
                    {
                        metroGrid1.Rows[index_row].Cells[6].Value = prix_u.ToString();


                    }
                    else
                    {
                        if (Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[6].Value) > prix_u
                            || Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[6].Value) < prix_r)
                        {
                            MessageBox.Show("à ne pas dépasser " + prix_u + " \n et pas moins de " + prix_r);
                            metroGrid1.Rows[index_row].Cells[6].Value = prix_u.ToString();

                        }
                        else
                        {
                            metroGrid1.Rows[index_row].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[8].Value)).ToString();

                        }
                    }
                    if (metroGrid1.Rows[index_row].Cells[8].Value == null || Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[8].Value) == 0)
                    {
                        metroGrid1.Rows[index_row].Cells[8].Value = "1";


                    }
                    else
                    {

                        if (Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[8].Value) > qte )
                        {
                            MessageBox.Show("quantité" + Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[8].Value) + " insuffisante, max "
                                 + qte);
                            metroGrid1.Rows[index_row].Cells[8].Value = "1";

                        }
                        else
                        {
                            metroGrid1.Rows[index_row].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_row].Cells[8].Value)).ToString();
                        }

                    }
                    if (metroGrid1.Rows[index_cell].Cells[11].Value == null && metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_cell].Cells[11].Value = "-1";
                        metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        metroGrid1.Rows[index_cell].Cells[6].Value = prix_u.ToString();

                    }
                    else if (metroGrid1.Rows[index_cell].Cells[11].Value.ToString() != "-1" && metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        //metroGrid1.Rows[index_cell].Cells[11].Value.ToString() == "1"
                        //|| metroGrid1.Rows[index_cell].Cells[11].Value.ToString() == "0"
                        string v = metroGrid1.Rows[index_cell].Cells[11].Value.ToString();
                        string v2 = metroGrid1.Rows[index_cell].Cells[12].Value.ToString();
                        if (v == "0")
                        {
                            metroGrid1.Rows[index_cell].Cells[8].Value = "1";
                        }
                        else
                        {
                            decimal piéces = Convert.ToDecimal(v) * Convert.ToDecimal(v2);
                            if (piéces > qte)
                            {
                                metroGrid1.Rows[index_cell].Cells[11].Value = "1";
                                metroGrid1.Rows[index_cell].Cells[8].Value = v2;
                                metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();

                            }
                            else
                            {
                                metroGrid1.Rows[index_cell].Cells[8].Value = piéces;
                                metroGrid1.Rows[index_cell].Cells[9].Value = (Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value) * Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value)).ToString();

                            }

                        }
                    }
                    metroGrid1.RefreshEdit();*/
                    metroGrid1.EditMode = DataGridViewEditMode.EditOnEnter;
                    //metroGrid1.Rows[index_row].Cells[index_cellule].ReadOnly = false;
                    metroGrid1.CurrentCell = metroGrid1.Rows[index_row].Cells[index_cellule];
                    metroGrid1.CurrentCell.Selected = true;
                    if (metroGrid1.Rows[index_row].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_row].Cells[11].ReadOnly = false;
                        //MessageBox.Show("Piéces Par Colis " + piéce_colis);
                    }
                    else
                    {
                        metroGrid1.Rows[index_row].Cells[11].ReadOnly = true;

                    }
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        if (i != index_row)
                        {
                            metroGrid1.Rows[i].Cells[6].ReadOnly = true;
                            metroGrid1.Rows[i].Cells[8].ReadOnly = true;
                            metroGrid1.Rows[i].Cells[11].ReadOnly = true;
                        }
                    }
                    
                    //metroGrid1.Rows[index_cell].Cells[8].Selected = true;
                    
                    calc();
                }
            }
        }
        void FOCUS_ON_GRID()
        {
            if (metroGrid1.RowCount > 0)
            {
                metroGrid1.Select();
                /*prix_u = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[5].Value);
                qte = Convert.ToInt32(metroGrid1.CurrentRow.Cells[7].Value);
                qteC = Convert.ToInt32(metroGrid1.CurrentRow.Cells[8].Value);
                prix = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[6].Value);
                prix_r = Convert.ToDecimal(metroGrid1.CurrentRow.Cells[10].Value);
                //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                total_qte_in_panier(idprod);
                get_qte_produit(idprod);
                /*MessageBox.Show("Total is " + total);
                MessageBox.Show("Totalp is " + total_p);*/
                /*if ((total_p + 1) <= total)
                {
                    metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                }
                else
                {

                    MessageBox.Show(" qte Total " + total_p + " est atteint ");

                }*/
            }
            else
            {
                //MessageBox.Show("Panier Vide");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectname = new System.Drawing.RectangleF(0, 0, 285, 25);
            e.Graphics.DrawString(nameshop.ToUpper(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, rectname, sf);
            //e.Graphics.DrawString("MAGASIN MEDJELLED", new Font("Arial",17,FontStyle.Bold),Brushes.Black,new Point(10,50));

            System.Drawing.RectangleF rectaddress = new System.Drawing.RectangleF(0, 30, 285, 25);
            e.Graphics.DrawString(address.ToUpper(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectaddress, sf);
            //e.Graphics.DrawString("CITE Maamoura -Laghouat-", new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, new Point(55, 80));

            System.Drawing.RectangleF rectphone = new System.Drawing.RectangleF(0, 50, 285, 25);
            e.Graphics.DrawString("Téléphone: " + phone, new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectphone, sf);

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 1, 70, 1000, 70);

            System.Drawing.RectangleF rectticket = new System.Drawing.RectangleF(0, 80, 285, 25);
            e.Graphics.DrawString("Bon Comptoir N° " + +id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawString("Utilisateur: " + name, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 127));
            e.Graphics.DrawString("Client: " + NameTxt.Text, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 142)); 
            e.Graphics.DrawLine(myPen, 1, 160, 1000, 160);

            e.Graphics.DrawString("Article", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Prix", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(115, 170));
            e.Graphics.DrawString("Qte", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(178, 170));
            e.Graphics.DrawString("Montant", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 170));
            myPen.Width = 1;
            e.Graphics.DrawLine(myPen, 1, 185, 1000, 185);

            int n = 170;
            decimal i = 0;
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                string article = row.Cells[4].Value.ToString();
                n += 25;
                if (article.Length >= 20)
                {
                    article = article.Insert(19, "\n");
                }

                e.Graphics.DrawString(article, new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(row.Cells[6].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(115, n));
                e.Graphics.DrawString(row.Cells[8].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(178, n));
                i += decimal.Parse(row.Cells[8].Value.ToString());
                e.Graphics.DrawString(row.Cells[9].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(225, n));
            }

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            n += 15;
            e.Graphics.DrawString("Total produit:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(i.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Net à payer:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(bunifuCustomLabelRemise.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Reçu:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(VesréTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Restant:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(ResteTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("à rendre:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(RenduTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            if (PrixNoRéfTxt.Text != "0" && PrixNoRéfTxt.Text != string.Empty)
            {
                n += 15;
                e.Graphics.DrawString("Tax de Transport:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(this.PrixNoRéfTxt.Text.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));
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

        private void ConfirmBillBtn2_Click(object sender, EventArgs e)
        {
            try
            {

                valider_vente();

                if (Fenetre == "En Attente")
                {
                    this.Close();
                }
                else
                {
                    vider_tous_cas();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }
        }

        private void PrixNoRéfTxt_TextChanged(object sender, EventArgs e)
        {
            if (PrixNoRéfTxt.Text != string.Empty)
            {
                //PrixNoRéfTxt.Text = Convert.ToDecimal(PrixNoRéfTxt.Text).ToString();
                QteNoRéftxt.Text = "1";
            }
            else
            {
                QteNoRéftxt.Text = string.Empty;
            }
        }

        private void VesréTxt_TabIndexChanged(object sender, EventArgs e)
        {
            CodeBarre.Focus();
        }
        void eliminate_non_numeric(string value)
        {
            //value = Regex.Replace(value, "[^0-9]", "");
            existence(value);
        }

        private void TotalLbl_TextChanged(object sender, EventArgs e)
        {
            VesréTxt.Text = string.Empty;
            RemiseTxt.Text = string.Empty;
            ResteTxt.Text = string.Empty;
            RenduTxt.Text = string.Empty;
            bunifuCustomLabelRemise.Text = "0";
        }
        string multi_code_barre_code = "";
        void Informations_MULTI_CODE(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_MULTI_CODE_by_code", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        exist_multi = true;
                        id_p = Convert.ToInt32(dt.Rows[0][0]);
                        multi_code_barre_code = dt.Rows[0][1].ToString();
                        designp = dt.Rows[0][2].ToString();
                        ventep = Convert.ToDecimal(dt.Rows[0][4]);
                        remisep = Convert.ToDecimal(dt.Rows[0][5]);
                        grosp = Convert.ToDecimal(dt.Rows[0][7]);
                        stockp = Convert.ToInt32(dt.Rows[0][6]);
                        total = Convert.ToInt32(dt.Rows[0][6]);
                        colis = Convert.ToDecimal(dt.Rows[0][8]);
                        pièces_par_colis = Convert.ToDecimal(dt.Rows[0][8]);
                        if (colis != 0)
                        {
                            colis = -1;
                        }
                        else { pièces_par_colis = 0; }


                        //MessageBox.Show("Produit Existe avec une seule fois njibou mn la table produit so id : "+id_p );

                    }
                    else if (dt.Rows.Count == 0)
                    {
                        //MessageBox.Show("Produit n'existe pas !");
                        exist_multi = false;
                        //CodeBarre.Text = string.Empty;
                    }
                }
                sqlcon.Close();
            }
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            if (metroGrid1.RowCount > 0)
            {
                if (metroGrid1.CurrentRow.Cells[4].Value.ToString() != "Autre Article")
                {
                    metroGrid1.EditMode = DataGridViewEditMode.EditOnEnter;
                    index_cell = metroGrid1.CurrentRow.Index;
                    metroGrid1.Rows[index_cell].Cells[6].ReadOnly = false;
                    metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                    if (metroGrid1.Rows[index_cell].Cells[12].Value.ToString() != "0")
                    {
                        metroGrid1.Rows[index_cell].Cells[11].ReadOnly = false;
                    }
                    else
                    {
                        metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;
                    }
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        if (i != index_cell)
                        {
                            metroGrid1.Rows[i].Cells[6].ReadOnly = true;
                            metroGrid1.Rows[i].Cells[8].ReadOnly = true;
                        }
                    }
                    prix_u = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[5].Value);
                    qte = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[7].Value);
                    //qteC = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[8].Value);
                    prix = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[6].Value);
                    prix_r = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[10].Value);
                    decimal colis_panier = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[11].Value);
                    decimal colis_pièces = Convert.ToDecimal(metroGrid1.Rows[index_cell].Cells[12].Value);
                    //MessageBox.Show("qte Max " + qte + "\n Prix " + prix + "\n Prix Minimum " + prix_r);
                    if (colis_pièces == 0)
                    {
                        //MessageBox.Show("Pas de colis ");
                        metroGrid1.Rows[index_cell].Cells[11].ReadOnly = true;
                    }
                    else
                    {
                        //MessageBox.Show(" Piéces par Colis  " + colis_pièces);
                    }

                    int idprod = Convert.ToInt32(metroGrid1.Rows[index_cell].Cells[0].Value);
                    total_qte_in_panier(idprod);
                    get_qte_produit(idprod);
                    /*MessageBox.Show("Total is " + total);
                    MessageBox.Show("Totalp is " + total_p);*/
                    if ((total_p + 1) <= total)
                    {
                        metroGrid1.Rows[index_cell].Cells[8].ReadOnly = false;
                    }
                    else
                    {

                        //MessageBox.Show(" qte Total " + total_p + " est atteint ");

                    }
                }
            }
            else
            {
                index_cell = -1;
                for (int i = 0; i < metroGrid1.RowCount; i++)
                {
                    metroGrid1.Rows[i].Cells[6].ReadOnly = true;
                    metroGrid1.Rows[i].Cells[8].ReadOnly = true;
                    metroGrid1.Rows[i].Cells[11].ReadOnly = true;
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (montant == 0)
                {
                    MessageBox.Show("Devis est Vide ! ");
                }
                else
                {
                    if (VesréTxt.Text == string.Empty)
                    {
                        VesréTxt.Text = "0";
                        ResteTxt.Text = montant.ToString();
                    }
                    if (RemiseTxt.Text == string.Empty)
                    {
                        RemiseTxt.Text = "0";
                    }
                    ajouter_facture_devis(this.montant, Convert.ToDecimal(VesréTxt.Text), Convert.ToDecimal(ResteTxt.Text), Convert.ToDecimal(RemiseTxt.Text));
                    last_id_facture_devis();
                    for (int i = 0; i < metroGrid1.RowCount; i++)
                    {
                        id_p = Convert.ToInt32(metroGrid1.Rows[i].Cells[0].Value);
                        prix_u = Convert.ToDecimal(metroGrid1.Rows[i].Cells[6].Value);
                        decimal new_qteC = Convert.ToDecimal(metroGrid1.Rows[i].Cells[8].Value);
                        decimal totalp = Convert.ToDecimal(metroGrid1.Rows[i].Cells[9].Value);
                        decimal colis_panier = Convert.ToDecimal(metroGrid1.Rows[i].Cells[11].Value);
                        ajouter_devis(this.id_p, colis_panier, this.prix_u, new_qteC);
                    }
                    MessageBox.Show("Opération Réussie");

                    //From here
                    
                    //printPreviewDialog2.Document = printDocument2;
                    //printPreviewDialog2.ShowDialog(); 
                    printDocument2.Print();

                    //End here

                    if (Fenetre == "En Attente")
                    {
                        this.Hide();
                    }
                    else
                    {
                        vider_tous_cas();
                    }
                }
                if (Fenetre == "En Attente")
                {
                    this.Hide();
                }
                else
                {
                    vider_tous_cas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERREUR TECHNIQUE");
            }

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectname = new System.Drawing.RectangleF(0, 0, 285, 25);
            e.Graphics.DrawString(nameshop.ToUpper(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, rectname, sf);
            //e.Graphics.DrawString("MAGASIN MEDJELLED", new Font("Arial",17,FontStyle.Bold),Brushes.Black,new Point(10,50));

            System.Drawing.RectangleF rectaddress = new System.Drawing.RectangleF(0, 30, 285, 25);
            e.Graphics.DrawString(address.ToUpper(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectaddress, sf);
            //e.Graphics.DrawString("CITE Maamoura -Laghouat-", new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, new Point(55, 80));

            System.Drawing.RectangleF rectphone = new System.Drawing.RectangleF(0, 50, 285, 25);
            e.Graphics.DrawString("Téléphone: " + phone, new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectphone, sf);

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 1, 70, 1000, 70);

            System.Drawing.RectangleF rectticket = new System.Drawing.RectangleF(0, 80, 285, 25);
            e.Graphics.DrawString("BON DE DEVIS N° " + id__facture_devis, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawString("Utilisateur: " + name, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 127));
            e.Graphics.DrawString("Client: " + NameTxt.Text, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 142));
            e.Graphics.DrawLine(myPen, 1, 160, 1000, 160);

            e.Graphics.DrawString("Article", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Prix", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(115, 170));
            e.Graphics.DrawString("Qte", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(178, 170));
            e.Graphics.DrawString("Montant", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, 170));
            myPen.Width = 1;
            e.Graphics.DrawLine(myPen, 1, 185, 1000, 185);

            int n = 170;
            decimal i = 0;
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                string article = row.Cells[4].Value.ToString();
                n += 25;
                if (article.Length >= 20)
                {
                    article = article.Insert(19, "\n");
                }

                e.Graphics.DrawString(article, new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(10, n));
                e.Graphics.DrawString(row.Cells[6].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(115, n));
                e.Graphics.DrawString(row.Cells[8].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(178, n));
                i += decimal.Parse(row.Cells[8].Value.ToString());
                e.Graphics.DrawString(row.Cells[9].Value.ToString(), new Font("Hypermarket", 7, FontStyle.Regular), Brushes.Black, new Point(225, n));
            }

            n += 25;
            e.Graphics.DrawLine(myPen, 1, n, 1000, n);

            n += 15;
            e.Graphics.DrawString("Total produit:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(i.ToString(), new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Net à payer:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(TotalLbl.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            /*
            n += 15;
            e.Graphics.DrawString("Reçu:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(VesréTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("Restant:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(ResteTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));

            n += 15;
            e.Graphics.DrawString("à rendre:", new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(10, n));
            e.Graphics.DrawString(RenduTxt.Text, new Font("Hypermarket", 8, FontStyle.Bold), Brushes.Black, new Point(225, n));
            */

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

        private void RemiseTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeBarre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Guide gg = new Guide(2);
            gg.Show();
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
    }

}

