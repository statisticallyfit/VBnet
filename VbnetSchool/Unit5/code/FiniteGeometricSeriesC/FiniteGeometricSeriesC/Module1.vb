Module Module1

    Public Class JumpOrZeroTermException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    'Function that gets user input
    Public Function getUserInput(ByVal userInputVarName As String) As Integer
        Dim NumberOfTries As Integer = 0
        Dim userInput As Integer = 0

        System.Console.WriteLine("Please enter an > 0 integer for " + userInputVarName)

        'This is run if input is a string, less <= 0, while number of tries is less than 3
        While (((Integer.TryParse(Console.ReadLine(), userInput) = False) Or userInput <= 0) And NumberOfTries < 3)
            System.Console.WriteLine("Please try again...")
            NumberOfTries = NumberOfTries + 1
        End While

        If (NumberOfTries = 3) Then
            Throw (New JumpOrZeroTermException("Giving up ..."))
        End If

        Return userInput
    End Function

    ' Function that calculates Sn
    Public Function SolveForSn(ByVal a1 As Integer, ByVal r As Integer, ByVal n As Integer) As Integer
        Dim Sn As Integer
        Sn = (a1 * (1 - r ^ n)) / (1 - r)
        Return Sn
    End Function

    Sub Main(ByVal args() As String)
        ' Declare formula variables
        Dim a1 As Integer = 0
        Dim r As Integer = 0
        Dim n As Integer = 0
        Dim Sn As Integer = 0
        Dim userPos As Integer = 0
        
        ' Get user input
        System.Console.WriteLine("Please input values for a1, r, and n in this order")

        Try
            a1 = getUserInput("a1")
            r = getUserInput("r")
            n = getUserInput("n")

            'Call the method
            Sn = SolveForSn(a1, r, n)

            ' Print the sum
            System.Console.WriteLine("The sum of the sequence is: " + CStr(Sn))
            System.Console.WriteLine()
            System.Console.WriteLine("Sequence summed successfully")

        Catch ex As JumpOrZeroTermException
            System.Console.WriteLine()
            System.Console.WriteLine(ex.Message)
        Finally
            System.Console.WriteLine("Program over")
        End Try
        System.Console.ReadKey()
    End Sub
End Module
