Imports MySql.Data.MySqlClient

Public Class UpdateUser
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private ReadOnly accountId As Integer

    Public Sub New(accountId As Integer)
        InitializeComponent()
        Me.accountId = accountId
    End Sub

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user information based on the accountId
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch data for the selected account
                Dim selectQuery As String = "SELECT id, name, username, position FROM motorshop_db.login WHERE id = @accountId"
                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@accountId", accountId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Set the values to the form controls
                            txtName.Text = reader("name").ToString()
                            txtUsername.Text = reader("username").ToString()
                            txtPosition.Text = reader("position").ToString()
                        Else
                            MessageBox.Show("Account not found.")
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save the updated user information
        UpdateUserData()
    End Sub

    Private Sub UpdateUserData()

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update data in the database
                Dim updateQuery As String = "UPDATE motorshop_db.login SET name = @name, username = @username, position = @position, password = @password WHERE id = @accountId"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@accountId", accountId)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("User information updated successfully.")
                    Me.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating user data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
