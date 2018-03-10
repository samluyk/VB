Public Class frmCalc

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Function CalculateRetail(ByVal Cost As Decimal, ByVal Percent As Decimal) As Decimal

        Dim Cost As Decimal
        Dim Percent As Decimal
        Dim Price As Decimal

        Cost = txtCost.Text
        Percent = txtPercent.Text

        If (Cost > 0) And (Percent > 0) Then
            Percent = (1 + (txtPercent.Text / 100))
            Price = Cost * Percent
            txtPrice.Text = Price
        Else
            MessageBox.Show("That isn't a positive number, man.",
            "User Input Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
