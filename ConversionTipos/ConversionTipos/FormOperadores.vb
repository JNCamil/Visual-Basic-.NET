Public Class FormOperadores
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'DIVISIÓN'
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        resultado = num1 / num2

        Label1.Text = resultado
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MULTIPLICACIÓN'
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        resultado = num1 * num2

        Label1.Text = resultado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SUMA'
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        resultado = num1 + num2

        Label1.Text = resultado
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'RESTA'
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        resultado = num1 - num2

        Label1.Text = resultado
    End Sub
End Class