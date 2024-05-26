Public Class FormWHILE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As Integer = 1
        While c < 10
            MsgBox(c)
            c = c + 1
        End While
    End Sub
End Class