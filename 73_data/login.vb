Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "admin" Or TextBox1.Text = "Admin") And TextBox2.Text = "1234" Then
            MsgBox("ยินดีตอนรับ" & vbNewLine & TextBox1.Text, MsgBoxStyle.Information)
            Me.Hide()
            Form1.Show()
        ElseIf TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Enter your Username")
        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Enter your Password")
        Else
            MsgBox("Wrong Username and Password", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ตั้งค่า PasswordChar ให้ TextBox แล้ว
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class