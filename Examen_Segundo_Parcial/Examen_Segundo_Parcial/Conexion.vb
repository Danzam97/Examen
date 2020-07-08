Imports System.Data.SqlClient

Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-SRS9O5V\SQLSERVER;Initial Catalog=Tienda;Integrated Security=True")

    Public Sub conectar()
        Try
            conexion.Open()
            MsgBox("conectado")
        Catch ex As Exception
            MessageBox.Show("No se logro conectar: " + ex.ToString)
            End
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultar() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarTabla", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarRecibo() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("recibo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarClientes() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarProductos() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarProductos", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            conexion.Close()

        End Try
    End Function
    Public Function Agregar(idVenta As Integer, fechaVenta As Date, precio As Integer, cantidad As Integer, idCliente As Integer, idProducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("agregar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function AgregarClientes(idCliente As Integer, nombre As String, apellido As String, direccion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("agregarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function AgregarProductos(idProducto As Integer, nombreProducto As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("agregarProductos", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function Actualizar(idVenta As Integer, fechaVenta As Date, precio As Integer, cantidad As Integer, idCliente As Integer, idProducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("modificar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function ActualizarClientes(idCliente As Integer, nombre As String, apellido As String, direccion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("modificarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)
            cmd.Parameters.AddWithValue("@direccion", direccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function ActualizarProductos(idProducto As Integer, nombre As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("modificarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", nombre)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function Eliminar(idVenta As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function EliminarClientes(id As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", id)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function EliminarProductos(idProducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

End Class