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
        Dim num1 As Integer = Console.ReadLine()
        Dim num2 As Integer = Console.ReadLine()

        Dim calc As Calculations = New Calculations()

        Dim addOp As dCalculate
        Dim subOp As dCalculate
        Dim getAll As dCalculate

        addOp = New dCalculate(AddressOf calc.add)
        subOp = New dCalculate(AddressOf calc.subtract)

        getAll = [Delegate].Combine(addOp, subOp)
        getAll.DynamicInvoke(num1, num2)


        Console.ReadKey()

    End Sub

End Module
