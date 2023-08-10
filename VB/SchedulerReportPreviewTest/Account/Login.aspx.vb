Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security

Namespace SchedulerReportPreviewTest

    Public Partial Class Login
        Inherits Page

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
