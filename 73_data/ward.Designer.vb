<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ward
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
        Me.Button_X_w = New System.Windows.Forms.Button()
        Me.report_ward = New System.Windows.Forms.Button()
        Me.Panel_patlient = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_X_w
        '
        Me.Button_X_w.BackColor = System.Drawing.Color.Red
        Me.Button_X_w.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_X_w.FlatAppearance.BorderSize = 0
        Me.Button_X_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_X_w.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_X_w.Location = New System.Drawing.Point(1009, 59)
        Me.Button_X_w.Name = "Button_X_w"
        Me.Button_X_w.Size = New System.Drawing.Size(25, 23)
        Me.Button_X_w.TabIndex = 53
        Me.Button_X_w.Text = "X"
        Me.Button_X_w.UseVisualStyleBackColor = False
        '
        'report_ward
        '
        Me.report_ward.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.report_ward.ForeColor = System.Drawing.Color.White
        Me.report_ward.Location = New System.Drawing.Point(959, 593)
        Me.report_ward.Name = "report_ward"
        Me.report_ward.Size = New System.Drawing.Size(75, 23)
        Me.report_ward.TabIndex = 51
        Me.report_ward.Text = "Report"
        Me.report_ward.UseVisualStyleBackColor = False
        '
        'Panel_patlient
        '
        Me.Panel_patlient.Location = New System.Drawing.Point(59, 86)
        Me.Panel_patlient.Name = "Panel_patlient"
        Me.Panel_patlient.Size = New System.Drawing.Size(975, 507)
        Me.Panel_patlient.TabIndex = 50
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(140, 70)
        Me.TableLayoutPanel2.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global._73_data.My.Resources.Resources.H_ward
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(959, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 24)
        Me.Panel1.TabIndex = 54
        '
        'ward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1046, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_X_w)
        Me.Controls.Add(Me.report_ward)
        Me.Controls.Add(Me.Panel_patlient)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ward"
        Me.Text = "ward"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_X_w As Button
    Friend WithEvents report_ward As Button
    Friend WithEvents Panel_patlient As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
