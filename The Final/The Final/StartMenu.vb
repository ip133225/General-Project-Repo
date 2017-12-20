Public Class StartMenu


    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click

        btnStartPause.Text = btnStartPause.Text = "Start" And "Pause"
        If (btnStartPause.Text = "Start") Then

            MessageBox.Show("Pause code")

        Else

        End If

        MessageBox.Show("Start code")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim rQuit As DialogResult
        rQuit = MessageBox.Show("Are You Sure You Want To Quit?", "Game Quit", MessageBoxButtons.YesNo)
        If rQuit = Windows.Forms.DialogResult.No Then
            MessageBox.Show("I Knew You Couldn't Quit On Me Just Yet! :3")
        ElseIf rQuit = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub picMainMenu_Click(sender As Object, e As EventArgs) Handles picMainMenu.Click
        'test
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Application.Restart()
    End Sub

End Class