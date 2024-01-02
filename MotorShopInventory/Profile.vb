Imports MySql.Data.MySqlClient

Public Class Profile
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Dim loggedInUser As String

    ' Add a constructor to accept the loggedInUser parameter
    Public Sub New(loggedInUser As String)
        InitializeComponent()

        Me.loggedInUser = loggedInUser

        LoadProfile(loggedInUser)
    End Sub

    ' Function to load the profile based on the logged-in user
    Private Sub LoadProfile(loggedInUser As String)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM login WHERE username = @Username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", loggedInUser)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Populate data in the Profile form based on the reader
                    txtUsername.Text = reader("username").ToString()
                    txtName.Text = reader("name").ToString()
                    txtPosition.Text = reader("position").ToString()

                    ' Add more fields as needed
                Else
                    MessageBox.Show("User not found in the database.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update data in the database
                Dim updateQuery As String = "UPDATE motorshop_db.login SET name = @name, position = @position, password = @password WHERE username = @username"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@username", loggedInUser)

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
