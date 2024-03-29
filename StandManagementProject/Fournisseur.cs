﻿using System;
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
    public partial class Fournisseur : Form
    {
        Vente vnt;
        public Fournisseur(Vente vente)
        {
            InitializeComponent();
            this.vnt = vente;
            Affichage_Four();
            last_ID_Four();
            DataFournisseur.Columns[0].Visible = false;
            
        }
        
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        
        int id = 0;
        void Rechercher_Four(string name)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("search_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@nom", name);
                using (DataTable dt = new DataTable())
                {
                    sqlcmd.Fill(dt);
                    DataFournisseur.DataSource = dt;
                }
                sqlcon.Close();
            }
        }
        void Affichage_Four()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("show_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlcmd.Fill(dt);
                DataFournisseur.DataSource = dt;
                
                
                sqlcon.Close();
            }
        }
        void last_ID_Four()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("get_last_id_four", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlcmd.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0]);
                /*MessageBox.Show("last id"+ id.ToString());*/
                sqlcon.Close();
            }
        }
        void Ajouter_Four(string nom,string prénom,string phone)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("add_four", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@nom", nom);
                sqlcmd.Parameters.AddWithValue("@prenom", prénom);
                sqlcmd.Parameters.AddWithValue("@phone", phone);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
       

        private void Recherchetxt_TextChanged(object sender, EventArgs e)
        {
            if(Recherchetxt.Text != string.Empty)
            {
                
                Rechercher_Four(Recherchetxt.Text);
            }
            else
            {
                Affichage_Four();
            }
        }

        private void DataFournisseur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataFournisseur.CurrentRow.Index != -1 && DataFournisseur.CurrentRow.Index != DataFournisseur.RowCount-1)
            {
                int id = Convert.ToInt32(this.DataFournisseur.CurrentRow.Cells[0].Value);
                string NameTxt = this.DataFournisseur.CurrentRow.Cells[1].Value.ToString();
                string PhoneFourTxt = this.DataFournisseur.CurrentRow.Cells[2].Value.ToString();                
                //pass_to_four();
                /*MessageBox.Show("Name"+ vnt.four + " ID "+ vnt.id);   */            
                this.Close();        
            }
        }

        private void AjouterNew_Click(object sender, EventArgs e)
        {
            if(Nom.Text == string.Empty || Prénom.Text == string.Empty)
            {
                MessageBox.Show("au moins Remplissez le nom et le prénom S.V.P !");
            }
            else
            {
                Ajouter_Four(Nom.Text, Prénom.Text,PhoneFour.Text);
                last_ID_Four();
                this.Close();

            }
        }
    }
}
