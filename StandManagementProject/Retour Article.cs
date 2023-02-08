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
using DocumentFormat.OpenXml.Vml;
using System.Data.SqlTypes;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace StandManagementProject
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(Form))]
    public partial class Retour_Article : UserControl
    {
        public Retour_Article(Détails_Facture_Client__Achat_ achat, int idfacture, int idprod, decimal prix_vente, int qte, decimal montant, decimal reste, decimal versée)
        {
            InitializeComponent();
            this.achat = achat;
            this.montant = montant;
            this.reste = reste;
            this.versée = versée;
            this.qte = qte;
            this.idprod = idprod;
            this.prix_vente = prix_vente;
            this.idfacture = idfacture;
            checkBoxRet.Checked = true;
           // MessageBox.Show(" montant " + this.montant + "\n reste" + this.reste);
        }
        decimal montant = 0, reste = 0, versée = 0, prix_vente = 0; int qte = 0, idprod = -1, idfacture;
        Détails_Facture_Client__Achat_ achat;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);

        private void metroButton1_Click(object sender, EventArgs e)
        {
           if (QTERet.Text != string.Empty)
            {
                if (QTERet.Text != "0")
                {
                    if(idprod != 0)
                    {
                        if (checkBoxADD.Checked)
                        {
                            update_qte_prod(idprod, +Convert.ToInt32(QTERet.Text));
                        }
                        else if (checkBoxRet.Checked)
                        {
                            update_qte_prod(idprod, -Convert.ToInt32(QTERet.Text));
                        }
                    }
                    decimal new_price = (prix_vente * Convert.ToInt32(QTERet.Text));
                    if (checkBoxADD.Checked)
                    {
                        montant = montant + new_price;
                        reste = reste + new_price;
                        
                        Update_Vente(idfacture, idprod, -Convert.ToInt32(QTERet.Text));
                        update_facture(idfacture, montant, versée, reste);
                        achat.détailsGrid.Columns.Remove("modify");
                        achat.détailsGrid.Refresh();
                        achat.détailsGrid.DataSource = null;
                        achat.add_image_column();
                        achat.reactivate_deals(montant, versée, reste);
                        achat.détailsGrid.Refresh();
                        achat.Affichage_Vente(idfacture);
                    }
                    else if (checkBoxRet.Checked)
                    {
                        montant = montant - new_price;
                        reste = reste - new_price;
                        Update_Vente(idfacture, idprod, Convert.ToInt32(QTERet.Text));
                        update_facture(idfacture, montant, versée, reste);
                        achat.détailsGrid.Columns.Remove("modify");
                        achat.détailsGrid.Refresh();
                        achat.détailsGrid.DataSource = null;
                        achat.add_image_column();
                        achat.reactivate_deals(montant, versée, reste);
                        achat.détailsGrid.Refresh();
                        achat.Affichage_Vente(idfacture);
                    }
                    else if (checkBoxPRICE.Checked)
                    {
                        /*new_price = Convert.ToDecimal(QTERet.Text);
                        montant = montant -(montant - new_price);
                        if(montant-versée > 0)
                        {
                            reste = montant - versée;
                        }
                        else
                        {
                            versée=montant;
                            reste = 0;
                        }*/
                        
                        Update_price(idfacture, idprod, Convert.ToDecimal(QTERet.Text));
                        achat.calc();

                    }

                    /*if(versée != 0 && (versée - new_price)>0)
                    {
                        versée = versée - new_price;
                    }*/
                    
                    
                    

                    // MessageBox.Show("Retour Efféctué Avec Succées");

                }
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }

        private void checkBoxRet_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxRet.Checked)
            {
                checkBoxADD.Checked = false;
                checkBoxPRICE.Checked = false;
                label1.Text = "Quantitée Retournée";
                QTERet.PromptText = "Entrer Quantité";
            }
            else if (checkBoxADD.Checked)
            {
                Information_prod(idprod);
                checkBoxRet.Checked = false;
                checkBoxPRICE.Checked = false;
                label1.Text = "Quantitée Ajoutée";
                QTERet.PromptText = "Entrer Quantité";
            }
            else if (checkBoxPRICE.Checked)
            {
                Information_prod(idprod);
                checkBoxADD.Checked = false;
                checkBoxRet.Checked = false;
                label1.Text = "Nouveau Prix";
                QTERet.PromptText = "Entrer prix";
            }
        }

        private void QTERet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void QTERet_TextChanged(object sender, EventArgs e)
        {
            if (QTERet.Text != string.Empty)
            {
                if (checkBoxRet.Checked)
                {
                    if (Convert.ToInt32(QTERet.Text) > qte)
                    {
                        MessageBox.Show("Vérifier la Quantité de retour", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        QTERet.Text = string.Empty;
                    }
                }
                else if (checkBoxADD.Checked)
                {
                    
                    if (idprod != 0)
                    {
                        if(Convert.ToInt32(QTERet.Text) > stock)
                        {
                            MessageBox.Show("Vérifier la Quantité à ajouter ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            QTERet.Text = string.Empty;
                        }
                    }
                }
                else if (checkBoxPRICE.Checked)
                {

                    if (idprod != 0)
                    {
                        if (Convert.ToDecimal(QTERet.Text) == 0 ||
                            Convert.ToDecimal(QTERet.Text) > price)
                        {
                            MessageBox.Show("Vérifier la Quantité à ajouter ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            QTERet.Text = string.Empty;
                        }
                    }
                }

            }
        }
        int stock = 0; decimal price = 0,price_r=0;
        void Information_prod(int idprod)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_prod_by_ID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", idprod);
                if(idprod != 0)
                {
                    using (DataTable dt = new DataTable())
                    {
                        sqlcmd.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            stock = Convert.ToInt32(dt.Rows[0][6]);
                            price = Convert.ToDecimal(dt.Rows[0][4]);
                            price_r = Convert.ToDecimal(dt.Rows[0][5]);
                            if (checkBoxADD.Checked)
                            {
                               MessageBox.Show("stock max " + stock);
                            }
                            else if (checkBoxPRICE.Checked)
                            {
                                MessageBox.Show("Prix minimum  " + price_r);
                            }
                           
                        }
                        else
                        {
                            stock = 0;
                        }

                    }
                }
                
                sqlcon.Close();
            }
        }
        void update_qte_prod(int idprod, int pqte)
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
        void Update_price(int idfacture, int idprod, decimal price)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_price_in_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", idfacture);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@idprod", idprod);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@price", price);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }
        void update_facture(int id, decimal montant, decimal versé, decimal reste)
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
    }

}
