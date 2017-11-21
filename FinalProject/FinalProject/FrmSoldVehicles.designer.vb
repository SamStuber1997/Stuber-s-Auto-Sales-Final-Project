<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoldVehicles
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
		Me.dgvInventory = New System.Windows.Forms.DataGridView()
		Me.SaleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TrimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DrivetrainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MileageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DealerDataSet = New FinalProject.DealerDataSet()
		Me.SoldTableAdapter = New FinalProject.DealerDataSetTableAdapters.SoldTableAdapter()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvInventory
		'
		Me.dgvInventory.AllowUserToAddRows = False
		Me.dgvInventory.AllowUserToDeleteRows = False
		Me.dgvInventory.AllowUserToOrderColumns = True
		Me.dgvInventory.AutoGenerateColumns = False
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleIDDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.TrimDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.DrivetrainDataGridViewTextBoxColumn, Me.MileageDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn})
		Me.dgvInventory.DataSource = Me.SoldBindingSource
		Me.dgvInventory.Location = New System.Drawing.Point(8, 147)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.ReadOnly = True
		Me.dgvInventory.Size = New System.Drawing.Size(1041, 222)
		Me.dgvInventory.TabIndex = 47
		'
		'SaleIDDataGridViewTextBoxColumn
		'
		Me.SaleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID"
		Me.SaleIDDataGridViewTextBoxColumn.HeaderText = "SaleID"
		Me.SaleIDDataGridViewTextBoxColumn.Name = "SaleIDDataGridViewTextBoxColumn"
		Me.SaleIDDataGridViewTextBoxColumn.ReadOnly = True
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
		'SalePriceDataGridViewTextBoxColumn
		'
		Me.SalePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice"
		Me.SalePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice"
		Me.SalePriceDataGridViewTextBoxColumn.Name = "SalePriceDataGridViewTextBoxColumn"
		Me.SalePriceDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ProfitDataGridViewTextBoxColumn
		'
		Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "Profit"
		Me.ProfitDataGridViewTextBoxColumn.HeaderText = "Profit"
		Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
		Me.ProfitDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SoldBindingSource
		'
		Me.SoldBindingSource.DataMember = "Sold"
		Me.SoldBindingSource.DataSource = Me.DealerDataSet
		'
		'DealerDataSet
		'
		Me.DealerDataSet.DataSetName = "DealerDataSet"
		Me.DealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SoldTableAdapter
		'
		Me.SoldTableAdapter.ClearBeforeFill = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Blue
		Me.Label1.Location = New System.Drawing.Point(277, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(286, 134)
		Me.Label1.TabIndex = 48
		Me.Label1.Text = "Stuber's Auto Sales "
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmSoldVehicles
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1061, 381)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dgvInventory)
		Me.Name = "FrmSoldVehicles"
		Me.Text = "FrmSoldVehicles"
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DealerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgvInventory As DataGridView
	Friend WithEvents DealerDataSet As DealerDataSet
	Friend WithEvents SoldBindingSource As BindingSource
	Friend WithEvents SoldTableAdapter As DealerDataSetTableAdapters.SoldTableAdapter
	Friend WithEvents SaleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TrimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DrivetrainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MileageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ProfitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Label1 As Label
End Class
