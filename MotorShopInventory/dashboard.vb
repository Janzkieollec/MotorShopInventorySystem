Imports System.Windows.Forms.AxHost
Imports MySql.Data.MySqlClient

Public Class dashboard
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataIntoDataGridView()
        totalProductss()
        totalStockss()
    End Sub

    Public Sub LoadDataIntoDataGridView()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Load product data into the product DataGridView
                Dim productDataTable As New DataTable()
                Dim productSelectQuery As String = "SELECT id, product_name FROM motorshop_db.products WHERE DATE(date) = CURDATE()"
                Using productAdapter As New MySqlDataAdapter(productSelectQuery, conn)
                    productAdapter.Fill(productDataTable)
                End Using

                ' Set the DataSource outside of the 'Using' block to avoid issues with disposing the adapter
                productDatagrid.DataSource = productDataTable

                ' Load stock data into the stock DataGridView
                ' Load stock data into the stock DataGridView
                Dim stockDataTable As New DataTable()
                Dim stockSelectQuery As String = "SELECT p.product_name, s.stocks, s.id FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id  ORDER BY id"
                Using stockAdapter As New MySqlDataAdapter(stockSelectQuery, conn)
                    stockAdapter.Fill(stockDataTable)
                End Using

                ' Set the DataSource outside of the 'Using' block to avoid issues with disposing the adapter
                stockDatgrid.DataSource = stockDataTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try


        End Using
    End Sub

    Public Sub totalProductss()
        Try
            Using connection As New MySqlConnection(connString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand to execute the SQL query
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM motorshop_db.products", connection)
                    ' Execute the query and get the result
                    Dim totalProducts As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalProduct
                    totalProduct.Text = totalProducts.ToString()
                End Using

                ' Get the current month and year
                Dim currentMonth As Integer = DateTime.Now.Month
                Dim currentYear As Integer = DateTime.Now.Year

                ' Your SQL query with parameters for month and year
                Dim query As String = "SELECT COUNT(*) FROM motorshop_db.products WHERE MONTH(date) = @month AND YEAR(date) = @year"

                Using newcmd As New MySqlCommand(query, connection)
                    ' Add parameters for month and year
                    newcmd.Parameters.AddWithValue("@month", currentMonth)
                    newcmd.Parameters.AddWithValue("@year", currentYear)

                    ' Execute the query and get the result
                    Dim totalProduct As Integer = Convert.ToInt32(newcmd.ExecuteScalar())

                    ' Display the result in a TextBox named newProduct
                    newProduct.Text = totalProduct.ToString() & " Total Product"
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub totalStockss()
        Try
            Using connection As New MySqlConnection(connString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand to execute the SQL query
                Using cmd As New MySqlCommand("SELECT SUM(stocks) FROM motorshop_db.stocks", connection)
                    ' Execute the query and get the result
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        ' If result is not DBNull.Value or Nothing, convert it to an integer
                        Dim stocks As Integer = Convert.ToInt32(result)

                        ' Display the result in a TextBox named totalStock
                        totalStocks.Text = stocks.ToString()
                        totalStock.Text = stocks.ToString() & " Total Stocks"
                    Else
                        ' Handle the case when there is no stock data
                        totalStocks.Text = "0"
                        totalStock.Text = "0 Total Stocks"
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
