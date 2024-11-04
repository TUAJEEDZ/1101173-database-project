<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C
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
        Dim Clinic_IDLabel As System.Windows.Forms.Label
        Dim Ldoc_nameLabel As System.Windows.Forms.Label
        Dim Ldoc_telLabel As System.Windows.Forms.Label
        Dim Ldoc_addressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C))
        Dim Label9 As System.Windows.Forms.Label
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.ClinicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicTableAdapter = New _73_data.dbpro73DataSetTableAdapters.clinicTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.ClinicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClinicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClinicDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clinic_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Ldoc_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Ldoc_telTextBox = New System.Windows.Forms.TextBox()
        Me.Ldoc_addressTextBox = New System.Windows.Forms.TextBox()
        Clinic_IDLabel = New System.Windows.Forms.Label()
        Ldoc_nameLabel = New System.Windows.Forms.Label()
        Ldoc_telLabel = New System.Windows.Forms.Label()
        Ldoc_addressLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClinicBindingNavigator.SuspendLayout()
        CType(Me.ClinicDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clinic_IDLabel
        '
        Clinic_IDLabel.AutoSize = True
        Clinic_IDLabel.Location = New System.Drawing.Point(317, 63)
        Clinic_IDLabel.Name = "Clinic_IDLabel"
        Clinic_IDLabel.Size = New System.Drawing.Size(48, 13)
        Clinic_IDLabel.TabIndex = 2
        Clinic_IDLabel.Text = "clinic ID:"
        '
        'Ldoc_nameLabel
        '
        Ldoc_nameLabel.AutoSize = True
        Ldoc_nameLabel.Location = New System.Drawing.Point(267, 89)
        Ldoc_nameLabel.Name = "Ldoc_nameLabel"
        Ldoc_nameLabel.Size = New System.Drawing.Size(98, 13)
        Ldoc_nameLabel.TabIndex = 4
        Ldoc_nameLabel.Text = "Local doctor name:"
        '
        'Ldoc_telLabel
        '
        Ldoc_telLabel.AutoSize = True
        Ldoc_telLabel.Location = New System.Drawing.Point(278, 115)
        Ldoc_telLabel.Name = "Ldoc_telLabel"
        Ldoc_telLabel.Size = New System.Drawing.Size(87, 13)
        Ldoc_telLabel.TabIndex = 6
        Ldoc_telLabel.Text = "Local doctor Tel:"
        '
        'Ldoc_addressLabel
        '
        Ldoc_addressLabel.AutoSize = True
        Ldoc_addressLabel.Location = New System.Drawing.Point(255, 141)
        Ldoc_addressLabel.Name = "Ldoc_addressLabel"
        Ldoc_addressLabel.Size = New System.Drawing.Size(110, 13)
        Ldoc_addressLabel.TabIndex = 8
        Ldoc_addressLabel.Text = "Local doctor Address:"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicBindingSource
        '
        Me.ClinicBindingSource.DataMember = "clinic"
        Me.ClinicBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'ClinicTableAdapter
        '
        Me.ClinicTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clinicTableAdapter = Me.ClinicTableAdapter
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
        Me.TableAdapterManager.workexpTableAdapter = Nothing
        '
        'ClinicBindingNavigator
        '
        Me.ClinicBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClinicBindingNavigator.BindingSource = Me.ClinicBindingSource
        Me.ClinicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClinicBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClinicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClinicBindingNavigatorSaveItem})
        Me.ClinicBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClinicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClinicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClinicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClinicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClinicBindingNavigator.Name = "ClinicBindingNavigator"
        Me.ClinicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClinicBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ClinicBindingNavigator.TabIndex = 0
        Me.ClinicBindingNavigator.Text = "BindingNavigator1"
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
        'ClinicBindingNavigatorSaveItem
        '
        Me.ClinicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClinicBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClinicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClinicBindingNavigatorSaveItem.Name = "ClinicBindingNavigatorSaveItem"
        Me.ClinicBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClinicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClinicDataGridView
        '
        Me.ClinicDataGridView.AutoGenerateColumns = False
        Me.ClinicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClinicDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClinicDataGridView.DataSource = Me.ClinicBindingSource
        Me.ClinicDataGridView.Location = New System.Drawing.Point(164, 188)
        Me.ClinicDataGridView.Name = "ClinicDataGridView"
        Me.ClinicDataGridView.Size = New System.Drawing.Size(441, 220)
        Me.ClinicDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "clinic_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "clinic_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ldoc_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ldoc_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ldoc_tel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ldoc_tel"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ldoc_address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ldoc_address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Clinic_IDTextBox
        '
        Me.Clinic_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "clinic_ID", True))
        Me.Clinic_IDTextBox.Location = New System.Drawing.Point(371, 60)
        Me.Clinic_IDTextBox.Name = "Clinic_IDTextBox"
        Me.Clinic_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Clinic_IDTextBox.TabIndex = 3
        '
        'Ldoc_nameTextBox
        '
        Me.Ldoc_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "ldoc_name", True))
        Me.Ldoc_nameTextBox.Location = New System.Drawing.Point(371, 86)
        Me.Ldoc_nameTextBox.Name = "Ldoc_nameTextBox"
        Me.Ldoc_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ldoc_nameTextBox.TabIndex = 5
        '
        'Ldoc_telTextBox
        '
        Me.Ldoc_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "ldoc_tel", True))
        Me.Ldoc_telTextBox.Location = New System.Drawing.Point(371, 112)
        Me.Ldoc_telTextBox.Name = "Ldoc_telTextBox"
        Me.Ldoc_telTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ldoc_telTextBox.TabIndex = 7
        '
        'Ldoc_addressTextBox
        '
        Me.Ldoc_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "ldoc_address", True))
        Me.Ldoc_addressTextBox.Location = New System.Drawing.Point(371, 138)
        Me.Ldoc_addressTextBox.Name = "Ldoc_addressTextBox"
        Me.Ldoc_addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ldoc_addressTextBox.TabIndex = 9
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label9.Location = New System.Drawing.Point(354, 25)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(61, 20)
        Label9.TabIndex = 195
        Label9.Text = "CLINIC"
        '
        'C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Clinic_IDLabel)
        Me.Controls.Add(Me.Clinic_IDTextBox)
        Me.Controls.Add(Ldoc_nameLabel)
        Me.Controls.Add(Me.Ldoc_nameTextBox)
        Me.Controls.Add(Ldoc_telLabel)
        Me.Controls.Add(Me.Ldoc_telTextBox)
        Me.Controls.Add(Ldoc_addressLabel)
        Me.Controls.Add(Me.Ldoc_addressTextBox)
        Me.Controls.Add(Me.ClinicDataGridView)
        Me.Controls.Add(Me.ClinicBindingNavigator)
        Me.Name = "C"
        Me.Text = "C"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClinicBindingNavigator.ResumeLayout(False)
        Me.ClinicBindingNavigator.PerformLayout()
        CType(Me.ClinicDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents ClinicBindingSource As BindingSource
    Friend WithEvents ClinicTableAdapter As dbpro73DataSetTableAdapters.clinicTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClinicBindingNavigator As BindingNavigator
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
    Friend WithEvents ClinicBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClinicDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Clinic_IDTextBox As TextBox
    Friend WithEvents Ldoc_nameTextBox As TextBox
    Friend WithEvents Ldoc_telTextBox As TextBox
    Friend WithEvents Ldoc_addressTextBox As TextBox
End Class
