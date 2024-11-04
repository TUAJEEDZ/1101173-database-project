Public Class medication
    Private Sub switchForm(form As Form)
        Panel_patlient.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Panel_patlient.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub


    Private Sub medication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim medication_search = New medication_search()
        switchForm(medication_search)
    End Sub

    Private Sub Button_X_w_Click(sender As Object, e As EventArgs) Handles Button_X_w.Click
        Panel1.Top = Button_X_w.Top
        Dim medication_search = New medication_search()
        switchForm(medication_search)
    End Sub

    Private Sub report_ward_Click(sender As Object, e As EventArgs)

    End Sub
End Class