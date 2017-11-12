using System;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication2
{
    public partial class Report1 : ReportControl 
    {

        kktDataSetTableAdapters.reportDataTable1TableAdapter ta;

        public Report1()
        {
            InitializeComponent();
            masters_dirTableAdapter.Fill(kktDataSet.masters_dir);
            ta = new kktDataSetTableAdapters.reportDataTable1TableAdapter();
            reportPath = "Report1.rdlc";
        }               

        public override void CreateReport()
        {
            DateTime selDate = dateTimePicker1.Value;
            int yr = selDate.Year;
            int mth = selDate.Month;
            int lastDay = DateTime.DaysInMonth(yr, mth);
            DateTime d1 = new DateTime(yr, mth, 1);
            DateTime d2 = new DateTime(yr, mth, lastDay);
            int master_id = (int)comboBox1.SelectedValue;            
            reportParameters = new ReportParameter[] {
                new ReportParameter("reportDate", String.Format("{0} {1}", selDate.ToString("MMMM"), yr)),
                new ReportParameter("masterName", ((DataRowView)comboBox1.SelectedItem)["value"].ToString())
            };            
            ta.Fill(this.kktDataSet.reportDataTable1, master_id, d1, d2);
            reportDataSource = new ReportDataSource("report1", this.kktDataSet.Tables["reportDataTable1"]);
        }

    }
}
