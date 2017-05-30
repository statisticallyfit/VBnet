
Module Module1
    Class Calculator
        Public Function Add(ByVal a As Integer, ByVal b As Integer) As Integer
            Return a + b
        End Function
        Public Function Add(ByVal a As Double, ByVal b As Double) As Double
            Return a + b
        End Function

    End Class

    Public Sub Main()
        Dim counter As Calculator
        counter = New Calculator()
        'pass two integers
        Console.WriteLine(counter.Add(1, 5))
        'pass two doubles
        Console.WriteLine(counter.Add(1, 5))
        Console.ReadKey()
    End Sub

End Module