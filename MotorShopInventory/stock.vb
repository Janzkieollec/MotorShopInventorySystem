Imports MySql.Data.MySqlClient

Public Class stock
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddStock As New AddStock
        frmAddStock.Location = New Point((Screen.GetWorkingArea(Me).Width - frmAddStock.Width) / 2, 0)
        tranparent.ShowForm(frmAddStock)
        stockDatagridView(stockSearch.Text, getUnit.Text)
        getDate.Value = Date.Today
    End Sub

    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stockDatagridView(stockSearch.Text, getUnit.Text)
        PopulateUnitComboBox()
    End Sub

    Private Sub PopulateUnitComboBox()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                getUnit.Items.Clear()
                getUnit.Items.Add("")

                Dim selectUnitQuery As String = "SELECT DISTINCT unit FROM motorshop_db.products"
                Using cmd As New MySqlCommand(selectUnitQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            getUnit.Items.Add(reader("unit").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading unit data: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub RefreshData()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()
                Dim selectQuery As String = "SELECT p.id, row_number() over() as IDs, p.product_name, p.brand_name, p.description, p.unit, s.date, s.stocks FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.Fill(dataTable)
                    stockDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub stockDatagridView(searchText As String, selectedUnit As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()
                Dim selectQuery As String = $"SELECT p.id, row_number() over() as IDs, p.product_name, p.brand_name, p.description, p.unit, s.date, s.stocks FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id WHERE CONCAT(s.id, ' ', p.product_name, ' ', p.description, ' ', p.unit, ' ', s.date, ' ', s.stocks) LIKE @searchText"

                If Not String.IsNullOrEmpty(selectedUnit) Then
                    selectQuery &= " AND p.unit = @selectedUnit"
                End If

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    If Not String.IsNullOrEmpty(selectedUnit) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@selectedUnit", selectedUnit)
                    End If

                    adapter.Fill(dataTable)
                    stockDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub stockSearch_TextChanged(sender As Object, e As EventArgs) Handles stockSearch.TextChanged
        stockDatagridView(stockSearch.Text, getUnit.Text)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim stockId As Integer = GetSelectedStockId()

        If stockId <> -1 Then
            Dim frmUpdateStock As New UpdateStocks(stockId)
            frmUpdateStock.Location = New Point((Screen.GetWorkingArea(Me).Width - frmUpdateStock.Width) / 2, 0)
            tranparent.ShowForm(frmUpdateStock)
            stockDatagridView(stockSearch.Text, getUnit.Text)
        End If
    End Sub

    Private Function GetSelectedStockId() As Integer
        If stockDatgrid.SelectedRows.Count > 0 Then
            ' Assuming the column name is "id", change it to the actual name in your DataGridView
            Dim selectedRow As DataGridViewRow = stockDatgrid.SelectedRows(0)
            Dim stockId As Integer = Convert.ToInt32(selectedRow.Cells("stock_id").Value)
            Return stockId
        Else
            MessageBox.Show("No record selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -1
        End If
    End Function


    Private Sub getDate_ValueChanged(sender As Object, e As EventArgs) Handles getDate.ValueChanged
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()
            Dim selectedDate As DateTime = getDate.Value

            ' Extract month and year from the selected date
            Dim selectedMonth As Integer = selectedDate.Month
            Dim selectedYear As Integer = selectedDate.Year

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation, search condition, date filter, and unit filter
                Dim selectQuery As String = $"SELECT p.id, row_number() over() as IDs, p.product_name, p.brand_name, p.description, p.unit, s.date, s.stocks FROM motorshop_db.stocks s INNER JOIN motorshop_db.products p ON s.product_id = p.id " &
                                              "WHERE MONTH(p.date) = @selectedMonth AND YEAR(p.date) = @selectedYear "

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedMonth", selectedMonth)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedYear", selectedYear)


                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    stockDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles getUnit.SelectedIndexChanged
        stockDatagridView(stockSearch.Text, getUnit.Text)
    End Sub
End Class
