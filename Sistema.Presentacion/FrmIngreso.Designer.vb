<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
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
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarM = New System.Windows.Forms.Button()
        Me.LblTotalM = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoM = New System.Windows.Forms.Label()
        Me.LblSubTotalM = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.LblTotalArticulos = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnBuscarArticulosDetalle = New System.Windows.Forms.Button()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarArticulos = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscarArticulos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtNumComprobante = New System.Windows.Forms.TextBox()
        Me.CboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtSerieComprobante = New System.Windows.Forms.TextBox()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAnular
        '
        Me.BtnAnular.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.ForeColor = System.Drawing.Color.White
        Me.BtnAnular.Location = New System.Drawing.Point(118, 377)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(123, 45)
        Me.BtnAnular.TabIndex = 5
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = False
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(7, 390)
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
        Me.BtnBuscar.Location = New System.Drawing.Point(627, 8)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(134, 45)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(7, 22)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(598, 20)
        Me.TxtValor.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(874, 392)
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
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Controls.Add(Me.PanelEx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(978, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalImpuestoM)
        Me.PanelMostrar.Controls.Add(Me.LblSubTotalM)
        Me.PanelMostrar.Controls.Add(Me.Label8)
        Me.PanelMostrar.Controls.Add(Me.Label7)
        Me.PanelMostrar.Controls.Add(Me.Label6)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrarDetalle)
        Me.PanelMostrar.Location = New System.Drawing.Point(127, 100)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(732, 349)
        Me.PanelMostrar.TabIndex = 8
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarM
        '
        Me.BtnCerrarM.BackColor = System.Drawing.Color.Red
        Me.BtnCerrarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarM.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarM.Location = New System.Drawing.Point(678, 8)
        Me.BtnCerrarM.Name = "BtnCerrarM"
        Me.BtnCerrarM.Size = New System.Drawing.Size(37, 34)
        Me.BtnCerrarM.TabIndex = 5
        Me.BtnCerrarM.Text = "X"
        Me.BtnCerrarM.UseVisualStyleBackColor = False
        '
        'LblTotalM
        '
        Me.LblTotalM.AutoSize = True
        Me.LblTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalM.Location = New System.Drawing.Point(652, 305)
        Me.LblTotalM.Name = "LblTotalM"
        Me.LblTotalM.Size = New System.Drawing.Size(16, 16)
        Me.LblTotalM.TabIndex = 4
        Me.LblTotalM.Text = "0"
        '
        'LblTotalImpuestoM
        '
        Me.LblTotalImpuestoM.AutoSize = True
        Me.LblTotalImpuestoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoM.Location = New System.Drawing.Point(652, 280)
        Me.LblTotalImpuestoM.Name = "LblTotalImpuestoM"
        Me.LblTotalImpuestoM.Size = New System.Drawing.Size(16, 16)
        Me.LblTotalImpuestoM.TabIndex = 4
        Me.LblTotalImpuestoM.Text = "0"
        '
        'LblSubTotalM
        '
        Me.LblSubTotalM.AutoSize = True
        Me.LblSubTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalM.Location = New System.Drawing.Point(652, 254)
        Me.LblSubTotalM.Name = "LblSubTotalM"
        Me.LblSubTotalM.Size = New System.Drawing.Size(16, 16)
        Me.LblSubTotalM.TabIndex = 4
        Me.LblSubTotalM.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(569, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(569, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Iva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(569, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sub Total"
        '
        'DgvMostrarDetalle
        '
        Me.DgvMostrarDetalle.AllowUserToAddRows = False
        Me.DgvMostrarDetalle.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalle.Location = New System.Drawing.Point(19, 48)
        Me.DgvMostrarDetalle.Name = "DgvMostrarDetalle"
        Me.DgvMostrarDetalle.ReadOnly = True
        Me.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(696, 191)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ChkSeleccionar)
        Me.PanelEx1.Controls.Add(Me.LblTotal)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(977, 592)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 9
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(803, 6)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(532, 539)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(137, 50)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.ForeColor = System.Drawing.Color.White
        Me.BtnInsertar.Location = New System.Drawing.Point(357, 539)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(137, 50)
        Me.BtnInsertar.TabIndex = 10
        Me.BtnInsertar.Text = "Realizar Compra"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.PanelEx2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(978, 624)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelArticulos)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Controls.Add(Me.PanelEx4)
        Me.GroupBox2.Location = New System.Drawing.Point(78, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(821, 356)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'PanelArticulos
        '
        Me.PanelArticulos.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelArticulos.Controls.Add(Me.LblTotalArticulos)
        Me.PanelArticulos.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulos.Controls.Add(Me.BtnBuscarArticulosDetalle)
        Me.PanelArticulos.Controls.Add(Me.DgvArticulos)
        Me.PanelArticulos.Controls.Add(Me.TxtBuscarArticulos)
        Me.PanelArticulos.Location = New System.Drawing.Point(110, 92)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(711, 266)
        Me.PanelArticulos.TabIndex = 10
        Me.PanelArticulos.Visible = False
        '
        'LblTotalArticulos
        '
        Me.LblTotalArticulos.AutoSize = True
        Me.LblTotalArticulos.Location = New System.Drawing.Point(575, 239)
        Me.LblTotalArticulos.Name = "LblTotalArticulos"
        Me.LblTotalArticulos.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalArticulos.TabIndex = 4
        Me.LblTotalArticulos.Text = "Total"
        Me.LblTotalArticulos.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(667, 15)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 23)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnBuscarArticulosDetalle
        '
        Me.BtnBuscarArticulosDetalle.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBuscarArticulosDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarArticulosDetalle.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarArticulosDetalle.Location = New System.Drawing.Point(497, 13)
        Me.BtnBuscarArticulosDetalle.Name = "BtnBuscarArticulosDetalle"
        Me.BtnBuscarArticulosDetalle.Size = New System.Drawing.Size(93, 38)
        Me.BtnBuscarArticulosDetalle.TabIndex = 13
        Me.BtnBuscarArticulosDetalle.Text = "Buscar"
        Me.BtnBuscarArticulosDetalle.UseVisualStyleBackColor = False
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(17, 62)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(675, 161)
        Me.DgvArticulos.TabIndex = 1
        '
        'TxtBuscarArticulos
        '
        Me.TxtBuscarArticulos.Location = New System.Drawing.Point(17, 23)
        Me.TxtBuscarArticulos.Name = "TxtBuscarArticulos"
        Me.TxtBuscarArticulos.Size = New System.Drawing.Size(474, 20)
        Me.TxtBuscarArticulos.TabIndex = 12
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtTotal.Location = New System.Drawing.Point(697, 321)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 17
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(697, 293)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.ReadOnly = True
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalImpuesto.TabIndex = 16
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(697, 266)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 15
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(24, 75)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(773, 178)
        Me.DgvDetalle.TabIndex = 0
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Label2)
        Me.PanelEx4.Controls.Add(Me.BtnBuscarArticulos)
        Me.PanelEx4.Controls.Add(Me.Label3)
        Me.PanelEx4.Controls.Add(Me.Label4)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Location = New System.Drawing.Point(6, 15)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(809, 335)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub Total"
        '
        'BtnBuscarArticulos
        '
        Me.BtnBuscarArticulos.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBuscarArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarArticulos.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarArticulos.Location = New System.Drawing.Point(357, 6)
        Me.BtnBuscarArticulos.Name = "BtnBuscarArticulos"
        Me.BtnBuscarArticulos.Size = New System.Drawing.Size(98, 49)
        Me.BtnBuscarArticulos.TabIndex = 9
        Me.BtnBuscarArticulos.Text = "Buscar"
        Me.BtnBuscarArticulos.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Iva"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(623, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.TxtNumComprobante)
        Me.GroupBox1.Controls.Add(Me.CboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtIdProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtSerieComprobante)
        Me.GroupBox1.Controls.Add(Me.PanelEx3)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 110)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(706, 63)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 8
        Me.TxtImpuesto.Text = "0.16"
        '
        'TxtNumComprobante
        '
        Me.TxtNumComprobante.Location = New System.Drawing.Point(339, 63)
        Me.TxtNumComprobante.Name = "TxtNumComprobante"
        Me.TxtNumComprobante.Size = New System.Drawing.Size(193, 20)
        Me.TxtNumComprobante.TabIndex = 7
        '
        'CboTipoComprobante
        '
        Me.CboTipoComprobante.FormattingEnabled = True
        Me.CboTipoComprobante.Items.AddRange(New Object() {"Factura", "Boleta", "Ticket"})
        Me.CboTipoComprobante.Location = New System.Drawing.Point(118, 63)
        Me.CboTipoComprobante.Name = "CboTipoComprobante"
        Me.CboTipoComprobante.Size = New System.Drawing.Size(90, 21)
        Me.CboTipoComprobante.TabIndex = 5
        Me.CboTipoComprobante.Text = "Boleta"
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBuscarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(537, 18)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(55, 34)
        Me.BtnBuscarProveedor.TabIndex = 4
        Me.BtnBuscarProveedor.Text = "..."
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = False
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(224, 25)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(308, 20)
        Me.TxtNombreProveedor.TabIndex = 3
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(118, 25)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(90, 20)
        Me.TxtIdProveedor.TabIndex = 2
        '
        'TxtSerieComprobante
        '
        Me.TxtSerieComprobante.Location = New System.Drawing.Point(224, 63)
        Me.TxtSerieComprobante.Name = "TxtSerieComprobante"
        Me.TxtSerieComprobante.Size = New System.Drawing.Size(99, 20)
        Me.TxtSerieComprobante.TabIndex = 6
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Label1)
        Me.PanelEx3.Controls.Add(Me.LblCodigo)
        Me.PanelEx3.Controls.Add(Me.LblCategoria)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Location = New System.Drawing.Point(6, 14)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(809, 90)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Impuesto"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(28, 56)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(70, 13)
        Me.LblCodigo.TabIndex = 14
        Me.LblCodigo.Text = "Comprobante"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(29, 14)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(69, 13)
        Me.LblCategoria.TabIndex = 17
        Me.LblCategoria.Text = "Proveedor (*)"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Label9)
        Me.PanelEx2.Controls.Add(Me.TxtId)
        Me.PanelEx2.Controls.Add(Me.BtnCancelar)
        Me.PanelEx2.Controls.Add(Me.BtnInsertar)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(-4, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(982, 618)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(373, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 29)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "REALIZAR COMPRA"
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(-4, 0)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(986, 650)
        Me.TabGeneral.TabIndex = 2
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 634)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmIngreso"
        Me.Text = "Compras"
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelArticulos.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.TabGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAnular As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBuscarArticulos As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents TxtNumComprobante As TextBox
    Friend WithEvents CboTipoComprobante As ComboBox
    Friend WithEvents BtnBuscarProveedor As Button
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents TxtSerieComprobante As TextBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents LblTotalArticulos As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnBuscarArticulosDetalle As Button
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents TxtBuscarArticulos As TextBox
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents BtnCerrarM As Button
    Friend WithEvents LblTotalM As Label
    Friend WithEvents LblTotalImpuestoM As Label
    Friend WithEvents LblSubTotalM As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label9 As Label
End Class
