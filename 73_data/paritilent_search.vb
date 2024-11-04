Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class paritilent_search
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub paritilent_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.Dbpro73DataSet.patients)
        DataGridView1.DataSource = SearchData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sForm As C
        sForm = New C()
        sForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As SC
        sForm = New SC()
        sForm.ShowDialog()
        Clinic_IDTextBox.Text = sForm.clinic_id
        'Label5.Text = sForm.patients_name
    End Sub

    Private Function SearchData() As DataTable
        Dim query As String = "SELECT * FROM View_patientsS WHERE patients_id LIKE '%' + @parm1 + '%' OR patients_name LIKE '%' + @parm1 + '%' OR clinic_ID LIKE '%' + @parm1 + '%' OR ldoc_tel LIKE '%' + @parm1 + '%' OR k_name LIKE '%' + @parm1 + '%' OR @parm1 = ''"
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
        Dim sForm As ppareport
        sForm = New ppareport()
        sForm.ShowDialog()
    End Sub
End Class