Public Class Card
    Public Suit As String
    Public Number As Integer
    Public Type As String
    Public imagecode As String
    'generate 52 cards 

    Dim usedNums As List(Of Integer)
    Dim RandomGen As New Random
    Dim CurrentNumber As Integer

    Public Function GenCards()
        For x = 1 To 52
            CurrentNumber = RandomGen.Next(1, 52) 'generate a random number to turn into a card, this creates an already shuffled deck
            If usedNums.Contains(CurrentNumber) Then 'make sure the number hasnt been used already
                While usedNums.Contains(CurrentNumber) 'repeat untill a new number has been gotten
                    CurrentNumber = RandomGen.Next(1, 52) 'get a different random number
                End While
            End If
            usedNums.Add(CurrentNumber) 'add the random number to the list of used numbers
            Dim CurrentCard As Card
            If CurrentNumber >= 1 And CurrentNumber <= 13 Then 'uses an if to decide what suit the card will be based off the number
                CreateHearts(CurrentCard) 'call the function to generate hearts
            ElseIf CurrentNumber >= 14 And CurrentNumber <= 26 Then
                CreateDiamonds(CurrentCard) 'call the function to generate diamonds
            ElseIf CurrentNumber >= 27 And CurrentNumber <= 39 Then
                CreateSpades(CurrentCard) 'call the function to generate spades
            ElseIf CurrentNumber >= 40 And CurrentNumber <= 52 Then
                CreateClubs(CurrentCard) 'call the function to generate clubs
            End If
        Next
    End Function

    Private Function CreateHearts(CurrentCard)
        CurrentCard.Suit = "H"
        If CurrentNumber >= 1 And CurrentNumber < 10 Then
            If CurrentNumber = 1 Then
                CurrentCard.Number = 1
                CurrentCard.Type = "2"
                CurrentCard.imagecode = "_2H"
            ElseIf CurrentNumber = 2 Then
                CurrentCard.Number = 2
                CurrentCard.Type = "3"
                CurrentCard.imagecode = "_3H"
            ElseIf CurrentNumber = 3 Then
                CurrentCard.Number = 3
                CurrentCard.Type = "4"
                CurrentCard.imagecode = "_4H"
            ElseIf CurrentNumber = 4 Then
                CurrentCard.Number = 4
                CurrentCard.Type = "5"
                CurrentCard.imagecode = "_5H"
            ElseIf CurrentNumber = 5 Then
                CurrentCard.Number = 5
                CurrentCard.Type = "6"
                CurrentCard.imagecode = "_6H"
            ElseIf CurrentNumber = 6 Then
                CurrentCard.Number = 6
                CurrentCard.Type = "7"
                CurrentCard.imagecode = "_7H"
            ElseIf CurrentNumber = 7 Then
                CurrentCard.Number = 7
                CurrentCard.Type = "8"
                CurrentCard.imagecode = "_8H"
            ElseIf CurrentNumber = 8 Then
                CurrentCard.Number = 8
                CurrentCard.Type = "9"
                CurrentCard.imagecode = "_9H"
            ElseIf CurrentNumber = 9 Then
                CurrentCard.Number = 9
                CurrentCard.Type = "10"
                CurrentCard.imagecode = "_10H"
            End If

        ElseIf CurrentNumber = 10 Then
            CurrentCard.Number = 13
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
                CurrentCard.Number = 11
            ElseIf CurrentNumber = 13 Then
                CurrentCard.Type = "K"
                CurrentCard.imagecode = "_KH"
                CurrentCard.Number = 12
            End If
        End If
        Return CurrentCard
    End Function

    Private Function CreateDiamonds(CurrentCard)

    End Function

    Private Function CreateSpades(CurrentCard)

    End Function

    Private Function CreateClubs(CurrentCard)

    End Function
End Class

