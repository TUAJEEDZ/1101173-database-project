Imports System.Reflection.Emit

Public Class requisiton_search
    Private Sub IN_patientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IN_patientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IN_patientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub requisiton_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.IN_patients' table. You can move, or remove it, as needed.
        Me.IN_patientsTableAdapter.Fill(Me.Dbpro73DataSet.IN_patients)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sForm As PS
        sForm = New PS()
        sForm.ShowDialog()
        Patients_idTextBox.Text = sForm.patients_id
        'Label5.Text = sForm.patients_name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As W
        sForm = New W()
        sForm.ShowDialog()
        Wards_idTextBox.Text = sForm.Wards_id
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sForm As pwati
        sForm = New pwati()
        sForm.ShowDialog()
    End Sub
End Class