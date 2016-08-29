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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbo_PMenu = New System.Windows.Forms.ComboBox()
        Me.Btn_Confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Your Race"
        '
        'Cbo_PMenu
        '
        Me.Cbo_PMenu.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PMenu.FormattingEnabled = True
        Me.Cbo_PMenu.Items.AddRange(New Object() {"Elf", "Giant", "Human"})
        Me.Cbo_PMenu.Location = New System.Drawing.Point(16, 44)
        Me.Cbo_PMenu.Name = "Cbo_PMenu"
        Me.Cbo_PMenu.Size = New System.Drawing.Size(146, 26)
        Me.Cbo_PMenu.TabIndex = 1
        '
        'Btn_Confirm
        '
        Me.Btn_Confirm.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Confirm.Location = New System.Drawing.Point(206, 44)
        Me.Btn_Confirm.Name = "Btn_Confirm"
        Me.Btn_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Confirm.TabIndex = 2
        Me.Btn_Confirm.Text = "Confirm"
        Me.Btn_Confirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(293, 105)
        Me.Controls.Add(Me.Btn_Confirm)
        Me.Controls.Add(Me.Cbo_PMenu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mabinogi CP Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cbo_PMenu As ComboBox
    Friend WithEvents Btn_Confirm As Button
End Class
