Public Class frmMain

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblMessage.Text = "Cafe por favor!"
    End Sub

    Private Sub btnGerman_Click(sender As Object, e As EventArgs) Handles btnGerman.Click
        lblMessage.Text = "Kaffee bitte!"
    End Sub

    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click
        lblMessage.Text = "Un cafe s'il vous plait"
    End Sub

    Private Sub btnRomainian_Click(sender As Object, e As EventArgs) Handles btnRomainian.Click
        lblMessage.Text = "Cafea, va rog!"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
