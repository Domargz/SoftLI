<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpresa
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
        Me.TbRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbNombreComercial = New System.Windows.Forms.TextBox()
        Me.TxbDireccion = New System.Windows.Forms.TextBox()
        Me.TxbRFC = New System.Windows.Forms.TextBox()
        Me.TxbTelefono = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGuardar, Me.MenuModificar, Me.MenuEliminar, Me.MenuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'TbRazonSocial
        '
        Me.TbRazonSocial.Location = New System.Drawing.Point(256, 61)
        Me.TbRazonSocial.Name = "TbRazonSocial"
        Me.TbRazonSocial.Size = New System.Drawing.Size(226, 20)
        Me.TbRazonSocial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOMBRE COMERCIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RAZON SOCIAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(681, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DERECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TELEFONO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "RFC"
        '
        'TxbNombreComercial
        '
        Me.TxbNombreComercial.Location = New System.Drawing.Point(256, 105)
        Me.TxbNombreComercial.Name = "TxbNombreComercial"
        Me.TxbNombreComercial.Size = New System.Drawing.Size(226, 20)
        Me.TxbNombreComercial.TabIndex = 2
        '
        'TxbDireccion
        '
        Me.TxbDireccion.Location = New System.Drawing.Point(256, 141)
        Me.TxbDireccion.Name = "TxbDireccion"
        Me.TxbDireccion.Size = New System.Drawing.Size(226, 20)
        Me.TxbDireccion.TabIndex = 3
        '
        'TxbRFC
        '
        Me.TxbRFC.Location = New System.Drawing.Point(256, 215)
        Me.TxbRFC.Name = "TxbRFC"
        Me.TxbRFC.Size = New System.Drawing.Size(226, 20)
        Me.TxbRFC.TabIndex = 5
        '
        'TxbTelefono
        '
        Me.TxbTelefono.Location = New System.Drawing.Point(256, 183)
        Me.TxbTelefono.Name = "TxbTelefono"
        Me.TxbTelefono.Size = New System.Drawing.Size(226, 20)
        Me.TxbTelefono.TabIndex = 4
        '
        'FormEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxbTelefono)
        Me.Controls.Add(Me.TxbRFC)
        Me.Controls.Add(Me.TxbDireccion)
        Me.Controls.Add(Me.TxbNombreComercial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TbRazonSocial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEmpresa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuGuardar As ToolStripMenuItem
    Friend WithEvents MenuModificar As ToolStripMenuItem
    Friend WithEvents MenuEliminar As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents TbRazonSocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbNombreComercial As TextBox
    Friend WithEvents TxbDireccion As TextBox
    Friend WithEvents TxbRFC As TextBox
    Friend WithEvents TxbTelefono As TextBox
End Class
