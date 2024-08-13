Imports System.Data.SqlClient

Public Class FormOrderProduct

    Private connectionString As String = "Data Source=Kume_Laptop\DB6401078;Initial Catalog=dbsutstore;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim idSearch = txtBoxSearchProductID.Text

        Dim sql = "SELECT TOP 1 * FROM PRODUCT WHERE proID = '" & idSearch & "'"

        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql

        sqlConnection.Open()

        Dim sqlReader = cmd.ExecuteReader()

        Do While sqlReader.Read()
            txtBoxProductName.Text = sqlReader.Item("proName")
            txtBoxUnitPrice.Text = sqlReader.Item("proPrice")
        Loop

        sqlReader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub txtBoxProCount_TextChanged(sender As Object, e As EventArgs) Handles txtBoxProCount.TextChanged
        Try
            If txtBoxProCount.Text.Trim <> "" Then
                Dim unitPrice As Integer
                Dim proCount As Integer

                If Integer.TryParse(txtBoxUnitPrice.Text, unitPrice) AndAlso Integer.TryParse(txtBoxProCount.Text, proCount) Then
                    txtBoxTotalPrice.Text = (unitPrice * proCount).ToString()
                Else
                    MessageBox.Show("Please enter valid numbers for unit price and product count.")
                    txtBoxTotalPrice.Text = ""
                End If
            Else
                txtBoxTotalPrice.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Try
            ' Validate input (e.g., check if textboxes are not empty)
            If String.IsNullOrEmpty(txtBoxSearchProductID.Text) Then
                MessageBox.Show("Please enter a product ID.")
                Return
            End If

            ' Convert text to appropriate data types
            Dim proID As Integer = Integer.Parse(txtBoxSearchProductID.Text)
            Dim proName As String = txtBoxProductName.Text
            Dim proPrice As Decimal = Decimal.Parse(txtBoxUnitPrice.Text)
            Dim proCount As Integer = Integer.Parse(txtBoxProCount.Text)
            Dim totalPrice As Decimal = proPrice * proCount

            ' Create a new row
            Dim row As Object() = {proID, proName, proPrice, proCount, totalPrice}

            ' Add the row to the DataGridView
            dgvOrderList.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRemoveOrder_Click(sender As Object, e As EventArgs) Handles btnRemoveOrder.Click
        Try
            If dgvOrderList.CurrentRow IsNot Nothing Then
                dgvOrderList.Rows.RemoveAt(dgvOrderList.CurrentRow.Index)
            End If
        Catch ex As Exception
            ' Handle the exception here, for example:
            MessageBox.Show("An error occurred while removing the row: " & ex.Message)
        End Try
    End Sub

    Private Sub btnInsertOrder_Click(sender As Object, e As EventArgs) Handles btnInsertOrder.Click
         sqlConnection.Open()

    Dim sqlCmd = sqlConnection.CreateCommand

    For Each row As DataGridViewRow In dgvorderList.Rows
        Dim proID = row.Cells(0).Value
        Dim proName = row.Cells(1).Value
        Dim proCount = row.Cells(3).Value

            Dim sql = "INSERT INTO ORDERS (proID, proCount) VALUES ('" & proID & "'," & proCount & ")"

            sqlCmd.CommandText = sql
        sqlCmd.ExecuteNonQuery()
    Next
        MessageBox.Show("Add complete")
        sqlConnection.Close()
    End Sub
End Class