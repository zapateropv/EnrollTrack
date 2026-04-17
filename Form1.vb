Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If (username.Equals("Admin") And password.Equals("1234")) Then
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub


End Class
