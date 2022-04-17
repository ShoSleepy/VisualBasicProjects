'Dice Simulator
'Brandon Jones
'11/3/21

Public Class FrmDiceRoll
    Dim dice1 As Integer                     'Sets Dice as Integers
    Dim dice2 As Integer
    Dim random As Random                            'Gives us a Random Variable


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Get out
        Me.Close()

    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        'Roll Button Starts Timer
        tmrTimer.Start()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'Set up for Random Dice roll 
        random = New Random
        prgProgressBar.Increment(5)

        If prgProgressBar.Value = 100 Then
            tmrTimer.Stop()
            prgProgressBar.Value = 0

        Else
            dice1 = random.Next(1, 7)
            dice2 = random.Next(1, 7)

            If dice1 = 1 Then
                DicePictureBox1.Image = My.Resources.Die1
            ElseIf dice1 = 2 Then
                DicePictureBox1.Image = My.Resources.Die2
            ElseIf dice1 = 3 Then
                DicePictureBox1.Image = My.Resources.Die3
            ElseIf dice1 = 4 Then
                DicePictureBox1.Image = My.Resources.Die4
            ElseIf dice1 = 5 Then
                DicePictureBox1.Image = My.Resources.Die5
            ElseIf dice1 = 6 Then
                DicePictureBox1.Image = My.Resources.Die6
            End If

            If dice2 = 1 Then
                DicePictureBox2.Image = My.Resources.Die1B
            ElseIf dice1 = 2 Then
                DicePictureBox2.Image = My.Resources.Die2B
            ElseIf dice1 = 3 Then
                DicePictureBox2.Image = My.Resources.Die3B
            ElseIf dice1 = 4 Then
                DicePictureBox2.Image = My.Resources.Die4B
            ElseIf dice1 = 5 Then
                DicePictureBox2.Image = My.Resources.Die5B
            ElseIf dice1 = 6 Then
                DicePictureBox2.Image = My.Resources.Die6B
            End If
        End If
    End Sub
End Class
