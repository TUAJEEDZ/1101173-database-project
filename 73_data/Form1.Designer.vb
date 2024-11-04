<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.requisiton_Button = New System.Windows.Forms.Button()
        Me.supplos_Button = New System.Windows.Forms.Button()
        Me.medilcation_Button = New System.Windows.Forms.Button()
        Me.ward_Button = New System.Windows.Forms.Button()
        Me.partilient_button = New System.Windows.Forms.Button()
        Me.staff_button = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 79)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._73_data.My.Resources.Resources.theWH
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1102, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(150, 71)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Button2.BackgroundImage = Global._73_data.My.Resources.Resources.home
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 65)
        Me.Button2.TabIndex = 0
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.requisiton_Button, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.supplos_Button, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.medilcation_Button, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ward_Button, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.partilient_button, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.staff_button, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 79)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.740258!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(119, 682)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'requisiton_Button
        '
        Me.requisiton_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.requisiton_Button.BackgroundImage = Global._73_data.My.Resources.Resources.Sp
        Me.requisiton_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.requisiton_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.requisiton_Button.FlatAppearance.BorderSize = 0
        Me.requisiton_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.requisiton_Button.Location = New System.Drawing.Point(3, 463)
        Me.requisiton_Button.Name = "requisiton_Button"
        Me.requisiton_Button.Size = New System.Drawing.Size(113, 86)
        Me.requisiton_Button.TabIndex = 5
        Me.requisiton_Button.UseVisualStyleBackColor = False
        '
        'supplos_Button
        '
        Me.supplos_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.supplos_Button.BackgroundImage = CType(resources.GetObject("supplos_Button.BackgroundImage"), System.Drawing.Image)
        Me.supplos_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.supplos_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.supplos_Button.FlatAppearance.BorderSize = 0
        Me.supplos_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplos_Button.Location = New System.Drawing.Point(3, 371)
        Me.supplos_Button.Name = "supplos_Button"
        Me.supplos_Button.Size = New System.Drawing.Size(113, 86)
        Me.supplos_Button.TabIndex = 4
        Me.supplos_Button.UseVisualStyleBackColor = False
        '
        'medilcation_Button
        '
        Me.medilcation_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.medilcation_Button.BackgroundImage = Global._73_data.My.Resources.Resources.medication
        Me.medilcation_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.medilcation_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medilcation_Button.FlatAppearance.BorderSize = 0
        Me.medilcation_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.medilcation_Button.Location = New System.Drawing.Point(3, 279)
        Me.medilcation_Button.Name = "medilcation_Button"
        Me.medilcation_Button.Size = New System.Drawing.Size(113, 86)
        Me.medilcation_Button.TabIndex = 3
        Me.medilcation_Button.UseVisualStyleBackColor = False
        '
        'ward_Button
        '
        Me.ward_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ward_Button.BackgroundImage = Global._73_data.My.Resources.Resources.ward
        Me.ward_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ward_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ward_Button.FlatAppearance.BorderSize = 0
        Me.ward_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ward_Button.Location = New System.Drawing.Point(3, 187)
        Me.ward_Button.Name = "ward_Button"
        Me.ward_Button.Size = New System.Drawing.Size(113, 86)
        Me.ward_Button.TabIndex = 2
        Me.ward_Button.UseVisualStyleBackColor = False
        '
        'partilient_button
        '
        Me.partilient_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.partilient_button.BackgroundImage = Global._73_data.My.Resources.Resources.pt_icon
        Me.partilient_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.partilient_button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partilient_button.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.partilient_button.FlatAppearance.BorderSize = 0
        Me.partilient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.partilient_button.Location = New System.Drawing.Point(3, 95)
        Me.partilient_button.Name = "partilient_button"
        Me.partilient_button.Size = New System.Drawing.Size(113, 86)
        Me.partilient_button.TabIndex = 1
        Me.partilient_button.UseVisualStyleBackColor = False
        '
        'staff_button
        '
        Me.staff_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.staff_button.BackgroundImage = Global._73_data.My.Resources.Resources.staff
        Me.staff_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.staff_button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.staff_button.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.staff_button.FlatAppearance.BorderSize = 0
        Me.staff_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.staff_button.Location = New System.Drawing.Point(3, 3)
        Me.staff_button.Name = "staff_button"
        Me.staff_button.Size = New System.Drawing.Size(113, 86)
        Me.staff_button.TabIndex = 0
        Me.staff_button.UseVisualStyleBackColor = False
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Picture.Location = New System.Drawing.Point(120, 80)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(1142, 682)
        Me.Picture.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "The Wellmeadows Hospital"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents requisiton_Button As Button
    Friend WithEvents supplos_Button As Button
    Friend WithEvents medilcation_Button As Button
    Friend WithEvents ward_Button As Button
    Friend WithEvents partilient_button As Button
    Friend WithEvents staff_button As Button
    Friend WithEvents Picture As Panel
End Class
