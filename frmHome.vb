Imports System.Data.SqlClient

Public Class frmHome
    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM STUDENT", con)
        Dim cmd1 As New SqlCommand("SELECT COUNT(*) FROM COURSE", con)
        Dim cmd2 As New SqlCommand("SELECT COUNT(*) FROM INSTRUCTOR", con)

        con.Open()
        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Dim result2 As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
        Dim result3 As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
        con.Close()

        Label2.Text = "TOTAL STUDENTS: " & result.ToString()
        Label3.Text = "TOTAL COURSE: " & result2.ToString()
        Label4.Text = "TOTAL INSTRUCTOR: " & result3.ToString()

    End Sub


End Class