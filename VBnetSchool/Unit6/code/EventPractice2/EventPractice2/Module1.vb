Module Module1

    Public Event print(ByVal value As String) ' argument type must be compatible with oddNumbers function

    Sub raiseOdd(ByVal x As Integer)
        'This is to raise printing event
        RaiseEvent print(x)
    End Sub

    Function oddNumbers(ByVal x As Integer)
        Dim list As New ArrayList

        'Add elements to list
        For i As Integer = 1 To x Step 2
            list.Add(i)
        Next i

        'print elements in list
        Console.WriteLine("Odd numbers printed: ")
        For Each i As Integer In list
            Console.WriteLine(i)
        Next i

        Return list
    End Function

    Sub Main()
        'Console.WriteLine("Please input the last number you want printed in the odd number sequence")
        Dim x As Integer = 10
        'Console.ReadLine()

        AddHandler print, AddressOf oddNumbers
        raiseOdd(x)

        Console.ReadKey()

    End Sub

End Module
