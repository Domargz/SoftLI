Public Class FrmPrincipal

    Private Sub MenuPuntodeVenta_Click(sender As Object, e As EventArgs) Handles MenuPuntodeVenta.Click
        If estatusCaja = True Then
            FormPuntodeVenta.Hide()
            FormPuntodeVenta.Show()
        Else
            MsgBox("No esta abierta la caja aun")
        End If
    End Sub

    Private Sub MenuEmpresa_Click(sender As Object, e As EventArgs) Handles MenuEmpresa.Click
        FormEmpresa.Hide()
        FormEmpresa.Show()

    End Sub

    Private Sub MenuUsuario_Click(sender As Object, e As EventArgs) Handles MenuUsuario.Click
        FormUsuarios.Hide()
        FormUsuarios.Show()

    End Sub

    Private Sub MenuProductos_Click(sender As Object, e As EventArgs) Handles MenuProductos.Click
        FormProductos.Hide()
        FormProductos.Show()

    End Sub

    Private Sub MenuEstacionesDeTrabajo_Click(sender As Object, e As EventArgs) Handles MenuEstacionesDeTrabajo.Click
        FormEstaciones.Hide()
        FormEstaciones.Show()

    End Sub

    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        End
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Empresa.llenarDatosEmpresa()
        Me.Text = "PUNTO DE VENTA SOFT-LI VERSION 1.0 COPYRIGHT 2020 //" & Empresa.nombreComercial & "USUARIO: " & Usuario.Usuario
    End Sub

    Private Sub MenuAperturaCaja_Click(sender As Object, e As EventArgs) Handles MenuAperturaCaja.Click
        If estatusCaja = False Then
            FormAperturaCaja.Hide()
            FormAperturaCaja.Show()
        Else
            MsgBox("Caja abierta")
        End If
    End Sub

    Private Sub MenuCierreCaja_Click(sender As Object, e As EventArgs) Handles MenuCierreCaja.Click
        If estatusCaja = True Then
            FormCierreDeCaja.Hide()
            FormCierreDeCaja.Show()
        Else
            MsgBox("No esta abierta la caja")
        End If

    End Sub

    Private Sub MenuCorteCaja_Click(sender As Object, e As EventArgs) Handles MenuCorteCaja.Click
        If estatusCaja = True Then
            FormCorteDeCaja.Hide()
            FormCorteDeCaja.Show()
        Else
            MsgBox("Caja cerrada")
        End If

    End Sub


End Class