Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxClasses

Namespace DXApplication1
	Partial Public Class Root
		Inherits System.Web.UI.MasterPage
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			MainSplitter.GetPaneByName("HeaderPane").Size = If(ASPxWebControl.GlobalTheme = "Moderno", 101, 87)
		End Sub
	End Class
End Namespace