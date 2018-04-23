using System;

public class XtraSchedulerReport1 : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
    private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;
    private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
    private DevExpress.XtraReports.UI.DetailBand Detail;

    public XtraSchedulerReport1() {
        InitializeComponent();
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
            this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.dayViewTimeRuler1,
            this.horizontalDateHeaders1,
            this.horizontalResourceHeaders1,
            this.dayViewTimeCells1});
            this.Detail.HeightF = 985.3334F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // calendarControl1
            // 
            this.calendarControl1.LocationFloat = new DevExpress.Utils.PointFloat(300F, 0F);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.SizeF = new System.Drawing.SizeF(301.0416F, 166.6667F);
            this.calendarControl1.TimeCells = this.dayViewTimeCells1;
            this.calendarControl1.View = this.reportDayView1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.HorizontalHeaders = this.horizontalResourceHeaders1;
            this.dayViewTimeCells1.LocationFloat = new DevExpress.Utils.PointFloat(51.0416F, 218.6667F);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.ShowWorkTimeOnly = true;
            this.dayViewTimeCells1.SizeF = new System.Drawing.SizeF(550F, 679.8611F);
            this.dayViewTimeCells1.View = this.reportDayView1;
            this.dayViewTimeCells1.VisibleTimeSnapMode = false;
            // 
            // horizontalResourceHeaders1
            // 
            this.horizontalResourceHeaders1.HorizontalHeaders = this.horizontalDateHeaders1;
            this.horizontalResourceHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(51.0416F, 192.6667F);
            this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
            this.horizontalResourceHeaders1.SizeF = new System.Drawing.SizeF(550F, 26F);
            this.horizontalResourceHeaders1.View = this.reportDayView1;
            // 
            // horizontalDateHeaders1
            // 
            this.horizontalDateHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(51.0416F, 166.6667F);
            this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
            this.horizontalDateHeaders1.SizeF = new System.Drawing.SizeF(550F, 26F);
            this.horizontalDateHeaders1.View = this.reportDayView1;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(300F, 166.6667F);
            this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.Corners.Top = 52;
            this.dayViewTimeRuler1.LocationFloat = new DevExpress.Utils.PointFloat(1.041603F, 166.6667F);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.SizeF = new System.Drawing.SizeF(50F, 731.8611F);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // XtraSchedulerReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "15.2";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
