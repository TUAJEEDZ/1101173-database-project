Imports System.Data.SqlClient

Public Class Psearch
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablepatients As New DataTable
    Public patients_Name As String
    Public patients_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelectQuery As String = "SELECT * FROM patients WHERE [patients_Name] LIKE '%" & TextBox1.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tablepatients.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablepatients
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        patients_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        patients_Name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class