
Partial Class members_offeralert
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cf As New comonfunctions
        Dim sql As String = ""
        Dim kk As String = ""
        sql = "update profile set newoffers='N' where pid=" & Session("pid") & ""

        kk = cf.update(sql)

        If kk = "True" Then
            Label1.Text = "Offer Emails are Stopped, you can also alter your privacy settings"
        Else
            Label1.Text = "Error has occured, kindly use privacy settings to disable/enable emails"
        End If

    End Sub
End Class
