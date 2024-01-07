Imports MySql.Data.MySqlClient

Public Class ViewProduct
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"
    Private _selectedID As Integer

    Public Sub New(selectedID As Integer)
        InitializeComponent()
        _selectedID = selectedID
        LoadProduct()
    End Sub

    Private Sub LoadProduct()
        Dim selectQuery As String = "SELECT row_number() over() as ID, v.product_id, p.product_name, p.brand_name, p.description, p.unit, v.date, p.status, v.quantity " &
                              "FROM motorshop_db.vew_products v " &
                              "INNER JOIN motorshop_db.products p ON v.product_id = p.id " &
                              "WHERE v.product_id = @id"

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

                    ' Hide the product_id column
                    inventoryDatgrid.Columns("product_id").Visible = False
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub

End Class
