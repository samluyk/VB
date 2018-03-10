Public Class frmPay

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const FULL_TIME As Integer = 40     '
        Const MULTIPLIER As Decimal = 1.5D  '
        Dim otRate As Decimal               '
        Dim otPay As Decimal                '
        Dim otHours As Integer              '
        Dim numHours As Integer = 0         '
        Dim payRate As Decimal = 0D         '
        Dim grossPay As Decimal = 0D        '
        Dim bonusAmt As Decimal = 0D        '
        Dim strBonusAmt As String           '

        Try

            numHours = CInt(txtHours.Text)

            If numHours < 0 Then


                MessageBox.Show("The number of hours worked must be a positive number.",
                "User Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If


            Try
                payRate = CDec(txtRate.Text)

                If payRate < 0 Then

                    txtRate.Clear()
                    txtRate.Focus()

                    MessageBox.Show("The hourly rate must be positive.",
                    "User Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else



                    If numHours > FULL_TIME Then
                        'They earned OT Pay
                        'Calc OT pay rate
                        otRate = MULTIPLIER * payRate

                        '# of hours OT is earned for
                        otHours = numHours - FULL_TIME

                        'Calc OT amt
                        otPay = CDec(otHours) * otRate

                        'calc gross pay
                        grossPay = CDec(FULL_TIME) * payRate + otPay

                    Else


                        'Calc pay without OT
                        grossPay = CDec(numHours) * payRate
                    End If

                    'Check for a bonus
                    strBonusAmt = InputBox("Enter the bonus amount",
                                           "Bonus")
                    'Check for a valid bonus amount
                    If (Decimal.TryParse(strBonusAmt, bonusAmt)) Then


                        'Add in the gross pay amount
                        grossPay += bonusAmt
                    Else
                        'Not a currency value
                        MessageBox.Show("The bonus amount must be a currency value, or 0.",
                        "User Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                    'output our result
                    txtGross.Text = grossPay.ToString("c")
                    End If


            Catch ex As Exception

                txtRate.Clear()
                txtRate.Focus()
                MessageBox.Show("The pay rate must be a currency value.",
                "User Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)


            End Try


        Catch ex As Exception

            txtHours.Clear()
            txtHours.Focus()
            MessageBox.Show("The number of hours worked must be a whole number.",
                            "User Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
