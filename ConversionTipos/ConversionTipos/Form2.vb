Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Para acceder a una variable global:'
        MsgBox(Form1.nombreGlobal)

    End Sub
End Class