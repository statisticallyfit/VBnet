Module Module1

    Public Event print(ByVal value As Integer)

    'Raising event sub
    Sub raiseEvt(ByVal x As Integer)
        RaiseEvent print(x)
    End Sub

    'Even numbers function
    Function evenNum(ByVal x As Integer)
        'Dim list As ArrayList = New ArrayList()
        Dim i As Integer
        Dim bflag As Boolean

        Console.WriteLine("Printing prime numbers...")

        For i = 0 To x
            bflag = True
            For j = 2 To i / 2
                If i Mod j = 0 Then
                    bflag = False
                    Exit For
                End If
            Next j
            If bflag = True Then
                Console.WriteLine(i)
            End If
        Next i
        
        Return i

    End Function

    Sub Main()
        Console.WriteLine("Enter the last number you want me to print in the list of prime numbers")
        Dim x As Integer = Console.ReadLine()

        AddHandler print, AddressOf evenNum
        raiseEvt(x)

        Console.ReadLine()

    End Sub
End Module
