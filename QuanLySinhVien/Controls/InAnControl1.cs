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
using Microsoft.Reporting.WinForms;

namespace QuanLySinhVien.Controls
{
    public partial class InAnControl1 : UserControl
    {
        public InAnControl1()
        {
            InitializeComponent();
        }

        private void InAnControl1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string sqlconn = @"server=DESKTOP-JRFV3IL\SQLEXPRESS;Database=QLSV;Integrated security=true";
            conn = new SqlConnection(sqlconn);
            SqlCommand command = new SqlCommand();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from SINHVIEN", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SINHVIEN");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportSinhVien.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

    }
}
