Imports Microsoft.VisualBasic
#Region "#reportpreview"
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.Web.ASPxScheduler.Reporting

Partial Public Class ReportPreview
	Inherits System.Web.UI.UserControl
	Private var_controlAdapter As ASPxSchedulerControlPrintAdapter

	Public Property ControlAdapter() As ASPxSchedulerControlPrintAdapter
		Get
			Return var_controlAdapter
		End Get
		Set(ByVal value As ASPxSchedulerControlPrintAdapter)
			var_controlAdapter = value
		End Set
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim rpt As New XtraSchedulerReport1()
		rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter
		ReportViewer1.Report = rpt
	End Sub
End Class
#End Region ' #reportpreview
