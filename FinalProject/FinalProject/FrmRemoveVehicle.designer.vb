<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemoveVehicle
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
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.dgvInventory = New System.Windows.Forms.DataGridView()
		Me.StockNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtStockNum = New System.Windows.Forms.TextBox()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.Inventory1TableAdapter = New FinalProject.DealerDataSetTableAdapters.Inventory1TableAdapter()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(617, 22)
		Me.StatusStrip1.TabIndex = 43
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'dgvInventory
		'
		Me.dgvInventory.AllowUserToAddRows = False
		Me.dgvInventory.AutoGenerateColumns = False
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNumberDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.TrimDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.DrivetrainDataGridViewTextBoxColumn, Me.MileageDataGridViewTextBoxColumn, Me.TrueMarketValueDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ArrivalDateDataGridViewTextBoxColumn})
		Me.dgvInventory.DataSource = Me.Inventory1BindingSource
		Me.dgvInventory.Location = New System.Drawing.Point(12, 86)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.ReadOnly = True
		Me.dgvInventory.Size = New System.Drawing.Size(585, 192)
		Me.dgvInventory.TabIndex = 44
		'
		'StockNumberDataGridViewTextBoxColumn
		'
		Me.StockNumberDataGridViewTextBoxColumn.DataPropertyName = "StockNumber"
		Me.StockNumberDataGridViewTextBoxColumn.HeaderText = "StockNumber"
		Me.StockNumberDataGridViewTextBoxColumn.Name = "StockNumberDataGridViewTextBoxColumn"
		Me.StockNumberDataGridViewTextBoxColumn.ReadOnly = True
		'
		'YearDataGridViewTextBoxColumn
		'
		Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
		Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
		Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
		Me.YearDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MakeDataGridViewTextBoxColumn
		'
		Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
		Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
		Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
		Me.MakeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ModelDataGridViewTextBoxColumn
		'
		Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
		Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
		Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
		Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TrimDataGridViewTextBoxColumn
		'
		Me.TrimDataGridViewTextBoxColumn.DataPropertyName = "Trim"
		Me.TrimDataGridViewTextBoxColumn.HeaderText = "Trim"
		Me.TrimDataGridViewTextBoxColumn.Name = "TrimDataGridViewTextBoxColumn"
		Me.TrimDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ColorDataGridViewTextBoxColumn
		'
		Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
		Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
		Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
		Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DrivetrainDataGridViewTextBoxColumn
		'
		Me.DrivetrainDataGridViewTextBoxColumn.DataPropertyName = "Drivetrain"
		Me.DrivetrainDataGridViewTextBoxColumn.HeaderText = "Drivetrain"
		Me.DrivetrainDataGridViewTextBoxColumn.Name = "DrivetrainDataGridViewTextBoxColumn"
		Me.DrivetrainDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MileageDataGridViewTextBoxColumn
		'
		Me.MileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage"
		Me.MileageDataGridViewTextBoxColumn.HeaderText = "Mileage"
		Me.MileageDataGridViewTextBoxColumn.Name = "MileageDataGridViewTextBoxColumn"
		Me.MileageDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TrueMarketValueDataGridViewTextBoxColumn
		'
		Me.TrueMarketValueDataGridViewTextBoxColumn.DataPropertyName = "TrueMarketValue"
		Me.TrueMarketValueDataGridViewTextBoxColumn.HeaderText = "TrueMarketValue"
		Me.TrueMarketValueDataGridViewTextBoxColumn.Name = "TrueMarketValueDataGridViewTextBoxColumn"
		Me.TrueMarketValueDataGridViewTextBoxColumn.ReadOnly = True
		'
		'PriceDataGridViewTextBoxColumn
		'
		Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
		Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
		Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
		Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ArrivalDateDataGridViewTextBoxColumn
		'
		Me.ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate"
		Me.ArrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate"
		Me.ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn"
		Me.ArrivalDateDataGridViewTextBoxColumn.ReadOnly = True
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
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(56, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(114, 20)
		Me.Label1.TabIndex = 46
		Me.Label1.Text = "Stock Number:"
		'
		'txtStockNum
		'
		Me.txtStockNum.Location = New System.Drawing.Point(198, 40)
		Me.txtStockNum.Name = "txtStockNum"
		Me.txtStockNum.Size = New System.Drawing.Size(100, 20)
		Me.txtStockNum.TabIndex = 45
		'
		'btnRemove
		'
		Me.btnRemove.Location = New System.Drawing.Point(387, 35)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(183, 32)
		Me.btnRemove.TabIndex = 47
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = True
		'
		'Inventory1TableAdapter
		'
		Me.Inventory1TableAdapter.ClearBeforeFill = True
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Blue
		Me.Label3.Location = New System.Drawing.Point(153, 298)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(286, 134)
		Me.Label3.TabIndex = 49
		Me.Label3.Text = "Stuber's Auto Sales "
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmRemoveVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(617, 454)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtStockNum)
		Me.Controls.Add(Me.dgvInventory)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "FrmRemoveVehicle"
		Me.Text = "FrmRemoveVehicle"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Inventory1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockNum As TextBox
    Friend WithEvents btnRemove As Button
	Friend WithEvents DealerDataSet As DealerDataSet
	Friend WithEvents Inventory1BindingSource As BindingSource
	Friend WithEvents Inventory1TableAdapter As DealerDataSetTableAdapters.Inventory1TableAdapter
	Friend WithEvents StockNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
	Friend WithEvents errProvider As ErrorProvider
	Friend WithEvents Label3 As Label
End Class
