<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblPrecioVenta = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.PicImagen = New System.Windows.Forms.PictureBox()
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.LblImagen = New System.Windows.Forms.Label()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Location = New System.Drawing.Point(138, 364)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(137, 42)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(774, 21)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 14
        Me.TxtId.Visible = False
        Me.TxtId.WordWrap = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(313, 364)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(137, 42)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.ForeColor = System.Drawing.Color.White
        Me.BtnInsertar.Location = New System.Drawing.Point(138, 364)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(137, 42)
        Me.BtnInsertar.TabIndex = 8
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(138, 265)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(312, 76)
        Me.TxtDescripcion.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(138, 145)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(312, 20)
        Me.TxtNombre.TabIndex = 4
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(62, 265)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 1
        Me.LblDescripcion.Text = "Descripcion"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelEx2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(982, 438)
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
        Me.PanelEx2.Controls.Add(Me.TxtPrecioVenta)
        Me.PanelEx2.Controls.Add(Me.CboCategoria)
        Me.PanelEx2.Controls.Add(Me.TxtStock)
        Me.PanelEx2.Controls.Add(Me.LblNombre)
        Me.PanelEx2.Controls.Add(Me.TxtCodigo)
        Me.PanelEx2.Controls.Add(Me.LblDescripcion)
        Me.PanelEx2.Controls.Add(Me.LblPrecioVenta)
        Me.PanelEx2.Controls.Add(Me.TxtNombre)
        Me.PanelEx2.Controls.Add(Me.LblStock)
        Me.PanelEx2.Controls.Add(Me.TxtDescripcion)
        Me.PanelEx2.Controls.Add(Me.LblCodigo)
        Me.PanelEx2.Controls.Add(Me.BtnCancelar)
        Me.PanelEx2.Controls.Add(Me.TxtImagen)
        Me.PanelEx2.Controls.Add(Me.TxtId)
        Me.PanelEx2.Controls.Add(Me.PicImagen)
        Me.PanelEx2.Controls.Add(Me.BtnActualizar)
        Me.PanelEx2.Controls.Add(Me.BtnCargarImagen)
        Me.PanelEx2.Controls.Add(Me.LblCategoria)
        Me.PanelEx2.Controls.Add(Me.LblImagen)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(990, 423)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(465, 29)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "AGREGAR / ACTUALIZAR ARTICULOS"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(138, 225)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(159, 20)
        Me.TxtPrecioVenta.TabIndex = 6
        '
        'CboCategoria
        '
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(138, 61)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(312, 21)
        Me.CboCategoria.TabIndex = 2
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(138, 185)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(159, 20)
        Me.TxtStock.TabIndex = 5
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(68, 148)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre (*)"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(138, 103)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(312, 20)
        Me.TxtCodigo.TabIndex = 3
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.Location = New System.Drawing.Point(44, 225)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(81, 13)
        Me.LblPrecioVenta.TabIndex = 16
        Me.LblPrecioVenta.Text = "Precio Venta (*)"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(77, 188)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(48, 13)
        Me.LblStock.TabIndex = 15
        Me.LblStock.Text = "Stock (*)"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(85, 106)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LblCodigo.TabIndex = 14
        Me.LblCodigo.Text = "Codigo"
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(583, 61)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(230, 20)
        Me.TxtImagen.TabIndex = 13
        '
        'PicImagen
        '
        Me.PicImagen.Location = New System.Drawing.Point(583, 106)
        Me.PicImagen.Name = "PicImagen"
        Me.PicImagen.Size = New System.Drawing.Size(291, 217)
        Me.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImagen.TabIndex = 12
        Me.PicImagen.TabStop = False
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarImagen.ForeColor = System.Drawing.Color.White
        Me.BtnCargarImagen.Location = New System.Drawing.Point(819, 59)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(55, 23)
        Me.BtnCargarImagen.TabIndex = 11
        Me.BtnCargarImagen.Text = "..."
        Me.BtnCargarImagen.UseVisualStyleBackColor = False
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(60, 64)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(65, 13)
        Me.LblCategoria.TabIndex = 17
        Me.LblCategoria.Text = "Categoria (*)"
        '
        'LblImagen
        '
        Me.LblImagen.AutoSize = True
        Me.LblImagen.Location = New System.Drawing.Point(535, 64)
        Me.LblImagen.Name = "LblImagen"
        Me.LblImagen.Size = New System.Drawing.Size(42, 13)
        Me.LblImagen.TabIndex = 10
        Me.LblImagen.Text = "Imagen"
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDesactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesactivar.ForeColor = System.Drawing.Color.White
        Me.BtnDesactivar.Location = New System.Drawing.Point(459, 376)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(123, 41)
        Me.BtnDesactivar.TabIndex = 8
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = False
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivar.ForeColor = System.Drawing.Color.White
        Me.BtnActivar.Location = New System.Drawing.Point(302, 376)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(123, 41)
        Me.BtnActivar.TabIndex = 7
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(146, 376)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 41)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(10, 388)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 5
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(677, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(134, 41)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(7, 26)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(646, 20)
        Me.TxtValor.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(878, 390)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Controls.Add(Me.PanelEx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(982, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
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
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.BtnReporte)
        Me.PanelEx1.Controls.Add(Me.BtnBuscar)
        Me.PanelEx1.Controls.Add(Me.LblTotal)
        Me.PanelEx1.Controls.Add(Me.BtnDesactivar)
        Me.PanelEx1.Controls.Add(Me.ChkSeleccionar)
        Me.PanelEx1.Controls.Add(Me.BtnActivar)
        Me.PanelEx1.Controls.Add(Me.BtnEliminar)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(-4, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(990, 421)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 9
        '
        'BtnReporte
        '
        Me.BtnReporte.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.ForeColor = System.Drawing.Color.White
        Me.BtnReporte.Location = New System.Drawing.Point(835, 14)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(134, 41)
        Me.BtnReporte.TabIndex = 4
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = False
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(-4, 2)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(990, 464)
        Me.TabGeneral.TabIndex = 1
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(981, 445)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmArticulo"
        Me.Text = "Articulos"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.PicImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.TabGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents TxtImagen As TextBox
    Friend WithEvents PicImagen As PictureBox
    Friend WithEvents BtnCargarImagen As Button
    Friend WithEvents LblImagen As Label
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents LblPrecioVenta As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents LblCodigo As Label
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label5 As Label
End Class
