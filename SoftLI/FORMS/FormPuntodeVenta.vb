Public Class FormPuntodeVenta
    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        Me.Close()

    End Sub

    Private Sub FormPuntodeVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "PUNTO DE VENTA SOFT-LI VERSION 1.0 COPYRIGHT 2020 //" & Empresa.nombreComercial & "USUARIO: " & Usuario.Usuario
    End Sub
End Class