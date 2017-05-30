Module Module1

    Delegate Sub Simple()

    Private Class Example
        Public Sub Welcome()
            MsgBox("A delegate with class")
        End Sub
    End Class

    Public Sub Main()
        Dim Simplicity As Simple
        Dim Exo As Example = New Example

        Simplicity = AddressOf Exo.Welcome
        Simplicity()
    End Sub

End Module
