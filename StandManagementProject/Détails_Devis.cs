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
using MetroFramework.Controls;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Bibliography;

namespace StandManagementProject
{
    public partial class Détails_Devis : Form
    {
        public Détails_Devis(Facture_Devis FD, int id_facture, decimal montant, decimal versé, decimal reste, decimal remise, string state, int id_user, string date, string vendeur, string client,int ID_Client)
        {
            InitializeComponent();
            this.FD = FD;
            this.id_facture = id_facture;
            this.id_bon_facture = id_facture;
            this.montant = montant;
            this.reste = reste;
            this.versé = versé;
            this.remise = remise;
            this.state = state;
            this.id_user = id_user;
            this.ID_Client = ID_Client;
            Affichage_Vente(this.id_facture);
            détailsGrid.Columns[0].ReadOnly = true;
            détailsGrid.Columns[1].ReadOnly = true;
            détailsGrid.Columns[2].ReadOnly = true;
            détailsGrid.Columns[3].ReadOnly = true;
            détailsGrid.Columns[4].ReadOnly = true;
            détailsGrid.Columns[5].ReadOnly = true;
            détailsGrid.Columns[6].ReadOnly = true;
            détailsGrid.Columns[7].ReadOnly = true;
            détailsGrid.Columns[8].ReadOnly = true;
            détailsGrid.Columns[9].ReadOnly = true;
            détailsGrid.Columns[10].ReadOnly = true;
            détailsGrid.Columns[11].ReadOnly = true;
            this.KeyPreview = true;

            textnum.Text = id_facture.ToString();
            textdate.Text = date;
            textvendeur.Text = vendeur;
            textclient.Text = client;
            textstatus.Text = state;
        }
        public int ID_Client = -1; int id_bon_facture = -1;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        Facture_Devis FD; public int id_facture = 0; decimal montant = 0, versé = 0, reste = 0, remise = 0;
        int index_cell = -1, DEVIS = -1, Produit = -1;
        decimal prix_vente = -1, prix_temp = -1, qteVente = -1, qteStock = -1, prix_v = -1, prix_u = -1;
        bool valid = true;
        string state = "";
        int id_user = -1;
        public void is_all_valid()
        {

            decimal stock = -1, vente = -1;
            valid = true;
            if (détailsGrid.RowCount > 0)
            {
                foreach (DataGridViewRow row in détailsGrid.Rows)
                {
                    vente = Convert.ToDecimal(row.Cells[7].Value);
                    stock = Convert.ToDecimal(row.Cells[8].Value);
                    if (vente > stock)
                    {
                        valid = false;
                    }
                }
            }
        }
        public void Produit_UPDATE(int index, int cell_produit)
        {
            if (index != -1)
            {
                MessageBox.Show("Séléctionner d'abord un produit à modifier");
            }
            else
            {
                MessageBox.Show("Pret à modifier");
            }
        }
        public void DEVIS_DELETE(int index, int cell_devis)
        {
            DialogResult result = MessageBox.Show("Question ? ", "Confirmer Vous Pour Annuler Article ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                delete_devis(cell_devis);
                Affichage_Vente(this.id_facture);

            }
        }
        public void reactivate_deals(decimal new_montant, decimal new_versé, decimal new_reste, decimal new_remise, string state)
        {
            montant = new_montant;
            versé = new_versé;
            reste = new_reste;
            this.remise = new_remise;
            this.state = state;
            textstatus.Text = this.state;
            this.TransfertButton.Enabled = false;
        }
        public void TRANSFERT_ONLY_CLIENT(int id_client,int id_devis,int id_facture,string nom)
        {
            change_client_for_devis(id_client, id_devis);
            if (state == "Validée")
            {
                change_client_for_Facture(id_client, id_facture);
            }
            
            ID_Client = id_client;
            textclient.Text = nom;
        }
        public void valider_devis()
        {
            this.id_bon_facture = this.id_facture;
            upadte_facture_devis(this.id_facture, montant, versé, reste, remise, "Validée");
            ajouter_facture_client(montant, versé, reste, remise);
            last_id_facture_client();
            ajouter_reglement_client(this.id_facture, this.versé);
            foreach (DataGridViewRow row in détailsGrid.Rows)
            {
                int ID_DEVIS = Convert.ToInt32(row.Cells[0].Value);
                int ID_Produit = Convert.ToInt32(row.Cells[1].Value);
                decimal PRIX_DE_VENTE = Convert.ToDecimal(row.Cells[4].Value);
                decimal TAUX_TVA = Convert.ToDecimal(row.Cells[6].Value);
                decimal QTE_VENTE = Convert.ToDecimal(row.Cells[7].Value);
                update_devis(ID_DEVIS, PRIX_DE_VENTE, QTE_VENTE, TAUX_TVA);
                ajouter_vente(ID_Produit, PRIX_DE_VENTE, QTE_VENTE);
                if (Produit != 0)
                {
                    update_qte_prod(ID_Produit, QTE_VENTE);
                }
            }
            FD.Affichage_Vente();

        }
        private void TransfertButton_Click(object sender, EventArgs e)
        {
            if (this.state == "En Attente")
            {
                if(détailsGrid.RowCount > 0)
                {
                    is_all_valid();
                    if (valid)
                    {

                        calc();
                        Devis_to_Facture DVF = new Devis_to_Facture(id_facture, montant, versé, reste, remise, this.id_user, this, "En Attente", détailsGrid);
                        DVF.Show();

                    }
                    else { MessageBox.Show("Facture Non Valide! verifié les qte avec le disponible !"); }
                }
            }
            else
            {
                MessageBox.Show("Facture Déja transféré");
            }

        }

