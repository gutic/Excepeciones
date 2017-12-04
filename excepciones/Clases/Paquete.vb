Imports Clases

Public Class Paquete
    Implements Producto
    Private _producto As List(Of Producto)
    Private _pasajero As List(Of Pasajero)
    Private _fechaFinal As Date
    Private _fecha As Date
    Private _descripcion As String

    Public Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            If Fecha >= value Then Throw New Exception("La fecha de vuelta debe ser posterior a la de ida")
            _fechaFinal = value
        End Set
    End Property

    Public ReadOnly Property NumeroDias As UShort
        Get
            Return DateDiff(DateInterval.Day, Fecha, FechaFinal)
        End Get
    End Property

    Public ReadOnly Property NumeroPasajeros As UShort
        Get
            Return _pasajero.Count
        End Get
    End Property

    Sub New(Descripcion As String, Fecha As Date, FechaFinal As Date)
        Me.Descripcion = Descripcion
        Me.Fecha = Fecha
        Me.FechaFinal = FechaFinal
        _pasajero = New List(Of Pasajero)
        _producto = New List(Of Producto)
    End Sub

    Public Sub addServicio(servicio As Producto)
        _producto.Add(servicio)
    End Sub

    Public Sub removeServicio(servicio As Producto)
        _producto.Remove(servicio)
    End Sub

    Public Function getAllservicios() As List(Of Producto)
        Return _producto
    End Function

    Public Sub addPasajero(pasajero As Pasajero)
        _pasajero.Add(pasajero)
    End Sub

    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajero
    End Function

    Public Overrides Function ToString() As String
        Dim salida As String
        salida = ""
        For Each Descripcion As Producto In getAllservicios()
            salida &= Descripcion.ToString() & ","
        Next
        Return salida
    End Function


    '____________________________________________ interfacer_____________________________

    Public Property Descripcion As String Implements Producto.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha As Date Implements Producto.Fecha
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value < Date.Today Then Throw New Exception("La reserva no puede ser para antes de hoy")
            If value = Date.Today Then Throw New Exception("La reserva no puede ser para hoy")
            _fecha = value
        End Set
    End Property

    Public Function costo() As Single Implements Producto.costo
        Dim total As Single
        For Each producto As Producto In getAllservicios()
            total += producto.costo
        Next
        Return total
    End Function
End Class
