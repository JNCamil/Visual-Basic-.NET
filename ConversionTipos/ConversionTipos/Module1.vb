

Module Module1
    'Una de la utilidades de los módulos es la de acceder a variables públicas'
    Public miNombre As String = "camilo"

    'También para funciones públicas
    Public Function divide(valor1 As Double, valor2 As Double) As Double
        Dim resultado As Double
        resultado = valor1 / valor2
        Return resultado
    End Function
End Module
