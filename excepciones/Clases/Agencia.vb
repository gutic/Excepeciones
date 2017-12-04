Public Class Agencia
    Private Shared _venta As List(Of Venta)
    Shared Sub New()
        _venta = New List(Of Venta)
    End Sub
    Public Shared Sub addVenta(Venta As Venta)
        _venta.Add(Venta)
    End Sub
    Public Shared Sub removeVenta(venta As Venta)
        _venta.Remove(venta)
    End Sub
    Public Shared Function getAllVentas() As List(Of Venta)
        Return _venta
    End Function
End Class
