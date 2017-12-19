Module Module1

    Public Event print(ByVal value As Integer)

    Sub eventToRaise(ByVal x As Integer)
        RaiseEvent print(x)
    End Sub

    Function evenNumbers(ByVal x As Integer)
        Dim list As New ArrayList

        'Add elements to list
        For i As Integer = 6 To x Step 2
            list.Add(i)
        Next i

        'Print elements in list
        Console.WriteLine("Even numbers: ")
        For Each num As Integer In list
            Console.WriteLine(num)
        Next num

        Return list
    End Function

    Sub Main()

        Console.WriteLine("This program prints even numbers between 6 and 16")
        Dim x As Integer = 16

        AddHandler print, AddressOf evenNumbers
        eventToRaise(x) ' argument must be same as function's and related to event's so it can do event

        Console.ReadKey()

    End Sub

End Module
