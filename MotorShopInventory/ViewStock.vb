Imports MySql.Data.MySqlClient

Public Class ViewStock
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Private _selectedID As Integer

    Public Sub New(selectedID As Integer)
        InitializeComponent()
        _selectedID = selectedID
        LoadProduct()
    End Sub

    Private Sub LoadProduct()
        Dim selectQuery As String = "SELECT row_number() over() as IDs, p.product_name, p.brand_name, p.description,v.date, v.stock, v.status " &
                                "FROM motorshop_db.view_stock v " &
                                "INNER JOIN motorshop_db.stocks s ON v.stock_id = s.id " &
                                "INNER JOIN motorshop_db.products p ON v.product_id = p.id " &
                                "WHERE v.product_id = @id ORDER BY v.id"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@id", _selectedID)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    ' Set the DataSource to the DefaultView of the DataTable
                    inventoryDatgrid.DataSource = dataTable.DefaultView

                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
