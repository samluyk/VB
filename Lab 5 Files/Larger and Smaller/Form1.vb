Public Class frmOne

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim A As Integer
        Dim B As Integer

        A = txtNumberOne.Text
        B = txtNumberTwo.Text

        If A = B Then
            lblOutput.Text = "Both numbers are equivalent"
        End If

        If A > B Then
            lblOutput.Text = "Value A is greater than B"
        End If

        If B > A Then
            lblOutput.Text = "Value B is greater than A"
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
