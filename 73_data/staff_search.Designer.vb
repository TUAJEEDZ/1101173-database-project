<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_search
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Staffs_idLabel As System.Windows.Forms.Label
        Dim Staffs_nameLabel As System.Windows.Forms.Label
        Dim Staffs_addressLabel As System.Windows.Forms.Label
        Dim Staffs_telLabel As System.Windows.Forms.Label
        Dim Staffs_birthLabel As System.Windows.Forms.Label
        Dim Staffs_sexLabel As System.Windows.Forms.Label
        Dim Staffs_ninLabel As System.Windows.Forms.Label
        Dim Staffs_positionLabel As System.Windows.Forms.Label
        Dim Staffs_currentLabel As System.Windows.Forms.Label
        Dim Staffs_scaleLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_search))
        Me.StaffsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
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
        Me.StaffsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Staffs_idTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_telTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Staffs_sexTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_ninTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_positionTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_currentTextBox = New System.Windows.Forms.TextBox()
        Me.Staffs_scaleTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StaffsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.staffsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Label9 = New System.Windows.Forms.Label()
        Staffs_idLabel = New System.Windows.Forms.Label()
        Staffs_nameLabel = New System.Windows.Forms.Label()
        Staffs_addressLabel = New System.Windows.Forms.Label()
        Staffs_telLabel = New System.Windows.Forms.Label()
        Staffs_birthLabel = New System.Windows.Forms.Label()
        Staffs_sexLabel = New System.Windows.Forms.Label()
        Staffs_ninLabel = New System.Windows.Forms.Label()
        Staffs_positionLabel = New System.Windows.Forms.Label()
        Staffs_currentLabel = New System.Windows.Forms.Label()
        Staffs_scaleLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffsBindingNavigator.SuspendLayout()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label9.Location = New System.Drawing.Point(396, 43)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(157, 20)
        Label9.TabIndex = 170
        Label9.Text = "PERSONAL DETAIL"
        '
        'Staffs_idLabel
        '
        Staffs_idLabel.AutoSize = True
        Staffs_idLabel.Location = New System.Drawing.Point(67, 100)
        Staffs_idLabel.Name = "Staffs_idLabel"
        Staffs_idLabel.Size = New System.Drawing.Size(21, 13)
        Staffs_idLabel.TabIndex = 151
        Staffs_idLabel.Text = "ID:"
        '
        'Staffs_nameLabel
        '
        Staffs_nameLabel.AutoSize = True
        Staffs_nameLabel.Location = New System.Drawing.Point(67, 126)
        Staffs_nameLabel.Name = "Staffs_nameLabel"
        Staffs_nameLabel.Size = New System.Drawing.Size(38, 13)
        Staffs_nameLabel.TabIndex = 152
        Staffs_nameLabel.Text = "Name:"
        '
        'Staffs_addressLabel
        '
        Staffs_addressLabel.AutoSize = True
        Staffs_addressLabel.Location = New System.Drawing.Point(67, 152)
        Staffs_addressLabel.Name = "Staffs_addressLabel"
        Staffs_addressLabel.Size = New System.Drawing.Size(48, 13)
        Staffs_addressLabel.TabIndex = 153
        Staffs_addressLabel.Text = "Address:"
        '
        'Staffs_telLabel
        '
        Staffs_telLabel.AutoSize = True
        Staffs_telLabel.Location = New System.Drawing.Point(67, 200)
        Staffs_telLabel.Name = "Staffs_telLabel"
        Staffs_telLabel.Size = New System.Drawing.Size(25, 13)
        Staffs_telLabel.TabIndex = 154
        Staffs_telLabel.Text = "Tel:"
        '
        'Staffs_birthLabel
        '
        Staffs_birthLabel.AutoSize = True
        Staffs_birthLabel.Location = New System.Drawing.Point(338, 104)
        Staffs_birthLabel.Name = "Staffs_birthLabel"
        Staffs_birthLabel.Size = New System.Drawing.Size(68, 13)
        Staffs_birthLabel.TabIndex = 155
        Staffs_birthLabel.Text = "Date of birth:"
        '
        'Staffs_sexLabel
        '
        Staffs_sexLabel.AutoSize = True
        Staffs_sexLabel.Location = New System.Drawing.Point(338, 126)
        Staffs_sexLabel.Name = "Staffs_sexLabel"
        Staffs_sexLabel.Size = New System.Drawing.Size(45, 13)
        Staffs_sexLabel.TabIndex = 156
        Staffs_sexLabel.Text = "Gender:"
        '
        'Staffs_ninLabel
        '
        Staffs_ninLabel.AutoSize = True
        Staffs_ninLabel.Location = New System.Drawing.Point(338, 152)
        Staffs_ninLabel.Name = "Staffs_ninLabel"
        Staffs_ninLabel.Size = New System.Drawing.Size(29, 13)
        Staffs_ninLabel.TabIndex = 157
        Staffs_ninLabel.Text = "NIN:"
        '
        'Staffs_positionLabel
        '
        Staffs_positionLabel.AutoSize = True
        Staffs_positionLabel.Location = New System.Drawing.Point(620, 100)
        Staffs_positionLabel.Name = "Staffs_positionLabel"
        Staffs_positionLabel.Size = New System.Drawing.Size(47, 13)
        Staffs_positionLabel.TabIndex = 158
        Staffs_positionLabel.Text = "Position:"
        '
        'Staffs_currentLabel
        '
        Staffs_currentLabel.AutoSize = True
        Staffs_currentLabel.Location = New System.Drawing.Point(620, 126)
        Staffs_currentLabel.Name = "Staffs_currentLabel"
        Staffs_currentLabel.Size = New System.Drawing.Size(39, 13)
        Staffs_currentLabel.TabIndex = 159
        Staffs_currentLabel.Text = "Salary:"
        '
        'Staffs_scaleLabel
        '
        Staffs_scaleLabel.AutoSize = True
        Staffs_scaleLabel.Location = New System.Drawing.Point(620, 152)
        Staffs_scaleLabel.Name = "Staffs_scaleLabel"
        Staffs_scaleLabel.Size = New System.Drawing.Size(37, 13)
        Staffs_scaleLabel.TabIndex = 160
        Staffs_scaleLabel.Text = "Scale:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(686, 251)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(50, 16)
        Label1.TabIndex = 195
        Label1.Text = "Search"
        '
        'StaffsBindingNavigator
        '
        Me.StaffsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffsBindingNavigator.BindingSource = Me.StaffsBindingSource
        Me.StaffsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.StaffsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffsBindingNavigatorSaveItem})
        Me.StaffsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffsBindingNavigator.Name = "StaffsBindingNavigator"
        Me.StaffsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.StaffsBindingNavigator.TabIndex = 171
        Me.StaffsBindingNavigator.Text = "BindingNavigator1"
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
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "staffs"
        Me.StaffsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StaffsBindingNavigatorSaveItem
        '
        Me.StaffsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffsBindingNavigatorSaveItem.Name = "StaffsBindingNavigatorSaveItem"
        Me.StaffsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StaffsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Staffs_idTextBox
        '
        Me.Staffs_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_id", True))
        Me.Staffs_idTextBox.Location = New System.Drawing.Point(128, 97)
        Me.Staffs_idTextBox.Name = "Staffs_idTextBox"
        Me.Staffs_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_idTextBox.TabIndex = 172
        '
        'Staffs_nameTextBox
        '
        Me.Staffs_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_name", True))
        Me.Staffs_nameTextBox.Location = New System.Drawing.Point(128, 123)
        Me.Staffs_nameTextBox.Name = "Staffs_nameTextBox"
        Me.Staffs_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_nameTextBox.TabIndex = 174
        '
        'Staffs_addressTextBox
        '
        Me.Staffs_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_address", True))
        Me.Staffs_addressTextBox.Location = New System.Drawing.Point(128, 149)
        Me.Staffs_addressTextBox.Multiline = True
        Me.Staffs_addressTextBox.Name = "Staffs_addressTextBox"
        Me.Staffs_addressTextBox.Size = New System.Drawing.Size(200, 42)
        Me.Staffs_addressTextBox.TabIndex = 176
        '
        'Staffs_telTextBox
        '
        Me.Staffs_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_tel", True))
        Me.Staffs_telTextBox.Location = New System.Drawing.Point(128, 197)
        Me.Staffs_telTextBox.Name = "Staffs_telTextBox"
        Me.Staffs_telTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_telTextBox.TabIndex = 178
        '
        'Staffs_birthDateTimePicker
        '
        Me.Staffs_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffsBindingSource, "staffs_birth", True))
        Me.Staffs_birthDateTimePicker.Location = New System.Drawing.Point(414, 100)
        Me.Staffs_birthDateTimePicker.Name = "Staffs_birthDateTimePicker"
        Me.Staffs_birthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_birthDateTimePicker.TabIndex = 180
        '
        'Staffs_sexTextBox
        '
        Me.Staffs_sexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_sex", True))
        Me.Staffs_sexTextBox.Location = New System.Drawing.Point(414, 126)
        Me.Staffs_sexTextBox.Name = "Staffs_sexTextBox"
        Me.Staffs_sexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_sexTextBox.TabIndex = 182
        '
        'Staffs_ninTextBox
        '
        Me.Staffs_ninTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_nin", True))
        Me.Staffs_ninTextBox.Location = New System.Drawing.Point(414, 152)
        Me.Staffs_ninTextBox.Name = "Staffs_ninTextBox"
        Me.Staffs_ninTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_ninTextBox.TabIndex = 184
        '
        'Staffs_positionTextBox
        '
        Me.Staffs_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_position", True))
        Me.Staffs_positionTextBox.Location = New System.Drawing.Point(671, 100)
        Me.Staffs_positionTextBox.Name = "Staffs_positionTextBox"
        Me.Staffs_positionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_positionTextBox.TabIndex = 186
        '
        'Staffs_currentTextBox
        '
        Me.Staffs_currentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_current", True))
        Me.Staffs_currentTextBox.Location = New System.Drawing.Point(671, 126)
        Me.Staffs_currentTextBox.Name = "Staffs_currentTextBox"
        Me.Staffs_currentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_currentTextBox.TabIndex = 188
        '
        'Staffs_scaleTextBox
        '
        Me.Staffs_scaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "staffs_scale", True))
        Me.Staffs_scaleTextBox.Location = New System.Drawing.Point(671, 152)
        Me.Staffs_scaleTextBox.Name = "Staffs_scaleTextBox"
        Me.Staffs_scaleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_scaleTextBox.TabIndex = 190
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 191
        Me.Button1.Text = "QUALIFICATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(671, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 192
        Me.Button2.Text = "WORK EXPERIENCE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.staffsTableAdapter = Me.StaffsTableAdapter
        Me.TableAdapterManager.suppilersTableAdapter = Nothing
        Me.TableAdapterManager.suppilesTableAdapter = Nothing
        Me.TableAdapterManager.treatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _73_data.dbpro73DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        Me.TableAdapterManager.workexpTableAdapter = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(742, 251)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 194
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 289)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(860, 188)
        Me.DataGridView1.TabIndex = 196
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 197
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'staff_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 584)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Staffs_idTextBox)
        Me.Controls.Add(Me.Staffs_nameTextBox)
        Me.Controls.Add(Me.Staffs_addressTextBox)
        Me.Controls.Add(Me.Staffs_telTextBox)
        Me.Controls.Add(Me.Staffs_birthDateTimePicker)
        Me.Controls.Add(Me.Staffs_sexTextBox)
        Me.Controls.Add(Me.Staffs_ninTextBox)
        Me.Controls.Add(Me.Staffs_positionTextBox)
        Me.Controls.Add(Me.Staffs_currentTextBox)
        Me.Controls.Add(Me.Staffs_scaleTextBox)
        Me.Controls.Add(Me.StaffsBindingNavigator)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Staffs_idLabel)
        Me.Controls.Add(Staffs_nameLabel)
        Me.Controls.Add(Staffs_addressLabel)
        Me.Controls.Add(Staffs_telLabel)
        Me.Controls.Add(Staffs_birthLabel)
        Me.Controls.Add(Staffs_sexLabel)
        Me.Controls.Add(Staffs_ninLabel)
        Me.Controls.Add(Staffs_positionLabel)
        Me.Controls.Add(Staffs_currentLabel)
        Me.Controls.Add(Staffs_scaleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff_search"
        Me.Text = "staff_search"
        CType(Me.StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffsBindingNavigator.ResumeLayout(False)
        Me.StaffsBindingNavigator.PerformLayout()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents StaffsTableAdapter As dbpro73DataSetTableAdapters.staffsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffsBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Staffs_idTextBox As TextBox
    Friend WithEvents Staffs_nameTextBox As TextBox
    Friend WithEvents Staffs_addressTextBox As TextBox
    Friend WithEvents Staffs_telTextBox As TextBox
    Friend WithEvents Staffs_birthDateTimePicker As DateTimePicker
    Friend WithEvents Staffs_sexTextBox As TextBox
    Friend WithEvents Staffs_ninTextBox As TextBox
    Friend WithEvents Staffs_positionTextBox As TextBox
    Friend WithEvents Staffs_currentTextBox As TextBox
    Friend WithEvents Staffs_scaleTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
End Class
