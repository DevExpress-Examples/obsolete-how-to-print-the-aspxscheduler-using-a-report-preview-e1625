using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXApplication1.Reports
{
    #region #reportpreview
    public partial class ReportPreview : System.Web.UI.UserControl
    {
        public DevExpress.Web.ASPxScheduler.Reporting.ASPxSchedulerControlPrintAdapter ControlAdapter { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            XtraSchedulerReport1 rpt = new XtraSchedulerReport1();
            rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter;
            ASPxDocumentViewer1.Report = rpt;
        }
    }
    #endregion #reportpreview
}