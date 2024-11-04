Public Class Q
    Private Sub QualifacationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QualifacationBindingNavigatorSaveItem.Click, QualifacationBindingNavigatorSaveItem.Click, QualifacationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QualifacationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub Q_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.qualifacation' table. You can move, or remove it, as needed.
        Me.QualifacationTableAdapter.Fill(Me.Dbpro73DataSet.qualifacation)

    End Sub
End Class