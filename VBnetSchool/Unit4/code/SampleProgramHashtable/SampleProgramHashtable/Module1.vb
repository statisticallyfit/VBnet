Imports System
Imports System.Collections

Module Module1

    Sub Main()
        Dim animals As New Hashtable()

        'Total of six in hashtable
        animals.Add("a1", "deer")                 '0
        animals.Add("a2", "black bear")           '1 
        animals.Add("a3", "red squirrel")         '2  
        animals.Add("a4", "mountain lion")        '3 
        animals.Add("a5", "hawk")                 '4  
        animals.Add("a6", "frog")                 '5   

        'Call PrintStuff
        PrintStuff(animals)

        'Remove the mountain lion 
        animals.Remove("a4")

        'Call PrintStuff
        PrintStuff(animals)

        'Does Hashtable contain animal?
        Console.WriteLine("Is there an animal at a4? :" & animals.Contains("a4"))
        Console.WriteLine("Is there an animal at a1? :" & animals.Contains("a5")) 'will be frog 

        ' Add a leopard
        animals.Add("a4", "leopard")

        'Print
        PrintStuff(animals)

        'Clear Hashtable
        animals.Clear()

        ' If Hashtable is empty, print it is empty
        If animals.Count = 0 Then
            Console.WriteLine("Empty")
        End If

        Console.ReadKey()

    End Sub

    Public Sub PrintStuff(ByVal animals As Hashtable)

        'Amount of animals
        Console.WriteLine("Amount of animals " & animals.Count)

        Console.WriteLine("Hashtable printed: ")
        'Print loop 
        For Each objanimal As String In animals.Values
            Console.WriteLine(objanimal)
        Next

    End Sub
End Module
