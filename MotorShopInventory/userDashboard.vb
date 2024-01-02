Imports MySql.Data.MySqlClient

Public Class userDashboard
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub userDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        totalProductss()
    End Sub

    Public Sub LoadDataIntoDataGridView()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Load product data into the product DataGridView
                Dim productDataTable As New DataTable()
                Dim productSelectQuery As String = "SELECT p.id, s.product_name FROM motorshop_db.products p INNER JOIN motorshop_db.stocks s ON p.stock_id = s.id  WHERE DATE(p.date) = CURDATE()"
                Using productAdapter As New MySqlDataAdapter(productSelectQuery, conn)
                    productAdapter.Fill(productDataTable)
                End Using

                ' Set the DataSource outside of the 'Using' block to avoid issues with disposing the adapter
                productDatagrid.DataSource = productDataTable


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
End Class