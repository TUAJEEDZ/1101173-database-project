Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class medication_search
    Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
    Private Sub MedicationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MedicationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MedicationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)

    End Sub

    Private Sub medication_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbpro73DataSet.View_TM' table. You can move, or remove it, as needed.
        Me.View_TMTableAdapter.Fill(Me.Dbpro73DataSet.View_TM)
        'TODO: This line of code loads data into the 'Dbpro73DataSet.treatment' table. You can move, or remove it, as needed.
        'Me.TreatmentTableAdapter.Fill(Me.Dbpro73DataSet.treatment)
        'TODO: This line of code loads data into the 'Dbpro73DataSet.medications' table. You can move, or remove it, as needed.
        Me.MedicationsTableAdapter.Fill(Me.Dbpro73DataSet.medications)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sForm As SS
        sForm = New SS()
        sForm.ShowDialog()
        Staffs_idTextBox.Text = sForm.staffs_id
        Label3.Text = sForm.staffs_name
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sForm As MS
        sForm = New MS()
        sForm.ShowDialog()
        Medications_idTextBox1.Text = sForm.medications_id
        Label4.Text = sForm.medications_name
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sForm As PS
        sForm = New PS()
        sForm.ShowDialog()
        Patients_idTextBox.Text = sForm.patients_id
        Label5.Text = sForm.patients_name
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Dim sqlInsert As String = "INSERT INTO treatment (staffs_id, medications_id, patients_id, quantity, treatmentdate) VALUES("
        'sqlInsert &= "'" & Staffs_idTextBox.Text & "'" & ", " & "'" & Medications_idTextBox1.Text & "'" & ", " & "'" & Patients_idTextBox.Text & "'" & ", " & "'" & QuantityTextBox.Text & ", '"
        'sqlInsert &= DateTime.Now & "')"

        'Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        'sqlConnection.Open()
        'sqlCommand.ExecuteNonQuery()
        'sqlConnection.Close()

        'sqlCommand.ExecuteNonQuery()
        'sqlConnection.Close()

        'MsgBox("บันทึกสำเร็จ")
        Dim sqlInsert As String = "INSERT INTO treatment (staffs_id, medications_id, patients_id, quantity, treatmentdate) VALUES (@staffs_id, @medications_id, @patients_id, @quantity, @treatmentdate)"

        Using sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@staffs_id", Staffs_idTextBox.Text)
            sqlCommand.Parameters.AddWithValue("@medications_id", Medications_idTextBox1.Text)
            sqlCommand.Parameters.AddWithValue("@patients_id", Patients_idTextBox.Text)
            sqlCommand.Parameters.AddWithValue("@quantity", QuantityTextBox.Text)
            sqlCommand.Parameters.AddWithValue("@treatmentdate", DateTime.Now)

            sqlConnection.Open()
            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()
        End Using

        MsgBox("บันทึกสำเร็จ")
        Me.TableAdapterManager.UpdateAll(Me.Dbpro73DataSet)
        Me.View_TMTableAdapter.Fill(Me.Dbpro73DataSet.View_TM)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim sForm As ptreport
        sForm = New ptreport()
        sForm.ShowDialog()
    End Sub
End Class