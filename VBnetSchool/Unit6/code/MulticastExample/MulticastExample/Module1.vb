Module Module1

    Public Delegate Sub myGreeting(ByVal strGreeting As String)

    Public Sub GreetingFn1(ByVal strGreeting As String)
        Console.WriteLine("Hi and " + strGreeting)
    End Sub

    Public Sub GreetingFn2(ByVal strGreeting As String)
        Console.WriteLine("Hello and " + strGreeting)
    End Sub

    Sub Main()
        'variables as Delegate myGreeting
        Dim greeting1 As myGreeting
        Dim greeting2 As myGreeting

        Dim greetingAll As [Delegate]

        greeting1 = New myGreeting(AddressOf GreetingFn1)
        greeting2 = New myGreeting(AddressOf GreetingFn2)

        greetingAll = [Delegate].Combine(greeting1, greeting2)

        greetingAll.DynamicInvoke("good morning")

        Console.ReadKey()
    End Sub

End Module
