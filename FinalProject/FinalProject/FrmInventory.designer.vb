<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventory
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
		Me.components = New System.ComponentModel.Container()
		Me.dgvInventory = New System.Windows.Forms.DataGridView()
		Me.StockNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TrimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DrivetrainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MileageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TrueMarketValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ArrivalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Inventory1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DealerDataSet = New FinalProject.DealerDataSet()
		Me.txtStockNum = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnSell = New System.Windows.Forms.Button()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Inventory1TableAdapter = New FinalProject.DealerDataSetTableAdapters.Inventory1TableAdapter()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvInventory
		'
		Me.dgvInventory.AllowUserToOrderColumns = True
		Me.dgvInventory.AutoGenerateColumns = False
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNumber, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.TrimDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.DrivetrainDataGridViewTextBoxColumn, Me.MileageDataGridViewTextBoxColumn, Me.TrueMarketValueDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ArrivalDateDataGridViewTextBoxColumn})
		Me.dgvInventory.DataSource = Me.Inventory1BindingSource
		Me.dgvInventory.Location = New System.Drawing.Point(-1, 198)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.Size = New System.Drawing.Size(1268, 283)
		Me.dgvInventory.TabIndex = 48
		'
		'StockNumber
		'
		Me.StockNumber.DataPropertyName = "StockNumber"
		Me.StockNumber.HeaderText = "StockNumber"
		Me.StockNumber.Name = "StockNumber"
		Me.StockNumber.ReadOnly = True
		'
		'YearDataGridViewTextBoxColumn
		'
		Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
		Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
		Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
		'
		'MakeDataGridViewTextBoxColumn
		'
		Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
		Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
		Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
		'
		'ModelDataGridViewTextBoxColumn
		'
		Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
		Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
		Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
		'
		'TrimDataGridViewTextBoxColumn
		'
		Me.TrimDataGridViewTextBoxColumn.DataPropertyName = "Trim"
		Me.TrimDataGridViewTextBoxColumn.HeaderText = "Trim"
		Me.TrimDataGridViewTextBoxColumn.Name = "TrimDataGridViewTextBoxColumn"
		'
		'ColorDataGridViewTextBoxColumn
		'
		Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
		Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
		Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
		'
		'DrivetrainDataGridViewTextBoxColumn
		'
		Me.DrivetrainDataGridViewTextBoxColumn.DataPropertyName = "Drivetrain"
		Me.DrivetrainDataGridViewTextBoxColumn.HeaderText = "Drivetrain"
		Me.DrivetrainDataGridViewTextBoxColumn.Name = "DrivetrainDataGridViewTextBoxColumn"
		'
		'MileageDataGridViewTextBoxColumn
		'
		Me.MileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage"
		Me.MileageDataGridViewTextBoxColumn.HeaderText = "Mileage"
		Me.MileageDataGridViewTextBoxColumn.Name = "MileageDataGridViewTextBoxColumn"
		'
		'TrueMarketValueDataGridViewTextBoxColumn
		'
		Me.TrueMarketValueDataGridViewTextBoxColumn.DataPropertyName = "TrueMarketValue"
		Me.TrueMarketValueDataGridViewTextBoxColumn.HeaderText = "TrueMarketValue"
		Me.TrueMarketValueDataGridViewTextBoxColumn.Name = "TrueMarketValueDataGridViewTextBoxColumn"
		'
		'PriceDataGridViewTextBoxColumn
		'
		Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
		Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
		Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
		'
		'ArrivalDateDataGridViewTextBoxColumn
		'
		Me.ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate"
		Me.ArrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate"
		Me.ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn"
		'
		'Inventory1BindingSource
		'
		Me.Inventory1BindingSource.DataMember = "Inventory1"
		Me.Inventory1BindingSource.DataSource = Me.DealerDataSet
		'
		'DealerDataSet
		'
		Me.DealerDataSet.DataSetName = "DealerDataSet"
		Me.DealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'txtStockNum
		'
		Me.txtStockNum.Location = New System.Drawing.Point(441, 162)
		Me.txtStockNum.Name = "txtStockNum"
		Me.txtStockNum.Size = New System.Drawing.Size(104, 20)
		Me.txtStockNum.TabIndex = 61
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(297, 162)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(114, 20)
		Me.Label3.TabIndex = 62
		Me.Label3.Text = "Stock Number:"
		'
		'btnSell
		'
		Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSell.Location = New System.Drawing.Point(570, 156)
		Me.btnSell.Name = "btnSell"
		Me.btnSell.Size = New System.Drawing.Size(100, 28)
		Me.btnSell.TabIndex = 63
		Me.btnSell.Text = "Sell Vehicle"
		Me.btnSell.UseVisualStyleBackColor = True
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
		'
		'Inventory1TableAdapter
		'
		Me.Inventory1TableAdapter.ClearBeforeFill = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Blue
		Me.Label1.Location = New System.Drawing.Point(245, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(286, 134)
		Me.Label1.TabIndex = 64
		Me.Label1.Text = "Stuber's Auto Sales "
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmInventory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1247, 493)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnSell)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtStockNum)
		Me.Controls.Add(Me.dgvInventory)
		Me.Name = "FrmInventory"
		Me.Text = "Inventory Report"
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvInventory As DataGridView
	Friend WithEvents StockNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents txtStockNum As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents btnSell As Button
	Friend WithEvents errProvider As ErrorProvider
	Friend WithEvents DealerDataSet As DealerDataSet
	Friend WithEvents Inventory1BindingSource As BindingSource
	Friend WithEvents Inventory1TableAdapter As DealerDataSetTableAdapters.Inventory1TableAdapter
	Friend WithEvents StockNumber As DataGridViewTextBoxColumn
	Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TrimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DrivetrainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MileageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TrueMarketValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ArrivalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Label1 As Label
End Class
