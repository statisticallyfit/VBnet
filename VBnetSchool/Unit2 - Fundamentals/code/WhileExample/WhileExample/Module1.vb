Module Module1

    Sub Main()
        'Initialize the index
        Dim i As Integer = 0
        While i < 50
            'This is going to be iterated until 50, but 50 will not be printed because it will be checked against condition. 
            System.Console.WriteLine(i)
            i = i + 10
        End While

    End Sub

End Module
