<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PalmTreeLibraryMainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PalmTreeLibraryMainWindow))
        Me.PalmTreePartsLibraryMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsAndSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsAndEuipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PalmTreePartsLibraryMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.PalmTreePartsCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.PalmTreePartsChecklistAddButton = New System.Windows.Forms.Button()
        Me.PalmTreePartsCheckListTextBox = New System.Windows.Forms.TextBox()
        Me.PalmTreePartsLibraryMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PalmTreePartsLibraryMenuStrip
        '
        Me.PalmTreePartsLibraryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.PalmTreePartsLibraryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.PalmTreePartsLibraryMenuStrip.Name = "PalmTreePartsLibraryMenuStrip"
        Me.PalmTreePartsLibraryMenuStrip.Size = New System.Drawing.Size(817, 24)
        Me.PalmTreePartsLibraryMenuStrip.TabIndex = 0
        Me.PalmTreePartsLibraryMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactsAndSuppliersToolStripMenuItem, Me.PartsToolStripMenuItem, Me.ToolsAndEuipmentToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ContactsAndSuppliersToolStripMenuItem
        '
        Me.ContactsAndSuppliersToolStripMenuItem.Name = "ContactsAndSuppliersToolStripMenuItem"
        Me.ContactsAndSuppliersToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ContactsAndSuppliersToolStripMenuItem.Text = "Contacts and Suppliers"
        '
        'PartsToolStripMenuItem
        '
        Me.PartsToolStripMenuItem.Name = "PartsToolStripMenuItem"
        Me.PartsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PartsToolStripMenuItem.Text = "Parts"
        '
        'ToolsAndEuipmentToolStripMenuItem
        '
        Me.ToolsAndEuipmentToolStripMenuItem.Name = "ToolsAndEuipmentToolStripMenuItem"
        Me.ToolsAndEuipmentToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ToolsAndEuipmentToolStripMenuItem.Text = "Tools and Euipment"
        '
        'VehiclesToolStripMenuItem
        '
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'PalmTreePartsLibraryMonthCalendar
        '
        Me.PalmTreePartsLibraryMonthCalendar.Location = New System.Drawing.Point(572, 33)
        Me.PalmTreePartsLibraryMonthCalendar.Name = "PalmTreePartsLibraryMonthCalendar"
        Me.PalmTreePartsLibraryMonthCalendar.TabIndex = 1
        '
        'PalmTreePartsCheckedListBox
        '
        Me.PalmTreePartsCheckedListBox.FormattingEnabled = True
        Me.PalmTreePartsCheckedListBox.Location = New System.Drawing.Point(679, 207)
        Me.PalmTreePartsCheckedListBox.Name = "PalmTreePartsCheckedListBox"
        Me.PalmTreePartsCheckedListBox.Size = New System.Drawing.Size(120, 184)
        Me.PalmTreePartsCheckedListBox.TabIndex = 3
        '
        'PalmTreePartsChecklistAddButton
        '
        Me.PalmTreePartsChecklistAddButton.Location = New System.Drawing.Point(573, 233)
        Me.PalmTreePartsChecklistAddButton.Name = "PalmTreePartsChecklistAddButton"
        Me.PalmTreePartsChecklistAddButton.Size = New System.Drawing.Size(75, 23)
        Me.PalmTreePartsChecklistAddButton.TabIndex = 7
        Me.PalmTreePartsChecklistAddButton.Text = "Add"
        Me.PalmTreePartsChecklistAddButton.UseVisualStyleBackColor = True
        '
        'PalmTreePartsCheckListTextBox
        '
        Me.PalmTreePartsCheckListTextBox.Location = New System.Drawing.Point(573, 207)
        Me.PalmTreePartsCheckListTextBox.Name = "PalmTreePartsCheckListTextBox"
        Me.PalmTreePartsCheckListTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PalmTreePartsCheckListTextBox.TabIndex = 8
        '
        'PalmTreeLibraryMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(817, 409)
        Me.Controls.Add(Me.PalmTreePartsCheckListTextBox)
        Me.Controls.Add(Me.PalmTreePartsChecklistAddButton)
        Me.Controls.Add(Me.PalmTreePartsCheckedListBox)
        Me.Controls.Add(Me.PalmTreePartsLibraryMonthCalendar)
        Me.Controls.Add(Me.PalmTreePartsLibraryMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.PalmTreePartsLibraryMenuStrip
        Me.MaximizeBox = False
        Me.Name = "PalmTreeLibraryMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PalmTree Library"
        Me.PalmTreePartsLibraryMenuStrip.ResumeLayout(False)
        Me.PalmTreePartsLibraryMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PalmTreePartsLibraryMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PalmTreePartsLibraryMonthCalendar As MonthCalendar
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PalmTreePartsCheckedListBox As CheckedListBox
    Friend WithEvents PalmTreePartsChecklistAddButton As Button
    Friend WithEvents PalmTreePartsCheckListTextBox As TextBox
    Friend WithEvents PartsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsAndEuipmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsAndSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
