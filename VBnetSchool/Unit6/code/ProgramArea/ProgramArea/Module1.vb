Module Module1

    'Public Delegate Function dSArea(ByVal side As Integer)
    Public Delegate Function Area(ByVal length As Integer, ByVal width As Integer)


    Class Shapes
        Dim area As Integer
        'Dim rArea As Integer

        Function squareArea(ByVal length As Integer, ByVal width As Integer)
            area = length * width
            Console.WriteLine("Square area: " & area)
            Return area
        End Function

        Function rectangleArea(ByVal length As Integer, ByVal width As Integer)
            area = length * width
            Console.WriteLine("Rectangle area: " & area)
            Return area
        End Function

    End Class


    Sub Main()
        'Link class variable areas to use delegates with class Shapes
        Dim area As Shapes = New Shapes()

        'Variables for delegate
        Dim square As Area
        Dim rectangle As Area

        ' Use to gather total by normal function calling
        Dim total As Integer

        'Get square information
        Console.WriteLine("Input a length and width value to calculate the square area")
        Dim sLength As Integer = Console.ReadLine()
        Dim sWidth As Integer = Console.ReadLine()

        Console.WriteLine()

        'Get rectangle information
        Console.WriteLine("Input a length and width value to calculate the rectangle area")
        Dim rLength As Integer = Console.ReadLine()
        Dim rWidth As Integer = Console.ReadLine()

        'Address pointer to square area
        square = New Area(AddressOf area.squareArea)
        
        'Address pointer to rectangle area
        rectangle = New Area(AddressOf area.rectangleArea)
        
        'Add all areas via delegates
        total = square(sLength, sWidth) + rectangle(rLength, rWidth)
        Console.WriteLine("Total: " & total)

        Console.ReadKey()

    End Sub

End Module
