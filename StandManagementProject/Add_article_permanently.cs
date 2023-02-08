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
using System.Globalization;
using MetroFramework.Controls;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;

namespace StandManagementProject
{
    public partial class Add_article_permanently : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Add_article_permanently(Vente vnt)
        {
            InitializeComponent();
            this.vnt = vnt;
        }
        string code_prod = "none";
        int idprod = -1, id_exist = -1, last_multi_code = -1; decimal prix_u = -1, prix_v = -1, prix_r = -1, prix_g = -1; MultiCode MC;
        string designation = string.Empty; int qtestock = 0;
        bool exist = false;
        Vente vnt;

        void ajouterproduit(string code, string design, decimal prix_v, decimal prix_u, decimal prix_r, decimal qte, decimal prix_g, decimal qtepieceboite)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_produit", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@code", code);
            sqlcmd.Parameters.AddWithValue("@designation ", design);
            sqlcmd.Parameters.AddWithValue("@prix_v", prix_v);
            sqlcmd.Parameters.AddWithValue("@prix_u", prix_u);
            sqlcmd.Parameters.AddWithValue("@prix_r", prix_r);
            sqlcmd.Parameters.AddWithValue("@prix_g", prix_g);
            sqlcmd.Parameters.AddWithValue("@qte", qte);
            sqlcmd.Parameters.AddWithValue("@piéce_par_colis", qtepieceboite);

            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        void update_product(int id, decimal qte, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_produit", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qte);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }
        void last_prod_id()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_last_multi_code", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                last_multi_code = Convert.ToInt32(dtbl.Rows[0][0]);
            }
            sqlcon.Close();

        }
        void checkproduct2(string s)
        {
            if (metroTextCode.Text != string.Empty && metroTextCode.Text != "N/A")
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("search_full_prod3", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter("get_prod_by_code", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@code", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count >= 1)
                {
                    metroDésignationTxt.Text = dtbl.Rows[0][2].ToString();
                    metroAchat.Text = dtbl.Rows[0][3].ToString();
                    metroVente.Text = dtbl.Rows[0][4].ToString();
                }
            }
        }
        void check_by_DES_IfExist(string s) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_prodid_bydesignation", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@designation", s);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                idprod = Convert.ToInt32(dt.Rows[0][0]);
            }
            sqlcon.Close();
        }
        void check_by_Code_IfExist(string s) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_prod_by_code", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@code", s);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                idprod = Convert.ToInt32(dt.Rows[0][0]);

            }
            else if (dt.Rows.Count == 0)
            {
                idprod = -1;

            }
            sqlcon.Close();
        }
        int getproductid(string designation)
        {
            int prodid = 0;
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_prodid_bydesignation", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                prodid = Convert.ToInt32(dtbl.Rows[0][0].ToString());
            }
            return prodid;
        }
        private void metroAchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If you want, you can allow decimal (float) numbers
            // checks to make sure only 1 decimal is allowed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
               && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as MetroFramework.Controls.MetroTextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void metroQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        int id_vente = -1;
        private void metroTextCode_TextChanged(object sender, EventArgs e)
        {
            checkproduct2(metroTextCode.Text);
        }
        private void metroValidate_Click(object sender, EventArgs e)
        {
            if (metroDésignationTxt.Text== string.Empty
               || metroQTE.Text == string.Empty  || metroAchat.Text == string.Empty)
            {
                MessageBox.Show("Veuillez Remplir tout les case pour Valider");
                DialogResult result = MessageBox.Show("Voulez Vous quitter cette fenetre", "Sortir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            else
            {
                    if (Convert.ToDecimal(metroVente.Text) < Convert.ToDecimal(metroAchat.Text))
                    {
                        MessageBox.Show(" Prix de vente Pas moins de " + metroAchat.Text);
                        metroVente.Text = "";
                        metroVente.Focus();

                    }
                    else
                    {
                        if (metroQTE.Text == "0")
                        {
                            MessageBox.Show(" Quantité non valide !");
                            metroQTE.Text = "";
                            metroQTE.Focus();
                        }
                        else
                        {
                            if (metroTextCode.Text == string.Empty) /*(!checkproduct(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString()))*/
                            {
                                check_by_DES_IfExist(metroDésignationTxt.Text);
                                if (idprod == -1)
                                {
                                    ajouterproduit("N/A", metroDésignationTxt.Text, Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text),
                                    Convert.ToDecimal(metroAchat.Text), Convert.ToDecimal(metroQTE.Text), Convert.ToDecimal(metroAchat.Text), 0);
                                    id_vente = getproductid(metroDésignationTxt.Text);


                                }
                                else
                                {
                                    update_product(idprod, Convert.ToDecimal(metroQTE.Text), Convert.ToDecimal(metroAchat.Text),
                                    Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text), Convert.ToDecimal(metroAchat.Text));
                                    id_vente = idprod;

                                }
                            vnt.ajouter_article_sans_code(id_vente, "", metroDésignationTxt.Text, Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text),
                            Convert.ToInt32(metroQTE.Text), 0, 0);
                            }
                            else
                            {
                                check_by_Code_IfExist(metroTextCode.Text);
                                if (idprod == -1)
                                {
                                    ajouterproduit(metroTextCode.Text, metroDésignationTxt.Text, Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text),
                                    Convert.ToDecimal(metroAchat.Text), Convert.ToDecimal(metroQTE.Text), Convert.ToDecimal(metroAchat.Text), 0);
                                    id_vente = getproductid(metroDésignationTxt.Text);
                                }
                                else
                                {
                                    update_product(idprod, Convert.ToDecimal(metroQTE.Text), Convert.ToDecimal(metroAchat.Text),
                                    Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text), Convert.ToDecimal(metroAchat.Text));
                                    id_vente = idprod;

                                }
                            vnt.ajouter_article_avec_code(id_vente, metroTextCode.Text, metroDésignationTxt.Text, Convert.ToDecimal(metroVente.Text), Convert.ToDecimal(metroAchat.Text),
                            Convert.ToInt32(metroQTE.Text), 0, 0);
                            }
                            this.Hide();
                        }
                    }
                
            }
        }
    }
}
