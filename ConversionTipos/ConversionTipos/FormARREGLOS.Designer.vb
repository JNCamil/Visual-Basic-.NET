<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormARREGLOS
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 138)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MOSTRAR DATOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 138)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ARREGLO DINÁMICO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(300, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 138)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ARREGLO MULTIDIMENSIONAL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormARREGLOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormARREGLOS"
        Me.Text = "FormARREGLOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
