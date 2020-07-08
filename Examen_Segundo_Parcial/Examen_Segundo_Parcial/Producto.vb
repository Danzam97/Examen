Public Class fmProducto
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable

    Private Sub fmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub
    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        txtProducto.Text = dgvProductos.CurrentRow.Cells(0).Value.ToString
        txtNombre.Text = dgvProductos.CurrentRow.Cells(1).Value.ToString
        txtDescripcion.Text = dgvProductos.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultarProductos()
            If tabla.Rows.Count <> 0 Then
                dgvProductos.DataSource = tabla
            Else
                dgvProductos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim id, nombre, descripcion As String
        id = Val(txtProducto.Text)
        nombre = txtNombre.Text
        descripcion = txtDescripcion.Text

        Try
            If conexion.AgregarProductos(id, nombre, descripcion) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("No se ingreso correctamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim id, nombre, descripcion As String
        id = Val(txtProducto.Text)
        nombre = txtNombre.Text
        descripcion = txtDescripcion.Text

        Try
            If conexion.ActualizarProductos(id, nombre, descripcion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idProducto As String
        idProducto = Val(txtProducto.Text)

        Try
            If conexion.EliminarProductos(idProducto) Then
                MsgBox("Exito")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class