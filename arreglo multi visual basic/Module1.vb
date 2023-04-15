Module Module1

    Sub Main()


        Dim matriz As Integer(,) = New Integer(2, 2) {}
            matriz(0, 0) = 1
            matriz(0, 1) = 2
            matriz(0, 2) = 3
            matriz(1, 0) = 4
            matriz(1, 1) = 5
            matriz(1, 2) = 6
            matriz(2, 0) = 7
            matriz(2, 1) = 8
            matriz(2, 2) = 9

            For i As Integer = 0 To matriz.GetLength(0) - 1

                For j As Integer = 0 To matriz.GetLength(1) - 1
                    Console.Write(matriz(i, j) & " ")
                Next

                Console.WriteLine()
                Console.ReadKey()
            Next
        End Sub







End Module
