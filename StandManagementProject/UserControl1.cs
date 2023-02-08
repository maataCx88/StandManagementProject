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
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(Form))]
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Stock stock, int id_prod, string designation, decimal prix_u, decimal prix_v, decimal prix_r, decimal prix_g, int qte, decimal piéces)
        {
            InitializeComponent();
            this.stk = stock;
            this.metroAchat.Text = prix_u.ToString("#.000");
            this.metroVente.Text = prix_v.ToString("#.000");
            this.metroRemise.Text = prix_r.ToString("#.000");
            this.metrogros.Text = prix_g.ToString("#.000");
            this.id_prod = id_prod;
            this.prix_u = prix_u;
            this.prix_v = prix_v;
            this.prix_r = prix_r;
            this.prix_g = prix_g;
            this.designation = designation;
            this.qtestock = qte;
            this.piéces = piéces;
            this.metroDésignationTxt.Text = designation;
            this.metroQTE.Text = this.qtestock.ToString("#.000");
            this.metroTextPiéces.Text = this.piéces.ToString("#.000");
        }
        int id_prod = -1; decimal prix_u = -1, prix_v = -1, prix_r = -1, prix_g = -1; Stock stk;
        string designation = string.Empty; decimal piéces = 0;

        private void metroQTE_TextChanged(object sender, EventArgs e)
        {
            if (metroQTE.Text != string.Empty)
            {
                if (metroTextBoites.Text == string.Empty && metroTextPiéces.Text == string.Empty)
                {
                    metroTextBoites.Text = metroTextPiéces.Text = string.Empty;
                    //metroQTE.Text = (Convert.ToDecimal(metroTextBoites.Text) * Convert.ToDecimal(metroTextBoites.Text)).ToString();

                }

                //metroTextBoites.Enabled = metroTextPiéces.Enabled = false;
            }
            else
            {
                metroTextBoites.Text = metroTextPiéces.Text = string.Empty;
                metroQTE.Enabled = true;
                metroTextBoites.Enabled = metroTextPiéces.Enabled = true;
            }
        }

        private void metroTextBoites_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoites.Text != string.Empty && metroTextPiéces.Text != string.Empty)
            {
                metroQTE.Enabled = false;
                metroQTE.Text = (Convert.ToDecimal(metroTextPiéces.Text) * Convert.ToDecimal(metroTextBoites.Text)).ToString();

            }
            else if (metroTextBoites.Text == string.Empty && metroTextPiéces.Text == string.Empty)
            {
                metroQTE.Enabled = true;
                metroQTE.Text = string.Empty;
                // 
            }
        }

        private void metroTextPiéces_Click(object sender, EventArgs e)
        {
            metroTextPiéces.Focus();
        }

        decimal qtestock = 0;
        private void metroVente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroValidate_Click(object sender, EventArgs e)
        {
            if (metrogros.Text == string.Empty || metroRemise.Text == string.Empty || metroVente.Text == string.Empty
               || metroQTE.Text == string.Empty || metroDésignationTxt.Text == string.Empty || metroAchat.Text == string.Empty)
            {
                MessageBox.Show("Veuillez Remplir tout les case pour Valider");
            }
            else
            {
                if (Convert.ToDecimal(metroVente.Text) < Convert.ToDecimal(metroAchat.Text))
                {
                    MessageBox.Show(" Prix de vente Pas moins de " + metroAchat.Text);
                    metroVente.Text = this.prix_v.ToString();
                }
                else
                {
                    if (Convert.ToDecimal(metroRemise.Text) > Convert.ToDecimal(metroVente.Text)
                        || Convert.ToDecimal(metroRemise.Text) < Convert.ToDecimal(metroAchat.Text))
                    {
                        MessageBox.Show(" Remise Pas plus de " + metroVente.Text + "\n " +
                            "et pas moins de  " + metroAchat.Text);
                        metroRemise.Text = this.prix_r.ToString();
                    }
                    else
                    {
                        decimal piéces = -1;
                        
                        this.designation = metroDésignationTxt.Text;
                        this.prix_u = Convert.ToDecimal(this.metroAchat.Text);
                        this.prix_v = Convert.ToDecimal(this.metroVente.Text);
                        this.prix_r = Convert.ToDecimal(this.metroRemise.Text);
                        this.prix_g = Convert.ToDecimal(this.metrogros.Text);
                        this.qtestock = Convert.ToDecimal(this.metroQTE.Text);
                        if (metroTextPiéces.Text == string.Empty)
                        {
                            piéces = 0;
                        }
                        else
                        {
                            piéces = Convert.ToDecimal(metroTextPiéces.Text);
                        }
                        //this.stk.update_product(id_prod, this.prix_u, this.prix_v, this.prix_r, this.prix_g);
                        this.stk.update_designation_and_qte(id_prod, this.designation, this.qtestock, this.prix_u, this.prix_v, this.prix_r, this.prix_g, piéces);
                        this.stk.view_stock();
                        MessageBox.Show("Les Prix sont mise à jour avec succées !");
                        this.Dispose();
                        this.Hide();

                    }
                }
            }
        }
    }

}
