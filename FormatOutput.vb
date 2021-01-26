Option Explicit On
Option Strict On

Module FormatOutput

    Sub main()

        Dim temp As String

        For j = 0 To 10
            For i = 0 To 15
                temp = i.ToString("D3")
                'Console.WriteLine($"The string: {temp.PadLeft(7)} is {Len(temp)} characters long")
                If i = 5 Then
                    temp = ""
                End If
                Console.Write(temp.PadRight(5))
            Next
            Console.WriteLine()
        Next
        Console.Read()

    End Sub

End Module
