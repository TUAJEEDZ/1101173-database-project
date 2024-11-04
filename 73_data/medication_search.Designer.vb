<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medication_search
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
        Dim Medications_idLabel As System.Windows.Forms.Label
        Dim Medications_nameLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim Method_of_AdminLabel As System.Windows.Forms.Label
        Dim Unit_per_dayLabel As System.Windows.Forms.Label
        Dim Staffs_idLabel As System.Windows.Forms.Label
        Dim Medications_idLabel1 As System.Windows.Forms.Label
        Dim Patients_idLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medication_search))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MedicationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.MedicationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Medications_idTextBox = New System.Windows.Forms.TextBox()
        Me.Medications_nameTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.Method_of_AdminTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_per_dayTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.View_TMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_TMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Staffs_idTextBox = New System.Windows.Forms.TextBox()
        Me.TreatmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medications_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Patients_idTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.MedicationsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.medicationsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.TreatmentTableAdapter = New _73_data.dbpro73DataSetTableAdapters.treatmentTableAdapter()
        Me.View_TMTableAdapter = New _73_data.dbpro73DataSetTableAdapters.View_TMTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MedicationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Medications_idLabel = New System.Windows.Forms.Label()
        Medications_nameLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        Method_of_AdminLabel = New System.Windows.Forms.Label()
        Unit_per_dayLabel = New System.Windows.Forms.Label()
        Staffs_idLabel = New System.Windows.Forms.Label()
        Medications_idLabel1 = New System.Windows.Forms.Label()
        Patients_idLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MedicationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedicationsBindingNavigator.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.View_TMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_TMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Medications_idLabel
        '
        Medications_idLabel.AutoSize = True
        Medications_idLabel.Location = New System.Drawing.Point(168, 81)
        Medications_idLabel.Name = "Medications_idLabel"
        Medications_idLabel.Size = New System.Drawing.Size(21, 13)
        Medications_idLabel.TabIndex = 1
        Medications_idLabel.Text = "ID:"
        '
        'Medications_nameLabel
        '
        Medications_nameLabel.AutoSize = True
        Medications_nameLabel.Location = New System.Drawing.Point(168, 107)
        Medications_nameLabel.Name = "Medications_nameLabel"
        Medications_nameLabel.Size = New System.Drawing.Size(38, 13)
        Medications_nameLabel.TabIndex = 3
        Medications_nameLabel.Text = "Name:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.Location = New System.Drawing.Point(168, 133)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(47, 13)
        DosageLabel.TabIndex = 5
        DosageLabel.Text = "Dosage:"
        '
        'Method_of_AdminLabel
        '
        Method_of_AdminLabel.AutoSize = True
        Method_of_AdminLabel.Location = New System.Drawing.Point(470, 81)
        Method_of_AdminLabel.Name = "Method_of_AdminLabel"
        Method_of_AdminLabel.Size = New System.Drawing.Size(90, 13)
        Method_of_AdminLabel.TabIndex = 7
        Method_of_AdminLabel.Text = "Method of Admin:"
        '
        'Unit_per_dayLabel
        '
        Unit_per_dayLabel.AutoSize = True
        Unit_per_dayLabel.Location = New System.Drawing.Point(470, 107)
        Unit_per_dayLabel.Name = "Unit_per_dayLabel"
        Unit_per_dayLabel.Size = New System.Drawing.Size(67, 13)
        Unit_per_dayLabel.TabIndex = 9
        Unit_per_dayLabel.Text = "Unit per day:"
        '
        'Staffs_idLabel
        '
        Staffs_idLabel.AutoSize = True
        Staffs_idLabel.Location = New System.Drawing.Point(201, 74)
        Staffs_idLabel.Name = "Staffs_idLabel"
        Staffs_idLabel.Size = New System.Drawing.Size(48, 13)
        Staffs_idLabel.TabIndex = 2
        Staffs_idLabel.Text = "Staffs id:"
        '
        'Medications_idLabel1
        '
        Medications_idLabel1.AutoSize = True
        Medications_idLabel1.Location = New System.Drawing.Point(201, 100)
        Medications_idLabel1.Name = "Medications_idLabel1"
        Medications_idLabel1.Size = New System.Drawing.Size(78, 13)
        Medications_idLabel1.TabIndex = 4
        Medications_idLabel1.Text = "Medications id:"
        '
        'Patients_idLabel
        '
        Patients_idLabel.AutoSize = True
        Patients_idLabel.Location = New System.Drawing.Point(201, 126)
        Patients_idLabel.Name = "Patients_idLabel"
        Patients_idLabel.Size = New System.Drawing.Size(59, 13)
        Patients_idLabel.TabIndex = 6
        Patients_idLabel.Text = "Patients id:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(201, 152)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 8
        QuantityLabel.Text = "Quantity:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(396, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(139, 24)
        Label1.TabIndex = 11
        Label1.Text = "MEDICATIONS"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label2.Location = New System.Drawing.Point(379, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(128, 24)
        Label2.TabIndex = 17
        Label2.Text = "TREATMENT"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-3, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1009, 544)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.MedicationsDataGridView)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.MedicationsBindingNavigator)
        Me.TabPage1.Controls.Add(Medications_idLabel)
        Me.TabPage1.Controls.Add(Me.Medications_idTextBox)
        Me.TabPage1.Controls.Add(Medications_nameLabel)
        Me.TabPage1.Controls.Add(Me.Medications_nameTextBox)
        Me.TabPage1.Controls.Add(DosageLabel)
        Me.TabPage1.Controls.Add(Me.DosageTextBox)
        Me.TabPage1.Controls.Add(Method_of_AdminLabel)
        Me.TabPage1.Controls.Add(Me.Method_of_AdminTextBox)
        Me.TabPage1.Controls.Add(Unit_per_dayLabel)
        Me.TabPage1.Controls.Add(Me.Unit_per_dayTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1001, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MEDICATION"
        '
        'MedicationsDataGridView
        '
        Me.MedicationsDataGridView.AutoGenerateColumns = False
        Me.MedicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.MedicationsDataGridView.DataSource = Me.MedicationsBindingSource
        Me.MedicationsDataGridView.Location = New System.Drawing.Point(208, 212)
        Me.MedicationsDataGridView.Name = "MedicationsDataGridView"
        Me.MedicationsDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.MedicationsDataGridView.TabIndex = 201
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "medications_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "medications_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "medications_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "medications_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dosage"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dosage"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "method_of_Admin"
        Me.DataGridViewTextBoxColumn4.HeaderText = "method_of_Admin"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "unit_per_day"
        Me.DataGridViewTextBoxColumn5.HeaderText = "unit_per_day"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "startdate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "startdate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "finishdate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "finishdate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'MedicationsBindingSource
        '
        Me.MedicationsBindingSource.DataMember = "medications"
        Me.MedicationsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicationsBindingNavigator
        '
        Me.MedicationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MedicationsBindingNavigator.BindingSource = Me.MedicationsBindingSource
        Me.MedicationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MedicationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MedicationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.MedicationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MedicationsBindingNavigatorSaveItem})
        Me.MedicationsBindingNavigator.Location = New System.Drawing.Point(3, 0)
        Me.MedicationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MedicationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MedicationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MedicationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MedicationsBindingNavigator.Name = "MedicationsBindingNavigator"
        Me.MedicationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MedicationsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.MedicationsBindingNavigator.TabIndex = 1
        Me.MedicationsBindingNavigator.Text = "BindingNavigator1"
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
        'Medications_idTextBox
        '
        Me.Medications_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationsBindingSource, "medications_id", True))
        Me.Medications_idTextBox.Location = New System.Drawing.Point(238, 78)
        Me.Medications_idTextBox.Name = "Medications_idTextBox"
        Me.Medications_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Medications_idTextBox.TabIndex = 2
        '
        'Medications_nameTextBox
        '
        Me.Medications_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationsBindingSource, "medications_name", True))
        Me.Medications_nameTextBox.Location = New System.Drawing.Point(238, 104)
        Me.Medications_nameTextBox.Name = "Medications_nameTextBox"
        Me.Medications_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Medications_nameTextBox.TabIndex = 4
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationsBindingSource, "dosage", True))
        Me.DosageTextBox.Location = New System.Drawing.Point(238, 130)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DosageTextBox.TabIndex = 6
        '
        'Method_of_AdminTextBox
        '
        Me.Method_of_AdminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationsBindingSource, "method_of_Admin", True))
        Me.Method_of_AdminTextBox.Location = New System.Drawing.Point(571, 78)
        Me.Method_of_AdminTextBox.Name = "Method_of_AdminTextBox"
        Me.Method_of_AdminTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Method_of_AdminTextBox.TabIndex = 8
        '
        'Unit_per_dayTextBox
        '
        Me.Unit_per_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationsBindingSource, "unit_per_day", True))
        Me.Unit_per_dayTextBox.Location = New System.Drawing.Point(571, 104)
        Me.Unit_per_dayTextBox.Name = "Unit_per_dayTextBox"
        Me.Unit_per_dayTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Unit_per_dayTextBox.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Label2)
        Me.TabPage2.Controls.Add(Me.View_TMDataGridView)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Staffs_idLabel)
        Me.TabPage2.Controls.Add(Me.Staffs_idTextBox)
        Me.TabPage2.Controls.Add(Medications_idLabel1)
        Me.TabPage2.Controls.Add(Me.Medications_idTextBox1)
        Me.TabPage2.Controls.Add(Patients_idLabel)
        Me.TabPage2.Controls.Add(Me.Patients_idTextBox)
        Me.TabPage2.Controls.Add(QuantityLabel)
        Me.TabPage2.Controls.Add(Me.QuantityTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1001, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TREATMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(650, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(650, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 18
        '
        'View_TMDataGridView
        '
        Me.View_TMDataGridView.AutoGenerateColumns = False
        Me.View_TMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_TMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.View_TMDataGridView.DataSource = Me.View_TMBindingSource
        Me.View_TMDataGridView.Location = New System.Drawing.Point(52, 212)
        Me.View_TMDataGridView.Name = "View_TMDataGridView"
        Me.View_TMDataGridView.Size = New System.Drawing.Size(842, 220)
        Me.View_TMDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "staffs_id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "staffs_id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "staffs_name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "staffs_name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "patients_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "patients_id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "patients_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "patients_name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "medications_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "medications_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "medications_name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "medications_name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn14.HeaderText = "quantity"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "treatmentdate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "treatmentdate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'View_TMBindingSource
        '
        Me.View_TMBindingSource.DataMember = "View_TM"
        Me.View_TMBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(576, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(576, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "-"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(576, 71)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 23)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(503, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(503, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Check"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Staffs_idTextBox
        '
        Me.Staffs_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "staffs_id", True))
        Me.Staffs_idTextBox.Location = New System.Drawing.Point(284, 71)
        Me.Staffs_idTextBox.Name = "Staffs_idTextBox"
        Me.Staffs_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Staffs_idTextBox.TabIndex = 3
        '
        'TreatmentBindingSource
        '
        Me.TreatmentBindingSource.DataMember = "treatment"
        Me.TreatmentBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'Medications_idTextBox1
        '
        Me.Medications_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "medications_id", True))
        Me.Medications_idTextBox1.Location = New System.Drawing.Point(284, 97)
        Me.Medications_idTextBox1.Name = "Medications_idTextBox1"
        Me.Medications_idTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Medications_idTextBox1.TabIndex = 5
        '
        'Patients_idTextBox
        '
        Me.Patients_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "patients_id", True))
        Me.Patients_idTextBox.Location = New System.Drawing.Point(284, 123)
        Me.Patients_idTextBox.Name = "Patients_idTextBox"
        Me.Patients_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patients_idTextBox.TabIndex = 7
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(284, 149)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuantityTextBox.TabIndex = 9
        '
        'MedicationsTableAdapter
        '
        Me.MedicationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Nothing
        Me.TableAdapterManager.IN_patientsTableAdapter = Nothing
        Me.TableAdapterManager.medicationsTableAdapter = Me.MedicationsTableAdapter
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
        'TreatmentTableAdapter
        '
        Me.TreatmentTableAdapter.ClearBeforeFill = True
        '
        'View_TMTableAdapter
        '
        Me.View_TMTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(819, 183)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 198
        Me.Button8.Text = "Print"
        Me.Button8.UseVisualStyleBackColor = True
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
        'MedicationsBindingNavigatorSaveItem
        '
        Me.MedicationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MedicationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("MedicationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MedicationsBindingNavigatorSaveItem.Name = "MedicationsBindingNavigatorSaveItem"
        Me.MedicationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MedicationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'medication_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "medication_search"
        Me.Text = "medication_search"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MedicationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedicationsBindingNavigator.ResumeLayout(False)
        Me.MedicationsBindingNavigator.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.View_TMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_TMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents MedicationsBindingSource As BindingSource
    Friend WithEvents MedicationsTableAdapter As dbpro73DataSetTableAdapters.medicationsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicationsBindingNavigator As BindingNavigator
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
    Friend WithEvents MedicationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Medications_idTextBox As TextBox
    Friend WithEvents Medications_nameTextBox As TextBox
    Friend WithEvents DosageTextBox As TextBox
    Friend WithEvents Method_of_AdminTextBox As TextBox
    Friend WithEvents Unit_per_dayTextBox As TextBox
    Friend WithEvents TreatmentBindingSource As BindingSource
    Friend WithEvents TreatmentTableAdapter As dbpro73DataSetTableAdapters.treatmentTableAdapter
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Staffs_idTextBox As TextBox
    Friend WithEvents Medications_idTextBox1 As TextBox
    Friend WithEvents Patients_idTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents View_TMBindingSource As BindingSource
    Friend WithEvents View_TMTableAdapter As dbpro73DataSetTableAdapters.View_TMTableAdapter
    Friend WithEvents View_TMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MedicationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
End Class
