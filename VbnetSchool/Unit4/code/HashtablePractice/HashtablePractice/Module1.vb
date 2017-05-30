Imports System
Imports System.Collections

Module Module1

    Sub Main()
        Dim so As New Hashtable()

        so.Add("b", "textbook")
        so.Add("c", "clock")
        so.Add("l", "laptop")
        so.Add("p", "pencil")
        so.Add("e", "eraser")
        so.Add("r", "memory stick")

        print(so)

        so.Remove("e")

        print(so)

        Console.WriteLine("Presence of eraser: " & so.Contains("e"))

        print(so)

        Console.ReadKey()

    End Sub

    Public Sub print(ByVal so As Hashtable)
        Console.WriteLine("Number of materials: " & so.Count)
        Console.WriteLine("PRINTED OUT: ")
        For Each sobj As String In so.Values
            Console.WriteLine(sobj)
        Next

    End Sub

End Module
