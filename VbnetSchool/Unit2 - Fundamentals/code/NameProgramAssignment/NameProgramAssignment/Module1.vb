Module Module1

    Sub Main()
        'Declare string variables name and team 
        Dim input As String

        ' Displays instructions
        Console.WriteLine("To see my name, type your own name below, starting with 'My name is...' in any letter case you prefer. To see my favorite sports team, type 'My team is...' and your favorite team")

        'Let user input go into the input variable
        input = Console.ReadLine()

        ' If 'My name is [user name]" is typed, print my own name in response to the user's
        If input.ToLower().StartsWith("my name is ") Then
            Console.Write("My name is Ana-Maria, ")
            Console.WriteLine(input.Substring("My name is".Length()))
        End If

        ' If 'My team is [user team]" is typed, print my own team in response to the user's
        If input.ToLower().StartsWith("my team is ") Then
            Console.Write("My team is the Blue Jays. I see yours is ")
            Console.WriteLine(input.Substring("My team is ".Length()))
        End If

        ' This pauses the program to see the output
        Console.ReadKey()

    End Sub

End Module
