<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requisiton_search
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
        Dim Patients_idLabel As System.Windows.Forms.Label
        Dim Wards_idLabel As System.Windows.Forms.Label
        Dim On_WaitingListLabel As System.Windows.Forms.Label
        Dim ExpectedstayLabel As System.Windows.Forms.Label
        Dim Date_placedLabel As System.Windows.Forms.Label
        Dim Date_leaveLabel As System.Windows.Forms.Label
        Dim Actual_leaveLabel As System.Windows.Forms.Label
        Dim Bed_numberLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(requisiton_search))
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.IN_patientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IN_patientsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.IN_patientsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.IN_patientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IN_patientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patients_idTextBox = New System.Windows.Forms.TextBox()
        Me.Wards_idTextBox = New System.Windows.Forms.TextBox()
        Me.On_WaitingListDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpectedstayTextBox = New System.Windows.Forms.TextBox()
        Me.Date_placedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_leaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Actual_leaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Bed_numberTextBox = New System.Windows.Forms.TextBox()
        Me.IN_patientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Patients_idLabel = New System.Windows.Forms.Label()
        Wards_idLabel = New System.Windows.Forms.Label()
        On_WaitingListLabel = New System.Windows.Forms.Label()
        ExpectedstayLabel = New System.Windows.Forms.Label()
        Date_placedLabel = New System.Windows.Forms.Label()
        Date_leaveLabel = New System.Windows.Forms.Label()
        Actual_leaveLabel = New System.Windows.Forms.Label()
        Bed_numberLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN_patientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN_patientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IN_patientsBindingNavigator.SuspendLayout()
        CType(Me.IN_patientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patients_idLabel
        '
        Patients_idLabel.AutoSize = True
        Patients_idLabel.Location = New System.Drawing.Point(106, 81)
        Patients_idLabel.Name = "Patients_idLabel"
        Patients_idLabel.Size = New System.Drawing.Size(58, 13)
        Patients_idLabel.TabIndex = 1
        Patients_idLabel.Text = "patients id:"
        '
        'Wards_idLabel
        '
        Wards_idLabel.AutoSize = True
        Wards_idLabel.Location = New System.Drawing.Point(106, 107)
        Wards_idLabel.Name = "Wards_idLabel"
        Wards_idLabel.Size = New System.Drawing.Size(49, 13)
        Wards_idLabel.TabIndex = 3
        Wards_idLabel.Text = "wards id:"
        '
        'On_WaitingListLabel
        '
        On_WaitingListLabel.AutoSize = True
        On_WaitingListLabel.Location = New System.Drawing.Point(106, 134)
        On_WaitingListLabel.Name = "On_WaitingListLabel"
        On_WaitingListLabel.Size = New System.Drawing.Size(82, 13)
        On_WaitingListLabel.TabIndex = 5
        On_WaitingListLabel.Text = "On Waiting List:"
        '
        'ExpectedstayLabel
        '
        ExpectedstayLabel.AutoSize = True
        ExpectedstayLabel.Location = New System.Drawing.Point(106, 159)
        ExpectedstayLabel.Name = "ExpectedstayLabel"
        ExpectedstayLabel.Size = New System.Drawing.Size(74, 13)
        ExpectedstayLabel.TabIndex = 7
        ExpectedstayLabel.Text = "Expectedstay:"
        '
        'Date_placedLabel
        '
        Date_placedLabel.AutoSize = True
        Date_placedLabel.Location = New System.Drawing.Point(481, 85)
        Date_placedLabel.Name = "Date_placedLabel"
        Date_placedLabel.Size = New System.Drawing.Size(66, 13)
        Date_placedLabel.TabIndex = 9
        Date_placedLabel.Text = "date placed:"
        '
        'Date_leaveLabel
        '
        Date_leaveLabel.AutoSize = True
        Date_leaveLabel.Location = New System.Drawing.Point(481, 111)
        Date_leaveLabel.Name = "Date_leaveLabel"
        Date_leaveLabel.Size = New System.Drawing.Size(60, 13)
        Date_leaveLabel.TabIndex = 11
        Date_leaveLabel.Text = "date leave:"
        '
        'Actual_leaveLabel
        '
        Actual_leaveLabel.AutoSize = True
        Actual_leaveLabel.Location = New System.Drawing.Point(481, 137)
        Actual_leaveLabel.Name = "Actual_leaveLabel"
        Actual_leaveLabel.Size = New System.Drawing.Size(68, 13)
        Actual_leaveLabel.TabIndex = 13
        Actual_leaveLabel.Text = "actual leave:"
        '
        'Bed_numberLabel
        '
        Bed_numberLabel.AutoSize = True
        Bed_numberLabel.Location = New System.Drawing.Point(481, 162)
        Bed_numberLabel.Name = "Bed_numberLabel"
        Bed_numberLabel.Size = New System.Drawing.Size(66, 13)
        Bed_numberLabel.TabIndex = 15
        Bed_numberLabel.Text = "bed number:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(416, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 18
        Label1.Text = "WAITING LIST"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IN_patientsBindingSource
        '
        Me.IN_patientsBindingSource.DataMember = "IN_patients"
        Me.IN_patientsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'IN_patientsTableAdapter
        '
        Me.IN_patientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Nothing
        Me.TableAdapterManager.IN_patientsTableAdapter = Me.IN_patientsTableAdapter
        Me.TableAdapterManager.medicationsTableAdapter = Nothing
        Me.TableAdapterManager.patientsTableAdapter = Nothing
        Me.TableAdapterManager.qualifacationTableAdapter = Nothing
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
        'IN_patientsBindingNavigator
        '
        Me.IN_patientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IN_patientsBindingNavigator.BindingSource = Me.IN_patientsBindingSource
        Me.IN_patientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IN_patientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IN_patientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.IN_patientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IN_patientsBindingNavigatorSaveItem})
        Me.IN_patientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IN_patientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IN_patientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IN_patientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IN_patientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IN_patientsBindingNavigator.Name = "IN_patientsBindingNavigator"
        Me.IN_patientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IN_patientsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.IN_patientsBindingNavigator.TabIndex = 0
        Me.IN_patientsBindingNavigator.Text = "BindingNavigator1"
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
        'IN_patientsBindingNavigatorSaveItem
        '
        Me.IN_patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IN_patientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("IN_patientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IN_patientsBindingNavigatorSaveItem.Name = "IN_patientsBindingNavigatorSaveItem"
        Me.IN_patientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IN_patientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patients_idTextBox
        '
        Me.Patients_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "patients_id", True))
        Me.Patients_idTextBox.Location = New System.Drawing.Point(194, 78)
        Me.Patients_idTextBox.Name = "Patients_idTextBox"
        Me.Patients_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_idTextBox.TabIndex = 2
        '
        'Wards_idTextBox
        '
        Me.Wards_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "wards_id", True))
        Me.Wards_idTextBox.Location = New System.Drawing.Point(194, 104)
        Me.Wards_idTextBox.Name = "Wards_idTextBox"
        Me.Wards_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Wards_idTextBox.TabIndex = 4
        '
        'On_WaitingListDateTimePicker
        '
        Me.On_WaitingListDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "On_WaitingList", True))
        Me.On_WaitingListDateTimePicker.Location = New System.Drawing.Point(194, 130)
        Me.On_WaitingListDateTimePicker.Name = "On_WaitingListDateTimePicker"
        Me.On_WaitingListDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.On_WaitingListDateTimePicker.TabIndex = 6
        '
        'ExpectedstayTextBox
        '
        Me.ExpectedstayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "Expectedstay", True))
        Me.ExpectedstayTextBox.Location = New System.Drawing.Point(194, 156)
        Me.ExpectedstayTextBox.Name = "ExpectedstayTextBox"
        Me.ExpectedstayTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ExpectedstayTextBox.TabIndex = 8
        '
        'Date_placedDateTimePicker
        '
        Me.Date_placedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "date_placed", True))
        Me.Date_placedDateTimePicker.Location = New System.Drawing.Point(569, 81)
        Me.Date_placedDateTimePicker.Name = "Date_placedDateTimePicker"
        Me.Date_placedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_placedDateTimePicker.TabIndex = 10
        '
        'Date_leaveDateTimePicker
        '
        Me.Date_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "date_leave", True))
        Me.Date_leaveDateTimePicker.Location = New System.Drawing.Point(569, 107)
        Me.Date_leaveDateTimePicker.Name = "Date_leaveDateTimePicker"
        Me.Date_leaveDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_leaveDateTimePicker.TabIndex = 12
        '
        'Actual_leaveDateTimePicker
        '
        Me.Actual_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "actual_leave", True))
        Me.Actual_leaveDateTimePicker.Location = New System.Drawing.Point(569, 133)
        Me.Actual_leaveDateTimePicker.Name = "Actual_leaveDateTimePicker"
        Me.Actual_leaveDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Actual_leaveDateTimePicker.TabIndex = 14
        '
        'Bed_numberTextBox
        '
        Me.Bed_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "bed_number", True))
        Me.Bed_numberTextBox.Location = New System.Drawing.Point(569, 159)
        Me.Bed_numberTextBox.Name = "Bed_numberTextBox"
        Me.Bed_numberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bed_numberTextBox.TabIndex = 16
        '
        'IN_patientsDataGridView
        '
        Me.IN_patientsDataGridView.AutoGenerateColumns = False
        Me.IN_patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IN_patientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.IN_patientsDataGridView.DataSource = Me.IN_patientsBindingSource
        Me.IN_patientsDataGridView.Location = New System.Drawing.Point(47, 238)
        Me.IN_patientsDataGridView.Name = "IN_patientsDataGridView"
        Me.IN_patientsDataGridView.Size = New System.Drawing.Size(845, 220)
        Me.IN_patientsDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "patients_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "patients_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "wards_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "wards_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "On_WaitingList"
        Me.DataGridViewTextBoxColumn3.HeaderText = "On_WaitingList"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Expectedstay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Expectedstay"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_placed"
        Me.DataGridViewTextBoxColumn5.HeaderText = "date_placed"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date_leave"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date_leave"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "actual_leave"
        Me.DataGridViewTextBoxColumn7.HeaderText = "actual_leave"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "bed_number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "bed_number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(400, 76)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(47, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 198
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'requisiton_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 528)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IN_patientsDataGridView)
        Me.Controls.Add(Patients_idLabel)
        Me.Controls.Add(Me.Patients_idTextBox)
        Me.Controls.Add(Wards_idLabel)
        Me.Controls.Add(Me.Wards_idTextBox)
        Me.Controls.Add(On_WaitingListLabel)
        Me.Controls.Add(Me.On_WaitingListDateTimePicker)
        Me.Controls.Add(ExpectedstayLabel)
        Me.Controls.Add(Me.ExpectedstayTextBox)
        Me.Controls.Add(Date_placedLabel)
        Me.Controls.Add(Me.Date_placedDateTimePicker)
        Me.Controls.Add(Date_leaveLabel)
        Me.Controls.Add(Me.Date_leaveDateTimePicker)
        Me.Controls.Add(Actual_leaveLabel)
        Me.Controls.Add(Me.Actual_leaveDateTimePicker)
        Me.Controls.Add(Bed_numberLabel)
        Me.Controls.Add(Me.Bed_numberTextBox)
        Me.Controls.Add(Me.IN_patientsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "requisiton_search"
        Me.Text = "requisiton_search"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN_patientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN_patientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IN_patientsBindingNavigator.ResumeLayout(False)
        Me.IN_patientsBindingNavigator.PerformLayout()
        CType(Me.IN_patientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents IN_patientsBindingSource As BindingSource
    Friend WithEvents IN_patientsTableAdapter As dbpro73DataSetTableAdapters.IN_patientsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IN_patientsBindingNavigator As BindingNavigator
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
    Friend WithEvents IN_patientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Patients_idTextBox As TextBox
    Friend WithEvents Wards_idTextBox As TextBox
    Friend WithEvents On_WaitingListDateTimePicker As DateTimePicker
    Friend WithEvents ExpectedstayTextBox As TextBox
    Friend WithEvents Date_placedDateTimePicker As DateTimePicker
    Friend WithEvents Date_leaveDateTimePicker As DateTimePicker
    Friend WithEvents Actual_leaveDateTimePicker As DateTimePicker
    Friend WithEvents Bed_numberTextBox As TextBox
    Friend WithEvents IN_patientsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
