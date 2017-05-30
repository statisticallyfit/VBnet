Module Module1
    Class Add
        Private result As Integer
        Public Sub New(ByVal A As Integer, ByVal B As Integer)
            result = A + B
            System.Console.WriteLine(result)
            Console.ReadKey()
        End Sub
    End Class

    Public Sub Main()
        Dim obj As New Add(10, 5)
        System.Console.WriteLine("Press any key to exit the program.")
        System.Console.ReadKey() ' pauses to see output. 
    End Sub

End Module
