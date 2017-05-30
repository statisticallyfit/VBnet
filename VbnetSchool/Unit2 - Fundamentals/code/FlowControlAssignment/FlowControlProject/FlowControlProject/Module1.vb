' Please give command line arguments :-)

Module Module1

    ' Command line arguments are always strings
    Sub Main(ByVal args() As String)

        'local variable definition 
        Dim ageOne As String = args(0)
        Dim ageTwo As String = args(1)

        ' check the boolean condition using if statement 
        If (ageOne > ageTwo) Then
            'print the following 
            Console.WriteLine("The first person is older than the second.")
        Else
            'print the following 
            Console.WriteLine("The second person is older than the first.")
        End If
        ' print which person is older and their ages
        Console.WriteLine("The first person is {0} years old", ageOne)
        Console.WriteLine("The second person is {0} years old", ageTwo)
        Console.ReadLine()
    End Sub

End Module
