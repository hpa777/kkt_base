using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication2
{
    public partial class Report2 : ReportControl
    {
        kktDataSetTableAdapters.reportDataTable2TableAdapter ta;

        public Report2()
        {
            InitializeComponent();
            masters_dirTableAdapter.Fill(kktDataSet.masters_dir);
            ta = new kktDataSetTableAdapters.reportDataTable2TableAdapter();
            reportPath = "Report2.rdlc";
        }

        public override void CreateReport()
        {
            int master_id = (int)comboBox1.SelectedValue;
            reportParameters = new ReportParameter[] {                
                new ReportParameter("masterName", ((DataRowView)comboBox1.SelectedItem)["value"].ToString())
            };
            ta.Fill(kktDataSet.reportDataTable2, master_id);
            reportDataSource = new ReportDataSource("report", this.kktDataSet.Tables["reportDataTable2"]);
        }
        
    }
}
