Public Class Card
    Public Suit As String
    Public Number As Integer
    Public Type As String
    Public imagecode As String
    'generate 52 cards 

    Shared CurrentCard As New Card

    Public Shared Function GenCards(CardPile, CurrentNumber, RandomGen, usedNums) 'call to get a new pile of cards
        For x = 1 To 51
            CurrentNumber = RandomGen.Next(1, 52) 'generate a random number to turn into a card, this creates an already shuffled deck
            If usedNums.Contains(CurrentNumber) Then 'make sure the number hasnt been used already
                While usedNums.Contains(CurrentNumber) 'repeat untill a new number has been gotten
                    CurrentNumber = RandomGen.Next(1, 52) 'get a different random number
                End While
            End If
            usedNums.Add(CurrentNumber) 'add the random number to the list of used numbers

            If CurrentNumber >= 1 And CurrentNumber <= 13 Then 'uses an if to decide what suit the card will be based off the number
                CreateHearts(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums) 'call the function to generate hearts
            ElseIf CurrentNumber >= 14 And CurrentNumber <= 26 Then
                CreateDiamonds(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums) 'call the function to generate diamonds
            ElseIf CurrentNumber >= 27 And CurrentNumber <= 39 Then
                CreateSpades(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums) 'call the function to generate spades
            ElseIf CurrentNumber >= 40 And CurrentNumber <= 52 Then
                CreateClubs(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums) 'call the function to generate clubs
            End If
            CardPile.Push(CurrentCard) 'adds the new card to the pile of cards
        Next
        Return CardPile
    End Function

    Private Shared Function CreateHearts(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums)
        CurrentCard.Suit = "H"
        If CurrentNumber >= 1 And CurrentNumber < 10 Then
            If CurrentNumber = 1 Then
                CurrentCard.Number = 2
                CurrentCard.Type = "2"
                CurrentCard.imagecode = "_2H"
            ElseIf CurrentNumber = 2 Then
                CurrentCard.Number = 3
                CurrentCard.Type = "3"
                CurrentCard.imagecode = "_3H"
            ElseIf CurrentNumber = 3 Then
                CurrentCard.Number = 4
                CurrentCard.Type = "4"
                CurrentCard.imagecode = "_4H"
            ElseIf CurrentNumber = 4 Then
                CurrentCard.Number = 5
                CurrentCard.Type = "5"
                CurrentCard.imagecode = "_5H"
            ElseIf CurrentNumber = 5 Then
                CurrentCard.Number = 6
                CurrentCard.Type = "6"
                CurrentCard.imagecode = "_6H"
            ElseIf CurrentNumber = 6 Then
                CurrentCard.Number = 7
                CurrentCard.Type = "7"
                CurrentCard.imagecode = "_7H"
            ElseIf CurrentNumber = 7 Then
                CurrentCard.Number = 8
                CurrentCard.Type = "8"
                CurrentCard.imagecode = "_8H"
            ElseIf CurrentNumber = 8 Then
                CurrentCard.Number = 9
                CurrentCard.Type = "9"
                CurrentCard.imagecode = "_9H"
            ElseIf CurrentNumber = 9 Then
                CurrentCard.Number = 10
                CurrentCard.Type = "10"
                CurrentCard.imagecode = "_10H"
            End If

        ElseIf CurrentNumber = 10 Then
            CurrentCard.Number = 10 'set to 10 so later it can be changed to either 10 or 1 based of the users decision
            CurrentCard.Type = "A"
            CurrentCard.imagecode = "_AH"

        ElseIf CurrentNumber > 10 And CurrentNumber <= 13 Then
            If CurrentNumber = 11 Then
                CurrentCard.Type = "J"
                CurrentCard.imagecode = "_JH"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 12 Then
                CurrentCard.Type = "Q"
                CurrentCard.imagecode = "_QH"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 13 Then
                CurrentCard.Type = "K"
                CurrentCard.imagecode = "_KH"
                CurrentCard.Number = 10
            End If
        End If
        Return CurrentCard
    End Function

    Private Shared Function CreateDiamonds(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums)
        CurrentCard.Suit = "D"
        If CurrentNumber >= 14 And CurrentNumber <= 22 Then
            If CurrentNumber = 14 Then
                CurrentCard.Number = 2
                CurrentCard.Type = "2"
                CurrentCard.imagecode = "_2D"
            ElseIf CurrentNumber = 15 Then
                CurrentCard.Number = 3
                CurrentCard.Type = "3"
                CurrentCard.imagecode = "_3D"
            ElseIf CurrentNumber = 16 Then
                CurrentCard.Number = 4
                CurrentCard.Type = "4"
                CurrentCard.imagecode = "_4D"
            ElseIf CurrentNumber = 17 Then
                CurrentCard.Number = 5
                CurrentCard.Type = "5"
                CurrentCard.imagecode = "_5D"
            ElseIf CurrentNumber = 18 Then
                CurrentCard.Number = 6
                CurrentCard.Type = "6"
                CurrentCard.imagecode = "_6D"
            ElseIf CurrentNumber = 19 Then
                CurrentCard.Number = 7
                CurrentCard.Type = "7"
                CurrentCard.imagecode = "_7D"
            ElseIf CurrentNumber = 20 Then
                CurrentCard.Number = 8
                CurrentCard.Type = "8"
                CurrentCard.imagecode = "_8D"
            ElseIf CurrentNumber = 21 Then
                CurrentCard.Number = 9
                CurrentCard.Type = "9"
                CurrentCard.imagecode = "_9D"
            ElseIf CurrentNumber = 22 Then
                CurrentCard.Number = 10
                CurrentCard.Type = "10"
                CurrentCard.imagecode = "_10D"
            End If

        ElseIf CurrentNumber = 23 Then
            CurrentCard.Number = 10 'set to 10 so later it can be changed to either 10 or 1 based of the users decision
            CurrentCard.Type = "A"
            CurrentCard.imagecode = "_AD"

        ElseIf CurrentNumber >= 24 And CurrentNumber <= 26 Then
            If CurrentNumber = 24 Then
                CurrentCard.Type = "J"
                CurrentCard.imagecode = "_JD"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 25 Then
                CurrentCard.Type = "Q"
                CurrentCard.imagecode = "_QD"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 26 Then
                CurrentCard.Type = "K"
                CurrentCard.imagecode = "_KD"
                CurrentCard.Number = 10
            End If
        End If
        Return CurrentCard
    End Function

    Private Shared Function CreateSpades(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums)
        CurrentCard.Suit = "S"
        If CurrentNumber >= 27 And CurrentNumber <= 35 Then
            If CurrentNumber = 27 Then
                CurrentCard.Number = 2
                CurrentCard.Type = "2"
                CurrentCard.imagecode = "_2S"
            ElseIf CurrentNumber = 28 Then
                CurrentCard.Number = 3
                CurrentCard.Type = "3"
                CurrentCard.imagecode = "_3S"
            ElseIf CurrentNumber = 29 Then
                CurrentCard.Number = 4
                CurrentCard.Type = "4"
                CurrentCard.imagecode = "_4S"
            ElseIf CurrentNumber = 30 Then
                CurrentCard.Number = 5
                CurrentCard.Type = "5"
                CurrentCard.imagecode = "_5S"
            ElseIf CurrentNumber = 31 Then
                CurrentCard.Number = 6
                CurrentCard.Type = "6"
                CurrentCard.imagecode = "_6S"
            ElseIf CurrentNumber = 32 Then
                CurrentCard.Number = 7
                CurrentCard.Type = "7"
                CurrentCard.imagecode = "_7S"
            ElseIf CurrentNumber = 33 Then
                CurrentCard.Number = 8
                CurrentCard.Type = "8"
                CurrentCard.imagecode = "_8S"
            ElseIf CurrentNumber = 34 Then
                CurrentCard.Number = 9
                CurrentCard.Type = "9"
                CurrentCard.imagecode = "_9S"
            ElseIf CurrentNumber = 35 Then
                CurrentCard.Number = 10
                CurrentCard.Type = "10"
                CurrentCard.imagecode = "_10S"
            End If

        ElseIf CurrentNumber = 36 Then
            CurrentCard.Number = 10 'set to 10 so later it can be changed to either 10 or 1 based of the users decision
            CurrentCard.Type = "A"
            CurrentCard.imagecode = "_AS"

        ElseIf CurrentNumber >= 37 And CurrentNumber <= 39 Then
            If CurrentNumber = 37 Then
                CurrentCard.Type = "J"
                CurrentCard.imagecode = "_JS"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 38 Then
                CurrentCard.Type = "Q"
                CurrentCard.imagecode = "_QS"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 39 Then
                CurrentCard.Type = "K"
                CurrentCard.imagecode = "_KS"
                CurrentCard.Number = 10
            End If
        End If
        Return CurrentCard
    End Function

    Private Shared Function CreateClubs(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums)
        CurrentCard.Suit = "C"
        If CurrentNumber >= 40 And CurrentNumber <= 48 Then
            If CurrentNumber = 40 Then
                CurrentCard.Number = 2
                CurrentCard.Type = "2"
                CurrentCard.imagecode = "_2C"
            ElseIf CurrentNumber = 41 Then
                CurrentCard.Number = 3
                CurrentCard.Type = "3"
                CurrentCard.imagecode = "_3C"
            ElseIf CurrentNumber = 42 Then
                CurrentCard.Number = 4
                CurrentCard.Type = "4"
                CurrentCard.imagecode = "_4C"
            ElseIf CurrentNumber = 43 Then
                CurrentCard.Number = 5
                CurrentCard.Type = "5"
                CurrentCard.imagecode = "_5C"
            ElseIf CurrentNumber = 44 Then
                CurrentCard.Number = 6
                CurrentCard.Type = "6"
                CurrentCard.imagecode = "_6C"
            ElseIf CurrentNumber = 45 Then
                CurrentCard.Number = 7
                CurrentCard.Type = "7"
                CurrentCard.imagecode = "_7C"
            ElseIf CurrentNumber = 46 Then
                CurrentCard.Number = 8
                CurrentCard.Type = "8"
                CurrentCard.imagecode = "_8C"
            ElseIf CurrentNumber = 47 Then
                CurrentCard.Number = 9
                CurrentCard.Type = "9"
                CurrentCard.imagecode = "_9C"
            ElseIf CurrentNumber = 48 Then
                CurrentCard.Number = 10
                CurrentCard.Type = "10"
                CurrentCard.imagecode = "_10C"
            End If

        ElseIf CurrentNumber = 49 Then
            CurrentCard.Number = 10 'set to 10 so later it can be changed to either 10 or 1 based of the users decision
            CurrentCard.Type = "A"
            CurrentCard.imagecode = "_AC"

        ElseIf CurrentNumber >= 50 And CurrentNumber <= 52 Then
            If CurrentNumber = 50 Then
                CurrentCard.Type = "J"
                CurrentCard.imagecode = "_JC"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 51 Then
                CurrentCard.Type = "Q"
                CurrentCard.imagecode = "_QC"
                CurrentCard.Number = 10
            ElseIf CurrentNumber = 52 Then
                CurrentCard.Type = "K"
                CurrentCard.imagecode = "_KC"
                CurrentCard.Number = 10
            End If
        End If
        Return CurrentCard
    End Function
End Class

