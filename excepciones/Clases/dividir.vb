﻿Public Class dividir
    Private mDividendo As Decimal
    Private mDivisor As Decimal

    Public Function Dividir(ByVal valor1 As Decimal, ByVal valor2 As Decimal) As Decimal
        If valor1 <= 0 Or valor1 > 1000 Then
            Throw New ArgumentException("Dividendo invalido")
        End If
        If valor2 <= 0 Or valor2 > 1000 Then
            Throw New ArgumentException("Divisor invalido")
        End If
        mDividendo = valor1
        mDivisor = valor2
        Return mDividendo / mDivisor
    End Function

End Class
