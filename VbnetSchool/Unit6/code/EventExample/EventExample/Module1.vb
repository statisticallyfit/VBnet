Module Module1

    Public Event print(ByVal value As Integer) ' same argument as eventRaised - RaiseEvent raises event of printing, which occurs in evenRaised sub

    Sub raise(ByVal a As Integer, ByVal b As Integer) ' goes here after eventToRaise(aNum, bNum) call
        RaiseEvent print(a + b)
    End Sub

    Sub add(ByVal num As Integer) ' goes here after RaiseEvent print(a+b) call
        Console.WriteLine("Answer: ")
        Console.WriteLine(num)
    End Sub

    Sub Main()

        Console.WriteLine("Please input two numbers to be added")

        Console.WriteLine("number one: ")
        Dim aNum As Integer = Console.ReadLine()

        Console.WriteLine("number two: ")
        Dim bNum As Integer = Console.ReadLine()

        AddHandler print, AddressOf add ' after raise, goes to add function because this is delegated
        raise(aNum, bNum)

        Console.ReadKey()

    End Sub

End Module
