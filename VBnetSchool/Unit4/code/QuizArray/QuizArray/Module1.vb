Imports System
Imports System.Collections

Module Module1

    Sub Main()
        'Declare arraylist
        Dim daysOfWeek As New ArrayList

        'Add items
        daysOfWeek.Add("Monday")
        daysOfWeek.Add("Tuesday")
        daysOfWeek.Add("Wednesday")
        daysOfWeek.Add("Thursday")
        daysOfWeek.Add("Friday")
        daysOfWeek.Add("Saturday")
        daysOfWeek.Add("Sunday")

        'Print
        Console.WriteLine("The days of the week are: ")
        For Each objdays As String In daysOfWeek
            Console.WriteLine(objdays)
        Next

        'Pause to see output
        Console.ReadKey()

    End Sub

End Module
