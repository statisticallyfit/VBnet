Imports System

Module Module1

    Private Delegate Sub MyDelegate()

    Sub Main()
        Dim obj As MyDelegate

        obj = New MyDelegate(AddressOf greetHi)

        obj()

        obj = New MyDelegate(AddressOf greetHello)

        obj()

        Console.ReadKey()

    End Sub

    Sub greetHi()
        Console.WriteLine("Hi!")
    End Sub

    Sub greetHello()
        Console.WriteLine("Hello!")
    End Sub

End Module
