using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    public delegate void DataSentHandler(string code, string desc, decimal prixachat, decimal prixvente, decimal prixremise);
    public partial class SearchProduct : Form
    {
        public event DataSentHandler DataSent;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        public SearchProduct()
        {
            InitializeComponent();
            show_all();
        }
        void show_all()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("show_full_prod", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
        }
        void rech_four(string s)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("search_full_prod", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@code", s);
            sda.SelectCommand.Parameters.AddWithValue("@des", s);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (searchfourn.Text == string.Empty)
            {
                show_all();
            }
            else
            {
                rech_four(searchfourn.Text);
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.DataSent(this.dataGridView2.CurrentRow.Cells[1].Value.ToString(), this.dataGridView2.CurrentRow.Cells[2].Value.ToString(), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[3].Value.ToString()), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[4].Value.ToString()), Convert.ToDecimal(this.dataGridView2.CurrentRow.Cells[5].Value.ToString()));
        }
    }
}
