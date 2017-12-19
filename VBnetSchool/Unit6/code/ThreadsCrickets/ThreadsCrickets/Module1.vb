' This program prints "[threadOne] The crickets [threadTwo] laugh and play [threadTwo end] in the field [threadOne end]

Imports System.Collections.Queue

Module Module1

    Public threadOne As System.Threading.Thread = New Threading.Thread(AddressOf crickets)
    Public threadTwo As System.Threading.Thread = New Threading.Thread(AddressOf laughAndPlay)

    Sub crickets()
        Dim cricketWord As New Queue()
        'Add to queue
        cricketWord.Enqueue("The ")
        cricketWord.Enqueue("crickets ")
        cricketWord.Enqueue("in ")
        cricketWord.Enqueue("the ")
        cricketWord.Enqueue("field.")

        For Each item As String In cricketWord
            For i = 0 To 2
                Console.WriteLine(cricketWord)
            Next i
        Next item
    End Sub

    Sub laughAndPlay()
        Console.WriteLine("laugh and play")
    End Sub


    Sub Main() 

        threadOne.Start()
        Console.ReadKey()
    End Sub

End Module
