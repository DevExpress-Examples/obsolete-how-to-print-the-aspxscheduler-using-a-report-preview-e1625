using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxMenu;
using DevExpress.XtraScheduler;

public partial class Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		DataHelper.SetupMappings(ASPxScheduler1);
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
		DataSource1.AttachTo(ASPxScheduler1);

        PrepareReportPreview(PreviewPanel);

	}
    
    protected void Page_Init(object sender, EventArgs e) {
        ASPxScheduler1.Start = DateTime.Today;
    }
    #region #preparereportpreview
    void PrepareReportPreview(Control cp) {
    ASPxSchedulerControlPrintAdapter1.TimeInterval = 
        new TimeInterval(DateTime.Today, DateTime.Today.AddDays(7));
    ASPxSchedulerControlPrintAdapter1.WorkTime = 
        new TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18));

    ReportPreview reportPreview = (ReportPreview)Page.LoadControl("ReportPreview.ascx");
    reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1;

    cp.Controls.Clear();
    cp.Controls.Add(reportPreview);
}
    #endregion #preparereportpreview

protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e) {
        PreviewPanel.Visible = true;
    }
}
