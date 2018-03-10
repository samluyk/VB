Public Class frmRevenue

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassA2.Clear()
        txtClassB.Clear()
        txtClassB2.Clear()
        txtClassC.Clear()
        txtClassC2.Clear()
        txtTotalRevenue.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer

        Dim rev1 As Integer
        Dim rev2 As Integer
        Dim rev3 As Integer

        Dim ans As Integer

        Try
            num1 = CDbl(txtClassA.Text)
            Try
                num2 = CDbl(txtClassB.Text)
                Try
                    num3 = CDbl(txtClassC.Text)
                    rev3 = num3 * 9
                    txtClassC2.Text = rev3


                Catch ex As Exception
                    MessageBox.Show(txtClassC.Text + " - Isn't a numeric value.",
                    "Data Entry Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
                    txtClassC.Clear() 'this erases the invalid input
                    txtClassC.Focus() 'this moves them to where they need to be

                    
                   

                End Try
                rev2 = num2 * 12
                txtClassB2.Text = rev2
            Catch ex As Exception
                MessageBox.Show(txtClassA.Text + " - Isn't a numeric value.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                txtClassB.Clear() 'this erases the invalid input
                txtClassB.Focus() 'this moves them to where they need to be
            End Try
            rev1 = num1 * 15
            txtClassA2.Text = rev1
        Catch ex As Exception
            MessageBox.Show(txtClassA.Text + " - Isn't a numeric value.",
            "Data Entry Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            txtClassA.Clear() 'this erases the invalid input
            txtClassA.Focus() 'this moves them to where they need to be
        End Try
        ans = rev1 + rev2 + rev3
        txtTotalRevenue.Text = CStr(ans)
    End Sub
End Class

