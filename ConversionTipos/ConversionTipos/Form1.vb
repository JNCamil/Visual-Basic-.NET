Public Class Form1

    'Alcance Variables: Local-Global-Modulo'
    'INICIO DE PROCEDIMIENTO: Palabra reservada Sub'

    Public nombreGlobal As String = "CARLOS" 'Alcance Global: se declara con Public------------------------------------------------------------------------------------------------'

    Dim nombre As String 'Alcance modulo------------------------------------------------------------------------------------------------'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Funciones de conversión de datos'
        'CBool - CDbl - CInt - CLng - CSng - CSng - CStr - Asc - Chr ' 



        'Alcance local-----------------------------------------------------------------------------------------------'
        Dim a As Integer
        Dim b As Integer
        Dim verifica As Boolean
        Dim nume1 As Double
        Dim nume2 As Integer

        'a = 45
        'b = 45
        'verifica = CBool(a = b)
        'MsgBox(verifica)
        'nume1 = CDbl("125,25") 'F9 si quiere detener ejecución aquí'
        'MsgBox(nume1)
        'nume2 = CInt(nume1)
        'MsgBox("El valor de número 2 es: " & nume2) ' Concatenar: &'

        'CSng convertir a Single'
        Dim nume3 As Single
        nume3 = CSng("190,23")
        MsgBox("El valor de número 2 es: " & nume3)
        'CStr'
        Dim palabra As String
        palabra = CStr(150)
        MsgBox("palabra: " & palabra)


        'Asc: ASCII'
        Dim codigoAscii As Integer
        codigoAscii = Asc("@")
        MsgBox("ASCII: " & codigoAscii)


        'Chr: lo contrario a Asc'
        Dim chr1 As String
        chr1 = Chr(64)
        MsgBox("Chr: " & chr1)
    End Sub


    'INICIO DE PROCEDIMIENTO: Palabra reservada Sub'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nombre = "Camilo"
        MsgBox(nombre)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub
End Class
