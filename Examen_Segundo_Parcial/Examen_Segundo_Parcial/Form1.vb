Public Class fmCRUD
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable
    Private Sub fmCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub
    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        txtVenta.Text = dgvVentas.CurrentRow.Cells(0).Value.ToString
        txtFecha.Text = dgvVentas.CurrentRow.Cells(1).Value.ToString
        txtPrecio.Text = dgvVentas.CurrentRow.Cells(2).Value.ToString
        txtCantidad.Text = dgvVentas.CurrentRow.Cells(3).Value.ToString
        txtCliente.Text = dgvVentas.CurrentRow.Cells(4).Value.ToString
        txtProducto.Text = dgvVentas.CurrentRow.Cells(5).Value.ToString
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            tabla = conexion.consultar()
            If tabla.Rows.Count <> 0 Then
                dgvVentas.DataSource = tabla
            Else
                dgvVentas.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim idVenta As Integer
        Dim fechaVenta As Date
        Dim precio As Integer
        Dim cantidad As Integer
        Dim idCliente As Integer
        Dim idProducto As Integer
        fechaVenta = CStr(Today)
        txtFecha.Text = fechaVenta
        idVenta = Val(txtVenta.Text)
        precio = Val(txtPrecio.Text)
        cantidad = Val(txtCantidad.Text)
        idCliente = Val(txtCliente.Text)
        idProducto = Val(txtProducto.Text)

        Try
            If conexion.Agregar(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("No se ingreso correctamente")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idVenta As Integer
        Dim fechaVenta As Date
        Dim precio As Integer
        Dim cantidad As Integer
        Dim idCliente As Integer
        Dim idProducto As Integer
        fechaVenta = CStr(Today)
        idVenta = txtVenta.Text
        precio = txtPrecio.Text
        cantidad = txtCantidad.Text
        idCliente = txtCliente.Text
        idProducto = txtProducto.Text

        Try
            If conexion.Actualizar(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim venta As String
        venta = txtVenta.Text

        Try
            If conexion.Eliminar(venta) Then
                MsgBox("Exito")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        fmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        fmProducto.Show()
        Me.Hide()
    End Sub

    Private Sub txtVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        Try
            tabla = conexion.consultarRecibo()
            If tabla.Rows.Count <> 0 Then
                dgvVentas.DataSource = tabla
            Else
                dgvVentas.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
