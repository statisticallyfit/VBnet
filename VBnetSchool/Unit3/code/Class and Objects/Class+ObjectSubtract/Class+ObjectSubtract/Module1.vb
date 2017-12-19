Module Module1
    Class SubtractTwo
        Public Function Subtract(ByVal a As Integer, ByVal b As Integer)
            Return a - b
        End Function
    End Class
    Sub Main()
        Dim obj As New SubtractTwo()
        Console.WriteLine("This is the final answer: " + CStr(obj.Subtract(10, 3)))
        Console.ReadKey()
    End Sub

End Module
