<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDealerStatus
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblProfit = New System.Windows.Forms.Label()
		Me.lblValue = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 45)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(150, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Sold Vehicle Profits:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(31, 124)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(123, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Inventory Value:"
		'
		'lblProfit
		'
		Me.lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfit.Location = New System.Drawing.Point(198, 42)
		Me.lblProfit.Name = "lblProfit"
		Me.lblProfit.Size = New System.Drawing.Size(131, 34)
		Me.lblProfit.TabIndex = 2
		'
		'lblValue
		'
		Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValue.Location = New System.Drawing.Point(198, 110)
		Me.lblValue.Name = "lblValue"
		Me.lblValue.Size = New System.Drawing.Size(131, 34)
		Me.lblValue.TabIndex = 3
		'
		'btnClose
		'
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(100, 183)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(168, 32)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Blue
		Me.Label4.Location = New System.Drawing.Point(35, 245)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(286, 134)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Stuber's Auto Sales "
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmDealerStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(382, 388)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.lblValue)
		Me.Controls.Add(Me.lblProfit)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FrmDealerStatus"
		Me.Text = "FrmDealerStatus"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents btnClose As Button
	Friend WithEvents Label4 As Label
End Class
