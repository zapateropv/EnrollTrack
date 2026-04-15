Imports System.Data.SqlClient

Public Class frmCourse
    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"
    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnrollmentDBDataSet.DEPARTMENT' table. You can move, or remove it, as needed.
        Me.DEPARTMENTTableAdapter.Fill(Me.EnrollmentDBDataSet.DEPARTMENT)

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
        Dim sda As New SqlDataAdapter("SELECT * FROM COURSE", con)
        Dim dta As New DataTable()
        sda.Fill(dta)

        DataGridView1.DataSource = dta
    End Sub

    Private Sub insertData()

        
        If formValidation() = False Then
            Exit Sub
        End If

        Dim id As Integer = txtId.Text
        Dim code As String = txtCode.Text
        Dim name As String = txtName.Text
        Dim units As Integer = txtUnits.Text
        Dim departmentId As Integer = txtDepartmentId.Text


        Dim query As String = "INSERT INTO COURSE (id, code, name, units, DEPARTMENT_id) 
                                VALUES(@id, @code, @name, @units, @departmentId)"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@code", code)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@units", units)
                command.Parameters.AddWithValue("@departmentId", departmentId)
                command.ExecuteNonQuery()
            End Using
        End Using

        displayTable()
        clearFields()
    End Sub

    Private Sub DeleteData()
        Dim id As Integer = txtId.Text
        Dim query As String = " DELETE FROM COURSE WHERE id = @id"


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
        Dim code As String = txtCode.Text
        Dim name As String = txtName.Text
        Dim units As Integer = txtUnits.Text
        Dim departmentId As Integer = txtDepartmentId.Text

        Dim query As String = "UPDATE COURSE SET code = @code, name = @name, units= @units, DEPARTMENT_id = @departmentId
                                WHERE id = @id"


        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@code", code)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@units", units)
                command.Parameters.AddWithValue("@departmentId", departmentId)
                command.ExecuteNonQuery()
            End Using
        End Using

        displayTable()
        clearFields()

    End Sub


    Private Sub clearFields()
        txtId.Clear()
        txtCode.Clear()
        txtName.Clear()
        txtUnits.Clear()
        txtDepartmentId.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtCode.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtUnits.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtDepartmentId.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Function formValidation() As Boolean

        If txtId.Text = "" Or txtCode.Text = "" Or txtName.Text = "" Or txtUnits.Text = "" Or txtDepartmentId.Text = "" Then

            MsgBox("Inputs can't be empty!")
            Return False
        End If

        Return True

    End Function

End Class