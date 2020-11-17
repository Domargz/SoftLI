<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.CAJASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAperturaCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCorteCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCierreCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPuntodeVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEstacionesDeTrabajo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CAJASToolStripMenuItem, Me.MenuPuntodeVenta, Me.MenuEmpresa, Me.MenuUsuario, Me.MenuProductos, Me.MenuEstacionesDeTrabajo, Me.MenuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CAJASToolStripMenuItem
        '
        Me.CAJASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAperturaCaja, Me.MenuCierreCaja, Me.MenuCorteCaja})
        Me.CAJASToolStripMenuItem.Name = "CAJASToolStripMenuItem"
        Me.CAJASToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.CAJASToolStripMenuItem.Text = "CAJAS"
        '
        'MenuAperturaCaja
        '
        Me.MenuAperturaCaja.Name = "MenuAperturaCaja"
        Me.MenuAperturaCaja.Size = New System.Drawing.Size(182, 22)
        Me.MenuAperturaCaja.Text = "APERTURA DE CAJA "
        '
        'MenuCorteCaja
        '
        Me.MenuCorteCaja.Name = "MenuCorteCaja"
        Me.MenuCorteCaja.Size = New System.Drawing.Size(182, 22)
        Me.MenuCorteCaja.Text = "CORTE DE CAJA"
        '
        'MenuCierreCaja
        '
        Me.MenuCierreCaja.Name = "MenuCierreCaja"
        Me.MenuCierreCaja.Size = New System.Drawing.Size(182, 22)
        Me.MenuCierreCaja.Text = "CIERRE DE CAJA "
        '
        'MenuPuntodeVenta
        '
        Me.MenuPuntodeVenta.Name = "MenuPuntodeVenta"
        Me.MenuPuntodeVenta.Size = New System.Drawing.Size(112, 20)
        Me.MenuPuntodeVenta.Text = "PUNTO DE VENTA"
        '
        'MenuEmpresa
        '
        Me.MenuEmpresa.Name = "MenuEmpresa"
        Me.MenuEmpresa.Size = New System.Drawing.Size(70, 20)
        Me.MenuEmpresa.Text = "EMPRESA"
        '
        'MenuUsuario
        '
        Me.MenuUsuario.Name = "MenuUsuario"
        Me.MenuUsuario.Size = New System.Drawing.Size(74, 20)
        Me.MenuUsuario.Text = "USUARIOS"
        '
        'MenuProductos
        '
        Me.MenuProductos.Name = "MenuProductos"
        Me.MenuProductos.Size = New System.Drawing.Size(86, 20)
        Me.MenuProductos.Text = "PRODUCTOS"
        '
        'MenuEstacionesDeTrabajo
        '
        Me.MenuEstacionesDeTrabajo.Name = "MenuEstacionesDeTrabajo"
        Me.MenuEstacionesDeTrabajo.Size = New System.Drawing.Size(155, 20)
        Me.MenuEstacionesDeTrabajo.Text = "ESTACIONES DE TRABAJO"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(49, 20)
        Me.MenuSalir.Text = "SALIR"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuPuntodeVenta As ToolStripMenuItem
    Friend WithEvents MenuEmpresa As ToolStripMenuItem
    Friend WithEvents MenuUsuario As ToolStripMenuItem
    Friend WithEvents MenuProductos As ToolStripMenuItem
    Friend WithEvents MenuEstacionesDeTrabajo As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents CAJASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAperturaCaja As ToolStripMenuItem
    Friend WithEvents MenuCorteCaja As ToolStripMenuItem
    Friend WithEvents MenuCierreCaja As ToolStripMenuItem
End Class
