Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET 0265
'Fall 2020
'multiplication table
'https://github.com/colelane/MultiplicationTableLC.git

Module MultiplicationTableLC
    Sub Main()
        Dim m, quit As String
        Dim n, column, row As Integer
        Dim data(12, 12) As Integer
        Dim goodData As Boolean

        Console.WriteLine("Press Q at any time to quit.")

        'The multiplaction table was done in 10 lines of code, the rest of it is making sure the user can't break it. 
        Do
            Do
                Console.BackgroundColor = ConsoleColor.Black
                Console.WriteLine("Enter a number")
                Try
                    m = Console.ReadLine()
                    n = CInt(m)
                    If n < 13 And n > 0 Then
                        goodData = True
                    Else
                        Console.Clear()
                        Console.BackgroundColor = ConsoleColor.DarkMagenta
                        Console.WriteLine("Only 1 - 12 will work! ")
                        goodData = False
                    End If
                Catch
                    If m = ("Q") Then
                        Exit Sub
                    End If
                    goodData = False
                    Console.Clear()
                    Console.BackgroundColor = ConsoleColor.DarkMagenta
                    Console.WriteLine("Only 1 - 12 will work! ")
                End Try
            Loop Until goodData = True

            Console.WriteLine($"Enjoy your  {n}  *  {n}  multiplication table! {vbNewLine}")

            'This nested for loop writes the multiplication table horizontally line by line.
            For column = 1 To n
                For row = 1 To n
                    data(row, column) = row * column
                    Console.Write(data(row, column) & vbTab)
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("Press Enter to start over, or press q to quit")
            quit = Console.ReadLine
            If quit = "q" Then
                Exit Sub
            End If
            Console.Clear()

        Loop
    End Sub



End Module
