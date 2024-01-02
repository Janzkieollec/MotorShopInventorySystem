Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=motorshop_db;")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM login WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim username As String = reader("username").ToString()
                MessageBox.Show("Login Successful!")

                Dim home As New home(username)
                home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username and password.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
