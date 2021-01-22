Option Strict On
Option Explicit On

Module LoopExamples

    Sub main()
        Dim someText As String
        Dim countBy As Integer = 1
        'For index As Integer = 0 To 10

        'For i = 0 To 10 Step countBy
        '    someText &= "*"
        '    Console.WriteLine(someText)
        '    If i >= 9 Then
        '        countBy = -1
        '    End If
        'Next

        'For i = 0 To 10
        '    Console.WriteLine("*")
        '    For j = 0 To 10
        '        Console.Write(j)
        '    Next
        'Next

        Dim loopCount As Integer = 1
        Dim countUp As Boolean = True

        While loopCount < 10

            If loopCount = 0 Then
                Exit While
            End If

            Console.WriteLine(StrDup(loopCount, "*"))

            If loopCount >= 9 Then
                countUp = False
            End If

            If countUp Then
                loopCount += 1
            Else
                loopCount -= 1
            End If

        End While

        Console.ReadLine()
    End Sub

End Module
