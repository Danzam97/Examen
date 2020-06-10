Public Class Login
    Private usuario, contraseña As String

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        usuario = InputBox("Ingrese el nombre de usuario")
        contraseña = InputBox("Ingrese la contraseña")
        If usuario <> "Administrador" Or contraseña <> "SinHacer2020" Then
            txtUsuario.Enabled = False
            txtContra.Enabled = False
            btnIngresar.Enabled = False
            MsgBox("Debe crear el usuario: Administrador con contraseña: SinHacer2020")
        Else
            txtUsuario.Enabled = True
            txtContra.Enabled = True
            btnIngresar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If String.Compare(usuario, "ADMINISTRADOR", True) = 0 And String.Compare(contraseña, "SINHACER2020", True) = 0 Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos")
            txtContra.Clear()
            txtUsuario.Clear()
        End If
    End Sub
End Class
