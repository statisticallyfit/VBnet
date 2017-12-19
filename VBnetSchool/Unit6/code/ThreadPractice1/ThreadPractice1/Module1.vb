Imports System.Threading.Thread

Module Module1

    Sub threadOne()
        Dim i As Integer
        For i = 0 To 5
            Console.WriteLine("A")
        Next i
    End Sub

    Sub threadTwo()
        Dim i As Integer
        For i = 0 To 5
            Console.WriteLine("B")
        Next
    End Sub

    Sub Main()
        'Declare and start the thread 
        Dim a As System.Threading.Thread = New Threading.Thread(AddressOf threadOne)
        Dim b As System.Threading.Thread = New Threading.Thread(AddressOf threadTwo)

        a.Start()
        b.Start()

        Console.ReadLine()

    End Sub

End Module
