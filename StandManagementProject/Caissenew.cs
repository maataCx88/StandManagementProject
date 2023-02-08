using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Caissenew : Form
    {
        string user;
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        public Caissenew(string user)
        {
            InitializeComponent();
            this.user = user;
            comboBoxpar.SelectedIndex = 0;
            metroDateTimestartdate.CustomFormat = "dd/MM/yyyy";
            metroDateTimefinishdate.CustomFormat = "dd/MM/yyyy";

            metroDateTimestartdate.Value = DateTime.Today;
            metroDateTimefinishdate.Value = DateTime.Today;

            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("NO DATA","100");
        }

        private void comboBoxpar_TextChanged(object sender, EventArgs e)
        {
            metroDateTimestartdate.Format = DateTimePickerFormat.Custom;
            metroDateTimefinishdate.Format = DateTimePickerFormat.Custom;

            if (comboBoxpar.SelectedIndex == 0)
            {
                metroDateTimestartdate.CustomFormat = "dd/MM/yyyy";
                metroDateTimefinishdate.CustomFormat = "dd/MM/yyyy";
            }
            else if (comboBoxpar.SelectedIndex == 1)
            {
                metroDateTimestartdate.CustomFormat = "MM/yyyy";
                metroDateTimefinishdate.CustomFormat = "MM/yyyy";

                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddDays(-Int32.Parse(metroDateTimestartdate.Value.Day.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddDays(-Int32.Parse(metroDateTimefinishdate.Value.Day.ToString()));
            }
            else
            {
                metroDateTimestartdate.CustomFormat = "yyyy";
                metroDateTimefinishdate.CustomFormat = "yyyy";

                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddMonths(-Int32.Parse(metroDateTimestartdate.Value.Month.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddYears(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(-Int32.Parse(metroDateTimefinishdate.Value.Month.ToString()));

                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddDays(-Int32.Parse(metroDateTimestartdate.Value.Day.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddDays(-Int32.Parse(metroDateTimefinishdate.Value.Day.ToString()));
            }
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
                        labelbenefices.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelbenefices.Font= new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelbenefices.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelbenefices.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelbenefices.Text = "0";
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
                    if (drd.GetValue(0).ToString() != "")
                    {
                        labelcaisse.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelcaisse.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelcaisse.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelcaisse.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelcaisse.Text = "0";
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
                        labelmarch.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelmarch.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelmarch.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelmarch.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelmarch.Text = "0";
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
                        labelcharges.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelcharges.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelcharges.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelcharges.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelcharges.Text = "0";
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
                        labeldettesclient.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labeldettesclient.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labeldettesclient.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labeldettesclient.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labeldettesclient.Text = "0";
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
                        labeldettesfournisseur.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labeldettesfournisseur.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labeldettesfournisseur.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labeldettesfournisseur.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labeldettesfournisseur.Text = "0";
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
                        labelverse.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelverse.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelverse.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelverse.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelverse.Text = "0";
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
                        labelfactureclient.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelfactureclient.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelfactureclient.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelfactureclient.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelfactureclient.Text = "0";
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
                        labelfacturefournisseur.Text = drd.GetValue(0).ToString();

                        if (drd.GetValue(0).ToString().Length > 10)
                        {
                            labelfacturefournisseur.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 15)
                        {
                            labelfacturefournisseur.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                        }

                        if (drd.GetValue(0).ToString().Length > 20)
                        {
                            labelfacturefournisseur.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        labelfacturefournisseur.Text = "0";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBoxpar.SelectedIndex == 1)
            {
                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddDays(-Int32.Parse(metroDateTimestartdate.Value.Day.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddDays(-Int32.Parse(metroDateTimefinishdate.Value.Day.ToString()));
            }
            else if (comboBoxpar.SelectedIndex == 2)
            {
                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddMonths(-Int32.Parse(metroDateTimestartdate.Value.Month.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddYears(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(-Int32.Parse(metroDateTimefinishdate.Value.Month.ToString()));

                metroDateTimestartdate.Value = metroDateTimestartdate.Value.AddDays(-Int32.Parse(metroDateTimestartdate.Value.Day.ToString()) + 1);

                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddMonths(1);
                metroDateTimefinishdate.Value = metroDateTimefinishdate.Value.AddDays(-Int32.Parse(metroDateTimefinishdate.Value.Day.ToString()));
            }

            labelcaisse.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelmarch.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelcharges.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelverse.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelfactureclient.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelfacturefournisseur.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labeldettesclient.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labeldettesfournisseur.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labeltotal.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelbenefices.Font = new Font("Nirmala UI", 36, FontStyle.Bold);
            labelbeneficesnet.Font = new Font("Nirmala UI", 36, FontStyle.Bold);



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

                labeltotal.Text = (decimal.Parse(labelfactureclient.Text) - decimal.Parse(labelfacturefournisseur.Text)).ToString();
                if (labeltotal.Text.Length > 10)
                {
                    labeltotal.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                }
                if (labeltotal.Text.Length > 15)
                {
                    labeltotal.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                }
                if (labeltotal.Text.Length > 20)
                {
                    labeltotal.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                }

                labelbeneficesnet.Text = (decimal.Parse(labelbenefices.Text) + decimal.Parse(labelcharges.Text)).ToString();
                if (labelbeneficesnet.Text.Length > 10)
                {
                    labelbeneficesnet.Font = new Font("Nirmala UI", 24, FontStyle.Bold);
                }
                if (labeltotal.Text.Length > 15)
                {
                    labelbeneficesnet.Font = new Font("Nirmala UI", 18, FontStyle.Bold);
                }
                if (labelbeneficesnet.Text.Length > 20)
                {
                    labelbeneficesnet.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                }

                decimal marge;
                marge = decimal.Parse(labelbenefices.Text);
                if (labelcaisse.Text != "0" && labelcaisse.Text != "0,000")
                    marge /= decimal.Parse(labelcaisse.Text);
                else
                    marge = 0;
                marge *= 100;
                labelmarge.Text = marge.ToString("#.000")+"%";

                chart();
            }
            else
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Changer la date \n S.V.P";
                mb.label1.Location = new Point(80, 20);
                mb.Show();
            }
        }

        public void chart()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sda = new SqlDataAdapter("chart", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@start", metroDateTimestartdate.Value);
                sda.SelectCommand.Parameters.AddWithValue("@end", metroDateTimefinishdate.Value);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 0)
                {
                    chart1.Series["s1"].Points.Clear();
                    chart1.Series["s1"].IsValueShownAsLabel = true;
                    chart1.Series["s1"].Points.AddXY("NO DATA", "100");
                }
                else
                {
                    chart1.Series["s1"].Points.Clear();
                    foreach (DataRow row in dtbl.Rows)
                    {
                        decimal por = 0;
                        por = Int32.Parse(row[0].ToString());
                        por /= Int32.Parse(labelfactureclient.Text);
                        por *= 100;
                        chart1.Series["s1"].Points.AddXY(row[1].ToString(), por.ToString("#.00"));
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

        private void NoCode_Click(object sender, EventArgs e)
        {
            if (metroDateTimestartdate.Value <= metroDateTimefinishdate.Value)
            {
                Détail_caisse caisse = new Détail_caisse(comboBoxpar.Text, this.metroDateTimestartdate, this.metroDateTimefinishdate,this.user);
                caisse.Show();
            }
            else
            {
                Message_box mb = new Message_box(LOGIN_.action_yes_1, false, "");
                mb.label1.Text = "Changer la date \n S.V.P";
                mb.label1.Location = new Point(80, 20);
                mb.Show();
            }
        }
    }
}
