using Microsoft.Win32;
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
    public partial class Zakat : Form
    {
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        decimal inventaire,debtc,debtf,total,soyolaa,nisab,zakat;
        int id_zakat;

        public Zakat()
        {
            InitializeComponent();
        }

        private void soyola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
    && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nissab.Text) || String.IsNullOrEmpty(soyola.Text))
            {
                MessageBox.Show("تحقق من ادخال قيم النصاب والسيولة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                get_last_id_zakat();

                calculate_inventaire();

                calculate_debt_clients();

                calculate_debt_four();

                soyolaa = decimal.Parse(soyola.Text);
                nisab = decimal.Parse(nissab.Text);

                total = inventaire;

                if (checkBoxdebtnsalo.Checked)
                    total += this.debtc;

                if (checkBoxdebtysalohli.Checked)
                    total -= this.debtf;

                if (checkBoxsoyola.Checked)
                    total += this.soyolaa;

                if (total >= nisab)
                {
                    zakat = (total * 25)/1000;

                    this.pictureBox4.Visible = true;
                    this.pictureBox6.Visible = true;
                    this.pictureBox2.Visible = true;

                }
                else
                {
                    zakat = 0;
                    MessageBox.Show("المجموع أقل من قيمة النصاب", "زكاتي", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("المجموع \n"+this.total,"زكاتي");
                }

                TotalLbl.Text = zakat.ToString();
            }
        }

        public void get_last_id_zakat()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_last_id_zakat", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    id_zakat = Convert.ToInt32(dt.Rows[0][0]);
                    id_zakat++;
                }

                sqlcon.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void calculate_inventaire()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_inventaire", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        inventaire = decimal.Parse(drd.GetValue(0).ToString());
                    }
                    else
                    {
                        inventaire = 0;
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

        public void calculate_debt_clients()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_debt_clients", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        debtc = decimal.Parse(drd.GetValue(0).ToString());
                    }
                    else
                    {
                        debtc = 0;
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

        public void calculate_debt_four()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("get_debt_four", sqlcon);
                sda.CommandType = CommandType.StoredProcedure;

                SqlDataReader drd = sda.ExecuteReader();
                while (drd.Read())
                {
                    if (drd.GetValue(0).ToString() != "")
                    {
                        debtf = decimal.Parse(drd.GetValue(0).ToString());
                    }
                    else
                    {
                        debtf = 0;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            add_zakat();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zakat_detail zd = new zakat_detail();
            zd.Show();
        }

        public void add_zakat()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();

                SqlCommand sda = new SqlCommand("add_zakat", sqlcon);
                sda.Parameters.AddWithValue("@inv", this.inventaire);

                if (checkBoxdebtnsalo.Checked)
                    sda.Parameters.AddWithValue("@debtc", this.debtc);
                else
                    sda.Parameters.AddWithValue("@debtc", 0);

                if (checkBoxdebtysalohli.Checked)
                    sda.Parameters.AddWithValue("@debtf", this.debtf);
                else
                    sda.Parameters.AddWithValue("@debtf", 0);

                if (checkBoxsoyola.Checked)
                    sda.Parameters.AddWithValue("@soyola", this.soyolaa);
                else
                    sda.Parameters.AddWithValue("@soyola", 0);

                sda.Parameters.AddWithValue("@nissab", this.nisab);
                sda.Parameters.AddWithValue("@total", this.total);
                sda.Parameters.AddWithValue("@zakatt", this.zakat);
                sda.Parameters.AddWithValue("@date", DateTime.Today.Date);
                sda.CommandType = CommandType.StoredProcedure;

                sda.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("تم الإضافة بنجاح.","نجاح");

                clear();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }

        public void clear()
        {
            this.nissab.Text = "800000";
            this.soyola.Text = "0";
            this.TotalLbl.Text = "0";

            this.pictureBox4.Visible = false;
            this.pictureBox6.Visible = false;
            this.pictureBox2.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            add_zakat();
            print_zakat();
        }

        public void print_zakat()
        {
            printDocument1.Print();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            System.Drawing.RectangleF rectname = new System.Drawing.RectangleF(0, 0, 285, 25);
            e.Graphics.DrawString(key.GetValue("Name").ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, rectname, sf);
            //e.Graphics.DrawString("MAGASIN MEDJELLED", new Font("Arial",17,FontStyle.Bold),Brushes.Black,new Point(10,50));

            System.Drawing.RectangleF rectaddress = new System.Drawing.RectangleF(0, 30, 285, 25);
            e.Graphics.DrawString(key.GetValue("Address").ToString(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectaddress, sf);
            //e.Graphics.DrawString("CITE Maamoura -Laghouat-", new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, new Point(55, 80));

            System.Drawing.RectangleF rectphone = new System.Drawing.RectangleF(0, 50, 285, 25);
            e.Graphics.DrawString("Téléphone: " + key.GetValue("phone").ToString(), new Font("Hypermarket", 12, FontStyle.Regular), Brushes.Black, rectphone, sf);

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 3;
            e.Graphics.DrawLine(myPen, 1, 70, 1000, 70);

            System.Drawing.RectangleF rectticket = new System.Drawing.RectangleF(0, 80, 285, 25);
            e.Graphics.DrawString("ZAKATY N° "+id_zakat, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, rectticket, sf);
            //e.Graphics.DrawString("Ticket N° "+id_facture, new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(75, 110));

            e.Graphics.DrawLine(myPen, 1, 105, 1000, 105);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 112));
            e.Graphics.DrawLine(myPen, 1, 132, 1000, 132);

            e.Graphics.DrawString("قيمة السلع", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(206, 148));
            e.Graphics.DrawString(this.inventaire.ToString("#.000"), new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 148));
            e.Graphics.DrawLine(myPen, 1, 170, 1000, 170);

            decimal totaldebt=0;

            e.Graphics.DrawString("الديون الداخلية", new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(200, 217));
            if (checkBoxdebtnsalo.Checked)
            {
                e.Graphics.DrawString(this.debtc.ToString("#.000"), new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 217));
                totaldebt += this.debtc;
            }
            else
            {
                e.Graphics.DrawString("0.000", new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 217));
            }

            e.Graphics.DrawString("الديون الخارجية", new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(193, 237));
            if (checkBoxdebtysalohli.Checked)
            {
                e.Graphics.DrawString(this.debtf.ToString("#.000"), new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 237));
                totaldebt -= this.debtf;
            }
            else
            {
                e.Graphics.DrawString("0.000", new Font("Hypermarket", 10, FontStyle.Regular), Brushes.Black, new Point(10, 237));
            }

            e.Graphics.DrawString("الديون", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(230, 185));
            e.Graphics.DrawString(totaldebt.ToString("#.000"), new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 185));
            e.Graphics.DrawLine(myPen, 1, 207, 1000, 207);


            e.Graphics.DrawString("السيولة", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(223, 262));
            if (checkBoxsoyola.Checked)
            {
                e.Graphics.DrawString(soyolaa.ToString("#.000"), new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 262));
            }
            else
            {
                e.Graphics.DrawString("0.000", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 262));
            }
            e.Graphics.DrawLine(myPen, 1, 282, 1000, 282);
            e.Graphics.DrawLine(myPen, 1, 292, 1000, 292);

            e.Graphics.DrawString("المجموع", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(215, 307));
            e.Graphics.DrawString(this.total.ToString("#.000"), new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 307));
            e.Graphics.DrawLine(myPen, 1, 327, 1000, 327);

            e.Graphics.DrawString("النصاب", new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(220, 342));
            e.Graphics.DrawString(this.nisab.ToString("#.000"), new Font("Hypermarket", 12, FontStyle.Bold), Brushes.Black, new Point(10, 342));
            e.Graphics.DrawLine(myPen, 1, 362, 1000, 362);
            e.Graphics.DrawLine(myPen, 1, 372, 1000, 372);
            e.Graphics.DrawLine(myPen, 1, 382, 1000, 382);

            System.Drawing.RectangleF rectzakat = new System.Drawing.RectangleF(0, 397, 285, 25);
            e.Graphics.DrawString("قيمة الزكاة", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, rectzakat, sf);

            System.Drawing.RectangleF rectzakatvalue = new System.Drawing.RectangleF(0, 417, 285, 50);
            e.Graphics.DrawString(this.zakat.ToString("#.000"), new Font("Janna LT", 20, FontStyle.Bold), Brushes.Black, rectzakatvalue, sf);

            System.Drawing.RectangleF rectdzoftwares = new System.Drawing.RectangleF(0, 470, 285, 25);
            e.Graphics.DrawString("DZOFTWARE/ dzoftwares@gmail.com/ 0659785799/ 0555756280", new Font("Hypermarket", 8, FontStyle.Regular), Brushes.Black, rectdzoftwares, sf);

        }
    }
}
