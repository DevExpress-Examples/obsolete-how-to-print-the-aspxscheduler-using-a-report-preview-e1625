Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Public Class XtraSchedulerReport1
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
	Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells
	Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders
	Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
	Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler
	Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
	#Region "Fields"

	#End Region

	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Dim resourceFileName As String = "XtraSchedulerReport1.resx"
		Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
		Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
		Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
		Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
		Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
		Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
		CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' calendarControl1
		' 
		Me.calendarControl1.Location = New System.Drawing.Point(283, 8)
		Me.calendarControl1.Name = "calendarControl1"
		Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
		Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
		Me.calendarControl1.View = Me.reportDayView1
		' 
		' dayViewTimeCells1
		' 
		Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
		Me.dayViewTimeCells1.Location = New System.Drawing.Point(51, 200)
		Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
		Me.dayViewTimeCells1.ShowWorkTimeOnly = True
		Me.dayViewTimeCells1.Size = New System.Drawing.Size(592, 692)
		Me.dayViewTimeCells1.View = Me.reportDayView1
		' 
		' horizontalDateHeaders1
		' 
		Me.horizontalDateHeaders1.HorizontalHeaders = Me.horizontalResourceHeaders1
		Me.horizontalDateHeaders1.Location = New System.Drawing.Point(51, 175)
		Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
		Me.horizontalDateHeaders1.Size = New System.Drawing.Size(592, 25)
		Me.horizontalDateHeaders1.View = Me.reportDayView1
		' 
		' horizontalResourceHeaders1
		' 
		Me.horizontalResourceHeaders1.Location = New System.Drawing.Point(51, 150)
		Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
		Me.horizontalResourceHeaders1.Size = New System.Drawing.Size(592, 25)
		Me.horizontalResourceHeaders1.View = Me.reportDayView1
		' 
		' reportDayView1
		' 
		Me.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.calendarControl1, Me.dayViewTimeCells1, Me.horizontalDateHeaders1, Me.dayViewTimeRuler1, Me.horizontalResourceHeaders1, Me.timeIntervalInfo1})
		Me.Detail.Height = 899
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dayViewTimeRuler1
		' 
		Me.dayViewTimeRuler1.Corners.Top = 48
		Me.dayViewTimeRuler1.Location = New System.Drawing.Point(1, 150)
		Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
		Me.dayViewTimeRuler1.Size = New System.Drawing.Size(50, 742)
		Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
		Me.dayViewTimeRuler1.View = Me.reportDayView1
		' 
		' timeIntervalInfo1
		' 
		Me.timeIntervalInfo1.Location = New System.Drawing.Point(17, 8)
		Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
		Me.timeIntervalInfo1.Size = New System.Drawing.Size(242, 100)
		Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
		' 
		' XtraSchedulerReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "9.2"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportDayView1})
		CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	#End Region

End Class
