<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolsAndEuipmentPopUp
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialPartNumberLabel = New System.Windows.Forms.Label()
        Me.ShopNumberLabel = New System.Windows.Forms.Label()
        Me.WarrantyLengthLabel = New System.Windows.Forms.Label()
        Me.WarrantyExpirationDateLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.CurrentStatusLabel = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(12, 220)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(189, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Rachet", "Screwdriver", "Hammer", "Electric Drill", "Ladder", "Measuring Tool", "Axe", "Socket", "Pliers", "Extension", "Multimeter", "Toolbox", "Safety Glasses", "Wrench", "Saw", "Goggles", "Scissors", "Riveter", "Brace", "Toolbag", "Hard Hat/Helmet", "Gloves", "Bradawl", "Table Saw", "Lathe", "Apron/Smock", "Footwear", "Chisel", "Lock", "Magnet", "USB/Thumb Drive", "Camera", "Mirror", "Pen/Pencil", "Ammeter", "Ohmmeter", "Voltmeter", "Handsaw", "Chainsaw", "Knife", "Engine", "Gearbox", "Magnifier", "Flashlight", "Telephone", "Socket Adapter", "Desktop", "Laptop", "Marker", "Whiteboard", "Corkboard", "Chaulk Gun", "Plunger", "Corkscrew", "Electric Cord", "Kitchen Appliance", "Adhesive/Tape", "Software", "Computer Monitor/TV", "Screwdriver Bit", "Bathroom Appliance", "Chemicals", "Electric Sander", "Scroll Saw", "Musical Instrument", "Light/LED", "CD/DVD", "Speaker", "Journal/Notebook", "Safety Manual", "Job Guide", "Towel/Rag", "Gardening Tool", "Watch/Accesories", "Coveralls/Overalls", "Planer", "Coin", "Bottle/Container", "Tool Case", "Power Supply", "Chop Saw", "Welding Helmet", "Jig", "Drill Press", "CNC Machine", "Router", "Fan/AC/HVAC Unit", "Grinder", "Square", "Calculator", "Gauge", "Clamp", "File", "Crucible", "Oven", "Jack", "Cart", "Ear Protection", "Video Game Console", "Cooler", "Microscope", "Security System", "Desktop/Laptop Component", "Bar", "Handle", "Clock", "Microphone", "Furniture", "Visor", "Printer", "Safe", "Bag", "Basket", "Box", "Pump", "Trailer", "Vehicle", "Computer Mouse", "Computer Keyboard", "Server", "Electronic Lead", "Anvil", "Vise", "Card Reader", "Cash Register", "Fax Machine", "Radio", "Grill", "Band Saw", "Soldering Iron", "Smart Board", "Sporting Equipment", "Weapon", "Impact Driver", "Heat Gun", "Reciprocating Saw", "Brush", "Mask", "Drill", "Sander", "Cap", "Switch", "Fishing Gear", "Crimper", "Multi-Tool", "Stone", "Biscuit Jointer", "Miter Saw", "Oscillating Tool", "Nail Gun", "Rotary Tool", "Stand", "Dust Collector", "Table", "Vacuum", "Generator", "Plasma Cutter", "Stick Welder", "Chest", "MIG Welder", "TIG Welder", "Moisture Meter", "Tester", "Thermometer", "Wire Feeder Welder", "Engine Driven Welder", "Multi-Process Welder", "Arc Welder", "Paint/Coating", "Wood", "Metal", "Cover", "Drill Bit", "Blade", "Battery", "Laser Engraver", "Remote", "Laser Cutter", "Plasma Cutter", "Tattoo Equipment", "Bucket", "Broom/Mop", "Pressure Washer", "Canopy", "Mixer", "Leaf Blower", "Bowl", "Paddle", "Utensil", "Tray", "Hoist", "Strap", "Rope", "Tarp", "Rack", "Bin", "Ammo Box", "Trimmer", "Pole Saw", "Shredder", "Wood Chipper", "Log Splitter", "Auger", "Cultivator", "Snow Blower", "Hose", "Airbrush", "Paint Sprayer", "Air Compressor", "Air Sander", "Ramp", "Crane", "Barrel", "Winch", "Torch", "Food", "Drink", "Cleaning Supply", "Vehicle Fluid", "Pharmaceutical", "Sink", "Toilet", "Shower", "Laundry/Dish Washer", "Laundry Dryer", "Suitcase", "Briefcase", "Crowbar", "Pick", "Key", "Toy", "Plane", "Sword", "Cable", "Drone", "Satellite", "Stapler", "Hole Puncher"})
        Me.ComboBox1.Location = New System.Drawing.Point(189, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(189, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(130, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(189, 118)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(189, 144)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(130, 20)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(189, 170)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(130, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(189, 196)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(130, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(189, 222)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(130, 20)
        Me.TextBox8.TabIndex = 9
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Location = New System.Drawing.Point(149, 16)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(35, 13)
        Me.BrandLabel.TabIndex = 10
        Me.BrandLabel.Text = "Brand"
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Location = New System.Drawing.Point(147, 42)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.ModelLabel.TabIndex = 11
        Me.ModelLabel.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tool Type"
        '
        'SerialPartNumberLabel
        '
        Me.SerialPartNumberLabel.AutoSize = True
        Me.SerialPartNumberLabel.Location = New System.Drawing.Point(86, 95)
        Me.SerialPartNumberLabel.Name = "SerialPartNumberLabel"
        Me.SerialPartNumberLabel.Size = New System.Drawing.Size(97, 13)
        Me.SerialPartNumberLabel.TabIndex = 13
        Me.SerialPartNumberLabel.Text = "Serial/Part Number"
        '
        'ShopNumberLabel
        '
        Me.ShopNumberLabel.AutoSize = True
        Me.ShopNumberLabel.Location = New System.Drawing.Point(111, 121)
        Me.ShopNumberLabel.Name = "ShopNumberLabel"
        Me.ShopNumberLabel.Size = New System.Drawing.Size(72, 13)
        Me.ShopNumberLabel.TabIndex = 14
        Me.ShopNumberLabel.Text = "Shop Number"
        '
        'WarrantyLengthLabel
        '
        Me.WarrantyLengthLabel.AutoSize = True
        Me.WarrantyLengthLabel.Location = New System.Drawing.Point(97, 147)
        Me.WarrantyLengthLabel.Name = "WarrantyLengthLabel"
        Me.WarrantyLengthLabel.Size = New System.Drawing.Size(86, 13)
        Me.WarrantyLengthLabel.TabIndex = 15
        Me.WarrantyLengthLabel.Text = "Warranty Length"
        '
        'WarrantyExpirationDateLabel
        '
        Me.WarrantyExpirationDateLabel.AutoSize = True
        Me.WarrantyExpirationDateLabel.Location = New System.Drawing.Point(58, 173)
        Me.WarrantyExpirationDateLabel.Name = "WarrantyExpirationDateLabel"
        Me.WarrantyExpirationDateLabel.Size = New System.Drawing.Size(125, 13)
        Me.WarrantyExpirationDateLabel.TabIndex = 16
        Me.WarrantyExpirationDateLabel.Text = "Warranty Expiration Date"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(105, 199)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(78, 13)
        Me.PurchaseDateLabel.TabIndex = 17
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'CurrentStatusLabel
        '
        Me.CurrentStatusLabel.AutoSize = True
        Me.CurrentStatusLabel.Location = New System.Drawing.Point(109, 251)
        Me.CurrentStatusLabel.Name = "CurrentStatusLabel"
        Me.CurrentStatusLabel.Size = New System.Drawing.Size(74, 13)
        Me.CurrentStatusLabel.TabIndex = 18
        Me.CurrentStatusLabel.Text = "Current Status"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(155, 225)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(28, 13)
        Me.CostLabel.TabIndex = 19
        Me.CostLabel.Text = "Cost"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(189, 248)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(130, 20)
        Me.TextBox9.TabIndex = 20
        '
        'ToolsAndEuipmentPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(331, 286)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.CurrentStatusLabel)
        Me.Controls.Add(Me.PurchaseDateLabel)
        Me.Controls.Add(Me.WarrantyExpirationDateLabel)
        Me.Controls.Add(Me.WarrantyLengthLabel)
        Me.Controls.Add(Me.ShopNumberLabel)
        Me.Controls.Add(Me.SerialPartNumberLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ModelLabel)
        Me.Controls.Add(Me.BrandLabel)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AddButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ToolsAndEuipmentPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToolsAndEuipmentPopUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents BrandLabel As Label
    Friend WithEvents ModelLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SerialPartNumberLabel As Label
    Friend WithEvents ShopNumberLabel As Label
    Friend WithEvents WarrantyLengthLabel As Label
    Friend WithEvents WarrantyExpirationDateLabel As Label
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents CurrentStatusLabel As Label
    Friend WithEvents CostLabel As Label
    Friend WithEvents TextBox9 As TextBox
End Class
