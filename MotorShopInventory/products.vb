Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class products
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=motorshop_db;"

    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productDatagridView(productSearch.Text, getUnit.Text)
        PopulateUnitComboBox()
        getDate.Value = DateAndTime.Today
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddItem As New AddItem
        frmAddItem.Location = New Point((WorkingArea.Width - frmAddItem.Width) / 2, 0)
        tranparent.ShowForm(frmAddItem)

        productDatagridView(productSearch.Text, getUnit.Text)

    End Sub

    'Handler for Update Item
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim productId As Integer = GetSelectedProductId()

        ' Check if a valid productId is returned
        If productId <> -1 Then
            Dim frmUpdateItem As New UpdateItem(productId)
            frmUpdateItem.Location = New Point((Screen.GetWorkingArea(Me).Width - frmUpdateItem.Width) / 2, 0)
            tranparent.ShowForm(frmUpdateItem)

            ' Refresh the Product datagrid
            productDatagridView(productSearch.Text, getUnit.Text)


        End If
    End Sub

    Private Function GetSelectedProductId() As Integer
        If productDatgrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = productDatgrid.SelectedRows(0)
            Dim productId As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)
            Return productId
        Else
            MessageBox.Show("No record selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return -1 ' Or any other value indicating that no record is selected
        End If
    End Function


    'function for product list

    ' Function for product list with date filter
    Public Sub productDatagridView(searchText As String, selectedUnit As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation, search condition, date filter, and unit filter
                Dim selectQuery As String = $"SELECT p.id, s.brand_name, s.description, s.unit, p.date, s.product_name, p.quantity FROM motorshop_db.products p " &
                                             "INNER JOIN motorshop_db.stocks s ON p.stock_id = s.id " &
                                             "WHERE CONCAT(p.id,' ',p.quantity, ' ', p.price) LIKE @searchText "

                ' Add unit filter condition if selectedUnit is provided
                If Not String.IsNullOrEmpty(selectedUnit) Then
                    selectQuery &= " AND s.unit = @selectedUnit"
                End If

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")

                    ' Add parameter for unit filter if selectedUnit is provided
                    If Not String.IsNullOrEmpty(selectedUnit) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@selectedUnit", selectedUnit)
                    End If

                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    productDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub productSearch_TextChanged(sender As Object, e As EventArgs) Handles productSearch.TextChanged
        productDatagridView(productSearch.Text, getUnit.Text)



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
                Dim selectQuery As String = $"SELECT p.id, s.brand_name, s.description, s.unit, p.date, s.product_name, p.quantity FROM motorshop_db.products p " &
                                             "INNER JOIN motorshop_db.stocks s ON p.stock_id = s.id " &
                                              "WHERE MONTH(p.date) = @selectedMonth AND YEAR(p.date) = @selectedYear "

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedMonth", selectedMonth)
                    adapter.SelectCommand.Parameters.AddWithValue("@selectedYear", selectedYear)


                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    productDatgrid.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub getUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles getUnit.SelectedIndexChanged
        productDatagridView(productSearch.Text, getUnit.Text)

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
End Class