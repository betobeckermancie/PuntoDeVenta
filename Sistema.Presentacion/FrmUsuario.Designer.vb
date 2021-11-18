<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNumDocumento = New System.Windows.Forms.TextBox()
        Me.LblPrecioVenta = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.CboRol = New System.Windows.Forms.ComboBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDesactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesactivar.ForeColor = System.Drawing.Color.White
        Me.BtnDesactivar.Location = New System.Drawing.Point(458, 379)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(123, 47)
        Me.BtnDesactivar.TabIndex = 7
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = False
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivar.ForeColor = System.Drawing.Color.White
        Me.BtnActivar.Location = New System.Drawing.Point(301, 379)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(123, 47)
        Me.BtnActivar.TabIndex = 6
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(145, 379)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 47)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(13, 394)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 4
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(629, 8)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(134, 41)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(10, 19)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(598, 20)
        Me.TxtValor.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(881, 396)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total"
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(6, 61)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(959, 310)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.BtnDesactivar)
        Me.TabPage1.Controls.Add(Me.BtnActivar)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Controls.Add(Me.PanelEx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(977, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LblTotal)
        Me.PanelEx1.Controls.Add(Me.ChkSeleccionar)
        Me.PanelEx1.Controls.Add(Me.TxtValor)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(-4, 2)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(977, 438)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 8
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(141, 259)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(159, 20)
        Me.TxtDireccion.TabIndex = 6
        '
        'TxtNumDocumento
        '
        Me.TxtNumDocumento.Location = New System.Drawing.Point(141, 219)
        Me.TxtNumDocumento.Name = "TxtNumDocumento"
        Me.TxtNumDocumento.Size = New System.Drawing.Size(159, 20)
        Me.TxtNumDocumento.TabIndex = 5
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.Location = New System.Drawing.Point(76, 262)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(52, 13)
        Me.LblPrecioVenta.TabIndex = 16
        Me.LblPrecioVenta.Text = "Direccion"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(26, 222)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(102, 13)
        Me.LblStock.TabIndex = 15
        Me.LblStock.Text = "Numero Documento"
        '
        'CboRol
        '
        Me.CboRol.FormattingEnabled = True
        Me.CboRol.Location = New System.Drawing.Point(141, 95)
        Me.CboRol.Name = "CboRol"
        Me.CboRol.Size = New System.Drawing.Size(312, 21)
        Me.CboRol.TabIndex = 2
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(92, 98)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(36, 13)
        Me.LblCategoria.TabIndex = 17
        Me.LblCategoria.Text = "Rol (*)"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(326, 361)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(137, 48)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(353, 69)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 1
        Me.TxtId.Visible = False
        Me.TxtId.WordWrap = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(501, 361)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(137, 48)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.ForeColor = System.Drawing.Color.White
        Me.BtnInsertar.Location = New System.Drawing.Point(326, 361)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(137, 48)
        Me.BtnInsertar.TabIndex = 10
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(141, 299)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(312, 20)
        Me.TxtTelefono.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(141, 136)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(312, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(71, 302)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(49, 13)
        Me.LblDescripcion.TabIndex = 1
        Me.LblDescripcion.Text = "Telefono"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(71, 139)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre (*)"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelEx2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(977, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Label5)
        Me.PanelEx2.Controls.Add(Me.BtnInsertar)
        Me.PanelEx2.Controls.Add(Me.BtnActualizar)
        Me.PanelEx2.Controls.Add(Me.GroupBox1)
        Me.PanelEx2.Controls.Add(Me.LblStock)
        Me.PanelEx2.Controls.Add(Me.CboTipoDocumento)
        Me.PanelEx2.Controls.Add(Me.BtnCancelar)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Controls.Add(Me.LblNombre)
        Me.PanelEx2.Controls.Add(Me.TxtDireccion)
        Me.PanelEx2.Controls.Add(Me.LblDescripcion)
        Me.PanelEx2.Controls.Add(Me.TxtNumDocumento)
        Me.PanelEx2.Controls.Add(Me.TxtNombre)
        Me.PanelEx2.Controls.Add(Me.LblPrecioVenta)
        Me.PanelEx2.Controls.Add(Me.TxtTelefono)
        Me.PanelEx2.Controls.Add(Me.CboRol)
        Me.PanelEx2.Controls.Add(Me.TxtId)
        Me.PanelEx2.Controls.Add(Me.LblCategoria)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(-4, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(981, 442)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(451, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "AGREGAR / ACTUALIZAR USUARIOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 230)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "-Para agregar un nuevo usuario rellene ambos campos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Para actualizar deje el ca" &
    "mpo de contraseña en blanco."
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(108, 110)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(261, 20)
        Me.TxtClave.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(108, 61)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(261, 20)
        Me.TxtEmail.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Email (*)"
        '
        'CboTipoDocumento
        '
        Me.CboTipoDocumento.FormattingEnabled = True
        Me.CboTipoDocumento.Items.AddRange(New Object() {"CEDULA", "CLAVE DE ELECTOR", "PASAPORTE", "PERMISO DE CONDUCIR"})
        Me.CboTipoDocumento.Location = New System.Drawing.Point(141, 177)
        Me.CboTipoDocumento.Name = "CboTipoDocumento"
        Me.CboTipoDocumento.Size = New System.Drawing.Size(159, 21)
        Me.CboTipoDocumento.TabIndex = 4
        Me.CboTipoDocumento.Text = "CEDULA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tipo Documento"
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(-4, 2)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(985, 464)
        Me.TabGeneral.TabIndex = 2
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 460)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmUsuario"
        Me.Text = "Usuario"
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNumDocumento As TextBox
    Friend WithEvents LblPrecioVenta As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents CboRol As ComboBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CboTipoDocumento As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
