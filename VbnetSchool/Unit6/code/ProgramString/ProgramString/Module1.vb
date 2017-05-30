Imports System
Imports System.Collections.Stack

Module Module1

    Public Delegate Function dPrint(ByVal stack As Stack)

    Sub Main()
        'Declare stack
        Dim stack As Stack = New Stack()


        'Declare variables of dPrint delegate
        Dim reverse As dPrint
        Dim cntCharacters As dPrint
        Dim cntWord As dPrint

        'Declare variable for all
        Dim printAll As dPrint

        'Push words in stack 
        stack.Push(" branch")
        stack.Push(" cherry")
        stack.Push(" the")
        stack.Push(" on")
        stack.Push(" chirping")
        stack.Push(" birds")
        stack.Push("Three")

        'Point to address of operations
        reverse = New dPrint(AddressOf reverseOrder)
        cntCharacters = New dPrint(AddressOf countCharacters)
        cntWord = New dPrint(AddressOf countWords)

        'Multicast
        printAll = dPrint.Combine(reverse, cntCharacters, cntWord)
        printAll.DynamicInvoke(stack)

        'NORMAL calling
        ' reverseOrder(stack)

        'countCharacters(stack)

        'countWords(stack)

        Console.ReadKey()

    End Sub



    Public Function reverseOrder(ByVal stack As Stack)
        'Print in reverse order
        Console.WriteLine("In REVERSE ORDER:")
        For Each i In stack
            Console.Write(i)
        Next
        Console.WriteLine()
        Console.WriteLine()
        Return stack
    End Function



    Public Function countCharacters(ByVal stack As Stack)
        Dim charCount As Integer = 0
        'Count chars - To DELEGATE

        For Each word As String In stack
            'count characters in the word
            Console.WriteLine("Word: " & word)

            For Each character As String In word
                charCount = charCount + 1
            Next character
        Next word
        Console.WriteLine("NUMBER OF CHARACTERS: " & charCount)
        Console.WriteLine()
        Return charCount
    End Function



    Public Function countWords(ByVal stack As Stack)
        Dim wordCount As Integer = stack.Count()
        'Count number of characters in stack DELEGATE
        Console.WriteLine("NUMBER OF WORDS: " & wordCount)
        Return wordCount
    End Function


End Module
