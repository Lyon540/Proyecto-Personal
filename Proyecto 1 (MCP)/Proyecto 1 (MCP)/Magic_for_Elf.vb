Public Class Magic_for_Elf
    Private Sub Btn_Confirm_MagMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_MagMElf.Click
        MagMElfSkill = 0
        MagMElfStat = 0
        Select Case Cbo_MagMElf.SelectedIndex
            'Beggin with the Magic Mastery Skill for Elf'
            'Skill & Stat Changes with races (Giants Only, Human/Elf is the same)'
            Case 0
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 0
                    MagMElfStat = MagMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 0
                    MagMElfStat = MagMElfStat + 5
                End If
            Case 2
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 10
                    MagMElfStat = MagMElfStat + 10
                End If
            Case 3
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 30
                    MagMElfStat = MagMElfStat + 15
                End If
            Case 4
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 60
                    MagMElfStat = MagMElfStat + 20
                End If
            Case 5
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 120
                    MagMElfStat = MagMElfStat + 25
                End If
            Case 6
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 180
                    MagMElfStat = MagMElfStat + 30
                End If
        End Select
    End Sub
End Class