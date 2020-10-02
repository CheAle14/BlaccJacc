Public Class Game_Form
    Public CardPile As New Stack(Of Card)

    Dim WinnerFound As Boolean = False
    Dim userBetAmount As Integer
    Dim UserCards As New List(Of Card)
    Dim Player1Cards As New List(Of Card)
    Dim Player2Cards As New List(Of Card)
    Dim DealerCards As New List(Of Card)
    Dim setupType As String
    Dim UserHand As New List(Of PictureBox)
    Dim Player1Hand As New List(Of PictureBox)
    Dim Player2Hand As New List(Of PictureBox)
    Dim DealerHand As New List(Of PictureBox)

    Private Sub Game_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Card.GenCards(CardPile)
        setupType = "initial"
        SetUpGame()
    End Sub

    Private Sub SetUpGame()
        If setupType = "initial" Then
            PayInNum.Show()
            PayInNum.Text = "You are currently betting " & PayIn.Value & " bills"
            PayIn.Maximum = MainMenu.Score
            PayIn.TickFrequency = PayIn.Maximum / 22
            setupType = "secondary"

        ElseIf setupType = "secondary" Then
            UserHand.Add(UserCard1)
            UserHand.Add(UserCard2)
            UserHand.Add(UserCard3)
            UserHand.Add(UserCard4)
            UserHand.Add(UserCard5)

            Player1Hand.Add(Player1Card1)
            Player1Hand.Add(Player1Card2)
            Player1Hand.Add(Player1Card3)
            Player1Hand.Add(Player1Card4)
            Player1Hand.Add(Player1Card5)

            Player2Hand.Add(Player2Card1)
            Player2Hand.Add(Player2Card2)
            Player2Hand.Add(Player2Card3)
            Player2Hand.Add(Player2Card4)
            Player2Hand.Add(Player2Card5)

            DealerHand.Add(DealerCard1)
            DealerHand.Add(DealerCard2)
            DealerHand.Add(DealerCard3)
            DealerHand.Add(DealerCard4)
            DealerHand.Add(DealerCard5)

            PayIn.Hide()
            PayInNum.Hide()
            PlaceBet.Hide()
            BtnHit.Show()
            BtnStand.Show()
            For x = 0 To 1 'this wil give all the players their first 2 cards
                UserCards.Add(CardPile.Pop)
                UserHand(x).Image = My.Resources.ResourceManager.GetObject(UserCards(x).imagecode)
                UserHand(x).Show()
                Player1Cards.Add(CardPile.Pop)
                Player1Hand(x).Show()
                Player2Cards.Add(CardPile.Pop)
                Player2Hand(x).Show()
                DealerCards.Add(CardPile.Pop)
                DealerHand(x).Show()
            Next

        ElseIf setupType = "reset" Then
            For x = 0 To UserCards.Count - 1
                UserHand(x).Hide()
            Next
            For x = 0 To Player1Cards.Count - 1
                Player1Hand(x).Hide()
            Next
            For x = 0 To DealerCards.Count - 1
                DealerHand(x).Hide()
            Next
            For x = 0 To Player2Cards.Count - 1
                Player2Hand(x).Hide()
            Next
            PileOfCards.Hide()
            BtnHit.Hide()
            BtnStand.Hide()

            UserCards.Clear()
            Player1Cards.Clear()
            Player2Cards.Clear()
            DealerCards.Clear()
            UserHand.Clear()
            Player1Hand.Clear()
            Player2Hand.Clear()
            DealerHand.Clear()
            AllPlayersDone = False
            UserDecision = ""
            UserDone = False
            Player1Done = False
            Player2Done = False
            DealerDone = False
            playerTurn = 1
            Player1Bust = False
            Player2Bust = False
            DealerBust = False
            UserScore = 0
            Player1Score = 0
            Player2Score = 0
            DealerScore = 0
            UserAcePlays = 0
            Player1Aces = 0
            Player2Aces = 0
            DealerAces = 0
            WinningList.Clear()

            PayIn.Show()
            PlaceBet.Show()

            setupType = "initial"
            SetUpGame()
        End If
    End Sub

    Dim AllPlayersDone As Boolean = False
    Dim UserDecision As String
    Dim UserDone As Boolean = False
    Dim Player1Done As Boolean = False
    Dim Player2Done As Boolean = False
    Dim DealerDone As Boolean = False
    Dim playerTurn As Integer = 1
    Dim Player1Bust As Boolean = False
    Dim Player2Bust As Boolean = False
    Dim DealerBust As Boolean = False
    Dim UserScore As Integer
    Dim Player1Score As Integer
    Dim Player2Score As Integer
    Dim DealerScore As Integer
    Dim UserAcePlays As Integer = 0
    Dim Player1Aces As Integer = 0
    Dim Player2Aces As Integer = 0
    Dim DealerAces As Integer = 0

    Private Sub NextMove()
        BtnStand.Hide()
        BtnHit.Hide()
        If CardPile.Count = 0 Then
            Card.GenCards(CardPile)
        End If
        If UserDone = True And Player1Done = True And Player2Done = True And DealerDone = True Then
            AllPlayersDone = True
        End If
        If AllPlayersDone = False Then
            If playerTurn = 1 Then
                If UserDone = False Then
                    If UserDecision = "Hit" Then
                        If CardPile.Peek.Type = "A" Then
                            UserAcePlays += 1
                        End If
                        UserCards.Add(CardPile.Pop())
                        UserScore = 0
                        For x = 0 To UserCards.Count - 1
                            UserScore += UserCards(x).Number
                            UserHand(x).Image = My.Resources.ResourceManager.GetObject(UserCards(x).imagecode)
                            UserHand(x).Show()
                        Next
                        If UserScore > 21 Then
                            If UserAcePlays > 0 Then
                                For a = 0 To UserAcePlays - 1
                                    UserScore -= 9
                                Next
                                If UserScore > 21 Then
                                    UserDecision = “Bust”
                                    UserDone = True
                                End If
                            Else
                                UserDecision = “Bust”
                                UserDone = True
                                FindWinner()
                            End If
                        ElseIf UserCards.Count = 5 Then
                            FindWinner()
                        Else
                            playerTurn += 1
                            UserDecision = ""
                            NextMove()
                        End If
                    ElseIf UserDecision = "Stand" Then
                        UserDone = True
                        If Player1Done = True And Player2Done = True And DealerDone = True Then
                            FindWinner()
                        Else
                            playerTurn += 1
                            NextMove()
                        End If
                    End If
                Else
                    If Player1Done = True And Player2Done = True And DealerDone = True Then
                        FindWinner()
                    Else
                        playerTurn += 1
                        NextMove()
                    End If
                End If

            ElseIf playerTurn = 2 Then
                If Player1Done = False Then
                    Player1Score = 0
                    For b = 0 To Player1Cards.Count - 1
                        Player1Score += Player1Cards(b).Number
                    Next
                    If Player1Score > 17 And Player1Score < 21 Then
                        Player1Done = True
                        playerTurn += 1
                        NextMove()
                    Else
                        If CardPile.Peek.Type = "A" Then
                            Player1Aces += 1
                        End If
                        Player1Cards.Add(CardPile.Pop())
                        Player1Score = 0
                        For x = 0 To Player1Cards.Count - 1
                            Player1Score += Player1Cards(x).Number
                            Player1Hand(x).Image = My.Resources.ResourceManager.GetObject("Card_back")
                            Player1Hand(x).Show()
                        Next

                        If Player1Score > 21 Then
                            For c = 0 To Player1Aces - 1
                                Player1Score -= 9
                            Next
                            Player1Done = True
                            Player1Bust = True
                            playerTurn += 1
                            NextMove()
                        ElseIf Player1Cards.Count = 5 Then
                            UserDecision = “Bust” 'the user cannot win so no point trying to find the winner
                            FindWinner()
                        Else
                            playerTurn += 1
                            NextMove()
                        End If
                    End If
                Else
                    playerTurn += 1
                    NextMove()
                End If

            ElseIf playerTurn = 3 Then
                If Player2Done = False Then
                    Player2Score = 0
                    For d = 0 To Player2Cards.Count - 1
                        Player2Score += Player2Cards(d).Number
                    Next
                    If Player2Score > 17 And Player2Score < 21 Then
                        Player2Done = True
                        playerTurn += 1
                        NextMove()
                    Else
                        If CardPile.Peek.Type = "A" Then
                            Player2Aces += 1
                        End If
                        Player2Cards.Add(CardPile.Pop())
                        Player2Score = 0
                        For x = 0 To Player2Cards.Count - 1
                            Player2Score += Player2Cards(x).Number
                            Player2Hand(x).Image = My.Resources.ResourceManager.GetObject("Card_back")
                            Player2Hand(x).Show()
                        Next

                        If Player2Score > 21 Then
                            For c = 0 To Player2Aces - 1
                                Player2Score -= 9
                            Next
                            Player2Done = True
                            Player2Bust = True
                            playerTurn += 1
                            NextMove()
                        ElseIf Player2Cards.Count = 5 Then
                            UserDecision = “Bust” 'the user cannot win so no point trying to find the winner
                            FindWinner()
                        Else
                            playerTurn += 1
                            NextMove()
                        End If
                    End If
                Else
                    playerTurn += 1
                    NextMove()
                End If

            ElseIf playerTurn = 4 Then 'do not recall nextove on user 4 as player must press a button
                If DealerDone = False Then
                    DealerScore = 0
                    For e = 0 To DealerCards.Count - 1
                        DealerScore += DealerCards(e).Number
                    Next
                    If DealerScore > 17 And DealerScore < 21 Then
                        DealerDone = True
                        playerTurn = 1
                    Else
                        If CardPile.Peek.Type = "A" Then
                            DealerAces += 1
                        End If
                        DealerCards.Add(CardPile.Pop())
                        DealerScore = 0
                        For x = 0 To DealerCards.Count - 1
                            DealerScore += DealerCards(x).Number
                            DealerHand(x).Image = My.Resources.ResourceManager.GetObject("Card_back")
                            DealerHand(x).Show()
                        Next
                        If DealerScore > 21 Then
                            For f = 0 To DealerAces - 1
                                DealerScore -= 9
                            Next
                            DealerDone = True
                            DealerBust = True
                            playerTurn = 1
                        ElseIf DealerCards.Count = 5 Then
                            UserDecision = “Bust”
                            FindWinner()
                        Else
                            playerTurn = 1
                        End If
                    End If
                Else
                    playerTurn = 1
                    If UserDone = True Then
                        NextMove()
                    End If
                End If

                If UserDone = False Then
                    BtnHit.Show()
                    BtnStand.Show()
                End If
            End If

        Else
            FindWinner()
        End If
    End Sub

    Dim UserWinner As Boolean
    Dim WinningList As New List(Of Integer)

    Private Sub FindWinner()
        Player1Score = 0
        UserScore = 0
        DealerScore = 0
        Player2Score = 0
        If UserDecision = “Bust” Then
            UserWinner = False
        Else
            For x = 0 To 4
                If Player1Bust = False Then
                    Try
                        Player1Score = Player1Cards(x).Number + Player1Cards(x + 1).Number
                    Catch
                    End Try
            If Player1Score > 21 Then
                        If Player1Aces > 0 Then
                            Player1Score = -9
                            Player1Aces = -1
                        End If
                    End If
                End If
                If Player2Bust = False Then
                    Try
                        Player2Score = Player2Cards(x).Number + Player2Cards(x + 1).Number
                    Catch
                    End Try
                    If Player2Score > 21 Then
                        If Player2Aces > 0 Then
                            Player2Score = -9
                            Player2Aces = -1
                        End If
                    End If
                End If
                Try
                    UserScore = UserCards(x).Number + UserCards(x + 1).Number
                Catch
                End Try
                If UserScore > 21 Then
                    If UserAcePlays > 0 Then
                        UserScore = -9
                        UserAcePlays = -1
                    End If
                End If
                If DealerBust = False Then
                    Try
                        DealerScore = DealerCards(x).Number + DealerCards(x + 1).Number
                    Catch
                    End Try
                    If DealerScore > 21 Then
                        If DealerAces > 0 Then
                            DealerScore = -9
                            DealerAces = -1
                        End If
                    End If
                End If
            Next
            Player1Score = 21 - Player1Score
            Player2Score = 21 - Player2Score
            UserScore = 21 - UserScore
            DealerScore = 21 - DealerScore
            WinningList.Add(Player1Score)
            WinningList.Add(Player2Score)
            WinningList.Add(UserScore)
            WinningList.Add(DealerScore)
            If UserScore < Player1Score And UserScore < Player2Score And UserScore < DealerScore Then 'it only matters if the user wins or loses 
                UserWinner = True
            ElseIf UserScore = WinningList.Min() Then
                UserScore = UserHand.Count
                If Player1Score = WinningList.Min() Then
                    Player1Score = Player1Cards.Count
                Else
                    Player1Score = 10
                End If

                If Player2Score = WinningList.Min() Then
                    Player2Score = Player2Cards.Count
                Else
                    Player2Score = 10
                End If

                If DealerScore = WinningList.Min() Then
                    UserWinner = False
                Else
                    DealerScore = 10
                End If

                If UserScore < Player1Score And UserScore < Player2Score And UserScore < DealerScore Then
                    UserWinner = True
                Else
                    UserWinner = False
                End If
            Else
                UserWinner = False
            End If
        End If

        Dim PlayAgain As Integer

        If UserWinner = True Then
            userBetAmount = userBetAmount * 2
            MainMenu.Score += +userBetAmount
            PlayAgain = MsgBox("You have won! wanna play again?", vbQuestion + vbYesNo + vbDefaultButton2, "WINNER!")
            If PlayAgain = vbYes Then
                setupType = "reset"
                SetUpGame()
            ElseIf PlayAgain = vbNo Then
                LogIn.QuitTheGame()
            End If
        ElseIf UserWinner = False Then
            userBetAmount = 0
            If MainMenu.Score = 0 Then
                MainMenu.Score = 10
            End If
            PlayAgain = MsgBox("You have lost. wanna play again?", vbQuestion + vbYesNo + vbDefaultButton2, "loser")
            If PlayAgain = vbYes Then
                setupType = "reset"
                SetUpGame()
            ElseIf PlayAgain = vbNo Then
                LogIn.QuitTheGame()
            End If
        End If
    End Sub

    Private Sub BtnHit_Click(sender As Object, e As EventArgs) Handles BtnHit.Click
        UserDecision = "Hit"
        NextMove()
    End Sub

    Private Sub BtnStand_Click(sender As Object, e As EventArgs) Handles BtnStand.Click
        UserDecision = "Stand"
        NextMove()
    End Sub

    Private Sub CmdQuit_Click(sender As Object, e As EventArgs) Handles CmdQuit.Click
        LogIn.QuitTheGame()
    End Sub

    Private Sub PayIn_Scroll(sender As Object, e As EventArgs) Handles PayIn.Scroll
        PayInNum.Text = "You are currently betting " & PayIn.Value & " bills"
    End Sub

    Private Sub PlaceBet_Click(sender As Object, e As EventArgs) Handles PlaceBet.Click
        userBetAmount = PayIn.Value
        MainMenu.Score -= userBetAmount
        SetUpGame()
    End Sub

End Class