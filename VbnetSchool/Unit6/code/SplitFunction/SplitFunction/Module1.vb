Module collections
    Sub Main()
        'Declare vacation phrase 
        Dim vacationPhrase As String = "Have fun in the Croatian mountains"

        'Pass ArrayList to string
        Dim vacationArray As String = vacationPhrase.ToArray()

        'Split vacation phrase
        Split(vacationPhrase)

        'Print split elements from vacation phrase: "Have" "fun" "in "the"...
        For i As Integer = 0 To vacationArray.Length Step 1
            Console.WriteLine(i)
        Next i

        Console.ReadKey()

    End Sub
End Module
