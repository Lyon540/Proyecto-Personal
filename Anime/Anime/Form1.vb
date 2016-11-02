Imports System.Data.SqlClient

Public Class Form1
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Añadir_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click
        Dim conec As New SqlConnection("Data Source=DEVBECARIOS1-PC\DBECARIOS ;Initial Catalog=Anime ;Integrated Security=True")
        Try
            conec.Open()
            Dim cmd As New SqlCommand("SP_Ingresar", conec)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd
                .Parameters.AddWithValue("@Nombre", Me.Txt_Nombre.Text)
                .Parameters.AddWithValue("@Genero_1", Me.Cbo_Gen1.SelectedItem)
                .Parameters.AddWithValue("@Genero_2", Me.Cbo_Gen2.SelectedItem)
                .Parameters.AddWithValue("@Genero_3", Me.Cbo_Gen3.SelectedItem)
                .Parameters.AddWithValue("@Capitulos", Me.Txt_Capitulos.Text)
                .Parameters.AddWithValue("@Descripcion", Me.Txt_Descripcion.Text)
                .Parameters.AddWithValue("@Fecha_Lanzamiento", Me.Txt_Lanzamiento.Text)
                .Parameters.AddWithValue("@Subtitulada", Me.Cbo_Subtitulada.SelectedItem)
                .Parameters.AddWithValue("@Doblada", Me.Cbo_Doblada.SelectedItem)
                .Parameters.AddWithValue("@Recomendado", Me.Cbo_Recom.SelectedItem)
                .Parameters.AddWithValue("@Estado", Me.Cbo_Edo.SelectedItem)

                .ExecuteNonQuery()
            End With
            MsgBox("El registro fue agregado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guardar")
            conec.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'http://www.tutorialesprogramacionya.com/'

    End Sub
End Class
