Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class home
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Dim loggedInUser As String

    Public Sub New(ByVal users As String)
        InitializeComponent()
        loggedInUser = users ' Save the username for later use

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT position, name FROM login WHERE username = @Username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", users)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim userTypeName As String = reader("position").ToString()
                    Dim userName As String = reader("name").ToString()

                    If String.Compare(userTypeName, "Admin", StringComparison.OrdinalIgnoreCase) <> 0 Then
                        btnInventory.Visible = False
                        btnAccount.Visible = False
                        btnStock.Visible = False
                        btnProfile.Visible = True
                        btnUserDashboad.Visible = True
                    End If

                    ' Concatenate the role and name
                    txtName.Text = $"{userTypeName}: {userName}"
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


    Sub childForm(ByVal panel As Form)
        mainPanel.Controls.Clear()

        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        mainPanel.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.BringToFront()
        panel.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropdown.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        childForm(dashboard)

        If TypeOf mainPanel.Controls(0) Is dashboard Then
            DirectCast(mainPanel.Controls(0), dashboard).LoadDataIntoDataGridView()
            DirectCast(mainPanel.Controls(0), dashboard).totalProductss()
            DirectCast(mainPanel.Controls(0), dashboard).totalStockss()

        End If
        dropdown.Visible = False

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        childForm(products)


        If TypeOf mainPanel.Controls(0) Is products Then
            DirectCast(mainPanel.Controls(0), products).refresh()
        End If

        dropdown.Visible = False

    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        childForm(stock)

        If TypeOf mainPanel.Controls(0) Is stock Then
            DirectCast(mainPanel.Controls(0), stock).RefreshData()
        End If

        dropdown.Visible = False

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        childForm(InventoryReport)

        dropdown.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If dropdown.Visible = False Then
            dropdown.Visible = True
        Else
            dropdown.Visible = False
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()

        ' Show a new instance of the login form
        Dim loginForm As New Form1
        loginForm.ShowDialog()

        ' Dispose of resources after the login form is closed
        loginForm.Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newHome As New home(loggedInUser)
        newHome.Show()
        Me.Hide()
    End Sub


    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        childForm(accountList)
        dropdown.Visible = False
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim userProfileForm As New Profile(loggedInUser)
                ' Show the Profile form
                userProfileForm.Location = New Point((Screen.GetWorkingArea(Me).Width - userProfileForm.Width) / 2, 0)
                tranparent.ShowForm(userProfileForm)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub btnUserDashboad_Click(sender As Object, e As EventArgs) Handles btnUserDashboad.Click
        childForm(userDashboard)

        If TypeOf mainPanel.Controls(0) Is userDashboard Then
            DirectCast(mainPanel.Controls(0), userDashboard).LoadDataIntoDataGridView()
            DirectCast(mainPanel.Controls(0), userDashboard).totalProductss()

        End If
        dropdown.Visible = False

    End Sub
End Class