Module Arithmetic

    Sub Main()

        Dim z As Integer

        z = Subtract(12, 13)

        System.Console.WriteLine("The subtracted result is " + CStr(z))

    End Sub

    Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
        Subtract = x - y

    End Function

End Module
