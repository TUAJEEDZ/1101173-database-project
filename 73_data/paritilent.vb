Public Class paritilent
    Private Sub switchForm(form As Form)
        Panel1.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Panel1.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub Panel_patlient_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub paritilent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paritilent_search = New paritilent_search()
        switchForm(paritilent_search)
    End Sub

    Private Sub report_patlient_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_X_PT_Click(sender As Object, e As EventArgs) Handles Button_X_PT.Click
        Panel2.Top = Button_X_PT.Top
        Dim paritilent_search = New paritilent_search()
        switchForm(paritilent_search)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class