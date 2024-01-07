Imports MySql.Data.MySqlClient

Public Class AddStock
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Check if the product already exists
                Dim stockId As Integer = GetProductIdByName(txtProductName.Text, conn)

                If stockId = -1 Then
                    MessageBox.Show("Product not found.")
                    Return
                End If

                If ProductExists(stockId, conn) Then
                    MessageBox.Show("Product already exists.")
                    Return
                End If

                ' If the product does not exist, proceed with the insertion
                InsertStockData(stockId, conn)

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Function ProductExists(stockId As Integer, connection As MySqlConnection) As Boolean
        ' Check if the product already exists in the stocks table
        Dim checkQuery As String = "SELECT COUNT(*) FROM motorshop_db.stocks WHERE product_id = @value1"
        Using checkCmd As New MySqlCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@value1", stockId)

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            Return existingCount > 0
        End Using
    End Function

    Private Sub InsertStockData(stockId As Integer, connection As MySqlConnection)
        ' Proceed with the insertion
        Dim insertQuery As String = "INSERT INTO motorshop_db.stocks (product_id, date, stocks) VALUES (@value1, @value2, @value3)"
        Using insertCmd As New MySqlCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@value1", stockId)
            insertCmd.Parameters.AddWithValue("@value2", txtDate.Value)
            insertCmd.Parameters.AddWithValue("@value3", txtStock.Text)

            Dim rowAffected As Integer = insertCmd.ExecuteNonQuery()

            If rowAffected > 0 Then
                ' Insert the value into the available_stocks column in the products table
                UpdateAvailableStocks(stockId, Convert.ToInt32(txtStock.Text), connection)

                ' Proceed with inserting into view_stock table
                InsertViewProductData(stockId, connection)
            Else
                MessageBox.Show("Data insertion failed.")
            End If
        End Using
    End Sub

    Private Sub UpdateAvailableStocks(stockId As Integer, additionalStocks As Integer, connection As MySqlConnection)
        ' Update the available_stocks column in the products table
        Dim updateQuery As String = "UPDATE motorshop_db.products SET available_stocks = available_stocks + @additionalStocks WHERE id = @stockId"
        Using updateCmd As New MySqlCommand(updateQuery, connection)
            updateCmd.Parameters.AddWithValue("@additionalStocks", additionalStocks)
            updateCmd.Parameters.AddWithValue("@stockId", stockId)

            Dim rowAffected As Integer = updateCmd.ExecuteNonQuery()

            If rowAffected <= 0 Then
                MessageBox.Show("Error updating available stocks.")
            End If
        End Using
    End Sub


    Private Sub InsertViewProductData(stockId As Integer, connection As MySqlConnection)
        ' Get the stockID from the stocks table
        Dim getstockID As Integer = GetProductID(stockId, connection)

        If getstockID <> -1 Then
            ' Insert data into view_stocks table
            Dim insertViewProductQuery As String = "INSERT INTO motorshop_db.view_stock (stock_id, product_id, date, stock) VALUES (@value1, @value2, @value3, @value4)"
            Using cmdInsertViewProduct As New MySqlCommand(insertViewProductQuery, connection)
                cmdInsertViewProduct.Parameters.AddWithValue("@value1", getstockID)
                cmdInsertViewProduct.Parameters.AddWithValue("@value2", stockId)
                cmdInsertViewProduct.Parameters.AddWithValue("@value3", txtDate.Value)
                cmdInsertViewProduct.Parameters.AddWithValue("@value4", txtStock.Text)

                Dim rowAffectedViewProduct As Integer = cmdInsertViewProduct.ExecuteNonQuery()

                If rowAffectedViewProduct > 0 Then
                    MessageBox.Show("Product successfully created!")
                Else
                    MessageBox.Show("Error inserting into view_stocks table.")
                End If
            End Using
        End If
    End Sub

    Private Function GetProductID(productId As Integer, connection As MySqlConnection) As Integer
        ' Query the stock_id based on the given product ID
        Dim query As String = "SELECT id FROM motorshop_db.stocks WHERE product_id = @productID"
        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@productID", productId)

            Dim result As Object = cmd.ExecuteScalar()

            ' Check if the result is not DBNull and convert it to an Integer
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                ' Handle the case where stock_id is not found
                MessageBox.Show("Stock ID not found for the specified product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        ' Return a default value if the retrieval fails
        Return -1
    End Function


    ' Helper method to get product_id based on the product name
    Private Function GetProductIdByName(productName As String, connection As MySqlConnection) As Integer
        ' Query to retrieve product_id from the 'products' table
        Dim query As String = "SELECT id FROM motorshop_db.products WHERE product_name = @productName"
        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@productName", productName)

            Dim productId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return productId
        End Using
    End Function

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Value = DateAndTime.Today
        PopulateProductNames()
    End Sub

    Private Sub PopulateProductNames()

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()


                ' Fetch product names from the 'products' table
                Dim selectProductsQuery As String = "SELECT product_name FROM motorshop_db.products"
                Using cmd As New MySqlCommand(selectProductsQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Add each product name to the ComboBox
                        While reader.Read()
                            txtProductName.Items.Add(reader("product_name").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading product names: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProductName.SelectedIndexChanged
        ' Check if an item is selected in the ComboBox
        If txtProductName.SelectedIndex <> -1 Then
            Using conn As New MySqlConnection(connString)
                Try
                    ' Open the connection only when needed
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Query to retrieve details of the selected product from the 'products' table
                    Dim query As String = "SELECT * FROM motorshop_db.products WHERE product_name = @productName"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@productName", txtProductName.SelectedItem.ToString())

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            ' Check if the product details are available
                            If reader.Read() Then
                                ' Populate text fields with product details
                                txtBrand.Text = reader("brand_name").ToString()
                                txtDescription.Text = reader("description").ToString()
                                txtUnit.Text = reader("unit").ToString()
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading product details: " & ex.Message)
                Finally
                    ' Close the connection if it was opened
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End Using
        Else

        End If
    End Sub

End Class
