Public Class ward
    Private Sub switchForm(form As Form)
        Panel_patlient.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Panel_patlient.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub report_ward_Click(sender As Object, e As EventArgs) Handles report_ward.Click
        Panel1.Top = report_ward.Top
        Dim ward_repost = New ward_repost()
        switchForm(ward_repost
                   )
    End Sub

    Private Sub Button_X_w_Click(sender As Object, e As EventArgs) Handles Button_X_w.Click
        Panel1.Top = Button_X_w.Top
        Dim ward_search = New ward_search()
        switchForm(ward_search)
    End Sub

    Private Sub ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ward_search = New ward_search()
        switchForm(ward_search)
    End Sub
End Class