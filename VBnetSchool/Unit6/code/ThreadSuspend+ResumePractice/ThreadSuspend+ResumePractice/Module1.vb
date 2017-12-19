Imports System.Threading.Thread

Module Module1

    Public A As System.Threading.Thread = New Threading.Thread(AddressOf methodA)
    Public B As System.Threading.Thread = New Threading.Thread(AddressOf methodB)

    Sub methodA()
        Dim i As Integer
        For i = 0 To 12
            'Console.WriteLine("A")
            If i = 6 Then 'for A
                B.Start()
                If A.ThreadState = Threading.ThreadState.Running Then
                    A.Suspend()
                End If
            End If
            Console.WriteLine("A")
        Next i
    End Sub

    Sub methodB()
        Dim i As Integer
        For i = 1 To 6
            Console.WriteLine("B")
        Next i

        If A.ThreadState = Threading.ThreadState.Suspended Then
            A.Resume()
        End If
    End Sub



    Sub Main()
        A.Start()
        Console.ReadLine()

    End Sub

End Module
