Imports System.Data.SqlClient

Public Class frmEnrollment

    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowCmbStudent()
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
        Dim sda As New SqlDataAdapter("SELECT * FROM ENROLLMENT", con)
        Dim dta As New DataTable()
        sda.Fill(dta)

        DataGridView1.DataSource = dta
    End Sub

    Private Sub insertData()

        If formValidation() = False Then
            Exit Sub
        End If
        Dim id As Integer = txtId.Text
        Dim grade As Double = txtGrade.Text
        Dim section_id As Integer = txtSectionId.Text
        'Dim student_id As Integer = txtStudentId.Text
        Dim studentID As Integer = cmbStudentID.SelectedValue

        Dim query As String = "INSERT INTO ENROLLMENT (id, grade, SECTION_id, STUDENT_id) 
                                VALUES(@id, @grade, @SECTION_id, @studentID)"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@grade", grade)
                command.Parameters.AddWithValue("@section_id", section_id)
                command.Parameters.AddWithValue("@studentID", studentID)
                command.ExecuteNonQuery()
            End Using
        End Using
        ShowMessage("Record Added")
        displayTable()
        clearFields()
    End Sub

    Private Sub DeleteData()
        Dim id As Integer = txtId.Text
        Dim query As String = " DELETE FROM ENROLLMENT WHERE id = @id"

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using command As New SqlCommand(query, con)

                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                End Using
            End Using
            ShowMessage("Record Deleted")
            displayTable()
            clearFields()
        Catch ex As Exception
            MsgBox("Cannot delete this  because it is used in other section.")
        End Try

    End Sub

    Private Sub UpdateData()

        Dim id As Integer = txtId.Text
        Dim grade As Double = txtGrade.Text
        Dim section_id As Integer = txtSectionId.Text
        'Dim student_id As Integer = txtStudentId.Text
        Dim studentID As Integer = cmbStudentID.SelectedValue

        Dim query As String = "UPDATE ENROLLMENT SET grade = @grade, SECTION_id = @section_id, STUDENT_id = @studentID WHERE id = @id"


        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@grade", grade)
                command.Parameters.AddWithValue("@section_id", section_id)
                command.Parameters.AddWithValue("@studentID", studentID)
                command.ExecuteNonQuery()
            End Using
        End Using
        ShowMessage("Record Updated")
        displayTable()
        clearFields()

    End Sub


    Private Sub clearFields()
        txtId.Clear()
        txtGrade.Clear()
        txtSectionId.Clear()

    End Sub

    Private Sub ShowMessage(message As String)
        MsgBox(message)
    End Sub

    Private Sub ShowCmbStudent()

        Dim query As String =
        "SELECT id, (first_name + ' ' + last_name) AS full_name FROM STUDENT"

        Dim dt As New DataTable()

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        cmbStudentID.DataSource = dt
        cmbStudentID.DisplayMember = "full_name"
        cmbStudentID.ValueMember = "id"

    End Sub

    Private Sub ShowCmbSection()

        Dim query As String =
        "SELECT id, (first_name + ' ' + last_name) AS full_name FROM STUDENT"

        Dim dt As New DataTable()

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        cmbStudentID.DataSource = dt
        cmbStudentID.DisplayMember = "full_name"
        cmbStudentID.ValueMember = "id"

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtGrade.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtSectionId.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        cmbStudentID.SelectedValue = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Function formValidation() As Boolean

        If txtId.Text = "" Or txtGrade.Text = "" Or txtSectionId.Text = "" Or cmbStudentID.Text = "" Then

            MsgBox("Inputs can't be empty!")
            Return False
        End If

        Return True

    End Function
End Class