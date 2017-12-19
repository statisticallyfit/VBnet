Imports System
Imports System.Collections.ArrayList

Module Module1

    Class InvalidParseException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Function getUserInput() As Integer

        Dim userInput As Integer
        Dim NumberOfTries As Integer

        ' While user inputs less than three blank spaces, tell user to enter integer only. 
        While (Integer.TryParse(Console.ReadLine(), userInput) = False And NumberOfTries < 3)
            Console.WriteLine("Please enter an integer")
            NumberOfTries = NumberOfTries + 1
        End While

        ' Throw exception after three tries. 
        If (NumberOfTries = 3) Then
            Throw (New InvalidParseException("Number of tries expired")) ' & disableAverage
        End If

        Return userInput
    End Function

    Function AverageTenNum(ByVal userInputs As ArrayList)
        'Declare Average As Integer
        Dim sum As Double

        ' Write averaging formula:
        For Each i As Integer In userInputs
            sum += i
        Next

        Return sum / userInputs.Count

    End Function

    Sub Main(ByVal args() As String)
        'Declare variable "Average"
        Dim Average As Double

        ' Declare the ten variables
        Dim userInputs As ArrayList
        Dim userPos As Integer

        userInputs = New ArrayList
        ' Ask for user input for all variables
        System.Console.WriteLine("Please enter ten numbers for an average")


        Try
            While (userPos < 10)
                ' userInput is added to userInputs ArrayList
                userInputs.Add(getUserInput())
                ' Increment so not more than ten numbers are entered
                userPos = userPos + 1
            End While

            System.Console.WriteLine()

            ' Call the method to evaluate
            Average = AverageTenNum(userInputs)

            'Print solution
            System.Console.WriteLine("The average is: " & Average)
            System.Console.WriteLine()
            System.Console.WriteLine("Average calculated successfully")

        Catch ex As InvalidParseException
            System.Console.WriteLine(ex.Message)
        Finally
            System.Console.WriteLine("Program over")
        End Try

        System.Console.ReadKey()

    End Sub

End Module
