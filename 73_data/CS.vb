Imports System.Data.SqlClient

Public Class CS
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tableclinic As New DataTable
    Public ldoc_Name As String
    Public clinic_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelectQuery As String = "SELECT * FROM clinic WHERE [ldoc_Name] LIKE '%" & TextBox1.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tableclinic.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tableclinic
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        clinic_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        ldoc_Name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class