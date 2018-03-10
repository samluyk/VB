Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const decYEARLY_FEE As Decimal = 5000D
        Const decONE_TIME_FEE As Decimal = 20000D
        Const decSUPPORT As Decimal = 3500D
        Const decTRAINING As Decimal = 2000D
        Const decBACKUP As Decimal = 300D
        Dim TotalLicensing As Decimal = 0D
        Dim TotalExtras As Decimal = 0D

        If rdoYearly.Checked Then
            TotalLicensing = TotalLicensing + decYEARLY_FEE
        Else
            TotalLicensing = TotalLicensing + decONE_TIME_FEE

        End If

        If chkSupport.Checked Then
            TotalExtras = TotalExtras + decSUPPORT
        End If

        If chkTraining.Checked Then
            TotalExtras = TotalExtras + decTRAINING
        End If

        If chkBackup.Checked Then
            TotalExtras = TotalExtras + decBACKUP
        End If

        txtLicensing.Text = TotalLicensing
        txtAdditional.Text = TotalExtras

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLicensing.Clear()
        txtAdditional.Clear()
        chkSupport.Checked = False
        chkTraining.Checked = False
        chkBackup.Checked = False

        'lblMonthlyFee.Text = String.Empty
        'lblStatus.Text = String.Empty
        'lblTotalFee.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
