Imports System
Imports System.Collections.Stack


Module collections
    Sub Main()
        Dim st As New System.Collections.Stack()
        st.Push("Have fun in the Croatian mountains")
        'st.Push("A")
        'st.Push("M")
        'st.Push("G")
        'st.Push("W")

        'Console.WriteLine("REVERSED: ")
        For Each objstack In st
            Console.WriteLine(objstack)
        Next

        'Console.WriteLine("IN ORDER: ")
        'maybe use Queue instead

        'Pass stack vacation to string 
        Dim vacationPhrase As String = st.ToString()

        'Split vacation phrase
        Dim vacationArray() As String = Split(vacationPhrase)

        For i As Integer = 0 To vacationArray.Length Step 1
            Console.WriteLine(i)
        Next i

        Console.ReadKey()

    End Sub
End Module