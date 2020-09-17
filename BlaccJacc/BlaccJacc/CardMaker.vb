Public Class Card
    Public Suit As String
    Public Number As Integer
    Public Type As String
    Public imagecode As String
    'generate 52 cards 

    Public Shared Function GenCards(CardPile) 'call to get a new pile of cards
        Dim usedNums As New List(Of Integer)
        Dim RandomGen As New Random
        Dim CurrentNumber As Integer
        For x = 1 To 51
            Dim CurrentCard As New Card
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
            CardPile.push(CurrentCard)
        Next
        Return CardPile
    End Function

    Private Shared Function CreateHearts(CurrentCard, CardPile, CurrentNumber, RandomGen, usedNums)
        CurrentCard.Suit = "H"
        If CurrentNumber >= 1 And CurrentNumber < 10 Then
            CurrentCard.Number = CurrentNumber + 1
            CurrentCard.Type = CurrentCard.Number.ToString()
            CurrentCard.imagecode = "_" + CurrentCard.Number.ToString() + "H"

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
        If CurrentNumber >= 14 And CurrentNumber < 23 Then
            CurrentCard.Number = CurrentNumber - 12
            CurrentCard.Type = CurrentCard.Number.ToString()
            CurrentCard.imagecode = "_" + CurrentCard.Number.ToString() + "D"

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
        If CurrentNumber >= 27 And CurrentNumber < 36 Then
            CurrentCard.Number = CurrentNumber - 25
            CurrentCard.Type = CurrentCard.Number.ToString()
            CurrentCard.imagecode = "_" + CurrentCard.Number.ToString() + "S"

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
        If CurrentNumber >= 40 And CurrentNumber < 49 Then
            CurrentCard.Number = CurrentNumber - 38
            CurrentCard.Type = CurrentCard.Number.ToString()
            CurrentCard.imagecode = "_" + CurrentCard.Number.ToString() + "C"

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

