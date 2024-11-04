Imports System.Data.SqlClient

Public Class ward_search
    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WardsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub ward_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.Dbpro73DataSet.wards)
        DataGridView1.DataSource = SearchData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sForm As shift
        sForm = New shift()
        sForm.ShowDialog()
    End Sub

    Private Function SearchData() As DataTable
        Dim query As String = "SELECT * FROM View_Shifts WHERE staffs_id LIKE '%' + @parm1 + '%' OR staffs_name LIKE '%' + @parm1 + '%' OR shifts LIKE '%' + @parm1 + '%' OR wards_id LIKE '%' + @parm1 + '%' OR wards_name LIKE '%' + @parm1 + '%' OR @parm1 = ''"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sForm As pwreport
        sForm = New pwreport()
        sForm.ShowDialog()
    End Sub
End Class