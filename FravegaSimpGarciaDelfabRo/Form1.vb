Public Class Form1
    Dim preciocompra As Integer
    Dim cantidadcomprada As Integer
    Dim precioventa As Integer
    Dim cantidadventa As Integer

    Dim heladera1 As Heladera = New Heladera()
    Dim lavarropas1 As Lavarropas = New Lavarropas()
    Private Sub RdBtnLavarropas_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnLavarropas.CheckedChanged
        TxtBxColor.Enabled = False
        TxtBxColor.Text = "Blanco"
    End Sub

    Private Sub RdBtnHeladera_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnHeladera.CheckedChanged
        TxtBxColor.Enabled = True
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        If (RdBtnHeladera.Checked = True) Then
            heladera1.modelo = TxtBxModelo.Text
            heladera1.descripcion = TxtBxDescripcion.Text
            heladera1.color = TxtBxColor.Text
            heladera1.capacidad = TxtBxCapacidad.Text
            heladera1.consumo = TxtBxConsumo.Text
            RdBtnLavarropas.Enabled = False
        End If
        If (RdBtnLavarropas.Checked = True) Then
            lavarropas1.modelo = TxtBxModelo.Text
            lavarropas1.descripcion = TxtBxDescripcion.Text
            lavarropas1.capacidad = TxtBxCapacidad.Text
            lavarropas1.consumo = TxtBxConsumo.Text
            RdBtnHeladera.Enabled = False
        End If
        BtnComprar.Enabled = True
        BtnVender.Enabled = True
    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        preciocompra = TxtBxPreciocompra.Text
        cantidadcomprada = TxtBxCantidadCompra.Text
        If (RdBtnHeladera.Checked = True) Then
            heladera1.comprar(preciocompra, cantidadcomprada)
            MsgBox("Se Han Comprado " & cantidadcomprada.ToString() & " Heladeras Correctamente")
            TxtBxStock.Text = heladera1.stock
        End If
        If (RdBtnLavarropas.Checked = True) Then
            lavarropas1.comprar(preciocompra, cantidadcomprada)
            MsgBox("Se Han Comprado " & cantidadcomprada.ToString() & " Lavarropas Correctamente")
            TxtBxStock.Text = lavarropas1.stock
        End If
    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click
        cantidadventa = TxtBxCantidadVenta.Text
        If (RdBtnHeladera.Checked = True) Then
            MsgBox(heladera1.vender(cantidadventa))
            TxtBxPrecioVenta.Text = heladera1.preciodeventa().ToString()
            TxtBxStock.Text = heladera1.stock
        End If
        If (RdBtnLavarropas.Checked = True) Then
            MsgBox(lavarropas1.vender(cantidadventa))
            TxtBxPrecioVenta.Text = lavarropas1.preciodeventa().ToString()
            TxtBxStock.Text = lavarropas1.stock
        End If

    End Sub


End Class
