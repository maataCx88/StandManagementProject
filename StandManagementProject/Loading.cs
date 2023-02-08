using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public partial class Loading : Form
    {
        public Loading(int id, string role, string name, string phone, string nameshop, string address,string email)
        {
            InitializeComponent();
            id1 = id;
            this.role = role;
            this.name = name;
            this.phone = phone;
            this.nameshop = nameshop;
            this.address = address;
            this.email = email;
        }
        int id1;
        string role;
        string name;
        string phone;
        string nameshop;
        string address;
        string email;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                MainMenu p = new MainMenu(id1,role,name,phone,nameshop,address,email);
                this.Hide();
                p.Show();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}
