Public Class FormFOR_NEXT
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contador As Integer
        Dim VALORINICIO As Integer
        Dim valorfinal As Integer

        VALORINICIO = CInt(TextBox1.Text)
        valorfinal = CInt(TextBox2.Text)

        For contador = VALORINICIO To valorfinal

            If contador = 5 Then
                Continue For  'SALTA AL NEXT'
            End If

            If contador = 9 Then
                Exit For 'DETIENE LA EJECUCIÓN'
            End If

            MsgBox(contador)

        Next
    End Sub
End Class