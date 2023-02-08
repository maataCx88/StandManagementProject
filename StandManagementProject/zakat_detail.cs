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
    public partial class zakat_detail : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public zakat_detail()
        {
            InitializeComponent();

            view_zakat();
        }

        public void view_zakat()
        {
            try
            {
                détailsGrid.DataSource = null;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_zakat", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                détailsGrid.DataSource = dtbl;
                nominate();
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void nominate()
        {
            détailsGrid.Columns[0].HeaderText = "ID";
            détailsGrid.Columns[1].HeaderText = "قيمة السلع";
            détailsGrid.Columns[2].HeaderText = "ديون داخلية";
            détailsGrid.Columns[3].HeaderText = "ديون خارجية";
            détailsGrid.Columns[4].HeaderText = "السيولة";
            détailsGrid.Columns[5].HeaderText = "قيمة النصاب";
            détailsGrid.Columns[6].HeaderText = "المجموع";
            détailsGrid.Columns[7].HeaderText = "قيمة الزكاة";
            détailsGrid.Columns[8].HeaderText = "التاريخ";
        }

        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                view_zakat();
            }
            else
            {
                search_zakat(search);
            }
        }

        public void search_zakat(string value)
        {
            try
            {
                détailsGrid.DataSource = null;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_zakat", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@value", value);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                détailsGrid.DataSource = dtbl;
                nominate();
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }

        }
    }
}
