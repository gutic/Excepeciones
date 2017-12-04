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

        Dim ciudad1 As New Ciudad("cancun")
        Dim ciudad2 As New Ciudad("encarnayork")
        Dim hotel1 As New Hotel("hotel1", #10/10/2017#, ciudad1, 2, 10)
        Console.WriteLine(hotel1.Montodiario & "ciudad: " & hotel1.ToString)
        Dim pasaje1 As New Pasaje("pasaje1", #10/10/2017#, 50, ciudad1, ciudad2)
        Console.WriteLine(pasaje1.ToString)
    End Sub
End Module
