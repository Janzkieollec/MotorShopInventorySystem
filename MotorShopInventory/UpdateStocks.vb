Imports MySql.Data.MySqlClient

Public Class UpdateStocks

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Dim stockId As Integer

    ' Constructor that accepts the patient ID
    Public Sub New(stockId As Integer)
        InitializeComponent()

        ' Assign the received patient ID to the class-level variable
        Me.stockId = stockId

        ' Load patient data based on the ID
        loadStock(stockId)
    End Sub

    Private Sub loadStock(stockId As Integer)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch patient data based on the ID
                Dim selectQuery As String = "SELECT * FROM motorshop_db.stocks WHERE id = @id"
                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@id", stockId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with patient data
                            txtProductName.Text = reader("product_name").ToString()
                            txtDescription.Text = reader("description").ToString()
                            txtUnit.Text = reader("unit").ToString()

                            ' Corrected the assignment for the date of birth
                            txtDate.Value = reader.GetDateTime("date")

                            txtStock.Text = reader("stocks").ToString()
                            txtBrand.Text = reader("brand_name").ToString()


                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading patient data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update patient data in the database
                Dim updateQuery As String = "UPDATE motorshop_db.stocks SET product_name = @product_name, description = @description, unit = @unit, brand_name = @brand_name, date = @date, stocks = @stocks WHERE id = @id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    ' Set parameters with the updated values
                    cmd.Parameters.AddWithValue("@product_name", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text)
                    cmd.Parameters.AddWithValue("@brand_name", txtBrand.Text)
                    cmd.Parameters.AddWithValue("@date", txtDate.Value)
                    cmd.Parameters.AddWithValue("@stocks", txtStock.Text)
                    cmd.Parameters.AddWithValue("@id", stockId)

                    ' Execute the update query
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Stock updated successfully.")
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating patient data: " & ex.Message)
            End Try
        End Using
    End Sub

End Class