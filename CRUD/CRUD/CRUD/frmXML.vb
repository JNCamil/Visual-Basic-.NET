Imports System.Xml 'Importar la librería para trabajar con XML
Public Class frmXML
    Dim ruta As String = AppDomain.CurrentDomain.BaseDirectory & "producto.xml" 'Es decir bin - Debug

    Dim docXml As New XmlDocument 'Creamos el objeto Xml para modificar la información
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub frmXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarProductos()

        docXml.Load(ruta) 'Inicializamos el objeto de la ruta

    End Sub

    Sub listarProductos()
        'NECESITAMOS UN ORIGEN DE DATOS O DATA SOURCE: UNO DE ELLOS PUEDE SER EL DATA TABLE
        Dim tablaProductos As New DataTable("producto")
        tablaProductos.Columns.Add("id", GetType(Integer))
        tablaProductos.Columns.Add("nombre", GetType(String))
        tablaProductos.Columns.Add("precio", GetType(Double))
        tablaProductos.Columns.Add("estado", GetType(Boolean))

        'Leer el archivo XML
        tablaProductos.ReadXml(ruta)

        'Poner datos en datagrid - Origen de los datos:
        dgvDatos.DataSource = tablaProductos


    End Sub
    'INSERTAR-----------------------------------------------------------------------------------------------------------------------------------
    Private Sub btninserta_Click(sender As Object, e As EventArgs) Handles btninserta.Click

        'CONTROL
        If txtid.Text <> "" Then
            MsgBox("Presione el botón nuevo para hacer un nuevo registro")
            Exit Sub
        End If

        Dim ultimoNodo As XmlNode = docXml.DocumentElement.LastChild 'Capturamos el último nodo producto

        Dim producto As XmlElement = docXml.CreateElement("producto")

        Dim id As XmlElement = docXml.CreateElement("id")
        Dim nombre As XmlElement = docXml.CreateElement("nombre")
        Dim precio As XmlElement = docXml.CreateElement("precio")
        Dim estado As XmlElement = docXml.CreateElement("estado")

        'Insertamos los elementos

        id.InnerText = Integer.Parse(ultimoNodo.ChildNodes(0).InnerText) + 1 'ChildNodes - todos los nodos (0) -> id 
        nombre.InnerText = Trim(txtnombre.Text) ' Función trim para quitar los espacios
        precio.InnerText = Trim(txtprecio.Text) ' Función trim para quitar los espacios
        estado.InnerText = IIf(chkEstado.Checked = True, "1", "0") 'Iff Evalúa condición 1 - true, 0 - false

        'Insertamos los nodos al padre
        producto.AppendChild(id)
        producto.AppendChild(nombre)
        producto.AppendChild(precio)
        producto.AppendChild(estado)

        'Insertar el nodo
        docXml.DocumentElement.InsertAfter(producto, ultimoNodo)
        docXml.Save(ruta) ' Guardamos


        'LIMPIAR CAMPOS
        txtnombre.Text = ""
        txtprecio.Text = ""
        MsgBox("Registro insertado correctamente")
        'Actualizamos el DataGrid
        Call listarProductos()




    End Sub

    'MODIFICAR-----------------------------------------------------------------------------------------------------------------------------------
    Private Sub dgvDatos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDatos.SelectionChanged
        'SI HAY DATOS:
        If dgvDatos.Rows.Count > 0 Then
            'DETERMINAR SI HAY ALGUNA FILA SELECCIONADA:
            If Not IsNothing(dgvDatos.CurrentRow) Then
                txtid.Text = dgvDatos.CurrentRow.Cells(0).Value 'Celda 0 para el id
                txtnombre.Text = dgvDatos.CurrentRow.Cells(1).Value
                txtprecio.Text = dgvDatos.CurrentRow.Cells(2).Value
                chkEstado.Checked = Boolean.Parse(dgvDatos.CurrentRow.Cells(3).Value)


            End If
        End If
    End Sub

    Private Sub btnmodifica_Click(sender As Object, e As EventArgs) Handles btnmodifica.Click

        'CONTROL
        If txtid.Text = "" Then
            MsgBox("Debe seleccionar el producto a modificar")
            Exit Sub
        End If

        Dim producto As XmlElement = docXml.DocumentElement.SelectSingleNode( _ 'el guión bajo _ se usa para continuar en la siguiente línea
           String.Format("producto[id='{0}']", txtid.Text)) ' SELECCIONAMOS EL ID del nodo el cual hayamos especificado en el DataGrid

        producto.ChildNodes(1).InnerText = txtnombre.Text
        producto.ChildNodes(2).InnerText = txtprecio.Text
        producto.ChildNodes(3).InnerText = IIf(chkEstado.Checked = True, "1", "0")
        docXml.Save(ruta)
        MsgBox("Registro modificado correctamente")
        Call listarProductos()


    End Sub

    'ELIMINAR-----------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnelimina_Click(sender As Object, e As EventArgs) Handles btnelimina.Click

        'CONTROL
        If txtid.Text = "" Then
            MsgBox("Debe seleccionar el producto a eliminar")
            Exit Sub
        End If

        'NODO RAÍZ 
        Dim raiz As XmlElement = docXml.DocumentElement
        Dim producto As XmlElement = docXml.DocumentElement.SelectSingleNode( _ 'el guión bajo _ se usa para continuar en la siguiente línea
           String.Format("producto[id='{0}']", txtid.Text)) ' SELECCIONAMOS EL ID del nodo el cual hayamos especificado en el DataGrid

        Dim respuesta
        respuesta = MsgBox("Seguro que desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If respuesta = vbYes Then

        Else
            Exit Sub
        End If


        raiz.RemoveChild(producto)
        docXml.Save(ruta)
        MsgBox("El registro se ha eliminado correctamente")
        Call listarProductos()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtid.Text = ""
        txtnombre.Text = ""
        txtprecio.Text = ""
        chkEstado.Checked = False
    End Sub
End Class
