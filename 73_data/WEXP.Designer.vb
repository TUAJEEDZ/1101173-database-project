<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WEXP
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
        Dim Workexp_idLabel As System.Windows.Forms.Label
        Dim Staffs_idLabel As System.Windows.Forms.Label
        Dim Workexp_positionLabel As System.Windows.Forms.Label
        Dim Workexp_startdateLabel As System.Windows.Forms.Label
        Dim Workexp_finishdateLabel As System.Windows.Forms.Label
        Dim Name_ognLabel As System.Windows.Forms.Label
        Dim Workexp_surguryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WEXP))
        Dim Label11 As System.Windows.Forms.Label
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.WorkexpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkexpTableAdapter = New _73_data.dbpro73DataSetTableAdapters.workexpTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.WorkexpBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WorkexpBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WorkexpDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Workexp_idTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_idTextBox = New System.Windows.Forms.TextBox()
        Me.Workexp_positionTextBox = New System.Windows.Forms.TextBox()
        Me.Workexp_startdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Workexp_finishdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Name_ognTextBox = New System.Windows.Forms.TextBox()
        Me.Workexp_surguryTextBox = New System.Windows.Forms.TextBox()
        Workexp_idLabel = New System.Windows.Forms.Label()
        Staffs_idLabel = New System.Windows.Forms.Label()
        Workexp_positionLabel = New System.Windows.Forms.Label()
        Workexp_startdateLabel = New System.Windows.Forms.Label()
        Workexp_finishdateLabel = New System.Windows.Forms.Label()
        Name_ognLabel = New System.Windows.Forms.Label()
        Workexp_surguryLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkexpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkexpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkexpBindingNavigator.SuspendLayout()
        CType(Me.WorkexpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Workexp_idLabel
        '
        Workexp_idLabel.AutoSize = True
        Workexp_idLabel.Location = New System.Drawing.Point(235, 73)
        Workexp_idLabel.Name = "Workexp_idLabel"
        Workexp_idLabel.Size = New System.Drawing.Size(79, 13)
        Workexp_idLabel.TabIndex = 2
        Workexp_idLabel.Text = "WORKEXP ID:"
        '
        'Staffs_idLabel
        '
        Staffs_idLabel.AutoSize = True
        Staffs_idLabel.Location = New System.Drawing.Point(235, 99)
        Staffs_idLabel.Name = "Staffs_idLabel"
        Staffs_idLabel.Size = New System.Drawing.Size(51, 13)
        Staffs_idLabel.TabIndex = 4
        Staffs_idLabel.Text = "Staffs ID:"
        '
        'Workexp_positionLabel
        '
        Workexp_positionLabel.AutoSize = True
        Workexp_positionLabel.Location = New System.Drawing.Point(235, 125)
        Workexp_positionLabel.Name = "Workexp_positionLabel"
        Workexp_positionLabel.Size = New System.Drawing.Size(47, 13)
        Workexp_positionLabel.TabIndex = 6
        Workexp_positionLabel.Text = "Position:"
        '
        'Workexp_startdateLabel
        '
        Workexp_startdateLabel.AutoSize = True
        Workexp_startdateLabel.Location = New System.Drawing.Point(235, 152)
        Workexp_startdateLabel.Name = "Workexp_startdateLabel"
        Workexp_startdateLabel.Size = New System.Drawing.Size(53, 13)
        Workexp_startdateLabel.TabIndex = 8
        Workexp_startdateLabel.Text = "Startdate:"
        '
        'Workexp_finishdateLabel
        '
        Workexp_finishdateLabel.AutoSize = True
        Workexp_finishdateLabel.Location = New System.Drawing.Point(235, 178)
        Workexp_finishdateLabel.Name = "Workexp_finishdateLabel"
        Workexp_finishdateLabel.Size = New System.Drawing.Size(58, 13)
        Workexp_finishdateLabel.TabIndex = 10
        Workexp_finishdateLabel.Text = "Finishdate:"
        '
        'Name_ognLabel
        '
        Name_ognLabel.AutoSize = True
        Name_ognLabel.Location = New System.Drawing.Point(235, 203)
        Name_ognLabel.Name = "Name_ognLabel"
        Name_ognLabel.Size = New System.Drawing.Size(66, 13)
        Name_ognLabel.TabIndex = 12
        Name_ognLabel.Text = "Oganization:"
        '
        'Workexp_surguryLabel
        '
        Workexp_surguryLabel.AutoSize = True
        Workexp_surguryLabel.Location = New System.Drawing.Point(235, 229)
        Workexp_surguryLabel.Name = "Workexp_surguryLabel"
        Workexp_surguryLabel.Size = New System.Drawing.Size(46, 13)
        Workexp_surguryLabel.TabIndex = 14
        Workexp_surguryLabel.Text = "Surgury:"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkexpBindingSource
        '
        Me.WorkexpBindingSource.DataMember = "workexp"
        Me.WorkexpBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'WorkexpTableAdapter
        '
        Me.WorkexpTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.shiftsTableAdapter = Nothing
        Me.TableAdapterManager.staffsTableAdapter = Nothing
        Me.TableAdapterManager.suppilersTableAdapter = Nothing
        Me.TableAdapterManager.suppilesTableAdapter = Nothing
        Me.TableAdapterManager.treatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _73_data.dbpro73DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        Me.TableAdapterManager.workexpTableAdapter = Me.WorkexpTableAdapter
        '
        'WorkexpBindingNavigator
        '
        Me.WorkexpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkexpBindingNavigator.BindingSource = Me.WorkexpBindingSource
        Me.WorkexpBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WorkexpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkexpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkexpBindingNavigatorSaveItem})
        Me.WorkexpBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkexpBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkexpBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkexpBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkexpBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkexpBindingNavigator.Name = "WorkexpBindingNavigator"
        Me.WorkexpBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkexpBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.WorkexpBindingNavigator.TabIndex = 0
        Me.WorkexpBindingNavigator.Text = "BindingNavigator1"
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
        'WorkexpBindingNavigatorSaveItem
        '
        Me.WorkexpBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WorkexpBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkexpBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkexpBindingNavigatorSaveItem.Name = "WorkexpBindingNavigatorSaveItem"
        Me.WorkexpBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WorkexpBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WorkexpDataGridView
        '
        Me.WorkexpDataGridView.AutoGenerateColumns = False
        Me.WorkexpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkexpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.WorkexpDataGridView.DataSource = Me.WorkexpBindingSource
        Me.WorkexpDataGridView.Location = New System.Drawing.Point(30, 272)
        Me.WorkexpDataGridView.Name = "WorkexpDataGridView"
        Me.WorkexpDataGridView.Size = New System.Drawing.Size(739, 220)
        Me.WorkexpDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "workexp_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "workexp_id"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "workexp_position"
        Me.DataGridViewTextBoxColumn3.HeaderText = "workexp_position"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "workexp_startdate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "workexp_startdate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "workexp_finishdate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "workexp_finishdate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "name_ogn"
        Me.DataGridViewTextBoxColumn6.HeaderText = "name_ogn"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "workexp_surgury"
        Me.DataGridViewTextBoxColumn7.HeaderText = "workexp_surgury"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Workexp_idTextBox
        '
        Me.Workexp_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkexpBindingSource, "workexp_id", True))
        Me.Workexp_idTextBox.Location = New System.Drawing.Point(339, 70)
        Me.Workexp_idTextBox.Name = "Workexp_idTextBox"
        Me.Workexp_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Workexp_idTextBox.TabIndex = 3
        '
        'Staffs_idTextBox
        '
        Me.Staffs_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkexpBindingSource, "staffs_id", True))
        Me.Staffs_idTextBox.Location = New System.Drawing.Point(339, 96)
        Me.Staffs_idTextBox.Name = "Staffs_idTextBox"
        Me.Staffs_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_idTextBox.TabIndex = 5
        '
        'Workexp_positionTextBox
        '
        Me.Workexp_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkexpBindingSource, "workexp_position", True))
        Me.Workexp_positionTextBox.Location = New System.Drawing.Point(339, 122)
        Me.Workexp_positionTextBox.Name = "Workexp_positionTextBox"
        Me.Workexp_positionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Workexp_positionTextBox.TabIndex = 7
        '
        'Workexp_startdateDateTimePicker
        '
        Me.Workexp_startdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkexpBindingSource, "workexp_startdate", True))
        Me.Workexp_startdateDateTimePicker.Location = New System.Drawing.Point(339, 148)
        Me.Workexp_startdateDateTimePicker.Name = "Workexp_startdateDateTimePicker"
        Me.Workexp_startdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Workexp_startdateDateTimePicker.TabIndex = 9
        '
        'Workexp_finishdateDateTimePicker
        '
        Me.Workexp_finishdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkexpBindingSource, "workexp_finishdate", True))
        Me.Workexp_finishdateDateTimePicker.Location = New System.Drawing.Point(339, 174)
        Me.Workexp_finishdateDateTimePicker.Name = "Workexp_finishdateDateTimePicker"
        Me.Workexp_finishdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Workexp_finishdateDateTimePicker.TabIndex = 11
        '
        'Name_ognTextBox
        '
        Me.Name_ognTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkexpBindingSource, "name_ogn", True))
        Me.Name_ognTextBox.Location = New System.Drawing.Point(339, 200)
        Me.Name_ognTextBox.Name = "Name_ognTextBox"
        Me.Name_ognTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_ognTextBox.TabIndex = 13
        '
        'Workexp_surguryTextBox
        '
        Me.Workexp_surguryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkexpBindingSource, "workexp_surgury", True))
        Me.Workexp_surguryTextBox.Location = New System.Drawing.Point(339, 226)
        Me.Workexp_surguryTextBox.Name = "Workexp_surguryTextBox"
        Me.Workexp_surguryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Workexp_surguryTextBox.TabIndex = 15
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label11.Location = New System.Drawing.Point(319, 34)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(166, 20)
        Label11.TabIndex = 147
        Label11.Text = "WORK EXPERIENCE"
        '
        'WEXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Workexp_idLabel)
        Me.Controls.Add(Me.Workexp_idTextBox)
        Me.Controls.Add(Staffs_idLabel)
        Me.Controls.Add(Me.Staffs_idTextBox)
        Me.Controls.Add(Workexp_positionLabel)
        Me.Controls.Add(Me.Workexp_positionTextBox)
        Me.Controls.Add(Workexp_startdateLabel)
        Me.Controls.Add(Me.Workexp_startdateDateTimePicker)
        Me.Controls.Add(Workexp_finishdateLabel)
        Me.Controls.Add(Me.Workexp_finishdateDateTimePicker)
        Me.Controls.Add(Name_ognLabel)
        Me.Controls.Add(Me.Name_ognTextBox)
        Me.Controls.Add(Workexp_surguryLabel)
        Me.Controls.Add(Me.Workexp_surguryTextBox)
        Me.Controls.Add(Me.WorkexpDataGridView)
        Me.Controls.Add(Me.WorkexpBindingNavigator)
        Me.Name = "WEXP"
        Me.Text = "WEXP"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkexpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkexpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkexpBindingNavigator.ResumeLayout(False)
        Me.WorkexpBindingNavigator.PerformLayout()
        CType(Me.WorkexpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents WorkexpBindingSource As BindingSource
    Friend WithEvents WorkexpTableAdapter As dbpro73DataSetTableAdapters.workexpTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkexpBindingNavigator As BindingNavigator
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
    Friend WithEvents WorkexpBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WorkexpDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Workexp_idTextBox As TextBox
    Friend WithEvents Staffs_idTextBox As TextBox
    Friend WithEvents Workexp_positionTextBox As TextBox
    Friend WithEvents Workexp_startdateDateTimePicker As DateTimePicker
    Friend WithEvents Workexp_finishdateDateTimePicker As DateTimePicker
    Friend WithEvents Name_ognTextBox As TextBox
    Friend WithEvents Workexp_surguryTextBox As TextBox
End Class
