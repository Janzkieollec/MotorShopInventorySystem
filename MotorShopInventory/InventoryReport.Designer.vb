<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryReport
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        invetorySearch = New Guna.UI2.WinForms.Guna2TextBox()
        inventoryDatgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        cmbSelect = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(inventoryDatgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(23, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(203, 25)
        Guna2HtmlLabel2.TabIndex = 22
        Guna2HtmlLabel2.Text = "Inventory & Report List"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(378, 54)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(50, 19)
        Guna2HtmlLabel1.TabIndex = 19
        Guna2HtmlLabel1.Text = "Search:"
        ' 
        ' invetorySearch
        ' 
        invetorySearch.BorderRadius = 5
        invetorySearch.CustomizableEdges = CustomizableEdges1
        invetorySearch.DefaultText = ""
        invetorySearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        invetorySearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        invetorySearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        invetorySearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        invetorySearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        invetorySearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        invetorySearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        invetorySearch.Location = New Point(429, 50)
        invetorySearch.Name = "invetorySearch"
        invetorySearch.PasswordChar = ChrW(0)
        invetorySearch.PlaceholderText = ""
        invetorySearch.SelectedText = ""
        invetorySearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        invetorySearch.Size = New Size(200, 29)
        invetorySearch.TabIndex = 18
        ' 
        ' inventoryDatgrid
        ' 
        inventoryDatgrid.AllowUserToAddRows = False
        inventoryDatgrid.AllowUserToDeleteRows = False
        inventoryDatgrid.AllowUserToResizeColumns = False
        inventoryDatgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        inventoryDatgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        inventoryDatgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        inventoryDatgrid.ColumnHeadersHeight = 36
        inventoryDatgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        inventoryDatgrid.DefaultCellStyle = DataGridViewCellStyle3
        inventoryDatgrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        inventoryDatgrid.Location = New Point(23, 85)
        inventoryDatgrid.Name = "inventoryDatgrid"
        inventoryDatgrid.ReadOnly = True
        inventoryDatgrid.RowHeadersVisible = False
        inventoryDatgrid.RowTemplate.Height = 25
        inventoryDatgrid.Size = New Size(606, 351)
        inventoryDatgrid.TabIndex = 17
        inventoryDatgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        inventoryDatgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        inventoryDatgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        inventoryDatgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        inventoryDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        inventoryDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        inventoryDatgrid.ThemeStyle.BackColor = Color.White
        inventoryDatgrid.ThemeStyle.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        inventoryDatgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        inventoryDatgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        inventoryDatgrid.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        inventoryDatgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        inventoryDatgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        inventoryDatgrid.ThemeStyle.HeaderStyle.Height = 36
        inventoryDatgrid.ThemeStyle.ReadOnly = True
        inventoryDatgrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        inventoryDatgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        inventoryDatgrid.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        inventoryDatgrid.ThemeStyle.RowsStyle.ForeColor = Color.Black
        inventoryDatgrid.ThemeStyle.RowsStyle.Height = 25
        inventoryDatgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        inventoryDatgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' cmbSelect
        ' 
        cmbSelect.BackColor = Color.Transparent
        cmbSelect.BorderRadius = 5
        cmbSelect.CustomizableEdges = CustomizableEdges3
        cmbSelect.DrawMode = DrawMode.OwnerDrawFixed
        cmbSelect.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSelect.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbSelect.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbSelect.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        cmbSelect.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbSelect.IntegralHeight = False
        cmbSelect.ItemHeight = 22
        cmbSelect.Items.AddRange(New Object() {"Products", "Stocks Record"})
        cmbSelect.Location = New Point(72, 51)
        cmbSelect.Name = "cmbSelect"
        cmbSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cmbSelect.Size = New Size(200, 28)
        cmbSelect.TabIndex = 23
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(23, 54)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(45, 19)
        Guna2HtmlLabel3.TabIndex = 24
        Guna2HtmlLabel3.Text = "Select:"
        ' 
        ' InventoryReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(653, 471)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(cmbSelect)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(invetorySearch)
        Controls.Add(inventoryDatgrid)
        FormBorderStyle = FormBorderStyle.None
        Name = "InventoryReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InventoryReport"
        CType(inventoryDatgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents invetorySearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents inventoryDatgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbSelect As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ids As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents productname As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents units As DataGridViewTextBoxColumn
    Friend WithEvents dated As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
End Class
