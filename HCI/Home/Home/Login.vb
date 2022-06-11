
Public Class login
    Dim usern = "amdin"
    Dim pass = "amdin123"
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        If username.Text = Nothing And password.Text = Nothing Then
            MsgBox("Pless Enter User name And Password", MsgBoxStyle.Exclamation)
        ElseIf username.Text = "admin" And password.Text = "admin123" Then
            MsgBox("Welcom To The Blood Bank System Mr.Admin ", MsgBoxStyle.Information)
            Me.Hide()
            Donors.Show()
        ElseIf username.Text = "" Or password.Text = "" Then
            MsgBox("Plesss Enter Valid information", MsgBoxStyle.Exclamation)
        ElseIf username.Text = "admin" And password.Text = "" Then
            MsgBox("Plesss Enter Valid Password", MsgBoxStyle.Exclamation)
        ElseIf username.Text = "" And password.Text = "admin123" Then
            MsgBox("Plesss Enter Valid User", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class