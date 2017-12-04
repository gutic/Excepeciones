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
        Dim pasajero1 As New Pasajero(99999, "pepe")
        Dim cliente1 As New Cliente(pasajero1, 12345)
        Try
            Console.WriteLine("fecha ida 15/01/2018, fecha vuelta 01/01/2018")
            Dim paquete2 As New Paquete("viaje en el tiempo", #01/15/2018#, #01/01/2018#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Try
            Console.WriteLine("fecha de ida: hoy")
            Dim paquete3 As New Paquete("viaje rush", Date.Today, #11/20/2017#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("fecha ida 10/10/2017, fecha vuelta 17/10/2017")
            Dim paquete4 As New Paquete("viajecito", #10/10/2017#, #10/17/2017#)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()


    End Sub
End Module
