Imports System.Data.SqlClient
Public Class Yasearch
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablemedications As New DataTable
    Public medications_name As String
    Public medications_id As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelectQuery As String = "SELECT * FROM medications WHERE medications_name LIKE '%" & TextBox1.Text & "%' or medications_id LIKE '%" & TextBox1.Text & "%' or dosage LIKE '%" & TextBox1.Text & "%' or method_of_Admin LIKE '%" & TextBox1.Text & "%'"
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
        medications_name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        medications_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Me.Close()
    End Sub
End Class