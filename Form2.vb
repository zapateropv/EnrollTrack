Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Form2


    Sub toggleForm(ByVal panel As Form)

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        toggleForm(New frmStudent())
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        toggleForm(New frmDepartment())
    End Sub


    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        toggleForm(New frmInstructor())
    End Sub

    Private Sub bnCourse_Click(sender As Object, e As EventArgs) Handles bnCourse.Click
        toggleForm(New frmCourse())
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        toggleForm(New frmSection())
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        toggleForm(New frmEnrollment())
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toggleForm(New frmHome())
    End Sub



    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        toggleForm(New frmHome())
    End Sub


End Class