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
        static int id1;
        public MainMenu(int id, string role, string name, string phone, string nameshop, string address, string email)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Left = Top = 0;
            label1.Text = nameshop;
            id1 = id;
            vente = new Vente(name, id1, phone, nameshop, address, email, "Principal") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fees = new Fees(id1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dshboard = new Dashboard(nameshop, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Barcode = new barcode(nameshop) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dette = new Dettes_dashboard(id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            stat = new Caissenew(name) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fct = new Facture_Devis(id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            zz=new Zakat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ss=new Settingss(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Barcode.Width = stk.Width =ss.Width= vente.Width =zz.Width = dette.Width = multi.Width = emp.Width = achat.Width = fees.Width = fctclt.Width = fctfourn.Width = stat.Width = dshboard.Width = fct.Width = bon.Width = pContainer.Width;
            Barcode.Height = stk.Height = vente.Height=ss.Height = dette.Height=zz.Height = emp.Height = multi.Height = achat.Height = fees.Height = fctclt.Height = fctfourn.Height = stat.Height = dshboard.Height = fct.Height = bon.Height = pContainer.Height;
            this.pContainer.Controls.Add(Barcode); this.pContainer.Controls.Add(ss); this.pContainer.Controls.Add(stk); this.pContainer.Controls.Add(zz); this.pContainer.Controls.Add(vente); this.pContainer.Controls.Add(emp); this.pContainer.Controls.Add(achat); this.pContainer.Controls.Add(fees); this.pContainer.Controls.Add(fctclt); this.pContainer.Controls.Add(fctfourn); this.pContainer.Controls.Add(stat); this.pContainer.Controls.Add(dshboard); this.pContainer.Controls.Add(dette); this.pContainer.Controls.Add(multi); this.pContainer.Controls.Add(fct); this.pContainer.Controls.Add(bon);
            if (role == "Vendeur")
            {
                guna2Button3.Visible = guna2Button4.Visible = guna2Button9.Visible = guna2Button5.Visible = guna2Button6.Visible = false;
            }
            dshboard.Show();
            timer1.Start();
            label4.Text = name + " !";
        }
        Vente vente;
        Employee emp = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Achat achat = new Achat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Fees fees;
        Stock stk = new Stock() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Factureclient fctclt = new Factureclient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Facturefournisseur fctfourn = new Facturefournisseur() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Caissenew stat;
        Dashboard dshboard;
        barcode Barcode;
        Dettes_dashboard dette;
        MultiCode multi = new MultiCode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Facture_Devis fct;
        Facture_Bon__Livraison bon = new Facture_Bon__Livraison() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Zakat zz;
        Settingss ss;
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showzakat()
        {
            achat.Hide();
            fees.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            fct.Hide();
            bon.Hide();
            Barcode.Hide();
            ss.Hide();
            dette.Hide();
            multi.Hide();
            emp.Hide();
            zz.Show();
            stat.Hide();
            dshboard.Hide();
            stk.Hide();
            vente.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            achat.Hide();
            fees.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            fct.Hide();
            ss.Hide();
            bon.Hide();
            Barcode.Hide();
            dette.Hide();
            multi.Hide();
            emp.Hide();
            zz.Hide();
            stat.Hide();
            dshboard.Hide();
            stk.Hide();
            vente.Show();
            vente.vider_tous_cas();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            vente.Hide();
            emp.Hide();
            achat.Hide();
            zz.Hide();
            fees.Hide();
            multi.Hide(); ss.Hide();
            fct.Hide();
            bon.Hide();
            fctclt.Hide();
            dette.Hide();
            dshboard.Hide();
            Barcode.Hide();
            fctfourn.Hide();
            stat.Hide();
            stk.Show();
            stk.view_stock();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            vente.Hide();
            emp.Hide();
            fees.Hide();
            dette.Hide();
            fct.Hide(); ss.Hide();
            zz.Hide();
            bon.Hide();
            multi.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide();
            Barcode.Hide();
            stat.Hide();
            stk.Hide();
            achat.Show();
            achat.call_all();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            vente.Hide();
            emp.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide(); ss.Hide();
            fct.Hide();
            zz.Hide();
            bon.Hide();
            multi.Hide();
            Barcode.Hide();
            dette.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide();
            fees.clear_all_fees();
            fees.Show();

            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            fctfourn.Hide();
            dshboard.Hide(); ss.Hide();
            fct.Hide();
            bon.Hide();
            stat.Hide();
            zz.Hide();
            multi.Hide();
            Barcode.Hide();
            dette.Hide();
            stk.Hide();
            achat.Hide();
            fees.Hide();
            emp.Show();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Hide();
            fct.Hide();
            bon.Hide();
            stk.Hide();
            multi.Hide();
            zz.Hide();
            Barcode.Hide();
            achat.Hide();
            dette.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Show();
            fctfourn.initiate_facture();
            fctfourn.Affichage_fact();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            vente.Hide();
            stat.Hide();
            stk.Hide();
            achat.Hide(); ss.Hide();
            fct.Hide();
            zz.Hide();
            bon.Hide();
            multi.Hide();
            Barcode.Hide();
            fees.Hide();
            dshboard.Hide();
            dette.Hide();
            emp.Hide();
            fctfourn.Hide();
            fctclt.Show();
            fctclt.bunifuDatepicker1.Value = fctclt.bunifuDatepicker2.Value = DateTime.Today;
            fctclt.Affichage_Vente();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            vente.Hide();
            stat.Hide();
            stk.Hide();
            Barcode.Hide();
            fct.Hide(); ss.Hide();
            zz.Hide();
            bon.Hide();
            multi.Hide();
            achat.Hide();
            dette.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            fctclt.Hide();
            dshboard.Show();
            dshboard.call_all();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("G");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide();
            stk.Hide();
            multi.Hide(); ss.Hide();
            fct.Hide();
            zz.Hide();
            bon.Hide();
            Barcode.Hide();
            achat.Hide();
            dette.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous quitter le programme ?", "Sortir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Show(); ss.Hide();
            dshboard.Hide();
            stk.Hide();
            Barcode.Hide();
            zz.Hide();
            dette.Hide();
            multi.Hide();
            fct.Hide();
            bon.Hide();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
          MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dette.Hide(); ss.Hide();
            multi.Hide();
            zz.Hide();
            dshboard.Hide();
            stk.Hide();
            Barcode.Show();
            Barcode.clear_all_barcode();
            fct.Hide();
            bon.Hide();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
          MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Hide();
            stk.Hide();
            Barcode.Hide();
            multi.Hide();
            achat.Hide();
            zz.Hide();
            fct.Hide();
            bon.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            dette.Show();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void showfct()
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Hide();
            stk.Hide();
            Barcode.Hide();
            multi.Hide();
            achat.Hide();
            fct.Affichage_Vente();
            fct.Show();
            bon.Hide();
            zz.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            dette.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void showbon()
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Hide();
            stk.Hide();
            Barcode.Hide();
            multi.Hide();
            achat.Hide();
            fct.Hide();
            zz.Hide();
            bon.Affichage_Vente();
            bon.Show();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            dette.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Hide();
            stk.Hide();
            Barcode.Hide();
            fct.Hide();
            bon.Hide();
            zz.Hide();
            multi.Show();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            dette.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            vente.Hide();
            fctclt.Hide();
            stat.Hide();
            dshboard.Hide(); ss.Show();
            stk.Hide();
            Barcode.Hide();
            fct.Hide();
            bon.Hide();
            zz.Hide();
            multi.Hide();
            achat.Hide();
            fees.Hide();
            emp.Hide();
            fctfourn.Hide();
            dette.Hide();
            MessageBox.Show("Vous utilisez le pack d'essai 30 jours, vous pouvez considerer d'acheter la version complete, Merci ", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
