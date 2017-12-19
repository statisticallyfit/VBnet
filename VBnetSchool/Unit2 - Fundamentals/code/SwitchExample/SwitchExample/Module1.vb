' Must switch this program to Class Application type

Module Module1
    Sub Main(ByVal args() As String)
        Dim switchOn As String = args(0)
        Select Case switchOn
            Case 1
                Console.WriteLine("Monday")
                Exit Select
            Case 2
                Console.WriteLine("Tuesday")
                Exit Select
            Case 3
                Console.WriteLine("Wednesday")
            Case 4
                System.Console.WriteLine("Thursday")
                Exit Select
            Case 5
                System.Console.WriteLine("Friday")
                Exit Select
            Case 6
                System.Console.WriteLine("Saturday")
                Exit Select
            Case 7
                System.Console.WriteLine("Sunday")
                Exit Select
            Case Else
                System.Console.WriteLine("No day like that")
                Exit Select

        End Select

    End Sub

End Module
