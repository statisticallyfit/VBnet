Module Module1
    Class MultiplyTwo
        Public Function Multiply(ByVal m As Integer, ByVal n As Integer)
            Return m * n
        End Function
    End Class
    Sub Main()
        'Create object in MultiplyTwo Class
        Dim obj As New MultiplyTwo()
        ' Print the answer
        Console.WriteLine("The answer is: " + CStr(obj.Multiply(9, 8)))
        Console.ReadKey()
    End Sub

End Module
