Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Añadir_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=. ; database=Anime ; integrated security = true")
        conexion.Open()
        Dim descri As String = TextBox1.Text
        Dim precio As String = TextBox2.Text
        Dim cadena As String = "insert into articulos(descripcion,precio) values ('" & descri & "'," & precio & ")"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        MessageBox.Show("Los datos se guardaron correctamente")
        TextBox1.Text = ""
        TextBox2.Text = ""
        conexion.Close()
        'http://www.tutorialesprogramacionya.com/'
    End Sub
End Class
