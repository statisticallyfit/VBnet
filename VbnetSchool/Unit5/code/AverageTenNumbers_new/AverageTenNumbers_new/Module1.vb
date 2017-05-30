Imports System
Imports System.Collections.ArrayList

Module Module1

    Sub Main(ByVal args() As String)
        'Declare variable "Average"
        Dim Average As Double
        Dim amount As ArrayList = New ArrayList

        ' Declare the ten variables
        Dim userInputs As ArrayList
        Dim userPos As Integer

        userInputs = New ArrayList
        ' Ask for user input for all variables
        System.Console.WriteLine("Please enter 10 numbers and press ENTER after each to get their total average")

        Dim cip As InputProvider
        cip = New InputProvider()

        Try
            While (userPos < 10)
                userInputs.Add(getUserInput(cip))
            End While

        Catch ex As InvalidExpressionException
            System.Console.WriteLine("Error")
        End Try

        ' Call the method to evaluate
        Average = AverageTenNum(userInputs)

        'Print solution
        System.Console.WriteLine("The average of the numbers is: " & Average)
        System.Console.ReadKey()

    End Sub

    Function getUserInput(ByVal AnInputProvider As InputProvider) As Integer

        Dim userInput As Integer
        Dim NumberOfTries As Integer

        'System.Console.WriteLine("Please enter an integer")

        While (Integer.TryParse(AnInputProvider.ReadLine(), userInput) = False And NumberOfTries < 3)
            AnInputProvider.ShowUserMessage("Try again naughty little monkey!")
            NumberOfTries = NumberOfTries + 1
        End While


        If (NumberOfTries = 3) Then
            Throw New InvalidExpressionException
        End If

        Return userInput
    End Function

    Function AverageTenNum(ByVal userInputs As ArrayList)
        'Declare Average As Integer
        Dim Average As Double

        ' Write averaging formula:
        For Each i As Integer In userInputs
            Average += i
        Next

        Return Average / userInputs.Count

    End Function

    Class InputProvider

        Function ReadLine() As String

            Return Console.ReadLine()

        End Function

        Sub ShowUserMessage(ByVal Message As String)

            Console.WriteLine(Message)

        End Sub
    End Class

End Module
