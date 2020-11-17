Public Class FormAperturaCaja
    Private Sub MenuAbrirCaja_Click(sender As Object, e As EventArgs) Handles MenuAbrirCaja.Click
        estatusCaja = True
        MsgBox("Caja abierta existosamente")
    End Sub

    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        Me.Close()
    End Sub
End Class