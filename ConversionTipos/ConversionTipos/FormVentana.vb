Imports System.ComponentModel

Public Class FormVentana
    'EVENTOS: -------------------------------------------------------------------------------------------------------------------'
    'Evento que se genera por defecto cuando se carga el formulario:'
    Private Sub FormVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.White 'me: hace referencia al formulario(objeto), es decir, sustituye a FormVentana'
    End Sub

    Private Sub FormVentana_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'MsgBox("HAZ DADO CLICK AL FORMULARIO")'
    End Sub

    Private Sub FormVentana_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' MsgBox("FORMULARIO SE ESTÁ CERRANDO")'
    End Sub

    Private Sub FormVentana_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        ' MsgBox("HAZ HECHO DOBLE CLICK EN EL FORMULARIO") 'Toma el evento click antes, habría que comentar el de 1 click'
    End Sub

    Private Sub FormVentana_Move(sender As Object, e As EventArgs) Handles Me.Move
        ' MsgBox("HAZ MOVIDO EL FORMULARIO")'
    End Sub


    'MÉTODOS: -------------------------------------------------------------------------------------------------------------------'

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        ' Form1.Show()
        Form1.ShowDialog() 'Que lo ponga de manera modal, por encima, hasta que no cierre nada, se superpone

    End Sub
End Class