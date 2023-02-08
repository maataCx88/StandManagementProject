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
    public partial class ColorBill : Form
    {
        public ColorBill(Factureclient fct,int id)
        {
            InitializeComponent();
            this.fct = fct;
            this.id = id;
        }
        SqlConnection sqlcon = new SqlConnection(@Properties.Settings.Default.FullString);
        int id = 0;
        Factureclient fct;
        public void set_color(int id,string color)
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlcmd = new SqlDataAdapter("update_back_color_to_bill", sqlcon);
                sqlcmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlcmd.SelectCommand.Parameters.AddWithValue("@id", id);
                sqlcmd.SelectCommand.Parameters.AddWithValue("@color", color);
                sqlcmd.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()== DialogResult.OK)
            {
                textBox1.Text = colorDialog.Color.ToKnownColor().ToString();
                pictureBox1.BackColor = colorDialog.Color;
                set_color(this.id, textBox1.Text);
                fct.Affichage_Vente();
                fct.colors();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            set_color(this.id, "WhiteSmoke");
            fct.Affichage_Vente();
            fct.colors();
        }
    }
}
