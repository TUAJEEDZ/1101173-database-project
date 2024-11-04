Public Class shift
    Private Sub ShiftsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ShiftsBindingNavigatorSaveItem.Click, ShiftsBindingNavigatorSaveItem.Click, ShiftsBindingNavigatorSaveItem.Click, ShiftsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShiftsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.shifts' table. You can move, or remove it, as needed.
        Me.ShiftsTableAdapter.Fill(Me.Dbpro73DataSet.shifts)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sForm As SS
        sForm = New SS()
        sForm.ShowDialog()
        Staffs_idTextBox.Text = sForm.staffs_id
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sForm As W
        sForm = New W()
        sForm.ShowDialog()
        Wards_idTextBox.Text = sForm.wards_id
    End Sub
End Class