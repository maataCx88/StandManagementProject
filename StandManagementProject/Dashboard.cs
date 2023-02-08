using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Dashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        MainMenu mm;

        public Dashboard(string nameshop, MainMenu mm)
        {
            InitializeComponent();
            label1.Text= nameshop;
            call_all();
            this.mm = mm;
        }
        public void call_all()
        {
            get_total_achat();
            get_total_vente();

            get_total_produit_achat();
            get_total_produit_vente();

            get_total_clients();
            get_total_workers();

            get_total_fournisseur();
        }
        public void get_total_clients()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_number_clients", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        guna2HtmlLabeltotalclient.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        guna2HtmlLabeltotalclient.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_total_workers()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_number_workers", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        guna2HtmlLabeltotalworkers.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        guna2HtmlLabeltotalworkers.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }


        public void get_total_fournisseur()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_number_fournisseur", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        guna2HtmlLabeltotalfournisseur.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        guna2HtmlLabeltotalfournisseur.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_total_achat()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_facture_four", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Today);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        labelachat.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        labelachat.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_total_vente()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_facture_clt", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Today);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        labelvente.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        labelvente.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_total_produit_achat()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_achat_today", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Today);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        //labelproduitachat.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                       // labelproduitachat.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_total_produit_vente()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_vente_today", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Today);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                     //   labelproduitvente.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                      //  labelproduitvente.Text = "0";
                    }
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        private void guna2GradientPanel3_Click(object sender, EventArgs e)
        {
            mm.showfct();
        }

        private void guna2GradientPanel4_Click(object sender, EventArgs e)
        {
            mm.showbon();
        }
    }
}
