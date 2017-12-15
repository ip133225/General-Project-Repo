Public Class StartMenu

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim rQuit As DialogResult
        rQuit = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If rQuit = Windows.Forms.DialogResult.No Then
            MessageBox.Show("I knew you couldn't leave me yet. :3")
        ElseIf rQuit = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub picMainMenu_Click(sender As Object, e As EventArgs) Handles picMainMenu.Click
        'test
    End Sub
End Class
