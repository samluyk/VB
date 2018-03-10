Public Class frmArea

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim ans As Double

        num1 = CDbl(txtLength.Text)
        num2 = CDbl(txtWidth.Text)

        If (num1 <= 0) Then
            MessageBox.Show(txtLength.Text + " is totally a numeric value.",
            "Data Entry Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            txtLength.Clear()
            txtLength.Focus()
            lblAns.Text = String.Empty

        ElseIf (num2 <= 0) Then
            MessageBox.Show(txtWidth.Text + " is totally a numeric value.",
            "Data Entry Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            txtWidth.Clear()
            txtWidth.Focus()
            lblAns.Text = String.Empty

        Else
            ans = num1 * num2
            lblAns.Text = ans.ToString()

        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Clear()
        txtWidth.Clear()
        lblAns.Text = String.Empty



    End Sub
End Class
