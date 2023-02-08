using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Start : Form
    {
        string textpicture;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpram,
            int lpram);
        bool check;
        public Start(bool checkstate)
        {
            InitializeComponent();
            check = checkstate;

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (textboxstorename.Text.Length < 3)
            {
                MessageBox.Show("Entrez un nom entre 3-17 lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textboxphone.Text != "" && textboxphone.Text.Length != 10)
            {
                MessageBox.Show("Entrer 10 chiffres (ex: 0123456789 )", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textboxstorename.Text) || string.IsNullOrEmpty(textboxphone.Text) || string.IsNullOrEmpty(textboxadresse.Text))
            {
                MessageBox.Show("Veuillez remplir toutes les informations requises SVP(*).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Dzoftware");

                key.SetValue("Phone", textboxphone.Text);
                key.SetValue("Name", textboxstorename.Text);
                
                if (string.IsNullOrEmpty(textboxadresse.Text))
                {
                    key.SetValue("Address", "");
                }
                else
                {
                    key.SetValue("Address", textboxadresse.Text);
                }

                if (string.IsNullOrEmpty(textboxemail.Text))
                {
                    key.SetValue("Email", "");
                }
                else
                {
                    key.SetValue("Email", textboxemail.Text);
                }

                if (string.IsNullOrEmpty(textboxtype.Text))
                {
                    key.SetValue("Type", "");
                }
                else
                {
                    key.SetValue("Type", textboxtype.Text);
                }

                if (string.IsNullOrEmpty(textboxrc.Text))
                {
                    key.SetValue("RC", "");
                }
                else
                {
                    key.SetValue("RC", textboxrc.Text);
                }

                if (string.IsNullOrEmpty(textboxnif.Text))
                {
                    key.SetValue("NIF", "");
                }
                else
                {
                    key.SetValue("NIF", textboxnif.Text);
                }

                if (string.IsNullOrEmpty(textboxart.Text))
                {
                    key.SetValue("Art", "");
                }
                else
                {
                    key.SetValue("Art", textboxart.Text);
                }

                if (string.IsNullOrEmpty(textboxnis.Text))
                {
                    key.SetValue("NIS", "");
                }
                else
                {
                    key.SetValue("NIS", textboxnis.Text);
                }

                if (string.IsNullOrEmpty(textboxncb.Text))
                {
                    key.SetValue("NCB", "");
                }
                else
                {
                    key.SetValue("NCB", textboxncb.Text);
                }

                if (ImageToByte(pictureBoxpicture.Image) == null)
                {
                    key.SetValue("Picture", ImageToByte(pictureBox1.Image));
                }
                else
                {
                    key.SetValue("Picture", ImageToByte(pictureBoxpicture.Image));
                }

                string cryptedate = EncryptString("b14ca5898a4e4133bbce2ea2315a1916", DateTime.Now.ToShortDateString());
                key.SetValue("Date", cryptedate);
                string lastuse = EncryptString("b14ca5898a4e4133bbce2ea2315a1916", DateTime.Now.ToShortDateString());
                key.SetValue("Last", lastuse);
                key.Close();
                RegistryKey keybackup = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\InternetManagers");
                keybackup.SetValue("Phone", textboxphone.Text);
                keybackup.SetValue("Name", textboxstorename.Text);

                if (string.IsNullOrEmpty(textboxadresse.Text))
                {
                    keybackup.SetValue("Address", "");
                }
                else
                {
                    keybackup.SetValue("Address", textboxadresse.Text);
                }

                if (string.IsNullOrEmpty(textboxemail.Text))
                {
                    keybackup.SetValue("Email", "");
                }
                else
                {
                    keybackup.SetValue("Email", textboxemail.Text);
                }

                if (string.IsNullOrEmpty(textboxtype.Text))
                {
                    keybackup.SetValue("Type", "");
                }
                else
                {
                    keybackup.SetValue("Type", textboxtype.Text);
                }

                if (string.IsNullOrEmpty(textboxrc.Text))
                {
                    keybackup.SetValue("RC", "");
                }
                else
                {
                    keybackup.SetValue("RC", textboxrc.Text);
                }

                if (string.IsNullOrEmpty(textboxnif.Text))
                {
                    keybackup.SetValue("NIF", "");
                }
                else
                {
                    keybackup.SetValue("NIF", textboxnif.Text);
                }

                if (string.IsNullOrEmpty(textboxart.Text))
                {
                    keybackup.SetValue("Art", "");
                }
                else
                {
                    keybackup.SetValue("Art", textboxart.Text);
                }

                if (string.IsNullOrEmpty(textboxnis.Text))
                {
                    keybackup.SetValue("NIS", "");
                }
                else
                {
                    keybackup.SetValue("NIS", textboxnis.Text);
                }

                if (string.IsNullOrEmpty(textboxncb.Text))
                {
                    keybackup.SetValue("NCB", "");
                }
                else
                {
                    keybackup.SetValue("NCB", textboxncb.Text);
                }

                if (ImageToByte(pictureBoxpicture.Image) == null)
                {
                    keybackup.SetValue("Picture", ImageToByte(pictureBox1.Image));
                }
                else
                {
                    keybackup.SetValue("Picture", ImageToByte(pictureBoxpicture.Image));
                }
                if (check)
                {
                    keybackup.SetValue("Date", cryptedate);
                    keybackup.SetValue("Last", lastuse);
                }
                keybackup.Close();
                Properties.Settings.Default.FullString = "Data Source=.\\SQLEXPRESS;Initial Catalog=store;Trusted Connection=true";
                Properties.Settings.Default.Save();
                sendhello();
                MessageBox.Show("Enregistré avec succès!", "Enregistrer", MessageBoxButtons.OK);
                Application.Restart();
                //Do
            }
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxaddapicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                textpicture = open.FileName;
                Image image = System.Drawing.Image.FromFile(textpicture);
                Image image2 = resizepicture(image, pictureBoxpicture.Size);
                pictureBoxpicture.Image = image2;
            }
            visible_delete_picture();
        }

        public static Image resizepicture(Image image, Size size)
        {
            Image imagee = new Bitmap(size.Width, size.Height);
            using (Graphics graphics = Graphics.FromImage((Bitmap)imagee))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, size));
            }
            return imagee;
        }

        public void visible_delete_picture()
        {
            if (pictureBoxpicture.Image != null)
            {
                buttondeletepicture.Enabled = true; ;
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            byte[] byteArray = new byte[0];

            if (img != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Close();

                    byteArray = stream.ToArray();
                }
                return byteArray;
            }
            else
            {
                return null;
            }

        }

        private void panelfill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttondeletepicture_Click(object sender, EventArgs e)
        {
            pictureBoxpicture.Image = null;
            buttondeletepicture.Enabled = false ;
        }

        public void modify()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");
            
            byte[] picData = key.GetValue("Picture") as byte[] ?? null;
            using (MemoryStream ms = new MemoryStream(picData))
            {
                pictureBoxpicture.Image = Image.FromStream(ms);
            }

            textboxstorename.Text = key.GetValue("Name").ToString();
            textboxadresse.Text = key.GetValue("Address").ToString();
            textboxphone.Text = key.GetValue("Phone").ToString();
            textboxemail.Text = key.GetValue("Email").ToString();
            textboxtype.Text = key.GetValue("Type").ToString();
            textboxrc.Text = key.GetValue("RC").ToString();
            textboxnif.Text = key.GetValue("NIF").ToString();
            textboxart.Text = key.GetValue("Art").ToString();
            textboxnis.Text = key.GetValue("NIS").ToString();
            textboxncb.Text = key.GetValue("NCB").ToString();

            buttondeletepicture.Enabled = true;

        }

        static void sendhello()
        {
            String foldername = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DateTime now = DateTime.Now;
            string subject = "Hello new user!";
            string emailbody = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var address in host.AddressList)
            {
                emailbody += "Address: " + address;
            }
            emailbody += "\n User: " + Environment.UserDomainName + " \\ " + Environment.UserName;
            emailbody += "\n Host: " + host;
            emailbody += "\n Time:" + now.ToString() + "\n";
            emailbody += "A New user registered !";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress("lucasfring558@gmail.com");
            mailMessage.To.Add("lucasfring558@gmail.com");
            mailMessage.Subject = subject;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("lucasfring558@gmail.com", "tjdudywamnoserht");
            mailMessage.Body = emailbody;

            client.Send(mailMessage);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if (check)
            {
                RegistryKey backup = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\InternetManagers", true);
                if (backup != null)
                {
                    MessageBox.Show("L'application ne peut pas être chargée, une interruption de date non autorisée s'est produite ! Sans activation, il ne peut pas fonctionner !", "ERREUR DATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
