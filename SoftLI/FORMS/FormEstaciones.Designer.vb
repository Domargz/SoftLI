﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstaciones
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
        Me.LbNumeroEstacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNumero3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DGVEstaciones = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGVEstaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LbNumeroEstacion
        '
        Me.LbNumeroEstacion.AutoSize = True
        Me.LbNumeroEstacion.Location = New System.Drawing.Point(54, 64)
        Me.LbNumeroEstacion.Name = "LbNumeroEstacion"
        Me.LbNumeroEstacion.Size = New System.Drawing.Size(123, 13)
        Me.LbNumeroEstacion.TabIndex = 2
        Me.LbNumeroEstacion.Text = "NUMERO DE STACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NUMERO DE STACION"
        '
        'LblNumero3
        '
        Me.LblNumero3.AutoSize = True
        Me.LblNumero3.Location = New System.Drawing.Point(251, 63)
        Me.LblNumero3.Name = "LblNumero3"
        Me.LblNumero3.Size = New System.Drawing.Size(13, 13)
        Me.LblNumero3.TabIndex = 4
        Me.LblNumero3.Text = "3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 20)
        Me.TextBox1.TabIndex = 5
        '
        'DGVEstaciones
        '
        Me.DGVEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEstaciones.Location = New System.Drawing.Point(88, 203)
        Me.DGVEstaciones.Name = "DGVEstaciones"
        Me.DGVEstaciones.Size = New System.Drawing.Size(686, 163)
        Me.DGVEstaciones.TabIndex = 6
        '
        'FormEstaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVEstaciones)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblNumero3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbNumeroEstacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormEstaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEstaciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGVEstaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuGuardar As ToolStripMenuItem
    Friend WithEvents MenuModificar As ToolStripMenuItem
    Friend WithEvents MenuEliminar As ToolStripMenuItem
    Friend WithEvents MenuSalir As ToolStripMenuItem
    Friend WithEvents LbNumeroEstacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNumero3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGVEstaciones As DataGridView
End Class