        public void Affichage_Vente(int id)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_devis_factureID", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id);

                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    this.détailsGrid.DataSource = dt;
                }
                sqlcon.Close();
                this.détailsGrid.Columns[0].Visible = false;
                this.détailsGrid.Columns[1].Visible = false;
                this.détailsGrid.Columns[5].Visible = false;
                this.détailsGrid.Columns[10].Visible = false;
                this.détailsGrid.Columns[11].Visible = false;
            }
        }
        public void change_client_for_devis(int id_client,int id_devis)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("change_client_of_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_client", id_client);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_devis", id_devis);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        public void change_client_for_Facture(int id_client, int id_facture)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("transfert_vente_client", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_client", id_client);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_facture", id_facture);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        public void upadte_facture_devis(int id, decimal montant, decimal versé, decimal reste, decimal remise, string bill_status)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_facture_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@total", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@status", bill_status);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }

        private void détailsGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void détailsGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (détailsGrid.CurrentCell.ColumnIndex == 6 || détailsGrid.CurrentCell.ColumnIndex == 4
                || détailsGrid.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        void delete_devis(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("DELETE_DEVIS", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }
        void calc()
        {
            decimal MontantDataGridview = 0;
            foreach (DataGridViewRow row in détailsGrid.Rows)
            {
                MontantDataGridview += Convert.ToDecimal(row.Cells[9].Value);
            }
            montant = MontantDataGridview;
            reste = montant - versé;
        }
        private void détailsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (index_cell != -1)
            {
                decimal new_price = 0, new_qte = 0, new_TVA = 0;
                if (détailsGrid.Rows[index_cell].Cells[7].Value == null
                    || détailsGrid.Rows[index_cell].Cells[7].Value.ToString() == string.Empty
                    || Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[7].Value.ToString()) > qteStock)
                {
                    //MessageBox.Show("QTE Changed");
                    détailsGrid.Rows[index_cell].Cells[7].Value = qteVente.ToString("#.000");
                    détailsGrid.Rows[index_cell].Cells[6].Value = "0".ToString();
                    détailsGrid.Rows[index_cell].Cells[4].Value = prix_temp.ToString("#.000");
                    détailsGrid.Rows[index_cell].Cells[9].Value = (prix_temp * qteVente).ToString("#.000");
                }
                else
                {
                    if (détailsGrid.Rows[index_cell].Cells[6].Value == null
                    || détailsGrid.Rows[index_cell].Cells[6].Value.ToString() == string.Empty)
                    {
                        //MessageBox.Show("TVA Changed");
                        détailsGrid.Rows[index_cell].Cells[7].Value = qteVente.ToString("#.000");
                        détailsGrid.Rows[index_cell].Cells[6].Value = "0".ToString();
                        détailsGrid.Rows[index_cell].Cells[4].Value = prix_temp.ToString("#.000");
                        détailsGrid.Rows[index_cell].Cells[9].Value = (prix_temp * qteVente).ToString("#.000");
                    }
                    else
                    {
                        if (détailsGrid.Rows[index_cell].Cells[4].Value == null
                        || détailsGrid.Rows[index_cell].Cells[4].Value.ToString() == string.Empty
                        
                        || Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[4].Value.ToString()) < prix_u)
                        {
                            
                            détailsGrid.Rows[index_cell].Cells[7].Value = qteVente.ToString("#.000");
                            détailsGrid.Rows[index_cell].Cells[6].Value = "0".ToString();
                            détailsGrid.Rows[index_cell].Cells[4].Value = prix_temp.ToString("#.000");
                            détailsGrid.Rows[index_cell].Cells[9].Value = (prix_temp * qteVente).ToString("#.000");
                        }
                        else
                        {
                            new_qte = Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[7].Value);
                            new_TVA = Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[6].Value);
                            new_price = Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[4].Value);
                            if (new_TVA != 0)
                            {

                                new_price = new_price + (new_price * (new_TVA / 100));
                                //MessageBox.Show("new price " + new_price);
                                détailsGrid.Rows[index_cell].Cells[9].Value = (new_price * new_qte).ToString("#.000");

                            }
                            else
                            {
                                new_price = Convert.ToDecimal(détailsGrid.Rows[index_cell].Cells[4].Value);
                                détailsGrid.Rows[index_cell].Cells[9].Value = (new_price * new_qte).ToString("#.000");
                            }
                        }

                    }
                }

            }
        }

        private void détailsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (détailsGrid.RowCount > 0)
            {

            }
        }

        void update_devis(int id, decimal prix, decimal qte, decimal tva)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_devis", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@prix", prix);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@qte", qte);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@tva", tva);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();

            }
        }
        public static bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openform => openform.GetType() == formtype);
        }

        private void Détails_Devis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)       // UPDATE
            {
                check_if_associated(this.id_facture);
                Transfert_devis_client TBC = new Transfert_devis_client(this, id_facture_associated, id_facture);
                if (FormIsOpen(Application.OpenForms, typeof(Transfert_devis_client)))
                {
                    MessageBox.Show("Formulaire déja ouvert!");
                }
                else
                {
                    TBC.Show();
                }
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F2)       // UPDATE
            {

                if (state == "Validée")
                {
                    
                    DialogResult result = MessageBox.Show("Vous voulez Annuler Ce Devis ! ", "Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        check_if_associated(this.id_facture);
                        //MessageBox.Show("ID FACTURE IS " + id_facture_associated);
                        update_vente(id_facture_associated);
                        calc();
                        upadte_facture_devis(this.id_facture, montant,0,montant,0, "En Attente");
                        reactivate_deals(montant, 0, montant, 0, "En Attente");
                        TransfertButton.Enabled = true;
                        Affichage_Vente(this.id_facture);
                    }

                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.F3)       // UPDATE
            {

                if (state == "En Attente")
                {
                    modify_qte(index_cell, 4);
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.F4)       // DELETE
            {
                if (state == "En Attente")
                {
                    modify_qte(index_cell, 6);
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.F5)       // UPDATE
            {
                if (state == "En Attente")
                {
                    modify_qte(index_cell, 7);
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.F6)       // delete
            {

                if (state == "En Attente")
                {
                    DialogResult rs = MessageBox.Show("Confirmer la suppression de l'article séléctionné ? ", "Confirmation"
                        , MessageBoxButtons.YesNo);
                    if(rs == DialogResult.Yes)
                    {
                        delete_devis(DEVIS);
                       // MessageBox.Show("article supprimé avec succées !");
                        Affichage_Vente(id_facture);
                    }
                    
                    e.SuppressKeyPress = true;
                }
            }



        }
        void open_read_only(int row_index, int index_cellule)
        {
            détailsGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            détailsGrid.Rows[row_index].Cells[7].ReadOnly = false;
            détailsGrid.Rows[row_index].Cells[6].ReadOnly = false;
            détailsGrid.Rows[row_index].Cells[4].ReadOnly = false;
            détailsGrid.CurrentCell = détailsGrid.Rows[row_index].Cells[index_cellule];
            détailsGrid.CurrentCell.Selected = true;
            for (int i = 0; i < détailsGrid.RowCount; i++)
            {
                if (i != row_index)
                {
                    détailsGrid.Rows[i].Cells[7].ReadOnly = true;
                    détailsGrid.Rows[i].Cells[6].ReadOnly = true;
                    détailsGrid.Rows[i].Cells[4].ReadOnly = true;
                }
            }
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
                    téléphone = dt.Rows[0][2].ToString();
                    emp = dt.Rows[0][3].ToString();
                    net_Total = Convert.ToDecimal(dt.Rows[0][4]);
                    net_Versé = Convert.ToDecimal(dt.Rows[0][5]);
                    net_Remise = Convert.ToDecimal(dt.Rows[0][6]);
                    net_Reste = Convert.ToDecimal(dt.Rows[0][7]);
                    net_HT = Convert.ToDecimal(dt.Rows[0][8]);
                    net_TVA = Convert.ToDecimal(dt.Rows[0][9]);
                    compte = dt.Rows[0][10].ToString();
                    adresse = dt.Rows[0][11].ToString();
                    livreur = dt.Rows[0][12].ToString();
                    vendeur = Convert.ToInt32(dt.Rows[0][13]);
                    clt = Convert.ToInt32(dt.Rows[0][14]);
                    facture = Convert.ToInt32(dt.Rows[0][14]);
                }
                sqlcon.Close();
            }
        }
        private void buttonImpression_Click(object sender, EventArgs e)
        {
            if (state == "En Attente")
            {
                MessageBox.Show(" Facture pas encore Valider");
            }
            else
            {
                calc();
                Devis_to_Facture DVF = new Devis_to_Facture(id_bon_facture, montant, versé, reste, remise, this.id_user, this, "Validée", détailsGrid);
                DVF.pass_to_impression();
                DVF.Show();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private void Détails_Devis_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Détails_Devis_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Détails_Devis_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void détailsGrid_Click(object sender, EventArgs e)
        {
            if (state == "En Attente")
            {
                if (détailsGrid.RowCount > 0)
                {

                    this.index_cell = Convert.ToInt32(this.détailsGrid.CurrentRow.Index);
                    this.DEVIS = Convert.ToInt32(this.détailsGrid.Rows[index_cell].Cells[0].Value);
                    this.Produit = Convert.ToInt32(this.détailsGrid.Rows[index_cell].Cells[1].Value);
                    this.prix_vente = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[4].Value);
                    this.prix_temp = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[5].Value);
                    this.qteVente = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[7].Value);
                    this.qteStock = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[8].Value);
                    this.prix_v = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[10].Value);
                    this.prix_u = Convert.ToDecimal(this.détailsGrid.Rows[index_cell].Cells[11].Value);
                }
            }
            else
            {
                this.index_cell = -1;
                this.DEVIS = -1;
                this.Produit = -1;
                this.prix_vente = -1;
                this.prix_temp = -1;
                this.qteVente = -1;
                this.qteStock = -1;
                this.prix_v = -1;
                this.prix_u = -1;
            }
        }

        private void détailsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Détails_Facture_Client__Achat__FormClosed(object sender, FormClosedEventArgs e)
        {
            FD.Affichage_Vente();
        }
        void modify_qte(int index_row, int index_cellule)
        {
            if (index_row == -1)
            {
                MessageBox.Show("Séléctionner un article pour modifier la Quantité !");
            }
            else
            {
                if (détailsGrid.Rows[index_row].Cells[3].Value.ToString() != "Autre Article")
                {


                    détailsGrid.EditMode = DataGridViewEditMode.EditOnEnter;
                    détailsGrid.Rows[index_row].Cells[index_cellule].ReadOnly = false;
                    détailsGrid.CurrentCell = détailsGrid.Rows[index_row].Cells[index_cellule];
                    détailsGrid.CurrentCell.Selected = true;
                    for (int i = 0; i < détailsGrid.RowCount; i++)
                    {
                        if (i != index_row)
                        {
                            détailsGrid.Rows[i].Cells[index_cellule].ReadOnly = true;
                        }
                    }
                }
            }
        }
        //bills
        void ajouter_facture_client(decimal montant, decimal versé, decimal reste, decimal remise)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_facture_clt", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_c", this.ID_Client);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id_u", this.id_user);//user
                sqlcmd.SelectCommand.Parameters.AddWithValue("@montant", montant);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@versé", versé);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@reste", reste);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@remise", remise);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@date_fact", DateTime.Today);
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
                    if(dt.Rows.Count > 0)
                    {
                        id_facture_associated = Convert.ToInt32(dt.Rows[0][0]);
                    }
                    else
                    {
                        id_facture_associated = -1;
                    }
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

    }
}
