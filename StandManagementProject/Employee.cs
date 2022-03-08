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
    public partial class Employee : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

        public Employee()
        {
            InitializeComponent();

            view_worker();

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

        public void view_worker()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_empl", sqlcon);
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
            dataGridView1.Columns[0].Width = 134;
            dataGridView1.Columns[1].HeaderText = "NOM";
            dataGridView1.Columns[1].Width = 142;
            dataGridView1.Columns[2].HeaderText = "PRENOM";
            dataGridView1.Columns[2].Width = 142;
            dataGridView1.Columns[3].HeaderText = "ROLE";
            dataGridView1.Columns[3].Width = 142;
            dataGridView1.Columns[4].HeaderText = "SALAIRE";
            dataGridView1.Columns[4].Width = 142;
            dataGridView1.Columns[5].HeaderText = "DATE AJOUT";
            dataGridView1.Columns[5].Width = 151;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    textBoxusername.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    textBoxpassword.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                    buttonview.Enabled = true;
                    buttonmodify.Enabled = true;
                    buttonviewusrpwd.Enabled = true;

                    if (String.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[6].Value.ToString()))
                    {
                        buttondelete.Enabled = true;
                        buttondateofdep.Enabled = false;
                    }
                    else
                    {
                        buttondelete.Enabled = false;
                        buttondateofdep.Enabled = true;
                    }
                }
                else
                {
                    Message_box mb = new Message_box(Login.action_yes_1, false, "");
                    mb.label1.Text = "Choisissez-en un \ns'il vous plaît.";
                    mb.label1.Location = new Point(80, 20);
                    mb.Show();

                    clear();
                }
            }
        }

        public void clear()
        {
            buttonview.Enabled = false;
            buttonmodify.Enabled = false;
            buttonviewusrpwd.Enabled = false;
            buttondateofdep.Enabled = false;
            buttondelete.Enabled = false;
        }

        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = null;
                view_worker();
            }
            else
            {
                search_worker(search);
            }
        }

        public void search_worker(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_worker", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        private void metroComboBoxstatus_TextChanged(object sender, EventArgs e)
        {
            string search = metroComboBoxstatus.Text;
            if (search == "TOUT")
            {
                dataGridView1.DataSource = null;
                view_worker();
            }
            else
            {
                search_worker_by_status(search);
            }
        }

        public void search_worker_by_status(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter;

                if (value == "OUI")
                {
                    sqlDataAdapter = new SqlDataAdapter("search_worker_by_oui", sqlcon);
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("search_worker_by_non", sqlcon);
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Add_worker add = new Add_worker();
            add.ShowDialog();

            clear();
            dataGridView1.DataSource = null;
            view_worker();
        }

        private void buttonviewusrpwd_Click(object sender, EventArgs e)
        {
            Message_box mb = new Message_box(Login.action_yes_1, true, "Back");
            mb.label1.Text = " Voulez-vous voir \n the username et password ?";
            mb.label1.Location = new Point(35, 15);
            mb.ShowDialog();

            if (Message_box.yesorno == "Yes")
            {
                Message_box mb1 = new Message_box(Login.action_yes_1, false, "");
                mb1.label1.Text = "The username est " + textBoxusername.Text + "\nThe password est " + textBoxpassword.Text;
                mb1.label1.Location = new Point(60, 15);
                mb1.ShowDialog();
            }
        }

        private void buttonmodify_Click(object sender, EventArgs e)
        {
            Add_worker add = new Add_worker("Modify", Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                dataGridView1.CurrentRow.Cells[8].Value.ToString());
            add.ShowDialog();

            clear();
            dataGridView1.DataSource = null;
            view_worker();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {

            Add_worker add = new Add_worker("View", Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                dataGridView1.CurrentRow.Cells[8].Value.ToString());
            add.ShowDialog();
        }

        private void buttondateofdep_Click(object sender, EventArgs e)
        {
            Message_box mb1 = new Message_box(Login.action_yes_1, false, "");
            mb1.label1.Text = "La date de départ est \n" + dataGridView1.CurrentRow.Cells[6].Value.ToString().Remove(10, 9);
            mb1.label1.Location = new Point(65, 15);
            mb1.ShowDialog();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Message_box mb1 = new Message_box(Login.action_yes_1, true, "Back");
            mb1.label1.Text = "Voulez-vous supprimer \ncet employé ?";
            mb1.label1.Location = new Point(60, 20);
            mb1.ShowDialog();

            if (Message_box.yesorno == "Yes")
            {
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();

                    SqlCommand sda = new SqlCommand("firing_worker", sqlcon);
                    sda.Parameters.AddWithValue("@id", Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    sda.Parameters.AddWithValue("@date", DateTime.Today.Date);
                    sda.CommandType = CommandType.StoredProcedure;

                    sda.ExecuteNonQuery();
                    sqlcon.Close();

                    Message_box mb = new Message_box(Login.action_yes_1, false, "");
                    mb.label1.Text = "Supprimer avec succès";
                    mb.label1.Location = new Point(60, 30);
                    mb.ShowDialog();

                    clear();
                    dataGridView1.DataSource = null;
                    view_worker();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                    MessageBox.Show("" + exp);
                }
            }
        }
    }
}
