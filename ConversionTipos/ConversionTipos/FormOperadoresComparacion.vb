Public Class FormOperadoresComparacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            Label2.Text = "IGUALES"
        Else
            Label2.Text = "DIFERENTES"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text < TextBox3.Text Then
            Label3.Text = "ES MENOR QUE"
        Else
            Label3.Text = "NO ES MENOR QUE"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox6.Text > TextBox5.Text Then
            Label5.Text = "ES MAYOR QUE"
        Else
            Label5.Text = "NO ES MAYOR QUE"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox8.Text <> TextBox7.Text Then
            Label7.Text = "SON DIFERENTES"
        Else
            Label7.Text = "NO SON DIFERENTES"
        End If
    End Sub
End Class