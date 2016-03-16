Imports Oracle.DataAccess.Client
Public Class F_Conexion
    Protected cnn As OracleConnection
    Public Function FnConectado()
        Try
            cnn = New OracleConnection("Data Source=XE;User ID=system;Password=123")
            cnn.Open()
            'MsgBox("Te has conectado a la base de datos", MsgBoxStyle.Information, "Donet")
            Return True
        Catch ex As Exception
            MsgBox("Error al conectarse  a la base de datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

End Class
