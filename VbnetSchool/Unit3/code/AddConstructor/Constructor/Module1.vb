Module Module1
    Class Add
        Private result As Integer
        Public Sub New(ByVal a As Integer, ByVal b As Integer)
            result = a + b
            System.Console.WriteLine(result)
        End Sub
    End Class

    Sub Main()
        Dim obj As New Add(10, 5)
        System.Console.ReadKey()

    End Sub

End Module
