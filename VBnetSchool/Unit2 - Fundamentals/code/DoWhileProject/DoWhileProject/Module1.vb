' This program prints numbers 1 to 10 in increasing order

Module Module1
    Sub Main()
        'Initialize variable
        Dim number As Integer = 0

        Do
            'Print to see number first
            System.Console.WriteLine(number)

            'Now increment by 1
            number = number + 1

        Loop While (number <= 10)

        'Print the loop is over
        System.Console.WriteLine("The loop is over")

    End Sub

End Module

