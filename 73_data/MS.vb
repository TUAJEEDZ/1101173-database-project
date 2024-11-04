Imports System.Data.SqlClient

Public Class MS
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablemedications As New DataTable
    Public medications_name As String
    Public medications_id As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlStatement As String = "SELECT * FROM medications WHERE medications_id LIKE '%" & TextBox1.Text & "%' OR medications_name LIKE '%" & TextBox1.Text & "%'"
        Dim SqlCommand As New SqlCommand(sqlStatement, sqlConnection)
        Dim SqlReader As SqlDataReader

        sqlConnection.Open()
        SqlReader = SqlCommand.ExecuteReader()
        tablemedications.Load(SqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablemedications
        DataGridView1.Refresh()

    End Sub

    Private Function SearchData() As DataTable
        Dim query As String = "SELECT * FROM medications WHERE medications_id LIKE '%' + @parm1 + '%' OR medications_name LIKE '%' + @parm1 + '%' OR @parm1 = ''"
        Dim connectionString As String = "Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True"

        Using connection As SqlConnection = New SqlConnection(connectionString)
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@parm1", TextBox1.Text.Trim())
                Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                Dim dataTable As DataTable = New DataTable
                dataAdapter.Fill(dataTable)
                Return dataTable
            End Using
        End Using
    End Function

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        DataGridView1.DataSource = SearchData()
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        medications_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        medications_name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class