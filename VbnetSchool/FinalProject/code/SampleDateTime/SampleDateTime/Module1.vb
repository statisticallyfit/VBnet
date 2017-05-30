Module Module1

    Sub Main()
        

        'Dim datTim1 As DateTime
        Dim actualDaysBetweenDates As Long
        Dim yearsOfAge As Long
        Dim age As Long
        Dim birthDateString As String
        Dim birthDate As Date

        Console.WriteLine("Input your date of birth ")
        birthDateString = Console.ReadLine()
        birthDate = Date.Parse(birthDateString)

        Dim daysBetweenDates As Long = DateDiff(DateInterval.DayOfYear, birthDate, Now)
        'Console.WriteLine("Difference between dates: " & diffBetweenDates)
        actualDaysBetweenDates = daysBetweenDates + 1
        'Console.WriteLine("Adjusted length: " & adjustedDiff)
        yearsOfAge = actualDaysBetweenDates / 365

        age = yearsOfAge - 1
        Console.WriteLine("Age: " & age)
        Console.ReadLine()
    End Sub

End Module
