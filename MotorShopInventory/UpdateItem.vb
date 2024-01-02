Imports MySql.Data.MySqlClient

Public Class UpdateItem
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Dim productID As Integer

    Public Sub New(productID As Integer)
        InitializeComponent()
        Me.productID = productID
        LoadProduct(productID)
    End Sub

    Private Sub LoadProduct(productID As Integer)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim selectQuery As String = "SELECT p.id, s.brand_name, s.description, s.unit, p.date, s.product_name, p.price, p.quantity FROM motorshop_db.products p " &
                                             "INNER JOIN motorshop_db.stocks s ON p.stock_id = s.id " &
                                             "WHERE p.id = @id"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@id", productID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtProductName.Text = reader("product_name").ToString()
                            txtDescription.Text = reader("description").ToString()
                            txtUnit.Text = reader("unit").ToString()
                            txtDate.Value = reader.GetDateTime("date")
                            txtPrice.Text = reader("price").ToString()
                            txtQuantity.Text = reader("quantity").ToString()
                            txtBrand.Text = reader("brand_name").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading product data: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim stockId As Integer = GetStockId(txtProductName.Text, conn)

                Dim currentQuantity As Integer = GetCurrentQuantity(productID, conn)
                Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text)

                Dim quantityDifference As Integer = newQuantity - currentQuantity

                Dim selectedStock As String = txtProductName.Text.ToString()

                ' Check if the selected product is out of stock
                If IsOutOfStock(stockId, conn) Then
                    MessageBox.Show("This product is currently out of stock. Cannot add it to inventory.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Exit the event handler without adding the item
                End If

                Dim updateQuery As String = "UPDATE motorshop_db.products SET price = @price, date = @date, quantity = @quantity WHERE id = @id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text)
                    cmd.Parameters.AddWithValue("@date", txtDate.Value)
                    cmd.Parameters.AddWithValue("@quantity", newQuantity)
                    cmd.Parameters.AddWithValue("@id", productID)

                    cmd.ExecuteNonQuery()

                    UpdateStockQuantity(stockId, quantityDifference, conn)

                    MessageBox.Show("Product updated successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating product data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function IsOutOfStock(stockId As Integer, connection As MySqlConnection) As Boolean
        Try
            ' Query the available stock quantity
            Dim query As String = "SELECT stocks FROM motorshop_db.stocks WHERE id = @stockId"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@stockId", stockId)

                Dim result As Object = cmd.ExecuteScalar()

                ' Check if the result is not DBNull and convert it to an Integer
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim availableStock As Integer = Convert.ToInt32(result)
                    Return availableStock <= 0
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions (e.g., log the error)
            MessageBox.Show("Error checking stock availability: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return true by default to prevent adding when an error occurs
        Return True
    End Function
    Private Function GetCurrentQuantity(productID As Integer, connection As MySqlConnection) As Integer
        Try
            Dim query As String = "SELECT quantity FROM motorshop_db.products WHERE id = @id"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", productID)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    MessageBox.Show("Product not found for the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving current quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function


    Private Sub UpdateStockQuantity(stockId As Integer, quantityToSubtract As Integer, connection As MySqlConnection)
        Try
            Dim updateQuery As String = "UPDATE motorshop_db.stocks SET stocks = stocks - @quantityToSubtract WHERE id = @stockId"
            Using cmdUpdate As New MySqlCommand(updateQuery, connection)
                cmdUpdate.Parameters.AddWithValue("@quantityToSubtract", quantityToSubtract)
                cmdUpdate.Parameters.AddWithValue("@stockId", stockId)
                cmdUpdate.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating stock quantity: " & ex.Message)
        End Try
    End Sub

    Private Function GetStockId(productName As String, connection As MySqlConnection) As Integer
        Try
            Dim query As String = "SELECT id FROM motorshop_db.stocks WHERE product_name = @product_name"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@product_name", productName)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    MessageBox.Show("Product not found for the specified name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving stock ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function
End Class
