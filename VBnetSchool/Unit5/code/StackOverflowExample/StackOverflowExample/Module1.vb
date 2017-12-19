Module Module1

    Sub Main()
        Dim a As Integer = 0
        Dim b As Integer = 50
        Dim c As Integer

        Try
            c = b / a
            Console.WriteLine("The answer is..." + c)
            Call addedReply(a, b, c)
        Catch e As OverflowException When (a = 0)
            Console.WriteLine("An overflow exception occurred.")
            Call addedReply(a, b, c)
        End Try
    End Sub

    Public Sub addedReply(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        Console.WriteLine("Press ENTER to continue...")
        Console.ReadLine()

    End Sub
End Module
