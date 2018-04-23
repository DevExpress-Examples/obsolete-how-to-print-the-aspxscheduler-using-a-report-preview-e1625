<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ReportPreview.ascx.vb" Inherits="SchedulerReportPreviewTest.Reports.ReportPreview" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.2.Web, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" ClientInstanceName="clientReportViewer">
        <ToolbarItems>
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="PrintReport" />
            <dx:ReportToolbarButton ItemKind="PrintPage" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
            <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
            <dx:ReportToolbarLabel ItemKind="PageLabel" />
            <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind="OfLabel" />
            <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
            <dx:ReportToolbarButton ItemKind="NextPage" />
            <dx:ReportToolbarButton ItemKind="LastPage" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="SaveToDisk" />
            <dx:ReportToolbarButton ItemKind="SaveToWindow" />
            <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                <Elements>
                    <dx:ListElement Value="pdf" />
                    <dx:ListElement Value="xls" />
                    <dx:ListElement Value="xlsx" />
                    <dx:ListElement Value="rtf" />
                    <dx:ListElement Value="mht" />
                    <dx:ListElement Value="html" />
                    <dx:ListElement Value="txt" />
                    <dx:ListElement Value="csv" />
                    <dx:ListElement Value="png" />
                </Elements>
            </dx:ReportToolbarComboBox>
        </ToolbarItems>
        <ClientSideEvents PageLoad= "function(s, e) {
            scheduler.HideLoadingPanel();
            ASPxPopupControl1.Show();
        }" />
</dx:ASPxDocumentViewer>