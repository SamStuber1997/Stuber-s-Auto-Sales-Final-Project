<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheapestVehicle
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
		Me.dgvCheapestVehicle = New System.Windows.Forms.DataGridView()
		CType(Me.dgvCheapestVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvCheapestVehicle
		'
		Me.dgvCheapestVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCheapestVehicle.Location = New System.Drawing.Point(12, 12)
		Me.dgvCheapestVehicle.Name = "dgvCheapestVehicle"
		Me.dgvCheapestVehicle.Size = New System.Drawing.Size(786, 150)
		Me.dgvCheapestVehicle.TabIndex = 0
		'
		'CheapestVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(810, 183)
		Me.Controls.Add(Me.dgvCheapestVehicle)
		Me.Name = "CheapestVehicle"
		Me.Text = "CheapestVehicle"
		CType(Me.dgvCheapestVehicle, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents dgvCheapestVehicle As DataGridView
End Class
