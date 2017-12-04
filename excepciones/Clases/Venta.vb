﻿Public Class Venta
    'bidireccional con cliente. cliente encargado de la asignacion
    Private _fecha As Date
    Private _cliente As Cliente
    Private _producto As Producto
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Friend Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    Sub New()
        _fecha = Nothing
    End Sub
    Public Function montoTotal() As Single
        Return _producto.costo
    End Function
    Public Overrides Function ToString() As String
        Return _cliente.Nombre & ":" & Fecha
    End Function
End Class
