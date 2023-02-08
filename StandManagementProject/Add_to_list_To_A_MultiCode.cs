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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using System.Runtime.CompilerServices;

namespace StandManagementProject
{
    public partial class Add_to_list_To_A_MultiCode : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Add_to_list_To_A_MultiCode(MultiCode MC, int idprod, string code,string code_prod)
        {
            InitializeComponent();
            if (code == "Modifier")
            {
                this.MC = MC;
                this.idprod = idprod;
                this.code = code;
                metroConfirm.Text = "Modifier";
            }
            else
            {
                this.MC = MC;
                this.idprod = idprod;
            }
            this.code_prod= code_prod;
            show_list(idprod);
            add_image_column();
            BarcodeScanner barcodeScanner = new BarcodeScanner(metroScanAdd);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        bool exist = false; int id_exist = -1, idprod = -1; string code_list = "", code = ""; bool exist_in_product = false;
        MultiCode MC; string designation="none"; decimal prix_u = -1, prix_v = -1, prix_r = -1, prix_g = -1; decimal qte=-1;
        string code_prod = "none";
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            metroScanAdd.Text =  e.Barcode;
            if (metroScanAdd.Text != string.Empty)
            {
                code_list = metroScanAdd.Text;
                
                   // code_list = eliminate_non_numeric(code_list);
                    Existance_in_product_list(code_list);
                    if (exist_in_product)
                    {
                        MessageBox.Show("Ce code existe déja dans les produits");
                        metroScanAdd.Text = ""; metroScanAdd.Focus();
                    }
                    else
                    {
                        Existance_in_list(code_list);
                        if (exist)
                        {
                            MessageBox.Show("Ce code existe déja dans un autre MULTI-CODE");
                            metroScanAdd.Text = ""; metroScanAdd.Focus();
                        }
                        else
                        {
                            add_to_list(code_list, idprod);
                        }


                    }

                    /*if (id_exist == idprod)
                    {
                        exist = false;

                    }
                    else
                    {



                    }*/
                    show_list(idprod);

                

                /*exist = false;
                exist_in_product = false;*/
                metroScanAdd.Text = string.Empty;
                //code_list = string.Empty;
            }
            /*exist = false;  id_exist = idprod = -1;
             exist_in_product = false;*/
        }
        string eliminate_non_numeric(string value)
        {
            value = Regex.Replace(value, "[^0-9]", "");
            return value;

        }
        void add_image_column()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();


            img.Image = (Image)Properties.Resources.delete_32px;
            dataGridView1.Columns.Add(img);
            img.HeaderText = "Action";
            img.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            img.Name = "modify";
            img.Width = 70;
        }
        void add_to_list(string code, int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("add_to_list", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@associated_code_ID", id);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        void show_list(int id)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("select_from_list", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code_ID", id);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                sqlcon.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Index == 0)
                {
                    code = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    update_list(code);
                    show_list(idprod);
                }
            }
        }

        private void metroScanAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void metroConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Voulez vous Ajouter un fournisseur pour ce Multi Code", "Poursuivre ou Fermer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Informations_produit(idprod);
                if (designation != "none")
                {
                    Fournisseur_dashboard fdb = new Fournisseur_dashboard(idprod, designation, prix_u, prix_v, prix_r, prix_g, qte,this.MC);
                    fdb.Show(); 
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        void update_list(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("delete_from_list", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }

        void Existance_in_list(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("verify_existance_in_list", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlcmd.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    exist = true;
                    id_exist = (int)dtbl.Rows[0][1];
                    //MessageBox.Show("ID EXIST" + id_exist);
                }
                else
                {
                    exist = false;
                    id_exist = -1;
                    //MessageBox.Show("ID NOT EXIST" + id_exist);
                }
                sqlcon.Close();
            }
        }
        void Existance_in_product_list(string code)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("verify_existance_in_product_list", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@code", code);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlcmd.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    exist_in_product = true;
                }
                else
                {
                    exist_in_product = false;
                }
                sqlcon.Close();
            }
        }
        void affichagefourn()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_four", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcon.Close();
            //  dataGridView2.Columns[1].Width = 200;
            //   dataGridView2.Columns[2].Width = 200;
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
            sqlcon.Close();
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
                        designation = dt.Rows[0][2].ToString();
                        prix_u = Convert.ToDecimal(dt.Rows[0][3]);
                        prix_v = Convert.ToDecimal(dt.Rows[0][4]);
                        prix_r = Convert.ToDecimal(dt.Rows[0][5]);
                        qte= Convert.ToDecimal(dt.Rows[0][6]);
                        prix_g = Convert.ToDecimal(dt.Rows[0][7]);
                    }
                }
                sqlcon.Close();
            }
        }
    }
}
