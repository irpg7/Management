using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;


namespace IsKaiser.Management.WinUI.Reports
{
    public partial class rptStatusDetect : DevExpress.XtraReports.UI.XtraReport
    {

        public rptStatusDetect(int id)
        {
          InitializeComponent();
            sqlDataSource1.Queries["Query"].Parameters[0].Value = id;
        }
        



    }
}
