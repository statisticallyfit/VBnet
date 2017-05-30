Module Module1
    Class Base
        'Overridable method uses this keyword
        Public Overridable Sub toOverride()
            System.Console.WriteLine("Old method")
        End Sub
    End Class

    Class Derived
        Inherits Base
        'The sub which overrides the base class method uses this keyword overrides
        Public Overrides Sub toOverride()
            System.Console.WriteLine("New and improved method")
            Console.ReadKey()
        End Sub
    End Class

    Public Sub Main()
        Dim overridenResult As New Derived()
        overridenResult.toOverride()
    End Sub

End Module