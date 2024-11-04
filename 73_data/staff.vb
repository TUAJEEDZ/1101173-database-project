Public Class staff
    Private Sub switchForm(form As Form)
        Panel1.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Panel1.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staff_search = New staff_search()
        switchForm(staff_search)
    End Sub

    Private Sub report_staff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_X_s_Click(sender As Object, e As EventArgs) Handles Button_X_s.Click
        Panel3.Top = Button_X_s.Top
        Dim staff_search = New staff_search()
        switchForm(staff_search)
    End Sub
End Class