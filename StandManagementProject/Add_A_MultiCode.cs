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
using System.Collections;
using System.Globalization;

namespace StandManagementProject
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(Form))]
    public partial class Add_A_MultiCode : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Add_A_MultiCode(MultiCode MC, int id_prod, string designation, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g, int qte,string code_prod)
        {
            InitializeComponent();
            this.MC = MC;
            if (id_prod != -1)
            {
                this.metroAchat.Text = prix_u.ToString();
                this.metroVente.Text = prix_v.ToString();
                this.metroRemise.Text = prix_r.ToString();
                this.metrogros.Text = prix_g.ToString();
                this.id_prod = id_prod;
                this.prix_u = prix_u;
                this.prix_v = prix_v;
                this.prix_r = prix_r;
                this.prix_g = prix_g;
                this.designation = designation;
                this.qtestock = qte;
                this.code_prod = code_prod;
                this.metroDésignationTxt.Text = designation;
                this.metroQTE.Text = this.qtestock.ToString();
                this.metroValidate.Text = "Modifier";
            }
            metroTextboite.Enabled = metroTextpiéces.Enabled = false;
            metroDésignationTxt.Focus();
            CultureInfo fr = new CultureInfo("fr-Fr");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(fr);

        }
        string code_prod = "none";
        int id_prod = -1, id_exist = -1, last_multi_code = -1; decimal prix_u = -1, prix_v = -1, prix_r = -1, prix_g = -1; MultiCode MC;
        string designation = string.Empty; int qtestock = 0;
        bool exist = false;
        private void metroVente_KeyPress(object sender, KeyPressEventArgs e)
        {
           

           
        }
        void Add_Multi_Code(string des, decimal prix_v, decimal prix_u, decimal prix_r, decimal prix_g, int qte,decimal piéces)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("add_multi_code_2", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@designation ", des);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@prix_v ", prix_v);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@prix_u ", prix_u);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@prix_r ", prix_r);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@qte ", qte);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@prix_g ", prix_g);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@piéces", piéces);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        void last_multicode()
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

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroTextboite.Enabled = metroTextpiéces.Enabled = true;
                metroQTE.Enabled = false;
            }
            else
            {
                metroTextboite.Enabled = metroTextpiéces.Enabled = false;
                metroQTE.Enabled = true;
            }
        }

        private void metroTextboite_TextChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                if (metroTextboite.Text != string.Empty && metroTextpiéces.Text != string.Empty)
                {
                    metroQTE.Text = (Convert.ToDecimal(metroTextboite.Text) * Convert.ToDecimal(metroTextpiéces.Text)).ToString("#");
                }
                else
                {
                    metroQTE.Text = string.Empty;
                }
            }
            else
            {
                metroTextboite.Text = metroTextpiéces.Text = string.Empty;
            }
            
        }

        public void update_designation_and_qte(int id, string designation, int qtes, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_multi_code", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@ID", id);
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qtes);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
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
        public void update_colis(int id, string designation, int qtes, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g,decimal piéces) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_multi_code_colis", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@ID", id);
            sda.SelectCommand.Parameters.AddWithValue("@designation", designation);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qtes);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@prix_g", prix_g);
            sda.SelectCommand.Parameters.AddWithValue("@piéces", piéces);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }
        void update_code()
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("add_code_to_null_code", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        void check_existance_des(string des)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("existance_multi_code_designation", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@designation ", des);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    exist = true;
                    id_exist = (int)dtbl.Rows[0][0];
                }
                else
                {
                    exist = false;
                    id_exist = -1;
                }
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        void Informations_produit(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_prod_by_ID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        code_prod = dt.Rows[0][1].ToString();
                        //MessageBox.Show("code prod " + code_prod);
                    }
                    else if (dt.Rows.Count == 0)
                    {


                    }
                }
                sqlcon.Close();
            }
        }
        private void metroValidate_Click(object sender, EventArgs e)
        {
            if (metrogros.Text == string.Empty || metroRemise.Text == string.Empty || metroVente.Text == string.Empty
               || metroQTE.Text == string.Empty || metroDésignationTxt.Text == string.Empty || metroAchat.Text == string.Empty)
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
                check_existance_des(metroDésignationTxt.Text);
                if (id_exist == this.id_prod)
                {
                    exist = false;
                }
                if (exist)
                {
                    MessageBox.Show("Désignation existe déja \n Vérifié le nom S.V.P");
                    metroDésignationTxt.Text = "";
                    metroDésignationTxt.Focus();
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
                        if (Convert.ToDecimal(metroRemise.Text) > Convert.ToDecimal(metroVente.Text)
                            || Convert.ToDecimal(metroRemise.Text) < Convert.ToDecimal(metroAchat.Text))
                        {
                            MessageBox.Show(" Remise Pas plus de " + metroVente.Text + "\n " +
                                "et pas moins de  " + metroAchat.Text);
                            metroRemise.Text = "";
                            metroRemise.Focus();
                        }
                        else if (metroQTE.Text == "0")
                        {
                            MessageBox.Show(" Quantité non valide !");
                            metroQTE.Text = "";
                            metroQTE.Focus();
                        }
                        else
                        {
                            decimal piéces = -1;
                           this.designation = metroDésignationTxt.Text;
                            this.prix_u = Convert.ToDecimal(this.metroAchat.Text);
                            this.prix_v = Convert.ToDecimal(this.metroVente.Text);
                            this.prix_r = Convert.ToDecimal(this.metroRemise.Text);
                            this.prix_g = Convert.ToDecimal(this.metrogros.Text);
                            this.qtestock = Convert.ToInt32(this.metroQTE.Text);
                            if (this.metroTextpiéces.Text != string.Empty)
                            {
                                piéces = Convert.ToDecimal(this.metroTextpiéces.Text);
                            }
                            else
                            {
                                piéces = 0;
                            }
                            
                            if (id_prod == -1)
                            {
                                Add_Multi_Code(designation, this.prix_v, this.prix_u,
                                this.prix_r, this.prix_g, this.qtestock,piéces);
                                update_code();
                                MessageBox.Show("Nouveau Multi-Code Ajoutée avec succées ! \n Maintenant Veuillez Ajouter la liste des code barres pour ce MULT-CODE  !");
                                last_multicode();
                                Informations_produit(last_multi_code);
                               // MessageBox.Show("Maintenant Veuillez Ajouter la liste des code barres pour ce MULT-CODE  !");
                                Add_to_list_To_A_MultiCode List_code = new Add_to_list_To_A_MultiCode(this.MC, last_multi_code, "Action",code_prod);
                                List_code.Show();
                                this.Hide();
                            }
                            else
                            {
                                //update_designation_and_qte(id_prod, designation, qtestock, prix_u, prix_v, prix_r, prix_g);
                                update_colis(id_prod, designation, qtestock, prix_u, prix_v, prix_r, prix_g,piéces);
                                MessageBox.Show(" MULT-CODE Modifié avec succées  !");

                            }
                            this.MC.view_stock();
                            this.Hide();

                        }
                    }
                }
            }
        }
    }
}
