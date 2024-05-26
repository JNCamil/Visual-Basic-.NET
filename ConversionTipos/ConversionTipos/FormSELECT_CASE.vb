Public Class FormSELECT_CASE
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim calificacion As Integer
        calificacion = CInt(TextBox1.Text)

        Select Case calificacion
            Case 0
                Label2.Text = "PERDISTE TODOS LOS PUNTOS"
            Case 100
                Label2.Text = "EXCELENTE"
            Case 90 To 99
                Label2.Text = "BIEN CHAVAL"
            Case Else
                Label2.Text = "basura"
        End Select

    End Sub
End Class