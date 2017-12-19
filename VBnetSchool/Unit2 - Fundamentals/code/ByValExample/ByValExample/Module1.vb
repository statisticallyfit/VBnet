Module Module1

    Sub Main()

        ' Declare an instance of the class and assign a value to its field. 
        Dim o1 As Class1 = New Class1()
        Dim o2 As Class1

        o1.Field = 5
        Console.WriteLine("Original value for the field: " & o1.Field)

        o2 = o1
        o1.Field = 10

        If (True) Then
            Dim o3 As Class1

            o3 = o1
            o3.Field = 50
        End If

        ' ByVal does not prevent changing the value of a field or property.
        ChangeFieldValue(o1)

        Console.WriteLine("Value of field after ChangeFieldValue: " & o1.Field)
        Console.WriteLine("Value of o1 after ChangeFieldValue: ")

        ' ByVal does prevent changing the value of o1 itself. 
        ChangeClassReference(o1)
        Console.WriteLine("Value of field after ChangeClassReference: " & o1.Field)
        Console.ReadKey()

    End Sub

    Public Sub ChangeFieldValue(ByVal obj As Class1)
        obj.Field = 500

    End Sub

    Public Sub ChangeClassReference(ByVal obj As Class1)
        obj = New Class1()
        obj.Field = 1000
    End Sub

    Public Class Class1
        Public Field As Integer
    End Class

End Module
