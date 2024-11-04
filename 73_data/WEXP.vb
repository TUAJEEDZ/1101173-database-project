Public Class WEXP
    Private Sub WorkexpBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WorkexpBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkexpBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub WEXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.workexp' table. You can move, or remove it, as needed.
        Me.WorkexpTableAdapter.Fill(Me.Dbpro73DataSet.workexp)

    End Sub
End Class