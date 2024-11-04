<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paritilent_search
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
        Dim Patients_nameLabel As System.Windows.Forms.Label
        Dim Patients_birthLabel As System.Windows.Forms.Label
        Dim Patients_sexLabel As System.Windows.Forms.Label
        Dim Patients_addressLabel As System.Windows.Forms.Label
        Dim Patients_telLabel As System.Windows.Forms.Label
        Dim Patients_DateregisteredLabel As System.Windows.Forms.Label
        Dim Patients_StatusLabel As System.Windows.Forms.Label
        Dim K_nameLabel As System.Windows.Forms.Label
        Dim K_telLabel As System.Windows.Forms.Label
        Dim K_addressLabel As System.Windows.Forms.Label
        Dim K_relationshipLabel As System.Windows.Forms.Label
        Dim Clinic_IDLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paritilent_search))
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.patientsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.PatientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Patients_idTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Patients_sexTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_telTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_DateregisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Patients_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.K_nameTextBox = New System.Windows.Forms.TextBox()
        Me.K_telTextBox = New System.Windows.Forms.TextBox()
        Me.K_addressTextBox = New System.Windows.Forms.TextBox()
        Me.K_relationshipTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Patients_idLabel = New System.Windows.Forms.Label()
        Patients_nameLabel = New System.Windows.Forms.Label()
        Patients_birthLabel = New System.Windows.Forms.Label()
        Patients_sexLabel = New System.Windows.Forms.Label()
        Patients_addressLabel = New System.Windows.Forms.Label()
        Patients_telLabel = New System.Windows.Forms.Label()
        Patients_DateregisteredLabel = New System.Windows.Forms.Label()
        Patients_StatusLabel = New System.Windows.Forms.Label()
        K_nameLabel = New System.Windows.Forms.Label()
        K_telLabel = New System.Windows.Forms.Label()
        K_addressLabel = New System.Windows.Forms.Label()
        K_relationshipLabel = New System.Windows.Forms.Label()
        Clinic_IDLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patients_idLabel
        '
        Patients_idLabel.AutoSize = True
        Patients_idLabel.Location = New System.Drawing.Point(32, 67)
        Patients_idLabel.Name = "Patients_idLabel"
        Patients_idLabel.Size = New System.Drawing.Size(21, 13)
        Patients_idLabel.TabIndex = 1
        Patients_idLabel.Text = "ID:"
        '
        'Patients_nameLabel
        '
        Patients_nameLabel.AutoSize = True
        Patients_nameLabel.Location = New System.Drawing.Point(32, 93)
        Patients_nameLabel.Name = "Patients_nameLabel"
        Patients_nameLabel.Size = New System.Drawing.Size(38, 13)
        Patients_nameLabel.TabIndex = 3
        Patients_nameLabel.Text = "Name:"
        '
        'Patients_birthLabel
        '
        Patients_birthLabel.AutoSize = True
        Patients_birthLabel.Location = New System.Drawing.Point(32, 120)
        Patients_birthLabel.Name = "Patients_birthLabel"
        Patients_birthLabel.Size = New System.Drawing.Size(68, 13)
        Patients_birthLabel.TabIndex = 5
        Patients_birthLabel.Text = "Date of birth:"
        '
        'Patients_sexLabel
        '
        Patients_sexLabel.AutoSize = True
        Patients_sexLabel.Location = New System.Drawing.Point(32, 145)
        Patients_sexLabel.Name = "Patients_sexLabel"
        Patients_sexLabel.Size = New System.Drawing.Size(45, 13)
        Patients_sexLabel.TabIndex = 7
        Patients_sexLabel.Text = "Gender:"
        '
        'Patients_addressLabel
        '
        Patients_addressLabel.AutoSize = True
        Patients_addressLabel.Location = New System.Drawing.Point(32, 171)
        Patients_addressLabel.Name = "Patients_addressLabel"
        Patients_addressLabel.Size = New System.Drawing.Size(48, 13)
        Patients_addressLabel.TabIndex = 9
        Patients_addressLabel.Text = "Address:"
        '
        'Patients_telLabel
        '
        Patients_telLabel.AutoSize = True
        Patients_telLabel.Location = New System.Drawing.Point(317, 67)
        Patients_telLabel.Name = "Patients_telLabel"
        Patients_telLabel.Size = New System.Drawing.Size(25, 13)
        Patients_telLabel.TabIndex = 11
        Patients_telLabel.Text = "Tel:"
        '
        'Patients_DateregisteredLabel
        '
        Patients_DateregisteredLabel.AutoSize = True
        Patients_DateregisteredLabel.Location = New System.Drawing.Point(317, 94)
        Patients_DateregisteredLabel.Name = "Patients_DateregisteredLabel"
        Patients_DateregisteredLabel.Size = New System.Drawing.Size(79, 13)
        Patients_DateregisteredLabel.TabIndex = 13
        Patients_DateregisteredLabel.Text = "Dateregistered:"
        '
        'Patients_StatusLabel
        '
        Patients_StatusLabel.AutoSize = True
        Patients_StatusLabel.Location = New System.Drawing.Point(317, 119)
        Patients_StatusLabel.Name = "Patients_StatusLabel"
        Patients_StatusLabel.Size = New System.Drawing.Size(40, 13)
        Patients_StatusLabel.TabIndex = 15
        Patients_StatusLabel.Text = "Status:"
        '
        'K_nameLabel
        '
        K_nameLabel.AutoSize = True
        K_nameLabel.Location = New System.Drawing.Point(628, 67)
        K_nameLabel.Name = "K_nameLabel"
        K_nameLabel.Size = New System.Drawing.Size(45, 13)
        K_nameLabel.TabIndex = 17
        K_nameLabel.Text = "k name:"
        '
        'K_telLabel
        '
        K_telLabel.AutoSize = True
        K_telLabel.Location = New System.Drawing.Point(628, 93)
        K_telLabel.Name = "K_telLabel"
        K_telLabel.Size = New System.Drawing.Size(30, 13)
        K_telLabel.TabIndex = 19
        K_telLabel.Text = "k tel:"
        '
        'K_addressLabel
        '
        K_addressLabel.AutoSize = True
        K_addressLabel.Location = New System.Drawing.Point(628, 119)
        K_addressLabel.Name = "K_addressLabel"
        K_addressLabel.Size = New System.Drawing.Size(56, 13)
        K_addressLabel.TabIndex = 21
        K_addressLabel.Text = "k address:"
        '
        'K_relationshipLabel
        '
        K_relationshipLabel.AutoSize = True
        K_relationshipLabel.Location = New System.Drawing.Point(628, 145)
        K_relationshipLabel.Name = "K_relationshipLabel"
        K_relationshipLabel.Size = New System.Drawing.Size(72, 13)
        K_relationshipLabel.TabIndex = 23
        K_relationshipLabel.Text = "k relationship:"
        '
        'Clinic_IDLabel
        '
        Clinic_IDLabel.AutoSize = True
        Clinic_IDLabel.Location = New System.Drawing.Point(317, 145)
        Clinic_IDLabel.Name = "Clinic_IDLabel"
        Clinic_IDLabel.Size = New System.Drawing.Size(48, 13)
        Clinic_IDLabel.TabIndex = 25
        Clinic_IDLabel.Text = "clinic ID:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label9.Location = New System.Drawing.Point(350, 34)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(143, 18)
        Label9.TabIndex = 194
        Label9.Text = "PERSONAL DETAIL"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label2.Location = New System.Drawing.Point(681, 217)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 16)
        Label2.TabIndex = 201
        Label2.Text = "Search"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "patients"
        Me.PatientsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Nothing
        Me.TableAdapterManager.IN_patientsTableAdapter = Nothing
        Me.TableAdapterManager.medicationsTableAdapter = Nothing
        Me.TableAdapterManager.patientsTableAdapter = Me.PatientsTableAdapter
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
        'PatientsBindingNavigator
        '
        Me.PatientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientsBindingNavigator.BindingSource = Me.PatientsBindingSource
        Me.PatientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PatientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientsBindingNavigatorSaveItem})
        Me.PatientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientsBindingNavigator.Name = "PatientsBindingNavigator"
        Me.PatientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.PatientsBindingNavigator.TabIndex = 0
        Me.PatientsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Patients_idTextBox
        '
        Me.Patients_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_id", True))
        Me.Patients_idTextBox.Location = New System.Drawing.Point(110, 67)
        Me.Patients_idTextBox.Name = "Patients_idTextBox"
        Me.Patients_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_idTextBox.TabIndex = 2
        '
        'Patients_nameTextBox
        '
        Me.Patients_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_name", True))
        Me.Patients_nameTextBox.Location = New System.Drawing.Point(110, 93)
        Me.Patients_nameTextBox.Name = "Patients_nameTextBox"
        Me.Patients_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_nameTextBox.TabIndex = 4
        '
        'Patients_birthDateTimePicker
        '
        Me.Patients_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "patients_birth", True))
        Me.Patients_birthDateTimePicker.Location = New System.Drawing.Point(110, 119)
        Me.Patients_birthDateTimePicker.Name = "Patients_birthDateTimePicker"
        Me.Patients_birthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Patients_birthDateTimePicker.TabIndex = 6
        '
        'Patients_sexTextBox
        '
        Me.Patients_sexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_sex", True))
        Me.Patients_sexTextBox.Location = New System.Drawing.Point(110, 145)
        Me.Patients_sexTextBox.Name = "Patients_sexTextBox"
        Me.Patients_sexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_sexTextBox.TabIndex = 8
        '
        'Patients_addressTextBox
        '
        Me.Patients_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_address", True))
        Me.Patients_addressTextBox.Location = New System.Drawing.Point(110, 171)
        Me.Patients_addressTextBox.Multiline = True
        Me.Patients_addressTextBox.Name = "Patients_addressTextBox"
        Me.Patients_addressTextBox.Size = New System.Drawing.Size(200, 48)
        Me.Patients_addressTextBox.TabIndex = 10
        '
        'Patients_telTextBox
        '
        Me.Patients_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_tel", True))
        Me.Patients_telTextBox.Location = New System.Drawing.Point(395, 67)
        Me.Patients_telTextBox.Name = "Patients_telTextBox"
        Me.Patients_telTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_telTextBox.TabIndex = 12
        '
        'Patients_DateregisteredDateTimePicker
        '
        Me.Patients_DateregisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "patients_Dateregistered", True))
        Me.Patients_DateregisteredDateTimePicker.Location = New System.Drawing.Point(395, 93)
        Me.Patients_DateregisteredDateTimePicker.Name = "Patients_DateregisteredDateTimePicker"
        Me.Patients_DateregisteredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Patients_DateregisteredDateTimePicker.TabIndex = 14
        '
        'Patients_StatusTextBox
        '
        Me.Patients_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "patients_Status", True))
        Me.Patients_StatusTextBox.Location = New System.Drawing.Point(395, 119)
        Me.Patients_StatusTextBox.Name = "Patients_StatusTextBox"
        Me.Patients_StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_StatusTextBox.TabIndex = 16
        '
        'K_nameTextBox
        '
        Me.K_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "k_name", True))
        Me.K_nameTextBox.Location = New System.Drawing.Point(706, 64)
        Me.K_nameTextBox.Name = "K_nameTextBox"
        Me.K_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.K_nameTextBox.TabIndex = 18
        '
        'K_telTextBox
        '
        Me.K_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "k_tel", True))
        Me.K_telTextBox.Location = New System.Drawing.Point(706, 90)
        Me.K_telTextBox.Name = "K_telTextBox"
        Me.K_telTextBox.Size = New System.Drawing.Size(200, 20)
        Me.K_telTextBox.TabIndex = 20
        '
        'K_addressTextBox
        '
        Me.K_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "k_address", True))
        Me.K_addressTextBox.Location = New System.Drawing.Point(706, 116)
        Me.K_addressTextBox.Name = "K_addressTextBox"
        Me.K_addressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.K_addressTextBox.TabIndex = 22
        '
        'K_relationshipTextBox
        '
        Me.K_relationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "k_relationship", True))
        Me.K_relationshipTextBox.Location = New System.Drawing.Point(706, 142)
        Me.K_relationshipTextBox.Name = "K_relationshipTextBox"
        Me.K_relationshipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.K_relationshipTextBox.TabIndex = 24
        '
        'Clinic_IDTextBox
        '
        Me.Clinic_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "clinic_ID", True))
        Me.Clinic_IDTextBox.Location = New System.Drawing.Point(395, 142)
        Me.Clinic_IDTextBox.Name = "Clinic_IDTextBox"
        Me.Clinic_IDTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Clinic_IDTextBox.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(523, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 192
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 193
        Me.Button2.Text = "CLINIC"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(860, 188)
        Me.DataGridView1.TabIndex = 202
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(737, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 200
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(35, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 203
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
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
        'PatientsBindingNavigatorSaveItem
        '
        Me.PatientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientsBindingNavigatorSaveItem.Name = "PatientsBindingNavigatorSaveItem"
        Me.PatientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'paritilent_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 509)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Patients_idLabel)
        Me.Controls.Add(Me.Patients_idTextBox)
        Me.Controls.Add(Patients_nameLabel)
        Me.Controls.Add(Me.Patients_nameTextBox)
        Me.Controls.Add(Patients_birthLabel)
        Me.Controls.Add(Me.Patients_birthDateTimePicker)
        Me.Controls.Add(Patients_sexLabel)
        Me.Controls.Add(Me.Patients_sexTextBox)
        Me.Controls.Add(Patients_addressLabel)
        Me.Controls.Add(Me.Patients_addressTextBox)
        Me.Controls.Add(Patients_telLabel)
        Me.Controls.Add(Me.Patients_telTextBox)
        Me.Controls.Add(Patients_DateregisteredLabel)
        Me.Controls.Add(Me.Patients_DateregisteredDateTimePicker)
        Me.Controls.Add(Patients_StatusLabel)
        Me.Controls.Add(Me.Patients_StatusTextBox)
        Me.Controls.Add(K_nameLabel)
        Me.Controls.Add(Me.K_nameTextBox)
        Me.Controls.Add(K_telLabel)
        Me.Controls.Add(Me.K_telTextBox)
        Me.Controls.Add(K_addressLabel)
        Me.Controls.Add(Me.K_addressTextBox)
        Me.Controls.Add(K_relationshipLabel)
        Me.Controls.Add(Me.K_relationshipTextBox)
        Me.Controls.Add(Clinic_IDLabel)
        Me.Controls.Add(Me.Clinic_IDTextBox)
        Me.Controls.Add(Me.PatientsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paritilent_search"
        Me.Text = "paritilent_search"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientsBindingNavigator.ResumeLayout(False)
        Me.PatientsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As dbpro73DataSetTableAdapters.patientsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientsBindingNavigator As BindingNavigator
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
    Friend WithEvents PatientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Patients_idTextBox As TextBox
    Friend WithEvents Patients_nameTextBox As TextBox
    Friend WithEvents Patients_birthDateTimePicker As DateTimePicker
    Friend WithEvents Patients_sexTextBox As TextBox
    Friend WithEvents Patients_addressTextBox As TextBox
    Friend WithEvents Patients_telTextBox As TextBox
    Friend WithEvents Patients_DateregisteredDateTimePicker As DateTimePicker
    Friend WithEvents Patients_StatusTextBox As TextBox
    Friend WithEvents K_nameTextBox As TextBox
    Friend WithEvents K_telTextBox As TextBox
    Friend WithEvents K_addressTextBox As TextBox
    Friend WithEvents K_relationshipTextBox As TextBox
    Friend WithEvents Clinic_IDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
End Class
