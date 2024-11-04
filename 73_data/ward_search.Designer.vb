<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ward_search
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
        Dim Wards_idLabel As System.Windows.Forms.Label
        Dim Wards_nameLabel As System.Windows.Forms.Label
        Dim Wards_locationLabel As System.Windows.Forms.Label
        Dim Wards_telLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ward_search))
        Me.Dbpro73DataSet = New _73_data.dbpro73DataSet()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New _73_data.dbpro73DataSetTableAdapters.wardsTableAdapter()
        Me.TableAdapterManager = New _73_data.dbpro73DataSetTableAdapters.TableAdapterManager()
        Me.WardsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WardsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Wards_idTextBox = New System.Windows.Forms.TextBox()
        Me.Wards_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Wards_locationTextBox = New System.Windows.Forms.TextBox()
        Me.Wards_telTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Wards_idLabel = New System.Windows.Forms.Label()
        Wards_nameLabel = New System.Windows.Forms.Label()
        Wards_locationLabel = New System.Windows.Forms.Label()
        Wards_telLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WardsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wards_idLabel
        '
        Wards_idLabel.AutoSize = True
        Wards_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wards_idLabel.Location = New System.Drawing.Point(103, 82)
        Wards_idLabel.Name = "Wards_idLabel"
        Wards_idLabel.Size = New System.Drawing.Size(60, 16)
        Wards_idLabel.TabIndex = 1
        Wards_idLabel.Text = "wards id:"
        '
        'Wards_nameLabel
        '
        Wards_nameLabel.AutoSize = True
        Wards_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wards_nameLabel.Location = New System.Drawing.Point(103, 147)
        Wards_nameLabel.Name = "Wards_nameLabel"
        Wards_nameLabel.Size = New System.Drawing.Size(83, 16)
        Wards_nameLabel.TabIndex = 3
        Wards_nameLabel.Text = "wards name:"
        '
        'Wards_locationLabel
        '
        Wards_locationLabel.AutoSize = True
        Wards_locationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wards_locationLabel.Location = New System.Drawing.Point(414, 80)
        Wards_locationLabel.Name = "Wards_locationLabel"
        Wards_locationLabel.Size = New System.Drawing.Size(96, 16)
        Wards_locationLabel.TabIndex = 5
        Wards_locationLabel.Text = "wards location:"
        '
        'Wards_telLabel
        '
        Wards_telLabel.AutoSize = True
        Wards_telLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wards_telLabel.Location = New System.Drawing.Point(414, 146)
        Wards_telLabel.Name = "Wards_telLabel"
        Wards_telLabel.Size = New System.Drawing.Size(63, 16)
        Wards_telLabel.TabIndex = 7
        Wards_telLabel.Text = "wards tel:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(384, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 24)
        Label1.TabIndex = 195
        Label1.Text = "WARDS"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label2.Location = New System.Drawing.Point(630, 245)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 16)
        Label2.TabIndex = 198
        Label2.Text = "Search"
        '
        'Dbpro73DataSet
        '
        Me.Dbpro73DataSet.DataSetName = "dbpro73DataSet"
        Me.Dbpro73DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "wards"
        Me.WardsBindingSource.DataSource = Me.Dbpro73DataSet
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.wardsTableAdapter = Me.WardsTableAdapter
        Me.TableAdapterManager.workexpTableAdapter = Nothing
        '
        'WardsBindingNavigator
        '
        Me.WardsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WardsBindingNavigator.BindingSource = Me.WardsBindingSource
        Me.WardsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WardsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WardsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.WardsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardsBindingNavigatorSaveItem})
        Me.WardsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WardsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WardsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WardsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WardsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WardsBindingNavigator.Name = "WardsBindingNavigator"
        Me.WardsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WardsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.WardsBindingNavigator.TabIndex = 0
        Me.WardsBindingNavigator.Text = "BindingNavigator1"
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
        'WardsBindingNavigatorSaveItem
        '
        Me.WardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WardsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WardsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WardsBindingNavigatorSaveItem.Name = "WardsBindingNavigatorSaveItem"
        Me.WardsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WardsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Wards_idTextBox
        '
        Me.Wards_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wards_id", True))
        Me.Wards_idTextBox.Location = New System.Drawing.Point(222, 80)
        Me.Wards_idTextBox.Name = "Wards_idTextBox"
        Me.Wards_idTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Wards_idTextBox.TabIndex = 2
        '
        'Wards_nameTextBox
        '
        Me.Wards_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wards_name", True))
        Me.Wards_nameTextBox.Location = New System.Drawing.Point(222, 146)
        Me.Wards_nameTextBox.Name = "Wards_nameTextBox"
        Me.Wards_nameTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Wards_nameTextBox.TabIndex = 4
        '
        'Wards_locationTextBox
        '
        Me.Wards_locationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wards_location", True))
        Me.Wards_locationTextBox.Location = New System.Drawing.Point(533, 79)
        Me.Wards_locationTextBox.Name = "Wards_locationTextBox"
        Me.Wards_locationTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Wards_locationTextBox.TabIndex = 6
        '
        'Wards_telTextBox
        '
        Me.Wards_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wards_tel", True))
        Me.Wards_telTextBox.Location = New System.Drawing.Point(533, 145)
        Me.Wards_telTextBox.Name = "Wards_telTextBox"
        Me.Wards_telTextBox.Size = New System.Drawing.Size(142, 20)
        Me.Wards_telTextBox.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(769, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 194
        Me.Button2.Text = "shift"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(104, 271)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(740, 188)
        Me.DataGridView1.TabIndex = 199
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(686, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 197
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(769, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 200
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ward_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 507)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Wards_idLabel)
        Me.Controls.Add(Me.Wards_idTextBox)
        Me.Controls.Add(Wards_nameLabel)
        Me.Controls.Add(Me.Wards_nameTextBox)
        Me.Controls.Add(Wards_locationLabel)
        Me.Controls.Add(Me.Wards_locationTextBox)
        Me.Controls.Add(Wards_telLabel)
        Me.Controls.Add(Me.Wards_telTextBox)
        Me.Controls.Add(Me.WardsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ward_search"
        Me.Text = "ward_search"
        CType(Me.Dbpro73DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WardsBindingNavigator.ResumeLayout(False)
        Me.WardsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dbpro73DataSet As dbpro73DataSet
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As dbpro73DataSetTableAdapters.wardsTableAdapter
    Friend WithEvents TableAdapterManager As dbpro73DataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardsBindingNavigator As BindingNavigator
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
    Friend WithEvents WardsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Wards_idTextBox As TextBox
    Friend WithEvents Wards_nameTextBox As TextBox
    Friend WithEvents Wards_locationTextBox As TextBox
    Friend WithEvents Wards_telTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
End Class
