<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSellVehicle
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cboDrivetrain = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtTrim = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtMileage = New System.Windows.Forms.TextBox()
		Me.txtColor = New System.Windows.Forms.TextBox()
		Me.txtModel = New System.Windows.Forms.TextBox()
		Me.txtMake = New System.Windows.Forms.TextBox()
		Me.txtYear = New System.Windows.Forms.TextBox()
		Me.txtTMV = New System.Windows.Forms.MaskedTextBox()
		Me.txtStockNum = New System.Windows.Forms.TextBox()
		Me.txtPrice = New System.Windows.Forms.MaskedTextBox()
		Me.txtSaleID = New System.Windows.Forms.MaskedTextBox()
		Me.btnSell = New System.Windows.Forms.Button()
		Me.BtnClose = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtProfit = New System.Windows.Forms.MaskedTextBox()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Label12 = New System.Windows.Forms.Label()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(84, 58)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(66, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Sale ID:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(63, 98)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(74, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Sell Price"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(36, 21)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(114, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Stock Number:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(16, 143)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(143, 20)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "True Market Value:"
		'
		'cboDrivetrain
		'
		Me.cboDrivetrain.Enabled = False
		Me.cboDrivetrain.FormattingEnabled = True
		Me.cboDrivetrain.Location = New System.Drawing.Point(554, 242)
		Me.cboDrivetrain.Name = "cboDrivetrain"
		Me.cboDrivetrain.Size = New System.Drawing.Size(100, 21)
		Me.cboDrivetrain.TabIndex = 33
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(446, 245)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(80, 20)
		Me.Label8.TabIndex = 32
		Me.Label8.Text = "Drivetrain:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(451, 296)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 20)
		Me.Label7.TabIndex = 31
		Me.Label7.Text = "Mileage:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(476, 189)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(50, 20)
		Me.Label6.TabIndex = 30
		Me.Label6.Text = "Color:"
		'
		'txtTrim
		'
		Me.txtTrim.Enabled = False
		Me.txtTrim.Location = New System.Drawing.Point(554, 145)
		Me.txtTrim.Name = "txtTrim"
		Me.txtTrim.Size = New System.Drawing.Size(100, 20)
		Me.txtTrim.TabIndex = 29
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(476, 145)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 20)
		Me.Label5.TabIndex = 28
		Me.Label5.Text = "Trim:"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(467, 100)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(56, 20)
		Me.Label9.TabIndex = 27
		Me.Label9.Text = "Model:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(467, 60)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(52, 20)
		Me.Label10.TabIndex = 26
		Me.Label10.Text = "Make:"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(472, 21)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(47, 20)
		Me.Label11.TabIndex = 25
		Me.Label11.Text = "Year:"
		'
		'txtMileage
		'
		Me.txtMileage.Enabled = False
		Me.txtMileage.Location = New System.Drawing.Point(554, 296)
		Me.txtMileage.Name = "txtMileage"
		Me.txtMileage.Size = New System.Drawing.Size(100, 20)
		Me.txtMileage.TabIndex = 24
		'
		'txtColor
		'
		Me.txtColor.Enabled = False
		Me.txtColor.Location = New System.Drawing.Point(554, 191)
		Me.txtColor.Name = "txtColor"
		Me.txtColor.Size = New System.Drawing.Size(100, 20)
		Me.txtColor.TabIndex = 23
		'
		'txtModel
		'
		Me.txtModel.Enabled = False
		Me.txtModel.Location = New System.Drawing.Point(554, 100)
		Me.txtModel.Name = "txtModel"
		Me.txtModel.Size = New System.Drawing.Size(100, 20)
		Me.txtModel.TabIndex = 22
		'
		'txtMake
		'
		Me.txtMake.Enabled = False
		Me.txtMake.Location = New System.Drawing.Point(554, 60)
		Me.txtMake.Name = "txtMake"
		Me.txtMake.Size = New System.Drawing.Size(100, 20)
		Me.txtMake.TabIndex = 21
		'
		'txtYear
		'
		Me.txtYear.Enabled = False
		Me.txtYear.Location = New System.Drawing.Point(554, 21)
		Me.txtYear.MaxLength = 4
		Me.txtYear.Name = "txtYear"
		Me.txtYear.Size = New System.Drawing.Size(100, 20)
		Me.txtYear.TabIndex = 20
		'
		'txtTMV
		'
		Me.txtTMV.Enabled = False
		Me.txtTMV.Location = New System.Drawing.Point(176, 147)
		Me.txtTMV.Name = "txtTMV"
		Me.txtTMV.Size = New System.Drawing.Size(100, 20)
		Me.txtTMV.TabIndex = 36
		'
		'txtStockNum
		'
		Me.txtStockNum.Enabled = False
		Me.txtStockNum.Location = New System.Drawing.Point(176, 23)
		Me.txtStockNum.Name = "txtStockNum"
		Me.txtStockNum.Size = New System.Drawing.Size(100, 20)
		Me.txtStockNum.TabIndex = 34
		'
		'txtPrice
		'
		Me.txtPrice.Location = New System.Drawing.Point(176, 100)
		Me.txtPrice.Name = "txtPrice"
		Me.txtPrice.Size = New System.Drawing.Size(100, 20)
		Me.txtPrice.TabIndex = 37
		'
		'txtSaleID
		'
		Me.txtSaleID.Enabled = False
		Me.txtSaleID.Location = New System.Drawing.Point(176, 62)
		Me.txtSaleID.Name = "txtSaleID"
		Me.txtSaleID.Size = New System.Drawing.Size(100, 20)
		Me.txtSaleID.TabIndex = 38
		'
		'btnSell
		'
		Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSell.Location = New System.Drawing.Point(20, 388)
		Me.btnSell.Name = "btnSell"
		Me.btnSell.Size = New System.Drawing.Size(175, 29)
		Me.btnSell.TabIndex = 39
		Me.btnSell.Text = "Sell"
		Me.btnSell.UseVisualStyleBackColor = True
		'
		'BtnClose
		'
		Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnClose.Location = New System.Drawing.Point(226, 388)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(175, 29)
		Me.BtnClose.TabIndex = 40
		Me.BtnClose.Text = "Close"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 435)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(689, 22)
		Me.StatusStrip1.TabIndex = 42
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'dtpArrival
		'
		Me.dtpArrival.Enabled = False
		Me.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpArrival.Location = New System.Drawing.Point(548, 343)
		Me.dtpArrival.Name = "dtpArrival"
		Me.dtpArrival.Size = New System.Drawing.Size(106, 20)
		Me.dtpArrival.TabIndex = 44
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(424, 343)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(95, 20)
		Me.Label13.TabIndex = 43
		Me.Label13.Text = "Arrival Date:"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(100, 189)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(50, 20)
		Me.Label15.TabIndex = 47
		Me.Label15.Text = "Profit:"
		'
		'txtProfit
		'
		Me.txtProfit.Enabled = False
		Me.txtProfit.Location = New System.Drawing.Point(176, 191)
		Me.txtProfit.Name = "txtProfit"
		Me.txtProfit.Size = New System.Drawing.Size(100, 20)
		Me.txtProfit.TabIndex = 48
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.Blue
		Me.Label12.Location = New System.Drawing.Point(40, 228)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(286, 134)
		Me.Label12.TabIndex = 49
		Me.Label12.Text = "Stuber's Auto Sales "
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmSellVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(689, 457)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.txtProfit)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.dtpArrival)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.BtnClose)
		Me.Controls.Add(Me.btnSell)
		Me.Controls.Add(Me.txtSaleID)
		Me.Controls.Add(Me.txtPrice)
		Me.Controls.Add(Me.txtTMV)
		Me.Controls.Add(Me.txtStockNum)
		Me.Controls.Add(Me.cboDrivetrain)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtTrim)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtMileage)
		Me.Controls.Add(Me.txtColor)
		Me.Controls.Add(Me.txtModel)
		Me.Controls.Add(Me.txtMake)
		Me.Controls.Add(Me.txtYear)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FrmSellVehicle"
		Me.Text = "Sell Vehicle"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDrivetrain As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTrim As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtTMV As MaskedTextBox
    Friend WithEvents txtStockNum As TextBox
    Friend WithEvents txtPrice As MaskedTextBox
    Friend WithEvents txtSaleID As MaskedTextBox
    Friend WithEvents btnSell As Button
    Friend WithEvents BtnClose As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents dtpArrival As DateTimePicker
	Friend WithEvents Label13 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents txtProfit As MaskedTextBox
	Friend WithEvents errProvider As ErrorProvider
	Friend WithEvents Label12 As Label
End Class
