Public Class Game_Form

    Public usedNums As New List(Of Integer)
    Public RandomGen As New Random
    Public CurrentNumber As Integer
    Public CardPile As New Stack(Of Card)

    Private Sub Game_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpGame()
        For x = 0 To CardPile.Count - 1
            Dim temp As Card
            temp = CardPile.Pop()
            ListBox1.Items.Add(temp.Type)
            temp = New Card
        Next
    End Sub

    Private Sub SetUpGame()
        Card.GenCards(CardPile, CurrentNumber, RandomGen, usedNums)
    End Sub

    Private Sub CmdQuit_Click(sender As Object, e As EventArgs) Handles CmdQuit.Click
        LogIn.QuitTheGame()
    End Sub
End Class