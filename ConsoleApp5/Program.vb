Imports System

Module CustomModule
    Sub Main()
        'Dim x, y As Integer
        'x = 5
        'y = x + 5
        ''its a comment here
        'Console.WriteLine("ouh")
        'Console.WriteLine("hello world")
        'Console.WriteLine(y)
        'Console.ReadLine()

        'Dim myFirstName As String
        'myFirstName = "Gyan"
        'Console.WriteLine(myFirstName)
        'Console.WriteLine(myFirstName)

        'Dim a As Integer = 9
        'Dim b As String = " ram"
        'Dim concatVar As String = CStr(a) & b.ToUpper()
        'Console.WriteLine(concatVar)

        'Console.WriteLine("Please type something and press enter.....")
        'Dim userValue As String = Console.ReadLine()
        'Console.WriteLine("you have typed : " & userValue)

        'Console.WriteLine("Would you prefer what is behind door number 1,2 or 3 ?")
        'Dim userValue1 As String = Console.ReadLine()
        'Dim message As String = IIf(userValue1 = "1", "car", "bike")
        'Console.WriteLine("You  picked : {1} .... and you have won a {0}!", message, userValue1)
        'Console.ReadLine()
        'If userValue1 = 1 Then
        '    message = "You have won a car !"
        'ElseIf userValue1 = 2 Then
        '    message = "you have won  a bike !!"
        'ElseIf userValue1 = 3 Then
        '    message = "You have won a truck!!"
        'Else
        '    message = "sorry , this is not a valid choice !!! "
        'End If
        'Console.WriteLine(message)
        'Console.ReadLine()


        ''operators 

        ''assignment operator 

        'x = 3
        'Console.WriteLine(x)

        ''addition 
        'x = 3 + 4
        'Console.WriteLine(x)

        '' subtraction 
        'x = 4 - 3
        'Console.WriteLine(x)

        ''multiplication

        'x = 10 * 3
        'Console.WriteLine(x)

        '' division

        'x = 10 / 5
        'Console.WriteLine(x)

        '' modulus 

        'x = 10 Mod 3

        'Console.WriteLine(x)
        'Console.ReadLine()

        'Dim i, num As Integer

        'Console.WriteLine("Enter a number until you wanna find the even number : ")
        'num = Console.ReadLine()



        'For i = 1 To num
        '    If i Mod 2 = 0 Then
        '        Console.WriteLine(i)
        '    End If
        'Next

        'Console.ReadLine()


        'For i = 1 To 10
        '    If i = 7 Then
        '        Console.WriteLine("found seven")
        '        Exit For
        '    End If
        '    Console.WriteLine(i)
        'Next

        'For j = 10 To 5 Step -1
        '    Console.WriteLine("the value of j :" & j)
        'Next
        'Console.ReadLine()

        'Console.WriteLine("hello there a new begining in  the world of visual basic and .net framework.")

        Dim r1 As New Rect()
        r1.AcceptDetails()
        r1.Display()



        Console.ReadLine()




    End Sub

End Module

Public Class Rect
    'class variables
    Private length As Double
    Private width As Double

    'class methods 
    Public Function AcceptDetails()
        length = 4.5
        width = 6.7
        Return 0

    End Function

    Public Function GetDetails()
        Return length * width
    End Function
    Public Function Display()
        Console.WriteLine("Length of rectangle : {0}", length)
        Console.WriteLine("Width of a rectangle : {0}", width)
        Console.WriteLine("Area of recatangle : {0}", GetDetails())

        Return 0
    End Function
End Class
