Imports Clases

Module tryDivision
    Sub Main()
        Dim a, b As Decimal
        a = 100
        b = 0
        Dim operacionDividir As New dividir
        Try
            Console.WriteLine("Resultado: " & operacionDividir.Dividir(a, b))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

    End Sub
End Module
