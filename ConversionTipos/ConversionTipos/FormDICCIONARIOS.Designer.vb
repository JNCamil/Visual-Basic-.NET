﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDICCIONARIOS
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
        Me.BTNpROCESA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNpROCESA
        '
        Me.BTNpROCESA.Location = New System.Drawing.Point(239, 124)
        Me.BTNpROCESA.Name = "BTNpROCESA"
        Me.BTNpROCESA.Size = New System.Drawing.Size(205, 126)
        Me.BTNpROCESA.TabIndex = 0
        Me.BTNpROCESA.Text = "PROCESAR"
        Me.BTNpROCESA.UseVisualStyleBackColor = True
        '
        'FormDICCIONARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNpROCESA)
        Me.Name = "FormDICCIONARIOS"
        Me.Text = "FormDICCIONARIOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNpROCESA As Button
End Class
