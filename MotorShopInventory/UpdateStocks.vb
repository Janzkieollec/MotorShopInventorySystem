Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class UpdateStocks

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Dim stockId As Integer

    ' Constructor that accepts the stock ID
    Public Sub New(stockId As Integer)
        InitializeComponent()

        ' Assign the received stock ID to the class-level variable
        Me.stockId = stockId

        ' Load stock data based on the ID
        loadStock(stockId)
    End Sub

    Private Sub loadStock(stockId As Integer)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch stock data based on the ID
                Dim selectQuery As String = "SELECT p.id, p.product_name, p.description, p.unit, s.date, p.brand_name, p.status FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id WHERE p.id = @id"
                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@id", stockId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with stock data
                            txtProductName.Text = reader("product_name").ToString()
                            txtDescription.Text = reader("description").ToString()
                            txtUnit.Text = reader("unit").ToString()
                            txtStatus.Text = reader("status").ToString()

                            ' Use DateTime.Parse to parse the date from the database
                            txtDate.Value = DateTime.Parse(reader("date").ToString())

                            txtBrand.Text = reader("brand_name").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading stock data: " & ex.Message)
            Finally
                ' Close the connection if it was opened
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch the current stock quantity
                Dim currentStock As Integer = GetCurrentStock(stockId, conn)

                ' Determine the change in stocks based on the status
                Dim stocksChange As Integer
                If txtStatus.Text.ToLower() = "in" Then
                    stocksChange = Convert.ToInt32(txtStock.Text)
                ElseIf txtStatus.Text.ToLower() = "out" Then
                    ' Check if the available stock is sufficient for an "out" transaction
                    If currentStock >= Convert.ToInt32(txtStock.Text) Then
                        stocksChange = -Convert.ToInt32(txtStock.Text)
                    Else
                        MessageBox.Show("Not enough stock available for transaction.")
                        Return
                    End If
                Else
                    MessageBox.Show("Invalid status.")
                    Return
                End If

                ' Calculate the new stock quantity
                Dim newStockQuantity As Integer = currentStock + stocksChange

                ' Update stock data in the database
                Dim updateQuery As String = "UPDATE motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id SET p.unit = @unit, p.status = @status, s.date = @date, s.stocks = @stocks, p.available_stocks = @available_stocks WHERE p.id = @id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    ' Set parameters with the updated values
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text)
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@date", txtDate.Value)
                    cmd.Parameters.AddWithValue("@stocks", newStockQuantity)
                    cmd.Parameters.AddWithValue("@available_stocks", newStockQuantity) ' Set available_stocks to the new stock quantity
                    cmd.Parameters.AddWithValue("@id", stockId)

                    Dim rowAffectedProduct As Integer = cmd.ExecuteNonQuery()

                    If rowAffectedProduct > 0 Then
                        ' Product successfully updated, now insert into 'view_stock' table
                        Dim updatedProductID As Integer = GetProductID(stockId, conn)
                        If updatedProductID <> -1 Then
                            Dim insertViewStockQuery As String = "INSERT INTO motorshop_db.view_stock (stock_id, product_id, date, stock, status) VALUES (@productId, @product_id, @date, @stocks, @status)"

                            Using cmdInsertViewStock As New MySqlCommand(insertViewStockQuery, conn)
                                cmdInsertViewStock.Parameters.AddWithValue("@productId", updatedProductID) ' Assuming productId is the correct field name
                                cmdInsertViewStock.Parameters.AddWithValue("@product_id", stockId) ' Assuming productId is the correct field name
                                cmdInsertViewStock.Parameters.AddWithValue("@date", txtDate.Value)
                                cmdInsertViewStock.Parameters.AddWithValue("@stocks", stocksChange)
                                cmdInsertViewStock.Parameters.AddWithValue("@status", txtStatus.Text)

                                Dim rowAffectedViewStock As Integer = cmdInsertViewStock.ExecuteNonQuery()

                                If rowAffectedViewStock > 0 Then
                                    MessageBox.Show("Product successfully updated!")
                                Else
                                    MessageBox.Show("Error inserting into view_stock table.")
                                End If
                            End Using
                        Else
                            MessageBox.Show("Error getting updated product ID.")
                        End If
                    Else
                        MessageBox.Show("Error updating product data.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating stock data: " & ex.Message)
            Finally
                ' Close the connection if it was opened
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub



    Private Function GetCurrentStock(stockId As Integer, conn As MySqlConnection) As Integer
        Try
            Dim selectQuery As String = "SELECT stocks FROM motorshop_db.stocks WHERE product_id = @id"
            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@id", stockId)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting current stock: " & ex.Message)
        End Try
        Return -1
    End Function




    Private Function GetProductID(stockId As String, conn As MySqlConnection) As Integer
        Try
            Dim selectQuery As String = "SELECT id FROM motorshop_db.stocks WHERE product_id = @id"
            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@id", stockId)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting product ID: " & ex.Message)
        End Try
        Return -1
    End Function


End Class
