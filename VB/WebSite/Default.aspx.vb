Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxMenu
Imports DevExpress.XtraScheduler

Partial Public Class [Default]
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DataHelper.SetupMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

		PrepareReportPreview(PreviewPanel)

	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		ASPxScheduler1.Start = DateTime.Today
	End Sub
	#Region "#preparereportpreview"
	Private Sub PrepareReportPreview(ByVal cp As Control)
	ASPxSchedulerControlPrintAdapter1.TimeInterval = New TimeInterval(DateTime.Today, DateTime.Today.AddDays(7))
	ASPxSchedulerControlPrintAdapter1.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18))

	Dim reportPreview As ReportPreview = CType(Page.LoadControl("ReportPreview.ascx"), ReportPreview)
	reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1

	cp.Controls.Clear()
	cp.Controls.Add(reportPreview)
	End Sub
	#End Region ' #preparereportpreview

Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase)
		PreviewPanel.Visible = True
End Sub
End Class
