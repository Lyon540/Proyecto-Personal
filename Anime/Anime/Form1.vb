Imports System.Data.SqlClient
Public Class Form1
    Sub Limpiar()
        Txt_Nombre.Text = ""
        Cbo_Gen.SelectedItem = ""
        Txt_Capitulos.Text = ""
        Cbo_Temp.SelectedItem = ""
        Txt_Descripcion.Text = ""
        Txt_Lanzamiento.Text = ""
        Cbo_Subtitulada.SelectedItem = ""
        Cbo_Doblada.SelectedItem = ""
        Cbo_Recom.SelectedItem = ""
        Cbo_Edo.SelectedItem = ""
        Cbo_Stat_Serie.SelectedItem = ""
        Txt_URL.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Btn_Añadir_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click
        Dim conec As New SqlConnection("Data Source=DESKTOP-MF3O32O\LYON ;Initial Catalog=Anime ;Integrated Security=True")
        Try
            conec.Open()
            Dim cmd As New SqlCommand("SP_Ingresar", conec)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd
                .Parameters.AddWithValue("@Nombre", Me.Txt_Nombre.Text)
                .Parameters.AddWithValue("@Genero", Me.Cbo_Gen.SelectedItem)
                .Parameters.AddWithValue("@Capitulos", Me.Txt_Capitulos.Text)
                .Parameters.AddWithValue("@Temporada", Me.Cbo_Temp.SelectedItem)
                .Parameters.AddWithValue("@Descripcion", Me.Txt_Descripcion.Text)
                .Parameters.AddWithValue("@Año_Lanzamiento", Me.Txt_Lanzamiento.Text)
                .Parameters.AddWithValue("@Subtitulada", Me.Cbo_Subtitulada.SelectedItem)
                .Parameters.AddWithValue("@Doblada", Me.Cbo_Doblada.SelectedItem)
                .Parameters.AddWithValue("@Recomendado", Me.Cbo_Recom.SelectedItem)
                .Parameters.AddWithValue("@Estado", Me.Cbo_Edo.SelectedItem)
                .Parameters.AddWithValue("@Stat_Serie", Me.Cbo_Stat_Serie.SelectedItem)
                .Parameters.AddWithValue("@URL", Me.Txt_URL.Text)

                .ExecuteNonQuery()
            End With
            MsgBox("El registro fue agregado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guardar")
            conec.Close()
            Call Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim DA As New SqlDataAdapter("SP_Actualizar", conec)
        Dim DS As New DataSet
        DA.Fill(DS, "Anime_Visto")
        DataGridView1.DataSource = DS.Tables("Anime_Visto")

        'http://www.tutorialesprogramacionya.com/'
    End Sub
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Txt_URL_TextChanged(sender As Object, e As EventArgs)
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(Txt_URL.Text)))
    End Sub

End Class
