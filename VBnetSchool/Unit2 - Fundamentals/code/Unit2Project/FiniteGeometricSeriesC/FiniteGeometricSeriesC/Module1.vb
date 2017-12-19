Module Module1

    ' PROGRAM MUST give user control after he inserted 0 values for either or all terms

    Class TermIsZeroException : Inherits Exception
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class


    Sub Main(ByVal args() As String)
        ' Declare formula variables
        Dim firstTerm As Integer
        Dim ratio As Integer
        Dim numberOfTerms As Integer
        Dim Sn As Integer
        Dim firstTermInput As ArrayList = New ArrayList
        Dim ratioInput As ArrayList = New ArrayList
        Dim numberOfTermsInput As ArrayList = New ArrayList
        Dim userPos As Integer

        System.Console.WriteLine("Enter a first term, common ratio, and number of terms for your sequence in this order")

        Try
            While userPos < 3
                getUserInput("a1")
                getUserInput("r")
                getUserInput("n")
            End While
            
        Catch ex As TermIsZeroException
            System.Console.WriteLine(ex.Message)
        End Try

        'Call the method
        Sn = SolveForSn(firstTerm, ratio, numberOfTerms)

        ' Print the sum
        System.Console.WriteLine("The sum of the sequence is: " + CStr(Sn))
        System.Console.ReadKey()
    End Sub


    ' Function that gets user input
    Public Function getUserInput(ByVal name As String) As Integer
        Dim NumberOfTries As Integer
        Dim firstTermInput As ArrayList = New ArrayList
        Dim ratioInput As ArrayList = New ArrayList
        Dim numberOfTermsInput As ArrayList = New ArrayList
        Dim userInput As Integer = Console.ReadLine()

        'While user inputs zero values within three tries, tell user to enter nonzero values only. 
        'While ((firstTermInput(Console.ReadLine) = 0 Or ratioInput(Console.ReadLine) = 0 Or numberOfTermsInput(Console.ReadLine) = 0) And (NumberOfTries < 3))
        'Console.WriteLine("Please enter nonzero values only.")
        'NumberOfTries = NumberOfTries + 1
        'End While 

        While (userInput = 0 And NumberOfTries > 3)
            System.Console.WriteLine("Please input non-zero values only")
            NumberOfTries = NumberOfTries + 1
        End While


        ' Throw exception after three tries. 
        If (NumberOfTries = 3) Then
            Throw (New TermIsZeroException("ERROR. Number of tries has expired."))
        End If


        Return userInput

    End Function

    ' Function that calculates Sn
    Public Function SolveForSn(ByVal a1 As Integer, ByVal r As Integer, ByVal n As Integer) As Integer
        Dim Sn As Integer
        Sn = (a1 * (1 - r ^ n)) / (1 - r)
        Return Sn
    End Function

End Module


