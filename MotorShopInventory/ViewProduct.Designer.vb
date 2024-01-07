<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProduct
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        inventoryDatgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        ID = New DataGridViewTextBoxColumn()
        product_name = New DataGridViewTextBoxColumn()
        Brand = New DataGridViewTextBoxColumn()
        description = New DataGridViewTextBoxColumn()
        unit = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        dates = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        CType(inventoryDatgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(24, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(64, 25)
        Guna2HtmlLabel2.TabIndex = 28
        Guna2HtmlLabel2.Text = "History"
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
        inventoryDatgrid.Columns.AddRange(New DataGridViewColumn() {ID, product_name, Brand, description, unit, quantity, dates, status})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        inventoryDatgrid.DefaultCellStyle = DataGridViewCellStyle3
        inventoryDatgrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        inventoryDatgrid.Location = New Point(24, 43)
        inventoryDatgrid.Name = "inventoryDatgrid"
        inventoryDatgrid.ReadOnly = True
        inventoryDatgrid.RowHeadersVisible = False
        inventoryDatgrid.RowTemplate.Height = 25
        inventoryDatgrid.Size = New Size(606, 385)
        inventoryDatgrid.TabIndex = 25
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
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(608, 0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(45, 29)
        Guna2ControlBox1.TabIndex = 29
        ' 
        ' ID
        ' 
        ID.DataPropertyName = "ID"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' product_name
        ' 
        product_name.DataPropertyName = "product_name"
        product_name.HeaderText = "Product Name"
        product_name.Name = "product_name"
        product_name.ReadOnly = True
        ' 
        ' Brand
        ' 
        Brand.DataPropertyName = "brand_name"
        Brand.HeaderText = "Brand "
        Brand.Name = "Brand"
        Brand.ReadOnly = True
        ' 
        ' description
        ' 
        description.DataPropertyName = "description"
        description.HeaderText = "Description"
        description.Name = "description"
        description.ReadOnly = True
        ' 
        ' unit
        ' 
        unit.DataPropertyName = "unit"
        unit.HeaderText = "Unit"
        unit.Name = "unit"
        unit.ReadOnly = True
        ' 
        ' quantity
        ' 
        quantity.DataPropertyName = "quantity"
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        ' 
        ' dates
        ' 
        dates.DataPropertyName = "date"
        dates.HeaderText = "Date"
        dates.Name = "dates"
        dates.ReadOnly = True
        ' 
        ' status
        ' 
        status.DataPropertyName = "status"
        status.HeaderText = "Status"
        status.Name = "status"
        status.ReadOnly = True
        ' 
        ' ViewProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(653, 471)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(inventoryDatgrid)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewProduct"
        CType(inventoryDatgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents inventoryDatgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents dates As DataGridViewTextBoxColumn
End Class
