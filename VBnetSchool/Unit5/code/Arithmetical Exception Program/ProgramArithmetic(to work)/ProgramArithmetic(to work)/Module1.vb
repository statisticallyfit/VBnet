Module Module1
    Sub Main()
        'Declare variables
        Dim i As Integer = Integer.MaxValue
        Dim j As Integer

        'Try and catch block to show there is no error
        Try
            j = i + 0 'adding by zero will not make the program crash
            Console.WriteLine("Program is fine. Message will be seen")
        Catch o As OverflowException
            Console.WriteLine("There will be no error")
        End Try
        'Final messages to user
        Console.WriteLine("Press ENTER to continue")
        Console.ReadKey()

    End Sub
End Module
