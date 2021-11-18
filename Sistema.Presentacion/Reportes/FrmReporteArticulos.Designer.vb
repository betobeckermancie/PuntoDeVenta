<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteArticulos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.articulo_listarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSistema = New Sistema.Presentacion.DsSistema()
        Me.articulo_listarTableAdapter = New Sistema.Presentacion.DsSistemaTableAdapters.articulo_listarTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.articulo_listarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'articulo_listarBindingSource
        '
        Me.articulo_listarBindingSource.DataMember = "articulo_listar"
        Me.articulo_listarBindingSource.DataSource = Me.DsSistema
        '
        'DsSistema
        '
        Me.DsSistema.DataSetName = "DsSistema"
        Me.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'articulo_listarTableAdapter
        '
        Me.articulo_listarTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer2.DocumentMapWidth = 8
        ReportDataSource1.Name = "DsArticulo"
        ReportDataSource1.Value = Me.articulo_listarBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.RptArticulos.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(829, 563)
        Me.ReportViewer2.TabIndex = 1
        '
        'FrmReporteArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 563)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "FrmReporteArticulos"
        Me.Text = "Reporte"
        CType(Me.articulo_listarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents articulo_listarBindingSource As BindingSource
    Friend WithEvents DsSistema As DsSistema
    Friend WithEvents articulo_listarTableAdapter As DsSistemaTableAdapters.articulo_listarTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
