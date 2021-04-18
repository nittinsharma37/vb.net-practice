Imports System

Public Class Rect
    'class variables
    Private length As Double
    Private width As Double

    'class methods 
    Public Function AcceptDetails()
        Console.WriteLine("Enter the length and width of a rectangle ")
        'Parsing values here
        length = Convert.ToDouble(Console.ReadLine)
        width = Double.Parse(Console.ReadLine())
        Return 0

    End Function

    Public Function GetArea()
        Return length * width
    End Function

    Public Function GetPerimeter()
        Return 2 * (length + width)

    End Function

    Public Function Display()
        Console.WriteLine("Length of rectangle : {0}", length)
        Console.WriteLine("Width of a rectangle : {0}", width)
        Console.WriteLine("Area of recatangle : {0}", GetArea())
        Console.WriteLine("Perimeter of recatangle : {0}", GetPerimeter())

        Return 0
    End Function
End Class
