<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ReportPreview.ascx.vb" Inherits="DXApplication1.Reports.ReportPreview" %>
<%@ Register assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" ClientInstanceName="clientReportViewer">
	<ClientSideEvents PageLoad= "function(s, e) {
			scheduler.HideLoadingPanel();
			ASPxPopupControl1.Show();
		}" />
</dx:ASPxDocumentViewer>