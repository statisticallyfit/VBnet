Module Module1
    'User define Exception class.
    Public Class Insuficentfund : Inherits Exception
        Sub New()
            MyBase.New("error occurred due to insuficent funds")
        End Sub
        Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
        Sub New(ByVal msg As String, ByVal inner As Exception)
            MyBase.New(msg, inner)
        End Sub
    End Class
    Public Class Bank
        Public Sub withdraw1(ByVal amount As Integer)
            If (amount < 0) Then
                ' Use the user define Exception Class
                Throw New Insuficentfund()
            Else
                Console.WriteLine("Welcome to Bank Account")
                Console.WriteLine("Your bank Account Balance is = " & amount)
            End If
        End Sub
    End Class
    Sub Main()
        Dim obj As New Bank
        Console.WriteLine("if you enter =Ve value exception is Occurr")
        Dim x As Integer
        x = Int32.Parse(Console.ReadLine())
        Try
            obj.withdraw1(x)
            'independent catch block for the user define Exception
        Catch ex As Insuficentfund
            Console.WriteLine(ex.Message)
            Console.WriteLine("***Exception in Bank Account Blance***")
        End Try
        Console.ReadKey()
    End Sub
End Module