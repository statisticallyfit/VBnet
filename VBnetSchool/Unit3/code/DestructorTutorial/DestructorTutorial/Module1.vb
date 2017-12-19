Imports System.Console
Module Module1

    Sub Main()
        Dim con As New Constructor(20)
        ' using Constructor's object con to access ShowAge Function in Constructor
        WriteLine(con.ShowAge())
        'storing a value in the constructor by passing a value(20) and calling it with the ShowAge method
        Read()
    End Sub

End Module

Public Class Constructor
    Public Age As Integer

    Public Sub New(ByVal x As Integer)
        'constructor
        Age = x
        'storing the value of Age in constructor
    End Sub

    Public Function ShowAge() As Integer
        Return Age
        'returning the stored value
    End Function

End Class
