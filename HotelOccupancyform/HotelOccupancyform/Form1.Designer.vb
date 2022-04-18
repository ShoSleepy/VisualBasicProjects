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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FloorsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumRoomsTextbox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotOccupiedLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OverallRateLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.NumRoomsTextbox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FloorsComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the occupancy rate for each floor"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DataListBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(46, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 332)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Floor Occupancy Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Floor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of rooms = 30"
        '
        'FloorsComboBox
        '
        Me.FloorsComboBox.FormattingEnabled = True
        Me.FloorsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.FloorsComboBox.Location = New System.Drawing.Point(216, 49)
        Me.FloorsComboBox.Name = "FloorsComboBox"
        Me.FloorsComboBox.Size = New System.Drawing.Size(88, 28)
        Me.FloorsComboBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number of occupied" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rooms:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NumRoomsTextbox
        '
        Me.NumRoomsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumRoomsTextbox.Location = New System.Drawing.Point(530, 51)
        Me.NumRoomsTextbox.Name = "NumRoomsTextbox"
        Me.NumRoomsTextbox.Size = New System.Drawing.Size(62, 26)
        Me.NumRoomsTextbox.TabIndex = 4
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(495, 97)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(109, 30)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DataListBox
        '
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.ItemHeight = 20
        Me.DataListBox.Location = New System.Drawing.Point(37, 41)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(658, 164)
        Me.DataListBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Rooms Occupied"
        '
        'TotOccupiedLbl
        '
        Me.TotOccupiedLbl.BackColor = System.Drawing.SystemColors.Control
        Me.TotOccupiedLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotOccupiedLbl.Location = New System.Drawing.Point(290, 494)
        Me.TotOccupiedLbl.Name = "TotOccupiedLbl"
        Me.TotOccupiedLbl.Size = New System.Drawing.Size(72, 23)
        Me.TotOccupiedLbl.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(412, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Overall Occupancy Rate"
        '
        'OverallRateLbl
        '
        Me.OverallRateLbl.BackColor = System.Drawing.SystemColors.Control
        Me.OverallRateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OverallRateLbl.Location = New System.Drawing.Point(664, 495)
        Me.OverallRateLbl.Name = "OverallRateLbl"
        Me.OverallRateLbl.Size = New System.Drawing.Size(77, 23)
        Me.OverallRateLbl.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(269, 593)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(416, 593)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 658)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OverallRateLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotOccupiedLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Hotel Occupancy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents NumRoomsTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FloorsComboBox As ComboBox
    Friend WithEvents DataListBox As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TotOccupiedLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents OverallRateLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
