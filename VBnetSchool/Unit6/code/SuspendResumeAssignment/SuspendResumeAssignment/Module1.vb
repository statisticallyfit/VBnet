Module Module1
    'Declare threads
    Public odd As System.Threading.Thread = New Threading.Thread(AddressOf oddNums)
    Public even As System.Threading.Thread = New Threading.Thread(AddressOf evenNums)

    Sub oddNums()
        Dim i As Integer
        Dim list As ArrayList = New ArrayList()

        'Add to list
        For i = 1 To 20 Step 2
            list.Add(i)
        Next i

        'Print
        For Each item As Integer In list
            ' start printing evens and suspend the odds at the fifth item (number 9)
            If item = 11 Then ' last odd number printed here is 9 
                even.Start()
                'Suspend printing odd numbers
                If odd.ThreadState = Threading.ThreadState.Running Then
                    odd.Suspend()
                End If
            End If
            Console.WriteLine(item)
        Next item

    End Sub

    Sub evenNums()
        Dim i As Integer
        Dim list As ArrayList = New ArrayList()

        Console.WriteLine("Odd numbers suspended...")

        'Add to list
        For i = 0 To 10 Step 2
            list.Add(i)
        Next i

        'Print
        For Each item As Integer In list
            Console.WriteLine(item)
        Next item

        Console.WriteLine("Odd numbers resumed...")

        'Resume first thread of printing odd numbers
        If odd.ThreadState = Threading.ThreadState.Suspended Then
            odd.Resume()
        End If

    End Sub


    Sub Main()

        odd.Start()

        Console.ReadKey()

    End Sub

End Module
