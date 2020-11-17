<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.LbPrecio = New System.Windows.Forms.Label()
        Me.TbCosto = New System.Windows.Forms.TextBox()
        Me.LbCosto = New System.Windows.Forms.Label()
        Me.TbClaveProductos = New System.Windows.Forms.TextBox()
        Me.LbClave = New System.Windows.Forms.Label()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.TbCodigo = New System.Windows.Forms.TextBox()
        Me.LbNumeroUsuario = New System.Windows.Forms.Label()
        Me.LbNumProducto = New System.Windows.Forms.Label()
        Me.LbCodigo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(254, 150)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(226, 20)
        Me.TbPrecio.TabIndex = 4
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.Location = New System.Drawing.Point(63, 149)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(47, 13)
        Me.LbPrecio.TabIndex = 6
        Me.LbPrecio.Text = "PRECIO"
        '
        'TbCosto
        '
        Me.TbCosto.Location = New System.Drawing.Point(254, 124)
        Me.TbCosto.Name = "TbCosto"
        Me.TbCosto.Size = New System.Drawing.Size(226, 20)
        Me.TbCosto.TabIndex = 3
        '
        'LbCosto
        '
        Me.LbCosto.AutoSize = True
        Me.LbCosto.Location = New System.Drawing.Point(63, 121)
        Me.LbCosto.Name = "LbCosto"
        Me.LbCosto.Size = New System.Drawing.Size(44, 13)
        Me.LbCosto.TabIndex = 5
        Me.LbCosto.Text = "COSTO"
        '
        'TbClaveProductos
        '
        Me.TbClaveProductos.Location = New System.Drawing.Point(254, 98)
        Me.TbClaveProductos.Name = "TbClaveProductos"
        Me.TbClaveProductos.Size = New System.Drawing.Size(226, 20)
        Me.TbClaveProductos.TabIndex = 2
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.Location = New System.Drawing.Point(63, 95)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(41, 13)
        Me.LbClave.TabIndex = 4
        Me.LbClave.Text = "CLAVE"
        '
        'DgvProductos
        '
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Location = New System.Drawing.Point(57, 248)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.Size = New System.Drawing.Size(686, 163)
        Me.DgvProductos.TabIndex = 27
        '
        'TbCodigo
        '
        Me.TbCodigo.Location = New System.Drawing.Point(254, 72)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(226, 20)
        Me.TbCodigo.TabIndex = 1
        '
        'LbNumeroUsuario
        '
        Me.LbNumeroUsuario.AutoSize = True
        Me.LbNumeroUsuario.Location = New System.Drawing.Point(327, 40)
        Me.LbNumeroUsuario.Name = "LbNumeroUsuario"
        Me.LbNumeroUsuario.Size = New System.Drawing.Size(13, 13)
        Me.LbNumeroUsuario.TabIndex = 2
        Me.LbNumeroUsuario.Text = "0"
        '
        'LbNumProducto
        '
        Me.LbNumProducto.AutoSize = True
        Me.LbNumProducto.Location = New System.Drawing.Point(130, 41)
        Me.LbNumProducto.Name = "LbNumProducto"
        Me.LbNumProducto.Size = New System.Drawing.Size(144, 13)
        Me.LbNumProducto.TabIndex = 1
        Me.LbNumProducto.Text = "NUMERO DE PRODUCTOS"
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.Location = New System.Drawing.Point(63, 69)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(49, 13)
        Me.LbCodigo.TabIndex = 3
        Me.LbCodigo.Text = "CODIGO"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TbPrecio)
        Me.Controls.Add(Me.LbPrecio)
        Me.Controls.Add(Me.TbCosto)
        Me.Controls.Add(Me.LbCosto)
        Me.Controls.Add(Me.TbClaveProductos)
        Me.Controls.Add(Me.LbClave)
        Me.Controls.Add(Me.DgvProductos)
        Me.Controls.Add(Me.TbCodigo)
        Me.Controls.Add(Me.LbNumeroUsuario)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me.LbNumProducto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProductos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuGuardar As ToolStripMenuItem
    Friend WithEvents MenuModificar As ToolStripMenuItem
    Friend WithEvents MenuEliminar As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents LbPrecio As Label
    Friend WithEvents TbCosto As TextBox
    Friend WithEvents LbCosto As Label
    Friend WithEvents TbClaveProductos As TextBox
    Friend WithEvents LbClave As Label
    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents TbCodigo As TextBox
    Friend WithEvents LbNumeroUsuario As Label
    Friend WithEvents LbNumProducto As Label
    Friend WithEvents LbCodigo As Label
End Class
