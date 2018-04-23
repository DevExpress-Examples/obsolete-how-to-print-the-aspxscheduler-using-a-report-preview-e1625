using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

namespace DXApplication1 {
    public partial class Calendar : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            PrepareReportPreview(PreviewPanel);
        }
		
		int lastInsertedAppointmentId;
		
		// DXCOMMENT: This handler is called when a datasource insert operation has been completed
		protected void SchedulingDataSource_Inserted(object sender, SqlDataSourceStatusEventArgs e) {
			// DXCOMMENT: This method saves the last inserted appointment's unique identifier
	        SqlConnection connection = (SqlConnection)e.Command.Connection;
	        using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('Appointments')", connection)) {
	            this.lastInsertedAppointmentId = Convert.ToInt32(cmd.ExecuteScalar());
	        }
	    }
		
		// DXCOMMENT: This handler is called before appointment data is posted to the datasource for insertion
	    protected void Scheduler_AppointmentRowInserting(object sender, ASPxSchedulerDataInsertingEventArgs e) {
			// DXCOMMENT: This method removes the ID field from the row insert query
	        e.NewValues.Remove("ID");
	    }
		
		// DXCOMMENT: This handler is called after a new record that contains appointment information has been inserted into the datasource
	    protected void Scheduler_AppointmentRowInserted(object sender, ASPxSchedulerDataInsertedEventArgs e) {
			// DXCOMMENT: This method sets the value of the key field for the appointment's data record
	        e.KeyFieldValue = this.lastInsertedAppointmentId;
	    }
		
		// DXCOMMENT: This handler is called after appointments are added to the collection
	    protected void Scheduler_AppointmentsInserted(object sender, PersistentObjectsEventArgs e) {
			// DXCOMMENT: This method sets unique identifiers for new appointments
	        ((ASPxSchedulerStorage)sender).SetAppointmentId((Appointment)e.Objects[0], lastInsertedAppointmentId);
	    }

        #region #callbackpanel
        protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            PreviewPanel.Visible = true;
        }
        #endregion #callbackpanel

        #region #preparereportpreview
        void PrepareReportPreview(Control cp)
        {
            ASPxSchedulerControlPrintAdapter1.TimeInterval =
                Scheduler.ActiveView.GetVisibleIntervals().Interval;
            ASPxSchedulerControlPrintAdapter1.WorkTime =
                new TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18));

            DXApplication1.Reports.ReportPreview reportPreview = 
                (DXApplication1.Reports.ReportPreview)Page.LoadControl("Reports/ReportPreview.ascx");
            reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1;

            cp.Controls.Clear();
            cp.Controls.Add(reportPreview);
        }
        #endregion #preparereportpreview
    }
}