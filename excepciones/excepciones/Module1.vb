Imports Clases

Module Module1

    Sub Main()
        'Dim algo As Integer
        'Console.WriteLine("algo " & algo)
        'algo = clase1.sumar(3, 2)
        'Console.WriteLine("algo " & algo)

        Dim ValorRandom As New Random
        For index = 1 To 100 Step 10
            Console.WriteLine("El mayor es: " & mayor(ValorRandom.Next(0, 100), index))
        Next

    End Sub
    Function mayor(a, b)
        If a > b Then
            Return a
        Else
            Return b
        End If
    End Function
End Module
