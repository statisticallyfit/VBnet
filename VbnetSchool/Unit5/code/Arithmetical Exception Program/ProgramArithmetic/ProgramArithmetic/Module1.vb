Module Module1
    Sub Main()
        'Variable declaration
        Dim i As Integer = Integer.MaxValue
        Dim j As Integer

        'Try and catch block to form error and catch it
        Try
            j = i + 1 'adding even one more the Integer's maximum value causes overflow
            Console.WriteLine("Program terminated here. Message will not be seen")
        Catch o As OverflowException
            Console.WriteLine("An integer cannot have more than its maximum value")
        End Try
        'End messages to user
        Console.WriteLine("Press ENTER to continue")
        Console.ReadKey()

    End Sub
End Module


