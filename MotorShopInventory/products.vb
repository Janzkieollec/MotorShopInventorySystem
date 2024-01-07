Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class products
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productDatagridView(productSearch.Text, getBrand.Text)
        PopulateBrandComboBox()
        getDate.Value = DateAndTime.Today
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddItem As New AddItem
        frmAddItem.Location = New Point((WorkingArea.Width - frmAddItem.Width) / 2, 0)
        tranparent.ShowForm(frmAddItem)

        productDatagridView(productSearch.Text, getBrand.Text)
        PopulateBrandComboBox()

    End Sub

    'Handler for Update Item
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim productId As Integer = GetSelectedProductId()

        ' Check if a valid productId is returned
        If productId <> -1 Then
            Dim frmUpdateItem As New UpdateItem(productId)
            frmUpdateItem.Location = New Point((Screen.GetWorkingArea(Me).Width - frmUpdateItem.Width) / 2, 0)
            tranparent.ShowForm(frmUpdateItem) ' Assuming transparent is the correct class or module

            ' Refresh the Product datagrid
            ' Assuming productDatagridView is the correct method to refresh the grid
            productDatagridView(productSearch.Text, getBrand.Text)
        End If
    End Sub

    Private Function GetSelectedProductId() As Integer
        If productDatgrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = productDatgrid.SelectedRows(0)
            Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
            Return productId
        Else
            MessageBox.Show("No record selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -1 ' Or any other value indicating that no record is selected
        End If
    End Function


    'function for product list

    ' Function for product list with date filter
    Public Sub productDatagridView(searchText As String, selectedBrand As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation, search condition, date filter, and unit filter
                Dim selectQuery As String = $"SELECT id, row_number() over() as IDs, product_name, brand_name, description, unit, date, available_stocks FROM motorshop_db.products " &
                                         "WHERE CONCAT(id,' ',product_name) LIKE @searchText "

                ' Add unit filter condition if selectedUnit is provided
                If Not String.IsNullOrEmpty(selectedBrand) Then
                    selectQuery &= " AND brand_name = @selectedBrand"
                End If

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    ' Add parameter for unit filter if selectedUnit is provided
                    If Not String.IsNullOrEmpty(selectedBrand) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@selectedBrand", selectedBrand)
                    End If

                    adapter.Fill(dataTable)

                    ' Add a new column to indicate product availability
                    Dim availabilityColumn As New DataColumn("Available Stock", GetType(String))
                    dataTable.Columns.Add(availabilityColumn)

                    ' Determine availability based on available_stocks
                    For Each row As DataRow In dataTable.Rows
                        Dim availableStocks As Integer = Convert.ToInt32(row("available_stocks"))

                        If availableStocks > 0 Then
                            row("Available Stock") = "Available"
                        Else
                            row("Available Stock") = "Not Available"
                        End If
                    Next

                    ' Bind the DataTable to the DataGridView
                    productDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub refresh()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation, search condition, date filter, and unit filter
                Dim selectQuery As String = $"SELECT id, row_number() over() as IDs, product_name, brand_name, description, unit, date, available_stocks FROM motorshop_db.products "
                Using adapter As New MySqlDataAdapter(selectQuery, conn)


                    adapter.Fill(dataTable)

                    ' Add a new column to indicate product availability
                    Dim availabilityColumn As New DataColumn("Available Stock", GetType(String))
                    dataTable.Columns.Add(availabilityColumn)

                    ' Determine availability based on available_stocks
                    For Each row As DataRow In dataTable.Rows
                        Dim availableStocks As Integer = Convert.ToInt32(row("available_stocks"))

                        If availableStocks > 0 Then
                            row("Available Stock") = "Available"
                        Else
                            row("Available Stock") = "Not Available"
                        End If
                    Next

                    ' Bind the DataTable to the DataGridView
                    productDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub productSearch_TextChanged(sender As Object, e As EventArgs) Handles productSearch.TextChanged
        productDatagridView(productSearch.Text, getBrand.Text)



    End Sub

    Private Sub getDate_ValueChanged(sender As Object, e As EventArgs) Handles getDate.ValueChanged
        ' Use Using statement for automatic resource disposal
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
                Dim selectQuery As String = $"SELECT id, row_number() over() as IDs, product_name, brand_name, description, unit, date, available_stocks FROM motorshop_db.products  " &
                                              "WHERE MONTH(date) = @selectedMonth AND YEAR(date) = @selectedYear "

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedMonth", selectedMonth)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedYear", selectedYear)


                    adapter.Fill(dataTable)

                    Dim availabilityColumn As New DataColumn("Available Stock", GetType(String))
                    dataTable.Columns.Add(availabilityColumn)

                    ' Determine availability based on available_stocks
                    For Each row As DataRow In dataTable.Rows
                        Dim availableStocks As Integer = Convert.ToInt32(row("available_stocks"))

                        If availableStocks > 0 Then
                            row("Available Stock") = "Available"
                        Else
                            row("Available Stock") = "Not Available"
                        End If
                    Next


                    ' Bind the DataTable to the DataGridView
                    productDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub getUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles getBrand.SelectedIndexChanged
        productDatagridView(productSearch.Text, getBrand.Text)

    End Sub

    Private Sub PopulateBrandComboBox()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Clear existing items in the ComboBox
                getBrand.Items.Clear()

                ' Add an empty string as the default value
                getBrand.Items.Add("")

                ' Fetch distinct brand values from the products table
                Dim selectBrandQuery As String = "SELECT DISTINCT brand_name FROM motorshop_db.products"
                Using cmd As New MySqlCommand(selectBrandQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Add each brand value to the ComboBox
                        While reader.Read()
                            getBrand.Items.Add(reader("brand_name").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading brand data: " & ex.Message)
            End Try
        End Using
    End Sub

End Class