Public Class Form1
    Private Sub switchForm(form As Form)
        Picture.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        Picture.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub staff_button_Click(sender As Object, e As EventArgs) Handles staff_button.Click
        Dim staff = New staff()
        switchForm(staff)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim home = New home()
        switchForm(home)
    End Sub

    Private Sub partilient_button_Click(sender As Object, e As EventArgs) Handles partilient_button.Click
        Dim paritilent = New paritilent()
        switchForm(paritilent)
    End Sub

    Private Sub ward_Button_Click(sender As Object, e As EventArgs) Handles ward_Button.Click
        Dim ward = New ward()
        switchForm(ward)
    End Sub

    Private Sub medilcation_Button_Click(sender As Object, e As EventArgs) Handles medilcation_Button.Click
        Dim medilcationd = New medication()
        switchForm(medilcationd)
    End Sub

    Private Sub supplos_Button_Click(sender As Object, e As EventArgs) Handles supplos_Button.Click
        Dim requisiton = New requisiton()
        switchForm(requisiton)

    End Sub

    Private Sub requisiton_Button_Click(sender As Object, e As EventArgs) Handles requisiton_Button.Click
        Dim suppile = New suppiles()
        switchForm(suppile)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim home = New home()
        switchForm(home)
    End Sub
End Class
