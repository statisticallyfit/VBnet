Module Module1

    Sub Main()
        Dim a As Double = -1.7976931348623157E+308
        Dim b As Double = -1.7976931348623157E+308
        Dim c As Double = 0.0
        'smallest double: -1.79769313486231570E+308
        'largest double: 1.7976931348623157E+308.

        c = a + b

        If Double.IsInfinity(c) Then
            Try
                c = a \ b
                System.Console.WriteLine("Program terminated before this point. This message will not be seen")
            Catch n As NotFiniteNumberException
                System.Console.WriteLine("Values a and b are too large for data type double")
            Finally
                System.Console.WriteLine("Result is {0}: " + CStr(c))
            End Try
            System.Console.WriteLine("Press ENTER to continue...")
            System.Console.ReadKey()
        End If
    End Sub
End Module
