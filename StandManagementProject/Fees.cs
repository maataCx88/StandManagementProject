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
    public partial class Fees : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id;

        public Fees(int id)
        {
            InitializeComponent();

            metroDateTimestartdate.MaxDate = DateTime.Today;
            metroDateTimefinishdate.MaxDate = DateTime.Today;
            metroDateTimedate.MaxDate = DateTime.Today;

            metroDateTimestartdate.Value = DateTime.Today;
            metroDateTimefinishdate.Value = DateTime.Today;

            this.id = id;
        }

        bool start;
        public void clear_all_fees()
        {
            richTextBox1.Text = textBoxamount.Text = metroTextBoxsearch.Text = string.Empty;
            metroDateTimedate.Value = metroDateTimestartdate.Value = metroDateTimestartdate.Value = DateTime.Today;
        }
        public void just_numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void view_fees()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("show_charge_bydate", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);
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
            dataGridView1.Columns[0].HeaderText = "N°";
          //  dataGridView1.Columns[0].Width = 113;
            dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
         //   dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "MONTAT";
          //  dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].HeaderText = "DATE";
          //  dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "NOM";
         //   dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].HeaderText = "PRENOM";
          //  dataGridView1.Columns[6].Width = 120;
        }

        private void pictureBoxsearch_Click(object sender, EventArgs e)
        {
            if (metroDateTimestartdate.Value <= metroDateTimefinishdate.Value)
            {
                view_fees();
                datagridviewchange();
            }
            else
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Changer la date \n S.V.P";
                mb.label1.Location = new Point(80, 20);
                mb.Show();
            }
            calc();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            start = true;

            field_coloring();

            if (String.IsNullOrEmpty(richTextBox1.Text) || String.IsNullOrEmpty(textBoxamount.Text))
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Please fill \n the fields in red";
                mb.label1.Location = new Point(90, 20);
                mb.Show();

                start = false;
            }
            else
            {
                if (start)
                {
                    add_fee();
                }
            }
            calc();
        }

        private void field_coloring()
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                labeldesecreption.BackColor = Color.Red;
            }
            else
            {
                labeldesecreption.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(textBoxamount.Text))
            {
                labelamount.BackColor = Color.Red;
            }
            else
            {
                labelamount.BackColor = Color.Lime;
            }

        }

        public void add_fee()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("add_charge", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@desc", richTextBox1.Text);
                sda.Parameters.AddWithValue("@amount", decimal.Parse(textBoxamount.Text));
                sda.Parameters.AddWithValue("@date", metroDateTimedate.Value);
                sda.Parameters.AddWithValue("@id", this.id);

                sda.ExecuteNonQuery();
                sqlcon.Close();

                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Ajouté avec succès";
                mb.label1.Location = new Point(80, 30);
                mb.ShowDialog();

                clear();
                dataGridView1.DataSource = null;
                view_fees();
                datagridviewchange();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void clear()
        {
            richTextBox1.Text = "";
            textBoxamount.Text = "";
            metroDateTimedate.Value = DateTime.Today;
            labeldesecreption.BackColor = panel4.BackColor;
            labelamount.BackColor = panel4.BackColor;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBoxamount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    if(dataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
                    {
                        metroDateTimedate.Value = DateTime.ParseExact(dataGridView1.CurrentRow.Cells[3].Value.ToString(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        metroDateTimedate.Value = DateTime.Today;
                    }
                   
                    textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
                else
                {
                    Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                    mb.label1.Text = "Choisissez-en un \ns'il vous plaît.";
                    mb.label1.Location = new Point(80, 20);
                    mb.Show();

                    clear();
                }
            }
        }

        private void buttonmodify_Click(object sender, EventArgs e)
        {
            start = true;

            field_coloring();

            if (String.IsNullOrEmpty(richTextBox1.Text) || String.IsNullOrEmpty(textBoxamount.Text))
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Veuillez remplir \n les champs en rouge";
                mb.label1.Location = new Point(70, 20);
                mb.Show();

                start = false;
            }
            else
            {
                if (start)
                {
                    modify_fee();
                }
            }
            calc();
        }

        public void modify_fee()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("update_charge", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@id", textBoxid.Text);
                sda.Parameters.AddWithValue("@desc", richTextBox1.Text);
                sda.Parameters.AddWithValue("@amount", decimal.Parse(textBoxamount.Text));
                sda.Parameters.AddWithValue("@date", metroDateTimedate.Value);

                sda.ExecuteNonQuery();
                sqlcon.Close();

                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Changé avec succès";
                mb.label1.Location = new Point(80, 30);
                mb.ShowDialog();

                clear();
                dataGridView1.DataSource = null;
                view_fees();
                datagridviewchange();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void datagridviewchange()
        {
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

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Message_box mb1 = new Message_box(LOGIN_.action_yes_1, true, "Back");
            mb1.label1.Text = "Voulez-vous supprimer \ncet frais ?";
            mb1.label1.Location = new Point(60, 20);
            mb1.ShowDialog();

            if (Message_box.yesorno == "Yes")
            {
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();

                    SqlCommand sda = new SqlCommand("delete_fee", sqlcon);
                    sda.Parameters.AddWithValue("@id", Int32.Parse(textBoxid.Text));
                    sda.CommandType = CommandType.StoredProcedure;

                    sda.ExecuteNonQuery();
                    sqlcon.Close();

                    Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                    mb.label1.Text = "Supprimer avec succès";
                    mb.label1.Location = new Point(60, 30);
                    mb.ShowDialog();

                    clear();
                    dataGridView1.DataSource = null;
                    view_fees();
                    datagridviewchange();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                    MessageBox.Show("" + exp);
                }
            }
            calc();
        }

        private void metroTextBoxsearch_TextChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = null;
                view_fees();
                datagridviewchange();
            }
            else
            {
                if (checkBox1.Checked)
                {
                    search_fees(search);
                }
                else
                {
                    search_fees_with_description(search);
                }
                
                datagridviewchange();
            }
            calc();
        }

        public void search_fees(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_fees", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@value", value);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date1", metroDateTimestartdate.Value);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@date2", metroDateTimefinishdate.Value);
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
        public void search_fees_with_description(string value)
        {
            try
            {
                dataGridView1.DataSource = null;

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("search_fees_with_description", sqlcon);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string search = metroTextBoxsearch.Text;
            if (String.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = null;
                view_fees();
                datagridviewchange();
            }
            else
            {
                if (checkBox1.Checked)
                {
                    search_fees(search);
                    
                }
                else
                {
                    search_fees_with_description(search);

                }

                datagridviewchange();
            }
            calc();
        }
        void calc()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells[2].Value);
            }
            labelTotal.Text = total.ToString("#.000");
        }
    }
}
