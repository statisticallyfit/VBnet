Module Module1
    Public Class NotKeyException : Inherits Exception
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Public Class Key
        Sub showKey(ByVal o As Hashtable)
            If o.ContainsKey("key5") Then
                Console.WriteLine("The key is in the hashtable.")
            Else
                Throw (New NotKeyException("EXCEPTION! WARNING! The key was not found"))
            End If
        End Sub
    End Class


    Sub Main()
        Dim o As New Hashtable()
        Dim key As Key = New Key()

        o.Add("key1", "cat")
        o.Add("key2", "dog")
        o.Add("key3", "fish")
        o.Add("key4", "hamster")

        Try
            key.showKey(o)
        Catch k As NotKeyException
            System.Console.WriteLine(k.Message)
        Finally
            System.Console.WriteLine()
            System.Console.WriteLine("Program is over")
        End Try

        Console.ReadKey()

    End Sub
End Module
