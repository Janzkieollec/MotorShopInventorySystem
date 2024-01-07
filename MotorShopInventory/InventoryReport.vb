Imports MySql.Data.MySqlClient

Public Class InventoryReport
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub cmbSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelect.SelectedIndexChanged
        If cmbSelect.SelectedItem IsNot Nothing Then
            ' Get the selected service
            Dim selectedService As String = cmbSelect.SelectedItem.ToString()

            ' Get the search keyword from the search box
            Dim searchKeyword As String = invetorySearch.Text.Trim()

            ' Perform actions based on the selected service
            Select Case selectedService
                Case "Products"
                    getProducts(searchKeyword)
                Case "Stocks Record"
                    getStocks(searchKeyword)
            End Select
        End If
    End Sub


    Private Sub getProducts(searchText As String)
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT id AS ID, brand_name AS 'Brand Name', description AS Desctiption, unit AS Unit, date AS Date, product_name AS 'Product Name', quantity AS Quantity FROM motorshop_db.products p " &
                                    "WHERE CONCAT(id,' ',quantity) LIKE @searchText"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    inventoryDatagrid.DataSource = dataTable

                    ' Remove the "ViewStockColumn" if it exists
                    If inventoryDatagrid.Columns.Contains("ViewStockColumn") Then
                        inventoryDatagrid.Columns.Remove("ViewStockColumn")
                    End If

                    ' Add a button column for ViewProduct
                    Dim viewProductButton As New DataGridViewButtonColumn()
                    viewProductButton.Name = "ViewProductColumn" ' Set the column name
                    viewProductButton.Text = "View"
                    viewProductButton.UseColumnTextForButtonValue = True
                    inventoryDatagrid.Columns.Add(viewProductButton)

                    ' Set the column header for the View column
                    inventoryDatagrid.Columns("ViewProductColumn").HeaderText = "View Product"

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getStocks(searchText As String)
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT p.id, s.date AS DATE, p.product_name AS 'Product Name',  p.brand_name AS 'Brand Name',s.stocks AS Stocks, p.description AS Description, p.unit AS Unit FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p On s.product_id = p.id WHERE CONCAT(s.id, ' ', p.product_name, ' ', p.description, ' ', p.unit, ' ', s.date, ' ', s.stocks) LIKE @searchText"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    inventoryDatagrid.DataSource = dataTable

                    ' Remove the "ViewProductColumn" if it exists
                    If inventoryDatagrid.Columns.Contains("ViewProductColumn") Then
                        inventoryDatagrid.Columns.Remove("ViewProductColumn")
                    End If

                    ' Add a button column for ViewStock
                    Dim viewStockButton As New DataGridViewButtonColumn()
                    viewStockButton.Name = "ViewStockColumn" ' Set the column name
                    viewStockButton.Text = "View"
                    viewStockButton.UseColumnTextForButtonValue = True
                    inventoryDatagrid.Columns.Add(viewStockButton)

                    ' Set the column header for the View column
                    inventoryDatagrid.Columns("ViewStockColumn").HeaderText = "View Stock"

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub inventoryDatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryDatagrid.CellContentClick
        ' Check if the clicked cell is a button column and not the header
        If e.RowIndex >= 0 Then
            If cmbSelect.SelectedItem IsNot Nothing Then
                ' Get the selected service
                Dim selectedService = cmbSelect.SelectedItem.ToString

                ' Handle the click event based on the selected service and column index
                Select Case selectedService
                    Case "Products"
                        If e.ColumnIndex = inventoryDatagrid.Columns("ViewProductColumn").Index Then
                            ' Get the ID of the selected row
                            Dim selectedID = Convert.ToInt32(inventoryDatagrid.Rows(e.RowIndex).Cells("id").Value)

                            ' Open the view form with the selected ID
                            Dim viewForm As New ViewProduct(selectedID)
                            viewForm.Location = New Point((Screen.GetWorkingArea(Me).Width - viewForm.Width) / 2, 0)
                            tranparent.ShowForm(viewForm)
                        End If
                    Case "Stocks Record"
                        If e.ColumnIndex = inventoryDatagrid.Columns("ViewStockColumn").Index Then
                            Dim selectedID = Convert.ToInt32(inventoryDatagrid.Rows(e.RowIndex).Cells("id").Value)

                            ' Open the view form with the selected ID
                            Dim viewForm As New ViewStock(selectedID)
                            viewForm.Location = New Point((Screen.GetWorkingArea(Me).Width - viewForm.Width) / 2, 0)
                            tranparent.ShowForm(viewForm)
                        End If
                End Select
            End If
        End If
    End Sub


    Private Sub invetorySearch_TextChanged(sender As Object, e As EventArgs) Handles invetorySearch.TextChanged
        ' Check if there is a selected item
        If cmbSelect.SelectedItem IsNot Nothing Then
            ' Get the selected service
            Dim selectedService As String = cmbSelect.SelectedItem.ToString()

            ' Get the search keyword from the search box
            Dim searchKeyword As String = invetorySearch.Text.Trim()

            ' Perform actions based on the selected service
            Select Case selectedService
                Case "Products"
                    getProducts(searchKeyword)
                Case "Stocks Record"
                    getStocks(searchKeyword)
            End Select
        End If
    End Sub

End Class
