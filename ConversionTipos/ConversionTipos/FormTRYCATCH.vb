Public Class FormTRYCATCH
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtoperador1.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtresultado.TextChanged

    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        Dim operador1, operador2 As Double


        'BLOQUE TRY CATCH:
        Try
            operador1 = txtoperador1.Text
            operador2 = txtoperador2.Text
            Call divide(operador1, operador2)
        Catch ex As Exception
            MsgBox("SE PRODUJO UN ERROR", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Sub divide(op1 As Double, op2 As Double)
        Dim resultado As Double
        resultado = op1 / op2
        txtresultado.Text = resultado
    End Sub
End Class