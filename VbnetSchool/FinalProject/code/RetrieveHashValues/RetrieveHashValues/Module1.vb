Imports System.Collections

Module Module1
    Public Sub Main()
        'Dim airports As New Hashtable

        'airports.Add("JFK", "John F. Kennedy, New York")
        'airports.Add("LAX", "Los Angeles International, Los Angeles")
        'airports.Add("ORD", "O'Hare International, Chicago")
        'airports.Add("LHR", "Heathrow Airport, London")

        'Console.WriteLine(airports.Item("JFK"))

        'Dim month As New Hashtable

        'Convert month from number to a name with select case 
        'month.Add("1", "January")
        'month.Add("February", 2)
        'month.Add("March", 3)
        'month.Add("April", 4)
        'month.Add("May", 5)
        'month.Add("June", 6)
        'month.Add("July", 7)
        'month.Add("August", 8)
        'month.Add("September", 9)
        'month.Add("October", 10)
        'month.Add("November", 11)
        'month.Add("December", 12)

        'Console.WriteLine(month.Item("January"))

        Dim monthOfBirthInt As Integer = Integer.Parse(Console.ReadLine())
        Dim monthOfBirthName As String
        Select Case monthOfBirthInt
            Case 1
                monthOfBirthName = "January"
                Console.WriteLine(monthOfBirthName)
            Case 2
                monthOfBirthName = "February"
                Console.WriteLine(monthOfBirthName)
            Case 3
                monthOfBirthName = "March"
                Console.WriteLine(monthOfBirthName)
            Case 4
                monthOfBirthName = "April"
                Console.WriteLine(monthOfBirthName)
            Case 5
                monthOfBirthName = "May"
                Console.WriteLine(monthOfBirthName)
            Case 6
                monthOfBirthName = "June"
                Console.WriteLine(monthOfBirthName)
            Case 7
                monthOfBirthName = "July"
                Console.WriteLine(monthOfBirthName)
            Case 8
                monthOfBirthName = "August"
                Console.WriteLine(monthOfBirthName)
            Case 9
                monthOfBirthName = "September"
                Console.WriteLine(monthOfBirthName)
            Case 10
                monthOfBirthName = "October"
                Console.WriteLine(monthOfBirthName)
            Case 11
                monthOfBirthName = "November"
                Console.WriteLine(monthOfBirthName)
            Case 12
                monthOfBirthName = "December"
                Console.WriteLine(monthOfBirthName)
                'Case Else
                'Console.WriteLine("You typed something else")
        End Select




        Console.ReadLine()
    End Sub
End Module
