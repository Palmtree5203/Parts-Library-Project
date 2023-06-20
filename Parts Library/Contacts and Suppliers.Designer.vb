<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactsandSuppliersMainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactsandSuppliersMainWindow))
        Me.ContactsAndSuppliersMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileContactsAndSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsContactsAndSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContactsAndSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsAndSuppliersListView = New System.Windows.Forms.ListView()
        Me.JunkColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BusinessOwnerRepColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BusinessNameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddressColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneNumber1ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneNumber2ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email1ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email2ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WebsiteLinkColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DetailsContactsAndSuppliersGroupBox = New System.Windows.Forms.GroupBox()
        Me.WebsiteLinkContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.Email2ContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.Email1ContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumber2ContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumber1ContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.AddressContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessNameContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessNameContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.WebsiteLinkContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.Email2ContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.Email1ContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.PhoneNumber2ContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.PhoneNumber1ContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.AddressContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel = New System.Windows.Forms.Label()
        Me.AddContactsAndSuppliersButton = New System.Windows.Forms.Button()
        Me.ControlsContactsAndSuppliersGroupBox = New System.Windows.Forms.GroupBox()
        Me.OpenContactsAndSuppliersButton = New System.Windows.Forms.Button()
        Me.SaveContactsAndSuppliersButton = New System.Windows.Forms.Button()
        Me.EditContactsAndSuppliersButton = New System.Windows.Forms.Button()
        Me.ContactsAndSuppliersSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ContactsAndSuppliersOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ContactsAndSuppliersPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.ContactsAndSuppliersPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ContactsAndSuppliersPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ContactsAndSuppliersMenuStrip.SuspendLayout()
        Me.DetailsContactsAndSuppliersGroupBox.SuspendLayout()
        Me.ControlsContactsAndSuppliersGroupBox.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactsAndSuppliersMenuStrip
        '
        Me.ContactsAndSuppliersMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContactsAndSuppliersToolStripMenuItem, Me.ToolsContactsAndSuppliersToolStripMenuItem, Me.HelpContactsAndSuppliersToolStripMenuItem})
        Me.ContactsAndSuppliersMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ContactsAndSuppliersMenuStrip.Name = "ContactsAndSuppliersMenuStrip"
        Me.ContactsAndSuppliersMenuStrip.Size = New System.Drawing.Size(832, 24)
        Me.ContactsAndSuppliersMenuStrip.TabIndex = 0
        Me.ContactsAndSuppliersMenuStrip.Text = "MenuStrip1"
        '
        'FileContactsAndSuppliersToolStripMenuItem
        '
        Me.FileContactsAndSuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileContactsAndSuppliersToolStripMenuItem.Name = "FileContactsAndSuppliersToolStripMenuItem"
        Me.FileContactsAndSuppliersToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileContactsAndSuppliersToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsContactsAndSuppliersToolStripMenuItem
        '
        Me.ToolsContactsAndSuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeBackgroundColorToolStripMenuItem})
        Me.ToolsContactsAndSuppliersToolStripMenuItem.Name = "ToolsContactsAndSuppliersToolStripMenuItem"
        Me.ToolsContactsAndSuppliersToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsContactsAndSuppliersToolStripMenuItem.Text = "Tools"
        '
        'ChangeBackgroundColorToolStripMenuItem
        '
        Me.ChangeBackgroundColorToolStripMenuItem.Name = "ChangeBackgroundColorToolStripMenuItem"
        Me.ChangeBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ChangeBackgroundColorToolStripMenuItem.Text = "Change Background Color"
        '
        'HelpContactsAndSuppliersToolStripMenuItem
        '
        Me.HelpContactsAndSuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HelpContactsAndSuppliersToolStripMenuItem.Name = "HelpContactsAndSuppliersToolStripMenuItem"
        Me.HelpContactsAndSuppliersToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpContactsAndSuppliersToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'ContactsAndSuppliersListView
        '
        Me.ContactsAndSuppliersListView.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ContactsAndSuppliersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.JunkColumnHeader, Me.BusinessOwnerRepColumnHeader, Me.BusinessNameColumnHeader, Me.AddressColumnHeader, Me.PhoneNumber1ColumnHeader, Me.PhoneNumber2ColumnHeader, Me.Email1ColumnHeader, Me.Email2ColumnHeader, Me.WebsiteLinkColumnHeader})
        Me.ContactsAndSuppliersListView.GridLines = True
        Me.ContactsAndSuppliersListView.HideSelection = False
        Me.ContactsAndSuppliersListView.LabelEdit = True
        Me.ContactsAndSuppliersListView.Location = New System.Drawing.Point(331, 27)
        Me.ContactsAndSuppliersListView.Name = "ContactsAndSuppliersListView"
        Me.ContactsAndSuppliersListView.Size = New System.Drawing.Size(489, 344)
        Me.ContactsAndSuppliersListView.TabIndex = 1
        Me.ContactsAndSuppliersListView.UseCompatibleStateImageBehavior = False
        Me.ContactsAndSuppliersListView.View = System.Windows.Forms.View.Details
        '
        'JunkColumnHeader
        '
        Me.JunkColumnHeader.Text = "Junk"
        Me.JunkColumnHeader.Width = 0
        '
        'BusinessOwnerRepColumnHeader
        '
        Me.BusinessOwnerRepColumnHeader.Text = "Business Owner/Rep"
        Me.BusinessOwnerRepColumnHeader.Width = 120
        '
        'BusinessNameColumnHeader
        '
        Me.BusinessNameColumnHeader.Text = "Business Name"
        Me.BusinessNameColumnHeader.Width = 100
        '
        'AddressColumnHeader
        '
        Me.AddressColumnHeader.Text = "Address"
        Me.AddressColumnHeader.Width = 100
        '
        'PhoneNumber1ColumnHeader
        '
        Me.PhoneNumber1ColumnHeader.Text = "Phone Number 1"
        Me.PhoneNumber1ColumnHeader.Width = 100
        '
        'PhoneNumber2ColumnHeader
        '
        Me.PhoneNumber2ColumnHeader.Text = "Phone Number 2"
        Me.PhoneNumber2ColumnHeader.Width = 100
        '
        'Email1ColumnHeader
        '
        Me.Email1ColumnHeader.Text = "Email 1"
        '
        'Email2ColumnHeader
        '
        Me.Email2ColumnHeader.Text = "Email 2"
        '
        'WebsiteLinkColumnHeader
        '
        Me.WebsiteLinkColumnHeader.Text = "Website/Link"
        Me.WebsiteLinkColumnHeader.Width = 80
        '
        'DetailsContactsAndSuppliersGroupBox
        '
        Me.DetailsContactsAndSuppliersGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.WebsiteLinkContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.Email2ContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.Email1ContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.PhoneNumber2ContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.PhoneNumber1ContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.AddressContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.BusinessNameContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.BusinessNameContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.WebsiteLinkContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.Email2ContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.Email1ContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.PhoneNumber2ContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.PhoneNumber1ContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.AddressContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Controls.Add(Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel)
        Me.DetailsContactsAndSuppliersGroupBox.Location = New System.Drawing.Point(12, 113)
        Me.DetailsContactsAndSuppliersGroupBox.Name = "DetailsContactsAndSuppliersGroupBox"
        Me.DetailsContactsAndSuppliersGroupBox.Size = New System.Drawing.Size(313, 258)
        Me.DetailsContactsAndSuppliersGroupBox.TabIndex = 2
        Me.DetailsContactsAndSuppliersGroupBox.TabStop = False
        Me.DetailsContactsAndSuppliersGroupBox.Text = "Details"
        '
        'WebsiteLinkContactsAndSuppliersTextBox
        '
        Me.WebsiteLinkContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 226)
        Me.WebsiteLinkContactsAndSuppliersTextBox.Name = "WebsiteLinkContactsAndSuppliersTextBox"
        Me.WebsiteLinkContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.WebsiteLinkContactsAndSuppliersTextBox.TabIndex = 15
        '
        'Email2ContactsAndSuppliersTextBox
        '
        Me.Email2ContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 195)
        Me.Email2ContactsAndSuppliersTextBox.Name = "Email2ContactsAndSuppliersTextBox"
        Me.Email2ContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Email2ContactsAndSuppliersTextBox.TabIndex = 14
        '
        'Email1ContactsAndSuppliersTextBox
        '
        Me.Email1ContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 168)
        Me.Email1ContactsAndSuppliersTextBox.Name = "Email1ContactsAndSuppliersTextBox"
        Me.Email1ContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Email1ContactsAndSuppliersTextBox.TabIndex = 13
        '
        'PhoneNumber2ContactsAndSuppliersTextBox
        '
        Me.PhoneNumber2ContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 139)
        Me.PhoneNumber2ContactsAndSuppliersTextBox.Name = "PhoneNumber2ContactsAndSuppliersTextBox"
        Me.PhoneNumber2ContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.PhoneNumber2ContactsAndSuppliersTextBox.TabIndex = 12
        '
        'PhoneNumber1ContactsAndSuppliersTextBox
        '
        Me.PhoneNumber1ContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 111)
        Me.PhoneNumber1ContactsAndSuppliersTextBox.Name = "PhoneNumber1ContactsAndSuppliersTextBox"
        Me.PhoneNumber1ContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.PhoneNumber1ContactsAndSuppliersTextBox.TabIndex = 11
        '
        'AddressContactsAndSuppliersTextBox
        '
        Me.AddressContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 84)
        Me.AddressContactsAndSuppliersTextBox.Name = "AddressContactsAndSuppliersTextBox"
        Me.AddressContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.AddressContactsAndSuppliersTextBox.TabIndex = 10
        '
        'BusinessNameContactsAndSuppliersTextBox
        '
        Me.BusinessNameContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 56)
        Me.BusinessNameContactsAndSuppliersTextBox.Name = "BusinessNameContactsAndSuppliersTextBox"
        Me.BusinessNameContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.BusinessNameContactsAndSuppliersTextBox.TabIndex = 9
        '
        'BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox
        '
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Location = New System.Drawing.Point(160, 26)
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Name = "BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox"
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Size = New System.Drawing.Size(147, 20)
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.TabIndex = 8
        '
        'BusinessNameContactsAndSuppliersLabel
        '
        Me.BusinessNameContactsAndSuppliersLabel.AutoSize = True
        Me.BusinessNameContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusinessNameContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 55)
        Me.BusinessNameContactsAndSuppliersLabel.Name = "BusinessNameContactsAndSuppliersLabel"
        Me.BusinessNameContactsAndSuppliersLabel.Size = New System.Drawing.Size(113, 18)
        Me.BusinessNameContactsAndSuppliersLabel.TabIndex = 7
        Me.BusinessNameContactsAndSuppliersLabel.Text = "Business Name"
        '
        'WebsiteLinkContactsAndSuppliersLabel
        '
        Me.WebsiteLinkContactsAndSuppliersLabel.AutoSize = True
        Me.WebsiteLinkContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsiteLinkContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 225)
        Me.WebsiteLinkContactsAndSuppliersLabel.Name = "WebsiteLinkContactsAndSuppliersLabel"
        Me.WebsiteLinkContactsAndSuppliersLabel.Size = New System.Drawing.Size(93, 18)
        Me.WebsiteLinkContactsAndSuppliersLabel.TabIndex = 6
        Me.WebsiteLinkContactsAndSuppliersLabel.Text = "Website/Link"
        '
        'Email2ContactsAndSuppliersLabel
        '
        Me.Email2ContactsAndSuppliersLabel.AutoSize = True
        Me.Email2ContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email2ContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 194)
        Me.Email2ContactsAndSuppliersLabel.Name = "Email2ContactsAndSuppliersLabel"
        Me.Email2ContactsAndSuppliersLabel.Size = New System.Drawing.Size(57, 18)
        Me.Email2ContactsAndSuppliersLabel.TabIndex = 5
        Me.Email2ContactsAndSuppliersLabel.Text = "Email 2"
        '
        'Email1ContactsAndSuppliersLabel
        '
        Me.Email1ContactsAndSuppliersLabel.AutoSize = True
        Me.Email1ContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email1ContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 167)
        Me.Email1ContactsAndSuppliersLabel.Name = "Email1ContactsAndSuppliersLabel"
        Me.Email1ContactsAndSuppliersLabel.Size = New System.Drawing.Size(57, 18)
        Me.Email1ContactsAndSuppliersLabel.TabIndex = 4
        Me.Email1ContactsAndSuppliersLabel.Text = "Email 1"
        '
        'PhoneNumber2ContactsAndSuppliersLabel
        '
        Me.PhoneNumber2ContactsAndSuppliersLabel.AutoSize = True
        Me.PhoneNumber2ContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumber2ContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 138)
        Me.PhoneNumber2ContactsAndSuppliersLabel.Name = "PhoneNumber2ContactsAndSuppliersLabel"
        Me.PhoneNumber2ContactsAndSuppliersLabel.Size = New System.Drawing.Size(120, 18)
        Me.PhoneNumber2ContactsAndSuppliersLabel.TabIndex = 3
        Me.PhoneNumber2ContactsAndSuppliersLabel.Text = "Phone Number 2"
        '
        'PhoneNumber1ContactsAndSuppliersLabel
        '
        Me.PhoneNumber1ContactsAndSuppliersLabel.AutoSize = True
        Me.PhoneNumber1ContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumber1ContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 110)
        Me.PhoneNumber1ContactsAndSuppliersLabel.Name = "PhoneNumber1ContactsAndSuppliersLabel"
        Me.PhoneNumber1ContactsAndSuppliersLabel.Size = New System.Drawing.Size(120, 18)
        Me.PhoneNumber1ContactsAndSuppliersLabel.TabIndex = 2
        Me.PhoneNumber1ContactsAndSuppliersLabel.Text = "Phone Number 1"
        '
        'AddressContactsAndSuppliersLabel
        '
        Me.AddressContactsAndSuppliersLabel.AutoSize = True
        Me.AddressContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 83)
        Me.AddressContactsAndSuppliersLabel.Name = "AddressContactsAndSuppliersLabel"
        Me.AddressContactsAndSuppliersLabel.Size = New System.Drawing.Size(62, 18)
        Me.AddressContactsAndSuppliersLabel.TabIndex = 1
        Me.AddressContactsAndSuppliersLabel.Text = "Address"
        '
        'BusinessOwnerRepresentativeNameContactsAndSuppliersLabel
        '
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.AutoSize = True
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.Location = New System.Drawing.Point(6, 25)
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.Name = "BusinessOwnerRepresentativeNameContactsAndSuppliersLabel"
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.Size = New System.Drawing.Size(148, 18)
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.TabIndex = 0
        Me.BusinessOwnerRepresentativeNameContactsAndSuppliersLabel.Text = "Business Owner/Rep"
        '
        'AddContactsAndSuppliersButton
        '
        Me.AddContactsAndSuppliersButton.Location = New System.Drawing.Point(9, 19)
        Me.AddContactsAndSuppliersButton.Name = "AddContactsAndSuppliersButton"
        Me.AddContactsAndSuppliersButton.Size = New System.Drawing.Size(75, 23)
        Me.AddContactsAndSuppliersButton.TabIndex = 16
        Me.AddContactsAndSuppliersButton.Text = "Add"
        Me.AddContactsAndSuppliersButton.UseVisualStyleBackColor = True
        '
        'ControlsContactsAndSuppliersGroupBox
        '
        Me.ControlsContactsAndSuppliersGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ControlsContactsAndSuppliersGroupBox.Controls.Add(Me.OpenContactsAndSuppliersButton)
        Me.ControlsContactsAndSuppliersGroupBox.Controls.Add(Me.SaveContactsAndSuppliersButton)
        Me.ControlsContactsAndSuppliersGroupBox.Controls.Add(Me.EditContactsAndSuppliersButton)
        Me.ControlsContactsAndSuppliersGroupBox.Controls.Add(Me.AddContactsAndSuppliersButton)
        Me.ControlsContactsAndSuppliersGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.ControlsContactsAndSuppliersGroupBox.Name = "ControlsContactsAndSuppliersGroupBox"
        Me.ControlsContactsAndSuppliersGroupBox.Size = New System.Drawing.Size(191, 80)
        Me.ControlsContactsAndSuppliersGroupBox.TabIndex = 3
        Me.ControlsContactsAndSuppliersGroupBox.TabStop = False
        Me.ControlsContactsAndSuppliersGroupBox.Text = "Controls"
        '
        'OpenContactsAndSuppliersButton
        '
        Me.OpenContactsAndSuppliersButton.Location = New System.Drawing.Point(107, 51)
        Me.OpenContactsAndSuppliersButton.Name = "OpenContactsAndSuppliersButton"
        Me.OpenContactsAndSuppliersButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenContactsAndSuppliersButton.TabIndex = 19
        Me.OpenContactsAndSuppliersButton.Text = "Open"
        Me.OpenContactsAndSuppliersButton.UseVisualStyleBackColor = True
        '
        'SaveContactsAndSuppliersButton
        '
        Me.SaveContactsAndSuppliersButton.Location = New System.Drawing.Point(107, 19)
        Me.SaveContactsAndSuppliersButton.Name = "SaveContactsAndSuppliersButton"
        Me.SaveContactsAndSuppliersButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveContactsAndSuppliersButton.TabIndex = 18
        Me.SaveContactsAndSuppliersButton.Text = "Save"
        Me.SaveContactsAndSuppliersButton.UseVisualStyleBackColor = True
        '
        'EditContactsAndSuppliersButton
        '
        Me.EditContactsAndSuppliersButton.Location = New System.Drawing.Point(9, 51)
        Me.EditContactsAndSuppliersButton.Name = "EditContactsAndSuppliersButton"
        Me.EditContactsAndSuppliersButton.Size = New System.Drawing.Size(75, 23)
        Me.EditContactsAndSuppliersButton.TabIndex = 17
        Me.EditContactsAndSuppliersButton.Text = "Edit"
        Me.EditContactsAndSuppliersButton.UseVisualStyleBackColor = True
        '
        'ContactsAndSuppliersOpenFileDialog
        '
        Me.ContactsAndSuppliersOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'ContactsAndSuppliersPrintDialog
        '
        Me.ContactsAndSuppliersPrintDialog.UseEXDialog = True
        '
        'ContactsAndSuppliersPrintPreviewDialog
        '
        Me.ContactsAndSuppliersPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ContactsAndSuppliersPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ContactsAndSuppliersPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.ContactsAndSuppliersPrintPreviewDialog.Enabled = True
        Me.ContactsAndSuppliersPrintPreviewDialog.Icon = CType(resources.GetObject("ContactsAndSuppliersPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.ContactsAndSuppliersPrintPreviewDialog.Name = "ContactsAndSuppliersPrintPreviewDialog"
        Me.ContactsAndSuppliersPrintPreviewDialog.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ContactsandSuppliersMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(832, 383)
        Me.Controls.Add(Me.ControlsContactsAndSuppliersGroupBox)
        Me.Controls.Add(Me.DetailsContactsAndSuppliersGroupBox)
        Me.Controls.Add(Me.ContactsAndSuppliersListView)
        Me.Controls.Add(Me.ContactsAndSuppliersMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ContactsAndSuppliersMenuStrip
        Me.MaximizeBox = False
        Me.Name = "ContactsandSuppliersMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts and Suppliers"
        Me.ContactsAndSuppliersMenuStrip.ResumeLayout(False)
        Me.ContactsAndSuppliersMenuStrip.PerformLayout()
        Me.DetailsContactsAndSuppliersGroupBox.ResumeLayout(False)
        Me.DetailsContactsAndSuppliersGroupBox.PerformLayout()
        Me.ControlsContactsAndSuppliersGroupBox.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContactsAndSuppliersMenuStrip As MenuStrip
    Friend WithEvents FileContactsAndSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsContactsAndSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpContactsAndSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsAndSuppliersListView As ListView
    Friend WithEvents DetailsContactsAndSuppliersGroupBox As GroupBox
    Friend WithEvents WebsiteLinkContactsAndSuppliersLabel As Label
    Friend WithEvents Email2ContactsAndSuppliersLabel As Label
    Friend WithEvents Email1ContactsAndSuppliersLabel As Label
    Friend WithEvents PhoneNumber2ContactsAndSuppliersLabel As Label
    Friend WithEvents PhoneNumber1ContactsAndSuppliersLabel As Label
    Friend WithEvents AddressContactsAndSuppliersLabel As Label
    Friend WithEvents BusinessOwnerRepresentativeNameContactsAndSuppliersLabel As Label
    Friend WithEvents BusinessNameContactsAndSuppliersLabel As Label
    Friend WithEvents AddContactsAndSuppliersButton As Button
    Friend WithEvents WebsiteLinkContactsAndSuppliersTextBox As TextBox
    Friend WithEvents Email2ContactsAndSuppliersTextBox As TextBox
    Friend WithEvents Email1ContactsAndSuppliersTextBox As TextBox
    Friend WithEvents PhoneNumber2ContactsAndSuppliersTextBox As TextBox
    Friend WithEvents PhoneNumber1ContactsAndSuppliersTextBox As TextBox
    Friend WithEvents AddressContactsAndSuppliersTextBox As TextBox
    Friend WithEvents BusinessNameContactsAndSuppliersTextBox As TextBox
    Friend WithEvents BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox As TextBox
    Friend WithEvents BusinessOwnerRepColumnHeader As ColumnHeader
    Friend WithEvents BusinessNameColumnHeader As ColumnHeader
    Friend WithEvents AddressColumnHeader As ColumnHeader
    Friend WithEvents PhoneNumber1ColumnHeader As ColumnHeader
    Friend WithEvents PhoneNumber2ColumnHeader As ColumnHeader
    Friend WithEvents Email1ColumnHeader As ColumnHeader
    Friend WithEvents Email2ColumnHeader As ColumnHeader
    Friend WithEvents WebsiteLinkColumnHeader As ColumnHeader
    Friend WithEvents JunkColumnHeader As ColumnHeader
    Friend WithEvents ControlsContactsAndSuppliersGroupBox As GroupBox
    Friend WithEvents OpenContactsAndSuppliersButton As Button
    Friend WithEvents SaveContactsAndSuppliersButton As Button
    Friend WithEvents EditContactsAndSuppliersButton As Button
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsAndSuppliersSaveFileDialog As SaveFileDialog
    Friend WithEvents ContactsAndSuppliersOpenFileDialog As OpenFileDialog
    Friend WithEvents ContactsAndSuppliersPrintDialog As PrintDialog
    Friend WithEvents ContactsAndSuppliersPrintDocument As Printing.PrintDocument
    Friend WithEvents ContactsAndSuppliersPrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
