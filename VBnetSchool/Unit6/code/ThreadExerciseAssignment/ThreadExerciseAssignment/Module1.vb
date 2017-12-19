Module Module1
    Sub add()
        Dim a As Integer = 4
        Dim b As Integer = 5
        Dim result As Integer
        result = a + b
        'Print result
        Console.WriteLine("The answer is: " & result)
    End Sub

    Sub Main()
        'Declare thread
        Dim sum As System.Threading.Thread = New Threading.Thread(AddressOf add)
        'Start thread
        sum.Start()
        'Pause to see output
        Console.ReadKey()
    End Sub

End Module
