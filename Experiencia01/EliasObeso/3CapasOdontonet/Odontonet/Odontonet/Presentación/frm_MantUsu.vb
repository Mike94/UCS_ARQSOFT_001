Public Class frm_MantUsu
    Dim dtxTipo As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Bitmap |*.bmp| JPG | *.jpg | GIF | *.gif | All Files|*.*"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog1.FileName
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        DateTimePicker1.Value = Date.Today
        ComboBox1.SelectedIndex = 0
        PictureBox1.Image = Nothing
    End Sub

    Private Sub frm_MantUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TipoxUsu()
    End Sub

    Sub TipoxUsu()
        dtxTipo.Clear()
        Try
            Dim fnx As New F_Procesos
            dtxTipo = fnx.Lista_Tipo_User
            ComboBox1.DataSource = dtxTipo
            ComboBox1.DisplayMember = "TIP_DES"
            ComboBox1.ValueMember = "TIP_PER_COD_FK"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim funcion As New F_Procesos 'Capa Datos
            Dim logica As New Vpersonas 'Capa Negocios
            logica.gdni = TextBox1.Text
            logica.gnom = TextBox2.Text
            logica.gape = TextBox3.Text
            logica.gfec = DateTimePicker1.Value
            logica.gtip = ComboBox1.SelectedValue
            logica.gcod = TextBox5.Text
            logica.gpwd = TextBox4.Text
            logica.gfot = PictureBox1
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            logica.gfot = arrImage
            If funcion.InsertarPersonas(logica) Then
                MsgBox("Usuario: " + TextBox5.Text + " Registrado")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class