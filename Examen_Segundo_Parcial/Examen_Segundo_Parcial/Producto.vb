Public Class fmProducto
    Dim conexion As conexion = New conexion()
    Dim tabla As New DataTable

    Private Sub fmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
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
End Class