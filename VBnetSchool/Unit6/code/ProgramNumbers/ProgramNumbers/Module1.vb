

'SOURCE for Prime Number Algorithm: http://www.freevbcode.com/ShowCode.asp?ID=9430

Module Module1

    Public Delegate Function dNums(ByVal x As Integer)

    Function oddNumbers(ByVal x As Integer)
        Dim list As New ArrayList

        'Add elements to list
        For i As Integer = 1 To x Step 2
            list.Add(i)
        Next i

        'Print elements in list
        Console.WriteLine("Odd numbers: ")
        For Each num As Integer In list
            Console.WriteLine(num)
        Next num

        Return list

    End Function


    Function evenNumbers(ByVal x As Integer)
        Dim list As New ArrayList

        'Add elements to list
        For i As Integer = 0 To x Step 2
            list.Add(i)
        Next i

        'Print elements in list
        Console.WriteLine("Even numbers: ")
        For Each num As Integer In list
            Console.WriteLine(num)
        Next num

        Return list
    End Function


    Function primeNumbers(ByVal x As Integer)
        Console.WriteLine("Prime numbers: ")

        'Generate prime numbers
        Dim i As Integer
        Dim j As Integer
        Dim bflag As Boolean

        For i = 1 To x
            bflag = True
            For j = 2 To i / 2
                'Console.WriteLine("J = " & j & "   and i/2 =  " & i / 2 & "  i = " & i)

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

    Function divByFour(ByVal x As Integer)
        Dim list As New ArrayList

        'Add elements divisble by 4
        For i As Integer = 0 To x Step 4
            list.Add(i)
        Next i

        'Print list
        Console.WriteLine("Elements divisible by four are listed: ")
        For Each num As Integer In list
            Console.WriteLine(num)
        Next num
        Return list
    End Function

    Sub Main()
        Console.WriteLine("Input the last number you need printed for the following number sequences: odd, even, prime, and divisible by four")
        Dim x As Integer = Console.ReadLine()

        'Declare delegate variables
        Dim odd As dNums
        Dim even As dNums
        Dim prime As dNums
        Dim divisible As dNums

        'Declare variable for multicasting
        Dim numAll As dNums

        'Point to address of operations
        odd = New dNums(AddressOf oddNumbers)
        even = New dNums(AddressOf evenNumbers)
        prime = New dNums(AddressOf primeNumbers)
        divisible = New dNums(AddressOf divByFour)

        'Multicast
        numAll = dNums.Combine(odd, even, prime, divisible)
        numAll.DynamicInvoke(x)

        Console.ReadKey()

    End Sub

End Module
