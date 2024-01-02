Imports MySql.Data.MySqlClient

Public Class AddStock
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=motorshop_db;")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()

            ' Check if the product already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM motorshop_db.stocks WHERE product_name = @value1"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@value1", txtProductName.Text)

            Dim existingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingCount > 0 Then
                MessageBox.Show("Product already exists.")
                Return
            End If

            ' If the product does not exist, proceed with the insertion
            Dim insertQuery As String = "INSERT INTO motorshop_db.stocks (product_name, description, unit, brand_name, date, stocks) VALUES (@value1, @value2, @value3, @value4, @value5, @value6)"
            Dim insertCmd As New MySqlCommand(insertQuery, conn)
            insertCmd.Parameters.AddWithValue("@value1", txtProductName.Text)
            insertCmd.Parameters.AddWithValue("@value2", txtDescription.Text)
            insertCmd.Parameters.AddWithValue("@value3", txtUnit.Text)
            insertCmd.Parameters.AddWithValue("@value4", txtBrand.Text)
            insertCmd.Parameters.AddWithValue("@value5", txtDate.Value)
            insertCmd.Parameters.AddWithValue("@value6", txtStock.Text)

            Dim rowAffected As Integer = insertCmd.ExecuteNonQuery()

            If rowAffected > 0 Then
                MessageBox.Show("Stock successfully created!")
            Else
                MessageBox.Show("Data insertion failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Value = DateAndTime.Today

    End Sub
End Class