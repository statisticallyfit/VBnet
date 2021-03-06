﻿' COMMENT BLOCK
' Name: Ana-Maria Vintila
' Dates as (dd/mm/yyyy): 
'   Begun: 21/1/2014
'   Finished: 22/1/2014
' Course: TCH061-AVT: Programming I - VB.NET   
' Program goal: to ask for input, both deposits and debits, and keep a running balance in the account  

Imports System.Globalization
Imports System.Text


Module Module1

    Class InvalidInputException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Class OverdraftNotAllowedException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Class BankAccount
        Dim balance As Decimal

        'Deposit amount
        Function deposit(ByVal amount As Decimal) As Decimal
            balance += amount
            Return balance
        End Function

        'Withdraw amount
        Function withdraw(ByVal amount As Decimal) As Decimal
            Try
                If amount <= balance Then
                    balance -= amount
                ElseIf amount > balance Then
                    Throw (New OverdraftNotAllowedException("Command rejected, no overdrafts allowed"))
                End If
            Catch o As OverdraftNotAllowedException
                Console.WriteLine(o.Message)
            End Try
            Return balance
        End Function

        'Get balance
        Function getBalance() As Decimal
            Return balance
        End Function

    End Class


    Sub Main()

        Try
            Do
                'Skip line and print instructions
                Console.WriteLine()
            Loop While pickAndExecuteChoice()

        Catch ie As InvalidInputException
            Console.WriteLine(ie.Message)
        Finally
            Console.WriteLine()
            Console.WriteLine("Bank account is closed")
        End Try

        Console.ReadKey()

    End Sub

    Function gracefulInputAmount() As Double
        Dim amount As Decimal
        Dim numTries As Integer
        Dim style As NumberStyles = NumberStyles.Currency Or NumberStyles.AllowCurrencySymbol
        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-GB")

        ' While parsing error occurs and number of tries haven't run out,
        REM  tell user to try again
        While ((Decimal.TryParse(Console.ReadLine(), style, culture, amount) = False Or ((amount - Math.Truncate(amount)).ToString.Length > 4)) And numTries < 3)
            Console.WriteLine("Please try again")
            numTries = numTries + 1
        End While
        ' Throw exception after three tries. 
        If (numTries = 3) Then
            Throw (New InvalidInputException("You ran out of tries giving an amount incorrectly, so balance will not be displayed"))
        End If
        Return amount
    End Function

    Function gracefulInputChoice() As Double
        Dim choice As Integer
        Dim numTries As Integer

        ' While parsing error occurs and number of tries haven't run out, 
        REM tell user to try again
        While (((Integer.TryParse(Console.ReadLine(), choice) = False Or choice > 4) And numTries < 3))
            Console.WriteLine("Please try again")
            numTries = numTries + 1
        End While
        ' Throw exception after three tries. 
        If (numTries = 3) Then
            Throw (New InvalidInputException("You ran out of tries picking a choice incorrectly, so account will close"))
        End If
        Return choice
    End Function

    Function pickAndExecuteChoice() As Boolean
        Dim choice As Integer
        Dim NumberOfTries As Integer
        Dim account As New BankAccount
        Dim amount As Decimal

        ' Show instruction first, then choices. 
        REM Interpret with select case
        Console.WriteLine("1) Deposit money ")
        Console.WriteLine("2) Withdraw money ")
        Console.WriteLine("3) See the current account balance")
        Console.WriteLine("4) None. Done for now ")
        Console.WriteLine()

        ' Input operation number and 
        REM give user three tries to get it right
        While (NumberOfTries < 3)
            Console.WriteLine()
            Console.WriteLine("Pick an operation by typing its number")
            Console.WriteLine()

            'Get user input and check for errors
            choice = gracefulInputChoice()

            'If choice is picked right, do bank account actions
            If (choice) Then
                Select Case choice
                    Case 1
                        Console.WriteLine("Write the amount you want to deposit. Amount cannot exceed two decimal places")
                        amount = gracefulInputAmount()
                        account.deposit(amount)
                        Console.WriteLine("Completed")
                    Case 2
                        Console.WriteLine("Write the amount you want to withdraw. Amount cannot exceed two decimal places")
                        amount = gracefulInputAmount()
                        account.withdraw(amount)
                        Console.WriteLine("Completed")
                    Case 3
                        Console.WriteLine("Current balance is: " & account.getBalance())
                        Console.WriteLine("Completed")
                    Case 4
                        Return False
                End Select
            End If
        End While

        Return True
    End Function

End Module
