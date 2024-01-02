Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=motorshop_db;")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()

            ' Check if the product already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM motorshop_db.login WHERE name = @value1"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@value1", txtName.Text)

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingCount > 0 Then
                MessageBox.Show("User account already exists.")
                Return
            End If

            ' If the patient does not exist, proceed with the insertion
            Dim query As String = "INSERT INTO motorshop_db.login (name, username, position, password) VALUES (@value1, @value2, @value3, @value4)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@value1", txtName.Text)
            cmd.Parameters.AddWithValue("@value2", txtUsername.Text)
            cmd.Parameters.AddWithValue("@value3", txtPosition.Text)
            cmd.Parameters.AddWithValue("@value4", txtPassword.Text)

            Dim rowAffected As Integer = cmd.ExecuteNonQuery()

            If rowAffected > 0 Then
                MessageBox.Show("Account successfully created!")
                Dim login As New Form1
                login.Show()
                Me.Hide()
            Else
                MessageBox.Show("Data insertion failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class