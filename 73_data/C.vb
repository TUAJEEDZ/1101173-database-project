Public Class C
    Private Sub ClinicBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClinicBindingNavigatorSaveItem.Click, ClinicBindingNavigatorSaveItem.Click, ClinicBindingNavigatorSaveItem.Click, ClinicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClinicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.clinic' table. You can move, or remove it, as needed.
        Me.ClinicTableAdapter.Fill(Me.Dbpro73DataSet.clinic)

    End Sub
End Class