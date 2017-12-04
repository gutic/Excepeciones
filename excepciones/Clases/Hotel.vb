Imports Clases

Public Class Hotel
    Implements Producto
    Private _habitaciones As Byte
    Private _noches As Byte
    Private _montodiario As Single
    Private _descripcion As String
    Private _fecha As Date
    Private _ciudad As Ciudad

    Public Property Ciudad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
    End Property
    Public Property Habitaciones As Byte
        Get
            Return _habitaciones
        End Get
        Set(value As Byte)
            _habitaciones = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Public Property Montodiario As Single
        Get
            Return _montodiario
        End Get
        Set(value As Single)
            _montodiario = value
        End Set
    End Property

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
            _fecha = value
        End Set
    End Property

    Sub New(descripcion As String, fecha As Date, ciudad As Ciudad, noches As Byte, montodiario As Single)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.Ciudad = ciudad
        Me.Noches = noches
        Me.Montodiario = montodiario
        Habitaciones = 0
    End Sub

    Public Overrides Function ToString() As String
        Return Montodiario & ":" & Noches & "ciudad: " & Ciudad.Nombre
    End Function

    Public Function costo() As Single Implements Producto.costo
        Return Montodiario * Noches
    End Function
End Class
