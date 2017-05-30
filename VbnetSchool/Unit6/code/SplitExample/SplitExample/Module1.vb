Module Module1

    Sub Main()
        Dim TestString As String = "apple    pear banana  "
        Console.Write(TestString)
        Dim TestArray() As String = Split(TestString)

        Console.WriteLine() ' space

        ' TestArray holds {"apple", "", "", "", "pear", "banana", "", ""}
        For Each i In TestArray
            Console.Write(i)
        Next

        Console.WriteLine() 'space

        Dim LastNonEmpty As Integer = -1
        For i As Integer = 0 To TestArray.Length - 1
            If TestArray(i) <> "" Then
                LastNonEmpty += 1
                TestArray(LastNonEmpty) = TestArray(i)
            End If
        Next
        ReDim Preserve TestArray(LastNonEmpty)

        ' TestArray now holds {"apple", "pear", "banana"}
        For Each i In TestArray
            Console.Write(i)
        Next

        Console.ReadKey()

    End Sub

End Module
