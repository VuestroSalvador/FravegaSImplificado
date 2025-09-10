Public Class Lavarropas
    Inherits Electro
    Public capacidad, consumo As Integer

    Public Sub New(capacidad As Integer, consumo As Integer)
        Me.capacidad = capacidad
        Me.consumo = consumo

    End Sub
    Public Sub New()

    End Sub

    Public Overrides Function preciodeventa()
        If Me.stock > 100 Then
            Return Me.preciocompra
        Else
            Return ((Me.preciocompra * 30) / 100) + Me.preciocompra
        End If
    End Function
End Class
