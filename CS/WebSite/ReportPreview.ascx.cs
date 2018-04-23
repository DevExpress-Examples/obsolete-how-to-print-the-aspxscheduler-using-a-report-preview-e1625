#region #reportpreview
using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.Web.ASPxScheduler.Reporting;

public partial class ReportPreview : System.Web.UI.UserControl {
    ASPxSchedulerControlPrintAdapter var_controlAdapter;

    public ASPxSchedulerControlPrintAdapter ControlAdapter { 
        get { return var_controlAdapter; } 
        set { var_controlAdapter = value; } }

    protected void Page_Load(object sender, EventArgs e) {
        XtraSchedulerReport1 rpt = new XtraSchedulerReport1();
        rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter;
        ReportViewer1.Report = rpt;
    }
}
#endregion #reportpreview
