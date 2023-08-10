Imports System
Imports DevExpress.Web

Namespace SchedulerReportPreviewTest

    Public Partial Class Root
        Inherits Web.UI.MasterPage

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            MainSplitter.GetPaneByName("HeaderPane").Size = If(Equals(ASPxWebControl.GlobalTheme, "Moderno"), 101, 87)
            MainSplitter.GetPaneByName("HeaderPane").MinSize = If(Equals(ASPxWebControl.GlobalTheme, "Moderno"), 101, 87)
        End Sub
    End Class
End Namespace
