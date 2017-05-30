Module Module1
    Sub Main()
        Dim obj As New Destructor()
    End Sub
End Module

Public Class Destructor
    Protected Overrides Sub Finalize()
        Write("hello")
        Read()
    End Sub
End Class