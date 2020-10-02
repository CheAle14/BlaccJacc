Public Class Card
    Public Suit As House
    Public Number As Number
    Public ReadOnly Property Type As String
        Get
            Select Case Number
                Case Number.Ace
                    Return "A"
                Case Number.King
                    Return "K"
                Case Number.Queen
                    Return "Q"
                Case Number.Jack
                    Return "J"
                Case Else
                    Return Number.ToString()
            End Select
        End Get
    End Property
    Public ReadOnly Property imagecode As String
        Get
            Return "_" & Type & Suit.ToString()(0)
        End Get
    End Property

    Public Shared Function GenCards() As Stack(Of Card)
        Dim unshuffled = New List(Of Card)
        For Each suit As House In [Enum].GetValues(GetType(House))
            For Each value As Number In [Enum].GetValues(GetType(Number))
                Dim card As New Card()
                With card
                    .Suit = suit
                    .Number = value
                End With
                unshuffled.Add(card)
            Next
        Next
        Dim shuffled = New Stack(Of Card)
        Dim rnd = New Random()
        While unshuffled.Count > 0
            Dim index = rnd.Next(0, unshuffled.Count)
            shuffled.Push(unshuffled(index))
            unshuffled.RemoveAt(index)
        End While
        Return shuffled
    End Function
End Class
