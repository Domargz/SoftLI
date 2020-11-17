Public Class LoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = Usuario.Usuario And PasswordTextBox.Text = Usuario.Clave Then
            estatusCaja = False
            FrmPrincipal.Hide()
            FrmPrincipal.Show()
        Else
            MsgBox("Datos incorrectos")
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub


    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub


    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK.Focus()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario.llenarDatosDeUsuario()

    End Sub
End Class
