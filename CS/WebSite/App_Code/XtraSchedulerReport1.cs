using System;
using DevExpress.XtraScheduler;

public class XtraSchedulerReport1 : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
    private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;
    private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
    private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
    private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
    #region Fields

    #endregion

    /// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

    public XtraSchedulerReport1()
	{        
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
    private void InitializeComponent() {
        string resourceFileName = "XtraSchedulerReport1.resx";
        this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
        this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
        this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
        this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
        this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
        this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
        ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // calendarControl1
        // 
        this.calendarControl1.Location = new System.Drawing.Point(283, 8);
        this.calendarControl1.Name = "calendarControl1";
        this.calendarControl1.Size = new System.Drawing.Size(350, 142);
        this.calendarControl1.TimeCells = this.dayViewTimeCells1;
        this.calendarControl1.View = this.reportDayView1;
        // 
        // dayViewTimeCells1
        // 
        this.dayViewTimeCells1.HorizontalHeaders = this.horizontalDateHeaders1;
        this.dayViewTimeCells1.Location = new System.Drawing.Point(51, 200);
        this.dayViewTimeCells1.Name = "dayViewTimeCells1";
        this.dayViewTimeCells1.ShowWorkTimeOnly = true;
        this.dayViewTimeCells1.Size = new System.Drawing.Size(592, 692);
        this.dayViewTimeCells1.View = this.reportDayView1;
        // 
        // horizontalDateHeaders1
        // 
        this.horizontalDateHeaders1.HorizontalHeaders = this.horizontalResourceHeaders1;
        this.horizontalDateHeaders1.Location = new System.Drawing.Point(51, 175);
        this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
        this.horizontalDateHeaders1.Size = new System.Drawing.Size(592, 25);
        this.horizontalDateHeaders1.View = this.reportDayView1;
        // 
        // horizontalResourceHeaders1
        // 
        this.horizontalResourceHeaders1.Location = new System.Drawing.Point(51, 150);
        this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
        this.horizontalResourceHeaders1.Size = new System.Drawing.Size(592, 25);
        this.horizontalResourceHeaders1.View = this.reportDayView1;
        // 
        // reportDayView1
        // 
        this.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None;
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.calendarControl1,
            this.dayViewTimeCells1,
            this.horizontalDateHeaders1,
            this.dayViewTimeRuler1,
            this.horizontalResourceHeaders1,
            this.timeIntervalInfo1});
        this.Detail.Height = 899;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // dayViewTimeRuler1
        // 
        this.dayViewTimeRuler1.Corners.Top = 48;
        this.dayViewTimeRuler1.Location = new System.Drawing.Point(1, 150);
        this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
        this.dayViewTimeRuler1.Size = new System.Drawing.Size(50, 742);
        this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
        this.dayViewTimeRuler1.View = this.reportDayView1;
        // 
        // timeIntervalInfo1
        // 
        this.timeIntervalInfo1.Location = new System.Drawing.Point(17, 8);
        this.timeIntervalInfo1.Name = "timeIntervalInfo1";
        this.timeIntervalInfo1.Size = new System.Drawing.Size(242, 100);
        this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
        // 
        // XtraSchedulerReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
        this.Version = "9.2";
        this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
        ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

}
