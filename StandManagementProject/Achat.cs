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

namespace StandManagementProject
{
    public partial class Achat : MetroFramework.Forms.MetroForm
    {
        int idfacture = 0, idprod=0;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SearchProduct search = new SearchProduct();
        public Achat()
        {
            InitializeComponent();
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            setdefaultzero(PrixAchatTextBox);
            setdefaultzero(PrixRemiseTextBox);
            setdefaultzero(PrixVenteTextBox);
            setdefaultzero(montantProduitTextBox);
            setdefaultzero(QteTextBox1);
            setdefaultzero(QuantitetotalTextBox);
            setdefaultzero(countproduitsTextBox);
            setdefaultzero(MontanttotalTextBox);
            setdefaultzero(montantRestTextBox);
            getlastfactid();
            affichagefourn();
        }
        void ajouter_reglement_fournisseur(int id, decimal versé)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_reg_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_reg_clt", DateTime.Today);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        private void Codelabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Opacity = .97;
            panel1.Visible = true;
            panel1.BackColor = Color.FromArgb(255, Color.White);
            idfournisseur = 1;
            NomTextBox.Enabled = true;
            PrenomTextBox.Enabled = true;
            TelephoneTextBox.Enabled = true;
            ajouterfournButton.Enabled = true;
            NomTextBox.Text = PrenomTextBox.Text = TelephoneTextBox.Text="";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        void setdefaultzero(MetroFramework.Controls.MetroTextBox t)
        {
            t.Text = "0";
        }
        void calc()
        {

            if (dataGridView1.Rows.Count != 0)
            {
                decimal montant = 0;
                decimal qte = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    montant += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    qte += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                countproduitsTextBox.Text = dataGridView1.Rows.Count.ToString();
                QuantitetotalTextBox.Text = qte.ToString();
                MontanttotalTextBox.Text = montant.ToString();

            }
        }
        void getlastfactid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("get_last_id_fact_four", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                idfacture = Convert.ToInt32(dt.Rows[0][0]);
            }
        }
        private void addtobasket_Click(object sender, EventArgs e)
        {
            if (DescTextbox.Text == string.Empty || PrixAchatTextBox.Text == string.Empty || PrixRemiseTextBox.Text == string.Empty || PrixVenteTextBox.Text == string.Empty || QteTextBox1.Text == string.Empty
                || PrixAchatTextBox.Text == "0" || PrixRemiseTextBox.Text == "0" || PrixVenteTextBox.Text == "0" || QteTextBox1.Text == "0")
            {
                MessageBox.Show("Remplir tous les champs s.v.p !", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                if (Convert.ToDecimal(PrixAchatTextBox.Text) > Convert.ToDecimal(PrixVenteTextBox.Text)
                       || Convert.ToDecimal(PrixRemiseTextBox.Text) > Convert.ToDecimal(PrixVenteTextBox.Text)
                       || Convert.ToDecimal(PrixRemiseTextBox.Text) < Convert.ToDecimal(PrixAchatTextBox.Text))
                {
                    MessageBox.Show("Vérifier les prix S.V.P !");
                }
                else
                {
                    if (CodeTextBox.Text == string.Empty)
                    {
                        DialogResult rs = MessageBox.Show("Voulez vous ajouter un produit sans code  de reference ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            object[] obj = { "", "N/A", DescTextbox.Text, PrixAchatTextBox.Text, QteTextBox1.Text, montantProduitTextBox.Text, PrixVenteTextBox.Text, PrixRemiseTextBox.Text, "" };
                            dataGridView1.Rows.Add(obj);
                            calc();
                            clearproduct();
                        }

                    }
                    else
                    {
                        object[] obj = { "", CodeTextBox.Text, DescTextbox.Text, PrixAchatTextBox.Text, QteTextBox1.Text, montantProduitTextBox.Text, PrixVenteTextBox.Text, PrixRemiseTextBox.Text, "" };
                        dataGridView1.Rows.Add(obj);
                        calc();
                        clearproduct();
                    }
                }
               
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception) { }
        }
        

        private void PrixVenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrixRemiseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QteTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void montantProduitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removefrombasket_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("le panier est vide suppression impossible !","Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Voulez vous vraiment supprimer la ligne sélectionnée ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                   
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    MessageBox.Show("Suppression effectué avec succées");
                    calc();
                }

            }
        }

        private void resetfields_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Voulez vous vraiment vider les champs ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                CodeTextBox.Text = DescTextbox.Text = string.Empty;
                PrixAchatTextBox.Text = PrixRemiseTextBox.Text = PrixVenteTextBox.Text = montantProduitTextBox.Text = QteTextBox1.Text = "0";
            }
        }

        private void PrixAchatTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if(PrixAchatTextBox.Text != string.Empty && QteTextBox1.Text != string.Empty)
            {
                montantProduitTextBox.Text = (Convert.ToDecimal(PrixAchatTextBox.Text) * Convert.ToDecimal(QteTextBox1.Text)).ToString();

            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NomTextBox.Text  = PrenomTextBox.Text = TelephoneTextBox.Text =  string.Empty;
            panel1.Visible = false;
            this.Opacity = 1;
            idfournisseur = 1;
            NomTextBox.Enabled = true;
            PrenomTextBox.Enabled = true;
            TelephoneTextBox.Enabled = true;
            ajouterfournButton.Enabled = true;

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void montantverseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDecimal(montantverseTextBox.Text)!=0)
                montantRestTextBox.Text = (Convert.ToDecimal(MontanttotalTextBox.Text) - Convert.ToDecimal(montantverseTextBox.Text)).ToString();
            }
            catch (Exception) { }
        }

        private void montantRestTextBox_TextChanged(object sender, EventArgs e)
        {
            /*if (Convert.ToDecimal(montantRestTextBox.Text) < 0)
            {
                montantRestTextBox.Text = "0";
            }*/
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Voulez vous vraiment vider tous ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                CodeTextBox.Text = DescTextbox.Text = string.Empty;
                PrixAchatTextBox.Text = PrixRemiseTextBox.Text = PrixVenteTextBox.Text = montantProduitTextBox.Text = QteTextBox1.Text = "0";
                dataGridView1.Rows.Clear();
            }
        }
        bool checkproduct(string s, string code)
        {
            bool checkingvar = false;
            if (code == "N/A")
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("search_full_prod2", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@code", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    checkingvar = true;
                }
                return checkingvar;
            }
            else
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("search_full_prod3", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@code", code);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    checkingvar = true;
                }
                return checkingvar;
            }
        }
        void checkproduct2(string s)
        {
            if (CodeTextBox.Text != string.Empty && CodeTextBox.Text != "N/A") {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("search_full_prod3", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter("get_prod_by_code", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@code", s);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    DescTextbox.Text = dtbl.Rows[0][2].ToString();
                    PrixAchatTextBox.Text = dtbl.Rows[0][3].ToString();
                    PrixRemiseTextBox.Text= dtbl.Rows[0][5].ToString();
                    PrixVenteTextBox.Text = dtbl.Rows[0][4].ToString();
                }
            }
        }
        void ajouterproduit(string code, string design, decimal prix_v, decimal prix_u, decimal prix_r, decimal qte)
        {
            if(sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_produit", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@code", code);
            sqlcmd.Parameters.AddWithValue("@designation ", design);
            sqlcmd.Parameters.AddWithValue("@prix_v", prix_v);
            sqlcmd.Parameters.AddWithValue("@prix_u", prix_u);
            sqlcmd.Parameters.AddWithValue("@prix_r", prix_r);
            sqlcmd.Parameters.AddWithValue("@qte", qte);
            sqlcmd.ExecuteNonQuery();
        }
        void update_product(int id, int qte, decimal prix_u, decimal prix_v, decimal prix_r) // mahdi
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update_produit", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            sda.SelectCommand.Parameters.AddWithValue("@prix_u", prix_u);
            sda.SelectCommand.Parameters.AddWithValue("@prix_v", prix_v);
            sda.SelectCommand.Parameters.AddWithValue("@prix_r", prix_r);
            sda.SelectCommand.Parameters.AddWithValue("@qte", qte);
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
        }

        void ajouterachat(int id_f, int id_p, decimal prix_v, decimal prix_a, decimal prix_r, decimal qte)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_achat", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@id_f", id_f);
            sqlcmd.Parameters.AddWithValue("@id_p", id_p);
            sqlcmd.Parameters.AddWithValue("@prix_a", prix_a);
            sqlcmd.Parameters.AddWithValue("@prix_v", prix_v);
            sqlcmd.Parameters.AddWithValue("@prix_r", prix_r);
            sqlcmd.Parameters.AddWithValue("@qte", qte);
            sqlcmd.Parameters.AddWithValue("@date_a", DateTime.Now);
            sqlcmd.ExecuteNonQuery();
        }
        void ajouterfacture(int id_f, decimal montant, decimal versé, decimal reste)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_facture_four", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@id_f", idfournisseur);
            sqlcmd.Parameters.AddWithValue("@montant", montant);
            sqlcmd.Parameters.AddWithValue("@versé", versé);
            sqlcmd.Parameters.AddWithValue("@reste", reste);
            sqlcmd.Parameters.AddWithValue("@date_fact", DateTime.Now);
            sqlcmd.ExecuteNonQuery();
        }
        void addfourn(string nom, string prenom,string tel)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("add_four", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@nom", nom);
            sqlcmd.Parameters.AddWithValue("@prenom", prenom);
            sqlcmd.Parameters.AddWithValue("@phone", tel);
            sqlcmd.ExecuteNonQuery();
        }
        void showallfourn()
        {

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
        void affichagefourn()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_four", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 200;
        }
        void rech_four(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("search_four", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@nom", s);
            sda.SelectCommand.Parameters.AddWithValue("@prenom", s);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 200;

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

        void clear()
        {
            dataGridView1.Rows.Clear();
            countproduitsTextBox.Text = MontanttotalTextBox.Text = QuantitetotalTextBox.Text = montantverseTextBox.Text = montantRestTextBox.Text = "0";
            clearproduct();
        }
        void clearproduct()
        {
            CodeTextBox.Text = DescTextbox.Text = ""; PrixAchatTextBox.Text = PrixVenteTextBox.Text = PrixRemiseTextBox.Text = QteTextBox1.Text = montantProduitTextBox.Text = "0";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(montantverseTextBox.Text == string.Empty)
            {
                MessageBox.Show("Verifier le montant versé s.v.p", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(NomTextBox.Enabled != false && PrenomTextBox.Enabled != false && ajouterfournButton.Enabled != false) { 
                DialogResult rs = MessageBox.Show("Voulez vous enrigistrer votre factue sans fournisseur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        string code = ""; string desig = ""; decimal prxachat = 0, prxvente = 0, prxrems = 0, qte = 0; DateTime now = DateTime.Now; int prodid = 0;
                        int qte2 = 0;
                        decimal montantfacture = Convert.ToDecimal(MontanttotalTextBox.Text), montantfactureverse = Convert.ToDecimal(montantverseTextBox.Text), montantfacturereste = Convert.ToDecimal(montantRestTextBox.Text);
                        ajouterfacture(idfournisseur, montantfacture, montantfactureverse, montantfacturereste);
                        ajouter_reglement_fournisseur(idfacture, montantfacture);
                        getlastfactid();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            code = row.Cells[1].Value.ToString();
                            desig = row.Cells[2].Value.ToString();
                            prxvente = Convert.ToDecimal(row.Cells[6].Value.ToString());
                            prxrems = Convert.ToDecimal(row.Cells[7].Value.ToString());
                            prxachat = Convert.ToDecimal(row.Cells[3].Value.ToString());
                            qte = Convert.ToDecimal(row.Cells[4].Value.ToString());
                            qte2 = Convert.ToInt32(row.Cells[4].Value.ToString());
                            if (code == "N/A") /*(!checkproduct(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString()))*/
                            {
                                check_by_DES_IfExist(desig);
                                if(idprod == -1)
                                {
                                    ajouterproduit(code, desig, prxvente, prxachat, prxrems, qte);
                                    prodid = getproductid(desig);
                                    
                                    
                                }
                                else
                                {
                                    update_product(idprod, qte2, prxachat, prxvente, prxrems);
                                    prodid= idprod ;
                                    MessageBox.Show("Prod id = " + idprod);
                                }

                            }
                            else
                            {
                                check_by_Code_IfExist(code);
                                if (idprod == -1)
                                {
                                    ajouterproduit(code, desig, prxvente, prxachat, prxrems, qte);
                                    prodid = getproductid(desig);
                                    
                                }
                                else
                                {
                                    update_product(idprod, qte2, prxachat, prxvente, prxrems);
                                    prodid = idprod;
                                    MessageBox.Show("Prod id = " + idprod);
                                }
                            }
                            
                            ajouterachat(idfacture, prodid, prxvente, prxachat, prxrems, qte);
                            idprod= -1;
                        }
                        getlastfactid();
                        idfournisseur = 1;
                        clear();
                        idprod = -1;
                    }
                    
                }
                else
                {
                    string code = ""; string desig = ""; decimal prxachat = 0, prxvente = 0, prxrems = 0, qte = 0; DateTime now = DateTime.Now; int prodid = 0;
                    int qte2 = 0;
                    decimal montantfacture = Convert.ToDecimal(MontanttotalTextBox.Text), montantfactureverse = Convert.ToDecimal(montantverseTextBox.Text), montantfacturereste = Convert.ToDecimal(montantRestTextBox.Text);
                    ajouterfacture(idfournisseur, montantfacture, montantfactureverse, montantfacturereste);
                    getlastfactid();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        code = row.Cells[1].Value.ToString();
                        desig = row.Cells[2].Value.ToString();
                        prxvente = Convert.ToDecimal(row.Cells[6].Value.ToString());
                        prxrems = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        prxachat = Convert.ToDecimal(row.Cells[3].Value.ToString());
                        qte = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        qte2 = Convert.ToInt32(row.Cells[4].Value.ToString());
                        if (code == "N/A") /*(!checkproduct(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString()))*/
                        {
                            check_by_DES_IfExist(desig);
                            if (idprod == -1)
                            {
                                ajouterproduit(code, desig, prxvente, prxachat, prxrems, qte);
                                prodid = getproductid(desig);


                            }
                            else
                            {
                                update_product(idprod, qte2, prxachat, prxvente, prxrems);
                                prodid = idprod;
                                MessageBox.Show("Prod id = " + idprod);
                            }

                        }
                        else
                        {
                            check_by_Code_IfExist(code);
                            if (idprod == -1)
                            {
                                ajouterproduit(code, desig, prxvente, prxachat, prxrems, qte);
                                prodid = getproductid(desig);

                            }
                            else
                            {
                                update_product(idprod, qte2, prxachat, prxvente, prxrems);
                                prodid = idprod;
                                MessageBox.Show("Prod id = " + idprod);
                            }
                        }
                        ajouterachat(idfacture, prodid, prxvente, prxachat, prxrems, qte);
                        idprod = -1;
                    }
                    getlastfactid();
                    idfournisseur = 1;
                    clear();
                    idprod = -1;
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(NomTextBox.Text == string.Empty || PrenomTextBox.Text == string.Empty)
            {
                MessageBox.Show("Selectionner un fournisseur d'abord s.v.p", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(PrenomTextBox.Enabled == false && NomTextBox.Enabled == false && ajouterfournButton.Enabled == false)
            {
                MessageBox.Show("Fournisseur : " + NomTextBox.Text + " " + PrenomTextBox.Text + " Selectionné id : "+idfournisseur);
                panel1.Visible = false;
                this.Opacity = 1;
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (NomTextBox.Text == string.Empty || PrenomTextBox.Text == string.Empty)
            {
                MessageBox.Show("Veillez saisir nom ou prenom au moins s.v.p", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nom = NomTextBox.Text, prenom = PrenomTextBox.Text, tel = TelephoneTextBox.Text;
                addfourn(nom,prenom,tel);
                affichagefourn();
            }
        }
        int idfournisseur = 1;

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                NomTextBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                PrenomTextBox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                TelephoneTextBox.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
                idfournisseur = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                NomTextBox.Enabled = false;
                PrenomTextBox.Enabled = false;
                TelephoneTextBox.Enabled = false;
                ajouterfournButton.Enabled = false;
                
            }
            catch (Exception) { }
        }

        private void bunifuMaterialTextbox1_Click_1(object sender, EventArgs e)
        {
            if (searchfourn.Text == "Rechercher fournisseur")
            {
                searchfourn.Text = string.Empty;
            }
        }

        private void searchfourn_OnValueChanged(object sender, EventArgs e)
        {
            if (searchfourn.Text == string.Empty)
            {
                affichagefourn();
            }
            else
            {
                rech_four(searchfourn.Text);
            }
        }

        private void Achat_Load(object sender, EventArgs e)
        {
            
        }
        private void DataSent(string code, string desc, decimal prixachat, decimal prixvente, decimal prixremise)
        {
            CodeTextBox.Text = code;
            DescTextbox.Text = desc;
            PrixAchatTextBox.Text = prixachat.ToString();
            PrixVenteTextBox.Text = prixvente.ToString();
            PrixRemiseTextBox.Text = prixremise.ToString();
        }


        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            search.DataSent += DataSent;
            search.ShowDialog();
        }

        private void PrixAchatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            checkproduct2(CodeTextBox.Text);
        }
    }
}

