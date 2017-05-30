Module Module1

    Sub Main()
        Dim input As String
        Console.WriteLine("If you are happy, input 1, if not, input 2 and press enter key")
        input = Console.ReadLine()
        If input = "1" Then
            Console.WriteLine("Happy World!")
        ElseIf input = "2" Then
            Console.WriteLine("Go Away!")
        End If
        'Console.ReadKey()
    End Sub

End Module
