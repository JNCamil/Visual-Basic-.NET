Public Class FormARREGLOS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Los arreglos se representan así:
        Dim estudiantes(2) As String ' Array estudiantes con 3 elementos
        estudiantes(0) = "Julio"
        estudiantes(1) = "pedro"
        estudiantes(2) = "andres"

        'MsgBox(estudiantes(0))
        'MsgBox(estudiantes(1))


        Dim n As Integer

        For n = 0 To 2
            MsgBox(estudiantes(n))
        Next

        For n = 0 To estudiantes.Length - 1 'Cantidad de elementos no indices, por eso -1
            MsgBox(estudiantes(n))
        Next





    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'ARREGLOS DINÁMICOS -------------------------------------------------------------------------------------------------------------------------

        Dim nombres() As String 'SE CREA EL ARREGLO

        ReDim nombres(1) 'ASIGNACIÓN DE ELEMENTOS

        nombres(0) = "ramon"
        nombres(1) = "julio"

        ReDim Preserve nombres(2) 'NUEVA ASIGNACIÓN DE ELEMENTOS, BORRANDO LO ANTERIOR, para evitarlo se usa PRESERVE

        nombres(2) = "pedro"


        MsgBox(nombres(0))

        MsgBox(nombres(1))

        MsgBox(nombres(2))



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'ARREGLOS MULTIDIMENSIONAL -------------------------------------------------------------------------------------------------------------------------
        Dim persona(3, 2) As String '2 dimensiones - 4 elementos la primera, 3 elementos la segunda

        persona(0, 0) = "julio"
        persona(0, 1) = "pedro"
        persona(0, 2) = "luis"

        persona(1, 0) = "belen"
        persona(1, 1) = "jose"
        persona(1, 2) = "ramon"

        persona(2, 0) = "laura"
        persona(2, 1) = "victor"
        persona(2, 2) = "alex"

        persona(3, 0) = "bryan"
        persona(3, 1) = "wilson"
        persona(3, 2) = "charo"

        'RECORRER EL ARRAY
        Dim i As Integer
        Dim n As Integer

        For i = 0 To persona.GetUpperBound(0) 'limite superior, primera posición/dimensión
            For n = 0 To persona.GetUpperBound(1) ''limite superior, segunda posición/dimensión

                MsgBox(persona(i, n))


            Next
        Next



    End Sub
End Class