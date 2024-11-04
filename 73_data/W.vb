Imports System.Data.SqlClient

Public Class W
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablewards As New DataTable
    Public wards_name As String
    Public wards_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlStatement As String = "SELECT * FROM wards WHERE wards_id LIKE '%" & TextBox1.Text & "%' OR wards_name LIKE '%" & TextBox1.Text & "%' OR wards_location LIKE '%" & TextBox1.Text & "%'"
        Dim SqlCommand As New SqlCommand(sqlStatement, sqlConnection)
        Dim SqlReader As SqlDataReader

        sqlConnection.Open()
        SqlReader = SqlCommand.ExecuteReader()
        tablewards.Load(SqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablewards
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        wards_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        wards_name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class