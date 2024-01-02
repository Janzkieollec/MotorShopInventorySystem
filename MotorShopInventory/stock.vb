Imports MySql.Data.MySqlClient

Public Class stock
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddStock As New AddStock
        frmAddStock.Location = New Point((WorkingArea.Width - frmAddStock.Width) / 2, 0)
        tranparent.ShowForm(frmAddStock)
        stockDatagridView(stockSearch.Text, getUnit.Text)
        getDate.Value = DateAndTime.Today

    End Sub

    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stockDatagridView(stockSearch.Text, getUnit.Text)

        PopulateUnitComboBox()
    End Sub

    Private Sub PopulateUnitComboBox()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Clear existing items in the ComboBox
                getUnit.Items.Clear()

                ' Add an empty string as the default value
                getUnit.Items.Add("")

                ' Fetch distinct unit values from the stocks table
                Dim selectUnitQuery As String = "SELECT DISTINCT unit FROM motorshop_db.stocks"
                Using cmd As New MySqlCommand(selectUnitQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Add each unit value to the ComboBox
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
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT id, product_name, description, unit, date, stocks FROM motorshop_db.stocks"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    stockDatgrid.DataSource = dataTable

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub stockDatagridView(searchText As String, selectedUnit As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT id, product_name, description, unit, date, stocks FROM motorshop_db.stocks
                                             WHERE CONCAT(id,' ', product_name,' ', description,' ', unit,' ', date,' ', stocks) LIKE @searchText"

                ' Add unit filter condition if selectedUnit is provided
                If Not String.IsNullOrEmpty(selectedUnit) Then
                    selectQuery &= " AND unit = @selectedUnit"
                End If

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    ' Add parameter for unit filter if selectedUnit is provided
                    If Not String.IsNullOrEmpty(selectedUnit) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@selectedUnit", selectedUnit)
                    End If

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
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

        ' Check if a valid stockId is returned
        If stockId <> -1 Then
            Dim frmUpdateStock As New UpdateStocks(stockId)
            frmUpdateStock.Location = New Point((Screen.GetWorkingArea(Me).Width - frmUpdateStock.Width) / 2, 0)
            tranparent.ShowForm(frmUpdateStock)

            stockDatagridView(stockSearch.Text, getUnit.Text)

        End If
    End Sub

    Private Function GetSelectedStockId() As Integer
        If stockDatgrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = stockDatgrid.SelectedRows(0)
            Dim productId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)
            Return productId
        Else
            MessageBox.Show("No record selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -1 ' Or any other value indicating that no record is selected
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

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT id, product_name, description, unit, date, stocks FROM motorshop_db.stocks
                                             WHERE MONTH(date) = @selectedMonth AND YEAR(date) = @selectedYear "




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
