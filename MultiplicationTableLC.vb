Module MultiplicationTableLC

    Sub Main()
        Dim numbers As String
        Dim n, column, row As Integer
        Dim data(12, 12) As Integer


        'populating the array
        Do
            Console.WriteLine("Enter a number")
            n = CInt(Console.ReadLine)

            For column = 1 To n
                For row = 1 To n
                    data(row, column) = row * column
                    Console.Write(data(row, column) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadLine()
            Console.Clear()
        Loop
    End Sub



End Module
