Public Class FormBloqueIF
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "si" Then
            Label2.Text = "te gusta el platano"

        ElseIf TextBox1.Text = "no" Then
            Label2.Text = "no te gusta el platano"
        Else
            Label2.Text = "gil pon si o no"
        End If
    End Sub
End Class
'F9 MARCAMOS - F11 PASO A PASO'