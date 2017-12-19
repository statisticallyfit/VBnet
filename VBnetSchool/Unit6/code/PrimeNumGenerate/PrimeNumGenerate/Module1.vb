Module Module1
    Sub Main()
        Dim i As Integer
        Dim j As Integer
        Dim bflag As Boolean
        For i = 1 To 50
            bflag = True
            For j = 2 To i / 2
                'Console.WriteLine("J = " & j & "   and i/2 =  " & i / 2 & "  i = " & i)

                If i Mod j = 0 Then
                    bflag = False
                    Exit For
                End If

            Next j
            If bflag = True Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
