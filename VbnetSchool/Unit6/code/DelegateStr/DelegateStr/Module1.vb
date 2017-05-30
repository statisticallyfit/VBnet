Imports System

Module Module1

    Public Delegate Sub MyDelegate(ByVal MsgString As String)

    Sub Main()
        Dim sendGreeting As MyDelegate

        sendGreeting = New MyDelegate(AddressOf GreetingFn1)
        sendGreeting("buddy duck")

        sendGreeting = New MyDelegate(AddressOf GreetingFn2)
        sendGreeting("buddy chipmunk")

        Console.ReadKey()

    End Sub

    Public Sub GreetingFn1(ByVal strGreeting As String)
        Console.WriteLine("Hi " + strGreeting)
    End Sub

    Public Sub GreetingFn2(ByVal strGreeting As String)
        Console.WriteLine("Hello " + strGreeting)
    End Sub

End Module
