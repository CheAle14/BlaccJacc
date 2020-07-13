Imports System.IO
Public Class MainMenu
    Public UserDetails As New Dictionary(Of String, Integer)
    Public CurrentUser As String = Environment.UserName

    Public Property Score As Integer
        Get
            Dim ScoreIn = 0
            UserDetails.TryGetValue(CurrentUser, ScoreIn)
            Return ScoreIn
        End Get
        Set(value As Integer)
            UserDetails(CurrentUser) = value
        End Set
    End Property

    Public Sub LoadFromFile()
        Dim contents As String()
        Try
            contents = System.IO.File.ReadAllLines("scores.txt")
        Catch ex As FileNotFoundException
            contents = {$"{Environment.UserName}:0"}
        End Try
        For Each line As String In contents
            line = line.TrimEnd()
            Dim split = line.Split(":")
            UserDetails(split(0)) = Integer.Parse(split(1))
        Next
    End Sub


    Public Sub SaveToFile() 'use "MainMenu.score =" to update score and then call save before exiting
        Dim contents = ""
        For Each keypair In UserDetails
            contents += $"{keypair.Key}:{keypair.Value}{Environment.NewLine}"
        Next
        System.IO.File.WriteAllText("scores.txt", contents)
    End Sub
End Class