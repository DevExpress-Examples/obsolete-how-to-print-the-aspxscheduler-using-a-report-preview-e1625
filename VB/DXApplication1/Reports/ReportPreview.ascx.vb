Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace DXApplication1.Reports
	#Region "#reportpreview"
	Partial Public Class ReportPreview
		Inherits System.Web.UI.UserControl
		Private privateControlAdapter As DevExpress.Web.ASPxScheduler.Reporting.ASPxSchedulerControlPrintAdapter
		Public Property ControlAdapter() As DevExpress.Web.ASPxScheduler.Reporting.ASPxSchedulerControlPrintAdapter
			Get
				Return privateControlAdapter
			End Get
			Set(ByVal value As DevExpress.Web.ASPxScheduler.Reporting.ASPxSchedulerControlPrintAdapter)
				privateControlAdapter = value
			End Set
		End Property

		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim rpt As New XtraSchedulerReport1()
			rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter
			ASPxDocumentViewer1.Report = rpt
		End Sub
	End Class
	#End Region ' #reportpreview
End Namespace