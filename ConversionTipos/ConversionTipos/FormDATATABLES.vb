Public Class FormDATATABLES
    Private Sub btnGeneradatatable_Click(sender As Object, e As EventArgs) Handles btnGeneradatatable.Click

        'Los dataTable se guardan en memoria
        Dim dt As DataTable = RetornaDatatable()


        'IMPRIMIR DATATABLE
        For Each dr As DataRow In dt.Rows  'dr : data row
            MsgBox("Nombre: " & dr("Nombre") & " , " & dr("Edad") & ",Nacionalidad: " & dr("Nacionalidad"))
        Next
    End Sub


    Function RetornaDatatable()
        'Declaración

        Dim dt As New DataTable
        'AGREGAR COLUMNAS: nomnbre - tipo con gettype
        dt.Columns.Add("Nombre", GetType(String))
        dt.Columns.Add("Edad", GetType(Integer))
        dt.Columns.Add("Nacionalidad", GetType(String))

        'AGREGAR REGISTROS
        dt.Rows.Add("CARLOS", 22, "PERUCHO")
        dt.Rows.Add("SOFIA", 45, "COLOCHO")
        dt.Rows.Add("SALOMON", 30, "ÑOL")

        Return dt

    End Function
End Class