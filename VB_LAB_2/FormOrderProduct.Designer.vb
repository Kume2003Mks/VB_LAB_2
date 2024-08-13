<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxSearchProductID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBoxProductName = New System.Windows.Forms.TextBox()
        Me.txtBoxProCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxTotalPrice = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBoxUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemoveOrder = New System.Windows.Forms.Button()
        Me.btnInsertOrder = New System.Windows.Forms.Button()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.cProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 225)
        Me.Panel1.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.56983!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.43017!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBoxSearchProductID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSearch, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddOrder, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(206, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64815!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(477, 213)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "กรอกรหัสสินค้า"
        '
        'txtBoxSearchProductID
        '
        Me.txtBoxSearchProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearchProductID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBoxSearchProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSearchProductID.Location = New System.Drawing.Point(3, 24)
        Me.txtBoxSearchProductID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxSearchProductID.Name = "txtBoxSearchProductID"
        Me.txtBoxSearchProductID.Size = New System.Drawing.Size(292, 34)
        Me.txtBoxSearchProductID.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(301, 24)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(162, 37)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtBoxProductName, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtBoxProCount, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 77)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.01887!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.98113!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 64)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'txtBoxProductName
        '
        Me.txtBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBoxProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxProductName.Location = New System.Drawing.Point(3, 23)
        Me.txtBoxProductName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxProductName.Name = "txtBoxProductName"
        Me.txtBoxProductName.ReadOnly = True
        Me.txtBoxProductName.Size = New System.Drawing.Size(140, 34)
        Me.txtBoxProductName.TabIndex = 5
        '
        'txtBoxProCount
        '
        Me.txtBoxProCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxProCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBoxProCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxProCount.Location = New System.Drawing.Point(149, 23)
        Me.txtBoxProCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxProCount.Name = "txtBoxProCount"
        Me.txtBoxProCount.Size = New System.Drawing.Size(140, 34)
        Me.txtBoxProCount.TabIndex = 3
        Me.txtBoxProCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ชื่อสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "จำนวนสั่งซื้อ"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtBoxTotalPrice, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(301, 77)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.97468!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.02532!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(173, 64)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ราคารวม"
        '
        'txtBoxTotalPrice
        '
        Me.txtBoxTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBoxTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTotalPrice.Location = New System.Drawing.Point(3, 26)
        Me.txtBoxTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxTotalPrice.Name = "txtBoxTotalPrice"
        Me.txtBoxTotalPrice.ReadOnly = True
        Me.txtBoxTotalPrice.Size = New System.Drawing.Size(167, 34)
        Me.txtBoxTotalPrice.TabIndex = 10
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtBoxUnitPrice, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 145)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(292, 66)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'txtBoxUnitPrice
        '
        Me.txtBoxUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBoxUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxUnitPrice.Location = New System.Drawing.Point(3, 24)
        Me.txtBoxUnitPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxUnitPrice.Name = "txtBoxUnitPrice"
        Me.txtBoxUnitPrice.ReadOnly = True
        Me.txtBoxUnitPrice.Size = New System.Drawing.Size(286, 34)
        Me.txtBoxUnitPrice.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ราคาต่อหน่วย"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddOrder.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddOrder.Location = New System.Drawing.Point(301, 152)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(173, 52)
        Me.btnAddOrder.TabIndex = 15
        Me.btnAddOrder.Text = "เพิ่ม"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRemoveOrder)
        Me.Panel2.Controls.Add(Me.btnInsertOrder)
        Me.Panel2.Controls.Add(Me.dgvOrderList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 225)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(885, 274)
        Me.Panel2.TabIndex = 13
        '
        'btnRemoveOrder
        '
        Me.btnRemoveOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveOrder.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemoveOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoveOrder.Location = New System.Drawing.Point(436, 208)
        Me.btnRemoveOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveOrder.Name = "btnRemoveOrder"
        Me.btnRemoveOrder.Size = New System.Drawing.Size(167, 40)
        Me.btnRemoveOrder.TabIndex = 18
        Me.btnRemoveOrder.Text = "ลบการสั่งซื้อ"
        Me.btnRemoveOrder.UseVisualStyleBackColor = False
        '
        'btnInsertOrder
        '
        Me.btnInsertOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertOrder.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInsertOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInsertOrder.Location = New System.Drawing.Point(637, 208)
        Me.btnInsertOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsertOrder.Name = "btnInsertOrder"
        Me.btnInsertOrder.Size = New System.Drawing.Size(167, 40)
        Me.btnInsertOrder.TabIndex = 17
        Me.btnInsertOrder.Text = "ยืนยันการสั่งซื้อ"
        Me.btnInsertOrder.UseVisualStyleBackColor = False
        '
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cProductID, Me.cProductName, Me.cPrice, Me.cProCount, Me.cTotalPrice})
        Me.dgvOrderList.Location = New System.Drawing.Point(81, 29)
        Me.dgvOrderList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.RowHeadersWidth = 62
        Me.dgvOrderList.RowTemplate.Height = 28
        Me.dgvOrderList.Size = New System.Drawing.Size(724, 162)
        Me.dgvOrderList.TabIndex = 0
        '
        'cProductID
        '
        Me.cProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cProductID.HeaderText = "รหัสสินค้า"
        Me.cProductID.MinimumWidth = 8
        Me.cProductID.Name = "cProductID"
        Me.cProductID.ReadOnly = True
        '
        'cProductName
        '
        Me.cProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cProductName.HeaderText = "ชื่อสินค้า"
        Me.cProductName.MinimumWidth = 8
        Me.cProductName.Name = "cProductName"
        Me.cProductName.ReadOnly = True
        '
        'cPrice
        '
        Me.cPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cPrice.HeaderText = "ราคา"
        Me.cPrice.MinimumWidth = 8
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'cProCount
        '
        Me.cProCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cProCount.HeaderText = "จำนวนการสั่ง"
        Me.cProCount.MinimumWidth = 8
        Me.cProCount.Name = "cProCount"
        Me.cProCount.ReadOnly = True
        '
        'cTotalPrice
        '
        Me.cTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cTotalPrice.HeaderText = "ราคารวม"
        Me.cTotalPrice.MinimumWidth = 8
        Me.cTotalPrice.Name = "cTotalPrice"
        Me.cTotalPrice.ReadOnly = True
        '
        'FormOrderProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 499)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormOrderProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOrderProduct"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxSearchProductID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtBoxProductName As TextBox
    Friend WithEvents txtBoxProCount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxTotalPrice As TextBox
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvOrderList As DataGridView
    Friend WithEvents cProductID As DataGridViewTextBoxColumn
    Friend WithEvents cProductName As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Friend WithEvents cProCount As DataGridViewTextBoxColumn
    Friend WithEvents cTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents btnInsertOrder As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtBoxUnitPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRemoveOrder As Button
End Class
