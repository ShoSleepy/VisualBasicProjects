Public Class Form1
    Private Sub Combtn_Click(sender As Object, e As EventArgs) Handles Combtn.Click
        'Declare Local Variables
        Dim containsValidNumbers As Boolean = False
        Dim IntA As Integer
        Dim IntB As Integer

        ' Clear any previously displayed message.
        Answerlbl.Text = String.Empty

        ' Is it an Integer?
        If Integer.TryParse(IntAtxt.Text, IntA) And
            Integer.TryParse(IntBtxt.Text, IntB) Then
        Else
            MessageBox.Show("Please enter only Integers.")
        End If

        If IntA = IntB Then
            Answerlbl.Text = "Integer A is equal to Integer B."
        ElseIf IntA > IntB Then
            Answerlbl.Text = "Integer A is greater than Integer B"
        ElseIf IntB > IntA Then
            Answerlbl.Text = "Integer B is greater than Integer A"
        End If
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
