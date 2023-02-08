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
    public partial class Caisse : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);

        public Caisse()
        {
            InitializeComponent();

            metroDateTimestartdate.MaxDate = DateTime.Today;
            metroDateTimefinishdate.MaxDate = DateTime.Today;

            metroDateTimestartdate.Value = DateTime.Today;
            metroDateTimefinishdate.Value = DateTime.Today;
        }
       public void calculate_benefice()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("show_benefices", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        TEXTBENEFICE.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        TEXTBENEFICE.Text = "0";
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
        public void get_total_caisse_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_caisse_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if(drd.GetValue(0).ToString() != "")
                    {
                        textBoxcaisse.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxcaisse.Text = "0";
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

        public void get_total_achat_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_achat_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxmarch.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxmarch.Text = "0";
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

        public void get_total_charge_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_charge_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxcharges.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxcharges.Text = "0";
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


        public void get_total_dette_client_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_dette_client_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxdettesclient.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxdettesclient.Text = "0";
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

        public void get_total_dette_fournisseur_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_dette_fournisseur_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxdettesfournisseur.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxdettesfournisseur.Text = "0";
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

        public void get_total_dette_fournisseur_payé_by_date()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_total_dette_fournisseur_payé_by_date", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxverse.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxverse.Text = "0";
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

        public void nbr_fact_clt()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("nbr_fact_clt", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxfactureclient.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxfactureclient.Text = "0";
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

        public void nbr_fact_four()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("nbr_fact_four", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sda.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        textBoxfacturefournisseur.Text = drd.GetValue(0).ToString();
                    }
                    else
                    {
                        textBoxfacturefournisseur.Text = "0";
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

        private void pictureBoxsearch_Click(object sender, EventArgs e)
        {
            if (metroDateTimestartdate.Value <= metroDateTimefinishdate.Value)
            {
                get_total_caisse_by_date();
                get_total_achat_by_date();
                get_total_charge_by_date();
                get_total_dette_client_by_date();
                get_total_dette_fournisseur_by_date();
                get_total_dette_fournisseur_payé_by_date();
                nbr_fact_clt();
                nbr_fact_four();
                calculate_benefice();
                textBoxtotal.Text = (Int32.Parse(textBoxfactureclient.Text) + Int32.Parse(textBoxfacturefournisseur.Text)).ToString();
            }
            else
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Changer la date \n S.V.P";
                mb.label1.Location = new Point(80, 20);
                mb.Show();
            }
            
        }

        private void labelcaisse_Click(object sender, EventArgs e)
        {

        }
    }
}
