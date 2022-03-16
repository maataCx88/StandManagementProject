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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();

            get_number_clients();
            get_number_workers();
            count_facture_clt();
            count_facture_four();
            count_achat_today();
            count_vente_today();
            get_data();
        }

        public void get_number_clients()
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
                    labelclientsnumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_number_workers()
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
                    labelworkersnumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void count_facture_clt()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_facture_clt", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Now.Date);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    labelclientsbillnumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void count_facture_four()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_facture_four", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Now.Date);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    labelfournisseurbillnumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void count_achat_today()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_achat_today", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Now.Date);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    labelproductsbuynumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void count_vente_today()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("count_vente_today", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;
                sda.Parameters.AddWithValue("@date", DateTime.Now.Date);

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    labelproductssellnumber.Text = drd.GetValue(0).ToString();
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void get_data()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("count_vente_by_date_and_qte", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date1", DateTime.Now.AddDays(-7).Date);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date2", DateTime.Now.Date);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                chart1.DataSource = ds;
                chart1.Series["NUMBER"].XValueMember = "date";
                chart1.Series["NUMBER"].YValueMembers = "nbr produit";

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToLongTimeString();
            labeldate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
