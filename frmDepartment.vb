Imports System.Data.SqlClient

Public Class frmDepartment

    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"

    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTable()
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub
    'QUERIES AND METHODS

    Private Sub displayTable()
        Dim con As New SqlConnection(connectionString)
        Dim sda As New SqlDataAdapter("SELECT * FROM DEPARTMENT", con)
        Dim dta As New DataTable()
        sda.Fill(dta)

        DataGridView1.DataSource = dta
    End Sub

    Private Sub insertData()

        If formValidation() = False Then
            Exit Sub
        End If
        Dim id As Integer = txtId.Text
        Dim name As String = txtName.Text
        Dim description As String = txtDescription.Text
        Dim query = "INSERT INTO DEPARTMENT(id, name, description) VALUES(@id, @name, @description)"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@name", name)

                command.ExecuteNonQuery()
            End Using
        End Using
        ShowMessage("Record Added! ")
        displayTable()
        clearFields()
    End Sub

    Private Sub DeleteData()
        Dim departmentId As Integer = txtId.Text

        Dim query As String = "DELETE FROM DEPARTMENT WHERE id = @departmentId"

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@departmentId", departmentId)
                    command.ExecuteNonQuery()
                End Using
            End Using
            ShowMessage("Record Deleted! ")
            displayTable()
            clearFields()
        Catch ex As Exception
            MsgBox("Cannot delete this  because it is used in other section.")
        End Try


    End Sub

    Private Sub UpdateData()
        Dim departmentId As Integer = txtId.Text
        Dim departmentName As String = txtName.Text
        Dim departmentDescription As String = txtDescription.Text
        Dim query As String = "UPDATE DEPARTMENT SET name = @departmentName, description = @departmentDescription WHERE id = @departmentId"


        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@departmentName", departmentName)
                command.Parameters.AddWithValue("@departmentDescription", departmentDescription)
                command.Parameters.AddWithValue("@departmentId", departmentId)
                command.ExecuteNonQuery()
            End Using
        End Using
        ShowMessage("Record Updated! ")
        displayTable()
        clearFields()
    End Sub


    Private Sub clearFields()
        txtId.Clear()
        txtName.Clear()
        txtDescription.Clear()
    End Sub

    Private Sub ShowMessage(message As String)
        MsgBox(message)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()

    End Sub

    Private Function formValidation() As Boolean

        If txtId.Text = "" Or txtName.Text = "" Or txtDescription.Text = "" Then

            MsgBox("Inputs can't be empty!")
            Return False
        End If

        Return True

    End Function


End Class