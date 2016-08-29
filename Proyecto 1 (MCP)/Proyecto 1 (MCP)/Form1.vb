Public Class Form1
    Private Sub Btn_Confirm_Click(sender As Object, e As EventArgs) Handles Btn_Confirm.Click
        Select Case Cbo_PMenu.SelectedIndex
            'Elf Windows Display'
            Case 0
                If Btn_Confirm.Created Then
                    Me.Hide()
                    Elf_Skills.Show()
                End If
        End Select
    End Sub
End Class
