Public Class FormEmpresa


    Private Sub FormEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "DATOS DE LA EMPRESA // " & Empresa.nombreComercial
    End Sub

    Private Sub TbRazonSocial_KeyDown(sender As Object, e As KeyEventArgs) Handles TbRazonSocial.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbNombreComercial.Focus()
        End If
    End Sub

    Private Sub TxbNombreComercial_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbNombreComercial.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbDireccion.Focus()
        End If
    End Sub
    Private Sub TxbDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbTelefono.Focus()
        End If
    End Sub
    Private Sub TxbTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbTelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbRFC.Focus()
        End If
    End Sub
    Private Sub TxbRFC_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbRFC.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Consultar a base de datos y poner la informacion en la grid.
        End If
    End Sub
End Class