using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class ReportControl : UserControl
    {
        public virtual void CreateReport()
        {
        }

        public string reportPath;

        public ReportDataSource reportDataSource;

        public ReportParameter[] reportParameters;

        
    }
}
