Public Class FormCierreDeCaja
    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        Me.Close()
    End Sub

    Private Sub MenuCerrarCaja_Click(sender As Object, e As EventArgs) Handles MenuCerrarCaja.Click
        estatusCaja = False
        MsgBox("Caja cerrada, existosamete")
    End Sub
End Class