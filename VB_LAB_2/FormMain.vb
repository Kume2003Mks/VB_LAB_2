Imports System.Data.SqlClient

Public Class FormMain
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        FormOrderProduct.Show()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        FormProduct.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        FormReport.Show()
    End Sub
End Class
