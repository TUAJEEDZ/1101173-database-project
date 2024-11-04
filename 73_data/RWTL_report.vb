Imports System.Data.SqlClient

Public Class RWTL_report
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Msearch
        sForm = New Msearch()
        sForm.ShowDialog()
        Patients_idTextBox.Text = sForm.patients_id
    End Sub

    Private Sub IN_patientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IN_patientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IN_patientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub RWTL_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.IN_patients' table. You can move, or remove it, as needed.
        Me.IN_patientsTableAdapter.Fill(Me.Dbpro73DataSet.IN_patients)

    End Sub
End Class