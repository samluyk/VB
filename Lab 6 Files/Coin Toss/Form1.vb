﻿Public Class frmFlip

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim rand As New Random

        intSideUp = rand.Next(2)

        If intSideUp = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
        Else
            picHeads.Visible = True
            picTails.Visible = False

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
