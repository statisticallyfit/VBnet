Module Module1
    Sub Main()
        ' Declare the string value
        Dim strValue As String = "x"

        Try
            'Try to parse string to get integer
            Dim intValue As Integer = Integer.Parse(strValue)
            System.Console.WriteLine("Parsing...")
            'Throw New Exception("The string value could not be parsed")
        Catch f As FormatException
            System.Console.WriteLine("Format Exception! The string value could not be parsed:" & strValue)
        Finally
            ' Say the process is finished
            System.Console.WriteLine("Press ENTER to continue...")
        End Try

        ' Pause output
        Console.ReadKey()

    End Sub
End Module
