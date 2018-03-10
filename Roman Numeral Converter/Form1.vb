Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click


        Dim numEntered As Integer


        'txtNumber.Text = numEntered
        numEntered = txtNumber.Text

        If (numEntered > 0) And (numEntered < 11) Then

            Select Case lblRomanEquivalent.ToString
                Case 1
                    lblRomanEquivalent.Text = ("I")
                Case 2
                    lblRomanEquivalent.Text = ("II")
                Case 3
                    lblRomanEquivalent.Text = ("III")
                Case 4
                    lblRomanEquivalent.Text = ("IV")
                Case 5
                    lblRomanEquivalent.Text = ("V")
                Case 6
                    lblRomanEquivalent.Text = ("VI")
                Case 7
                    lblRomanEquivalent.Text = ("VII")
                Case 8
                    lblRomanEquivalent.Text = ("VIII")
                Case 9
                    lblRomanEquivalent.Text = ("IX")
                Case 10
                    lblRomanEquivalent.Text = ("X")

            End Select
        Else
            MessageBox.Show("pls only 1-10 thx",
            "Data Entry Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub
End Class
