Imports MySql.Data.MySqlClient

Public Class accountList
    Private Sub accountList_Load(sender As Object, e As EventArgs)
        accountDatagridView(accountSearch.Text)
    End Sub

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub accountDatagridView(searchText As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT id, row_number() over() as IDs, name, username, position FROM motorshop_db.login
                                  WHERE CONCAT(id,' ', name,' ', username,' ', position) LIKE @searchText AND position <> 'Admin'"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    accountDatgrid.DataSource = dataTable

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub accountSearch_TextChanged(sender As Object, e As EventArgs) Handles accountSearch.TextChanged
        accountDatagridView(accountSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddItem As New AddUser
        frmAddItem.Location = New Point((WorkingArea.Width - frmAddItem.Width) / 2, 0)
        tranparent.ShowForm(frmAddItem)

        'Refresh the Product datagrid
        accountDatagridView(accountSearch.Text)
    End Sub

    Private Function GetSelectedUserId() As Integer
        If accountDatgrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = accountDatgrid.SelectedRows(0)
            Dim accountId As Integer = Convert.ToInt32(selectedRow.Cells("userId").Value)
            Return accountId
        Else
            MessageBox.Show("No user selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -1 ' Return -1 if no row is selected
        End If
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim accountId As Integer = GetSelectedUserId()

        If accountId <> -1 Then ' Check if a row is selected
            Dim frmUpdateUser As New UpdateUser(accountId)
            frmUpdateUser.Location = New Point((Screen.GetWorkingArea(Me).Width - frmUpdateUser.Width) / 2, 0)
            tranparent.ShowForm(frmUpdateUser)

            ' Refresh the Account datagrid
            accountDatagridView(accountSearch.Text)
        Else
            MessageBox.Show("Please select a user to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
