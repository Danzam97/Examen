Public Class fmClientes
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable
    Private Sub fmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub
    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        txtID.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString
        txtNombre.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
        txtApellido.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
        txtDireccion.Text = dgvClientes.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultarClientes()
            If tabla.Rows.Count <> 0 Then
                dgvClientes.DataSource = tabla
            Else
                dgvClientes.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim id, nombre, apellido, direccion As String
        id = Val(txtID.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text

        Try
            If conexion.AgregarClientes(id, nombre, apellido, direccion) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("No se ingreso correctamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim id, nombre, apellido, direccion As String
        id = Val(txtID.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text

        Try
            If conexion.ActualizarClientes(id, nombre, apellido, direccion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As String
        id = Val(txtID.Text)

        Try
            If conexion.EliminarClientes(id) Then
                MsgBox("Exito")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        fmCRUD.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        fmProducto.Show()
        Me.Hide()
    End Sub
End Class