<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Label1 As System.Windows.Forms.Label
        Me.txtTotalSales = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTS = New System.Windows.Forms.TextBox()
        Me.btnCalcTax = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCountyTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.lblCST = New System.Windows.Forms.Label()
        Me.lblSST = New System.Windows.Forms.Label()
        Me.lblTST = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Label1 = New System.Windows.Forms.Label()
        Me.txtTotalSales.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalSales.Controls.Add(Me.Panel1)
        Me.txtTotalSales.Controls.Add(Me.Panel3)
        Me.txtTotalSales.Controls.Add(Me.Panel2)
        Me.txtTotalSales.Location = New System.Drawing.Point(12, 76)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(684, 343)
        Me.txtTotalSales.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnCalcTax)
        Me.Panel2.Controls.Add(Me.txtTS)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(49, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 159)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblTST)
        Me.Panel3.Controls.Add(Me.lblSST)
        Me.Panel3.Controls.Add(Me.lblCST)
        Me.Panel3.Controls.Add(Me.lblTotalTax)
        Me.Panel3.Controls.Add(Me.lblStateTax)
        Me.Panel3.Controls.Add(Me.lblCountyTax)
        Me.Panel3.Location = New System.Drawing.Point(401, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 307)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(200, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(297, 39)
        Label1.TabIndex = 1
        Label1.Text = "Monthly Sales Tax"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Enter total Sales:"
        '
        'txtTS
        '
        Me.txtTS.Location = New System.Drawing.Point(22, 70)
        Me.txtTS.Name = "txtTS"
        Me.txtTS.Size = New System.Drawing.Size(235, 20)
        Me.txtTS.TabIndex = 1
        Me.txtTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcTax
        '
        Me.btnCalcTax.Location = New System.Drawing.Point(22, 112)
        Me.btnCalcTax.Name = "btnCalcTax"
        Me.btnCalcTax.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcTax.TabIndex = 2
        Me.btnCalcTax.Text = "Calculate"
        Me.btnCalcTax.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(182, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCountyTax
        '
        Me.lblCountyTax.AutoSize = True
        Me.lblCountyTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountyTax.Location = New System.Drawing.Point(22, 22)
        Me.lblCountyTax.Name = "lblCountyTax"
        Me.lblCountyTax.Size = New System.Drawing.Size(153, 20)
        Me.lblCountyTax.TabIndex = 0
        Me.lblCountyTax.Text = "County Sales Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(22, 112)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(141, 20)
        Me.lblStateTax.TabIndex = 1
        Me.lblStateTax.Text = "State Sales Tax:"
        '
        'lblTotalTax
        '
        Me.lblTotalTax.AutoSize = True
        Me.lblTotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTax.Location = New System.Drawing.Point(22, 202)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(137, 20)
        Me.lblTotalTax.TabIndex = 2
        Me.lblTotalTax.Text = "Total Sales Tax:"
        '
        'lblCST
        '
        Me.lblCST.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCST.Location = New System.Drawing.Point(26, 56)
        Me.lblCST.Name = "lblCST"
        Me.lblCST.Size = New System.Drawing.Size(149, 34)
        Me.lblCST.TabIndex = 3
        Me.lblCST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSST
        '
        Me.lblSST.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSST.Location = New System.Drawing.Point(26, 151)
        Me.lblSST.Name = "lblSST"
        Me.lblSST.Size = New System.Drawing.Size(149, 34)
        Me.lblSST.TabIndex = 4
        Me.lblSST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTST
        '
        Me.lblTST.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTST.Location = New System.Drawing.Point(26, 243)
        Me.lblTST.Name = "lblTST"
        Me.lblTST.Size = New System.Drawing.Size(149, 34)
        Me.lblTST.TabIndex = 5
        Me.lblTST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(16, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Location = New System.Drawing.Point(125, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 62)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 504)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Name = "Form1"
        Me.Text = "Monthly Sales Tax"
        Me.txtTotalSales.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalSales As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTST As Label
    Friend WithEvents lblSST As Label
    Friend WithEvents lblCST As Label
    Friend WithEvents lblTotalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblCountyTax As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalcTax As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
End Class
