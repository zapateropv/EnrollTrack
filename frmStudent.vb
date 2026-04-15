Imports System.Data.SqlClient
Public Class frmStudent
    Dim connectionString As String = "Server=VINCENT\SQLEXPRESS;DATABASE=EnrollmentDB;Trusted_Connection=True;"


    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    'QUERIES AND METHODS

    Private Sub displayTable()
        Dim con As New SqlConnection(connectionString)
        Dim sda As New SqlDataAdapter("SELECT * FROM STUDENT", con)
        Dim dta As New DataTable()
        sda.Fill(dta)

        DataGridView1.DataSource = dta
    End Sub

    Private Sub insertData()




        If formValidation() = False Then
            Exit Sub
        End If

        Dim studentId As Integer = txtId.Text
        Dim firstName As String = txtFirst.Text
        Dim lastName As String = txtLast.Text
        Dim gender As String = cmbGender.Text
        Dim birth_Date As String = bday.Value
            Dim email As String = txtEmail.Text

            Dim query As String = "INSERT INTO STUDENT (id, first_name, last_name, gender,birth_date, email) 
                               VALUES(@studentId, @firstName, @lastName, @gender, @birth_Date, @email)"


            Using con As New SqlConnection(connectionString)
                con.Open()
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@studentId", studentId)
                    command.Parameters.AddWithValue("@firstName", firstName)
                    command.Parameters.AddWithValue("@lastName", lastName)
                    command.Parameters.AddWithValue("@gender", gender)
                    command.Parameters.AddWithValue("@birth_Date", birth_Date)
                    command.Parameters.AddWithValue("@email", email)
                    command.ExecuteNonQuery()
                End Using
            End Using

            displayTable()
            clearFields()



    End Sub

    Private Sub DeleteData()
        Dim studentId As Integer = txtId.Text
        Dim query As String = "DELETE FROM STUDENT WHERE id = @studentId"

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@studentId", studentId)
                    command.ExecuteNonQuery()
                End Using
            End Using


            displayTable()
            clearFields()
        Catch ex As Exception
            MsgBox("Cannot delete this  because it is used in other section.")
        End Try



    End Sub

    Private Sub UpdateData()

        Dim studentId As Integer = txtId.Text
        Dim firstName As String = txtFirst.Text
        Dim lastName As String = txtLast.Text
        Dim gender As String = cmbGender.Text
        Dim birth_Date As String = bday.Value
        Dim email As String = txtEmail.Text
        Dim query As String = "UPDATE STUDENT SET first_name = @firstName, last_name = @lastName, gender = @gender,
                                birth_date = @birth_Date, email = @email WHERE id = @studentId"



        Using con As New SqlConnection(connectionString)
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@gender", gender)
                command.Parameters.AddWithValue("@birth_Date", birth_Date)
                command.Parameters.AddWithValue("@email", email)

                command.ExecuteNonQuery()
            End Using
        End Using



        displayTable()
        clearFields()

    End Sub


    Private Sub clearFields()
        txtId.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        cmbGender.SelectedIndex = -1
        bday.Value = DateTime.Now
        txtEmail.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtFirst.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtLast.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        cmbGender.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        bday.Value = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Function formValidation() As Boolean

        If txtId.Text = "" Or txtFirst.Text = "" Or txtLast.Text = "" Or cmbGender.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Inputs can't be empty!")
            Return False
        End If

        Return True

    End Function


End Class