<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountList
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
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        accountSearch = New Guna.UI2.WinForms.Guna2TextBox()
        accountDatgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        userId = New DataGridViewTextBoxColumn()
        name = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        position = New DataGridViewTextBoxColumn()
        CType(accountDatgrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(23, 12)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(113, 25)
        Guna2HtmlLabel2.TabIndex = 28
        Guna2HtmlLabel2.Text = "Account List"
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
        btnAdd.TabIndex = 27
        btnAdd.Text = "Add User"
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
        btnUpdate.TabIndex = 26
        btnUpdate.Text = "Update User"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(378, 16)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(50, 19)
        Guna2HtmlLabel1.TabIndex = 25
        Guna2HtmlLabel1.Text = "Search:"
        ' 
        ' accountSearch
        ' 
        accountSearch.BorderRadius = 5
        accountSearch.CustomizableEdges = CustomizableEdges5
        accountSearch.DefaultText = ""
        accountSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        accountSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        accountSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        accountSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        accountSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        accountSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        accountSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        accountSearch.Location = New Point(429, 12)
        accountSearch.Name = "accountSearch"
        accountSearch.PasswordChar = ChrW(0)
        accountSearch.PlaceholderText = ""
        accountSearch.SelectedText = ""
        accountSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        accountSearch.Size = New Size(200, 29)
        accountSearch.TabIndex = 24
        ' 
        ' accountDatgrid
        ' 
        accountDatgrid.AllowUserToAddRows = False
        accountDatgrid.AllowUserToDeleteRows = False
        accountDatgrid.AllowUserToResizeColumns = False
        accountDatgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        accountDatgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        accountDatgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        accountDatgrid.ColumnHeadersHeight = 36
        accountDatgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        accountDatgrid.Columns.AddRange(New DataGridViewColumn() {ID, userId, name, username, position})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        accountDatgrid.DefaultCellStyle = DataGridViewCellStyle3
        accountDatgrid.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        accountDatgrid.Location = New Point(23, 52)
        accountDatgrid.Name = "accountDatgrid"
        accountDatgrid.ReadOnly = True
        accountDatgrid.RowHeadersVisible = False
        accountDatgrid.RowTemplate.Height = 25
        accountDatgrid.Size = New Size(606, 351)
        accountDatgrid.TabIndex = 23
        accountDatgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        accountDatgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(185), CByte(226), CByte(218))
        accountDatgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        accountDatgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        accountDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        accountDatgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        accountDatgrid.ThemeStyle.BackColor = Color.White
        accountDatgrid.ThemeStyle.GridColor = Color.FromArgb(CByte(182), CByte(224), CByte(216))
        accountDatgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(22), CByte(160), CByte(133))
        accountDatgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        accountDatgrid.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        accountDatgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        accountDatgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        accountDatgrid.ThemeStyle.HeaderStyle.Height = 36
        accountDatgrid.ThemeStyle.ReadOnly = True
        accountDatgrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(208), CByte(235), CByte(230))
        accountDatgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        accountDatgrid.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        accountDatgrid.ThemeStyle.RowsStyle.ForeColor = Color.Black
        accountDatgrid.ThemeStyle.RowsStyle.Height = 25
        accountDatgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(99), CByte(191), CByte(173))
        accountDatgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' ID
        ' 
        ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID.DataPropertyName = "IDs"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Width = 157
        ' 
        ' userId
        ' 
        userId.DataPropertyName = "id"
        userId.HeaderText = "UserId"
        userId.Name = "userId"
        userId.ReadOnly = True
        userId.Visible = False
        ' 
        ' name
        ' 
        name.DataPropertyName = "name"
        name.HeaderText = "Name"
        name.Name = "name"
        name.ReadOnly = True
        ' 
        ' username
        ' 
        username.DataPropertyName = "username"
        username.HeaderText = "Username"
        username.Name = "username"
        username.ReadOnly = True
        ' 
        ' position
        ' 
        position.DataPropertyName = "position"
        position.HeaderText = "Position"
        position.Name = "position"
        position.ReadOnly = True
        ' 
        ' accountList
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(653, 471)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(accountSearch)
        Controls.Add(accountDatgrid)
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.CenterScreen
        Text = "accountList"
        CType(accountDatgrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents accountSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents accountDatgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents userId As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents position As DataGridViewTextBoxColumn
End Class
