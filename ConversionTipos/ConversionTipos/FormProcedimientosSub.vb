Public Class FormProcedimientosSub
    Private Sub btnEjecutaSub_Click(sender As Object, e As EventArgs) Handles btnEjecutaSub.Click
        'LLAMAR PROCEDIMIENTO SUB, instrucción Call
        Call Darmensaje()
    End Sub


    'Para crear un procedimiento, se utiliza la palabra Sub'
    'Los procedimientos no retornan valores
    Sub Darmensaje()
        MsgBox(txtDato1.Text)

    End Sub


    'FUNCIONES----------------------------------------------------------------------------------------------------------------------------------------
    'las funciones deben retornar un valor
    Function emitemensaje() As String ' tenemos que indicar el valor que retorna'
        Dim mensaje As String
        mensaje = txtDato1.Text
        Return mensaje
    End Function

    Private Sub btnejecutafun_Click(sender As Object, e As EventArgs) Handles btnejecutafun.Click
        Dim mensaje As String
        mensaje = emitemensaje()
        If mensaje = "" Then
            MsgBox("escriba un mensaje")
            Exit Sub
        End If
        MsgBox(mensaje)
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Dim valor1 As Double
        Dim valor2 As Double
        Dim sumatoria As Double
        valor1 = txtvalor1.Text
        valor2 = txtvalor2.Text

        sumatoria = suma(valor1, valor2)

        MsgBox(sumatoria)
        MsgBox(valor1)

    End Sub
    Function suma(ByRef valor1 As Double, ByVal valor2 As Double) As Double
        'PARÁMETROS POR VALOR: BYVAL (se puede omitir porque es por defecto)
        'PARÁMETROS POR REFERENCIA: BYREF

        Dim resultado As Double
        resultado = valor1 + valor2
        valor1 = 40 'En caso de ByVal, la variable no cambiará porque se pasa por valor, con ByRef sí cambia porque se pasa por referencia
        '**************Paso por valor: copia, Paso por referencia: él mismo***************************
        Return resultado
    End Function


    Sub multiplicar(valor1 As Double, valor2 As Double)
        Dim resultado As Double
        resultado = valor1 * valor2
        MsgBox(resultado)
    End Sub

    Private Sub cmdmultiplica_Click(sender As Object, e As EventArgs) Handles cmdmultiplica.Click

        Dim valor1, valor2 As Double
        valor1 = txtvalor1.Text
        valor2 = txtvalor2.Text

        Call multiplicar(valor1, valor2)

    End Sub

    'APLICANDO BYREF:----------------------------------------------------------------------------------------------------------------------
    Sub resta(valor1 As Double, valor2 As Double, ByRef resultado As Double)
        resultado = valor1 - valor2

    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        Dim valor1, valor2 As Double

        Dim resultadoResta As Double

        valor1 = txtvalor1.Text
        valor2 = txtvalor2.Text

        Call resta(valor1, valor2, resultadoResta) 'Como se pasa él mismo, resultado obtendrá en el procedimiento = valor1 - valor2
        MsgBox(resultadoResta)
    End Sub

    Private Sub FormProcedimientosSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(miNombre)
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Dim valor1, valor2 As Double
        Dim resultado As Double
        valor1 = txtvalor1.Text
        valor2 = txtvalor2.Text
        resultado = divide(valor1, valor2)
        MsgBox(resultado)

    End Sub
End Class