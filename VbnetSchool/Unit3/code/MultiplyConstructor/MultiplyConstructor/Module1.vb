Module Module1
    Class MultiplyTwo
        Private result As Integer
        Public Sub New(ByVal m As Integer, ByVal n As Integer)
            result = m * n
            System.Console.WriteLine(result)
        End Sub

    End Class

    Public Sub Main()
        'Declare and object in class to use the object to pass the function variables
        Dim obj As New MultiplyTwo(5, 10)
        'Pause to see output      
        Console.ReadKey()
    End Sub

End Module

