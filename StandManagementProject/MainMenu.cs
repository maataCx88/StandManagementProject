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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            stk.Width = vente.Width=emp.Width=achat.Width=fees.Width=fctclt.Width=fctfourn.Width=stat.Width=dshboard.Width=pContainer.Width;
            stk.Height = vente.Height = emp.Height = achat.Height = fees.Height = fctclt.Height = fctfourn.Height = stat.Height = dshboard.Height  = pContainer.Height;

            this.pContainer.Controls.Add(stk); this.pContainer.Controls.Add(vente); this.pContainer.Controls.Add(emp); this.pContainer.Controls.Add(achat); this.pContainer.Controls.Add(fees); this.pContainer.Controls.Add(fctclt); this.pContainer.Controls.Add(fctfourn); this.pContainer.Controls.Add(stat); this.pContainer.Controls.Add(dshboard);
            dshboard.Show();
        }
        Vente vente = new Vente() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Employee emp = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Achat achat = new Achat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Fees fees = new Fees(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Stock stk = new Stock() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Factureclient fctclt = new Factureclient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Facturefournisseur fctfourn = new Facturefournisseur() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Caisse stat=new Caisse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Dashboard dshboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {          
            emp.Hide();
            achat.Hide();
            fees.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            stat.Hide();
            dshboard.Hide();
            stk.Hide();
            vente.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            vente.Hide();
            emp.Hide();
            achat.Hide();
            fees.Hide();
            fctclt.Hide();
            dshboard.Hide();
            fctfourn.Hide();
            stat.Hide();
            stk.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            vente.Hide();
            emp.Hide();
            fees.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide();
            stat.Hide();
            stk.Hide();
            achat.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            vente.Hide();
            emp.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide();
            fees.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide();
            fees.Hide();
            emp.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide();
            stk.Hide();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            vente.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide();
            fees.Hide();
            dshboard.Hide();
            emp.Hide();
            fctfourn.Hide();
            fctclt.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            vente.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            fctclt.Hide();
            dshboard.Show();
        }
    }
}
