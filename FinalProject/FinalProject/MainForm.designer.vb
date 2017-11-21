<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SoldVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DealerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InventoryStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.DealerToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(515, 29)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
		Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
		Me.CloseToolStripMenuItem.Text = "Close "
		'
		'InventoryToolStripMenuItem
		'
		Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddVehicleToolStripMenuItem, Me.RemoveVehicleToolStripMenuItem, Me.ViewInventoryToolStripMenuItem, Me.SoldVehiclesToolStripMenuItem})
		Me.InventoryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
		Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
		Me.InventoryToolStripMenuItem.Text = "Inventory"
		'
		'AddVehicleToolStripMenuItem
		'
		Me.AddVehicleToolStripMenuItem.Name = "AddVehicleToolStripMenuItem"
		Me.AddVehicleToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
		Me.AddVehicleToolStripMenuItem.Text = "Add Vehicle"
		'
		'RemoveVehicleToolStripMenuItem
		'
		Me.RemoveVehicleToolStripMenuItem.Name = "RemoveVehicleToolStripMenuItem"
		Me.RemoveVehicleToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
		Me.RemoveVehicleToolStripMenuItem.Text = "Remove Vehicle"
		'
		'ViewInventoryToolStripMenuItem
		'
		Me.ViewInventoryToolStripMenuItem.Name = "ViewInventoryToolStripMenuItem"
		Me.ViewInventoryToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
		Me.ViewInventoryToolStripMenuItem.Text = "Inventory Report"
		'
		'SoldVehiclesToolStripMenuItem
		'
		Me.SoldVehiclesToolStripMenuItem.Name = "SoldVehiclesToolStripMenuItem"
		Me.SoldVehiclesToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
		Me.SoldVehiclesToolStripMenuItem.Text = "Sold Vehicles"
		'
		'DealerToolStripMenuItem
		'
		Me.DealerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryStatusToolStripMenuItem})
		Me.DealerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DealerToolStripMenuItem.Name = "DealerToolStripMenuItem"
		Me.DealerToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
		Me.DealerToolStripMenuItem.Text = "Dealer"
		'
		'InventoryStatusToolStripMenuItem
		'
		Me.InventoryStatusToolStripMenuItem.Name = "InventoryStatusToolStripMenuItem"
		Me.InventoryStatusToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
		Me.InventoryStatusToolStripMenuItem.Text = "Inventory Status"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Blue
		Me.Label2.Location = New System.Drawing.Point(114, 70)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(286, 134)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Stuber's Auto Sales "
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(515, 275)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MainForm"
		Me.Text = "Dream Vehicles Inc"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddVehicleToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RemoveVehicleToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DealerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InventoryStatusToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewInventoryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SoldVehiclesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label2 As Label
End Class
