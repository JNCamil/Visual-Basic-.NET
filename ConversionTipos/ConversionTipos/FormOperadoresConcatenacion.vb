Public Class FormOperadoresConcatenacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'PRIMERA FORMA:  Label1.Text = TextBox1.Text & " " & TextBox2.Text' 
        Label1.Text = TextBox1.Text + " " + TextBox2.Text
    End Sub
End Class