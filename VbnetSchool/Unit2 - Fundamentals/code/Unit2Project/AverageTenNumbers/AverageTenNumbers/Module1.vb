Module Module1

    Sub Main(ByVal args() As String)
        'Declare variable "Average"
        Dim Average As Double

        ' Declare the ten variables and allow their input values to be inputted from command line. 
        Dim n1 As String = args(0)
        Dim n2 As String = args(1)
        Dim n3 As String = args(2)
        Dim n4 As String = args(3)
        Dim n5 As String = args(4)
        Dim n6 As String = args(5)
        Dim n7 As String = args(6)
        Dim n8 As String = args(7)
        Dim n9 As String = args(8)
        Dim n10 As String = args(9)

        ' Call the method to evaluate
        Average = AverageTenNum(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10)

        'Print solution
        System.Console.WriteLine("The average of the numbers is: " & Average)
        System.Console.ReadKey()
    End Sub

    Function AverageTenNum(ByVal n1 As Integer, ByVal n2 As Integer, ByVal n3 As Integer, ByVal n4 As Integer, ByVal n5 As Integer, ByVal n6 As Integer, ByVal n7 As Integer, ByVal n8 As Integer, ByVal n9 As Integer, ByVal n10 As Integer)
        'Declare Average As Integer
        Dim Average As Double

        ' Write averaging formula: 
        Average = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10

        Return Average

    End Function

End Module
