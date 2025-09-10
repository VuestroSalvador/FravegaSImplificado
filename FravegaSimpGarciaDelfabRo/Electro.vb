Public Class Electro
    Public modelo, descripcion As String
    Public stock, preciocompra As Integer

    Public Sub New(modelo As String, desc As String)
        Me.modelo = modelo
        Me.descripcion = desc

    End Sub

    Public Sub New()

    End Sub

    Public Function comprar(preciocompra As Integer, cantcomprada As Integer)
        Me.preciocompra = preciocompra
        Me.stock = Me.stock + cantcomprada
    End Function

    Public Function vender(cantidadvender As Integer)
        If (cantidadvender <= Me.stock) Then
            Me.stock = Me.stock - cantidadvender
            Return "Se Realizo La Venta Correctamente"
        Else
            Return "No Se Puede Realizar La venta (Stock Insuficiente)"
        End If
    End Function

    Public Overridable Function preciodeventa()
        Return ((Me.preciocompra * 20) / 100) + Me.preciocompra
    End Function
End Class
