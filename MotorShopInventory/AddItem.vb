
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class AddItem
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim selectedStock As String = txtProductName.SelectedItem.ToString()
                Dim stockId As Integer = GetStockId(selectedStock, conn)

                ' Check if the selected product is out of stock
                If IsOutOfStock(stockId, conn) Then
                    MessageBox.Show("This product is currently out of stock. Cannot add it to inventory.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Exit the event handler without adding the item
                End If

                ' If the product is in stock, proceed with the insertion
                Dim query As String = "INSERT INTO motorshop_db.products (stock_id, price, quantity, date) VALUES (@value1, @value2, @value3, @value4)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@value1", stockId)
                cmd.Parameters.AddWithValue("@value2", txtPrice.Text)
                cmd.Parameters.AddWithValue("@value3", txtQuantity.Text)
                cmd.Parameters.AddWithValue("@value4", txtDate.Value)

                Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                If rowAffected > 0 Then
                    UpdateStockQuantity(stockId, Convert.ToInt32(txtQuantity.Text), conn)
                    MessageBox.Show("Product successfully created!")
                Else
                    MessageBox.Show("Data insertion failed.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
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


    Private Sub UpdateStockQuantity(stockId As Integer, quantityToSubtract As Integer, connection As MySqlConnection)
        Try
            ' Update the stock quantity in the 'stocks' table
            Dim updateQuery As String = "UPDATE motorshop_db.stocks SET stocks = stocks - @quantityToSubtract WHERE id = @stockId"
            Using cmdUpdate As New MySqlCommand(updateQuery, connection)
                cmdUpdate.Parameters.AddWithValue("@quantityToSubtract", quantityToSubtract)
                cmdUpdate.Parameters.AddWithValue("@stockId", stockId)

                cmdUpdate.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle the exception (e.g., log the error)
        End Try
    End Sub
    Private Function GetStockId(productName As String, connection As MySqlConnection) As Integer
        Try
            ' Query the gender_id based on gender_name
            Dim query As String = "SELECT id FROM motorshop_db.stocks WHERE product_name = @product_name"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@product_name", productName)

                Dim result As Object = cmd.ExecuteScalar()

                ' Check if the result is not DBNull and convert it to an Integer
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where genderid is not found
                    MessageBox.Show("Gender not found for the specified name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Handle any other exceptions
            MessageBox.Show("Error retrieving gender_id: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return a default value if the retrieval fails
        Return -1
    End Function

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Value = DateAndTime.Today
        LoadStockComboBox()
    End Sub

    Private Sub LoadStockComboBox()
        Using conn As New MySqlConnection(connString)
            Try
                ' Open the connection only when needed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Query to retrieve gender names from the 'gender' table
                Dim query As String = "SELECT * FROM motorshop_db.stocks"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing items in the ComboBox
                        txtProductName.Items.Clear()

                        ' Load gender names into the ComboBox
                        While reader.Read()
                            txtProductName.Items.Add(reader("product_name").ToString())
                        End While


                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading gender names: " & ex.Message)
            Finally
                ' Close the connection if it was opened
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
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

                    ' Query to retrieve details of the selected product from the 'stocks' table
                    Dim query As String = "SELECT * FROM motorshop_db.stocks WHERE product_name = @productName"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@productName", txtProductName.SelectedItem.ToString())

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            ' Check if the product details are available
                            If reader.Read() Then
                                ' Populate text fields with product details
                                txtBrand.Text = reader("brand_name").ToString()
                                txtDescription.Text = reader("description").ToString()
                                txtUnit.Text = reader("unit").ToString()

                                ' Check if the product is out of stock
                                Dim availableStock As Integer = Convert.ToInt32(reader("stocks"))
                                If availableStock <= 0 Then
                                    MessageBox.Show("This product is currently out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
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
        End If
    End Sub


End Class