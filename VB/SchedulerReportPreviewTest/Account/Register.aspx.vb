Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security

Namespace SchedulerReportPreviewTest

    Public Partial Class Register
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub btnCreateUser_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim user As MembershipUser = Membership.CreateUser(tbUserName.Text, tbPassword.Text, tbEmail.Text)
                Response.Redirect(If(Request.QueryString("ReturnUrl"), "~/Account/RegisterSuccess.aspx"))
            Catch exc As MembershipCreateUserException
                If exc.StatusCode = MembershipCreateStatus.DuplicateEmail OrElse exc.StatusCode = MembershipCreateStatus.InvalidEmail Then
                    tbEmail.ErrorText = exc.Message
                    tbEmail.IsValid = False
                ElseIf exc.StatusCode = MembershipCreateStatus.InvalidPassword Then
                    tbPassword.ErrorText = exc.Message
                    tbPassword.IsValid = False
                Else
                    tbUserName.ErrorText = exc.Message
                    tbUserName.IsValid = False
                End If

            End Try
        End Sub
    End Class
End Namespace
