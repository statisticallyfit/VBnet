Module Module1

    Public Class Add
        Public Function add(ByVal a As Integer, ByVal b As Integer) As Integer
            Return a + b
        End Function
    End Class

    Sub Main()
        Dim objadd As New Add()
        System.Console.WriteLine(objadd.add(10, 5))
        Console.ReadKey()
    End Sub

End Module
