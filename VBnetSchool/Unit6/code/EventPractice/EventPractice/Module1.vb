Module Module1

    Public Event print(ByVal value As Integer)

    Sub raiseMultiply(ByVal a As Integer, ByVal b As Integer)
        RaiseEvent print(a * b) ' a*b is value
    End Sub

    Function callToPrintNum(ByVal num As Integer)
        Console.WriteLine("The answer: ")
        Console.WriteLine(num)
        Return num
    End Function

    Sub Main()
        Console.WriteLine("Please enter two numbers to be multiplied")
        Dim a As Integer = Console.ReadLine()
        Dim b As Integer = Console.ReadLine()

        AddHandler print, AddressOf callToPrintNum
        raiseMultiply(a, b)

    End Sub

End Module
