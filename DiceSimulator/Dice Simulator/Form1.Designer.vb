<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiceRoll
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.DicePictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DicePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prgProgressBar = New System.Windows.Forms.ProgressBar()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DicePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DicePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.RollButton)
        Me.GroupBox1.Controls.Add(Me.DicePictureBox2)
        Me.GroupBox1.Controls.Add(Me.DicePictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 351)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Take a chance"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(364, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 27)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(228, 290)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(81, 27)
        Me.RollButton.TabIndex = 3
        Me.RollButton.Text = "Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'DicePictureBox2
        '
        Me.DicePictureBox2.Image = Global.Dice_Simulator.My.Resources.Resources.Die6B
        Me.DicePictureBox2.Location = New System.Drawing.Point(400, 75)
        Me.DicePictureBox2.Name = "DicePictureBox2"
        Me.DicePictureBox2.Size = New System.Drawing.Size(104, 104)
        Me.DicePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DicePictureBox2.TabIndex = 2
        Me.DicePictureBox2.TabStop = False
        '
        'DicePictureBox1
        '
        Me.DicePictureBox1.Image = Global.Dice_Simulator.My.Resources.Resources.Die1
        Me.DicePictureBox1.Location = New System.Drawing.Point(150, 75)
        Me.DicePictureBox1.Name = "DicePictureBox1"
        Me.DicePictureBox1.Size = New System.Drawing.Size(104, 104)
        Me.DicePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DicePictureBox1.TabIndex = 1
        Me.DicePictureBox1.TabStop = False
        '
        'prgProgressBar
        '
        Me.prgProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgProgressBar.Location = New System.Drawing.Point(0, 427)
        Me.prgProgressBar.Name = "prgProgressBar"
        Me.prgProgressBar.Size = New System.Drawing.Size(800, 23)
        Me.prgProgressBar.TabIndex = 1
        '
        'tmrTimer
        '
        '
        'FrmDiceRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.prgProgressBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDiceRoll"
        Me.Text = "Dice Simulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DicePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DicePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents RollButton As Button
    Friend WithEvents DicePictureBox2 As PictureBox
    Friend WithEvents DicePictureBox1 As PictureBox
    Friend WithEvents prgProgressBar As ProgressBar
    Friend WithEvents tmrTimer As Timer
End Class
