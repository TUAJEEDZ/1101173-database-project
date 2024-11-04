Imports System.Data.SqlClient

Public Class staffViewsearch
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Dim tablestaffs As New DataTable
    Public staffs_name As String
    Public staffs_id As String
    Public staffs_address As String
    Public staffs_tel As String
    Public staffs_birth As Date
    Public staffs_sex As String
    Public staffs_nin As String
    Public staffs_position As String
    Public staffs_current As String
    Public staffs_scale As String
    Public qualifacation_type As String
    Public qualifacation_date As Date
    Public qualifacation_ins As String
    Public workexp_position As String
    Public workexp_startdate As Date
    Public workexp_finishdate As Date
    Public name_ogn As String
    Public workexp_surgury As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelectQuery As String = "SELECT * FROM staffs WHERE staffs_name LIKE '%" & TextBox1.Text & "%' or staffs_id LIKE '%" & TextBox1.Text & "%' or staffs_position LIKE '%" & TextBox1.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tablestaffs.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablestaffs
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        staffs_id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        staffs_name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        staffs_address = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        staffs_tel = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        staffs_birth = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        staffs_sex = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
        staffs_nin = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
        staffs_position = DataGridView1.SelectedRows(0).Cells(7).Value.ToString()
        staffs_current = DataGridView1.SelectedRows(0).Cells(8).Value.ToString()
        staffs_scale = DataGridView1.SelectedRows(0).Cells(9).Value.ToString()
        qualifacation_type = DataGridView1.SelectedRows(0).Cells(10).Value.ToString()
        qualifacation_date = DataGridView1.SelectedRows(0).Cells(11).Value.ToString()
        qualifacation_ins = DataGridView1.SelectedRows(0).Cells(12).Value.ToString()
        workexp_position = DataGridView1.SelectedRows(0).Cells(13).Value.ToString()
        workexp_startdate = DataGridView1.SelectedRows(0).Cells(14).Value.ToString()
        workexp_finishdate = DataGridView1.SelectedRows(0).Cells(15).Value.ToString()
        name_ogn = DataGridView1.SelectedRows(0).Cells(16).Value.ToString()
        workexp_surgury = DataGridView1.SelectedRows(0).Cells(17).Value.ToString()
        Me.Close()
    End Sub

    Private Sub staffViewsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class