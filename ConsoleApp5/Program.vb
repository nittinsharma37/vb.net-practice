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

        '        Dim r1 As New Rect()
        '#Const age = True

        '#If age Then

        '        Console.WriteLine("You are welcome to the Robotics Club")
        '#End If
        '        Console.ReadKey()
        '        r1.AcceptDetails()
        '        r1.Display()

        '        Dim msgReturn As New MsgRW()
        '        msgReturn.MsgRead()
        '        msgReturn.MsgWrite()

        '        Console.ReadLine()


        '******************************************************************************************************



        '******************************operators here**********************************************************


        'Dim a, b As Integer
        'Dim res As Single
        'Dim compa As Boolean
        'a = 2
        'b = 7
        '***************************Arthimetic operators ****************************************************
        'res = b ^ a
        'res = a + b
        'res = b / a this sign will return division in floating point 
        'res = b \ a this will return in integer 
        'res = b Mod a this will Return modulus 

        '**********************comparison op*************************

        'compa = (a = b) for equals to value 

        'compa = a <> b  returns true if they are not equal

        'compa = a < b
        'Console.WriteLine(compa)
        'compa = a > b
        'Console.WriteLine(compa)
        'compa = a <= b
        'Console.WriteLine(compa)
        'compa = a >= b
        'Console.WriteLine(compa)

        'Console.WriteLine(compa)


        'Dim x As Integer = 5
        'Dim y As Integer = 10
        'Dim Result, obj, obj2 As Object
        'Dim str, str2 As String
        'str = "Apple12345"
        'str2 = "Apple12345"
        'obj = 10
        'obj2 = 20

        'Console.WriteLine(" Program of Comparison Operator")
        ''Use of > Operator  
        'Console.WriteLine(" Output of x > y is {0}", x > y)

        ''Use of < Operator  
        'Console.WriteLine(" Output of x < y is {0}", x < y)

        ''Use of = Operator  
        'Console.WriteLine(" Output of x = y is {0}", x = y)

        ''Use of <> Operator  
        'Console.WriteLine(" Output of x <> y is {0}", x <> y)

        ''Use of >= Operator  
        'Console.WriteLine(" Output of x >= y is {0}", x >= y)

        ''Use of <= Operator  
        'Console.WriteLine(" Output of x <= y is {0}", x <= y)

        ''Use of Is Operator  
        'Result = obj Is obj2
        'Console.WriteLine(" Output of obj Is obj2 is {0}", Result)

        ''Use of Is Operator  
        'Result = obj IsNot obj2
        'Console.WriteLine(" Output of obj IsNot obj2 is {0}", Result)

        ''Use of Like Operator  
        'Result = str Like str2
        'Console.WriteLine(" Output of str Like str2 is {0}", Result)


        '*******************************-- Logical --*****************************


        'Dim a As Boolean = True
        'Dim b As Boolean = False
        'Dim c, d As Integer
        'c = 10
        'd = 20

        ''Use of And Operator  
        'If a And b Then
        '    Console.WriteLine(" Operands A And B are True")
        'End If

        ''Use of Or Operator  
        'If a Or b Then
        '    Console.WriteLine(" Operands A Or B are True")
        'End If

        ''Use of Xor Operator  
        'If a Xor b Then
        '    Console.WriteLine(" Operands A Xor B is True")
        'End If

        ''Use of And Operator  
        'If c And d Then
        '    Console.WriteLine(" Operands c And d is True")
        'End If

        ''Use of Or Operator  
        'If c Or d Then
        '    Console.WriteLine(" Operands c Or d is True")
        'End If

        ''Use of AndAlso Operator  
        'If a AndAlso b Then
        '    Console.WriteLine(" Operand A AndAlso B is True")
        'End If

        ''Use of OrElse Operator  
        'If a OrElse b Then
        '    Console.WriteLine(" Operand A OrElse B is True")
        'End If

        ''Use of Not Operator  
        'If Not (a And b) Then
        '    Console.WriteLine(" Output of Not (A And B) is True")
        'End If

        '*******************************-- Asignment op --****************************************

        'Dim A As Integer = 5
        'Dim B As Integer
        'Dim Str, name As String
        'name = "come"
        'Str = "Wel"

        ''Use of = Operator  
        'B = A
        'Console.WriteLine(" Assign value A to B is {0}", B)

        ''Use of += Operator  
        'B += A
        'Console.WriteLine(" Output of B += A is {0}", B)

        ''Use of -= Operator  
        'B -= A
        'Console.WriteLine(" Output of B -= A is {0}", B)

        ''Use of *= Operator  
        'B *= A
        'Console.WriteLine(" Output of B *= A is {0}", B)

        ''Use of /= Operator  
        'B /= A
        'Console.WriteLine(" Output of B /= A is {0}", B)

        ''Use of = Operator  
        'B \= A
        'Console.WriteLine(" Output of B \= A is {0}", B)

        ''Use of ^= Operator  
        'B ^= A
        'Console.WriteLine(" Output of B ^= A is {0}", B)

        ''Use of &= Operator  
        'Str &= name
        'Console.WriteLine(" Output of Str &= name is {0}", Str)

        '****************-- String concatination --*************************

        'Dim str As String = " All we "
        'Dim str2 As String = " have to learn "
        'Dim str3 As String = " "
        'Dim str4 As String = " is code. "
        'Dim result As String
        'Dim result2 As String
        'result = str & str2
        'Console.WriteLine(" Result = str & str2 gives = {0}", result)
        'result2 = str + str2 + str3 + str4
        'Console.WriteLine(" Result = str + str2 + str3 +str4 gives = {0}", result2.ToString)
        'Decision()
        'temperature(20)
        'ForLoop()
        CollHash()
        Console.ReadLine()
    End Sub

    Public Sub CollHash()
        Dim ht As Hashtable = New Hashtable()
        Dim k As String
        ht.Add("001", "Zara Ali")
        ht.Add("002", "Abida Rehman")
        ht.Add("003", "Joe Holzner")
        ht.Add("004", "Mausam Benazir Nur")


        If (ht.ContainsValue("Nuha Ali")) Then
            Console.WriteLine("This student name is already in the list")
        Else
            ht.Add("005", "Nuha Ali")
        End If
        ' Get a collection of the keys. 
        Dim key As ICollection = ht.Keys

        For Each k In key
            Console.WriteLine(" {0} : {1}", k, ht(k))
        Next k
        Console.ReadKey()
    End Sub




    Public Sub ForLoop()
        Dim anArray() As Integer = {1, 3, 5, 7, 9}
        Dim arrayItem As Integer
        'displaying the values

        For Each arrayItem In anArray
            Console.WriteLine(arrayItem)
        Next
        Console.ReadLine()
    End Sub

    Sub temperature(ByVal temp)

        Dim tempFromUser As Integer = temp

        Convert.ToInt32(tempFromUser)
        Console.WriteLine("temperature : {0}", tempFromUser)


        Select Case tempFromUser
            Case Is < 0
                Console.WriteLine("its cold !")
            Case Is < 18
                Console.WriteLine("its getting acceptable !")
            Case Is < 25
                Console.WriteLine("its comfortable !")
            Case Is < 35
                Console.WriteLine("its getting hot !")
            Case Is < 40
                Console.WriteLine("its burning 😁")

            Case Else
                Console.WriteLine("its not possible !")
        End Select




    End Sub


    Sub Decision()
        'local variable definition 
        Dim a As Integer = 10

        ' check the boolean condition using if statement 
        If (a < 20) Then
            ' if condition is true then print the following 
            Console.WriteLine("a is less than 20")
        End If
        Console.WriteLine("value of a is : {0}", a)
        Console.ReadLine()
    End Sub


End Module




