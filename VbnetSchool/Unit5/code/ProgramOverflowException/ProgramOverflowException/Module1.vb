Module Module1

    Sub Main()
        Dim a As Double = -1.7976931348623157E+308
        Dim b As Double = 1.7976931348623157E+308
        Dim result As Double = 0.0

        Try
            result = a + b
            System.Console.WriteLine("Program terminated before this point. Message not seen")
        Catch o As OverflowException
            System.Console.WriteLine("There is an arithmetical error of type overflow here. Check double values")
        End Try
        System.Console.WriteLine("Press ENTER to continue...")
        System.Console.ReadKey()

    End Sub

End Module
