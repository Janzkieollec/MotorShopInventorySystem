
Imports System.Net
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class AddItem
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Check if the product already exists
                If ProductExists(txtProduct.Text, conn) Then
                    MessageBox.Show("Product already exists.")
                    Return
                End If

                ' Insert into 'products' table
                Dim insertProductQuery As String = "INSERT INTO motorshop_db.products (product_id, product_name, brand_name, description, unit, date, status, quantity) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)"
                Using cmdInsertProduct As New MySqlCommand(insertProductQuery, conn)
                    cmdInsertProduct.Parameters.AddWithValue("@value1", txtID.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value2", txtProduct.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value3", txtBrand.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value4", txtDescription.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value5", txtUnit.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value6", txtDate.Value)
                    cmdInsertProduct.Parameters.AddWithValue("@value7", txtStatus.Text)
                    cmdInsertProduct.Parameters.AddWithValue("@value8", txtQuantity.Text)

                    Dim rowAffectedProduct As Integer = cmdInsertProduct.ExecuteNonQuery()

                    If rowAffectedProduct > 0 Then
                        ' Product successfully created, now get the product ID
                        Dim productID As Integer = GetProductID(txtID.Text, conn)

                        ' Continue with inserting into 'vew_products' table
                        If productID <> -1 Then
                            Dim insertVewProductQuery As String = "INSERT INTO motorshop_db.vew_products (product_id, date, quantity, status) VALUES (@value1, @value2, @value3, @value4)"
                            Using cmdInsertVewProduct As New MySqlCommand(insertVewProductQuery, conn)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value1", productID)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value2", txtDate.Value)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value3", txtQuantity.Text)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value4", txtStatus.Text)

                                Dim rowAffectedVewProduct As Integer = cmdInsertVewProduct.ExecuteNonQuery()

                                If rowAffectedVewProduct > 0 Then
                                    MessageBox.Show("Product successfully created!")
                                Else
                                    MessageBox.Show("Error inserting into vew_product table.")
                                End If
                            End Using
                        End If
                    Else
                        MessageBox.Show("Error inserting into products table.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Function ProductExists(productName As String, connection As MySqlConnection) As Boolean
        ' Check if the product already exists in the products table based on product_name
        Dim checkQuery As String = "SELECT COUNT(*) FROM motorshop_db.products WHERE product_name = @value1"
        Using checkCmd As New MySqlCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@value1", productName)

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            Return existingCount > 0
        End Using
    End Function



    Private Function GetProductID(productID As String, connection As MySqlConnection) As Integer
        Try
            ' Query the product_id based on the given product ID
            Dim query As String = "SELECT id FROM motorshop_db.products WHERE product_id = @productID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@productID", productID)

                Dim result As Object = cmd.ExecuteScalar()

                ' Check if the result is not DBNull and convert it to an Integer
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where product_id is not found
                    MessageBox.Show("Product ID not found for the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Handle any other exceptions
            MessageBox.Show("Error retrieving product_id: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return a default value if the retrieval fails
        Return -1
    End Function



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
        GenerateProductId()
    End Sub

    Private Sub GenerateProductId()
        ' Get the current date and time
        Dim currentDate As String = DateAndTime.Today.ToString("yyyyMMdd")

        ' Generate a random number (you may use a more robust method depending on your requirements)
        Dim random As New Random()
        Dim randomSuffix As Integer = random.Next(1000, 9999)

        ' Combine the date and random number to create the product ID
        Dim productId As String = currentDate & randomSuffix.ToString()

        ' Set the generated product ID in the txtID.Text control
        txtID.Text = productId
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


End Class