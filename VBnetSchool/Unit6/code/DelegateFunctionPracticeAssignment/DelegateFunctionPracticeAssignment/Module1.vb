Imports System

Module Module1

    Public Delegate Function MyDelegate(ByVal num1 As Double, ByVal num2 As Double)

    Function add(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        result = num1 + num2
        Console.WriteLine("Addition: " + CStr(result))
        Return result
    End Function

    Function subtract(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        result = num1 - num2
        Console.WriteLine("Subtraction: " + CStr(result))
        Return result
    End Function

    Function multiply(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        result = num1 * num2
        Console.WriteLine("Multiplication: " + CStr(result))
        Return result
    End Function

    Function divide(ByVal num1 As Double, ByVal num2 As Double)
        Dim result As Integer
        result = num1 / num2
        Console.WriteLine("Division: " + CStr(result))
        Return result
    End Function


    Sub Main()
        'Declare output
        Dim output As MyDelegate
        'Dim x As MyDelegate

        'Get user input
        Console.WriteLine("Please input two numbers to be added, subtracted, multiplied, and divided")
        Dim number1 = Console.ReadLine()
        Dim number2 = Console.ReadLine()

        'By delegate calls, calculate
        Console.WriteLine("Printed by delegate calling")
        output = New MyDelegate(AddressOf add)
        output(number1, number2)

        output = New MyDelegate(AddressOf subtract)
        output(number1, number2)

        'x = (AddressOf multiply)
        'x.Invoke(number1, number2)

        output = New MyDelegate(AddressOf multiply)
        output(number1, number2)

        output = New MyDelegate(AddressOf divide)
        output(number1, number2)

        Console.WriteLine()

        'By function calls, calculate
        Console.WriteLine("Printed by normal function calling")
        add(number1, number2)
        subtract(number1, number2)
        multiply(number1, number2)
        divide(number1, number2)

        Console.ReadKey()

    End Sub

End Module
