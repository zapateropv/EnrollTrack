Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class frmSection

    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"
    Private Sub frmSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        displayTable()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        insertData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub
    'QUERIES AND METHODS

    Private Sub displayTable()
        Dim con As New SqlConnection(connectionString)
        Dim sda As New SqlDataAdapter("SELECT * FROM SECTION", con)
        Dim dta As New DataTable()
        sda.Fill(dta)

        DataGridView1.DataSource = dta
    End Sub

    Private Sub insertData()


        If formValidation() = False Then
            Exit Sub
        End If


        Dim id As Integer = txtId.Text
        Dim day As String = cmbDay.Text
        Dim start_Time As String = timeStart.Text
        Dim end_Time As String = timeEnd.Text
        Dim semester As Integer = cmbSem.Text
        Dim room As String = txtRoom.Text
        Dim course_id As Integer = txtCourseId.Text
        Dim instructor_id As String = txtInstructorId.Text


        Dim query As String = "INSERT INTO SECTION (id, day_of_week, start_time, end_time, semester, room, COURSE_id, INSTRUCTOR_id) 
                                VALUES(@id, @day, @start_Time, @end_Time, @semester, @room, @course_id, @instructor_id)"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@day", day)
                command.Parameters.AddWithValue("@start_Time", start_Time)
                command.Parameters.AddWithValue("@end_Time", end_Time)
                command.Parameters.AddWithValue("@semester", semester)
                command.Parameters.AddWithValue("@room", room)
                command.Parameters.AddWithValue("@course_id", course_id)
                command.Parameters.AddWithValue("@instructor_id", instructor_id)
                command.ExecuteNonQuery()
            End Using
        End Using

        displayTable()
        clearFields()
    End Sub

    Private Sub DeleteData()
        Dim id As Integer = txtId.Text
        Dim query As String = " DELETE FROM SECTION WHERE id = @id"

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using command As New SqlCommand(query, con)

                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                End Using
            End Using

            displayTable()
            clearFields()
        Catch ex As Exception
            MsgBox("Cannot delete this because it is used in other section.")
        End Try


    End Sub

    Private Sub UpdateData()
        Dim id As Integer = txtId.Text
        Dim day As String = cmbDay.Text
        Dim start_Time As String = timeStart.Text
        Dim end_Time As String = timeEnd.Text
        Dim semester As Integer = cmbSem.Text
        Dim room As String = txtRoom.Text
        Dim course_id As Integer = txtCourseId.Text
        Dim instructor_id As String = txtInstructorId.Text

        Dim query As String = "UPDATE SECTION SET day_of_week = @day, start_time = @start_Time, end_time = @end_Time, semester = @semester
                                ,room = @room, COURSE_id = @course_id, INSTRUCTOR_id = @instructor_id WHERE id = @id"


        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@day", day)
                command.Parameters.AddWithValue("@start_Time", start_Time)
                command.Parameters.AddWithValue("@end_Time", end_Time)
                command.Parameters.AddWithValue("@semester", semester)
                command.Parameters.AddWithValue("@room", room)
                command.Parameters.AddWithValue("@course_id", course_id)
                command.Parameters.AddWithValue("@instructor_id", instructor_id)
                command.ExecuteNonQuery()
            End Using
        End Using

        displayTable()
        clearFields()


    End Sub


    Private Sub clearFields()
        txtId.Clear()
        cmbDay.SelectedIndex = -1
        timeStart.Value = DateTime.Now
        timeEnd.Value = DateTime.Now
        cmbSem.SelectedIndex = -1
        txtRoom.Clear()
        txtCourseId.Clear()
        txtInstructorId.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        cmbDay.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        timeStart.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        timeEnd.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        cmbSem.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtRoom.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtCourseId.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtInstructorId.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
    End Sub

    Private Function formValidation() As Boolean

        If txtId.Text = "" Or txtId.Text = "" Or cmbDay.Text = "" Or timeStart.Text = "" Or timeEnd.Text = "" Or cmbSem.Text = "" Or txtRoom.Text = "" Or txtCourseId.Text = "" Or txtInstructorId.Text = "" Then

            MsgBox("Inputs can't be empty!")
            Return False
        End If

        Return True

    End Function

End Class