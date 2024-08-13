Imports System.Data.SqlClient

Public Class FormProduct
    Private connectionString As String = "Data Source=Kume_Laptop\DB6401078;Initial Catalog=dbsutstore;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Dim productBindingSource As BindingSource = New BindingSource()

    Private Sub LoadData()
        Dim sql = "SELECT * FROM PRODUCT"

        Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
        Dim dataTable As DataTable = New DataTable()

        sqlAdapter.Fill(dataTable)
        productBindingSource.DataSource = dataTable
    End Sub

    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData() ' เรียกฟังก์ชันโหลดข้อมูล

            ' ผูกมัดข้อมูลกับ TextBox
            txtBoxProductId.DataBindings.Add("Text", productBindingSource, "proID")
            txtBoxProductName.DataBindings.Add("Text", productBindingSource, "proName")
            txtBoxProductPrice.DataBindings.Add("Text", productBindingSource, "proPrice", True, DataSourceUpdateMode.OnPropertyChanged) ' อัปเดตเมื่อมีการเปลี่ยนแปลง
            txtBoxProductDes.DataBindings.Add("Text", productBindingSource, "proDes")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        productBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        productBindingSource.MoveNext()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            Dim proID = txtBoxProductId.Text
            Dim sql = "DELETE FROM PRODUCT WHERE proID = '" & proID & "'"
            Dim sqlCmd = sqlConnection.CreateCommand
            sqlCmd.CommandText = sql
            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()
            sqlConnection.Close()
            LoadData()
            MessageBox.Show("สำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim proID = txtBoxProductId.Text
        Dim proName = txtBoxProductName.Text
        Dim proPrice = txtBoxProductPrice.Text
        Dim proDes = txtBoxProductDes.Text
        Dim sql = "UPDATE PRODUCT 
                    SET proID = '" & proID & "', 
                    proName = '" & proName & "', 
                    proPrice = '" & proPrice & "', 
                    proDes = '" & proDes & "' 
                    WHERE proID = '" & proID & "'"

        Dim sqlCmd = sqlConnection.CreateCommand
        sqlCmd.CommandText = sql
        sqlConnection.Open()
        sqlCmd.ExecuteNonQuery()
        sqlConnection.Close()
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtBoxProductId.Text = ""
        txtBoxProductName.Text = ""
        txtBoxProductPrice.Text = ""
        txtBoxProductDes.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim proID = txtBoxProductId.Text
        Dim proName = txtBoxProductName.Text
        Dim proPrice = txtBoxProductPrice.Text
        Dim proDes = txtBoxProductDes.Text
        Dim sql = "INSERT INTO PRODUCT VALUES ('" & proID & "', '" & proName & "', " & proPrice & ", '" & proDes & "') "
        Dim sqlCmd = sqlConnection.CreateCommand
        sqlCmd.CommandText = sql
        sqlConnection.Open()
        sqlCmd.ExecuteNonQuery()
        sqlConnection.Close()
        MessageBox.Show("บันทึกสำเร็จ")

    End Sub
End Class