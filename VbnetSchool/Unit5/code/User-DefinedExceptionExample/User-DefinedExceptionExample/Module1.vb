Module Module1

    Class OddException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Sub Main()
        Dim y As Integer = 11

        Try
            If y Mod 2 = 0 Then
                System.Console.WriteLine("Number y was even")
            Else
                Throw (New OddException("Odd error occurred"))
            End If
        Catch ex As OddException
            System.Console.WriteLine(ex.Message)
        Finally
            System.Console.WriteLine("Press ENTER to continue")
        End Try
        System.Console.ReadKey()
    End Sub

End Module
