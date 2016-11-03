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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLanzamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtituladaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobladaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecomendadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimeVistoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimeDataSet = New Anime.AnimeDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Anime_VistoTableAdapter = New Anime.AnimeDataSetTableAdapters.Anime_VistoTableAdapter()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitulosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLanzamientoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtituladaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobladaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecomendadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimeVistoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(890, 481)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
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
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(882, 455)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Añadir Anime"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Cbo_Doblada
        '
        Me.Cbo_Doblada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Doblada.FormattingEnabled = True
        Me.Cbo_Doblada.Items.AddRange(New Object() {"", "Español", "Ingles", "Japones (Original)"})
        Me.Cbo_Doblada.Location = New System.Drawing.Point(405, 91)
        Me.Cbo_Doblada.Name = "Cbo_Doblada"
        Me.Cbo_Doblada.Size = New System.Drawing.Size(99, 21)
        Me.Cbo_Doblada.TabIndex = 28
        '
        'Cbo_Subtitulada
        '
        Me.Cbo_Subtitulada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Subtitulada.FormattingEnabled = True
        Me.Cbo_Subtitulada.Items.AddRange(New Object() {"", "Español", "Ingles"})
        Me.Cbo_Subtitulada.Location = New System.Drawing.Point(405, 64)
        Me.Cbo_Subtitulada.Name = "Cbo_Subtitulada"
        Me.Cbo_Subtitulada.Size = New System.Drawing.Size(99, 21)
        Me.Cbo_Subtitulada.TabIndex = 27
        '
        'Cbo_Recom
        '
        Me.Cbo_Recom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Recom.FormattingEnabled = True
        Me.Cbo_Recom.Items.AddRange(New Object() {"", "Si", "Quizas", "No del todo", "No"})
        Me.Cbo_Recom.Location = New System.Drawing.Point(405, 118)
        Me.Cbo_Recom.Name = "Cbo_Recom"
        Me.Cbo_Recom.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_Recom.TabIndex = 26
        '
        'Cbo_Edo
        '
        Me.Cbo_Edo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Edo.FormattingEnabled = True
        Me.Cbo_Edo.Items.AddRange(New Object() {"", "Visto", "No Visto", "Iniciado", "Casi terminado"})
        Me.Cbo_Edo.Location = New System.Drawing.Point(405, 145)
        Me.Cbo_Edo.Name = "Cbo_Edo"
        Me.Cbo_Edo.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_Edo.TabIndex = 25
        '
        'Btn_Añadir
        '
        Me.Btn_Añadir.Location = New System.Drawing.Point(657, 31)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Añadir.TabIndex = 2
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Txt_Lanzamiento
        '
        Me.Txt_Lanzamiento.Location = New System.Drawing.Point(405, 38)
        Me.Txt_Lanzamiento.Name = "Txt_Lanzamiento"
        Me.Txt_Lanzamiento.Size = New System.Drawing.Size(99, 20)
        Me.Txt_Lanzamiento.TabIndex = 21
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Location = New System.Drawing.Point(405, 12)
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(198, 20)
        Me.Txt_Descripcion.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(303, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(303, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Recomendado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(303, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Doblada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(303, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Subtitulada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha Lanzamiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(303, 15)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.Genero1DataGridViewTextBoxColumn, Me.Genero2DataGridViewTextBoxColumn, Me.Genero3DataGridViewTextBoxColumn, Me.CapitulosDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaLanzamientoDataGridViewTextBoxColumn, Me.SubtituladaDataGridViewTextBoxColumn, Me.DobladaDataGridViewTextBoxColumn, Me.RecomendadoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AnimeVistoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(877, 277)
        Me.DataGridView1.TabIndex = 7
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
        'AnimeVistoBindingSource
        '
        Me.AnimeVistoBindingSource.DataMember = "Anime_Visto"
        Me.AnimeVistoBindingSource.DataSource = Me.AnimeDataSet
        '
        'AnimeDataSet
        '
        Me.AnimeDataSet.DataSetName = "AnimeDataSet"
        Me.AnimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TabPage3.Controls.Add(Me.ComboBox4)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.ComboBox3)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(882, 455)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Buscar Anime"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"", "Visto", "No Visto", "Iniciado", "Casi terminado"})
        Me.ComboBox3.Location = New System.Drawing.Point(392, 11)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(290, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Estado"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Español", "Ingles"})
        Me.ComboBox2.Location = New System.Drawing.Point(110, 93)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox2.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Subtitulada"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(67, 20)
        Me.TextBox2.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Capitulos"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Accion", "Lucha", "Aventura", "Carreras", "Ficcion", "Comedia", "Drama", "Demonios", "Deporte", "Ecchi", "Escolares", "Fantasia", "Gore", "Harem", "Horror", "Josei", "Magia", "Mecha", "Militar", "Misterio", "Parodia", "Psicologico", "Reencuentros", "Romance", "Seinen", "Shojo", "Shonen", "Space", "Suspenso", "Sobre Natural", "Supernatural", "Terror", "Vampiros", "Yuri", "Hentai"})
        Me.ComboBox1.Location = New System.Drawing.Point(110, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Genero"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nombre"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn1, Me.Genero1DataGridViewTextBoxColumn1, Me.Genero2DataGridViewTextBoxColumn1, Me.Genero3DataGridViewTextBoxColumn1, Me.CapitulosDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.FechaLanzamientoDataGridViewTextBoxColumn1, Me.SubtituladaDataGridViewTextBoxColumn1, Me.DobladaDataGridViewTextBoxColumn1, Me.RecomendadoDataGridViewTextBoxColumn1, Me.EstadoDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.AnimeVistoBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(3, 175)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(877, 277)
        Me.DataGridView3.TabIndex = 32
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 455)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificar Anime"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 176)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(877, 277)
        Me.DataGridView2.TabIndex = 32
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(810, 484)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Anime_VistoTableAdapter
        '
        Me.Anime_VistoTableAdapter.ClearBeforeFill = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"", "Español", "Ingles", "Japones (Original)"})
        Me.ComboBox4.Location = New System.Drawing.Point(109, 122)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox4.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 125)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Doblada"
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'Genero1DataGridViewTextBoxColumn1
        '
        Me.Genero1DataGridViewTextBoxColumn1.DataPropertyName = "Genero_1"
        Me.Genero1DataGridViewTextBoxColumn1.HeaderText = "Genero_1"
        Me.Genero1DataGridViewTextBoxColumn1.Name = "Genero1DataGridViewTextBoxColumn1"
        '
        'Genero2DataGridViewTextBoxColumn1
        '
        Me.Genero2DataGridViewTextBoxColumn1.DataPropertyName = "Genero_2"
        Me.Genero2DataGridViewTextBoxColumn1.HeaderText = "Genero_2"
        Me.Genero2DataGridViewTextBoxColumn1.Name = "Genero2DataGridViewTextBoxColumn1"
        '
        'Genero3DataGridViewTextBoxColumn1
        '
        Me.Genero3DataGridViewTextBoxColumn1.DataPropertyName = "Genero_3"
        Me.Genero3DataGridViewTextBoxColumn1.HeaderText = "Genero_3"
        Me.Genero3DataGridViewTextBoxColumn1.Name = "Genero3DataGridViewTextBoxColumn1"
        '
        'CapitulosDataGridViewTextBoxColumn1
        '
        Me.CapitulosDataGridViewTextBoxColumn1.DataPropertyName = "Capitulos"
        Me.CapitulosDataGridViewTextBoxColumn1.HeaderText = "Capitulos"
        Me.CapitulosDataGridViewTextBoxColumn1.Name = "CapitulosDataGridViewTextBoxColumn1"
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        '
        'FechaLanzamientoDataGridViewTextBoxColumn1
        '
        Me.FechaLanzamientoDataGridViewTextBoxColumn1.DataPropertyName = "Fecha_Lanzamiento"
        Me.FechaLanzamientoDataGridViewTextBoxColumn1.HeaderText = "Fecha_Lanzamiento"
        Me.FechaLanzamientoDataGridViewTextBoxColumn1.Name = "FechaLanzamientoDataGridViewTextBoxColumn1"
        '
        'SubtituladaDataGridViewTextBoxColumn1
        '
        Me.SubtituladaDataGridViewTextBoxColumn1.DataPropertyName = "Subtitulada"
        Me.SubtituladaDataGridViewTextBoxColumn1.HeaderText = "Subtitulada"
        Me.SubtituladaDataGridViewTextBoxColumn1.Name = "SubtituladaDataGridViewTextBoxColumn1"
        '
        'DobladaDataGridViewTextBoxColumn1
        '
        Me.DobladaDataGridViewTextBoxColumn1.DataPropertyName = "Doblada"
        Me.DobladaDataGridViewTextBoxColumn1.HeaderText = "Doblada"
        Me.DobladaDataGridViewTextBoxColumn1.Name = "DobladaDataGridViewTextBoxColumn1"
        '
        'RecomendadoDataGridViewTextBoxColumn1
        '
        Me.RecomendadoDataGridViewTextBoxColumn1.DataPropertyName = "Recomendado"
        Me.RecomendadoDataGridViewTextBoxColumn1.HeaderText = "Recomendado"
        Me.RecomendadoDataGridViewTextBoxColumn1.Name = "RecomendadoDataGridViewTextBoxColumn1"
        '
        'EstadoDataGridViewTextBoxColumn1
        '
        Me.EstadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn1.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn1.Name = "EstadoDataGridViewTextBoxColumn1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 516)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimeVistoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txt_Lanzamiento As TextBox
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Btn_Añadir As Button
    Friend WithEvents Cbo_Doblada As ComboBox
    Friend WithEvents Cbo_Subtitulada As ComboBox
    Friend WithEvents Cbo_Recom As ComboBox
    Friend WithEvents Cbo_Edo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AnimeDataSet As AnimeDataSet
    Friend WithEvents AnimeVistoBindingSource As BindingSource
    Friend WithEvents Anime_VistoTableAdapter As AnimeDataSetTableAdapters.Anime_VistoTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Genero3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitulosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaLanzamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtituladaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobladaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecomendadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Genero1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Genero2DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Genero3DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CapitulosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaLanzamientoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SubtituladaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DobladaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RecomendadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
