Public Class Elf_Skills
    Private Sub Btn_CCElf_Click(sender As Object, e As EventArgs) Handles Btn_CCElf.Click
        Me.Hide()
        Elf_Close_Combat_Skills.Show()
    End Sub
    Private Sub Btn_ArchElf_Click(sender As Object, e As EventArgs) Handles Btn_ArchElf.Click
        Me.Hide()
        Archery_for_Elf.Show()
    End Sub
End Class