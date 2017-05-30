Module Module1

    Public Delegate Function dCalculate(ByVal a As Integer, ByVal b As Integer)

    Class Calculations
        Function add(ByVal a As Integer, ByVal b As Integer)
            Dim result As Integer
            result = a + b
            Console.WriteLine("Added: " & result)
            Return result
        End Function

        Function subtract(ByVal a As Integer, ByVal b As Integer)
            Dim result As Integer
            result = a - b
            Console.WriteLine("Subtracted: " & result)
            Return result
        End Function
    End Class

    Sub Main()
        Console.WriteLine("Please input two numbers to add and subtract")
        Dim num1 As Integer = Console.ReadLine()
        Dim num2 As Integer = Console.ReadLine()

        Dim answer As dCalculate
        Dim calc As Calculations = New Calculations()

        answer = New dCalculate(AddressOf calc.add)
        answer(num1, num2)

        answer = New dCalculate(AddressOf calc.subtract)
        answer(num1, num2)

        Console.ReadKey()

    End Sub

End Module
