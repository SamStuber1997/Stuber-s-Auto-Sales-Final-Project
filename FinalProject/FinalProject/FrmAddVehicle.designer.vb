<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddVehicle
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
		Me.components = New System.ComponentModel.Container()
		Me.txtStockNum = New System.Windows.Forms.TextBox()
		Me.txtYear = New System.Windows.Forms.TextBox()
		Me.txtMake = New System.Windows.Forms.TextBox()
		Me.txtModel = New System.Windows.Forms.TextBox()
		Me.txtColor = New System.Windows.Forms.TextBox()
		Me.txtMileage = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTrim = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtTMV = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.cboDrivetrain = New System.Windows.Forms.ComboBox()
		Me.txtPrice = New System.Windows.Forms.MaskedTextBox()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.BtnClose = New System.Windows.Forms.Button()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Label11 = New System.Windows.Forms.Label()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtStockNum
		'
		Me.txtStockNum.Location = New System.Drawing.Point(183, 32)
		Me.txtStockNum.MaxLength = 2
		Me.txtStockNum.Name = "txtStockNum"
		Me.txtStockNum.Size = New System.Drawing.Size(100, 20)
		Me.txtStockNum.TabIndex = 0
		'
		'txtYear
		'
		Me.txtYear.Location = New System.Drawing.Point(431, 32)
		Me.txtYear.MaxLength = 4
		Me.txtYear.Name = "txtYear"
		Me.txtYear.Size = New System.Drawing.Size(100, 20)
		Me.txtYear.TabIndex = 1
		'
		'txtMake
		'
		Me.txtMake.Location = New System.Drawing.Point(431, 71)
		Me.txtMake.Name = "txtMake"
		Me.txtMake.Size = New System.Drawing.Size(100, 20)
		Me.txtMake.TabIndex = 2
		'
		'txtModel
		'
		Me.txtModel.Location = New System.Drawing.Point(431, 111)
		Me.txtModel.Name = "txtModel"
		Me.txtModel.Size = New System.Drawing.Size(100, 20)
		Me.txtModel.TabIndex = 3
		'
		'txtColor
		'
		Me.txtColor.Location = New System.Drawing.Point(431, 202)
		Me.txtColor.Name = "txtColor"
		Me.txtColor.Size = New System.Drawing.Size(100, 20)
		Me.txtColor.TabIndex = 4
		'
		'txtMileage
		'
		Me.txtMileage.Location = New System.Drawing.Point(431, 307)
		Me.txtMileage.Name = "txtMileage"
		Me.txtMileage.Size = New System.Drawing.Size(100, 20)
		Me.txtMileage.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(41, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(114, 20)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Stock Number:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(349, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(47, 20)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Year:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(344, 71)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 20)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Make:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(344, 111)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 20)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Model:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(353, 156)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 20)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Trim:"
		'
		'txtTrim
		'
		Me.txtTrim.Location = New System.Drawing.Point(431, 156)
		Me.txtTrim.Name = "txtTrim"
		Me.txtTrim.Size = New System.Drawing.Size(100, 20)
		Me.txtTrim.TabIndex = 12
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(353, 200)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(50, 20)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "Color:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(328, 307)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 20)
		Me.Label7.TabIndex = 14
		Me.Label7.Text = "Mileage:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(323, 256)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(80, 20)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Drivetrain:"
		'
		'txtTMV
		'
		Me.txtTMV.Location = New System.Drawing.Point(183, 82)
		Me.txtTMV.Name = "txtTMV"
		Me.txtTMV.Size = New System.Drawing.Size(100, 20)
		Me.txtTMV.TabIndex = 16
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(12, 82)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(143, 20)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "True Market Value:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(107, 131)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(48, 20)
		Me.Label10.TabIndex = 18
		Me.Label10.Text = "Price:"
		'
		'cboDrivetrain
		'
		Me.cboDrivetrain.FormattingEnabled = True
		Me.cboDrivetrain.Location = New System.Drawing.Point(431, 253)
		Me.cboDrivetrain.Name = "cboDrivetrain"
		Me.cboDrivetrain.Size = New System.Drawing.Size(100, 21)
		Me.cboDrivetrain.TabIndex = 19
		'
		'txtPrice
		'
		Me.txtPrice.Location = New System.Drawing.Point(183, 133)
		Me.txtPrice.Name = "txtPrice"
		Me.txtPrice.Size = New System.Drawing.Size(100, 20)
		Me.txtPrice.TabIndex = 20
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(111, 392)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(127, 25)
		Me.btnAdd.TabIndex = 21
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'BtnClose
		'
		Me.BtnClose.Location = New System.Drawing.Point(327, 392)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(127, 25)
		Me.BtnClose.TabIndex = 22
		Me.BtnClose.Text = "Close"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(305, 354)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(95, 20)
		Me.Label12.TabIndex = 24
		Me.Label12.Text = "Arrival Date:"
		'
		'dtpArrival
		'
		Me.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpArrival.Location = New System.Drawing.Point(431, 354)
		Me.dtpArrival.Name = "dtpArrival"
		Me.dtpArrival.Size = New System.Drawing.Size(106, 20)
		Me.dtpArrival.TabIndex = 25
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(591, 22)
		Me.StatusStrip1.TabIndex = 26
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Blue
		Me.Label11.Location = New System.Drawing.Point(16, 183)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(286, 134)
		Me.Label11.TabIndex = 27
		Me.Label11.Text = "Stuber's Auto Sales "
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmAddVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(591, 451)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.dtpArrival)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.BtnClose)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.txtPrice)
		Me.Controls.Add(Me.cboDrivetrain)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtTMV)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtTrim)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtMileage)
		Me.Controls.Add(Me.txtColor)
		Me.Controls.Add(Me.txtModel)
		Me.Controls.Add(Me.txtMake)
		Me.Controls.Add(Me.txtYear)
		Me.Controls.Add(Me.txtStockNum)
		Me.Name = "FrmAddVehicle"
		Me.Text = "Add Vehicle"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtStockNum As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTMV As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboDrivetrain As ComboBox
    Friend WithEvents txtPrice As MaskedTextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnClose As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents dtpArrival As DateTimePicker
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents errProvider As ErrorProvider
	Friend WithEvents Label11 As Label
End Class
