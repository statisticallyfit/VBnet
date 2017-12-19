Module exceptionProg
    Sub Main()
        Try
            Throw New ApplicationException("A custom exception is being thrown here...")
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            Console.WriteLine("Now inside the Finally Block")
        End Try
        Console.ReadKey()
    End Sub
End Module
