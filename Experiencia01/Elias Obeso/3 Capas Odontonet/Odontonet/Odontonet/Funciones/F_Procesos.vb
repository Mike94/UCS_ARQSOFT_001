Imports Oracle.DataAccess.Client
Public Class F_Procesos
    Inherits F_Conexion 'Heredamos toda la clase conexion
    Dim cmd As New OracleCommand
    Dim dt As New DataTable
    Public Function Logeo() As DataTable
        Try
            FnConectado()
            cmd = New OracleCommand("ELIAS.LOGE")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("p_lista", OracleDbType.RefCursor).Direction = ParameterDirection.Output
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then 'Si la consulta retorno datos
                dt.Clear()
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Donet")
            Return Nothing
        End Try
    End Function
    Public Function Lista_Tipo_User() As DataTable
        Try
            FnConectado()
            cmd = New OracleCommand("ELIAS.LISTXTIPO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("P_LISTA", OracleDbType.RefCursor).Direction = ParameterDirection.Output
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then 'Si la consulta retorno datos
                dt.Clear()
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Donet")
            Return Nothing
        End Try
    End Function
    Public Function InsertarPersonas(ByVal dt As Vpersonas) As Boolean
        Try
            FnConectado()
            cmd = New OracleCommand("ELIAS.PERSO_ING")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("v_per_dni", dt.gdni)
            cmd.Parameters.Add("v_per_nom", dt.gnom)
            cmd.Parameters.Add("v_per_ape", dt.gape)
            cmd.Parameters.Add("v_per_fech", dt.gfec)
            cmd.Parameters.Add("v_per_tip_fk", dt.gtip)
            cmd.Parameters.Add("v_per_foto", dt.gfot)
            cmd.Parameters.Add("v_usu_cod", dt.gcod)
            cmd.Parameters.Add("v_usu_pwd", dt.gpwd)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Odonet")
            Return False
        Finally
        End Try
    End Function
End Class
