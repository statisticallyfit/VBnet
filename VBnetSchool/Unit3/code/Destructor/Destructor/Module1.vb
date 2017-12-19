Module Module1
    Public Class Destructor
        Protected Overrides Sub Finalize()
            Console.WriteLine("hello")
            Console.ReadKey()
            Finalize()
        End Sub
    End Class
    Sub Main()
        Dim obj As New Destructor
    End Sub

End Module
