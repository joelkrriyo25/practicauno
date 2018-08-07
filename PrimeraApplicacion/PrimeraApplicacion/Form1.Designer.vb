<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejemplo1
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.btn_mensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_titulo.Location = New System.Drawing.Point(199, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(75, 15)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Laboratorio 1"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Location = New System.Drawing.Point(126, 41)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(288, 20)
        Me.txt_Mensaje.TabIndex = 1
        '
        'btn_mensaje
        '
        Me.btn_mensaje.Location = New System.Drawing.Point(189, 67)
        Me.btn_mensaje.Name = "btn_mensaje"
        Me.btn_mensaje.Size = New System.Drawing.Size(108, 33)
        Me.btn_mensaje.TabIndex = 2
        Me.btn_mensaje.Text = "Mensaje"
        Me.btn_mensaje.UseVisualStyleBackColor = True
        '
        'Ejemplo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 333)
        Me.Controls.Add(Me.btn_mensaje)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Ejemplo1"
        Me.Text = "Ejemplo1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_Mensaje As System.Windows.Forms.TextBox
    Friend WithEvents btn_mensaje As System.Windows.Forms.Button

End Class
