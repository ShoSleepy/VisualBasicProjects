Public Class Form1
    Private Sub txtTotalSales_Paint(sender As Object, e As PaintEventArgs) Handles txtTotalSales.Paint

    End Sub

    Private Sub btnCalcTax_Click(sender As Object, e As EventArgs) Handles btnCalcTax.Click
        ' Declare Variables for the Calculations.
        Dim decCST As Decimal ' County Sales Tax Total
        Dim decSST As Decimal ' State Sales Tax Total
        Dim decTST As Decimal ' Total Sales Tax Total
        Const decCOUNTY_RATE As Decimal = 0.02D ' County Tax Rate
        Const decSTATE_RATE As Decimal = 0.04D ' State Tax Rate

        Try
            ' Calculate and display the County Tax Total.
            decCST = CDec(txtTS.Text) * decCOUNTY_RATE
            lblCST.Text = decCST.ToString("c")

            ' Calculate and display the State Tax Total.
            decSST = CDec(txtTS.Text) * decSTATE_RATE
            lblSST.Text = decSST.ToString("c")

            ' Calculate and display the Total Tax Total.
            decTST = decCST + decSST
            lblTST.Text = decTST.ToString("c")

        Catch ex As Exception
            ' Error Message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the Tax info fields.
        txtTS.Clear()

        ' Clear the decTotal fields.
        lblCST.Text = String.Empty
        lblSST.Text = String.Empty
        lblTST.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
