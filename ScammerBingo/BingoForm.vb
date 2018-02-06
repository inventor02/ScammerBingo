Public Class BingoForm
    Dim score As Integer

    Private Sub HandleBingoButtonClick(sender As Button, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click
        Console.WriteLine("Button clicked: " & sender.Text)

        sender.Enabled = False
        score = score + 1

        SetScore(score)
    End Sub

    Private Sub BingoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        score = 0
    End Sub

    Sub SetScore(ByRef newScore As Integer)
        Dim scoreText As String = newScore.ToString()

        If scoreText.Length < 2 Then
            scoreText = "0" & scoreText
        End If

        ScoreLabel.Text = scoreText & "/20"
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        For Each control As Control In Me.Controls
            If control Is BoardGroupBox Then
                For Each gControl As Control In control.Controls
                    If TypeOf gControl Is Button Then
                        gControl.Enabled = True
                    End If
                Next
            End If
        Next

        score = 0
        SetScore(score)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
