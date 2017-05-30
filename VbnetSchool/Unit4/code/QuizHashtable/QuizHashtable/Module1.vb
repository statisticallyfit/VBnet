Imports System
Imports System.Collections


Module Module1

    Sub Main()
        ' Declare friends
        Dim friends As New Hashtable()

        'Add elements
        friends.Add("ID1", "Linda")
        friends.Add("ID2", "Iren")
        friends.Add("ID3", "Madeline")
        friends.Add("ID4", "Vanessa")
        friends.Add("ID5", "Joelle")
        friends.Add("ID6", "Andra")
        friends.Add("ID7", "Otilia")

        'Print
        print(friends)

        Console.ReadKey()

    End Sub

    'Print function 
    Public Sub print(ByVal friends As Hashtable)
        For Each objfriend As String In friends.Values
            Console.WriteLine(objfriend)
        Next
    End Sub
End Module
