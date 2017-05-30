Module exceptionProg
    Public Class TempIsZeroException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class
    Public Class Temperature
        Dim temperature As Integer = 0
        Sub showTemp()
            If (temperature = 0) Then
                Throw (New TempIsZeroException("Zero Temperature found"))
            Else
                Console.WriteLine("Temperature: {0}", temperature)
            End If
        End Sub
    End Class
    Sub Main()
        Dim temp As Temperature = New Temperature()
        Try
            temp.showTemp()
        Catch e As TempIsZeroException
            Console.WriteLine("TempIsZeroException: {0}", e.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
