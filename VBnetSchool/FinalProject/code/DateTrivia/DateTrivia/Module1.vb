﻿' COMMENT BLOCK
' Name: Ana-Maria Vintila
' Dates as (dd/mm/yyyy): 
'   Begun: 20/1/2014
'   Finished: 21/1/2014
' Course: TCH061-AVT: Programming I - VB.NET   
' Program goal: to give the user their age and trivia for the decade of the birth year if they input their full date of birth.  

' Goal getUserBirthDateAsDate(): to get the user input as a birthdate
' parameter: none
' Goal calculateAgeFromBirthDate(): to find the user's age from the birthday he inputted
' parameter: the result of getUserBirthDateAsDate() function, which is birthDate
' Goal getTriviaFromDate(): to use the birthDate input to locate trivia for the decade he was born
' parameter: the user's birthDate

Imports System.Collections.Hashtable

Module Module1

    Class InvalidDateException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class


    Function getUserBirthDateAsDate()
        'Declarations for birthdate information
        'Dim birthDateString As String
        Dim birthDate As Date
        Dim NumberOfTries As Integer

        'Instructions 
        Console.WriteLine("Instructions: ")
        Console.WriteLine()
        Console.WriteLine("1) to find your age, please write your date of birth.")
        Console.WriteLine()
        Console.WriteLine("2) you can write the day, month, and year in any format you choose but they must be spaced.")
        Console.WriteLine()
        Console.WriteLine("Now press ENTER to begin")
        Console.ReadLine()
        Console.WriteLine("Input your date of birth ")
        'birthDateString = Console.ReadLine()

        'If birthDate is invalid (if month or day doesn't exist) then tell the user 
        While ((Date.TryParse(Console.ReadLine(), birthDate)).Equals(False) And NumberOfTries < 3) ' input birthDateAsString from console and try to parse to Date object
            Console.WriteLine("Please try again")
            NumberOfTries = NumberOfTries + 1
        End While
        ' Throw exception after three tries
        If (NumberOfTries = 3) Then
            Throw (New InvalidDateException("Sorry, you ran out of tries"))
        End If

        'Return the birthDate as type Date. Will be argument of calculateAgeFromBirthDate()
        Return birthDate

    End Function


    Function calculateAgeFromBirthDate(ByVal birthDate As Date)
        Dim daysBetweenDates As Integer
        Dim actualDaysBetweenDates As Integer
        Dim age As Integer

        'Find the number of days between the dates
        daysBetweenDates = DateDiff(DateInterval.DayOfYear, birthDate, Now)
        'Adjust the number to get actual number of days
        actualDaysBetweenDates = daysBetweenDates + 1
        age = (actualDaysBetweenDates / 365)

        'Return the age. Variable age accepts this answer in Sub Main()
        Return age

    End Function

    Function getTriviaFromDate(ByVal birthDate As Date) As String ' must be as string because it returns string output, either " " or trivia(i)

        'Declare two arrays to store the decade and trivia separately
        Dim decade(12) As Date
        Dim trivia(12) As String
        Dim i As Integer

        'Decade array as Date
        decade(0) = #1/1/2010#
        decade(1) = #1/1/2000#
        decade(2) = #1/1/1990#
        decade(3) = #1/1/1980#
        decade(4) = #1/1/1970#
        decade(5) = #1/1/1960#
        decade(6) = #1/1/1950#
        decade(7) = #1/1/1940#
        decade(8) = #1/1/1930#
        decade(9) = #1/1/1920#
        decade(10) = #1/1/1910#
        decade(11) = #1/1/1900#

        'Trivia array as a string
        trivia(0) = "Upon completion in 2010, Burj Khalifa becomes the world’s tallest building."
        trivia(1) = "A Leonid meteor shower storm occurs on November 18, 2001. "
        trivia(2) = "In 1998, a Lunar Prospector finds that it is possible for water to exist on the Moon. "
        trivia(3) = "Elie Wiesel, survivor of the Holocaust during World War II and writer of Night, is awarded the Nobel Prize in 1986. "
        trivia(4) = "Maya Angelou publishes 'I Know Why the Caged Bird Sings' as a work of literature to fight racism. "
        trivia(5) = "On November 12, 1961, Romanian gymnast Nadia Comaneci is born; on April 12, 1961, Soviet cosmonaut Yuri Gagarin is the first man in space; and on July 20, 1969, Apollo 11 lands on the moon"
        trivia(6) = "The first airplane lands at the North Pole in 1952"
        trivia(7) = "This decade, after taking her religious vows in May 1931 and going to teach at St. Mary’s School at the Loreto Entally community of Calcutta, she graduates as principal of the school in 1944. "
        trivia(8) = "Franklin D. Roosevelt becomes president of the United States in 1932. "
        trivia(9) = "Martin Luther King Jr., a famous civil-rights activist, is born on January 15, 1929"
        trivia(10) = "In 1912, Antoni Gaudí finishes the Casa Milà , a self-supporting steel structure with ‘undulating stone facades,’ best known as La Pedrera (‘The Quarry’)  "
        trivia(11) = "Jack London publishes two of his adventure books describing a loyal husky, traveling to the Klondike for gold, and the savage wilderness of the natural world. Published first is The Call of the Wild (1903) and the second is White Fang (1906) "


        ' Compare birthdate to each next value in decade
        For i = 0 To 11
            If birthDate < decade(i) Then
                'nothing is returned
            Else
                Return trivia(i)
            End If
        Next i

        If (birthDate < decade(0) And birthDate > decade(11)) Then
            Console.WriteLine("Oops! Don't have trivia for this decade")
        End If

        Return ""

    End Function


    Sub Main()
        Dim age As Integer
        Dim userBirthDate As Date

        Try
            'Get age
            userBirthDate = getUserBirthDateAsDate()
            age = calculateAgeFromBirthDate(userBirthDate)

            'Get trivia for decade
            Console.WriteLine()
            Console.WriteLine("You are " & age & " years old")
            Console.WriteLine()
            Console.WriteLine(" ~ Trivia for this decade ~ ")
            Console.WriteLine()
            Console.WriteLine(getTriviaFromDate(userBirthDate))

        Catch d As InvalidDateException
            Console.WriteLine(d.Message)
        Finally
            Console.WriteLine()
            Console.WriteLine("End of program")
        End Try

        Console.ReadKey()

    End Sub

End Module
