Imports Microsoft.VisualBasic
Imports System
Namespace DXApplication1.Reports
	Partial Public Class XtraSchedulerReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
			Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
			Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
			Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
			Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
			Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
			Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
			CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.calendarControl1, Me.timeIntervalInfo1, Me.dayViewTimeRuler1, Me.horizontalDateHeaders1, Me.horizontalResourceHeaders1, Me.dayViewTimeCells1})
			Me.Detail.HeightF = 897.0811F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dayViewTimeCells1
			' 
			Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalResourceHeaders1
			Me.dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(49.99996F, 202.0417F)
			Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
			Me.dayViewTimeCells1.SizeF = New System.Drawing.SizeF(600F, 695.0394F)
			Me.dayViewTimeCells1.View = Me.reportDayView1
			Me.dayViewTimeCells1.VisibleTimeSnapMode = False
			' 
			' horizontalResourceHeaders1
			' 
			Me.horizontalResourceHeaders1.HorizontalHeaders = Me.horizontalDateHeaders1
			Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(50F, 176.0417F)
			Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
			Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(600F, 25.99998F)
			Me.horizontalResourceHeaders1.View = Me.reportDayView1
			' 
			' horizontalDateHeaders1
			' 
			Me.horizontalDateHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(50F, 150.0417F)
			Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
			Me.horizontalDateHeaders1.SizeF = New System.Drawing.SizeF(600F, 26F)
			Me.horizontalDateHeaders1.View = Me.reportDayView1
			' 
			' dayViewTimeRuler1
			' 
			Me.dayViewTimeRuler1.Corners.Top = 52
			Me.dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 150.0418F)
			Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
			Me.dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50F, 747.0393F)
			Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
			Me.dayViewTimeRuler1.View = Me.reportDayView1
			' 
			' timeIntervalInfo1
			' 
			Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
			Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(300F, 150F)
			Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
			' 
			' calendarControl1
			' 
			Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(300F, 0F)
			Me.calendarControl1.Name = "calendarControl1"
			Me.calendarControl1.SizeF = New System.Drawing.SizeF(350F, 150F)
			Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
			Me.calendarControl1.View = Me.reportDayView1
			' 
			' XtraSchedulerReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.Version = "13.2"
			Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportDayView1})
			CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells
		Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
		Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
		Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
		Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders
		Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
		Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler
	End Class
End Namespace
