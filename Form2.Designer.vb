<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDepRep = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtReporte = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbResultado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtActivo = New System.Windows.Forms.TextBox()
        Me.txtRecuperado = New System.Windows.Forms.TextBox()
        Me.txtMuerto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.errorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorEdad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDepartamento = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorMunicipio = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorResultado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorEstado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDescripcion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(189, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(321, 22)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(189, 96)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(69, 22)
        Me.txtEdad.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Departamento:"
        '
        'cmbDep
        '
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDep.Location = New System.Drawing.Point(189, 128)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(215, 24)
        Me.cmbDep.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Municipio:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(189, 166)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(152, 22)
        Me.txtMunicipio.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Resultado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(189, 312)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(321, 99)
        Me.txtDescripcion.TabIndex = 11
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(130, 446)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(104, 41)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(406, 446)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 41)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(596, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Reporte:"
        '
        'cmbDepRep
        '
        Me.cmbDepRep.Enabled = False
        Me.cmbDepRep.FormattingEnabled = True
        Me.cmbDepRep.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepRep.Location = New System.Drawing.Point(681, 56)
        Me.cmbDepRep.Name = "cmbDepRep"
        Me.cmbDepRep.Size = New System.Drawing.Size(224, 24)
        Me.cmbDepRep.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Recuperado", "Muerto"})
        Me.cmbEstado.Location = New System.Drawing.Point(189, 256)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(152, 24)
        Me.cmbEstado.TabIndex = 17
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(599, 187)
        Me.txtReporte.Multiline = True
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReporte.Size = New System.Drawing.Size(428, 300)
        Me.txtReporte.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(268, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ingrese los datos del paciente:"
        '
        'cmbResultado
        '
        Me.cmbResultado.FormattingEnabled = True
        Me.cmbResultado.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.cmbResultado.Location = New System.Drawing.Point(189, 202)
        Me.cmbResultado.Name = "cmbResultado"
        Me.cmbResultado.Size = New System.Drawing.Size(152, 24)
        Me.cmbResultado.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(596, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Historial:"
        '
        'txtActivo
        '
        Me.txtActivo.Enabled = False
        Me.txtActivo.Location = New System.Drawing.Point(599, 123)
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.Size = New System.Drawing.Size(69, 22)
        Me.txtActivo.TabIndex = 23
        '
        'txtRecuperado
        '
        Me.txtRecuperado.Enabled = False
        Me.txtRecuperado.Location = New System.Drawing.Point(767, 123)
        Me.txtRecuperado.Name = "txtRecuperado"
        Me.txtRecuperado.Size = New System.Drawing.Size(69, 22)
        Me.txtRecuperado.TabIndex = 24
        '
        'txtMuerto
        '
        Me.txtMuerto.Enabled = False
        Me.txtMuerto.Location = New System.Drawing.Point(935, 123)
        Me.txtMuerto.Name = "txtMuerto"
        Me.txtMuerto.Size = New System.Drawing.Size(69, 22)
        Me.txtMuerto.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(596, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Activo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(764, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Recuperado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(932, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Muerto:"
        '
        'btnReporte
        '
        Me.btnReporte.Enabled = False
        Me.btnReporte.Location = New System.Drawing.Point(935, 47)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(104, 41)
        Me.btnReporte.TabIndex = 29
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(270, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 41)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'errorNombre
        '
        Me.errorNombre.ContainerControl = Me
        '
        'errorEdad
        '
        Me.errorEdad.ContainerControl = Me
        '
        'errorDepartamento
        '
        Me.errorDepartamento.ContainerControl = Me
        '
        'errorMunicipio
        '
        Me.errorMunicipio.ContainerControl = Me
        '
        'errorResultado
        '
        Me.errorResultado.ContainerControl = Me
        '
        'errorEstado
        '
        Me.errorEstado.ContainerControl = Me
        '
        'errorDescripcion
        '
        Me.errorDescripcion.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 547)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMuerto)
        Me.Controls.Add(Me.txtRecuperado)
        Me.Controls.Add(Me.txtActivo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbResultado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbDepRep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.errorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDep As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbDepRep As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtReporte As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbResultado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents txtRecuperado As TextBox
    Friend WithEvents txtMuerto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents errorNombre As ErrorProvider
    Friend WithEvents errorEdad As ErrorProvider
    Friend WithEvents errorDepartamento As ErrorProvider
    Friend WithEvents errorMunicipio As ErrorProvider
    Friend WithEvents errorResultado As ErrorProvider
    Friend WithEvents errorEstado As ErrorProvider
    Friend WithEvents errorDescripcion As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
