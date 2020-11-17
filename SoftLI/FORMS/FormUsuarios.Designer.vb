<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvUuarios = New System.Windows.Forms.DataGridView()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.LblNumeroUsuario = New System.Windows.Forms.Label()
        Me.LbUusario = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.TbClave = New System.Windows.Forms.TextBox()
        Me.LbClave = New System.Windows.Forms.Label()
        Me.TbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TbTipoUsuario = New System.Windows.Forms.TextBox()
        Me.lbTipoUsuario = New System.Windows.Forms.Label()
        Me.TbMaterno = New System.Windows.Forms.TextBox()
        Me.LbMaterno = New System.Windows.Forms.Label()
        Me.TbPaterno = New System.Windows.Forms.TextBox()
        Me.LbPaterno = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvUuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGuardar, Me.MenuModificar, Me.MenuEliminar, Me.MenuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuGuardar
        '
        Me.MenuGuardar.Name = "MenuGuardar"
        Me.MenuGuardar.Size = New System.Drawing.Size(73, 20)
        Me.MenuGuardar.Text = "GUARDAR"
        '
        'MenuModificar
        '
        Me.MenuModificar.Name = "MenuModificar"
        Me.MenuModificar.Size = New System.Drawing.Size(82, 20)
        Me.MenuModificar.Text = "MODIFICAR"
        '
        'MenuEliminar
        '
        Me.MenuEliminar.Name = "MenuEliminar"
        Me.MenuEliminar.Size = New System.Drawing.Size(72, 20)
        Me.MenuEliminar.Text = "ELIMINAR"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(49, 20)
        Me.MenuSalir.Text = "SALIR"
        '
        'DgvUuarios
        '
        Me.DgvUuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUuarios.Location = New System.Drawing.Point(43, 257)
        Me.DgvUuarios.Name = "DgvUuarios"
        Me.DgvUuarios.Size = New System.Drawing.Size(686, 163)
        Me.DgvUuarios.TabIndex = 11
        '
        'TbUsuario
        '
        Me.TbUsuario.Location = New System.Drawing.Point(240, 81)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(226, 20)
        Me.TbUsuario.TabIndex = 1
        '
        'LblNumeroUsuario
        '
        Me.LblNumeroUsuario.AutoSize = True
        Me.LblNumeroUsuario.Location = New System.Drawing.Point(313, 49)
        Me.LblNumeroUsuario.Name = "LblNumeroUsuario"
        Me.LblNumeroUsuario.Size = New System.Drawing.Size(13, 13)
        Me.LblNumeroUsuario.TabIndex = 9
        Me.LblNumeroUsuario.Text = "3"
        '
        'LbUusario
        '
        Me.LbUusario.AutoSize = True
        Me.LbUusario.Location = New System.Drawing.Point(49, 78)
        Me.LbUusario.Name = "LbUusario"
        Me.LbUusario.Size = New System.Drawing.Size(56, 13)
        Me.LbUusario.TabIndex = 1
        Me.LbUusario.Text = "USUARIO"
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Location = New System.Drawing.Point(116, 50)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(125, 13)
        Me.LbUsuario.TabIndex = 7
        Me.LbUsuario.Text = "NUMERO DE USUARIO"
        '
        'TbClave
        '
        Me.TbClave.Location = New System.Drawing.Point(240, 107)
        Me.TbClave.Name = "TbClave"
        Me.TbClave.Size = New System.Drawing.Size(226, 20)
        Me.TbClave.TabIndex = 2
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.Location = New System.Drawing.Point(49, 104)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(41, 13)
        Me.LbClave.TabIndex = 13
        Me.LbClave.Text = "CLAVE"
        '
        'TbNombreUsuario
        '
        Me.TbNombreUsuario.Location = New System.Drawing.Point(240, 133)
        Me.TbNombreUsuario.Name = "TbNombreUsuario"
        Me.TbNombreUsuario.Size = New System.Drawing.Size(226, 20)
        Me.TbNombreUsuario.TabIndex = 3
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(49, 130)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(124, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "NOMBRE DE USUARIO"
        '
        'TbTipoUsuario
        '
        Me.TbTipoUsuario.Location = New System.Drawing.Point(240, 211)
        Me.TbTipoUsuario.Name = "TbTipoUsuario"
        Me.TbTipoUsuario.Size = New System.Drawing.Size(226, 20)
        Me.TbTipoUsuario.TabIndex = 6
        '
        'lbTipoUsuario
        '
        Me.lbTipoUsuario.AutoSize = True
        Me.lbTipoUsuario.Location = New System.Drawing.Point(49, 211)
        Me.lbTipoUsuario.Name = "lbTipoUsuario"
        Me.lbTipoUsuario.Size = New System.Drawing.Size(102, 13)
        Me.lbTipoUsuario.TabIndex = 6
        Me.lbTipoUsuario.Text = "TIPO DE USUARIO"
        '
        'TbMaterno
        '
        Me.TbMaterno.Location = New System.Drawing.Point(240, 185)
        Me.TbMaterno.Name = "TbMaterno"
        Me.TbMaterno.Size = New System.Drawing.Size(226, 20)
        Me.TbMaterno.TabIndex = 5
        '
        'LbMaterno
        '
        Me.LbMaterno.AutoSize = True
        Me.LbMaterno.Location = New System.Drawing.Point(49, 183)
        Me.LbMaterno.Name = "LbMaterno"
        Me.LbMaterno.Size = New System.Drawing.Size(116, 13)
        Me.LbMaterno.TabIndex = 5
        Me.LbMaterno.Text = "APELLIDO MATERNO"
        '
        'TbPaterno
        '
        Me.TbPaterno.Location = New System.Drawing.Point(240, 159)
        Me.TbPaterno.Name = "TbPaterno"
        Me.TbPaterno.Size = New System.Drawing.Size(226, 20)
        Me.TbPaterno.TabIndex = 4
        '
        'LbPaterno
        '
        Me.LbPaterno.AutoSize = True
        Me.LbPaterno.Location = New System.Drawing.Point(49, 158)
        Me.LbPaterno.Name = "LbPaterno"
        Me.LbPaterno.Size = New System.Drawing.Size(114, 13)
        Me.LbPaterno.TabIndex = 4
        Me.LbPaterno.Text = "APELLIDO PATERNO"
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TbPaterno)
        Me.Controls.Add(Me.LbPaterno)
        Me.Controls.Add(Me.TbMaterno)
        Me.Controls.Add(Me.LbMaterno)
        Me.Controls.Add(Me.TbTipoUsuario)
        Me.Controls.Add(Me.lbTipoUsuario)
        Me.Controls.Add(Me.TbNombreUsuario)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.TbClave)
        Me.Controls.Add(Me.LbClave)
        Me.Controls.Add(Me.DgvUuarios)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.LblNumeroUsuario)
        Me.Controls.Add(Me.LbUusario)
        Me.Controls.Add(Me.LbUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUsuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvUuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuGuardar As ToolStripMenuItem
    Friend WithEvents MenuModificar As ToolStripMenuItem
    Friend WithEvents MenuEliminar As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents DgvUuarios As DataGridView
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents LblNumeroUsuario As Label
    Friend WithEvents LbUusario As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents TbClave As TextBox
    Friend WithEvents LbClave As Label
    Friend WithEvents TbNombreUsuario As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents TbTipoUsuario As TextBox
    Friend WithEvents lbTipoUsuario As Label
    Friend WithEvents TbMaterno As TextBox
    Friend WithEvents LbMaterno As Label
    Friend WithEvents TbPaterno As TextBox
    Friend WithEvents LbPaterno As Label
End Class
