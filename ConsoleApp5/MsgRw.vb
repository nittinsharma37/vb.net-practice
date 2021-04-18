
Public Class MsgRW
    Dim msg As String
    Public Function MsgRead()
        Console.WriteLine("Enter your message : ")
        msg = Console.ReadLine().ToString
        Return 0
    End Function
    Public Function MsgWrite()
        Console.WriteLine("Your  message : {0}", msg)
        Return 0
    End Function
End Class
