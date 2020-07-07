Public Class Form2
    Private activoComa, recuperadoComa, muertoComa As Integer
    Private activoAtl, recuperadoAtl, muertoAtl As Integer
    Private activoCh, recuperadoCh, muertoCh As Integer
    Private activoCo, recuperadoCo, muertoCo As Integer
    Private activoCop, recuperadoCop, muertoCop As Integer
    Private activoCor, recuperadoCor, muertoCor As Integer
    Private activoPar, recuperadoPar, muertoPar As Integer
    Private activoGr, recuperadoGr, muertoGr As Integer
    Private activoIn, recuperadoIn, muertoIn As Integer
    Private activoIs, recuperadoIs, muertoIs As Integer
    Private activoPa, recuperadoPa, muertoPa As Integer
    Private activoLem, recuperadoLem, muertoLem As Integer
    Private activoOc, recuperadoOc, muertoOc As Integer
    Private activoOl, recuperadoOl, muertoOl As Integer
    Private activoSan, recuperadoSan, muertoSan As Integer
    Private activoVa, recuperadoVa, muertoVa As Integer
    Private activoYo, recuperadoYo, muertoYo As Integer
    Private activoMora, recuperadoMora, muertoMora As Integer

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNombre.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtDescripcion.Clear()
        cmbEstado.SelectedIndex = -1
        cmbResultado.SelectedIndex = -1
        cmbDepRep.SelectedIndex = -1
        cmbDep.SelectedIndex = -1
    End Sub

    Private Sub cmbResultado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResultado.SelectedIndexChanged
        If cmbResultado.SelectedIndex = 0 Then
            cmbEstado.Enabled = True
        Else
            cmbEstado.Enabled = False
        End If
    End Sub
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorNombre.SetError(sender, "")
        Else
            Me.errorNombre.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorEdad.SetError(sender, "")
        Else
            Me.errorEdad.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub txtMunicipio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorMunicipio.SetError(sender, "")
        Else
            Me.errorMunicipio.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub txtDescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorDescripcion.SetError(sender, "")
        Else
            Me.errorDescripcion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub cmbDep_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbDep.Validating
        If cmbDep.SelectedIndex <> -1 Then
            Me.errorDepartamento.SetError(sender, "")
        Else
            Me.errorDepartamento.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub cmbResultado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbResultado.Validating
        If cmbResultado.SelectedIndex <> -1 Then
            Me.errorDepartamento.SetError(sender, "")
        Else
            Me.errorDepartamento.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub cmbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbEstado.Validating
        If cmbEstado.SelectedIndex <> -1 Then
            Me.errorDepartamento.SetError(sender, "")
        Else
            Me.errorDepartamento.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingrese la edad del paciente")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese el municipio donde reside el paciente")
        ToolTip1.ToolTipTitle = "Municipio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbDep_MouseHover(sender As Object, e As EventArgs) Handles cmbDep.MouseHover
        ToolTip1.SetToolTip(cmbDep, "Elija el departamento donde reside el paciente")
        ToolTip1.ToolTipTitle = "Departamento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbResultado_MouseHover(sender As Object, e As EventArgs) Handles cmbResultado.MouseHover
        ToolTip1.SetToolTip(cmbResultado, "Elija el resultado de la prueba del paciente")
        ToolTip1.ToolTipTitle = "Resultado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Ingrese la descripcion del estado del paciente")
        ToolTip1.ToolTipTitle = "Descripcion"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnClear_MouseHover(sender As Object, e As EventArgs) Handles btnClear.MouseHover
        ToolTip1.SetToolTip(btnClear, "Limpia los campos")
        ToolTip1.ToolTipTitle = "Clear"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Elija el estado del paciente")
        ToolTip1.ToolTipTitle = "Estado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnReporte_MouseHover(sender As Object, e As EventArgs) Handles btnReporte.MouseHover
        ToolTip1.SetToolTip(btnReporte, "Muestra el conteo de activos, recuperados y muertos")
        ToolTip1.ToolTipTitle = "Reporte"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnRegistrar_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrar.MouseHover
        ToolTip1.SetToolTip(btnRegistrar, "Registra los datos del paciente en la base de datos")
        ToolTip1.ToolTipTitle = "Registro"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtDescripcion.Text <> String.Empty And txtMunicipio.Text <> String.Empty And cmbDep.SelectedIndex <> -1 And cmbResultado.SelectedIndex <> -1 Then
            If cmbResultado.SelectedIndex = 0 And cmbEstado.SelectedIndex <> -1 Then
                MessageBox.Show("Paciente Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtReporte.Text &= "Paciente: "
                txtReporte.Text &= txtNombre.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= txtEdad.Text
                txtReporte.Text &= " años"
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= "Departamento: "
                txtReporte.Text &= cmbDep.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= "Municipio: "
                txtReporte.Text &= txtMunicipio.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= cmbResultado.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= cmbEstado.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= txtDescripcion.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                cmbDepRep.Enabled = True
                btnReporte.Enabled = True
            ElseIf cmbResultado.SelectedIndex = 1 Then
                MessageBox.Show("Paciente Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtReporte.Text &= "Paciente: "
                txtReporte.Text &= txtNombre.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= txtEdad.Text
                txtReporte.Text &= " años"
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= "Departamento: "
                txtReporte.Text &= cmbDep.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= "Municipio: "
                txtReporte.Text &= txtMunicipio.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= cmbResultado.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= cmbEstado.SelectedItem
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= txtDescripcion.Text
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                txtReporte.Text &= Environment.NewLine
                txtReporte.SelectionStart = txtReporte.Text.Length
                cmbDepRep.Enabled = True
                btnReporte.Enabled = True
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Revise los datos ingresados", "Error en campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Select Case cmbDep.SelectedIndex
            Case 0
                If cmbEstado.SelectedIndex = 0 Then
                    activoAtl += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoAtl += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoAtl += 1
                End If
            Case 1
                If cmbEstado.SelectedIndex = 0 Then
                    activoCh += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoCh += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoCh += 1
                End If
            Case 2
                If cmbEstado.SelectedIndex = 0 Then
                    activoCo += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoCo += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoCo += 1
                End If
            Case 3
                If cmbEstado.SelectedIndex = 0 Then
                    activoComa += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoComa += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoComa += 1
                End If
            Case 4
                If cmbEstado.SelectedIndex = 0 Then
                    activoCop += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoCop += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoCop += 1
                End If
            Case 5
                If cmbEstado.SelectedIndex = 0 Then
                    activoCor += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoCor += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoCor += 1
                End If
            Case 6
                If cmbEstado.SelectedIndex = 0 Then
                    activoPar += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoPar += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoPar += 1
                End If
            Case 7
                If cmbEstado.SelectedIndex = 0 Then
                    activoMora += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoMora += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoMora += 1
                End If
            Case 8
                If cmbEstado.SelectedIndex = 0 Then
                    activoGr += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoGr += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoGr += 1
                End If
            Case 9
                If cmbEstado.SelectedIndex = 0 Then
                    activoIn += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoIn += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoIn += 1
                End If
            Case 10
                If cmbEstado.SelectedIndex = 0 Then
                    activoIs += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoIs += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoIs += 1
                End If
            Case 11
                If cmbEstado.SelectedIndex = 0 Then
                    activoPa += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoPa += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoPa += 1
                End If
            Case 12
                If cmbEstado.SelectedIndex = 0 Then
                    activoLem += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoLem += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoLem += 1
                End If
            Case 13
                If cmbEstado.SelectedIndex = 0 Then
                    activoOc += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoOc += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoOc += 1
                End If
            Case 14
                If cmbEstado.SelectedIndex = 0 Then
                    activoOl += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoOl += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoOl += 1
                End If
            Case 15
                If cmbEstado.SelectedIndex = 0 Then
                    activoSan += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoSan += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoSan += 1
                End If
            Case 16
                If cmbEstado.SelectedIndex = 0 Then
                    activoVa += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoVa += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoVa += 1
                End If
            Case 17
                If cmbEstado.SelectedIndex = 0 Then
                    activoYo += 1
                ElseIf cmbEstado.SelectedIndex = 1 Then
                    recuperadoYo += 1
                ElseIf cmbEstado.SelectedIndex = 2 Then
                    muertoYo += 1
                End If
        End Select
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Select Case cmbDepRep.SelectedIndex
            Case 0
                txtActivo.Text = activoAtl
                txtRecuperado.Text = recuperadoAtl
                txtMuerto.Text = muertoAtl
            Case 1
                txtActivo.Text = activoCh
                txtRecuperado.Text = recuperadoCh
                txtMuerto.Text = muertoCh
            Case 2
                txtActivo.Text = activoCo
                txtRecuperado.Text = recuperadoCo
                txtMuerto.Text = muertoCo
            Case 3
                txtActivo.Text = activoComa
                txtRecuperado.Text = recuperadoComa
                txtMuerto.Text = muertoComa
            Case 4
                txtActivo.Text = activoCop
                txtRecuperado.Text = recuperadoCop
                txtMuerto.Text = muertoCop
            Case 5
                txtActivo.Text = activoCor
                txtRecuperado.Text = recuperadoCor
                txtMuerto.Text = muertoCor
            Case 6
                txtActivo.Text = activoPar
                txtRecuperado.Text = recuperadoPar
                txtMuerto.Text = muertoPar
            Case 7
                txtActivo.Text = activoMora
                txtRecuperado.Text = recuperadoMora
                txtMuerto.Text = muertoMora
            Case 8
                txtActivo.Text = activoGr
                txtRecuperado.Text = recuperadoGr
                txtMuerto.Text = muertoGr
            Case 9
                txtActivo.Text = activoIn
                txtRecuperado.Text = recuperadoIn
                txtMuerto.Text = muertoIn
            Case 10
                txtActivo.Text = activoIs
                txtRecuperado.Text = recuperadoIs
                txtMuerto.Text = muertoIs
            Case 11
                txtActivo.Text = activoPa
                txtRecuperado.Text = recuperadoPa
                txtMuerto.Text = muertoPa
            Case 12
                txtActivo.Text = activoLem
                txtRecuperado.Text = recuperadoLem
                txtMuerto.Text = muertoLem
            Case 13
                txtActivo.Text = activoOc
                txtRecuperado.Text = recuperadoOc
                txtMuerto.Text = muertoOc
            Case 14
                txtActivo.Text = activoOl
                txtRecuperado.Text = recuperadoOl
                txtMuerto.Text = muertoOl
            Case 15
                txtActivo.Text = activoSan
                txtRecuperado.Text = recuperadoSan
                txtMuerto.Text = muertoSan
            Case 16
                txtActivo.Text = activoVa
                txtRecuperado.Text = recuperadoVa
                txtMuerto.Text = muertoVa
            Case 17
                txtActivo.Text = activoYo
                txtRecuperado.Text = recuperadoYo
                txtMuerto.Text = muertoYo
        End Select
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As String
        opcion = MsgBox("¿Desea salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            End
        End If
    End Sub
End Class