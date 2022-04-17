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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Answerlbl = New System.Windows.Forms.Label()
        Me.IntAtxt = New System.Windows.Forms.TextBox()
        Me.IntBtxt = New System.Windows.Forms.TextBox()
        Me.Combtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter Two Integers"
        '
        'Answerlbl
        '
        Me.Answerlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Answerlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answerlbl.Location = New System.Drawing.Point(27, 124)
        Me.Answerlbl.Name = "Answerlbl"
        Me.Answerlbl.Size = New System.Drawing.Size(379, 33)
        Me.Answerlbl.TabIndex = 5
        Me.Answerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntAtxt
        '
        Me.IntAtxt.Location = New System.Drawing.Point(88, 70)
        Me.IntAtxt.Name = "IntAtxt"
        Me.IntAtxt.Size = New System.Drawing.Size(100, 20)
        Me.IntAtxt.TabIndex = 6
        '
        'IntBtxt
        '
        Me.IntBtxt.Location = New System.Drawing.Point(259, 70)
        Me.IntBtxt.Name = "IntBtxt"
        Me.IntBtxt.Size = New System.Drawing.Size(100, 20)
        Me.IntBtxt.TabIndex = 7
        '
        'Combtn
        '
        Me.Combtn.Location = New System.Drawing.Point(88, 196)
        Me.Combtn.Name = "Combtn"
        Me.Combtn.Size = New System.Drawing.Size(75, 23)
        Me.Combtn.TabIndex = 8
        Me.Combtn.Text = "Compare"
        Me.Combtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(259, 196)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.Exitbtn.TabIndex = 9
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(430, 249)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Combtn)
        Me.Controls.Add(Me.IntBtxt)
        Me.Controls.Add(Me.IntAtxt)
        Me.Controls.Add(Me.Answerlbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Answerlbl As Label
    Friend WithEvents IntAtxt As TextBox
    Friend WithEvents IntBtxt As TextBox
    Friend WithEvents Combtn As Button
    Friend WithEvents Exitbtn As Button
End Class
