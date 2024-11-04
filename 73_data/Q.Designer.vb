<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q
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
        Dim Qualifacation_typeLabel As System.Windows.Forms.Label
        Dim Qualifacation_dateLabel As System.Windows.Forms.Label
        Dim Qualifacation_insLabel As System.Windows.Forms.Label
        Dim Qualifacation_idLabel As System.Windows.Forms.Label
        Dim Staffs_idLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Q))
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.QualifacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualifacationTableAdapter = New _73_data.dbpro73DataSetTableAdapters.qualifacationTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.QualifacationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QualifacationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QualifacationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qualifacation_idTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_idTextBox = New System.Windows.Forms.TextBox()
        Me.Qualifacation_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Qualifacation_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Qualifacation_insTextBox = New System.Windows.Forms.TextBox()
        Qualifacation_typeLabel = New System.Windows.Forms.Label()
        Qualifacation_dateLabel = New System.Windows.Forms.Label()
        Qualifacation_insLabel = New System.Windows.Forms.Label()
        Qualifacation_idLabel = New System.Windows.Forms.Label()
        Staffs_idLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualifacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualifacationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QualifacationBindingNavigator.SuspendLayout()
        CType(Me.QualifacationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qualifacation_typeLabel
        '
        Qualifacation_typeLabel.AutoSize = True
        Qualifacation_typeLabel.Location = New System.Drawing.Point(208, 145)
        Qualifacation_typeLabel.Name = "Qualifacation_typeLabel"
        Qualifacation_typeLabel.Size = New System.Drawing.Size(34, 13)
        Qualifacation_typeLabel.TabIndex = 133
        Qualifacation_typeLabel.Text = "Type:"
        '
        'Qualifacation_dateLabel
        '
        Qualifacation_dateLabel.AutoSize = True
        Qualifacation_dateLabel.Location = New System.Drawing.Point(208, 170)
        Qualifacation_dateLabel.Name = "Qualifacation_dateLabel"
        Qualifacation_dateLabel.Size = New System.Drawing.Size(33, 13)
        Qualifacation_dateLabel.TabIndex = 134
        Qualifacation_dateLabel.Text = "Date:"
        '
        'Qualifacation_insLabel
        '
        Qualifacation_insLabel.AutoSize = True
        Qualifacation_insLabel.Location = New System.Drawing.Point(208, 197)
        Qualifacation_insLabel.Name = "Qualifacation_insLabel"
        Qualifacation_insLabel.Size = New System.Drawing.Size(55, 13)
        Qualifacation_insLabel.TabIndex = 135
        Qualifacation_insLabel.Text = "Institution:"
        '
        'Qualifacation_idLabel
        '
        Qualifacation_idLabel.AutoSize = True
        Qualifacation_idLabel.Location = New System.Drawing.Point(196, 94)
        Qualifacation_idLabel.Name = "Qualifacation_idLabel"
        Qualifacation_idLabel.Size = New System.Drawing.Size(77, 13)
        Qualifacation_idLabel.TabIndex = 131
        Qualifacation_idLabel.Text = "qualification id:"
        '
        'Staffs_idLabel
        '
        Staffs_idLabel.AutoSize = True
        Staffs_idLabel.Location = New System.Drawing.Point(208, 120)
        Staffs_idLabel.Name = "Staffs_idLabel"
        Staffs_idLabel.Size = New System.Drawing.Size(46, 13)
        Staffs_idLabel.TabIndex = 132
        Staffs_idLabel.Text = "staffs id:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label11.Location = New System.Drawing.Point(306, 45)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(132, 20)
        Label11.TabIndex = 146
        Label11.Text = "QUALIFICATION"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QualifacationBindingSource
        '
        Me.QualifacationBindingSource.DataMember = "qualifacation"
        Me.QualifacationBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'QualifacationTableAdapter
        '
        Me.QualifacationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Nothing
        Me.TableAdapterManager.IN_patientsTableAdapter = Nothing
        Me.TableAdapterManager.medicationsTableAdapter = Nothing
        Me.TableAdapterManager.patientsTableAdapter = Nothing
        Me.TableAdapterManager.qualifacationTableAdapter = Me.QualifacationTableAdapter
        Me.TableAdapterManager.requisitionsTableAdapter = Nothing
        Me.TableAdapterManager.SearchTableAdapter = Nothing
        Me.TableAdapterManager.shiftsTableAdapter = Nothing
        Me.TableAdapterManager.staffsTableAdapter = Nothing
        Me.TableAdapterManager.suppilersTableAdapter = Nothing
        Me.TableAdapterManager.suppilesTableAdapter = Nothing
        Me.TableAdapterManager.treatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _73_data.dbpro73DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        Me.TableAdapterManager.workexpTableAdapter = Nothing
        '
        'QualifacationBindingNavigator
        '
        Me.QualifacationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QualifacationBindingNavigator.BindingSource = Me.QualifacationBindingSource
        Me.QualifacationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QualifacationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QualifacationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QualifacationBindingNavigatorSaveItem})
        Me.QualifacationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QualifacationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QualifacationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QualifacationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QualifacationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QualifacationBindingNavigator.Name = "QualifacationBindingNavigator"
        Me.QualifacationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QualifacationBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.QualifacationBindingNavigator.TabIndex = 136
        Me.QualifacationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'QualifacationBindingNavigatorSaveItem
        '
        Me.QualifacationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QualifacationBindingNavigatorSaveItem.Image = CType(resources.GetObject("QualifacationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QualifacationBindingNavigatorSaveItem.Name = "QualifacationBindingNavigatorSaveItem"
        Me.QualifacationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QualifacationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QualifacationDataGridView
        '
        Me.QualifacationDataGridView.AutoGenerateColumns = False
        Me.QualifacationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualifacationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.QualifacationDataGridView.DataSource = Me.QualifacationBindingSource
        Me.QualifacationDataGridView.Location = New System.Drawing.Point(98, 251)
        Me.QualifacationDataGridView.Name = "QualifacationDataGridView"
        Me.QualifacationDataGridView.Size = New System.Drawing.Size(545, 220)
        Me.QualifacationDataGridView.TabIndex = 136
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "qualifacation_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "qualifacation_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "staffs_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "staffs_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "qualifacation_type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "qualifacation_type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "qualifacation_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "qualifacation_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "qualifacation_ins"
        Me.DataGridViewTextBoxColumn5.HeaderText = "qualifacation_ins"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Qualifacation_idTextBox
        '
        Me.Qualifacation_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifacationBindingSource, "qualifacation_id", True))
        Me.Qualifacation_idTextBox.Location = New System.Drawing.Point(295, 91)
        Me.Qualifacation_idTextBox.Name = "Qualifacation_idTextBox"
        Me.Qualifacation_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Qualifacation_idTextBox.TabIndex = 137
        '
        'Staffs_idTextBox
        '
        Me.Staffs_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifacationBindingSource, "staffs_id", True))
        Me.Staffs_idTextBox.Location = New System.Drawing.Point(295, 117)
        Me.Staffs_idTextBox.Name = "Staffs_idTextBox"
        Me.Staffs_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_idTextBox.TabIndex = 139
        '
        'Qualifacation_typeTextBox
        '
        Me.Qualifacation_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifacationBindingSource, "qualifacation_type", True))
        Me.Qualifacation_typeTextBox.Location = New System.Drawing.Point(295, 143)
        Me.Qualifacation_typeTextBox.Name = "Qualifacation_typeTextBox"
        Me.Qualifacation_typeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Qualifacation_typeTextBox.TabIndex = 141
        '
        'Qualifacation_dateDateTimePicker
        '
        Me.Qualifacation_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QualifacationBindingSource, "qualifacation_date", True))
        Me.Qualifacation_dateDateTimePicker.Location = New System.Drawing.Point(295, 169)
        Me.Qualifacation_dateDateTimePicker.Name = "Qualifacation_dateDateTimePicker"
        Me.Qualifacation_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Qualifacation_dateDateTimePicker.TabIndex = 143
        '
        'Qualifacation_insTextBox
        '
        Me.Qualifacation_insTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifacationBindingSource, "qualifacation_ins", True))
        Me.Qualifacation_insTextBox.Location = New System.Drawing.Point(295, 195)
        Me.Qualifacation_insTextBox.Name = "Qualifacation_insTextBox"
        Me.Qualifacation_insTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Qualifacation_insTextBox.TabIndex = 145
        '
        'Q
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 493)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.Qualifacation_idTextBox)
        Me.Controls.Add(Me.Staffs_idTextBox)
        Me.Controls.Add(Me.Qualifacation_typeTextBox)
        Me.Controls.Add(Me.Qualifacation_dateDateTimePicker)
        Me.Controls.Add(Me.Qualifacation_insTextBox)
        Me.Controls.Add(Me.QualifacationDataGridView)
        Me.Controls.Add(Me.QualifacationBindingNavigator)
        Me.Controls.Add(Qualifacation_typeLabel)
        Me.Controls.Add(Qualifacation_dateLabel)
        Me.Controls.Add(Qualifacation_insLabel)
        Me.Controls.Add(Qualifacation_idLabel)
        Me.Controls.Add(Staffs_idLabel)
        Me.Name = "Q"
        Me.Text = "Q"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualifacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualifacationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QualifacationBindingNavigator.ResumeLayout(False)
        Me.QualifacationBindingNavigator.PerformLayout()
        CType(Me.QualifacationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents QualifacationBindingSource As BindingSource
    Friend WithEvents QualifacationTableAdapter As dbpro73DataSetTableAdapters.qualifacationTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QualifacationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents QualifacationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents QualifacationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Qualifacation_idTextBox As TextBox
    Friend WithEvents Staffs_idTextBox As TextBox
    Friend WithEvents Qualifacation_typeTextBox As TextBox
    Friend WithEvents Qualifacation_dateDateTimePicker As DateTimePicker
    Friend WithEvents Qualifacation_insTextBox As TextBox
End Class
