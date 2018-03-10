Public Class frmMain


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'closes application on click
        Application.Exit()

    End Sub


    Private Sub lblShootTime_Click(sender As Object, e As EventArgs) Handles lblDuration.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strCSVData As String

        strCSVData = txtName.Text & "," & cbxSex.SelectedValue

        MsgBox(strCSVData)
    End Sub
End Class