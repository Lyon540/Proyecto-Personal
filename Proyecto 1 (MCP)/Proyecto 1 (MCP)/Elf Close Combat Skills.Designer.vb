<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elf_Close_Combat_Skills
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cbo_CMElf = New System.Windows.Forms.ComboBox()
        Me.Btn_Confirm_CMElf = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_1__MCP_.My.Resources.Resources.Combat_Mastery
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Cbo_CMElf
        '
        Me.Cbo_CMElf.FormattingEnabled = True
        Me.Cbo_CMElf.Items.AddRange(New Object() {"Rank F", "Rank E", "Rank D", "Rank C", "Rank B", "Rank A", "Rank 9", "Rank 8", "Rank 7", "Rank 6", "Rank 5", "Rank 4", "Rank 3", "Rank 2", "Rank 1"})
        Me.Cbo_CMElf.Location = New System.Drawing.Point(62, 32)
        Me.Cbo_CMElf.Name = "Cbo_CMElf"
        Me.Cbo_CMElf.Size = New System.Drawing.Size(66, 21)
        Me.Cbo_CMElf.TabIndex = 1
        '
        'Btn_Confirm_CMElf
        '
        Me.Btn_Confirm_CMElf.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Confirm_CMElf.Location = New System.Drawing.Point(149, 30)
        Me.Btn_Confirm_CMElf.Name = "Btn_Confirm_CMElf"
        Me.Btn_Confirm_CMElf.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Confirm_CMElf.TabIndex = 2
        Me.Btn_Confirm_CMElf.Text = "Confirm"
        Me.Btn_Confirm_CMElf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Elf_Close_Combat_Skills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 481)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Confirm_CMElf)
        Me.Controls.Add(Me.Cbo_CMElf)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Elf_Close_Combat_Skills"
        Me.Text = "Elf_Close_Combat_Skills"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cbo_CMElf As ComboBox
    Friend WithEvents Btn_Confirm_CMElf As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
