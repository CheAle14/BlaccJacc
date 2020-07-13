Public Class LogIn
    Private Sub CMDQuit_Click(sender As Object, e As EventArgs) Handles CMDQuit.Click
        QuitTheGame()
    End Sub

    Private Sub QuitTheGame()
        'make a confirmation form to fit the design instead of a vbYEsNo box
        MainMenu.SaveToFile()
        'if confirmation yes
        End
        'else return to game
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.LoadFromFile()
        For Each keypair In MainMenu.UserDetails
            LBLUserList.Items.Add(keypair.Key)
        Next
        If Not MainMenu.UserDetails.ContainsKey(Environment.UserName) Then
            LBLUserList.Items.Add(Environment.UserName)
        End If
    End Sub

    Private Sub LBLUserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBLUserList.SelectedIndexChanged
        If LBLUserList.SelectedIndex >= 0 Then
            Dim item = LBLUserList.Items(LBLUserList.SelectedIndex)
            MainMenu.CurrentUser = item
            Me.Hide()
            MainMenu.Show()
        End If
    End Sub

    Private Sub CMDNewUser_Click(sender As Object, e As EventArgs) Handles CMDNewUser.Click
        Dim input = InputBox("Enter new username (dont use spaces or :)", "New Username", Environment.UserName)
        If Not String.IsNullOrWhiteSpace(input) Then
            If input.Contains(" ") OrElse input.Contains(":") Then
                MsgBox("Invalid name")
                Return
            End If
            LBLUserList.Items.Add(input)
            MainMenu.CurrentUser = input
            MainMenu.UserDetails(input) = 100
            MainMenu.SaveToFile()
        End If
    End Sub
End Class
