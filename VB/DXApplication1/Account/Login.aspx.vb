Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security

Namespace DXApplication1
	Partial Public Class Login
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Membership.ValidateUser(tbUserName.Text, tbPassword.Text) Then
				If String.IsNullOrEmpty(Request.QueryString("ReturnUrl")) Then
					FormsAuthentication.SetAuthCookie(tbUserName.Text, False)
					Response.Redirect("~/")
				Else
					FormsAuthentication.RedirectFromLoginPage(tbUserName.Text, False)
				End If
			Else
				tbUserName.ErrorText = "Invalid user"
				tbUserName.IsValid = False
			End If
		End Sub
	End Class
End Namespace