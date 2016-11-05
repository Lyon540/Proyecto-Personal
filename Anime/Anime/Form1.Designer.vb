<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Cbo_Stat_Serie = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Cbo_Temp = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Cbo_Doblada = New System.Windows.Forms.ComboBox()
        Me.Cbo_Subtitulada = New System.Windows.Forms.ComboBox()
        Me.Cbo_Recom = New System.Windows.Forms.ComboBox()
        Me.Cbo_Edo = New System.Windows.Forms.ComboBox()
        Me.Btn_Añadir = New System.Windows.Forms.Button()
        Me.Txt_Lanzamiento = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Capitulos = New System.Windows.Forms.TextBox()
        Me.Cbo_Gen3 = New System.Windows.Forms.ComboBox()
        Me.Cbo_Gen2 = New System.Windows.Forms.ComboBox()
        Me.Cbo_Gen1 = New System.Windows.Forms.ComboBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.AnimeDataSet = New Anime.AnimeDataSet()
        Me.AnimeVistoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Anime_VistoTableAdapter = New Anime.AnimeDataSetTableAdapters.Anime_VistoTableAdapter()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemporadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLanzamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtituladaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobladaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecomendadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatSerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.ComboBox16 = New System.Windows.Forms.ComboBox()
        Me.ComboBox17 = New System.Windows.Forms.ComboBox()
        Me.ComboBox18 = New System.Windows.Forms.ComboBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimeVistoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(890, 209)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Txt_URL)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Cbo_Stat_Serie)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Cbo_Temp)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Cbo_Doblada)
        Me.TabPage1.Controls.Add(Me.Cbo_Subtitulada)
        Me.TabPage1.Controls.Add(Me.Cbo_Recom)
        Me.TabPage1.Controls.Add(Me.Cbo_Edo)
        Me.TabPage1.Controls.Add(Me.Btn_Añadir)
        Me.TabPage1.Controls.Add(Me.Txt_Lanzamiento)
        Me.TabPage1.Controls.Add(Me.Txt_Descripcion)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Txt_Capitulos)
        Me.TabPage1.Controls.Add(Me.Cbo_Gen3)
        Me.TabPage1.Controls.Add(Me.Cbo_Gen2)
        Me.TabPage1.Controls.Add(Me.Cbo_Gen1)
        Me.TabPage1.Controls.Add(Me.Txt_Nombre)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(882, 183)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Añadir Anime"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(720, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Txt_URL
        '
        Me.Txt_URL.Location = New System.Drawing.Point(721, 38)
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.Size = New System.Drawing.Size(99, 20)
        Me.Txt_URL.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(619, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "URL de Imagen"
        '
        'Cbo_Stat_Serie
        '
        Me.Cbo_Stat_Serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Stat_Serie.FormattingEnabled = True
        Me.Cbo_Stat_Serie.Items.AddRange(New Object() {"", "En Emision", "Concluido"})
        Me.Cbo_Stat_Serie.Location = New System.Drawing.Point(721, 12)
        Me.Cbo_Stat_Serie.Name = "Cbo_Stat_Serie"
        Me.Cbo_Stat_Serie.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_Stat_Serie.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(619, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Estado de la Serie"
        '
        'Cbo_Temp
        '
        Me.Cbo_Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Temp.FormattingEnabled = True
        Me.Cbo_Temp.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.Cbo_Temp.Location = New System.Drawing.Point(74, 145)
        Me.Cbo_Temp.Name = "Cbo_Temp"
        Me.Cbo_Temp.Size = New System.Drawing.Size(67, 21)
        Me.Cbo_Temp.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Temporada"
        '
        'Cbo_Doblada
        '
        Me.Cbo_Doblada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Doblada.FormattingEnabled = True
        Me.Cbo_Doblada.Items.AddRange(New Object() {"", "Español", "Ingles", "Japones (Original)"})
        Me.Cbo_Doblada.Location = New System.Drawing.Point(374, 91)
        Me.Cbo_Doblada.Name = "Cbo_Doblada"
        Me.Cbo_Doblada.Size = New System.Drawing.Size(99, 21)
        Me.Cbo_Doblada.TabIndex = 28
        '
        'Cbo_Subtitulada
        '
        Me.Cbo_Subtitulada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Subtitulada.FormattingEnabled = True
        Me.Cbo_Subtitulada.Items.AddRange(New Object() {"", "Español", "Ingles"})
        Me.Cbo_Subtitulada.Location = New System.Drawing.Point(374, 64)
        Me.Cbo_Subtitulada.Name = "Cbo_Subtitulada"
        Me.Cbo_Subtitulada.Size = New System.Drawing.Size(99, 21)
        Me.Cbo_Subtitulada.TabIndex = 27
        '
        'Cbo_Recom
        '
        Me.Cbo_Recom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Recom.FormattingEnabled = True
        Me.Cbo_Recom.Items.AddRange(New Object() {"", "Si", "Quizas", "No del todo", "No"})
        Me.Cbo_Recom.Location = New System.Drawing.Point(374, 118)
        Me.Cbo_Recom.Name = "Cbo_Recom"
        Me.Cbo_Recom.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_Recom.TabIndex = 26
        '
        'Cbo_Edo
        '
        Me.Cbo_Edo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Edo.FormattingEnabled = True
        Me.Cbo_Edo.Items.AddRange(New Object() {"", "Visto", "No Visto", "Iniciado", "Casi terminado"})
        Me.Cbo_Edo.Location = New System.Drawing.Point(374, 145)
        Me.Cbo_Edo.Name = "Cbo_Edo"
        Me.Cbo_Edo.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_Edo.TabIndex = 25
        '
        'Btn_Añadir
        '
        Me.Btn_Añadir.Location = New System.Drawing.Point(622, 143)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Añadir.TabIndex = 2
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Txt_Lanzamiento
        '
        Me.Txt_Lanzamiento.Location = New System.Drawing.Point(374, 38)
        Me.Txt_Lanzamiento.Name = "Txt_Lanzamiento"
        Me.Txt_Lanzamiento.Size = New System.Drawing.Size(99, 20)
        Me.Txt_Lanzamiento.TabIndex = 21
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Location = New System.Drawing.Point(374, 12)
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(198, 20)
        Me.Txt_Descripcion.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(272, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Recomendado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Doblada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Subtitulada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha Lanzamiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Descripcion"
        '
        'Txt_Capitulos
        '
        Me.Txt_Capitulos.Location = New System.Drawing.Point(74, 119)
        Me.Txt_Capitulos.Name = "Txt_Capitulos"
        Me.Txt_Capitulos.Size = New System.Drawing.Size(67, 20)
        Me.Txt_Capitulos.TabIndex = 13
        '
        'Cbo_Gen3
        '
        Me.Cbo_Gen3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Gen3.FormattingEnabled = True
        Me.Cbo_Gen3.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.Cbo_Gen3.Location = New System.Drawing.Point(74, 92)
        Me.Cbo_Gen3.Name = "Cbo_Gen3"
        Me.Cbo_Gen3.Size = New System.Drawing.Size(82, 21)
        Me.Cbo_Gen3.TabIndex = 12
        '
        'Cbo_Gen2
        '
        Me.Cbo_Gen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Gen2.FormattingEnabled = True
        Me.Cbo_Gen2.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.Cbo_Gen2.Location = New System.Drawing.Point(74, 65)
        Me.Cbo_Gen2.Name = "Cbo_Gen2"
        Me.Cbo_Gen2.Size = New System.Drawing.Size(82, 21)
        Me.Cbo_Gen2.TabIndex = 11
        '
        'Cbo_Gen1
        '
        Me.Cbo_Gen1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Gen1.FormattingEnabled = True
        Me.Cbo_Gen1.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.Cbo_Gen1.Location = New System.Drawing.Point(74, 38)
        Me.Cbo_Gen1.Name = "Cbo_Gen1"
        Me.Cbo_Gen1.Size = New System.Drawing.Size(82, 21)
        Me.Cbo_Gen1.TabIndex = 10
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(74, 12)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(157, 20)
        Me.Txt_Nombre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Capitulos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Genero 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Genero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Genero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.ComboBox5)
        Me.TabPage3.Controls.Add(Me.ComboBox6)
        Me.TabPage3.Controls.Add(Me.Btn_Buscar)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.ComboBox9)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(882, 183)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Buscar Anime"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.ComboBox10)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.ComboBox11)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.ComboBox12)
        Me.TabPage2.Controls.Add(Me.ComboBox13)
        Me.TabPage2.Controls.Add(Me.ComboBox14)
        Me.TabPage2.Controls.Add(Me.ComboBox15)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.TextBox8)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.ComboBox16)
        Me.TabPage2.Controls.Add(Me.ComboBox17)
        Me.TabPage2.Controls.Add(Me.ComboBox18)
        Me.TabPage2.Controls.Add(Me.TextBox10)
        Me.TabPage2.Controls.Add(Me.Label38)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 183)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificar Anime"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Genero1DataGridViewTextBoxColumn, Me.Genero2DataGridViewTextBoxColumn, Me.Genero3DataGridViewTextBoxColumn, Me.CapitulosDataGridViewTextBoxColumn, Me.TemporadaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaLanzamientoDataGridViewTextBoxColumn, Me.SubtituladaDataGridViewTextBoxColumn, Me.DobladaDataGridViewTextBoxColumn, Me.RecomendadoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.StatSerieDataGridViewTextBoxColumn, Me.URLDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AnimeVistoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 255)
        Me.DataGridView1.TabIndex = 2
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(804, 487)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'AnimeDataSet
        '
        Me.AnimeDataSet.DataSetName = "AnimeDataSet"
        Me.AnimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnimeVistoBindingSource
        '
        Me.AnimeVistoBindingSource.DataMember = "Anime_Visto"
        Me.AnimeVistoBindingSource.DataSource = Me.AnimeDataSet
        '
        'Anime_VistoTableAdapter
        '
        Me.Anime_VistoTableAdapter.ClearBeforeFill = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Genero1DataGridViewTextBoxColumn
        '
        Me.Genero1DataGridViewTextBoxColumn.DataPropertyName = "Genero_1"
        Me.Genero1DataGridViewTextBoxColumn.HeaderText = "Genero_1"
        Me.Genero1DataGridViewTextBoxColumn.Name = "Genero1DataGridViewTextBoxColumn"
        '
        'Genero2DataGridViewTextBoxColumn
        '
        Me.Genero2DataGridViewTextBoxColumn.DataPropertyName = "Genero_2"
        Me.Genero2DataGridViewTextBoxColumn.HeaderText = "Genero_2"
        Me.Genero2DataGridViewTextBoxColumn.Name = "Genero2DataGridViewTextBoxColumn"
        '
        'Genero3DataGridViewTextBoxColumn
        '
        Me.Genero3DataGridViewTextBoxColumn.DataPropertyName = "Genero_3"
        Me.Genero3DataGridViewTextBoxColumn.HeaderText = "Genero_3"
        Me.Genero3DataGridViewTextBoxColumn.Name = "Genero3DataGridViewTextBoxColumn"
        '
        'CapitulosDataGridViewTextBoxColumn
        '
        Me.CapitulosDataGridViewTextBoxColumn.DataPropertyName = "Capitulos"
        Me.CapitulosDataGridViewTextBoxColumn.HeaderText = "Capitulos"
        Me.CapitulosDataGridViewTextBoxColumn.Name = "CapitulosDataGridViewTextBoxColumn"
        '
        'TemporadaDataGridViewTextBoxColumn
        '
        Me.TemporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada"
        Me.TemporadaDataGridViewTextBoxColumn.HeaderText = "Temporada"
        Me.TemporadaDataGridViewTextBoxColumn.Name = "TemporadaDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'FechaLanzamientoDataGridViewTextBoxColumn
        '
        Me.FechaLanzamientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Lanzamiento"
        Me.FechaLanzamientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Lanzamiento"
        Me.FechaLanzamientoDataGridViewTextBoxColumn.Name = "FechaLanzamientoDataGridViewTextBoxColumn"
        '
        'SubtituladaDataGridViewTextBoxColumn
        '
        Me.SubtituladaDataGridViewTextBoxColumn.DataPropertyName = "Subtitulada"
        Me.SubtituladaDataGridViewTextBoxColumn.HeaderText = "Subtitulada"
        Me.SubtituladaDataGridViewTextBoxColumn.Name = "SubtituladaDataGridViewTextBoxColumn"
        '
        'DobladaDataGridViewTextBoxColumn
        '
        Me.DobladaDataGridViewTextBoxColumn.DataPropertyName = "Doblada"
        Me.DobladaDataGridViewTextBoxColumn.HeaderText = "Doblada"
        Me.DobladaDataGridViewTextBoxColumn.Name = "DobladaDataGridViewTextBoxColumn"
        '
        'RecomendadoDataGridViewTextBoxColumn
        '
        Me.RecomendadoDataGridViewTextBoxColumn.DataPropertyName = "Recomendado"
        Me.RecomendadoDataGridViewTextBoxColumn.HeaderText = "Recomendado"
        Me.RecomendadoDataGridViewTextBoxColumn.Name = "RecomendadoDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'StatSerieDataGridViewTextBoxColumn
        '
        Me.StatSerieDataGridViewTextBoxColumn.DataPropertyName = "Stat_Serie"
        Me.StatSerieDataGridViewTextBoxColumn.HeaderText = "Stat_Serie"
        Me.StatSerieDataGridViewTextBoxColumn.Name = "StatSerieDataGridViewTextBoxColumn"
        '
        'URLDataGridViewTextBoxColumn
        '
        Me.URLDataGridViewTextBoxColumn.DataPropertyName = "URL"
        Me.URLDataGridViewTextBoxColumn.HeaderText = "URL"
        Me.URLDataGridViewTextBoxColumn.Name = "URLDataGridViewTextBoxColumn"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(555, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "En Emision", "Concluido"})
        Me.ComboBox1.Location = New System.Drawing.Point(109, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Estado de la Serie"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox2.Location = New System.Drawing.Point(109, 92)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox2.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Temporada"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"", "Si", "Quizas", "No del todo", "No"})
        Me.ComboBox5.Location = New System.Drawing.Point(389, 13)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 56
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"", "Visto", "No Visto", "Iniciado", "Casi terminado"})
        Me.ComboBox6.Location = New System.Drawing.Point(389, 40)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 55
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Location = New System.Drawing.Point(555, 144)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buscar.TabIndex = 37
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 146)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 20)
        Me.TextBox2.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(287, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Estado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(287, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Recomendado"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 149)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 13)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Fecha Lanzamiento"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(109, 65)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(67, 20)
        Me.TextBox4.TabIndex = 46
        '
        'ComboBox9
        '
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.ComboBox9.Location = New System.Drawing.Point(109, 39)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox9.TabIndex = 43
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(109, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(157, 20)
        Me.TextBox5.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 69)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Capitulos"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 42)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Genero"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(44, 13)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Nombre"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(720, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(721, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(99, 20)
        Me.TextBox6.TabIndex = 64
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(619, 42)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 13)
        Me.Label29.TabIndex = 63
        Me.Label29.Text = "URL de Imagen"
        '
        'ComboBox10
        '
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"", "En Emision", "Concluido"})
        Me.ComboBox10.Location = New System.Drawing.Point(721, 13)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox10.TabIndex = 62
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(619, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 13)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = "Estado de la Serie"
        '
        'ComboBox11
        '
        Me.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox11.Location = New System.Drawing.Point(74, 146)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox11.TabIndex = 60
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 149)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 13)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "Temporada"
        '
        'ComboBox12
        '
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"", "Español", "Ingles", "Japones (Original)"})
        Me.ComboBox12.Location = New System.Drawing.Point(374, 92)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox12.TabIndex = 58
        '
        'ComboBox13
        '
        Me.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Items.AddRange(New Object() {"", "Español", "Ingles"})
        Me.ComboBox13.Location = New System.Drawing.Point(374, 65)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox13.TabIndex = 57
        '
        'ComboBox14
        '
        Me.ComboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox14.FormattingEnabled = True
        Me.ComboBox14.Items.AddRange(New Object() {"", "Si", "Quizas", "No del todo", "No"})
        Me.ComboBox14.Location = New System.Drawing.Point(374, 119)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox14.TabIndex = 56
        '
        'ComboBox15
        '
        Me.ComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Items.AddRange(New Object() {"", "Visto", "No Visto", "Iniciado", "Casi terminado"})
        Me.ComboBox15.Location = New System.Drawing.Point(374, 146)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox15.TabIndex = 55
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(622, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Añadir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(374, 39)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(99, 20)
        Me.TextBox7.TabIndex = 54
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(374, 13)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(198, 20)
        Me.TextBox8.TabIndex = 53
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(272, 149)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 13)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Estado"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(272, 122)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 13)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Recomendado"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(272, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 50
        Me.Label34.Text = "Doblada"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(272, 68)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 13)
        Me.Label35.TabIndex = 49
        Me.Label35.Text = "Subtitulada"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(272, 42)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(100, 13)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = "Fecha Lanzamiento"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(272, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 13)
        Me.Label37.TabIndex = 47
        Me.Label37.Text = "Descripcion"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(74, 120)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(67, 20)
        Me.TextBox9.TabIndex = 46
        '
        'ComboBox16
        '
        Me.ComboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox16.FormattingEnabled = True
        Me.ComboBox16.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.ComboBox16.Location = New System.Drawing.Point(74, 93)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox16.TabIndex = 45
        '
        'ComboBox17
        '
        Me.ComboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox17.FormattingEnabled = True
        Me.ComboBox17.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.ComboBox17.Location = New System.Drawing.Point(74, 66)
        Me.ComboBox17.Name = "ComboBox17"
        Me.ComboBox17.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox17.TabIndex = 44
        '
        'ComboBox18
        '
        Me.ComboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox18.FormattingEnabled = True
        Me.ComboBox18.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.ComboBox18.Location = New System.Drawing.Point(74, 39)
        Me.ComboBox18.Name = "ComboBox18"
        Me.ComboBox18.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox18.TabIndex = 43
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(74, 13)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(157, 20)
        Me.TextBox10.TabIndex = 42
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 123)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(50, 13)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "Capitulos"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 96)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(51, 13)
        Me.Label39.TabIndex = 40
        Me.Label39.Text = "Genero 3"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(7, 69)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(51, 13)
        Me.Label40.TabIndex = 39
        Me.Label40.Text = "Genero 2"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(7, 42)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(51, 13)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "Genero 1"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(7, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(44, 13)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "Nombre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 521)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimeVistoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Cbo_Stat_Serie As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Cbo_Temp As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Cbo_Doblada As ComboBox
    Friend WithEvents Cbo_Subtitulada As ComboBox
    Friend WithEvents Cbo_Recom As ComboBox
    Friend WithEvents Cbo_Edo As ComboBox
    Friend WithEvents Btn_Añadir As Button
    Friend WithEvents Txt_Lanzamiento As TextBox
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Capitulos As TextBox
    Friend WithEvents Cbo_Gen3 As ComboBox
    Friend WithEvents Cbo_Gen2 As ComboBox
    Friend WithEvents Cbo_Gen1 As ComboBox
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents AnimeDataSet As AnimeDataSet
    Friend WithEvents AnimeVistoBindingSource As BindingSource
    Friend WithEvents Anime_VistoTableAdapter As AnimeDataSetTableAdapters.Anime_VistoTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitulosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemporadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaLanzamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtituladaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobladaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecomendadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatSerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents URLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents ComboBox15 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents ComboBox16 As ComboBox
    Friend WithEvents ComboBox17 As ComboBox
    Friend WithEvents ComboBox18 As ComboBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
End Class
