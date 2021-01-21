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


        'Dim userInput As String
        'Console.WriteLine("Type a word and press Enter")
        'userInput = Console.ReadLine()

        'Console.WriteLine("you typed " & userInput)
        'Console.WriteLine($"you typed {userInput}")




        'Dim firstNumber As String
        'Dim secondNumber As String
        'Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim problem As Boolean = False

        Console.WriteLine("enter a number")
        Try
            userInput = Console.ReadLine()
            firstNumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"I need a number. you entered {userInput}")
            problem = True
        End Try

        Console.WriteLine("enter a number")
        Try
            userInput = Console.ReadLine()
            secondNumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"I need a number. you entered {userInput}")
            problem = True
        End Try

        If problem = True Then
            Console.Clear()
            Console.WriteLine("Sorry try again later...")
            Console.WriteLine("Have a nice day...")
        Else
            'otherwise do the math and display the result
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        End If

        Console.Read()

    End Sub

End Module
