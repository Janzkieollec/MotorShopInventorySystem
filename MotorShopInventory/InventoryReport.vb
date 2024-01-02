Imports MySql.Data.MySqlClient

Public Class InventoryReport
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

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
                Dim selectQuery As String = $"SELECT p.id AS ID,s.brand_name AS 'Brand Name',s.description AS Desctiption, s.unit AS Unit, p.date AS Date, s.product_name AS 'Product Name', p.quantity AS Quantity FROM motorshop_db.products p " &
                                             "INNER JOIN motorshop_db.stocks s ON p.stock_id = s.id  " &
                                             "WHERE CONCAT(p.id,' ',p.quantity, ' ', p.price) LIKE @searchText"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    inventoryDatgrid.DataSource = dataTable

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
                Dim selectQuery As String = $"SELECT id AS ID, product_name AS 'Product Name', description AS Description, unit AS Unit, date AS Date, stocks AS Stocks FROM motorshop_db.stocks
                                             WHERE CONCAT(id,' ', product_name,' ', description,' ', unit,' ', date,' ', stocks) LIKE @searchText"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    inventoryDatgrid.DataSource = dataTable

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
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