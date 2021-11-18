<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaVentas
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarM = New System.Windows.Forms.Button()
        Me.LblTotalM = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoM = New System.Windows.Forms.Label()
        Me.LblSubTotalM = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVerComprobante = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.DtFechaFin)
        Me.TabPage1.Controls.Add(Me.DtFechaInicio)
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Controls.Add(Me.PanelEx1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(979, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(356, 24)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaFin.TabIndex = 13
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicio.Location = New System.Drawing.Point(67, 24)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaInicio.TabIndex = 12
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
        Me.PanelMostrar.Location = New System.Drawing.Point(127, 119)
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
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.BtnVerComprobante)
        Me.PanelEx1.Controls.Add(Me.BtnFiltrar)
        Me.PanelEx1.Controls.Add(Me.LblTotal)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(-4, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(981, 592)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Desde:"
        '
        'BtnVerComprobante
        '
        Me.BtnVerComprobante.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnVerComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerComprobante.ForeColor = System.Drawing.Color.White
        Me.BtnVerComprobante.Location = New System.Drawing.Point(835, 8)
        Me.BtnVerComprobante.Name = "BtnVerComprobante"
        Me.BtnVerComprobante.Size = New System.Drawing.Size(134, 47)
        Me.BtnVerComprobante.TabIndex = 9
        Me.BtnVerComprobante.Text = "Comprobante"
        Me.BtnVerComprobante.UseVisualStyleBackColor = False
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrar.Location = New System.Drawing.Point(596, 8)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(134, 47)
        Me.BtnFiltrar.TabIndex = 3
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = False
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(878, 393)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Location = New System.Drawing.Point(-4, 1)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(987, 614)
        Me.TabGeneral.TabIndex = 4
        '
        'FrmConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 516)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmConsultaVentas"
        Me.Text = "Consulta de Ventas Entre Fechas"
        Me.TabPage1.ResumeLayout(False)
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnVerComprobante As Button
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents BtnCerrarM As Button
    Friend WithEvents LblTotalM As Label
    Friend WithEvents LblTotalImpuestoM As Label
    Friend WithEvents LblSubTotalM As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class
