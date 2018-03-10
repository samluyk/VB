Public Class frmSum

    Private Sub btnNumbers_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        Dim count As Integer = 0
        Dim sum As Integer = 0

        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty

        Dim answer As Integer
        prompt = "Enter a positive integer value."
        title = "Getting user input"
        defaultResponse = ""

        answer = InputBox(prompt, title, defaultResponse)

        If answer < 1 Then
            MessageBox.Show("That isn't positive, man.",
        "Data Entry Error",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error)
        End If



        For counter As Integer = 1 To answer
            count = counter + 1
            sum = sum + counter

        Next

        MessageBox.Show(sum,
        "The sum of 1 to the number you entered, is:",
        MessageBoxButtons.OK,
         MessageBoxIcon.Exclamation)





    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
