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
    public partial class Login : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void metroButtonternout_Click(object sender, EventArgs e)
        {
            Message_box mb = new Message_box(action_yes_1, true, "");
            mb.label1.Text = "Etes-vous sûr de sortir \n l'application?";
            mb.label1.Location = new Point(65, 20);
            mb.Show();
        }

        public static void action_yes_1()
        {
            Application.Exit();
        }

        private void metroButtonlogin_Click(object sender, EventArgs e)
        {
            verify_login();
        }

        public void verify_login()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                SqlDataAdapter sda = new SqlDataAdapter("verify_login", sqlConnection);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@usrname", textBoxusername.Text);
                sda.SelectCommand.Parameters.AddWithValue("@pwd", textBoxpassword.Text);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 0)
                {
                    Message_box mb = new Message_box(action_yes_1, false, "");
                    mb.label1.Text = "Veuillez vérifier \n the username et password.";
                    mb.label1.Location = new Point(40, 20);
                    mb.Show();
                }
                else if (dtbl.Rows.Count == 1)
                {

                    Main m = new Main(Int32.Parse(dtbl.Rows[0][0].ToString()), dtbl.Rows[0][1].ToString(), dtbl.Rows[0][2].ToString(), dtbl.Rows[0][3].ToString());
                    this.Hide();
                    m.Show();

                    Message_box mb = new Message_box(action_yes_1, false, "");
                    mb.label1.Text = "Bienvenue M. \n" + dtbl.Rows[0][1] + " " + dtbl.Rows[0][2];
                    mb.label1.Location = new Point(100, 15);
                    mb.Show();
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, Contacter DZOFTWARES");
                MessageBox.Show(""+exp);
            }
        }

        private void pictureBoxshow_Click(object sender, EventArgs e)
        {
            pictureBoxshow.Hide();
            pictureBoxhide.Show();
            textBoxpassword.UseSystemPasswordChar = false;
            textBoxpassword.PasswordChar = '\0';
        }

        private void pictureBoxhide_Click(object sender, EventArgs e)
        {
            pictureBoxhide.Hide();
            pictureBoxshow.Show();
            textBoxpassword.UseSystemPasswordChar = true;
        }
    }
}
