﻿Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class ppareport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlConnection As New SqlConnection("Data Source=MSI\TUAJEEDZ02;Initial Catalog=dbpro73;Integrated Security=True")
        Dim com As New SqlCommand("Select * from patients ", sqlConnection)
        Dim SqlDA As New SqlDataAdapter(com)
        Dim dt As New DataTable
        SqlDA.Fill(dt)

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\msi gaming\OneDrive\Desktop\73_data\73_data\ReportPA.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ppareport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class