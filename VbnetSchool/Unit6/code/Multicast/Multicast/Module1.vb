' This is the Multicast assignment

Imports System

Module Module1

    Public Delegate Function dCalculate(ByVal num1 As Integer, ByVal num2 As Integer)

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

    Function divide(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        result = num2 / num1
        Console.WriteLine("Dividing second by first number: " + CStr(result))
        Return result
    End Function


    Sub Main()
        'Input two numbers for the four operations
        Console.WriteLine("Input two numbers for the four arithmetic operations")

        ' Get arguments for num1, num2 from user
        Dim arg1 As Integer = Console.ReadLine()
        Dim arg2 As Integer = Console.ReadLine()

        'Create variables belonging to delegate dCalculate
        Dim operationAdd As dCalculate
        Dim operationSub As dCalculate
        Dim operationMultiply As dCalculate
        Dim operationDiv As dCalculate

        'Declare variable for multicasting
        Dim findAll As dCalculate

        'Point to address of operations
        operationAdd = New dCalculate(AddressOf add)
        operationSub = New dCalculate(AddressOf subtract)
        operationMultiply = New dCalculate(AddressOf multiply)
        operationDiv = New dCalculate(AddressOf divide)

        ' Multicast 
        findAll = [Delegate].Combine(operationAdd, operationSub, operationMultiply, operationDiv)

        findAll.DynamicInvoke(arg1, arg2)

        'Pause to read output
        Console.ReadKey()

    End Sub

End Module

