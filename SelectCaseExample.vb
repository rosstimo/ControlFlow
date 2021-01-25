Module SelectCaseExample

    Sub main()

        Dim temp As String = "6"
        'If statement evaluating a single variable
        If temp = "1" Then
            'do stuff for "1" input
            Console.WriteLine("If 1")
        ElseIf temp = "2" Then
            'do stuff for "2" input
            Console.WriteLine("If 2")
        ElseIf temp = "3" Then
            'do stuff for "3" input
            Console.WriteLine("If 3")
        Else
            'do stuff for any other input
            Console.WriteLine("If other")
        End If

        'select case evaluating a variable
        Select Case temp
            Case = "1"
                'do stuff for "1" input
                Console.WriteLine("Case 1")
            Case = "2"
                'do stuff for "2" input
                Console.WriteLine("Case 2")
            Case = "3"
                'do stuff for "3" input
                Console.WriteLine("Case 3")
            Case Else
                'do stuff for any other input
                Console.WriteLine("Case other")
        End Select

        Console.WriteLine("hello")

        Console.Read()
    End Sub

End Module
