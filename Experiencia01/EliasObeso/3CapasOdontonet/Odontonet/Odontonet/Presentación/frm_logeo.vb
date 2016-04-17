Public Class frm_logeo
    Dim dt As New DataTable
    Dim dv As New DataView
    Sub Mostrar()
        Try
            Dim fnc As New F_Procesos
            dt = fnc.Logeo
            If dt.Rows.Count > 0 Then
                dv = dt.DefaultView
                dv.RowFilter = "USE_COD= '" & Me.TextBox1.Text & "' AND USE_PWD='" & Me.TextBox2.Text & "'"
                If dv.Count > 0 Then
                    MsgBox("Bienvenido " & dv.Item(0)(2), MsgBoxStyle.Information, "Odonet")
                    Dim frm As New frm_MantUsu
                    frm.Show()
                    Me.Close()
                Else
                    MsgBox("Usuario incorrecto", MsgBoxStyle.Information, "Odonet")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mostrar()
    End Sub
End Class
