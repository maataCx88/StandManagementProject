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
    public partial class Stock : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

        public Stock()
        {
            InitializeComponent();

            view_stock();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(4, 0, 154);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void view_stock()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_prod", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                nominate();

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        void nominate()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "CODE BARE";
            dataGridView1.Columns[1].Width = 230;
            dataGridView1.Columns[2].HeaderText = "DESIGNATION";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].HeaderText = "PRIX ACHAT";
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].HeaderText = "PRIX UNITAIRE";
            dataGridView1.Columns[4].Width = 220;
            dataGridView1.Columns[5].HeaderText = "PRIX REMISE";
            dataGridView1.Columns[5].Width = 220;
            dataGridView1.Columns[6].HeaderText = "QUANTITE";
            dataGridView1.Columns[6].Width = 220;
        }

        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = null;
                view_stock();
            }
            else
            {
                search_stock(search);
            }
        }

        public void search_stock(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_full_prod", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@code", value);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                nominate();
                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    if(dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                    {
                        View_prodcut view = new View_prodcut(Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        view.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, contacter DZOFTWARES");
                    }
                }
                else
                {
                    Message_box mb = new Message_box(Login.action_yes_1, false, "");
                    mb.label1.Text = "Choisissez-en un \ns'il vous plaît.";
                    mb.label1.Location = new Point(80, 20);
                    mb.Show();
                }
            }
        }

        private void metroComboBoxstatus_TextChanged(object sender, EventArgs e)
        {
            string search = metroComboBoxstatus.Text;
            if (search == "DISPONIBLE")
            {
                dataGridView1.DataSource = null;
                view_stock();
            }
            else
            {
                search_stock_by_status(search);
            }
        }

        public void search_stock_by_status(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter;

                if (value == "FINI")
                {
                    sqlDataAdapter = new SqlDataAdapter("search_stock_by_finished", sqlcon);
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("search_stock_by_tout", sqlcon);
                }

                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

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
