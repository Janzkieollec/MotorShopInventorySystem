<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDashboard
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userDashboard))
        Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        productDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        no = New DataGridViewTextBoxColumn()
        products = New DataGridViewTextBoxColumn()
        Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        PictureBox1 = New PictureBox()
        newProduct = New Guna.UI2.WinForms.Guna2HtmlLabel()
        totalProduct = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2GroupBox3.SuspendLayout()
        CType(productDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        Guna2GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2GroupBox3
        ' 
        Guna2GroupBox3.BorderThickness = 0
        Guna2GroupBox3.Controls.Add(productDatagrid)
        Guna2GroupBox3.CustomBorderColor = Color.Black
        Guna2GroupBox3.CustomBorderThickness = New Padding(0)
        Guna2GroupBox3.CustomizableEdges = CustomizableEdges1
        Guna2GroupBox3.FillColor = Color.PaleGreen
        Guna2GroupBox3.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GroupBox3.ForeColor = SystemColors.ControlText
        Guna2GroupBox3.Location = New Point(361, 60)
        Guna2GroupBox3.Name = "Guna2GroupBox3"
        Guna2GroupBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GroupBox3.ShadowDecoration.Depth = 15
        Guna2GroupBox3.ShadowDecoration.Enabled = True
        Guna2GroupBox3.ShadowDecoration.Shadow = New Padding(10, 3, 4, 7)
        Guna2GroupBox3.Size = New Size(262, 154)
        Guna2GroupBox3.TabIndex = 38
        Guna2GroupBox3.Text = "New Product Arrived"
        ' 
        ' productDatagrid
        ' 
        productDatagrid.AllowUserToAddRows = False
        productDatagrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        productDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        DataGridViewCellStyle2.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        productDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        productDatagrid.ColumnHeadersHeight = 20
        productDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        productDatagrid.Columns.AddRange(New DataGridViewColumn() {no, products})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        productDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        productDatagrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        productDatagrid.Location = New Point(0, 36)
        productDatagrid.Name = "productDatagrid"
        productDatagrid.ReadOnly = True
        productDatagrid.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        productDatagrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        productDatagrid.RowTemplate.Height = 25
        productDatagrid.Size = New Size(262, 176)
        productDatagrid.TabIndex = 36
        productDatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        productDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        productDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        productDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        productDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        productDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        productDatagrid.ThemeStyle.BackColor = Color.White
        productDatagrid.ThemeStyle.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        productDatagrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        productDatagrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        productDatagrid.ThemeStyle.HeaderStyle.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        productDatagrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        productDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        productDatagrid.ThemeStyle.HeaderStyle.Height = 20
        productDatagrid.ThemeStyle.ReadOnly = True
        productDatagrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        productDatagrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        productDatagrid.ThemeStyle.RowsStyle.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        productDatagrid.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText
        productDatagrid.ThemeStyle.RowsStyle.Height = 25
        productDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        productDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' no
        ' 
        no.DataPropertyName = "id"
        no.HeaderText = "No."
        no.Name = "no"
        no.ReadOnly = True
        ' 
        ' products
        ' 
        products.DataPropertyName = "product_name"
        products.HeaderText = "Product Name"
        products.Name = "products"
        products.ReadOnly = True
        ' 
        ' Guna2GroupBox1
        ' 
        Guna2GroupBox1.BorderThickness = 0
        Guna2GroupBox1.Controls.Add(PictureBox1)
        Guna2GroupBox1.Controls.Add(newProduct)
        Guna2GroupBox1.Controls.Add(totalProduct)
        Guna2GroupBox1.CustomBorderColor = Color.Black
        Guna2GroupBox1.CustomBorderThickness = New Padding(0)
        Guna2GroupBox1.CustomizableEdges = CustomizableEdges3
        Guna2GroupBox1.FillColor = Color.FromArgb(CByte(199), CByte(249), CByte(204))
        Guna2GroupBox1.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GroupBox1.ForeColor = SystemColors.ControlText
        Guna2GroupBox1.Location = New Point(35, 59)
        Guna2GroupBox1.Name = "Guna2GroupBox1"
        Guna2GroupBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GroupBox1.ShadowDecoration.Depth = 15
        Guna2GroupBox1.ShadowDecoration.Enabled = True
        Guna2GroupBox1.ShadowDecoration.Shadow = New Padding(10, 3, 4, 7)
        Guna2GroupBox1.Size = New Size(262, 154)
        Guna2GroupBox1.TabIndex = 37
        Guna2GroupBox1.Text = "Product"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(131, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' newProduct
        ' 
        newProduct.BackColor = Color.Transparent
        newProduct.Font = New Font("Bahnschrift", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        newProduct.Location = New Point(11, 125)
        newProduct.Name = "newProduct"
        newProduct.Size = New Size(69, 15)
        newProduct.TabIndex = 30
        newProduct.Text = "Total Product"
        ' 
        ' totalProduct
        ' 
        totalProduct.BackColor = Color.Transparent
        totalProduct.Font = New Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        totalProduct.Location = New Point(23, 44)
        totalProduct.Name = "totalProduct"
        totalProduct.Size = New Size(62, 35)
        totalProduct.TabIndex = 27
        totalProduct.Text = "Total"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(12, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(105, 25)
        Guna2HtmlLabel2.TabIndex = 36
        Guna2HtmlLabel2.Text = "Dashboard"
        ' 
        ' userDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(653, 471)
        Controls.Add(Guna2GroupBox3)
        Controls.Add(Guna2GroupBox1)
        Controls.Add(Guna2HtmlLabel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "userDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "userDashboard"
        Guna2GroupBox3.ResumeLayout(False)
        CType(productDatagrid, ComponentModel.ISupportInitialize).EndInit()
        Guna2GroupBox1.ResumeLayout(False)
        Guna2GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents productDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents products As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents newProduct As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents totalProduct As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
