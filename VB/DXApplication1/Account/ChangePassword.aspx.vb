Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security

Namespace DXApplication1
	Partial Public Class ChangePassword
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub btnChangePassword_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim user As MembershipUser = Membership.GetUser(Me.User.Identity.Name)
			If (Not Membership.ValidateUser(user.UserName, tbCurrentPassword.Text)) Then
				tbCurrentPassword.ErrorText = "Old Password is not valid"
				tbCurrentPassword.IsValid = False
			ElseIf (Not user.ChangePassword(tbCurrentPassword.Text, tbPassword.Text)) Then
				tbPassword.ErrorText = "Password is not valid"
				tbPassword.IsValid = False
			Else
				Response.Redirect("~/")
			End If
		End Sub
	End Class
End Namespace