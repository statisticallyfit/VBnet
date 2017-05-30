Module Module1

    'Define delegate
    Public Delegate Function MyDelegate(ByVal x As Integer, ByVal y As Integer)

    'Add function
    Public Function add(ByVal x As Integer, ByVal y As Integer)
        Dim result As Integer
        result = x + y
        Console.WriteLine("Added result: " + CStr(result))
        Return result
    End Function

    'Subtract function
    Public Function subtract(ByVal x As Integer, ByVal y As Integer)
        Dim result As Integer
        result = x - y
        Console.WriteLine("Subtracted result: " + CStr(result))
        Return result
    End Function

    'Divide function
    Public Function divide(ByVal x As Integer, ByVal y As Integer)
        Dim result As Integer
        result = x \ y
        Console.WriteLine("Divided result: " + CStr(result))
        Return result
    End Function

    Sub Main(ByVal args() As String)
        'Declare variables and input nums from command line
        Dim calculate As MyDelegate
        Dim num1 As String = args(0)
        Dim num2 As String = args(1)
        Dim num3 As String = args(2)
        Dim num4 As String = args(3)
        Dim num5 As String = args(4)
        Dim num6 As String = args(5)

        'Use delegates to point to functions
        calculate = New MyDelegate(AddressOf add)
        calculate(num1, num2)
        calculate = New MyDelegate(AddressOf subtract)
        calculate(num3, num4)
        calculate = New MyDelegate(AddressOf divide)
        calculate(num5, num6)

        Console.ReadLine()

    End Sub

End Module
