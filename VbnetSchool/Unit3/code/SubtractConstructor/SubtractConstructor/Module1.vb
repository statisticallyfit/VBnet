Module Module1
    Class SubtractClass
        Private result As Integer
        Public Sub New(ByVal a As Integer, ByVal b As Integer)
            result = a - b
            System.Console.WriteLine(result)
        End Sub
    End Class

    Sub Main()
        Dim obj As New SubtractClass(9087, 2134)
        Console.ReadKey()
    End Sub
End Module

