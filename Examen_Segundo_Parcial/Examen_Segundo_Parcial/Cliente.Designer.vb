<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(26, 261)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.Size = New System.Drawing.Size(731, 150)
        Me.dgvClientes.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(120, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 154)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(386, 40)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 22)
        Me.txtDireccion.TabIndex = 5
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(386, 154)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 22)
        Me.txtApellido.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido:"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(532, 37)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(83, 23)
        Me.btnConsultar.TabIndex = 17
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(532, 75)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(83, 23)
        Me.btnCrear.TabIndex = 18
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(532, 114)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(83, 23)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(532, 151)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(83, 23)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(648, 114)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(128, 73)
        Me.btnProductos.TabIndex = 21
        Me.btnProductos.Text = "Tabla Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(648, 25)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(128, 73)
        Me.btnVentas.TabIndex = 22
        Me.btnVentas.Text = "Tabla Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'fmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "fmClientes"
        Me.Text = "Cliente"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnVentas As Button
End Class
