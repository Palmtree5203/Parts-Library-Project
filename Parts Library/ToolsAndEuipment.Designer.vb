<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolsAndEuipmentMainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolsAndEuipmentMainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSaveListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.AddToolsAndEquipmentButton = New System.Windows.Forms.Button()
        Me.ToolsAndEquipmentListView = New System.Windows.Forms.ListView()
        Me.JunkColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaveListToolStripMenuItem, Me.OpenListToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewSaveListToolStripMenuItem
        '
        Me.NewSaveListToolStripMenuItem.Name = "NewSaveListToolStripMenuItem"
        Me.NewSaveListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewSaveListToolStripMenuItem.Text = "New/Save List"
        '
        'OpenListToolStripMenuItem
        '
        Me.OpenListToolStripMenuItem.Name = "OpenListToolStripMenuItem"
        Me.OpenListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenListToolStripMenuItem.Text = "Open List"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'AddToolsAndEquipmentButton
        '
        Me.AddToolsAndEquipmentButton.Location = New System.Drawing.Point(12, 350)
        Me.AddToolsAndEquipmentButton.Name = "AddToolsAndEquipmentButton"
        Me.AddToolsAndEquipmentButton.Size = New System.Drawing.Size(75, 23)
        Me.AddToolsAndEquipmentButton.TabIndex = 3
        Me.AddToolsAndEquipmentButton.Text = "Add"
        Me.AddToolsAndEquipmentButton.UseVisualStyleBackColor = True
        '
        'ToolsAndEquipmentListView
        '
        Me.ToolsAndEquipmentListView.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolsAndEquipmentListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.JunkColumnHeader, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ToolsAndEquipmentListView.GridLines = True
        Me.ToolsAndEquipmentListView.HideSelection = False
        Me.ToolsAndEquipmentListView.LabelEdit = True
        Me.ToolsAndEquipmentListView.Location = New System.Drawing.Point(12, 27)
        Me.ToolsAndEquipmentListView.Name = "ToolsAndEquipmentListView"
        Me.ToolsAndEquipmentListView.Size = New System.Drawing.Size(600, 181)
        Me.ToolsAndEquipmentListView.TabIndex = 4
        Me.ToolsAndEquipmentListView.UseCompatibleStateImageBehavior = False
        Me.ToolsAndEquipmentListView.View = System.Windows.Forms.View.Details
        '
        'JunkColumnHeader
        '
        Me.JunkColumnHeader.Text = "Junk"
        Me.JunkColumnHeader.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Make"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Model"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tool Type"
        Me.ColumnHeader3.Width = 71
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Serial/Part Number"
        Me.ColumnHeader4.Width = 104
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Shop Number"
        Me.ColumnHeader5.Width = 89
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Warranty Length"
        Me.ColumnHeader6.Width = 98
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Warranty Expiration Date"
        Me.ColumnHeader7.Width = 81
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Cost"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Purchase Date"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Current Status"
        '
        'ToolsAndEuipmentMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(624, 385)
        Me.Controls.Add(Me.ToolsAndEquipmentListView)
        Me.Controls.Add(Me.AddToolsAndEquipmentButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ToolsAndEuipmentMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToolsAndEuipment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents AddToolsAndEquipmentButton As Button
    Friend WithEvents ToolsAndEquipmentListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents JunkColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents OpenListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSaveListToolStripMenuItem As ToolStripMenuItem
End Class
