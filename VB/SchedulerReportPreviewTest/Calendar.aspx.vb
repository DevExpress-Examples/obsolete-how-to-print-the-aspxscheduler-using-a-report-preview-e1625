Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Namespace SchedulerReportPreviewTest
    Partial Public Class Calendar
        Inherits System.Web.UI.Page

        #Region "#calendarpageload"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Session("Loaded") IsNot Nothing Then
                PrepareReportPreview(PreviewPanel)
            End If
        End Sub
        #End Region ' #calendarpageload

        Private lastInsertedAppointmentId As Integer

        ' DXCOMMENT: This handler is called when a datasource insert operation has been completed
        Protected Sub SchedulingDataSource_Inserted(ByVal sender As Object, ByVal e As SqlDataSourceStatusEventArgs)
            ' DXCOMMENT: This method saves the last inserted appointment's unique identifier
            Dim connection As SqlConnection = CType(e.Command.Connection, SqlConnection)
            Using cmd As New SqlCommand("SELECT IDENT_CURRENT('Appointments')", connection)
                Me.lastInsertedAppointmentId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Sub

        ' DXCOMMENT: This handler is called before appointment data is posted to the datasource for insertion
        Protected Sub Scheduler_AppointmentRowInserting(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertingEventArgs)
            ' DXCOMMENT: This method removes the ID field from the row insert query
            e.NewValues.Remove("ID")
        End Sub

        ' DXCOMMENT: This handler is called after a new record that contains appointment information has been inserted into the datasource
        Protected Sub Scheduler_AppointmentRowInserted(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertedEventArgs)
            ' DXCOMMENT: This method sets the value of the key field for the appointment's data record
            e.KeyFieldValue = Me.lastInsertedAppointmentId
        End Sub

        ' DXCOMMENT: This handler is called after appointments are added to the collection
        Protected Sub Scheduler_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            ' DXCOMMENT: This method sets unique identifiers for new appointments
            DirectCast(sender, ASPxSchedulerStorage).SetAppointmentId(CType(e.Objects(0), Appointment), lastInsertedAppointmentId)
        End Sub
        #Region "#callbackpanel"
        Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
            If e.Parameter = "Show" Then
                PreviewPanel.Visible = True
                Session("Loaded") = True
                PrepareReportPreview(PreviewPanel)
            Else
                PreviewPanel.Visible = False
                Session.Remove("Loaded")
            End If
        End Sub
        #End Region ' #callbackpanel

        #Region "#preparereportpreview"
        Private Sub PrepareReportPreview(ByVal cp As Control)
            ASPxSchedulerControlPrintAdapter1.TimeInterval = Scheduler.ActiveView.GetVisibleIntervals().Interval
            ASPxSchedulerControlPrintAdapter1.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18))

            Dim reportPreview As Reports.ReportPreview = CType(Page.LoadControl("Reports/ReportPreview.ascx"), Reports.ReportPreview)
            reportPreview.ControlAdapter = ASPxSchedulerControlPrintAdapter1

            cp.Controls.Clear()
            cp.Controls.Add(reportPreview)
        End Sub
        #End Region ' #preparereportpreview
    End Class
End Namespace