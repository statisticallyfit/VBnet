' Program to create exception from comparing two variables  
Module Module1
    ' Class to pass message "a is not bigger than b"
    Public Class MaxCompareException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Class Maximum

        Public Sub showMax(ByVal a As Integer, ByVal b As Integer)
            'If-Then statement causing error
            If a > b Then
                Console.WriteLine("a is bigger than b")
            Else
                'Throw the exception
                Throw (New MaxCompareException("WARNING! a is not bigger than b"))
            End If
        End Sub
    End Class

    Sub Main()
        Dim a As Integer = 10
        Dim b As Integer = 20
        Dim m As Maximum = New Maximum()

        Try
            m.showMax(a, b)
        Catch ex As MaxCompareException
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("Press ENTER to continue...")
        End Try
        Console.ReadKey()
    End Sub

End Module

    
