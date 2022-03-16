using Microsoft.Reporting.WinForms;
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
    public partial class FactPrinter : Form
    {
        int id=0;
        string nometprenom="", totalprod="", totalmontant="", totalverse="", totalreste="";
        public FactPrinter(int id, string nometprenom, string totalprod, string totalmontant, string totalverse, string totalreste)
        {
            InitializeComponent();
            this.id = id;
            this.nometprenom = nometprenom; this.totalprod = totalprod; this.totalmontant = totalmontant; this.totalverse = totalverse; this.totalreste = totalreste;
         
            getfact(id);         
        }
        void getfact(int idfact)
        {
            DataSet dt = new DataSet();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("show_final_bill", sqlcon);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("id", idfact);
            sqlData.Fill(dt);
             
            ReportParameter nom = new ReportParameter("client",nometprenom);
            ReportParameter totalart = new ReportParameter("TotalArticle", totalprod);
            ReportParameter totalmont = new ReportParameter("MontantTotal", totalmontant);
            ReportParameter totalvers = new ReportParameter("MontantVerse", totalverse);
            ReportParameter totalrest = new ReportParameter("MontantRest", totalreste);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { totalart,totalmont,totalvers,totalrest,nom});
            ReportDataSource datasource = new ReportDataSource("DataSet1", dt.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.LocalReport.Refresh();
            sqlcon.Close();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        private void FactPrinter_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
