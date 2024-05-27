Public Class FormDICCIONARIOS
    Private Sub BTNpROCESA_Click(sender As Object, e As EventArgs) Handles BTNpROCESA.Click
        'UN DICCIONARIO ES UNA COLECCIÓN DE DATOS CON UNA CLAVE - VALOR

        'DECLARACIÓN
        Dim dict As New Dictionary(Of String, Integer) 'CADENA PARA VALOR

        dict.Add("TOYOTA", 25)
        dict.Add("NISSAN", 50)
        dict.Add("MAZDA", 14)

        MsgBox(dict.Count) 'CANTIDAD DE ELEMENTOS

        MsgBox(dict("NISSAN")) 'POR CLAVE

        'SI EXISTE UNA MARCA DETERMINADA, CLAVE -------------------------------------------------------------------------------------------
        Dim marca As String = ""

        marca = "NISSAN"

        If dict.ContainsKey(marca) Then
            MsgBox("La marca: " + marca + " existe en el diccionario")

            If dict(marca) = 0 Then
                MsgBox("NO HAY INVENTARIO SUFICIENTE DE LA MARCA " + marca)
            End If

        Else
            MsgBox("La marca: " + marca + " no existe en el diccionario")

        End If

        'IMPRIMIR DICCIONARIO --------------------------------------------------------------------------------------------------------------------
        For Each pareja As KeyValuePair(Of String, Integer) In dict 'pareja es la variable que se declara para imprimir

            MsgBox("LA MARCA: " + pareja.Key + " TIENE CANTIDAD: " & pareja.Value) 'OJO A LA CONCATENACIÓN****************** mejor &

        Next


    End Sub
End Class