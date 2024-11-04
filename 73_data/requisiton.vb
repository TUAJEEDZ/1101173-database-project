Public Class requisiton
    Private Sub switchForm(form As Form)
        Panel_3.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Panel_3.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub requisiton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim requisiton_search = New requisiton_search()
        switchForm(requisiton_search)
    End Sub
End Class