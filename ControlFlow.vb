Option Explicit On
Option Strict On
Option Compare Binary

Module ControlFlow

    Sub Main()
        'Dim firstNumber As Decimal
        'Dim secondNumber As Integer
        'firstNumber = 10
        'secondNumber = 8
        'If firstNumber > secondNumber Then
        '    Console.WriteLine("First Number is Bigger!!")
        'ElseIf firstNumber < secondNumber Then
        '    Console.WriteLine("Second Number is Bigger!!")
        'Else
        '    Console.WriteLine("The Numbers Are Equal!!")
        'End If

        Dim userInput As String
        Console.WriteLine("Type a word and press Enter")
        userInput = Console.ReadLine()

        'Console.WriteLine("you typed " & userInput)
        Console.WriteLine($"you typed {userInput}")

        Console.Read()

    End Sub

End Module
