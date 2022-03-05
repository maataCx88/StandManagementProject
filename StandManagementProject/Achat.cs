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
    public partial class Achat : MetroFramework.Forms.MetroForm
    {
        public Achat()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            setdefaultzero(PrixAchatTextBox);
            setdefaultzero(PrixRemiseTextBox);
            setdefaultzero(PrixVenteTextBox);
            setdefaultzero(montantProduitTextBox);
            setdefaultzero(QteTextBox1);
            setdefaultzero(QuantitetotalTextBox);
            setdefaultzero(countproduitsTextBox);
            setdefaultzero(MontanttotalTextBox);
            setdefaultzero(montantRestTextBox);
        }

        private void Codelabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Opacity = .97;
            panel1.Visible = true;
            panel1.BackColor = Color.FromArgb(255, Color.White);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Recherchez produits existants")
            {
                SearchTextBox.Text = string.Empty;
            }
        }
        void setdefaultzero(MetroFramework.Controls.MetroTextBox t)
        {
            t.Text = "0";
        }
        void calc()
        {

            if (dataGridView1.Rows.Count != 0)
            {
                decimal montant = 0;
                decimal qte = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    montant += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    qte += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                countproduitsTextBox.Text = dataGridView1.Rows.Count.ToString();
                QuantitetotalTextBox.Text = qte.ToString();
                MontanttotalTextBox.Text = montant.ToString();

            }
        }
        private void addtobasket_Click(object sender, EventArgs e)
        {
            if (DescTextbox.Text == string.Empty || PrixAchatTextBox.Text == string.Empty || PrixRemiseTextBox.Text == string.Empty || PrixVenteTextBox.Text == string.Empty || QteTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Remplir tous les champs s.v.p !", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                if (CodeTextBox.Text == string.Empty)
                {
                    DialogResult rs = MessageBox.Show("Voulez vous ajouter un produit sans code  de reference ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        object[] obj = { "",CodeTextBox.Text, DescTextbox.Text, PrixAchatTextBox.Text, PrixRemiseTextBox.Text, PrixVenteTextBox.Text, PrixAchatTextBox.Text };
                        dataGridView1.Rows.Add(obj);
                        calc();
                    }

                }
                else
                {
                    object[] obj = { "", CodeTextBox.Text, DescTextbox.Text, PrixAchatTextBox.Text, PrixRemiseTextBox.Text, PrixVenteTextBox.Text, PrixAchatTextBox.Text };
                    dataGridView1.Rows.Add(obj);
                    calc();
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value = (e.RowIndex + 1).ToString();
        }
        

        private void PrixVenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrixRemiseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QteTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void montantProduitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removefrombasket_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("le panier est vide suppression impossible !","Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Voulez vous vraiment supprimer l'enregistrement sélectionner ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                   
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    MessageBox.Show("Suppression effectué avec succées");
                    calc();
                }

            }
        }

        private void resetfields_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Voulez vous vraiment vider les champs ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                CodeTextBox.Text = DescTextbox.Text = string.Empty;
                PrixAchatTextBox.Text = PrixRemiseTextBox.Text = PrixVenteTextBox.Text = montantProduitTextBox.Text = QteTextBox1.Text = "0";
            }
        }

        private void PrixAchatTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if(PrixAchatTextBox.Text != string.Empty && QteTextBox1.Text != string.Empty)
            {
                montantProduitTextBox.Text = (Convert.ToDecimal(PrixAchatTextBox.Text) * Convert.ToDecimal(QteTextBox1.Text)).ToString();

            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NomTextBox.Text  = PrenomTextBox.Text = TelephoneTextBox.Text = AddresseTextBox.Text = string.Empty;
            panel1.Visible = false;
            this.Opacity = 1;


        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void montantverseTextBox_TextChanged(object sender, EventArgs e)
        {
            montantRestTextBox.Text = (Convert.ToDecimal(MontanttotalTextBox.Text) - Convert.ToDecimal(montantverseTextBox.Text)).ToString();
        }

        private void montantRestTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(montantRestTextBox.Text) < 0)
            {
                montantRestTextBox.Text = "0";
            }
        }
    }
}

