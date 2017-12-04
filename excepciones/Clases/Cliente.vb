Public Class Cliente
    Inherits Pasajero
    Private _cuit_cuil As String
    Private _ventas As List(Of Venta)
    Public Property Cuit_cuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            _cuit_cuil = value
        End Set
    End Property
    Sub New(Pasajero As Pasajero, Cuit_cuil As String)
        MyBase.New(Pasajero.Dni, Pasajero.Nombre)
        Me.Cuit_cuil = Cuit_cuil
        _ventas = New List(Of Venta)
    End Sub
    Public Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
    Public Overrides Function ToString() As String
        Return Me.Nombre & ":" & Cuit_cuil
    End Function
    Public Sub addVenta(venta As Venta)
        venta.Cliente = Me
        _ventas.Add(venta)
    End Sub
End Class
