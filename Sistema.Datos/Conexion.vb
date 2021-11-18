Imports System.Data.SqlClient
Public Class Conexion
    Public conn As SqlConnection

    Public Sub New()
        Me.conn = New SqlConnection("Data Source=DESKTOP-OVTO4Q7\SQLEXPRESS01;Initial Catalog=dbSistema;User ID=sa;Password=123456")
    End Sub

End Class
