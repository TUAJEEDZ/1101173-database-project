<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shift
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
        Dim ShiftsLabel As System.Windows.Forms.Label
        Dim StartdateLabel As System.Windows.Forms.Label
        Dim Staffs_idLabel As System.Windows.Forms.Label
        Dim Wards_idLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(shift))
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.ShiftsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.shiftsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.ShiftsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ShiftsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShiftsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftsTextBox = New System.Windows.Forms.TextBox()
        Me.StartdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Staffs_idTextBox = New System.Windows.Forms.TextBox()
        Me.Wards_idTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        ShiftsLabel = New System.Windows.Forms.Label()
        StartdateLabel = New System.Windows.Forms.Label()
        Staffs_idLabel = New System.Windows.Forms.Label()
        Wards_idLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShiftsBindingNavigator.SuspendLayout()
        CType(Me.ShiftsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShiftsLabel
        '
        ShiftsLabel.AutoSize = True
        ShiftsLabel.Location = New System.Drawing.Point(233, 85)
        ShiftsLabel.Name = "ShiftsLabel"
        ShiftsLabel.Size = New System.Drawing.Size(36, 13)
        ShiftsLabel.TabIndex = 2
        ShiftsLabel.Text = "Shifts:"
        '
        'StartdateLabel
        '
        StartdateLabel.AutoSize = True
        StartdateLabel.Location = New System.Drawing.Point(233, 112)
        StartdateLabel.Name = "StartdateLabel"
        StartdateLabel.Size = New System.Drawing.Size(53, 13)
        StartdateLabel.TabIndex = 4
        StartdateLabel.Text = "Startdate:"
        '
        'Staffs_idLabel
        '
        Staffs_idLabel.AutoSize = True
        Staffs_idLabel.Location = New System.Drawing.Point(233, 137)
        Staffs_idLabel.Name = "Staffs_idLabel"
        Staffs_idLabel.Size = New System.Drawing.Size(48, 13)
        Staffs_idLabel.TabIndex = 6
        Staffs_idLabel.Text = "Staffs id:"
        '
        'Wards_idLabel
        '
        Wards_idLabel.AutoSize = True
        Wards_idLabel.Location = New System.Drawing.Point(233, 163)
        Wards_idLabel.Name = "Wards_idLabel"
        Wards_idLabel.Size = New System.Drawing.Size(52, 13)
        Wards_idLabel.TabIndex = 8
        Wards_idLabel.Text = "Wards id:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label9.Location = New System.Drawing.Point(365, 38)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(50, 18)
        Label9.TabIndex = 195
        Label9.Text = "SHIFT"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShiftsBindingSource
        '
        Me.ShiftsBindingSource.DataMember = "shifts"
        Me.ShiftsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'ShiftsTableAdapter
        '
        Me.ShiftsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Nothing
        Me.TableAdapterManager.IN_patientsTableAdapter = Nothing
        Me.TableAdapterManager.medicationsTableAdapter = Nothing
        Me.TableAdapterManager.patientsTableAdapter = Nothing
        Me.TableAdapterManager.qualifacationTableAdapter = Nothing
        Me.TableAdapterManager.requisitionsTableAdapter = Nothing
        Me.TableAdapterManager.SearchTableAdapter = Nothing
        Me.TableAdapterManager.shiftsTableAdapter = Me.ShiftsTableAdapter
        Me.TableAdapterManager.staffsTableAdapter = Nothing
        Me.TableAdapterManager.suppilersTableAdapter = Nothing
        Me.TableAdapterManager.suppilesTableAdapter = Nothing
        Me.TableAdapterManager.treatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _73_data.dbpro73DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        Me.TableAdapterManager.workexpTableAdapter = Nothing
        '
        'ShiftsBindingNavigator
        '
        Me.ShiftsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShiftsBindingNavigator.BindingSource = Me.ShiftsBindingSource
        Me.ShiftsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ShiftsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShiftsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ShiftsBindingNavigatorSaveItem})
        Me.ShiftsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ShiftsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ShiftsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ShiftsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ShiftsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ShiftsBindingNavigator.Name = "ShiftsBindingNavigator"
        Me.ShiftsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ShiftsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ShiftsBindingNavigator.TabIndex = 0
        Me.ShiftsBindingNavigator.Text = "BindingNavigator1"
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
        'ShiftsBindingNavigatorSaveItem
        '
        Me.ShiftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShiftsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShiftsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShiftsBindingNavigatorSaveItem.Name = "ShiftsBindingNavigatorSaveItem"
        Me.ShiftsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ShiftsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShiftsDataGridView
        '
        Me.ShiftsDataGridView.AutoGenerateColumns = False
        Me.ShiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShiftsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ShiftsDataGridView.DataSource = Me.ShiftsBindingSource
        Me.ShiftsDataGridView.Location = New System.Drawing.Point(154, 197)
        Me.ShiftsDataGridView.Name = "ShiftsDataGridView"
        Me.ShiftsDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.ShiftsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "shifts"
        Me.DataGridViewTextBoxColumn1.HeaderText = "shifts"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "startdate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "startdate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "staffs_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "staffs_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "wards_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "wards_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ShiftsTextBox
        '
        Me.ShiftsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "shifts", True))
        Me.ShiftsTextBox.Location = New System.Drawing.Point(290, 82)
        Me.ShiftsTextBox.Name = "ShiftsTextBox"
        Me.ShiftsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShiftsTextBox.TabIndex = 3
        '
        'StartdateDateTimePicker
        '
        Me.StartdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ShiftsBindingSource, "startdate", True))
        Me.StartdateDateTimePicker.Location = New System.Drawing.Point(290, 108)
        Me.StartdateDateTimePicker.Name = "StartdateDateTimePicker"
        Me.StartdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.StartdateDateTimePicker.TabIndex = 5
        '
        'Staffs_idTextBox
        '
        Me.Staffs_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "staffs_id", True))
        Me.Staffs_idTextBox.Location = New System.Drawing.Point(290, 134)
        Me.Staffs_idTextBox.Name = "Staffs_idTextBox"
        Me.Staffs_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_idTextBox.TabIndex = 7
        '
        'Wards_idTextBox
        '
        Me.Wards_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "wards_id", True))
        Me.Wards_idTextBox.Location = New System.Drawing.Point(290, 160)
        Me.Wards_idTextBox.Name = "Wards_idTextBox"
        Me.Wards_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Wards_idTextBox.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(496, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 23)
        Me.Button6.TabIndex = 197
        Me.Button6.Text = "-"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(496, 134)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 23)
        Me.Button7.TabIndex = 196
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'shift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 533)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Label9)
        Me.Controls.Add(ShiftsLabel)
        Me.Controls.Add(Me.ShiftsTextBox)
        Me.Controls.Add(StartdateLabel)
        Me.Controls.Add(Me.StartdateDateTimePicker)
        Me.Controls.Add(Staffs_idLabel)
        Me.Controls.Add(Me.Staffs_idTextBox)
        Me.Controls.Add(Wards_idLabel)
        Me.Controls.Add(Me.Wards_idTextBox)
        Me.Controls.Add(Me.ShiftsDataGridView)
        Me.Controls.Add(Me.ShiftsBindingNavigator)
        Me.Name = "shift"
        Me.Text = "shift"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShiftsBindingNavigator.ResumeLayout(False)
        Me.ShiftsBindingNavigator.PerformLayout()
        CType(Me.ShiftsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents ShiftsBindingSource As BindingSource
    Friend WithEvents ShiftsTableAdapter As dbpro73DataSetTableAdapters.shiftsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ShiftsBindingNavigator As BindingNavigator
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
    Friend WithEvents ShiftsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ShiftsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ShiftsTextBox As TextBox
    Friend WithEvents StartdateDateTimePicker As DateTimePicker
    Friend WithEvents Staffs_idTextBox As TextBox
    Friend WithEvents Wards_idTextBox As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
