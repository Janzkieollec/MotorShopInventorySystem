<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class products
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
        productSearch = New Guna.UI2.WinForms.Guna2TextBox()
        productDatgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        ids = New DataGridViewTextBoxColumn()
        brand = New DataGridViewTextBoxColumn()
        productname = New DataGridViewTextBoxColumn()
        description = New DataGridViewTextBoxColumn()
        units = New DataGridViewTextBoxColumn()
        dated = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        getDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        getUnit = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(productDatgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(23, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(106, 25)
        Guna2HtmlLabel2.TabIndex = 16
        Guna2HtmlLabel2.Text = "Product List"
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
        btnAdd.TabIndex = 15
        btnAdd.Text = "Add Item"
        ' 
        ' btnUpdate
        ' 
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
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update Item"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(379, 47)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(50, 19)
        Guna2HtmlLabel1.TabIndex = 13
        Guna2HtmlLabel1.Text = "Search:"
        ' 
        ' productSearch
        ' 
        productSearch.BorderRadius = 5
        productSearch.CustomizableEdges = CustomizableEdges5
        productSearch.DefaultText = ""
        productSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        productSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        productSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        productSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        productSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        productSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        productSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        productSearch.Location = New Point(430, 43)
        productSearch.Name = "productSearch"
        productSearch.PasswordChar = ChrW(0)
        productSearch.PlaceholderText = ""
        productSearch.SelectedText = ""
        productSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        productSearch.Size = New Size(200, 29)
        productSearch.TabIndex = 12
        ' 
        ' productDatgrid
        ' 
        productDatgrid.AllowUserToAddRows = False
        productDatgrid.AllowUserToDeleteRows = False
        productDatgrid.AllowUserToResizeColumns = False
        productDatgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        productDatgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        productDatgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        productDatgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        productDatgrid.ColumnHeadersHeight = 36
        productDatgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        productDatgrid.Columns.AddRange(New DataGridViewColumn() {ids, brand, productname, description, units, dated, quantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        productDatgrid.DefaultCellStyle = DataGridViewCellStyle3
        productDatgrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        productDatgrid.Location = New Point(23, 78)
        productDatgrid.Name = "productDatgrid"
        productDatgrid.ReadOnly = True
        productDatgrid.RowHeadersVisible = False
        productDatgrid.RowTemplate.Height = 25
        productDatgrid.Size = New Size(606, 325)
        productDatgrid.TabIndex = 11
        productDatgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        productDatgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        productDatgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        productDatgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        productDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        productDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        productDatgrid.ThemeStyle.BackColor = Color.White
        productDatgrid.ThemeStyle.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        productDatgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        productDatgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        productDatgrid.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        productDatgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        productDatgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        productDatgrid.ThemeStyle.HeaderStyle.Height = 36
        productDatgrid.ThemeStyle.ReadOnly = True
        productDatgrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        productDatgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        productDatgrid.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        productDatgrid.ThemeStyle.RowsStyle.ForeColor = Color.Black
        productDatgrid.ThemeStyle.RowsStyle.Height = 25
        productDatgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        productDatgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' ids
        ' 
        ids.DataPropertyName = "id"
        ids.HeaderText = "ID"
        ids.Name = "ids"
        ids.ReadOnly = True
        ids.Width = 44
        ' 
        ' brand
        ' 
        brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        brand.DataPropertyName = "brand_name"
        brand.HeaderText = "Brand Name"
        brand.Name = "brand"
        brand.ReadOnly = True
        ' 
        ' productname
        ' 
        productname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        productname.DataPropertyName = "product_name"
        productname.HeaderText = "Product Name"
        productname.Name = "productname"
        productname.ReadOnly = True
        ' 
        ' description
        ' 
        description.DataPropertyName = "description"
        description.HeaderText = "Description"
        description.Name = "description"
        description.ReadOnly = True
        description.Width = 103
        ' 
        ' units
        ' 
        units.DataPropertyName = "unit"
        units.HeaderText = "Unit"
        units.Name = "units"
        units.ReadOnly = True
        units.Width = 55
        ' 
        ' dated
        ' 
        dated.DataPropertyName = "date"
        dated.HeaderText = "Date"
        dated.Name = "dated"
        dated.ReadOnly = True
        dated.Width = 63
        ' 
        ' quantity
        ' 
        quantity.DataPropertyName = "quantity"
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        quantity.Width = 86
        ' 
        ' getDate
        ' 
        getDate.BorderRadius = 5
        getDate.Checked = True
        getDate.CustomizableEdges = CustomizableEdges7
        getDate.FillColor = Color.LightGreen
        getDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        getDate.Format = DateTimePickerFormat.Short
        getDate.Location = New Point(69, 43)
        getDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        getDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        getDate.Name = "getDate"
        getDate.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        getDate.Size = New Size(120, 29)
        getDate.TabIndex = 17
        getDate.Value = New Date(2023, 12, 30, 17, 16, 12, 574)
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(24, 47)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(39, 19)
        Guna2HtmlLabel3.TabIndex = 18
        Guna2HtmlLabel3.Text = "Date:"
        ' 
        ' getUnit
        ' 
        getUnit.BackColor = Color.Transparent
        getUnit.BorderRadius = 5
        getUnit.CustomizableEdges = CustomizableEdges9
        getUnit.DrawMode = DrawMode.OwnerDrawFixed
        getUnit.DropDownStyle = ComboBoxStyle.DropDownList
        getUnit.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        getUnit.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        getUnit.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        getUnit.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        getUnit.ItemHeight = 22
        getUnit.Location = New Point(233, 43)
        getUnit.Name = "getUnit"
        getUnit.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        getUnit.Size = New Size(140, 28)
        getUnit.TabIndex = 19
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel4.Location = New Point(196, 47)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(31, 19)
        Guna2HtmlLabel4.TabIndex = 20
        Guna2HtmlLabel4.Text = "Unit:"
        ' 
        ' products
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
        Controls.Add(productSearch)
        Controls.Add(productDatgrid)
        FormBorderStyle = FormBorderStyle.None
        Name = "products"
        StartPosition = FormStartPosition.CenterScreen
        Text = "products"
        CType(productDatgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents productSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents productDatgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents ids As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents productname As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents units As DataGridViewTextBoxColumn
    Friend WithEvents dated As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents getDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents getUnit As Guna.UI2.WinForms.Guna2ComboBox
End Class
