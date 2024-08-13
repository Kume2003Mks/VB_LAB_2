Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FormReport

    Private connectionString As String = "Data Source=Kume_Laptop\DB6401078;Initial Catalog=dbsutstore;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.Clear()

        Dim sqlDataAdapter = New SqlDataAdapter("SELECT * FROM BestSellerProducts", connectionString)
        Dim dataSet As DataSet = New DataSet()

        sqlDataAdapter.Fill(dataSet)

        Dim rprtDS1 = New ReportDataSource("BestSellerDataset", dataSet.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)

        Dim adapterProduct = New SqlDataAdapter("SELECT * FROM OrderDetailsView", connectionString)
        Dim dsProduct As DataSet = New DataSet()
        adapterProduct.Fill(dsProduct)

        Dim rprtDS2 = New ReportDataSource("OrderDetailsViewDataset", dsProduct.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS2)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class