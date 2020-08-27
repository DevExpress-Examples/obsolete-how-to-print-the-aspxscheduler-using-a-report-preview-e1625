<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Calendar.aspx.vb" Inherits="SchedulerReportPreviewTest.Calendar" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler.Controls" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler.Reporting" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraScheduler.v15.2.Core, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraScheduler" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Left" runat="server">
    <div class="navcontainer">
        <%-- DXCOMMENT: Configure DateNavigator for Scheduler --%>
        <dx:ASPxDateNavigator runat="server" ID="DateNavigator" MasterControlID="Scheduler" CssClass="datenavigator">
            <Properties Rows="2" DayNameFormat="FirstLetter">
                <Style Border-BorderWidth="0"></Style>
            </Properties>
        </dx:ASPxDateNavigator>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%-- DXCOMMENT: Configure ASPxScheduler control --%>
    <dx:ASPxScheduler runat="server" ID="Scheduler" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="ResourceDataSource"
        ActiveViewType="WorkWeek" Start="2011-04-06" Width="100%"
        OnAppointmentRowInserting="Scheduler_AppointmentRowInserting" OnAppointmentRowInserted="Scheduler_AppointmentRowInserted" OnAppointmentsInserted="Scheduler_AppointmentsInserted" ClientInstanceName="scheduler">
        <Views>
            <DayView>
                <VisibleTime Start="8:00" End="20:00" />
            </DayView>
            <WorkWeekView>
                <VisibleTime Start="8:00" End="20:00" />
            </WorkWeekView>
            <WeekView Enabled="False" />
            <MonthView CompressWeekend="False" />
            <TimelineView Enabled="False" />
        </Views>
        <Storage EnableReminders="False">
            <Appointments>
                <%-- DXCOMMENT: Configure appointment mappings --%>
                <Mappings AppointmentId="ID" Type="EventType" Start="StartDate" End="EndDate" AllDay="AllDay"
                    Subject="Subject" Location="Location" Description="Description" Status="Status"
                    Label="Label" ResourceId="ResourceID" RecurrenceInfo="RecurrenceInfo" />
            </Appointments>
            <Resources>
                <%-- DXCOMMENT: Configure resource mappings --%>
                <Mappings ResourceId="ID" Caption="Name" />
            </Resources>
        </Storage>
        <OptionsBehavior RecurrentAppointmentEditAction="Ask" />
        <BorderLeft BorderWidth="0" />
    </dx:ASPxScheduler>

    <%-- DXCOMMENT: Configure appointment mappings --%>
    <asp:SqlDataSource ID="AppointmentDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DataConnectionString %>"
        DeleteCommand="DELETE FROM [Appointments] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Appointments] ([EventType], [StartDate], [EndDate], [AllDay], [Subject], [Location], [Description], [Status], [Label], [ResourceID], [RecurrenceInfo], [ReminderInfo], [ContactInfo]) VALUES (@EventType, @StartDate, @EndDate, @AllDay, @Subject, @Location, @Description, @Status, @Label, @ResourceID, @RecurrenceInfo, @ReminderInfo, @ContactInfo)"
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Appointments]"
        UpdateCommand="UPDATE [Appointments] SET [EventType] = @EventType, [StartDate] = @StartDate, [EndDate] = @EndDate, [AllDay] = @AllDay, [Subject] = @Subject, [Location] = @Location, [Description] = @Description, [Status] = @Status, [Label] = @Label, [ResourceID] = @ResourceID, [RecurrenceInfo] = @RecurrenceInfo, [ReminderInfo] = @ReminderInfo, [ContactInfo] = @ContactInfo WHERE [ID] = @ID"
        OnInserted="SchedulingDataSource_Inserted">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="EventType" Type="Int32" />
            <asp:Parameter Name="StartDate" Type="DateTime" />
            <asp:Parameter Name="EndDate" Type="DateTime" />
            <asp:Parameter Name="AllDay" Type="Boolean" />
            <asp:Parameter Name="Subject" Type="String" />
            <asp:Parameter Name="Location" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Status" Type="Int32" />
            <asp:Parameter Name="Label" Type="Int32" />
            <asp:Parameter Name="ResourceID" Type="Int32" />
            <asp:Parameter Name="RecurrenceInfo" Type="String" />
            <asp:Parameter Name="ReminderInfo" Type="String" />
            <asp:Parameter Name="ContactInfo" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="EventType" Type="Int32" />
            <asp:Parameter Name="StartDate" Type="DateTime" />
            <asp:Parameter Name="EndDate" Type="DateTime" />
            <asp:Parameter Name="AllDay" Type="Boolean" />
            <asp:Parameter Name="Subject" Type="String" />
            <asp:Parameter Name="Location" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Status" Type="Int32" />
            <asp:Parameter Name="Label" Type="Int32" />
            <asp:Parameter Name="ResourceID" Type="Int32" />
            <asp:Parameter Name="RecurrenceInfo" Type="String" />
            <asp:Parameter Name="ReminderInfo" Type="String" />
            <asp:Parameter Name="ContactInfo" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


    <%-- DXCOMMENT: Configure resource mappings --%>
    <asp:SqlDataSource ID="ResourceDataSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DataConnectionString %>" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Resources]">
    </asp:SqlDataSource>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="ASPxPopupControl1" HeaderText="Print Preview" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="680px" Height="600px"
        ScrollBars="Auto" >
        <ContentCollection>
<dx:PopupControlContentControl runat="server">
    <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" ClientInstanceName="ASPxCallbackPanel1" OnCallback="ASPxCallbackPanel1_Callback" >
        <PanelCollection>
            <dx:PanelContent runat="server">
                <asp:Panel ID="PreviewPanel" runat="server" Visible="False">
                </asp:Panel>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
            </dx:PopupControlContentControl>
</ContentCollection>
    </dx:ASPxPopupControl>
        <dx:ASPxSchedulerControlPrintAdapter ID="ASPxSchedulerControlPrintAdapter1" runat="server" ClientIDMode="AutoID" SchedulerControlID="Scheduler">
    </dx:ASPxSchedulerControlPrintAdapter>
</asp:Content>