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
    public partial class Add_worker : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        int id;
        string username;

        public Add_worker()
        {
            InitializeComponent();
            dateTimePickerdateofjoin.MaxDate = DateTime.Today;
            dateTimePickerdateofjoin.Value = DateTime.Today;
        }

        public Add_worker(string view, int id, string first_name, string last_name, string role, string salary, string date, string username, string password)
        {
            InitializeComponent();
            dateTimePickerdateofjoin.MaxDate = DateTime.Today;

            if (view == "Modify")
            {
                buttonadd.Text = "Modifier";
                label1.Text = "Modifier les informations";
                label1.Location = new Point(230, 12);
                this.id = id;
                textBoxfirstname.Text = first_name;
                textBoxlastname.Text = last_name;
                comboBoxrole.Text = role;
                textBoxbasesalary.Text = salary;

                if(date != "")
                {
                    dateTimePickerdateofjoin.Value = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    dateTimePickerdateofjoin.Value = DateTime.Today;
                }
                
                textBoxusername.Text = username;
                textBoxpassword.Text = password;
                this.username = username;
            }
            else
            {
                buttonadd.Visible = false;
                label1.Text = "Voir les informations";
                textBoxfirstname.Text = first_name;
                textBoxfirstname.ReadOnly = true;
                textBoxlastname.Text = last_name;
                textBoxlastname.ReadOnly = true;
                comboBoxrole.Visible = false;
                textBoxrole.Text = role;
                textBoxrole.Visible = true;
                textBoxbasesalary.Text = salary;
                textBoxbasesalary.ReadOnly = true;
                dateTimePickerdateofjoin.Visible = false;

                if(date != "")
                {
                    textBoxdate.Text = date.Remove(10, 9);
                }
                else
                {
                    textBoxdate.Text = "";
                }
                
                textBoxdate.Visible = true;
                textBoxusername.Text = username;
                textBoxusername.ReadOnly = true;
                textBoxpassword.Text = password;
                textBoxpassword.ReadOnly = true;
            }
        }

        bool start;

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

        public void just_letters(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.Space);
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            start = true;

            Color color = panelworkinformation.BackColor;

            field_coloring();

            if (String.IsNullOrEmpty(textBoxfirstname.Text) || String.IsNullOrEmpty(textBoxlastname.Text) ||
                  String.IsNullOrEmpty(comboBoxrole.Text) || String.IsNullOrEmpty(textBoxbasesalary.Text) ||
                  String.IsNullOrEmpty(textBoxusername.Text) || String.IsNullOrEmpty(textBoxpassword.Text))
            {
                Message_box mb = new Message_box(Login.action_yes_1, false, "");
                mb.label1.Text = "Veuillez remplir \n les champs en rouge";
                mb.label1.Location = new Point(70, 20);
                mb.Show();

                start = false;
            }
            else
            {
                if (start)
                {
                    if (buttonadd.Text == "Ajouter")
                    {
                        before_add_worker_username();
                    }
                    else
                    {
                        if (this.username == textBoxusername.Text)
                        {
                            labelusername.BackColor = Color.Lime;
                            modify_worker();
                        }
                        else
                        {
                            before_add_worker_username();
                        }
                    }
                }
            }
        }

        private void field_coloring()
        {
            if (String.IsNullOrEmpty(textBoxfirstname.Text))
            {
                labelfirstname.BackColor = Color.Red;
            }
            else
            {
                labelfirstname.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(textBoxlastname.Text))
            {
                labellastname.BackColor = Color.Red;
            }
            else
            {
                labellastname.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(comboBoxrole.Text))
            {
                labelrole.BackColor = Color.Red;
            }
            else
            {
                labelrole.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(textBoxbasesalary.Text))
            {
                labelbasesalary.BackColor = Color.Red;
            }
            else
            {
                labelbasesalary.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(textBoxusername.Text))
            {
                labelusername.BackColor = Color.Red;
            }
            else
            {
                labelusername.BackColor = Color.Lime;
            }

            if (String.IsNullOrEmpty(textBoxpassword.Text))
            {
                labelpassword.BackColor = Color.Red;
            }
            else
            {
                labelpassword.BackColor = Color.Lime;
            }
        }

        public void before_add_worker_username()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sda = new SqlDataAdapter("verify_username", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@username", textBoxusername.Text);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                sqlcon.Close();

                if (dtbl.Rows.Count == 1)
                {
                    Message_box mb = new Message_box(Login.action_yes_1, false, "");
                    mb.label1.Text = "Veuillez changer \nthe username";
                    mb.label1.Location = new Point(80, 20);
                    mb.Show();

                    labelusername.BackColor = Color.Red;
                }
                else
                {
                    if (buttonadd.Text == "Ajouter")
                    {
                        add_worker_();
                    }
                    else
                    {
                        modify_worker();
                    }
                    labelusername.BackColor = Color.Lime;
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void add_worker_()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("add_user", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@first_name_worker", textBoxfirstname.Text.ToString());
                sda.Parameters.AddWithValue("@last_name_worker", textBoxlastname.Text);
                sda.Parameters.AddWithValue("@role_worker", comboBoxrole.Text);
                sda.Parameters.AddWithValue("@salary_worker", decimal.Parse(textBoxbasesalary.Text));
                sda.Parameters.AddWithValue("@username_worker", textBoxusername.Text);
                sda.Parameters.AddWithValue("@password_worker", textBoxpassword.Text);
                sda.Parameters.AddWithValue("@date_of_join_worker", dateTimePickerdateofjoin.Value);

                sda.ExecuteNonQuery();
                sqlcon.Close();

                Message_box mb = new Message_box(Login.action_yes_1, false, "");
                mb.label1.Text = "Ajouté avec succès";
                mb.label1.Location = new Point(80, 30);
                mb.ShowDialog();

                this.Hide();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void modify_worker()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("update_user", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@id", id);
                sda.Parameters.AddWithValue("@first_name_worker", textBoxfirstname.Text.ToString());
                sda.Parameters.AddWithValue("@last_name_worker", textBoxlastname.Text);
                sda.Parameters.AddWithValue("@role_worker", comboBoxrole.Text);
                sda.Parameters.AddWithValue("@salary_worker", decimal.Parse(textBoxbasesalary.Text));
                sda.Parameters.AddWithValue("@username_worker", textBoxusername.Text);
                sda.Parameters.AddWithValue("@password_worker", textBoxpassword.Text);
                sda.Parameters.AddWithValue("@date_of_join_worker", dateTimePickerdateofjoin.Value);

                sda.ExecuteNonQuery();
                sqlcon.Close();

                Message_box mb = new Message_box(Login.action_yes_1, false, "");
                mb.label1.Text = "Changé avec succès";
                mb.label1.Location = new Point(80, 30);
                mb.ShowDialog();

                this.Hide();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
    }
}
