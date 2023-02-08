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
    public partial class Settingss : Form
    {
        MainMenu mm;
        public Settingss(MainMenu mm)
        {
            InitializeComponent();
            this.mm = mm;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
           
            if ((Application.OpenForms["Form1"] as Form1) != null)
            {
                MessageBox.Show("Calculatrice deja ouverte !");
            }
            else
            {
                Form1 ff = new Form1();
                ff.Show();
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["play"] as play) != null)
            {
                MessageBox.Show("Lecteur musique deja ouvert !");
            }
            else
            {
                play mm = new play();
                mm.Show();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Browser"] as Navigateur) != null)
            {
                MessageBox.Show("Navigateur Internet deja ouvert !");
            }
            else
            {
                Navigateur sss = new Navigateur();
                sss.Show();
            }
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Calendar"] as Calendar) != null)
            {
                MessageBox.Show("Calandrier deja ouvert !");
            }
            else
            {
                Calendar cc = new Calendar();
                cc.Show();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Guide"] as Guide) != null)
            {
                MessageBox.Show("Guide deja ouvert !");
            }
            else
            {
                Guide gd = new Guide(1);
                gd.Show();
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            mm.showzakat();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start start = new Start(false);
            start.modify();
            start.ShowDialog();
        }
    }
}
