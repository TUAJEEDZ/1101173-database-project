<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RWTL_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RWTL_report))
        Me.Button1 = New System.Windows.Forms.Button()
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
        Patients_idLabel = New System.Windows.Forms.Label()
        Wards_idLabel = New System.Windows.Forms.Label()
        On_WaitingListLabel = New System.Windows.Forms.Label()
        ExpectedstayLabel = New System.Windows.Forms.Label()
        Date_placedLabel = New System.Windows.Forms.Label()
        Date_leaveLabel = New System.Windows.Forms.Label()
        Actual_leaveLabel = New System.Windows.Forms.Label()
        Bed_numberLabel = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN_patientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN_patientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IN_patientsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patients_idLabel
        '
        Patients_idLabel.AutoSize = True
        Patients_idLabel.Location = New System.Drawing.Point(103, 168)
        Patients_idLabel.Name = "Patients_idLabel"
        Patients_idLabel.Size = New System.Drawing.Size(58, 13)
        Patients_idLabel.TabIndex = 210
        Patients_idLabel.Text = "patients id:"
        '
        'Wards_idLabel
        '
        Wards_idLabel.AutoSize = True
        Wards_idLabel.Location = New System.Drawing.Point(103, 194)
        Wards_idLabel.Name = "Wards_idLabel"
        Wards_idLabel.Size = New System.Drawing.Size(49, 13)
        Wards_idLabel.TabIndex = 212
        Wards_idLabel.Text = "wards id:"
        '
        'On_WaitingListLabel
        '
        On_WaitingListLabel.AutoSize = True
        On_WaitingListLabel.Location = New System.Drawing.Point(103, 221)
        On_WaitingListLabel.Name = "On_WaitingListLabel"
        On_WaitingListLabel.Size = New System.Drawing.Size(82, 13)
        On_WaitingListLabel.TabIndex = 214
        On_WaitingListLabel.Text = "On Waiting List:"
        '
        'ExpectedstayLabel
        '
        ExpectedstayLabel.AutoSize = True
        ExpectedstayLabel.Location = New System.Drawing.Point(103, 246)
        ExpectedstayLabel.Name = "ExpectedstayLabel"
        ExpectedstayLabel.Size = New System.Drawing.Size(74, 13)
        ExpectedstayLabel.TabIndex = 216
        ExpectedstayLabel.Text = "Expectedstay:"
        '
        'Date_placedLabel
        '
        Date_placedLabel.AutoSize = True
        Date_placedLabel.Location = New System.Drawing.Point(103, 273)
        Date_placedLabel.Name = "Date_placedLabel"
        Date_placedLabel.Size = New System.Drawing.Size(66, 13)
        Date_placedLabel.TabIndex = 218
        Date_placedLabel.Text = "date placed:"
        '
        'Date_leaveLabel
        '
        Date_leaveLabel.AutoSize = True
        Date_leaveLabel.Location = New System.Drawing.Point(103, 299)
        Date_leaveLabel.Name = "Date_leaveLabel"
        Date_leaveLabel.Size = New System.Drawing.Size(60, 13)
        Date_leaveLabel.TabIndex = 220
        Date_leaveLabel.Text = "date leave:"
        '
        'Actual_leaveLabel
        '
        Actual_leaveLabel.AutoSize = True
        Actual_leaveLabel.Location = New System.Drawing.Point(103, 325)
        Actual_leaveLabel.Name = "Actual_leaveLabel"
        Actual_leaveLabel.Size = New System.Drawing.Size(68, 13)
        Actual_leaveLabel.TabIndex = 222
        Actual_leaveLabel.Text = "actual leave:"
        '
        'Bed_numberLabel
        '
        Bed_numberLabel.AutoSize = True
        Bed_numberLabel.Location = New System.Drawing.Point(103, 350)
        Bed_numberLabel.Name = "Bed_numberLabel"
        Bed_numberLabel.Size = New System.Drawing.Size(66, 13)
        Bed_numberLabel.TabIndex = 224
        Bed_numberLabel.Text = "bed number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 209
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.IN_patientsTableAdapter = Me.IN_patientsTableAdapter
        Me.TableAdapterManager.medicationsTableAdapter = Nothing
        Me.TableAdapterManager.patientsTableAdapter = Nothing
        Me.TableAdapterManager.requisitionsTableAdapter = Nothing
        Me.TableAdapterManager.SearchTableAdapter = Nothing
        Me.TableAdapterManager.shiftsTableAdapter = Nothing
        Me.TableAdapterManager.staffsTableAdapter = Nothing
        Me.TableAdapterManager.suppilersTableAdapter = Nothing
        Me.TableAdapterManager.suppilesTableAdapter = Nothing
        Me.TableAdapterManager.treatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _73_data.dbpro73DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        '
        'IN_patientsBindingNavigator
        '
        Me.IN_patientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IN_patientsBindingNavigator.BindingSource = Me.IN_patientsBindingSource
        Me.IN_patientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IN_patientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IN_patientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.IN_patientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IN_patientsBindingNavigatorSaveItem})
        Me.IN_patientsBindingNavigator.Location = New System.Drawing.Point(106, 121)
        Me.IN_patientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IN_patientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IN_patientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IN_patientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IN_patientsBindingNavigator.Name = "IN_patientsBindingNavigator"
        Me.IN_patientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IN_patientsBindingNavigator.Size = New System.Drawing.Size(309, 25)
        Me.IN_patientsBindingNavigator.TabIndex = 210
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
        Me.Patients_idTextBox.Location = New System.Drawing.Point(191, 165)
        Me.Patients_idTextBox.Name = "Patients_idTextBox"
        Me.Patients_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_idTextBox.TabIndex = 211
        '
        'Wards_idTextBox
        '
        Me.Wards_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "wards_id", True))
        Me.Wards_idTextBox.Location = New System.Drawing.Point(191, 191)
        Me.Wards_idTextBox.Name = "Wards_idTextBox"
        Me.Wards_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Wards_idTextBox.TabIndex = 213
        '
        'On_WaitingListDateTimePicker
        '
        Me.On_WaitingListDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "On_WaitingList", True))
        Me.On_WaitingListDateTimePicker.Location = New System.Drawing.Point(191, 217)
        Me.On_WaitingListDateTimePicker.Name = "On_WaitingListDateTimePicker"
        Me.On_WaitingListDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.On_WaitingListDateTimePicker.TabIndex = 215
        '
        'ExpectedstayTextBox
        '
        Me.ExpectedstayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "Expectedstay", True))
        Me.ExpectedstayTextBox.Location = New System.Drawing.Point(191, 243)
        Me.ExpectedstayTextBox.Name = "ExpectedstayTextBox"
        Me.ExpectedstayTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ExpectedstayTextBox.TabIndex = 217
        '
        'Date_placedDateTimePicker
        '
        Me.Date_placedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "date_placed", True))
        Me.Date_placedDateTimePicker.Location = New System.Drawing.Point(191, 269)
        Me.Date_placedDateTimePicker.Name = "Date_placedDateTimePicker"
        Me.Date_placedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_placedDateTimePicker.TabIndex = 219
        '
        'Date_leaveDateTimePicker
        '
        Me.Date_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "date_leave", True))
        Me.Date_leaveDateTimePicker.Location = New System.Drawing.Point(191, 295)
        Me.Date_leaveDateTimePicker.Name = "Date_leaveDateTimePicker"
        Me.Date_leaveDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_leaveDateTimePicker.TabIndex = 221
        '
        'Actual_leaveDateTimePicker
        '
        Me.Actual_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IN_patientsBindingSource, "actual_leave", True))
        Me.Actual_leaveDateTimePicker.Location = New System.Drawing.Point(191, 321)
        Me.Actual_leaveDateTimePicker.Name = "Actual_leaveDateTimePicker"
        Me.Actual_leaveDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Actual_leaveDateTimePicker.TabIndex = 223
        '
        'Bed_numberTextBox
        '
        Me.Bed_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IN_patientsBindingSource, "bed_number", True))
        Me.Bed_numberTextBox.Location = New System.Drawing.Point(191, 347)
        Me.Bed_numberTextBox.Name = "Bed_numberTextBox"
        Me.Bed_numberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bed_numberTextBox.TabIndex = 225
        '
        'RWTL_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 599)
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
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RWTL_report"
        Me.Text = "RWTL_report"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN_patientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN_patientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IN_patientsBindingNavigator.ResumeLayout(False)
        Me.IN_patientsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
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
End Class
