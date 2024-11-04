Imports System.Data.SqlClient

Public Class SSSSSSSSS

    Private Function SearchData() As DataTable
        Dim query As String = "SELECT * FROM staffs WHERE staffs_id LIKE '%' + @parm1 + '%' OR staffs_name LIKE '%' + @parm1 + '%' OR staffs_position LIKE '%' + @parm1 + '%' OR @parm1 = ''"
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

    Private Sub SSSSSSSSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = SearchData()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        DataGridView1.DataSource = SearchData()
    End Sub
End Class