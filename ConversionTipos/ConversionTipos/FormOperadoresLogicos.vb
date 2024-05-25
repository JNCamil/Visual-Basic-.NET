Public Class FormOperadoresLogicos
    Private Sub FormOperadoresLogicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A As Integer
        Dim B As Integer



        'AND 
        A = 3
        B = 50

        If A > 5 And B > 15 Then
            MsgBox("CONDICIÓN1 SE CUMPLE")
        End If


        'OR 
        A = 10
        B = 50

        If A > 5 Or B > 15 Then
            MsgBox("CONDICIÓN2 SE CUMPLE")
        End If


        'NOT
        If Not A = 3 Then
            MsgBox("CONDICION3 SE CUMPLE")
        End If


    End Sub
End Class