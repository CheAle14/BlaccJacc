Public Class Game_Form
    Private Sub Game_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdQuit_Click(sender As Object, e As EventArgs) Handles CmdQuit.Click
        LogIn.QuitTheGame()
    End Sub
End Class