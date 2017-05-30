Imports System
Imports System.Collections


Module Module1

    Sub Main()
        Dim animals As New ArrayList

        'Total of six in array
        animals.Add("deer")                 '0
        animals.Add("black bear")           '1 
        animals.Add("red squirrel")         '2  
        animals.Add("mountain lion")        '3 
        animals.Add("hawk")                 '4  
        animals.Add("frog")                 '5   

        ' Call print function 
        PrintStuff(animals)
        

        'Insert new animal
        animals.Insert(1, "polar bear")

        ' Call print function 
        PrintStuff(animals)

        'Remove polar bear
        animals.RemoveAt(1)

        ' Call print function 
        PrintStuff(animals)

        'Pause to see output 
        Console.ReadKey()

    End Sub

    Public Sub PrintStuff(ByVal animals As ArrayList) ''NOTE: returntype of sub must be ArrayList not ArrayList(), which means an array of an ArrayList. 
        'Print items and how many
        Console.WriteLine("Amount of animals: " & animals.Count)
        Console.WriteLine("Arraylist objects are: ")
        For Each objanimals As String In animals
            Console.WriteLine(objanimals)
        Next

    End Sub

End Module

