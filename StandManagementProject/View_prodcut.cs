using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class View_prodcut : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id;

        public View_prodcut(int id)
        {
            InitializeComponent();

            this.id = id;

            view_product();

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpram,
            int lpram);

        private void closeprgrm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureandname_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void view_product()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_full_details_achat_by_prod", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", this.id);
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
            dataGridView1.Columns[0].HeaderText = "N° ACHAT";
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].HeaderText = "DESIGNATION";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "PRIX ACHAT";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].HeaderText = "PRIX VENTE";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "PRIX REMISE";
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].HeaderText = "QUANTITE";
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].HeaderText = "RESTE";
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].HeaderText = "FOURNISSEUR";
            dataGridView1.Columns[7].Width = 200;
        }

        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = null;
                view_product();
            }
            else
            {
                search_product(search);
            }
        }

        public void search_product(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_product", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", this.id);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@value", value);
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
