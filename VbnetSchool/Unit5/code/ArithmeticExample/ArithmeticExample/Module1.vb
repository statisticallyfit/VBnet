Module Module1

    Sub Main()
        Dim intFixed As Integer = 0
        Dim intTemp As Integer = 100
        Dim num As Integer = 0

        Try
            num = intTemp / intFixed
            System.Console.WriteLine("Program terminated before this statement")
        Catch a As DivideByZeroException
            System.Console.WriteLine("Division by zero has occurred")
        Catch o As OverflowException
            System.Console.WriteLine("Overflow exception here")
        Finally
            System.Console.WriteLine("Result is {0}: " + CStr(num))
        End Try
        System.Console.WriteLine("Press ENTER to continue...")
        System.Console.ReadKey()

    End Sub

End Module
