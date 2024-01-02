<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        stockSearch = New Guna.UI2.WinForms.Guna2TextBox()
        stockDatgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        product_name = New DataGridViewTextBoxColumn()
        description = New DataGridViewTextBoxColumn()
        Unit = New DataGridViewTextBoxColumn()
        data = New DataGridViewTextBoxColumn()
        stocks = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        getUnit = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        getDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(stockDatgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(23, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(86, 25)
        Guna2HtmlLabel2.TabIndex = 22
        Guna2HtmlLabel2.Text = "Stock List"
        ' 
        ' btnAdd
        ' 
        btnAdd.BorderRadius = 5
        btnAdd.CustomizableEdges = CustomizableEdges1
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.MediumSeaGreen
        btnAdd.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Black
        btnAdd.Location = New Point(501, 421)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAdd.Size = New Size(128, 37)
        btnAdd.TabIndex = 21
        btnAdd.Text = "Add Item"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Transparent
        btnUpdate.BorderRadius = 5
        btnUpdate.CustomizableEdges = CustomizableEdges3
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.FillColor = Color.MediumSeaGreen
        btnUpdate.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(367, 421)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnUpdate.Size = New Size(128, 37)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "Update Item"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(377, 47)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(50, 19)
        Guna2HtmlLabel1.TabIndex = 19
        Guna2HtmlLabel1.Text = "Search:"
        ' 
        ' stockSearch
        ' 
        stockSearch.BorderRadius = 5
        stockSearch.CustomizableEdges = CustomizableEdges5
        stockSearch.DefaultText = ""
        stockSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        stockSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        stockSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        stockSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        stockSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        stockSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        stockSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        stockSearch.Location = New Point(428, 43)
        stockSearch.Name = "stockSearch"
        stockSearch.PasswordChar = ChrW(0)
        stockSearch.PlaceholderText = ""
        stockSearch.SelectedText = ""
        stockSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        stockSearch.Size = New Size(200, 29)
        stockSearch.TabIndex = 18
        ' 
        ' stockDatgrid
        ' 
        stockDatgrid.AllowUserToAddRows = False
        stockDatgrid.AllowUserToDeleteRows = False
        stockDatgrid.AllowUserToResizeColumns = False
        stockDatgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        stockDatgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        stockDatgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        stockDatgrid.ColumnHeadersHeight = 36
        stockDatgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        stockDatgrid.Columns.AddRange(New DataGridViewColumn() {ID, product_name, description, Unit, data, stocks})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        stockDatgrid.DefaultCellStyle = DataGridViewCellStyle3
        stockDatgrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        stockDatgrid.Location = New Point(23, 78)
        stockDatgrid.Name = "stockDatgrid"
        stockDatgrid.ReadOnly = True
        stockDatgrid.RowHeadersVisible = False
        stockDatgrid.RowTemplate.Height = 25
        stockDatgrid.Size = New Size(606, 325)
        stockDatgrid.TabIndex = 17
        stockDatgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        stockDatgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        stockDatgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        stockDatgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        stockDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        stockDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        stockDatgrid.ThemeStyle.BackColor = Color.White
        stockDatgrid.ThemeStyle.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        stockDatgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        stockDatgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        stockDatgrid.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        stockDatgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        stockDatgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        stockDatgrid.ThemeStyle.HeaderStyle.Height = 36
        stockDatgrid.ThemeStyle.ReadOnly = True
        stockDatgrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        stockDatgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        stockDatgrid.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        stockDatgrid.ThemeStyle.RowsStyle.ForeColor = Color.Black
        stockDatgrid.ThemeStyle.RowsStyle.Height = 25
        stockDatgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        stockDatgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' ID
        ' 
        ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID.DataPropertyName = "id"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Width = 157
        ' 
        ' product_name
        ' 
        product_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        product_name.DataPropertyName = "product_name"
        product_name.HeaderText = "Product Name"
        product_name.Name = "product_name"
        product_name.ReadOnly = True
        product_name.Width = 157
        ' 
        ' description
        ' 
        description.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        description.DataPropertyName = "description"
        description.HeaderText = "Description"
        description.Name = "description"
        description.ReadOnly = True
        description.Width = 103
        ' 
        ' Unit
        ' 
        Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Unit.DataPropertyName = "unit"
        Unit.HeaderText = "Unit"
        Unit.Name = "Unit"
        Unit.ReadOnly = True
        Unit.Width = 55
        ' 
        ' data
        ' 
        data.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        data.DataPropertyName = "date"
        data.HeaderText = "Date"
        data.Name = "data"
        data.ReadOnly = True
        data.Width = 63
        ' 
        ' stocks
        ' 
        stocks.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        stocks.DataPropertyName = "stocks"
        stocks.HeaderText = "Stocks"
        stocks.Name = "stocks"
        stocks.ReadOnly = True
        stocks.Width = 71
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel4.Location = New Point(194, 47)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(31, 19)
        Guna2HtmlLabel4.TabIndex = 26
        Guna2HtmlLabel4.Text = "Unit:"
        ' 
        ' getUnit
        ' 
        getUnit.BackColor = Color.Transparent
        getUnit.BorderRadius = 5
        getUnit.CustomizableEdges = CustomizableEdges7
        getUnit.DrawMode = DrawMode.OwnerDrawFixed
        getUnit.DropDownStyle = ComboBoxStyle.DropDownList
        getUnit.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        getUnit.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        getUnit.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        getUnit.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        getUnit.ItemHeight = 22
        getUnit.Location = New Point(231, 43)
        getUnit.Name = "getUnit"
        getUnit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        getUnit.Size = New Size(140, 28)
        getUnit.TabIndex = 25
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(22, 47)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(39, 19)
        Guna2HtmlLabel3.TabIndex = 24
        Guna2HtmlLabel3.Text = "Date:"
        ' 
        ' getDate
        ' 
        getDate.BorderRadius = 5
        getDate.Checked = True
        getDate.CustomizableEdges = CustomizableEdges9
        getDate.FillColor = Color.LightGreen
        getDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        getDate.Format = DateTimePickerFormat.Short
        getDate.Location = New Point(67, 43)
        getDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        getDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        getDate.Name = "getDate"
        getDate.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        getDate.Size = New Size(120, 29)
        getDate.TabIndex = 23
        getDate.Value = New Date(2023, 12, 30, 17, 16, 12, 574)
        ' 
        ' stock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(653, 471)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(getUnit)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(getDate)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(stockSearch)
        Controls.Add(stockDatgrid)
        FormBorderStyle = FormBorderStyle.None
        Name = "stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "stock"
        CType(stockDatgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents stockSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents stockDatgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents stocks As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents getUnit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents getDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
