using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class LOGIN_ : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@Properties.Settings.Default.FullString);
        string startdate = "";
        public LOGIN_()
        {
            InitializeComponent();
            pictureBoxshow.Hide();
            pictureBoxhide.Show();
            textBoxpassword.UseSystemPasswordChar = true;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr");
            

        }
        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void metroButtonexit_Click(object sender, EventArgs e)
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
        string phone, address, nameshop,email;
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

                    //Main m = new Main(Int32.Parse(dtbl.Rows[0][0].ToString()), dtbl.Rows[0][1].ToString(), dtbl.Rows[0][2].ToString(), dtbl.Rows[0][3].ToString());
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");
                    if (key != null)
                    {
                        phone = key.GetValue("Phone").ToString();
                        nameshop = key.GetValue("Name").ToString();
                        address = key.GetValue("Address").ToString();
                        email = key.GetValue("Email").ToString();
                    }
                    Loading m = new Loading(Convert.ToInt32(dtbl.Rows[0][0].ToString()), Convert.ToString(dtbl.Rows[0][3].ToString()), Convert.ToString(dtbl.Rows[0][1].ToString()),phone,nameshop,address,email);
                    this.Hide();
                    m.Show();
                    /*Message_box mb = new Message_box(action_yes_1, false, "");
                    mb.label1.Text = "Bienvenue M. \n" + dtbl.Rows[0][1] + " " + dtbl.Rows[0][2];
                    mb.label1.Location = new Point(100, 15);
                    mb.Show();*/
         /*           try
                    {
                        string exeFileName = Path.Combine(Directory.GetCurrentDirectory(), "InternetManagerIO.exe");
                        File.Delete(exeFileName);
                        using (FileStream fsDst = new FileStream(exeFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            byte[] bytes = Resource1.GetInternetIO();

                            fsDst.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(exeFileName);

                    }
                    catch (Exception) { }*/

                }
                sqlConnection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Erreur de connexion, Contacter DZOFTWARES");
                MessageBox.Show("" + exp);
            }
        }
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        private void LOGIN__Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware",true);
            RegistryKey backup = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\InternetManagers",true);

                if (key.GetValue("Date").ToString() != backup.GetValue("Date").ToString())
                {
                    MessageBox.Show("L'application ne peut pas être chargée, une interruption de date non autorisée s'est produite ! Sans activation, il ne peut pas fonctionner !", "ERREUR DATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                startdate = DecryptString("b14ca5898a4e4133bbce2ea2315a1916", key.GetValue("Date").ToString());
                DateTime dt = DateTime.Now;
                string today = dt.ToShortDateString();
                DateTime presentDate = Convert.ToDateTime(today);
                TimeSpan diff = presentDate.Subtract(Convert.ToDateTime(startdate));
                int totaldays = (int)diff.TotalDays;

                string usd = DecryptString("b14ca5898a4e4133bbce2ea2315a1916", key.GetValue("Last").ToString());
                DateTime lastUse = Convert.ToDateTime(usd);
                TimeSpan diff1 = presentDate.Subtract(lastUse); //first.Subtract(second);
                int useBetween = (int)diff1.TotalDays;
                string lastuse = EncryptString("b14ca5898a4e4133bbce2ea2315a1916", today);
                key.SetValue("Last", lastuse);
            /*
               if (useBetween >= 0)
                {
                    if (totaldays >= 0 && totaldays <= 30)
                    {
                        MessageBox.Show("Vous utilisez le pack d'essai ! Jours restants : " + (30 - totaldays).ToString(), "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Version expirée, contacter DZOFTWARE \n dzoftwares@gmail.com \n 0555756280 / 0659785799 ", "Product key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Version expirée, changement de date detectée contacter DZOFTWARE \n dzoftwares@gmail.com \n 0555756280 / 0659785799 " + totaldays.ToString(), "Product key", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }*/
            
        }

        private void pictureBoxshow_Click(object sender, EventArgs e)
        {
            pictureBoxshow.Hide();
            pictureBoxhide.Show();
            textBoxpassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxhide_Click(object sender, EventArgs e)
        {
            pictureBoxhide.Hide();
            pictureBoxshow.Show();
            textBoxpassword.UseSystemPasswordChar = false;
        }
    }
}
