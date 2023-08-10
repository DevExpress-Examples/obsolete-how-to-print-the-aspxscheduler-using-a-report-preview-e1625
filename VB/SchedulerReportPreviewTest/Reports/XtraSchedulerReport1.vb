Public Class XtraSchedulerReport1
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView

    Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

    Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders

    Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders

    Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

    Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

    Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells

    Private Detail As DevExpress.XtraReports.UI.DetailBand

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

'#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Detail = New DevExpress.XtraReports.UI.DetailBand()
        calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
        dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
        horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
        horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
        reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
        timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
        dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
        CType(reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {calendarControl1, timeIntervalInfo1, dayViewTimeRuler1, horizontalDateHeaders1, horizontalResourceHeaders1, dayViewTimeCells1})
        Detail.HeightF = 985.3334F
        Detail.Name = "Detail"
        Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' calendarControl1
        ' 
        calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(300F, 0F)
        calendarControl1.Name = "calendarControl1"
        calendarControl1.SizeF = New System.Drawing.SizeF(301.0416F, 166.6667F)
        calendarControl1.TimeCells = dayViewTimeCells1
        calendarControl1.View = reportDayView1
        ' 
        ' dayViewTimeCells1
        ' 
        dayViewTimeCells1.HorizontalHeaders = horizontalResourceHeaders1
        dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(51.0416F, 218.6667F)
        dayViewTimeCells1.Name = "dayViewTimeCells1"
        dayViewTimeCells1.ShowWorkTimeOnly = True
        dayViewTimeCells1.SizeF = New System.Drawing.SizeF(550F, 679.8611F)
        dayViewTimeCells1.View = reportDayView1
        dayViewTimeCells1.VisibleTimeSnapMode = False
        ' 
        ' horizontalResourceHeaders1
        ' 
        horizontalResourceHeaders1.HorizontalHeaders = horizontalDateHeaders1
        horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(51.0416F, 192.6667F)
        horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
        horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(550F, 26F)
        horizontalResourceHeaders1.View = reportDayView1
        ' 
        ' horizontalDateHeaders1
        ' 
        horizontalDateHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(51.0416F, 166.6667F)
        horizontalDateHeaders1.Name = "horizontalDateHeaders1"
        horizontalDateHeaders1.SizeF = New System.Drawing.SizeF(550F, 26F)
        horizontalDateHeaders1.View = reportDayView1
        ' 
        ' timeIntervalInfo1
        ' 
        timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        timeIntervalInfo1.Name = "timeIntervalInfo1"
        timeIntervalInfo1.SizeF = New System.Drawing.SizeF(300F, 166.6667F)
        timeIntervalInfo1.TimeCells = dayViewTimeCells1
        ' 
        ' dayViewTimeRuler1
        ' 
        dayViewTimeRuler1.Corners.Top = 52
        dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(1.041603F, 166.6667F)
        dayViewTimeRuler1.Name = "dayViewTimeRuler1"
        dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50F, 731.8611F)
        dayViewTimeRuler1.TimeCells = dayViewTimeCells1
        dayViewTimeRuler1.View = reportDayView1
        ' 
        ' XtraSchedulerReport1
        ' 
        Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Detail})
        Version = "15.2"
        Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {reportDayView1})
        CType(reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
'#End Region
End Class
