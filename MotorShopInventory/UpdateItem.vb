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

                Dim selectQuery As String = "SELECT product_id, product_name, brand_name, description, unit, date, status, quantity FROM motorshop_db.products " &
                                             "WHERE id = @id"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@id", productID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtID.Text = reader("product_id").ToString()
                            txtProduct.Text = reader("product_name").ToString()
                            txtDescription.Text = reader("description").ToString()
                            txtUnit.Text = reader("unit").ToString()
                            txtDate.Value = reader.GetDateTime("date")
                            txtStatus.Text = reader("status").ToString()
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

    Private Function GetProductID(productID As String, conn As MySqlConnection) As Integer
        Try
            Dim selectQuery As String = "SELECT id FROM motorshop_db.products WHERE product_id = @product_id"
            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@product_id", productID)
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim updateQuery As String = "UPDATE motorshop_db.products SET product_id = @product_id, product_name = @product_name, brand_name = @brand_name, description = @description, unit = @unit, status = @status, date = @date, quantity = @quantity WHERE id = @id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@product_id", txtID.Text)
                    cmd.Parameters.AddWithValue("@product_name", txtProduct.Text)
                    cmd.Parameters.AddWithValue("@brand_name", txtBrand.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text)
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@date", txtDate.Value)
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
                    cmd.Parameters.AddWithValue("@id", productID)

                    Dim rowAffectedProduct As Integer = cmd.ExecuteNonQuery()

                    If rowAffectedProduct > 0 Then
                        ' Product successfully updated, now insert into 'vew_products' table
                        Dim updatedProductID As Integer = GetProductID(txtID.Text, conn)
                        If updatedProductID <> -1 Then
                            Dim insertVewProductQuery As String = "INSERT INTO motorshop_db.vew_products (product_id, date, quantity, status) VALUES (@value1, @value2, @value3, @value4)"
                            Using cmdInsertVewProduct As New MySqlCommand(insertVewProductQuery, conn)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value1", updatedProductID)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value2", txtDate.Value)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value3", txtQuantity.Text)
                                cmdInsertVewProduct.Parameters.AddWithValue("@value4", txtStatus.Text)

                                Dim rowAffectedVewProduct As Integer = cmdInsertVewProduct.ExecuteNonQuery()

                                If rowAffectedVewProduct > 0 Then
                                    MessageBox.Show("Product successfully updated!")
                                Else
                                    MessageBox.Show("Error inserting into vew_products table.")
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
                MessageBox.Show("Error updating product data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
