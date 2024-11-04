Imports System.Data.SqlClient

Public Class Msearch
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablemedications As New DataTable
    Public medications_Name As String
    Public medications_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelectQuery As String = "SELECT * FROM medications WHERE [medications_Name] LIKE '%" & TextBox1.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tablemedications.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablemedications
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        medications_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        medications_Name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class